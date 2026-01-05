Imports System.Data.SQLite
Public Class Journal
    Private selectedJournalId As Integer = 0
    Function HasUnsavedData() As Boolean
        Return txttitle.Text <> "" Or txtcontent.Text <> ""
    End Function
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property

    Private Sub LoadJournal(Optional filterDate As Date? = Nothing)
        Try
            Call koneksi()

            Dim sql As String = "SELECT journal_id, title, content, created_at " &
                            "FROM journal WHERE account_id = @id"

            ' Filter tanggal jika dtsearch berubah
            If filterDate.HasValue Then
                sql &= " AND DATE(created_at) = DATE(@tgl)"
            End If

            sql &= " ORDER BY created_at DESC"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@id", CurrentID)

                If filterDate.HasValue Then
                    cmd.Parameters.AddWithValue("@tgl", filterDate.Value.ToString("yyyy-MM-dd"))
                End If

                da = New SQLiteDataAdapter(cmd)
                ds = New DataSet()
                da.Fill(ds)

                dgvjournal.DataSource = ds.Tables(0)
            End Using

            ' Formatting Grid agar estetik seperti desainmu
            FormatGrid()

        Catch ex As Exception
            MessageBox.Show("Error Load Journal: " & ex.Message)
        Finally
            ' TUTUP KONEKSI supaya tidak "Locked" lagi nanti pas mau Save
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub

    Private Sub FormatGrid()
        ' Sembunyikan kolom ID dan Content supaya hanya judul dan tanggal yang kelihatan
        If dgvjournal.Columns.Contains("journal_id") Then dgvjournal.Columns("journal_id").Visible = False
        If dgvjournal.Columns.Contains("content") Then dgvjournal.Columns("content").Visible = False

        dgvjournal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvjournal.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvjournal.AllowUserToAddRows = False
        dgvjournal.ReadOnly = True ' Supaya user nggak bisa ngetik langsung di grid
    End Sub

    Private Sub ClearJournalForm()
        txttitle.Clear()
        txtcontent.Clear()
        selectedJournalId = 0
    End Sub
    Private Sub Journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblwelcome.Text = "Welcome, " & CurrentName & "!"
        SetNavIndicator(Me, "pnljournal")
        LoadJournal()
        txttitle.Focus()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Call koneksi()

            Using cmd As New SQLiteCommand()
                cmd.Connection = Conn

                If selectedJournalId = 0 Then
                    cmd.CommandText = "INSERT INTO journal (account_id, title, content, created_at) VALUES (@id, @title, @content, datetime('now','localtime'))"
                Else
                    cmd.CommandText = "UPDATE journal SET title=@title, content=@content WHERE journal_id=@jid"
                    cmd.Parameters.AddWithValue("@jid", selectedJournalId)
                End If

                cmd.Parameters.AddWithValue("@id", CurrentID)
                cmd.Parameters.AddWithValue("@title", txttitle.Text)
                cmd.Parameters.AddWithValue("@content", txtcontent.Text)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Journal successfully saved!", "Success")
            ClearJournalForm()
            LoadJournal()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' INI KUNCINYA: Selalu tutup koneksi agar tidak "Locked"
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If selectedJournalId = 0 Then
            MessageBox.Show("Please select a journal from the list first.")
            Exit Sub
        End If

        Dim result = MessageBox.Show("This journal will be permanently deleted. Continue?", "Confirm Delete",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                Call koneksi()
                cmd = New SQLiteCommand("DELETE FROM journal WHERE journal_id=@jid", Conn)
                cmd.Parameters.AddWithValue("@jid", selectedJournalId)
                cmd.ExecuteNonQuery()

                LogActivity("User deleted a journal entry")
                MessageBox.Show("Journal deleted successfully.")
                ClearJournalForm()
                LoadJournal()
            Catch ex As Exception
                MessageBox.Show("Error deleting journal: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub dgvjournal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvjournal.CellClick
        If e.RowIndex < 0 Then Exit Sub

        ' Ambil data dari baris yang diklik untuk ditampilkan kembali di TextBox
        selectedJournalId = Convert.ToInt32(dgvjournal.Rows(e.RowIndex).Cells("journal_id").Value)
        txttitle.Text = dgvjournal.Rows(e.RowIndex).Cells("title").Value.ToString()
        txtcontent.Text = dgvjournal.Rows(e.RowIndex).Cells("content").Value.ToString()
    End Sub

    Private Sub dtsearch_ValueChanged(sender As Object, e As EventArgs) Handles dtsearch.ValueChanged
        LoadJournal(dtsearch.Value)
    End Sub

    Private Sub btncounseling_Click(sender As Object, e As EventArgs) Handles btncounseling.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        ChatRoom.Show()
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

    Private Sub btnmood_Click_1(sender As Object, e As EventArgs) Handles btnmood.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        MoodTracker.Show()
        Me.Hide()
    End Sub

    Private Sub btnfinance_Click_1(sender As Object, e As EventArgs) Handles btnfinance.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        FinanceTracker.Show()
        Me.Hide()
    End Sub

    Private Sub btnfindcounselor_Click_1(sender As Object, e As EventArgs) Handles btnfindcounselor.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        FindCounselor.Show()
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