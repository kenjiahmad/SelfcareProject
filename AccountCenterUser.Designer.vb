<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountCenterUser
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtbirth = New System.Windows.Forms.DateTimePicker()
        Me.lbljournal = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btndelaccount = New System.Windows.Forms.Button()
        Me.btnchangepw = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbltododone = New System.Windows.Forms.Label()
        Me.lbltodo = New System.Windows.Forms.Label()
        Me.lblfinance = New System.Windows.Forms.Label()
        Me.lblmood = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.btntodo = New System.Windows.Forms.Button()
        Me.pnltodo = New System.Windows.Forms.Panel()
        Me.btnjournal = New System.Windows.Forms.Button()
        Me.pnljournal = New System.Windows.Forms.Panel()
        Me.btnmood = New System.Windows.Forms.Button()
        Me.pnlmood = New System.Windows.Forms.Panel()
        Me.btnfinance = New System.Windows.Forms.Button()
        Me.pnlfinance = New System.Windows.Forms.Panel()
        Me.btnsignout = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.pnluser = New System.Windows.Forms.Panel()
        Me.btnfindcounselor = New System.Windows.Forms.Button()
        Me.pnlfind = New System.Windows.Forms.Panel()
        Me.btncounseling = New System.Windows.Forms.Button()
        Me.pnlcounseling = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'lbljournal
        '
        Me.lbljournal.AutoSize = True
        Me.lbljournal.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljournal.Location = New System.Drawing.Point(257, 39)
        Me.lbljournal.Name = "lbljournal"
        Me.lbljournal.Size = New System.Drawing.Size(15, 21)
        Me.lbljournal.TabIndex = 47
        Me.lbljournal.Text = " "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btndelaccount)
        Me.GroupBox2.Controls.Add(Me.btnchangepw)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Controls.Add(Me.btnedit)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(556, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 305)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Actions"
        '
        'btndelaccount
        '
        Me.btndelaccount.BackColor = System.Drawing.Color.SandyBrown
        Me.btndelaccount.FlatAppearance.BorderSize = 0
        Me.btndelaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelaccount.Location = New System.Drawing.Point(17, 250)
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
        Me.btnchangepw.Location = New System.Drawing.Point(17, 180)
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
        Me.btnsave.Location = New System.Drawing.Point(17, 108)
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
        Me.btnedit.Location = New System.Drawing.Point(17, 33)
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
        Me.Label5.Location = New System.Drawing.Point(263, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 27)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Account Center"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.lblfinance)
        Me.GroupBox3.Controls.Add(Me.lblmood)
        Me.GroupBox3.Controls.Add(Me.lbljournal)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(268, 421)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(502, 203)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Overview"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbltododone)
        Me.GroupBox4.Controls.Add(Me.lbltodo)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 120)
        Me.GroupBox4.TabIndex = 50
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "To-do"
        '
        'lbltododone
        '
        Me.lbltododone.AutoSize = True
        Me.lbltododone.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltododone.Location = New System.Drawing.Point(21, 73)
        Me.lbltododone.Name = "lbltododone"
        Me.lbltododone.Size = New System.Drawing.Size(15, 21)
        Me.lbltododone.TabIndex = 50
        Me.lbltododone.Text = " "
        '
        'lbltodo
        '
        Me.lbltodo.AutoSize = True
        Me.lbltodo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltodo.Location = New System.Drawing.Point(21, 33)
        Me.lbltodo.Name = "lbltodo"
        Me.lbltodo.Size = New System.Drawing.Size(15, 21)
        Me.lbltodo.TabIndex = 46
        Me.lbltodo.Text = " "
        '
        'lblfinance
        '
        Me.lblfinance.AutoSize = True
        Me.lblfinance.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfinance.Location = New System.Drawing.Point(257, 155)
        Me.lblfinance.Name = "lblfinance"
        Me.lblfinance.Size = New System.Drawing.Size(15, 21)
        Me.lblfinance.TabIndex = 49
        Me.lblfinance.Text = " "
        '
        'lblmood
        '
        Me.lblmood.AutoSize = True
        Me.lblmood.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmood.Location = New System.Drawing.Point(257, 96)
        Me.lblmood.Name = "lblmood"
        Me.lblmood.Size = New System.Drawing.Size(15, 21)
        Me.lblmood.TabIndex = 48
        Me.lblmood.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 27)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "You have:"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtage)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtbirth)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(268, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 305)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Information"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.lblwelcome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 49)
        Me.Panel2.TabIndex = 52
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
        'btntodo
        '
        Me.btntodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btntodo.FlatAppearance.BorderSize = 0
        Me.btntodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntodo.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btntodo.Image = Global.SelfcareProject.My.Resources.Resources.icons8_to_do_list_25
        Me.btntodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntodo.Location = New System.Drawing.Point(0, 165)
        Me.btntodo.Name = "btntodo"
        Me.btntodo.Size = New System.Drawing.Size(235, 57)
        Me.btntodo.TabIndex = 0
        Me.btntodo.Text = "To-do List"
        Me.btntodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntodo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btntodo.UseVisualStyleBackColor = True
        '
        'pnltodo
        '
        Me.pnltodo.BackColor = System.Drawing.Color.Chocolate
        Me.pnltodo.Location = New System.Drawing.Point(0, 165)
        Me.pnltodo.Name = "pnltodo"
        Me.pnltodo.Size = New System.Drawing.Size(18, 57)
        Me.pnltodo.TabIndex = 29
        Me.pnltodo.Visible = False
        '
        'btnjournal
        '
        Me.btnjournal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnjournal.FlatAppearance.BorderSize = 0
        Me.btnjournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnjournal.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjournal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnjournal.Image = Global.SelfcareProject.My.Resources.Resources.icons8_journal_25
        Me.btnjournal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnjournal.Location = New System.Drawing.Point(0, 225)
        Me.btnjournal.Name = "btnjournal"
        Me.btnjournal.Size = New System.Drawing.Size(235, 57)
        Me.btnjournal.TabIndex = 30
        Me.btnjournal.Text = "Journal"
        Me.btnjournal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnjournal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnjournal.UseVisualStyleBackColor = True
        '
        'pnljournal
        '
        Me.pnljournal.BackColor = System.Drawing.Color.Chocolate
        Me.pnljournal.Location = New System.Drawing.Point(0, 225)
        Me.pnljournal.Name = "pnljournal"
        Me.pnljournal.Size = New System.Drawing.Size(18, 57)
        Me.pnljournal.TabIndex = 31
        Me.pnljournal.Visible = False
        '
        'btnmood
        '
        Me.btnmood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnmood.FlatAppearance.BorderSize = 0
        Me.btnmood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmood.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmood.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmood.Image = Global.SelfcareProject.My.Resources.Resources.icons8_happy_24
        Me.btnmood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmood.Location = New System.Drawing.Point(0, 285)
        Me.btnmood.Name = "btnmood"
        Me.btnmood.Size = New System.Drawing.Size(235, 57)
        Me.btnmood.TabIndex = 32
        Me.btnmood.Text = "Mood Tracker"
        Me.btnmood.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmood.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnmood.UseVisualStyleBackColor = True
        '
        'pnlmood
        '
        Me.pnlmood.BackColor = System.Drawing.Color.Chocolate
        Me.pnlmood.Location = New System.Drawing.Point(0, 285)
        Me.pnlmood.Name = "pnlmood"
        Me.pnlmood.Size = New System.Drawing.Size(18, 57)
        Me.pnlmood.TabIndex = 33
        Me.pnlmood.Visible = False
        '
        'btnfinance
        '
        Me.btnfinance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnfinance.FlatAppearance.BorderSize = 0
        Me.btnfinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfinance.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfinance.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfinance.Image = Global.SelfcareProject.My.Resources.Resources.icons8_card_wallet_25
        Me.btnfinance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnfinance.Location = New System.Drawing.Point(0, 345)
        Me.btnfinance.Name = "btnfinance"
        Me.btnfinance.Size = New System.Drawing.Size(235, 57)
        Me.btnfinance.TabIndex = 34
        Me.btnfinance.Text = "Finance Tracker"
        Me.btnfinance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnfinance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnfinance.UseVisualStyleBackColor = True
        '
        'pnlfinance
        '
        Me.pnlfinance.BackColor = System.Drawing.Color.Chocolate
        Me.pnlfinance.Location = New System.Drawing.Point(0, 345)
        Me.pnlfinance.Name = "pnlfinance"
        Me.pnlfinance.Size = New System.Drawing.Size(18, 57)
        Me.pnlfinance.TabIndex = 35
        Me.pnlfinance.Visible = False
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
        'btnuser
        '
        Me.btnuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnuser.FlatAppearance.BorderSize = 0
        Me.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuser.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnuser.Image = Global.SelfcareProject.My.Resources.Resources.icons8_user_25
        Me.btnuser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnuser.Location = New System.Drawing.Point(0, 105)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(235, 57)
        Me.btnuser.TabIndex = 37
        Me.btnuser.Text = "Account Center"
        Me.btnuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnuser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnuser.UseVisualStyleBackColor = True
        '
        'pnluser
        '
        Me.pnluser.BackColor = System.Drawing.Color.Chocolate
        Me.pnluser.Location = New System.Drawing.Point(0, 105)
        Me.pnluser.Name = "pnluser"
        Me.pnluser.Size = New System.Drawing.Size(18, 57)
        Me.pnluser.TabIndex = 38
        Me.pnluser.Visible = False
        '
        'btnfindcounselor
        '
        Me.btnfindcounselor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnfindcounselor.FlatAppearance.BorderSize = 0
        Me.btnfindcounselor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfindcounselor.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindcounselor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfindcounselor.Image = Global.SelfcareProject.My.Resources.Resources.icons8_find_24
        Me.btnfindcounselor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnfindcounselor.Location = New System.Drawing.Point(0, 405)
        Me.btnfindcounselor.Name = "btnfindcounselor"
        Me.btnfindcounselor.Size = New System.Drawing.Size(235, 57)
        Me.btnfindcounselor.TabIndex = 39
        Me.btnfindcounselor.Text = "Find Counselor"
        Me.btnfindcounselor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnfindcounselor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnfindcounselor.UseVisualStyleBackColor = True
        '
        'pnlfind
        '
        Me.pnlfind.BackColor = System.Drawing.Color.Chocolate
        Me.pnlfind.Location = New System.Drawing.Point(0, 405)
        Me.pnlfind.Name = "pnlfind"
        Me.pnlfind.Size = New System.Drawing.Size(18, 57)
        Me.pnlfind.TabIndex = 40
        Me.pnlfind.Visible = False
        '
        'btncounseling
        '
        Me.btncounseling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncounseling.FlatAppearance.BorderSize = 0
        Me.btncounseling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncounseling.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncounseling.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncounseling.Image = Global.SelfcareProject.My.Resources.Resources.icons8_consultation_25__1_
        Me.btncounseling.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncounseling.Location = New System.Drawing.Point(0, 465)
        Me.btncounseling.Name = "btncounseling"
        Me.btncounseling.Size = New System.Drawing.Size(235, 57)
        Me.btncounseling.TabIndex = 41
        Me.btncounseling.Text = "Counseling"
        Me.btncounseling.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncounseling.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btncounseling.UseVisualStyleBackColor = True
        '
        'pnlcounseling
        '
        Me.pnlcounseling.BackColor = System.Drawing.Color.Chocolate
        Me.pnlcounseling.Location = New System.Drawing.Point(0, 465)
        Me.pnlcounseling.Name = "pnlcounseling"
        Me.pnlcounseling.Size = New System.Drawing.Size(18, 57)
        Me.pnlcounseling.TabIndex = 42
        Me.pnlcounseling.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.pnlcounseling)
        Me.Panel1.Controls.Add(Me.btncounseling)
        Me.Panel1.Controls.Add(Me.pnlfind)
        Me.Panel1.Controls.Add(Me.btnfindcounselor)
        Me.Panel1.Controls.Add(Me.pnluser)
        Me.Panel1.Controls.Add(Me.btnuser)
        Me.Panel1.Controls.Add(Me.btnsignout)
        Me.Panel1.Controls.Add(Me.pnlfinance)
        Me.Panel1.Controls.Add(Me.btnfinance)
        Me.Panel1.Controls.Add(Me.pnlmood)
        Me.Panel1.Controls.Add(Me.btnmood)
        Me.Panel1.Controls.Add(Me.pnljournal)
        Me.Panel1.Controls.Add(Me.btnjournal)
        Me.Panel1.Controls.Add(Me.pnltodo)
        Me.Panel1.Controls.Add(Me.btntodo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 595)
        Me.Panel1.TabIndex = 53
        '
        'AccountCenterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(800, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AccountCenterUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountCenterUser"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents dtbirth As DateTimePicker
    Friend WithEvents lbljournal As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btndelaccount As Button
    Friend WithEvents btnchangepw As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbltododone As Label
    Friend WithEvents lbltodo As Label
    Friend WithEvents lblfinance As Label
    Friend WithEvents lblmood As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblwelcome As Label
    Friend WithEvents btntodo As Button
    Friend WithEvents pnltodo As Panel
    Friend WithEvents btnjournal As Button
    Friend WithEvents pnljournal As Panel
    Friend WithEvents btnmood As Button
    Friend WithEvents pnlmood As Panel
    Friend WithEvents btnfinance As Button
    Friend WithEvents pnlfinance As Panel
    Friend WithEvents btnsignout As Button
    Friend WithEvents btnuser As Button
    Friend WithEvents pnluser As Panel
    Friend WithEvents btnfindcounselor As Button
    Friend WithEvents pnlfind As Panel
    Friend WithEvents btncounseling As Button
    Friend WithEvents pnlcounseling As Panel
    Friend WithEvents Panel1 As Panel
End Class
