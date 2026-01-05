Imports System.Data.SQLite
Public Class ActivityLog
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property
    Private Sub LoadLogData(Optional keyword As String = "", Optional filterDate As Date? = Nothing)
        Try
            Call koneksi()

            ' Query dasar: Join tabel account untuk mengambil kolom 'name'
            Dim sql As String = "SELECT l.log_id, a.name, l.activity, l.created_at " &
                                "FROM activity_log l " &
                                "INNER JOIN account a ON l.account_id = a.account_id WHERE 1=1"

            ' Filter berdasarkan Nama atau Deskripsi Aktivitas (txtsearch)
            If Not String.IsNullOrEmpty(keyword) Then
                sql &= " AND (a.name LIKE @key OR l.activity LIKE @key)"
            End If

            ' Filter berdasarkan Tanggal (dtsearch)
            If filterDate.HasValue Then
                sql &= " AND DATE(l.created_at) = DATE(@tgl)"
            End If

            sql &= " ORDER BY l.created_at DESC"

            Using cmd As New SQLiteCommand(sql, Conn)
                ' Parameter untuk keyword pencarian
                If Not String.IsNullOrEmpty(keyword) Then
                    cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
                End If

                ' Parameter untuk tanggal
                If filterDate.HasValue Then
                    cmd.Parameters.AddWithValue("@tgl", filterDate.Value.ToString("yyyy-MM-dd"))
                End If

                da = New SQLiteDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dgvlog.DataSource = dt
            End Using

            FormatGrid()

        Catch ex As Exception
            MessageBox.Show("Error loading logs: " & ex.Message)
        Finally
            ' STANDAR KEAMANAN: Selalu tutup dan bersihkan pool [cite: 2026-01-04]
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub

    Private Sub FormatGrid()
        If dgvlog.Columns.Count > 0 Then
            dgvlog.Columns("log_id").HeaderText = "ID"
            dgvlog.Columns("name").HeaderText = "User Name"
            dgvlog.Columns("activity").HeaderText = "Activity Detail"
            dgvlog.Columns("created_at").HeaderText = "Timestamp"

            dgvlog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvlog.ReadOnly = True
            dgvlog.AllowUserToAddRows = False
            dgvlog.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub
    Private Sub ActivityLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLogData()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        LoadLogData(txtsearch.Text)
    End Sub
    Private Sub btnsignout_Click(sender As Object, e As EventArgs) Handles btnsignout.Click
        If MessageBox.Show("Are you sure you want to sign out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' Reset sesi dan kembali ke form login
            Call Logout(Me)
            CurrentID = 0
            CurrentName = ""
            Me.Close()
            SignIn.Show()
            SignIn.txtemail.Focus()
        End If
    End Sub
End Class