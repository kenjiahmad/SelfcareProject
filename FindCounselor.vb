Imports System.Data.SQLite

Public Class FindCounselor
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property
    Dim originalSelectedID As Integer = -1
    Private Function HasUnsavedData() As Boolean
        ' Jika ada baris yang dipilih dan ID-nya bukan -1 (awal)
        If dgvcounselor.CurrentRow IsNot Nothing Then
            Dim currentIDSelection As Integer = Convert.ToInt32(dgvcounselor.CurrentRow.Cells("account_id").Value)
            Return currentIDSelection <> originalSelectedID
        End If
        Return False
    End Function
    Private Function ConfirmLeavePage() As Boolean
        Dim result = MessageBox.Show("You have selected a counselor but haven't sent a request." & vbCrLf &
                                 "Are you sure you want to leave?", "Unsaved Request",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Return result = DialogResult.Yes
    End Function
    Sub LoadCounselors()
        Try
            Call koneksi()
            ' Ambil data lengkap termasuk birth_date untuk hitung umur
            Dim sql As String = "SELECT account_id, name, specialist, bio, birth_date FROM account " &
                            "WHERE role = 'counselor' AND is_deleted = 0"

            Using cmd As New SQLiteCommand(sql, Conn)
                da = New SQLiteDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dgvcounselor.DataSource = dt
            End Using

            FormatGrid()

            ' Reset Label detail di awal agar rapi
            lblname.Text = "-"
            lblspecialist.Text = "-"
            lblage.Text = "-"
            txtbio.Text = ""

        Catch ex As Exception
            MessageBox.Show("Error loading counselors: " & ex.Message)
        Finally
            ' Standar keamanan database [cite: 2026-01-04]
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub
    Private Sub FormatGrid()
        ' Pengaturan Header agar lebih cantik sesuai UI Multimedia kamu
        If dgvcounselor.Columns.Count > 0 Then
            ' Sembunyikan ID dan Birth Date (karena hanya untuk hitung umur di kodingan)
            dgvcounselor.Columns("account_id").Visible = False
            dgvcounselor.Columns("birth_date").Visible = False

            dgvcounselor.Columns("name").HeaderText = "Counselor Name"
            dgvcounselor.Columns("specialist").HeaderText = "Specialist"
            dgvcounselor.Columns("bio").HeaderText = "Biography"

            dgvcounselor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvcounselor.ReadOnly = True
            dgvcounselor.AllowUserToAddRows = False
            dgvcounselor.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub
    Private Sub FindCounselor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCounselors()
        pnlfind.Visible = True
    End Sub
    Private Sub dgvCounselor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcounselor.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvcounselor.Rows(e.RowIndex)

            lblname.Text = row.Cells("name").Value.ToString()
            lblspecialist.Text = row.Cells("specialist").Value.ToString()
            txtbio.Text = row.Cells("bio").Value.ToString()

            ' Hitung umur dari kolom birth_date yang disembunyikan
            Dim birthDate As Date = Convert.ToDateTime(row.Cells("birth_date").Value)
            Dim age As Integer = Date.Today.Year - birthDate.Year
            If birthDate > Date.Today.AddYears(-age) Then age -= 1
            lblage.Text = age.ToString()
        End If
    End Sub

    Private Sub btnuser_Click(sender As Object, e As EventArgs)
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        AccountCenterUser.Show()
        Me.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnfinance_Click_1(sender As Object, e As EventArgs) Handles btnfinance.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        FinanceTracker.Show()
        Me.Hide()
    End Sub

    Private Sub btncounseling_Click(sender As Object, e As EventArgs) Handles btncounseling.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        ChatRoom.Show()
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

    Private Sub btnuser_Click_1(sender As Object, e As EventArgs) Handles btnuser.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

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

    Private Sub btnmood_Click_1(sender As Object, e As EventArgs) Handles btnmood.Click
        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then Exit Sub
        End If

        MoodTracker.Show()
        Me.Hide()
    End Sub
End Class