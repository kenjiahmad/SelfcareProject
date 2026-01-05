Imports System.Data.SQLite
Public Class FinanceTracker
    Function HasUnsavedData() As Boolean
        Return txtdescription.Text <> "" Or txtamount.Text <> ""
    End Function
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property
    Private Sub LoadFinance(Optional filterDate As Date? = Nothing)
        Try
            Call koneksi()

            Dim sql As String = "SELECT finance_id, created_at, type, description, amount " &
                                "FROM finance_tracker WHERE account_id = @id"

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
                Dim dt As New DataTable
                da.Fill(dt)
                dgvfinance.DataSource = dt
            End Using

            FormatGrid()
        Catch ex As Exception
            MessageBox.Show("Error loading finance data: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub LoadFinanceSummary()
        Try
            Call koneksi()
            Dim totalIncome As Decimal = 0
            Dim totalExpense As Decimal = 0

            ' Total Income
            Using cmdIncome As New SQLiteCommand("SELECT IFNULL(SUM(amount), 0) FROM finance_tracker WHERE account_id = @id AND type = 'income'", Conn)
                cmdIncome.Parameters.AddWithValue("@id", CurrentID)
                totalIncome = Convert.ToDecimal(cmdIncome.ExecuteScalar())
            End Using

            ' Total Expense
            Using cmdExpense As New SQLiteCommand("SELECT IFNULL(SUM(amount), 0) FROM finance_tracker WHERE account_id = @id AND type = 'expense'", Conn)
                cmdExpense.Parameters.AddWithValue("@id", CurrentID)
                totalExpense = Convert.ToDecimal(cmdExpense.ExecuteScalar())
            End Using

            ' Update UI dengan format mata uang
            lbltotalincome.Text = "Income : Rp " & totalIncome.ToString("N0")
            lbltotalexpense.Text = "Expense : Rp " & totalExpense.ToString("N0")
            lblbalance.Text = "Balance : Rp " & (totalIncome - totalExpense).ToString("N0")

        Catch ex As Exception
            MessageBox.Show("Error calculating summary: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub FormatGrid()
        If dgvfinance.Columns.Count > 0 Then
            dgvfinance.Columns("finance_id").Visible = False
            dgvfinance.Columns("created_at").HeaderText = "Date"
            dgvfinance.Columns("type").HeaderText = "Type"
            dgvfinance.Columns("description").HeaderText = "Description"
            dgvfinance.Columns("amount").HeaderText = "Amount"

            dgvfinance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvfinance.ReadOnly = True
            dgvfinance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvfinance.AllowUserToAddRows = False
        End If
    End Sub
    Private Sub CloseConnection()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
            SQLiteConnection.ClearAllPools()
        End If
    End Sub
    Private Sub FinanceTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetNavIndicator(Me, "pnlfinance") ' Gunakan navigasi dari Module
        lblwelcome.Text = "Welcome, " & CurrentName
        rbincome.Checked = True
        dtsearch.Value = Date.Today

        LoadFinance()
        LoadFinanceSummary()
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtdescription.Text = "" Or txtamount.Text = "" Then
            MessageBox.Show("Please complete all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim amount As Decimal
        If Not Decimal.TryParse(txtamount.Text, amount) Then
            MessageBox.Show("Amount must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Call koneksi()
            Dim type As String = If(rbincome.Checked, "income", "expense")
            Dim sql As String = "INSERT INTO finance_tracker (account_id, type, description, amount, created_at) " &
                                "VALUES (@id, @type, @desc, @amount, datetime('now','localtime'))"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@id", CurrentID)
                cmd.Parameters.AddWithValue("@type", type)
                cmd.Parameters.AddWithValue("@desc", txtdescription.Text)
                cmd.Parameters.AddWithValue("@amount", amount)
                cmd.ExecuteNonQuery()
            End Using

            LogActivity("Added finance record: " & type & " - " & amount)

            ' Reset UI
            txtdescription.Clear()
            txtamount.Clear()
            rbincome.Checked = True

            LoadFinance()
            LoadFinanceSummary()
            MessageBox.Show("Transaction added successfully 💸", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Failed to add transaction: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvfinance.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a transaction first.", "Warning")
            Exit Sub
        End If

        If MessageBox.Show("Delete this transaction?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        Try
            Dim financeId As Integer = dgvfinance.SelectedRows(0).Cells("finance_id").Value
            Call koneksi()

            Using cmd As New SQLiteCommand("DELETE FROM finance_tracker WHERE finance_id = @fid", Conn)
                cmd.Parameters.AddWithValue("@fid", financeId)
                cmd.ExecuteNonQuery()
            End Using

            LogActivity("Deleted a finance record")
            LoadFinance()
            LoadFinanceSummary()
        Catch ex As Exception
            MessageBox.Show("Error deleting data: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub dtsearch_ValueChanged(sender As Object, e As EventArgs) Handles dtsearch.ValueChanged
        LoadFinance(dtsearch.Value)
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

    Private Sub btnjournal_Click(sender As Object, e As EventArgs) Handles btnjournal.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        Journal.Show()
        Me.Hide()
    End Sub

    Private Sub btntodo_Click(sender As Object, e As EventArgs) Handles btntodo.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        ToDoList.Show()
        Me.Hide()
    End Sub

    Private Sub btnmood_Click(sender As Object, e As EventArgs) Handles btnmood.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        MoodTracker.Show()
        Me.Hide()
    End Sub

    Private Sub btnfindcounselor_Click_1(sender As Object, e As EventArgs) Handles btnfindcounselor.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        FindCounselor.Show()
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
End Class