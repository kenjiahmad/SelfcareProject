Imports System.Data.SQLite
Public Class ChangePassword
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property
    Function HasUnsavedData() As Boolean
        Return txtoldpassword.Text <> "" Or txtnewpassword.Text <> "" Or txtconfirmpassword.Text <> ""
    End Function
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If HasUnsavedData() Then
            Dim result = MessageBox.Show(
                "Password changes is not completed. Are you sure you want to leave this page?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.No Then Exit Sub
        End If

        txtoldpassword.Clear()
        txtnewpassword.Clear()
        txtconfirmpassword.Clear()
        Me.Hide()
        AccountCenterUser.Show()
    End Sub

    Private Sub chkshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkshowpassword.CheckedChanged
        Dim showPw As Boolean = chkshowpassword.Checked
        txtoldpassword.UseSystemPasswordChar = Not showPw
        txtnewpassword.UseSystemPasswordChar = Not showPw
        txtconfirmpassword.UseSystemPasswordChar = Not showPw
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' === VALIDASI KOSONG ===
        If txtoldpassword.Text = "" Or txtnewpassword.Text = "" Or txtconfirmpassword.Text = "" Then
            MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' === PASSWORD BARU & KONFIRMASI ===
        If txtnewpassword.Text <> txtconfirmpassword.Text Then
            MessageBox.Show("New password and confirmation do not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' === PASSWORD BARU TIDAK BOLEH SAMA ===
        If txtoldpassword.Text = txtnewpassword.Text Then
            MessageBox.Show("New password must be different from old password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Call koneksi()

            ' === AMBIL PASSWORD HASH DARI DB ===
            ' Menggunakan Using untuk keamanan koneksi [cite: 2026-01-04]
            Dim dbPassword As Object
            Using cmdCheck As New SQLiteCommand("SELECT password FROM account WHERE account_id = @id AND is_deleted = 0", Conn)
                cmdCheck.Parameters.AddWithValue("@id", CurrentID)
                dbPassword = cmdCheck.ExecuteScalar()
            End Using

            Dim oldHashed As String = HashPassword(txtoldpassword.Text)

            ' === CEK PASSWORD LAMA ===
            If dbPassword Is Nothing OrElse dbPassword.ToString() <> oldHashed Then
                MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' === KONFIRMASI ===
            Dim result = MessageBox.Show("Are you sure you want to change your password?", "Confirm",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then Exit Sub

            ' === UPDATE PASSWORD ===
            Dim newHashed As String = HashPassword(txtnewpassword.Text)
            Dim sqlUpdate As String = "UPDATE account SET password = @newpass WHERE account_id = @id"

            Using cmdUpdate As New SQLiteCommand(sqlUpdate, Conn)
                cmdUpdate.Parameters.AddWithValue("@newpass", newHashed)
                cmdUpdate.Parameters.AddWithValue("@id", CurrentID)
                cmdUpdate.ExecuteNonQuery()
            End Using

            ' === LOG ACTIVITY SESUAI ROLE === [cite: 2026-01-04]
            ' Menggunakan CurrentRole yang sudah di-set saat login
            If CurrentRole.ToLower() = "counselor" Then
                LogActivity("Counselor changed password")
            Else
                LogActivity("User changed password")
            End If

            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' === RESET FORM & REDIRECT SESUAI ROLE ===
            txtoldpassword.Clear()
            txtnewpassword.Clear()
            txtconfirmpassword.Clear()

            ' Penentuan form kembali berdasarkan role
            If CurrentRole.ToLower() = "counselor" Then
                AccountCenterCounselor.Show()
            Else
                AccountCenterUser.Show()
            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message)
        Finally
            ' STANDAR KEAMANAN: Selalu bersihkan pool [cite: 2026-01-04]
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
                SQLiteConnection.ClearAllPools()
            End If
        End Try
    End Sub
End Class