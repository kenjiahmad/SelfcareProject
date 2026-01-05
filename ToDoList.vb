Imports System.Data.SQLite

Public Class ToDoList
    Dim isUpdatingCheck As Boolean = False
    'Protected Overrides ReadOnly Property CreateParams As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
    '        Return cp
    '    End Get
    'End Property
    Function HasUnsavedData() As Boolean
        Return txttitle.Text <> "" Or txtdescription.Text <> ""
    End Function
    Private Sub LoadTodo(Optional dueFilter As Date? = Nothing)
        Try
            Call koneksi()

            ' SQLite Query: is_done=0 (belum selesai), is_deleted=0 (aktif)
            Dim sql As String = "SELECT todo_id, title, description, due_date FROM todo_list " &
                                "WHERE account_id = @id AND is_done = 0 AND is_deleted = 0"

            If dueFilter.HasValue Then
                sql &= " AND DATE(due_date) = DATE(@due)"
            End If

            sql &= " ORDER BY due_date ASC"

            cmd = New SQLiteCommand(sql, Conn)
            cmd.Parameters.AddWithValue("@id", CurrentID)
            If dueFilter.HasValue Then
                cmd.Parameters.AddWithValue("@due", dueFilter.Value.ToString("yyyy-MM-dd"))
            End If

            da = New SQLiteDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)

            dgvtodo.DataSource = ds.Tables(0)
            FormatGrid()
        Catch ex As Exception
            MessageBox.Show("Error loading todos: " & ex.Message)
        End Try
    End Sub
    Private Sub FormatGrid()
        ' Setup tampilan Grid agar rapi sesuai UI multimedia kamu
        If dgvtodo.Columns.Contains("todo_id") Then dgvtodo.Columns("todo_id").Visible = False

        ' Pastikan kolom is_done (Checkbox) ada di paling kiri
        If Not dgvtodo.Columns.Contains("is_done") Then
            Dim chk As New DataGridViewCheckBoxColumn()
            chk.Name = "is_done"
            chk.HeaderText = "Done"
            dgvtodo.Columns.Insert(0, chk)
        End If

        dgvtodo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvtodo.AllowUserToAddRows = False
        dgvtodo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvtodo.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub
    Private Sub ToDoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetNavIndicator(Me, "pnltodo")
        lblwelcome.Text = "Welcome, " & CurrentName & "!"
        LoadTodo()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txttitle.Text = "" Then
            MessageBox.Show("Title is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Call koneksi()
            ' SQLite menggunakan datetime('now','localtime') sebagai pengganti NOW()
            Dim sql As String = "INSERT INTO todo_list (account_id, title, description, due_date, is_done, created_at, is_deleted) " &
                                "VALUES (@id, @title, @desc, @due, 0, datetime('now','localtime'), 0)"

            cmd = New SQLiteCommand(sql, Conn)
            cmd.Parameters.AddWithValue("@id", CurrentID)
            cmd.Parameters.AddWithValue("@title", txttitle.Text)
            cmd.Parameters.AddWithValue("@desc", txtdescription.Text)
            cmd.Parameters.AddWithValue("@due", dtdue.Value.ToString("yyyy-MM-dd"))

            cmd.ExecuteNonQuery()
            LogActivity("User just added new to do")
            MessageBox.Show("Todo added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txttitle.Clear()
            txtdescription.Clear()
            LoadTodo()
        Catch ex As Exception
            MessageBox.Show("Failed to add todo: " & ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvtodo.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a todo to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Delete this todo?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim todoId As Integer = dgvtodo.SelectedRows(0).Cells("todo_id").Value
                Call koneksi()
                cmd = New SQLiteCommand("UPDATE todo_list SET is_deleted = 1 WHERE todo_id = @id", Conn)
                cmd.Parameters.AddWithValue("@id", todoId)
                cmd.ExecuteNonQuery()
                LogActivity("User just deleted some to do")
                LoadTodo()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvtodo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtodo.CellContentClick
        If e.RowIndex < 0 OrElse dgvtodo.Columns(e.ColumnIndex).Name <> "is_done" Then Exit Sub

        Dim todoId As Integer = Convert.ToInt32(dgvtodo.Rows(e.RowIndex).Cells("todo_id").Value)

        If MessageBox.Show("Mark this task as completed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Call koneksi()
                cmd = New SQLiteCommand("UPDATE todo_list SET is_done = 1 WHERE todo_id = @id", Conn)
                cmd.Parameters.AddWithValue("@id", todoId)
                cmd.ExecuteNonQuery()
                LogActivity("User done some to do")
                LoadTodo() ' Refresh grid (tugas selesai akan hilang dari list aktif)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        Else
            ' Jika user pilih NO, kita batalkan centangnya (refresh grid)
            LoadTodo()
        End If
    End Sub
    Private Sub dgvtodo_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvtodo.CurrentCellDirtyStateChanged
        ' Jika ada sel yang sedang diedit (seperti checkbox diklik)
        If dgvtodo.IsCurrentCellDirty Then
            ' Langsung sahkan perubahannya tanpa menunggu pindah sel
            dgvtodo.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dtsearch_ValueChanged(sender As Object, e As EventArgs) Handles dtsearch.ValueChanged
        LoadTodo(dtsearch.Value)
    End Sub

    Private Sub btnshowall_Click(sender As Object, e As EventArgs) Handles btnshowall.Click
        LoadTodo()
    End Sub

    Private Sub btnsignout_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Panggil fungsi pusat di Module
            Call Logout(Me)
        End If
    End Sub

    Private Sub btnhistory_Click(sender As Object, e As EventArgs) Handles btnhistory.Click
        ToDoHistory.ShowDialog()
    End Sub
    Private Sub btnjournal_Click_1(sender As Object, e As EventArgs) Handles btnjournal.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If
        Journal.Show()
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

    Private Sub btncounseling_Click_1(sender As Object, e As EventArgs) Handles btncounseling.Click
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

    Private Sub btnsignout_Click_1(sender As Object, e As EventArgs) Handles btnsignout.Click
        Dim result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Panggil fungsi pusat di Module
            Call Logout(Me)
        End If
    End Sub
End Class