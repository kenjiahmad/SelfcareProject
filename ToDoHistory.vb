Imports System.Data.SQLite

Public Class ToDoHistory
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property
    Private Sub LoadHistoryData(Optional filterDate As Date? = Nothing)
        Try
            Call koneksi()

            ' Query dasar: mengambil tugas yang is_done = 1 dan tidak dihapus
            Dim sql As String = "SELECT title, description, due_date, created_at " &
                                "FROM todo_list " &
                                "WHERE account_id = @id AND is_done = 1 AND is_deleted = 0"

            ' Tambahkan filter tanggal jika ada
            If filterDate.HasValue Then
                sql &= " AND DATE(due_date) = DATE(@tgl)"
            End If

            sql &= " ORDER BY due_date DESC"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@id", CurrentID)
                If filterDate.HasValue Then
                    cmd.Parameters.AddWithValue("@tgl", filterDate.Value.ToString("yyyy-MM-dd"))
                End If

                da = New SQLiteDataAdapter(cmd)
                ds = New DataSet()
                da.Fill(ds)

                dgvhistory.DataSource = ds.Tables(0)
            End Using

            FormatGrid()

        Catch ex As Exception
            MessageBox.Show("Error loading completed tasks: " & ex.Message)
        Finally
            ' STANDAR KEAMANAN: Pastikan koneksi ditutup dan pools dibersihkan [cite: 2026-01-04]
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub

    Private Sub FormatGrid()
        ' Merapikan header Grid agar lebih informatif
        If dgvhistory.Columns.Count > 0 Then
            dgvhistory.Columns("title").HeaderText = "Task Name"
            dgvhistory.Columns("description").HeaderText = "Notes"
            dgvhistory.Columns("due_date").HeaderText = "Completed Date"
            dgvhistory.Columns("created_at").HeaderText = "Date Created"

            dgvhistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvhistory.ReadOnly = True
            dgvhistory.AllowUserToAddRows = False
            dgvhistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub
    Private Sub ToDoHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHistoryData()
    End Sub

    Private Sub dtsearch_ValueChanged(sender As Object, e As EventArgs) Handles dtsearch.ValueChanged
        LoadHistoryData(dtsearch.Value)
    End Sub

    Private Sub btnshowall_Click(sender As Object, e As EventArgs) Handles btnshowall.Click
        LoadHistoryData()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub
End Class