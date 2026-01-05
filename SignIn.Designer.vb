<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkshowpw = New System.Windows.Forms.CheckBox()
        Me.btnsignin = New System.Windows.Forms.Button()
        Me.btnsignup = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pctbExit = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.pctbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.pctbExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 51)
        Me.Panel2.TabIndex = 35
        '
        'chkshowpw
        '
        Me.chkshowpw.AutoSize = True
        Me.chkshowpw.FlatAppearance.BorderSize = 0
        Me.chkshowpw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkshowpw.Location = New System.Drawing.Point(118, 399)
        Me.chkshowpw.Name = "chkshowpw"
        Me.chkshowpw.Size = New System.Drawing.Size(150, 25)
        Me.chkshowpw.TabIndex = 30
        Me.chkshowpw.Text = "Show password"
        Me.chkshowpw.UseVisualStyleBackColor = True
        '
        'btnsignin
        '
        Me.btnsignin.BackColor = System.Drawing.Color.SandyBrown
        Me.btnsignin.FlatAppearance.BorderSize = 0
        Me.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignin.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignin.Location = New System.Drawing.Point(118, 495)
        Me.btnsignin.Name = "btnsignin"
        Me.btnsignin.Size = New System.Drawing.Size(289, 57)
        Me.btnsignin.TabIndex = 31
        Me.btnsignin.Text = "SIGN IN"
        Me.btnsignin.UseVisualStyleBackColor = False
        '
        'btnsignup
        '
        Me.btnsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignup.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignup.Location = New System.Drawing.Point(118, 586)
        Me.btnsignup.Name = "btnsignup"
        Me.btnsignup.Size = New System.Drawing.Size(289, 57)
        Me.btnsignup.TabIndex = 32
        Me.btnsignup.Text = "CREATE AN ACCOUNT"
        Me.btnsignup.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Location = New System.Drawing.Point(118, 250)
        Me.txtemail.Multiline = True
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(289, 47)
        Me.txtemail.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 27)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "EMAIL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 42)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "SIGN IN"
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Location = New System.Drawing.Point(118, 353)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(289, 21)
        Me.txtpassword.TabIndex = 29
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 27)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "PASSWORD"
        '
        'pctbExit
        '
        Me.pctbExit.Image = Global.SelfcareProject.My.Resources.Resources.icons8_close_window_100
        Me.pctbExit.Location = New System.Drawing.Point(468, 9)
        Me.pctbExit.Name = "pctbExit"
        Me.pctbExit.Size = New System.Drawing.Size(38, 35)
        Me.pctbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbExit.TabIndex = 29
        Me.pctbExit.TabStop = False
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(518, 676)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.chkshowpw)
        Me.Controls.Add(Me.btnsignin)
        Me.Controls.Add(Me.btnsignup)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Sign In"
        Me.Panel2.ResumeLayout(False)
        CType(Me.pctbExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents pctbExit As PictureBox
    Friend WithEvents chkshowpw As CheckBox
    Friend WithEvents btnsignin As Button
    Friend WithEvents btnsignup As Button
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label2 As Label
End Class
