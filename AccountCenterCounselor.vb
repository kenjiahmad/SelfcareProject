Imports System.Data.SQLite
Public Class AccountCenterCounselor
    Dim originalName As String
    Dim originalBirth As Date
    Dim originalSpecialist As String
    Dim originalBio As String
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property
    Private Function HasUnsavedData() As Boolean
        If Not txtname.Enabled Then Return False

        Return txtname.Text <> originalName _
               OrElse dtbirth.Value.Date <> originalBirth.Date _
               OrElse txtspecialist.Text <> originalSpecialist _
               OrElse txtbio.Text <> originalBio
    End Function
    Sub LoadProfileData()
        Try
            Call koneksi()
            ' Ambil data lengkap counselor termasuk Specialist & Bio
            Dim sql As String = "SELECT name, birth_date, email, specialist, bio FROM account WHERE account_id = @id"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@id", CurrentID)
                Using rd As SQLiteDataReader = cmd.ExecuteReader()
                    If rd.Read() Then
                        txtname.Text = rd("name").ToString()
                        txtemail.Text = rd("email").ToString()
                        dtbirth.Value = If(IsDBNull(rd("birth_date")), Date.Today, Convert.ToDateTime(rd("birth_date")))
                        txtspecialist.Text = rd("specialist").ToString()
                        txtbio.Text = rd("bio").ToString()

                        ' Simpan nilai original untuk deteksi perubahan
                        originalName = txtname.Text
                        originalBirth = dtbirth.Value
                        originalSpecialist = txtspecialist.Text
                        originalBio = txtbio.Text

                        CalculateAge()
                    End If
                End Using
            End Using

            SetEditMode(False)
        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message)
        Finally
            ' STANDAR KEAMANAN [cite: 2026-01-04]
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub

    Sub CalculateAge()
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - dtbirth.Value.Year
        If dtbirth.Value.Date > today.AddYears(-age) Then age -= 1
        txtage.Text = age.ToString()
    End Sub

    Sub SetEditMode(isEdit As Boolean)
        txtname.Enabled = isEdit
        dtbirth.Enabled = isEdit
        txtspecialist.Enabled = isEdit
        txtbio.Enabled = isEdit

        txtemail.Enabled = False ' Email terkunci
        txtage.Enabled = False   ' Umur otomatis

        btnsave.Enabled = isEdit
        btnedit.Enabled = Not isEdit
    End Sub
    Private Sub AccountCenterCounselor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblwelcome.Text = "Counselor Portal: " & CurrentName
        LoadProfileData()
        SetEditMode(False)
        SetNavIndicator(Me, "pnluser")
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        SetEditMode(True)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Call koneksi()
            ' Update data Counselor
            Dim sql As String = "UPDATE account SET name = @name, birth_date = @birth, " &
                                "specialist = @spec, bio = @bio WHERE account_id = @id"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@name", txtname.Text)
                cmd.Parameters.AddWithValue("@birth", dtbirth.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@spec", txtspecialist.Text)
                cmd.Parameters.AddWithValue("@bio", txtbio.Text)
                cmd.Parameters.AddWithValue("@id", CurrentID)

                cmd.ExecuteNonQuery()
            End Using

            LogActivity("Counselor updated their professional profile")
            MessageBox.Show("Profile updated successfully!", "Success")

            CurrentName = txtname.Text
            LoadProfileData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub

    Private Sub dtbirth_ValueChanged(sender As Object, e As EventArgs) Handles dtbirth.ValueChanged
        CalculateAge()
    End Sub

    Private Sub btnsignout_Click(sender As Object, e As EventArgs) Handles btnsignout.Click
        Dim result = MessageBox.Show("Sign out from counselor portal?", "Sign Out",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Panggil fungsi pusat di Module
            Call Logout(Me)
        End If
    End Sub

    Private Sub btnchangepw_Click(sender As Object, e As EventArgs) Handles btnchangepw.Click
        Me.Hide()
        ChangePassword.ShowDialog()
    End Sub

    Private Sub btndelaccount_Click(sender As Object, e As EventArgs) Handles btndelaccount.Click
        Dim result = MessageBox.Show("This will permanently disable your account." & vbCrLf &
                                   "Are you sure you want to continue?", "Delete Account",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.No Then Exit Sub

        Try
            Call koneksi()
            ' SQLite menggunakan datetime('now', 'localtime')
            Dim sql As String = "UPDATE account SET is_deleted = 1, deleted_at = datetime('now', 'localtime') WHERE account_id = @id"
            cmd = New SQLiteCommand(sql, Conn)
            cmd.Parameters.AddWithValue("@id", CurrentID)
            cmd.ExecuteNonQuery()

            ' Catat ke Log sebelum keluar
            LogActivity("Account Deleted by Counselor")

            MessageBox.Show("Your account has been deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Jalankan fungsi pembersihan massal
            Logout(Me)
        Catch ex As Exception
            MessageBox.Show("Error deleting account: " & ex.Message)
        End Try
    End Sub

    Private Sub btnreq_Click(sender As Object, e As EventArgs) Handles btnreq.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        IncomingReq.Show()
        Me.Hide()
    End Sub
End Class