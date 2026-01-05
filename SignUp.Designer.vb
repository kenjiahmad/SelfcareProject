<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkshowpw = New System.Windows.Forms.CheckBox()
        Me.dtbirth = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnsignup = New System.Windows.Forms.Button()
        Me.btnsignin = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbrole = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtpassword)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtemail)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkshowpw)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(43, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 171)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Account"
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Location = New System.Drawing.Point(357, 84)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(260, 21)
        Me.txtpassword.TabIndex = 5
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 27)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "EMAIL"
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Location = New System.Drawing.Point(25, 84)
        Me.txtemail.Multiline = True
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(260, 38)
        Me.txtemail.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 27)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "PASSWORD"
        '
        'chkshowpw
        '
        Me.chkshowpw.AutoSize = True
        Me.chkshowpw.FlatAppearance.BorderSize = 0
        Me.chkshowpw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkshowpw.Location = New System.Drawing.Point(357, 128)
        Me.chkshowpw.Name = "chkshowpw"
        Me.chkshowpw.Size = New System.Drawing.Size(150, 25)
        Me.chkshowpw.TabIndex = 6
        Me.chkshowpw.Text = "Show password"
        Me.chkshowpw.UseVisualStyleBackColor = True
        '
        'dtbirth
        '
        Me.dtbirth.Location = New System.Drawing.Point(24, 147)
        Me.dtbirth.Name = "dtbirth"
        Me.dtbirth.Size = New System.Drawing.Size(260, 28)
        Me.dtbirth.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 36)
        Me.Panel2.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 27)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "BIRTH"
        '
        'btnsignup
        '
        Me.btnsignup.BackColor = System.Drawing.Color.SandyBrown
        Me.btnsignup.FlatAppearance.BorderSize = 0
        Me.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignup.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignup.Location = New System.Drawing.Point(400, 566)
        Me.btnsignup.Name = "btnsignup"
        Me.btnsignup.Size = New System.Drawing.Size(285, 54)
        Me.btnsignup.TabIndex = 47
        Me.btnsignup.Text = "SIGN UP"
        Me.btnsignup.UseVisualStyleBackColor = False
        '
        'btnsignin
        '
        Me.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignin.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignin.Location = New System.Drawing.Point(44, 566)
        Me.btnsignin.Name = "btnsignin"
        Me.btnsignin.Size = New System.Drawing.Size(284, 54)
        Me.btnsignin.TabIndex = 48
        Me.btnsignin.Text = "I HAVE AN ACCOUNT"
        Me.btnsignin.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtname.Location = New System.Drawing.Point(140, 48)
        Me.txtname.Multiline = True
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(476, 38)
        Me.txtname.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 27)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "NAME"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.dtbirth)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbrole)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(44, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 215)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(351, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 27)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "ROLE"
        '
        'cbrole
        '
        Me.cbrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbrole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbrole.FormattingEnabled = True
        Me.cbrole.Items.AddRange(New Object() {"user", "counselor"})
        Me.cbrole.Location = New System.Drawing.Point(356, 147)
        Me.cbrole.Name = "cbrole"
        Me.cbrole.Size = New System.Drawing.Size(260, 29)
        Me.cbrole.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 42)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "SIGN UP"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(728, 650)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnsignup)
        Me.Controls.Add(Me.btnsignin)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkshowpw As CheckBox
    Friend WithEvents dtbirth As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnsignup As Button
    Friend WithEvents btnsignin As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbrole As ComboBox
    Friend WithEvents Label1 As Label
End Class
