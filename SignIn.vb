Imports System.Data.SQLite

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class SignIn
    Function HasUnsavedData() As Boolean
        Return txtemail.Text <> "" Or txtpassword.Text <> ""
    End Function

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        txtemail.Focus()

        With txtpassword
            .AutoSize = False
            .Height = 23
        End With
    End Sub

    Private Sub pctbExit_Click(sender As Object, e As EventArgs) Handles pctbExit.Click
        If HasUnsavedData() Then
            Dim result = MessageBox.Show(
                "Sign In not completed. Are you sure you want to leave this page?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.No Then Exit Sub

            txtemail.Clear()
            txtpassword.Clear()
            txtemail.Focus()
        Else
            If MessageBox.Show(
                "Are you sure you want to close the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) = DialogResult.Yes Then
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Chkshowpw_CheckedChanged(sender As Object, e As EventArgs) Handles chkshowpw.CheckedChanged
        txtpassword.UseSystemPasswordChar = Not chkshowpw.Checked
    End Sub

    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click
        ' VALIDASI INPUT
        If txtemail.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Please enter email and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Call koneksi()
            ' Gunakan fungsi SHA256 kamu untuk hashing password input [cite: 2026-01-04]
            Dim hashedPassword As String = HashPassword(txtpassword.Text)

            ' Gunakan parameter bernama (@) agar konsisten dan aman dari SQL Injection
            Dim sql As String = "SELECT account_id, name, role FROM account " &
                            "WHERE email = @email AND password = @password AND is_deleted = 0"

            Using cmd As New SQLiteCommand(sql, Conn)
                cmd.Parameters.AddWithValue("@email", txtemail.Text.Trim())
                cmd.Parameters.AddWithValue("@password", hashedPassword)

                rd = cmd.ExecuteReader()

                If rd.Read() Then
                    ' Ambil data ke variabel lokal dulu
                    Dim accId As Integer = Convert.ToInt32(rd("account_id"))
                    Dim accRole As String = rd("role").ToString().ToLower() ' Paksa lowercase untuk pengecekan
                    Dim accName As String = rd("name").ToString()
                    rd.Close() ' Tutup reader segera setelah data diambil

                    ' Isi Session (Variabel Global di Module)
                    CurrentID = accId
                    CurrentName = accName
                    CurrentRole = accRole

                    MessageBox.Show("Login successful. Welcome " & accName & "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()

                    ' --- REDIRECT & LOG ACTIVITY BERDASARKAN ROLE --- [cite: 2026-01-04]
                    If accRole = "admin" Then
                        ActivityLog.Show()
                        LogActivity("Admin Signed in")
                    ElseIf accRole = "counselor" Then
                        AccountCenterCounselor.Show()
                        LogActivity("Counselor Signed in")
                    Else
                        AccountCenterUser.Show()
                        LogActivity("User Signed in")
                    End If

                    ' Reset Form Login
                    txtemail.Clear()
                    txtpassword.Clear()
                    txtemail.Focus()

                Else
                    rd.Close()
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' STANDAR KEAMANAN: Selalu tutup koneksi dan bersihkan pool [cite: 2026-01-04]
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        If HasUnsavedData() Then
            Dim result = MessageBox.Show(
                "Sign In not completed. Are you sure you want to leave this page?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.No Then Exit Sub
        End If

        txtemail.Clear()
        txtpassword.Clear()
        Me.Hide()
        SignUp.Show()
    End Sub


End Class
