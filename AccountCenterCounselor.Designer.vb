<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountCenterCounselor
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnluser = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btndelaccount = New System.Windows.Forms.Button()
        Me.btnchangepw = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtspecialist = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtbirth = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnreq = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnsignout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnreq)
        Me.Panel1.Controls.Add(Me.pnluser)
        Me.Panel1.Controls.Add(Me.btnuser)
        Me.Panel1.Controls.Add(Me.btnsignout)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 595)
        Me.Panel1.TabIndex = 59
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Chocolate
        Me.Panel3.Location = New System.Drawing.Point(0, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(18, 57)
        Me.Panel3.TabIndex = 40
        Me.Panel3.Visible = False
        '
        'pnluser
        '
        Me.pnluser.BackColor = System.Drawing.Color.Chocolate
        Me.pnluser.Location = New System.Drawing.Point(0, 137)
        Me.pnluser.Name = "pnluser"
        Me.pnluser.Size = New System.Drawing.Size(18, 57)
        Me.pnluser.TabIndex = 38
        Me.pnluser.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.lblwelcome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 49)
        Me.Panel2.TabIndex = 58
        '
        'lblwelcome
        '
        Me.lblwelcome.AutoSize = True
        Me.lblwelcome.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblwelcome.Location = New System.Drawing.Point(12, 9)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(18, 27)
        Me.lblwelcome.TabIndex = 29
        Me.lblwelcome.Text = " "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btndelaccount)
        Me.GroupBox2.Controls.Add(Me.btnchangepw)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Controls.Add(Me.btnedit)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(250, 418)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(538, 190)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'btndelaccount
        '
        Me.btndelaccount.BackColor = System.Drawing.Color.SandyBrown
        Me.btndelaccount.FlatAppearance.BorderSize = 0
        Me.btndelaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelaccount.Location = New System.Drawing.Point(320, 118)
        Me.btndelaccount.Name = "btndelaccount"
        Me.btndelaccount.Size = New System.Drawing.Size(179, 40)
        Me.btndelaccount.TabIndex = 3
        Me.btndelaccount.Text = "Delete Account"
        Me.btndelaccount.UseVisualStyleBackColor = False
        '
        'btnchangepw
        '
        Me.btnchangepw.BackColor = System.Drawing.Color.SandyBrown
        Me.btnchangepw.FlatAppearance.BorderSize = 0
        Me.btnchangepw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchangepw.Location = New System.Drawing.Point(45, 118)
        Me.btnchangepw.Name = "btnchangepw"
        Me.btnchangepw.Size = New System.Drawing.Size(179, 40)
        Me.btnchangepw.TabIndex = 2
        Me.btnchangepw.Text = "Change Password"
        Me.btnchangepw.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.SandyBrown
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(320, 33)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(179, 40)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save Change"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.SandyBrown
        Me.btnedit.FlatAppearance.BorderSize = 0
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Location = New System.Drawing.Point(45, 33)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(179, 40)
        Me.btnedit.TabIndex = 0
        Me.btnedit.Text = "Edit Information"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(263, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 27)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Account Center"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtspecialist)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtbirth)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(250, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 305)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Information"
        '
        'txtbio
        '
        Me.txtbio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbio.Enabled = False
        Me.txtbio.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbio.Location = New System.Drawing.Point(289, 127)
        Me.txtbio.Multiline = True
        Me.txtbio.Name = "txtbio"
        Me.txtbio.Size = New System.Drawing.Size(236, 163)
        Me.txtbio.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 21)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Bio"
        '
        'txtspecialist
        '
        Me.txtspecialist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtspecialist.Enabled = False
        Me.txtspecialist.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtspecialist.Location = New System.Drawing.Point(289, 61)
        Me.txtspecialist.Name = "txtspecialist"
        Me.txtspecialist.Size = New System.Drawing.Size(236, 21)
        Me.txtspecialist.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 21)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Specialist"
        '
        'txtage
        '
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtage.Enabled = False
        Me.txtage.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(18, 269)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(233, 21)
        Me.txtage.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 21)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Age"
        '
        'dtbirth
        '
        Me.dtbirth.Location = New System.Drawing.Point(13, 195)
        Me.dtbirth.Name = "dtbirth"
        Me.dtbirth.Size = New System.Drawing.Size(236, 28)
        Me.dtbirth.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Birth"
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Enabled = False
        Me.txtemail.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(16, 127)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(233, 21)
        Me.txtemail.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 21)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Email"
        '
        'txtname
        '
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(13, 61)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(236, 21)
        Me.txtname.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 21)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Name"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Chocolate
        Me.Panel4.Location = New System.Drawing.Point(0, 257)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(18, 57)
        Me.Panel4.TabIndex = 42
        Me.Panel4.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = Global.SelfcareProject.My.Resources.Resources.icons8_consultation_25__1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(0, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 57)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Chat Room"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnreq
        '
        Me.btnreq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnreq.FlatAppearance.BorderSize = 0
        Me.btnreq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreq.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreq.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnreq.Image = Global.SelfcareProject.My.Resources.Resources.icons8_request_25
        Me.btnreq.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreq.Location = New System.Drawing.Point(0, 197)
        Me.btnreq.Name = "btnreq"
        Me.btnreq.Size = New System.Drawing.Size(235, 57)
        Me.btnreq.TabIndex = 39
        Me.btnreq.Text = "Chat Request"
        Me.btnreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreq.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnreq.UseVisualStyleBackColor = True
        '
        'btnuser
        '
        Me.btnuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnuser.FlatAppearance.BorderSize = 0
        Me.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuser.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnuser.Image = Global.SelfcareProject.My.Resources.Resources.icons8_user_25
        Me.btnuser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnuser.Location = New System.Drawing.Point(0, 137)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(235, 57)
        Me.btnuser.TabIndex = 37
        Me.btnuser.Text = "Account Center"
        Me.btnuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnuser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnuser.UseVisualStyleBackColor = True
        '
        'btnsignout
        '
        Me.btnsignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnsignout.FlatAppearance.BorderSize = 0
        Me.btnsignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignout.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsignout.Image = Global.SelfcareProject.My.Resources.Resources.icons8_logout_25
        Me.btnsignout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsignout.Location = New System.Drawing.Point(0, 535)
        Me.btnsignout.Name = "btnsignout"
        Me.btnsignout.Size = New System.Drawing.Size(235, 57)
        Me.btnsignout.TabIndex = 36
        Me.btnsignout.Text = "Sign Out"
        Me.btnsignout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsignout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnsignout.UseVisualStyleBackColor = True
        '
        'AccountCenterCounselor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(800, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountCenterCounselor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountCenterCounselor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnreq As Button
    Friend WithEvents pnluser As Panel
    Friend WithEvents btnuser As Button
    Friend WithEvents btnsignout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblwelcome As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btndelaccount As Button
    Friend WithEvents btnchangepw As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtbirth As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtspecialist As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
End Class
