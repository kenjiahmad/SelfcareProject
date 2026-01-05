Imports System.Data.SQLite

Public Class MoodHistory
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property
    Private Sub LoadMoodHistory(Optional filterDate As Date? = Nothing)
        Try
            Call koneksi()

            ' Query dasar untuk mengambil riwayat mood user yang sedang login
            Dim sql As String = "SELECT created_at, mood, note FROM mood_tracker WHERE account_id = @id"

            ' Jika ada filter tanggal dari dtsearch
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

                dgvhistory.DataSource = dt
            End Using

            FormatGrid()

        Catch ex As Exception
            MessageBox.Show("Error loading mood history: " & ex.Message)
        Finally
            ' Standar keamanan agar DB tidak locked [cite: 2026-01-04]
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub

    Private Sub FormatGrid()
        ' Pengaturan Header agar lebih cantik sesuai UI Multimedia kamu
        If dgvhistory.Columns.Count > 0 Then
            dgvhistory.Columns("created_at").HeaderText = "Date & Time"
            dgvhistory.Columns("mood").HeaderText = "Mood Entry"
            dgvhistory.Columns("note").HeaderText = "Journal Note"

            dgvhistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvhistory.ReadOnly = True
            dgvhistory.AllowUserToAddRows = False
            dgvhistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub
    Private Sub MoodHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblwelcome.Text = "Welcome, " & CurrentName & "!"
        dtsearch.Value = Date.Today
        ' Load semua history saat pertama kali buka
        LoadMoodHistory()
    End Sub

    Private Sub dtsearch_ValueChanged(sender As Object, e As EventArgs) Handles dtsearch.ValueChanged
        LoadMoodHistory(dtsearch.Value)
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub btnshowall_Click(sender As Object, e As EventArgs) Handles btnshowall.Click
        LoadMoodHistory()
    End Sub
End Class