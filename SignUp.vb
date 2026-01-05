Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class SignUp
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000 ' Mematikan Flicker (WS_EX_COMPOSITED)
            Return cp
        End Get
    End Property
    Function HasUnsavedData() As Boolean
        Return txtname.Text <> "" _
            Or txtemail.Text <> "" _
            Or txtpassword.Text <> "" _
            Or cbrole.SelectedIndex <> -1
    End Function
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        txtname.Focus()

        With txtpassword
            .AutoSize = False
            .Height = 23
        End With
    End Sub

    Private Sub btnsignin_Click(sender As Object, e As EventArgs) Handles btnsignin.Click
        If HasUnsavedData() Then
            If MessageBox.Show(
                "You have unsaved changes. Leave this page?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) = DialogResult.No Then Exit Sub
        End If

        Me.Close()
        SignIn.Show()
    End Sub

    Private Sub btnsignup_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        ' 1. VALIDASI KOSONG
        If txtname.Text = "" Or cbrole.Text = "" Or txtemail.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Please complete all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. VALIDASI FORMAT EMAIL
        If Not txtemail.Text.Contains("@") Or Not txtemail.Text.Contains(".") Then
            MessageBox.Show("Please enter a valid email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Call koneksi()

            ' 3. CEK APAKAH EMAIL SUDAH TERDAFTAR (Gunakan @email, bukan ?)
            cmd = New SQLiteCommand("SELECT COUNT(*) FROM account WHERE email = @email AND is_deleted = 0", Conn)
            cmd.Parameters.AddWithValue("@email", txtemail.Text)

            Dim emailExists As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If emailExists > 0 Then
                MessageBox.Show("Email is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' 4. PROSES INSERT
            Dim hashedPassword As String = HashPassword(txtpassword.Text)
            Dim sqlInsert As String = "INSERT INTO account (name, birth_date, role, email, password, created_at, is_deleted) " &
                                       "VALUES (@name, @birth, @role, @email, @pw, @created, 0)"

            cmd = New SQLiteCommand(sqlInsert, Conn)
            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@birth", dtbirth.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@role", cbrole.Text.ToLower())
            cmd.Parameters.AddWithValue("@email", txtemail.Text)
            cmd.Parameters.AddWithValue("@pw", hashedPassword)
            cmd.Parameters.AddWithValue("@created", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

            cmd.ExecuteNonQuery()
            LogActivity("New account registered: " & txtemail.Text)
            MessageBox.Show("Registration successful. Please sign in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
            SignIn.Show()

        Catch ex As Exception
            MessageBox.Show("Registration failed: " & ex.Message)
        End Try
    End Sub

    Private Sub chkshowpw_CheckedChanged(sender As Object, e As EventArgs) Handles chkshowpw.CheckedChanged
        txtpassword.UseSystemPasswordChar = Not chkshowpw.Checked
    End Sub
End Class