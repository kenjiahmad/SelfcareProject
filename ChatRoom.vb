Imports System.Data.SQLite
Public Class ChatRoom
    Sub LoadActiveChats()
        Try
            Call koneksi()
            Dim sql As String = ""

            ' Jika Counselor, cari User. Jika User, cari Counselor. [cite: 2026-01-04]
            If CurrentRole = "counselor" Then
                sql = "SELECT a.assignment_id, b.name As partner_name " &
                  "FROM counselor_assignment a JOIN account b ON a.user_id = b.account_id " &
                  "WHERE a.counselor_id = @id AND a.status = 'ACCEPTED'"
            Else
                sql = "SELECT a.assignment_id, b.name As partner_name " &
                  "FROM counselor_assignment a JOIN account b ON a.counselor_id = b.account_id " &
                  "WHERE a.user_id = @id AND a.status = 'ACCEPTED'"
            End If

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@id", CurrentID)
                da = New SQLiteDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dgvactivechats.DataSource = dt
            End Using

            ' Format grid agar hanya muncul kolom nama partner
            If dgvactivechats.Columns.Count > 0 Then
                dgvactivechats.Columns("assignment_id").Visible = False
                dgvactivechats.Columns("partner_name").HeaderText = "Conversations"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLiteConnection.ClearAllPools()
        End Try
    End Sub
    Sub LoadMessages(assignmentID As Integer)
        Try
            Call koneksi()
            Dim sql As String = "SELECT sender_id, message_text FROM chat_message WHERE assignment_id = @aid ORDER BY sent_at ASC"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@aid", assignmentID)
                rd = cmd.ExecuteReader()

                ' Bersihkan chat lama sebelum memuat yang baru
                flpchat.Controls.Clear()

                While rd.Read()
                    Dim senderID As Integer = Convert.ToInt32(rd("sender_id"))
                    Dim msgText As String = rd("message_text").ToString()

                    ' Buat balon chat sederhana
                    Dim lbl As New Label
                    lbl.Text = msgText
                    lbl.AutoSize = True
                    lbl.MaximumSize = New Size(flpchat.Width - 50, 0)
                    lbl.Padding = New Padding(10)
                    lbl.Margin = New Padding(5)

                    ' Jika pengirimnya adalah USER YANG SEDANG LOGIN (CurrentID)
                    If senderID = CurrentID Then
                        lbl.BackColor = Color.FromArgb(255, 128, 0) ' Oranye (Tema kamu)
                        lbl.ForeColor = Color.White
                        lbl.TextAlign = ContentAlignment.MiddleRight
                        ' Tambahkan ke panel
                        flpchat.Controls.Add(lbl)
                    Else
                        ' Jika pengirimnya LAWAN BICARA
                        lbl.BackColor = Color.White
                        lbl.ForeColor = Color.Black
                        flpchat.Controls.Add(lbl)
                    End If
                End While
            End Using

            ' Scroll otomatis ke paling bawah
            flpchat.VerticalScroll.Value = flpchat.VerticalScroll.Maximum

        Catch ex As Exception
            ' Handle error diam-diam agar tidak mengganggu pengalaman chat
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
            SQLiteConnection.ClearAllPools()
        End Try
    End Sub
    Private Sub ChatRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        If String.IsNullOrWhiteSpace(txtmessage.Text) OrElse dgvactivechats.CurrentRow Is Nothing Then Exit Sub

        Try
            Call koneksi()
            Dim assignID As Integer = Convert.ToInt32(dgvactivechats.CurrentRow.Cells("assignment_id").Value)

            Dim sql As String = "INSERT INTO chat_message (assignment_id, sender_id, message_text, sent_at) " &
                            "VALUES (@aid, @sid, @msg, @time)"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@aid", assignID)
                cmd.Parameters.AddWithValue("@sid", CurrentID)
                cmd.Parameters.AddWithValue("@msg", txtmessage.Text.Trim())
                cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.ExecuteNonQuery()
            End Using

            txtmessage.Clear()
            ' Langsung panggil muat pesan agar pesan kita muncul seketika
            LoadMessages(assignID)

        Catch ex As Exception
            MessageBox.Show("Failed to send: " & ex.Message)
        Finally
            ' Selalu tutup dan bersihkan pool [cite: 2026-01-04]
            If Conn.State = ConnectionState.Open Then Conn.Close()
            SQLiteConnection.ClearAllPools()
        End Try

    End Sub
    Private Sub dgvActiveChats_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvactivechats.CellClick
        If e.RowIndex >= 0 Then
            ' Ambil ID pertemanan
            Dim assignID As Integer = Convert.ToInt32(dgvactivechats.Rows(e.RowIndex).Cells("assignment_id").Value)

            ' 1. Muat pesan pertama kali
            LoadMessages(assignID)

            ' 2. Baru aktifkan timer untuk cek pesan baru secara otomatis
            tmrchat.Enabled = True

            ' Opsional: Ubah header nama di atas chat agar rapi
            lblchatwith.Text = "Chatting with: " & dgvactivechats.Rows(e.RowIndex).Cells("partner_name").Value.ToString()
        End If
    End Sub
    Private Sub tmrchat_Tick(sender As Object, e As EventArgs) Handles tmrchat.Tick
        If dgvactivechats.CurrentRow IsNot Nothing Then
            Dim currentAssignID As Integer = Convert.ToInt32(dgvactivechats.CurrentRow.Cells("assignment_id").Value)
            LoadMessages(currentAssignID)
        End If
    End Sub
End Class