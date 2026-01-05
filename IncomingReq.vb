Imports System.Data.SQLite
Public Class IncomingReq
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property
    Sub LoadRequests()
        Try
            Call koneksi()
            ' Ambil nama user dan waktu request dari hasil join tabel
            Dim sql As String = "SELECT a.assignment_id, b.name As user_name, a.created_at " &
                            "FROM counselor_assignment a " &
                            "JOIN account b ON a.user_id = b.account_id " &
                            "WHERE a.counselor_id = @cid AND a.status = 'PENDING' AND a.is_active = 1"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@cid", CurrentID)
                da = New SQLiteDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dgvrequest.DataSource = dt
            End Using

            FormatGrid()

        Catch ex As Exception
            MessageBox.Show("Error loading requests: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                ' Sangat krusial karena dipanggil otomatis oleh Timer [cite: 2026-01-04]
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub

    Private Sub FormatGrid()
        If dgvrequest.Columns.Count > 0 Then
            With dgvrequest
                ' Sembunyikan ID teknis
                .Columns("assignment_id").Visible = False

                .Columns("user_name").HeaderText = "User Name"
                .Columns("created_at").HeaderText = "Requested Time"

                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .ReadOnly = True
                .AllowUserToAddRows = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersVisible = False
            End With
        End If
    End Sub
    Private Function HasUnsavedData() As Boolean
        ' Jika user sudah mengklik salah satu baris di grid, kita anggap ada interaksi aktif
        If dgvrequest.CurrentRow IsNot Nothing Then
            Return True
        End If
        Return False
    End Function

    ' Konfirmasi saat ingin pindah menu [cite: 2026-01-04]
    Private Function ConfirmLeavePage() As Boolean
        Dim result = MessageBox.Show("You have a selected request that hasn't been processed. Leave anyway?",
                                 "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Return result = DialogResult.Yes
    End Function
    Private Sub IncomingReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrrefresh.Tick
        ' Refresh tabel secara otomatis untuk melihat jika ada user baru yang request
        LoadRequests()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tmrrefresh.Stop()

        If HasUnsavedData() Then
            If Not ConfirmLeavePage() Then
                tmrrefresh.Start()
                Exit Sub
            End If
        End If

        ChatRoom.Show()
        Me.Hide()
    End Sub

    Private Sub btnaccept_Click(sender As Object, e As EventArgs) Handles btnaccept.Click
        If dgvrequest.CurrentRow Is Nothing Then Exit Sub

        Dim assignID As Integer = Convert.ToInt32(dgvrequest.CurrentRow.Cells("assignment_id").Value)
        Dim uName As String = dgvrequest.CurrentRow.Cells("user_name").Value.ToString()

        Try
            Call koneksi()
            Dim sql As String = "UPDATE counselor_assignment SET status = 'ACCEPTED' WHERE assignment_id = @id"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@id", assignID)
                cmd.ExecuteNonQuery()
            End Using

            LogActivity("Counselor accepted chat request from " & uName)
            MessageBox.Show("Request accepted! You can now start chatting in Chat Room.", "Success")

            LoadRequests() ' Refresh tabel
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLiteConnection.ClearAllPools()
        End Try
    End Sub

    Private Sub btnreject_Click(sender As Object, e As EventArgs) Handles btnreject.Click
        If dgvrequest.CurrentRow Is Nothing Then Exit Sub

        Dim assignID As Integer = Convert.ToInt32(dgvrequest.CurrentRow.Cells("assignment_id").Value)

        Dim ask = MessageBox.Show("Are you sure you want to reject this request?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ask = DialogResult.No Then Exit Sub

        Try
            Call koneksi()
            ' Ubah status jadi REJECTED agar tidak muncul lagi
            Dim sql As String = "UPDATE counselor_assignment SET status = 'REJECTED' WHERE assignment_id = @id"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@id", assignID)
                cmd.ExecuteNonQuery()
            End Using

            LogActivity("Counselor rejected a chat request")
            LoadRequests()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQLiteConnection.ClearAllPools()
        End Try
    End Sub
End Class