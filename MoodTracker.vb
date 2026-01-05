Imports System.Data.SQLite
Public Class MoodTracker
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property
    Function GetSelectedMood() As String
        ' Loop melalui GroupBox untuk mencari RadioButton yang dipilih
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = CType(ctrl, RadioButton)
                If rb.Checked Then
                    Return rb.Tag.ToString()
                End If
            End If
        Next
        Return ""
    End Function

    Function GetMoodText(moodTag As String) As String
        Select Case moodTag
            Case "very_sad" : Return "Very Sad 😭"
            Case "sad" : Return "Sad 😟"
            Case "neutral" : Return "Neutral 😐"
            Case "good" : Return "Good 🙂"
            Case "happy" : Return "Happy 😀"
            Case "laugh" : Return "Laughing 😂"
            Case "funny" : Return "Funny 😜"
            Case "love" : Return "Loved 😍"
            Case Else : Return "-"
        End Select
    End Function

    Sub ResetMoodForm()
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Checked = False
            End If
        Next
        txtnote.Clear()
        lblmoodpreview.Text = "Today you feel: -"
    End Sub

    Function HasUnsavedData() As Boolean
        ' Cek jika ada note atau jika ada mood yang sudah dipilih tapi belum di-save
        If txtnote.Text <> "" Then Return True
        Return GetSelectedMood() <> ""
    End Function
    Private Sub MoodTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetNavIndicator(Me, "pnlmood")

        lblwelcome.Text = "Welcome, " & CurrentName

        ' Inisialisasi Tag untuk RadioButton sesuai urutan di UI
        rd1.Tag = "very_sad"
        rd2.Tag = "sad"
        rd3.Tag = "neutral"
        rd4.Tag = "good"
        rd5.Tag = "happy"
        rd6.Tag = "laugh"
        rd7.Tag = "funny"
        rd8.Tag = "love"

        lblmoodpreview.Text = "Today you feel: -"
    End Sub
    Private Sub Mood_CheckedChanged(sender As Object, e As EventArgs) Handles _
        rd1.CheckedChanged, rd2.CheckedChanged, rd3.CheckedChanged, rd4.CheckedChanged,
        rd5.CheckedChanged, rd6.CheckedChanged, rd7.CheckedChanged, rd8.CheckedChanged

        Dim moodTag As String = GetSelectedMood()
        If moodTag <> "" Then
            lblmoodpreview.Text = "Today you feel: " & GetMoodText(moodTag)
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim moodValue As String = GetSelectedMood()
        If moodValue = "" Then
            MessageBox.Show("Please select your mood first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Call koneksi()

            ' Menggunakan parameter @ dan SQLite datetime function
            Dim sql As String = "INSERT INTO mood_tracker (account_id, mood, note, created_at) " &
                                "VALUES (@id, @mood, @note, datetime('now','localtime'))"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@id", CurrentID)
                cmd.Parameters.AddWithValue("@mood", moodValue)
                cmd.Parameters.AddWithValue("@note", txtnote.Text)

                cmd.ExecuteNonQuery()
            End Using

            LogActivity("Logged daily mood: " & moodValue)

            MessageBox.Show("Mood saved successfully 💙", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ResetMoodForm()

        Catch ex As Exception
            MessageBox.Show("Failed to save mood: " & ex.Message)
        Finally
            ' STANDAR KEAMANAN: Selalu tutup dan bersihkan pool
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub

    Private Sub btnhistory_Click(sender As Object, e As EventArgs) Handles btnhistory.Click
        Dim frm As New MoodHistory
        frm.ShowDialog()
        ResetMoodForm()
    End Sub

    Private Sub btnfindcounselor_Click(sender As Object, e As EventArgs) Handles btnfindcounselor.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        FindCounselor.Show()
        Me.Hide()
    End Sub

    Private Sub btnuser_Click_1(sender As Object, e As EventArgs) Handles btnuser.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        AccountCenterUser.LoadOverview()
        AccountCenterUser.Show()
        Me.Hide()
    End Sub

    Private Sub btntodo_Click_1(sender As Object, e As EventArgs) Handles btntodo.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        ToDoList.Show()
        Me.Hide()
    End Sub

    Private Sub btnjournal_Click_1(sender As Object, e As EventArgs) Handles btnjournal.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        Journal.Show()
        Me.Hide()
    End Sub

    Private Sub btnfinance_Click_1(sender As Object, e As EventArgs) Handles btnfinance.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        FinanceTracker.Show()
        Me.Hide()
    End Sub

    Private Sub btncounseling_Click_1(sender As Object, e As EventArgs) Handles btncounseling.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        ChatRoom.Show()
        Me.Hide()
    End Sub

    Private Sub btnsignout_Click_1(sender As Object, e As EventArgs) Handles btnsignout.Click
        Dim result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Panggil fungsi pusat di Module
            Call Logout(Me)
        End If
    End Sub
End Class