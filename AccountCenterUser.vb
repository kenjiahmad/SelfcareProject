Imports System.Data.SQLite
Public Class AccountCenterUser
    Dim originalName As String
    Dim originalBirth As Date
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
        OrElse dtbirth.Value.Date <> originalBirth.Date
    End Function
    Sub LoadProfileData()
        Try
            Call koneksi()
            ' Ambil data lengkap user yang sedang login
            cmd = New SQLiteCommand("SELECT name, birth_date, email FROM account WHERE account_id = @id", Conn)
            cmd.Parameters.AddWithValue("@id", CurrentID)
            rd = cmd.ExecuteReader()

            If rd.Read() Then
                txtname.Text = rd("name").ToString()
                txtemail.Text = rd("email").ToString()
                dtbirth.Value = Convert.ToDateTime(rd("birth_date"))

                ' Simpan untuk cek UnsavedData
                originalName = txtname.Text
                originalBirth = dtbirth.Value

                CalculateAge()
                SetEditMode(False)
            End If
            rd.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message)
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
        txtemail.Enabled = False ' Email dikunci
        txtage.Enabled = False   ' Umur otomatis
        btnsave.Enabled = isEdit
        btnedit.Enabled = Not isEdit ' Tombol edit hilang saat mode edit aktif
    End Sub
    Sub LoadOverview()
        Try
            Call koneksi()
            lbltodo.Text = "• " & GetActiveTodoCount() & " active to-do"
            lbltododone.Text = "• " & GetCompletedTodoCount() & " completed"
            lbljournal.Text = "• " & GetCount("journal") & " journals"
            lblmood.Text = "• Last mood: " & GetLastMood()
            lblfinance.Text = "• Balance: Rp " & FormatNumber(GetBalance(), 0)
        Catch ex As Exception
            ' Jika error (misal tabel belum ada), tidak crash
        End Try
    End Sub

    Function GetCount(tableName As String) As Integer
        ' Pakai interpolasi string untuk nama tabel, tapi @id untuk data
        cmd = New SQLiteCommand($"SELECT COUNT(*) FROM {tableName} WHERE account_id = @id AND is_deleted = 0", Conn)
        cmd.Parameters.AddWithValue("@id", CurrentID)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Function GetActiveTodoCount() As Integer
        cmd = New SQLiteCommand("SELECT COUNT(*) FROM todo_list WHERE account_id = @id AND is_done = 0 AND is_deleted = 0", Conn)
        cmd.Parameters.AddWithValue("@id", CurrentID)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Function GetCompletedTodoCount() As Integer
        cmd = New SQLiteCommand("SELECT COUNT(*) FROM todo_list WHERE account_id = @id AND is_done = 1 AND is_deleted = 0", Conn)
        cmd.Parameters.AddWithValue("@id", CurrentID)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Function GetLastMood() As String
        cmd = New SQLiteCommand("SELECT mood FROM mood_tracker WHERE account_id = @id ORDER BY created_at DESC LIMIT 1", Conn)
        cmd.Parameters.AddWithValue("@id", CurrentID)
        Dim result = cmd.ExecuteScalar()
        Return If(result Is Nothing, "-", result.ToString())
    End Function

    Function GetBalance() As Decimal
        ' Logika: Income (+) dan Expense (-)
        cmd = New SQLiteCommand("SELECT IFNULL(SUM(CASE WHEN type='income' THEN amount ELSE -amount END), 0) " &
                            "FROM finance_tracker WHERE account_id = @id", Conn)
        cmd.Parameters.AddWithValue("@id", CurrentID)
        Return Convert.ToDecimal(cmd.ExecuteScalar())
    End Function
    Private Sub AccountCenterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblwelcome.Text = "Welcome, " & CurrentName & "!"
        SetNavIndicator(Me, "pnluser")
        LoadProfileData()
        LoadOverview()
        SetEditMode(False)
    End Sub

    Private Sub btnchangepw_Click(sender As Object, e As EventArgs) Handles btnchangepw.Click
        Me.Hide()
        ChangePassword.ShowDialog()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Call koneksi()
            Dim sql As String = "UPDATE account SET name = @name, birth_date = @birth WHERE account_id = @id"
            cmd = New SQLiteCommand(sql, Conn)
            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@birth", dtbirth.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@id", CurrentID)

            cmd.ExecuteNonQuery()
            LogActivity("User just edited profile")
            MessageBox.Show("Profile updated successfully!", "Success")

            ' Update session name jika berubah
            CurrentName = txtname.Text

            LoadProfileData() ' Refresh data
        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message)
        End Try
    End Sub

    Private Sub dtbirth_ValueChanged(sender As Object, e As EventArgs) Handles dtbirth.ValueChanged
        CalculateAge()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        SetEditMode(True)
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
            LogActivity("Account Deleted by user")

            MessageBox.Show("Your account has been deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Jalankan fungsi pembersihan massal
            Logout(Me)
        Catch ex As Exception
            MessageBox.Show("Error deleting account: " & ex.Message)
        End Try
    End Sub

    Private Sub btntodo_Click(sender As Object, e As EventArgs) Handles btntodo.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        ToDoList.Show()
        Me.Hide()
    End Sub

    Private Sub btnsignout_Click(sender As Object, e As EventArgs) Handles btnsignout.Click
        Dim result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Panggil fungsi pusat di Module
            Call Logout(Me)
        End If
    End Sub

    Private Sub btnjournal_Click(sender As Object, e As EventArgs) Handles btnjournal.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        Journal.Show()
        Me.Hide()
    End Sub

    Private Sub btnmood_Click(sender As Object, e As EventArgs) Handles btnmood.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        MoodTracker.Show()
        Me.Hide()
    End Sub

    Private Sub btnfinance_Click(sender As Object, e As EventArgs) Handles btnfinance.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        FinanceTracker.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnfindcounselor.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        FindCounselor.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btncounseling.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        ChatRoom.Show()
        Me.Hide()
    End Sub
End Class