Imports System.Data.SQLite
Imports System.Security.Cryptography
Imports System.Text

Module Module1
    Public Conn As SQLiteConnection
    Public cmd As SQLiteCommand
    Public rd As SQLiteDataReader
    Public da As SQLiteDataAdapter
    Public ds As DataSet

    ' Session Data
    Public CurrentID As Integer
    Public CurrentName As String
    Public CurrentRole As String
    Sub koneksi()
        Try
            If Conn Is Nothing Then
                ' Menggunakan Application.StartupPath lebih stabil daripada DataDirectory
                Dim dbPath As String = IO.Path.Combine(Application.StartupPath, "selfcare_app.db")
                Conn = New SQLiteConnection("Data Source=" & dbPath & ";Version=3;")
            End If

            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub
    Public Function HashPassword(ByVal password As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            ' Ubah password input menjadi byte array
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password))

            ' Ubah byte array menjadi string Hexadecimal
            Dim builder As New StringBuilder()
            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function
    Sub LogActivity(activity As String)
        Try
            Call koneksi()
            Dim sql As String = "INSERT INTO activity_log (account_id, activity, created_at) VALUES (@id, @act, datetime('now','localtime'))"
            cmd = New SQLiteCommand(sql, Conn)
            cmd.Parameters.AddWithValue("@id", CurrentID)
            cmd.Parameters.AddWithValue("@act", activity)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            ' Diamkan saja atau tampilkan error jika perlu
        End Try
    End Sub
    Sub Logout(ByVal CurrentForm As Form)
        ' 1. Catat log berdasarkan role sebelum session dihapus [cite: 2026-01-04]
        Dim logMsg As String = "User Sign Out"
        If CurrentRole.ToLower() = "counselor" Then
            logMsg = "Counselor Sign Out"
        ElseIf CurrentRole.ToLower() = "admin" Then
            logMsg = "Admin Sign Out"
        End If

        LogActivity(logMsg)

        ' 2. Kosongkan Session
        CurrentID = 0
        CurrentName = ""
        CurrentRole = ""

        ' 3. Tutup semua form terbuka kecuali SignIn
        ' Gunakan ToArray agar tidak error saat koleksi form berubah
        For Each f As Form In Application.OpenForms.Cast(Of Form).ToArray()
            If f.Name <> "SignIn" Then
                f.Hide() ' Sembunyikan dulu agar transisi mulus
                f.Close()
            End If
        Next

        ' 4. Bersihkan Database Pool [cite: 2026-01-04]
        ' Memastikan tidak ada koneksi menggantung saat ganti akun
        SQLiteConnection.ClearAllPools()

        ' 5. Tampilkan kembali dan Reset Sign In
        SignIn.Show()
        SignIn.txtemail.Clear()
        SignIn.txtpassword.Clear()
        SignIn.txtemail.Focus()
    End Sub

    Public Sub SetNavIndicator(ByVal f As Form, ByVal activePanelName As String)
        ' Cari semua panel yang namanya mengandung "pnl" di Form tersebut
        For Each ctrl As Control In f.Controls
            If TypeOf ctrl Is Panel AndAlso ctrl.Name.StartsWith("pnl") Then
                ' Jika nama panel sesuai dengan activePanelName, buat dia True, sisanya False
                If ctrl.Name.ToLower() = activePanelName.ToLower() Then
                    ctrl.Visible = True
                Else
                    ' Panel navigasi biasanya tidak termasuk panel kontainer utama
                    ' Kita hanya targetkan panel indikator oranye
                    If ctrl.Name.ToLower().Contains("todo") Or
                       ctrl.Name.ToLower().Contains("journal") Or
                       ctrl.Name.ToLower().Contains("mood") Or
                       ctrl.Name.ToLower().Contains("finance") Or
                       ctrl.Name.ToLower().Contains("user") Then
                        ctrl.Visible = False
                    End If
                End If
            End If
        Next

        ' Khusus untuk panel yang dipilih, paksa True
        Dim targetPanel As Control = f.Controls.Find(activePanelName, True).FirstOrDefault()
        If targetPanel IsNot Nothing Then targetPanel.Visible = True
    End Sub
    Public Function ConfirmLeavePage() As Boolean
        Dim result = MessageBox.Show(
            "You have unsaved changes. Leave without saving?",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        Return result = DialogResult.Yes
    End Function
End Module