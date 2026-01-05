<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatRoom
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pnlcounseling = New System.Windows.Forms.Panel()
        Me.btncounseling = New System.Windows.Forms.Button()
        Me.pnlfind = New System.Windows.Forms.Panel()
        Me.btnfindcounselor = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.pnlfinance = New System.Windows.Forms.Panel()
        Me.btnfinance = New System.Windows.Forms.Button()
        Me.pnlmood = New System.Windows.Forms.Panel()
        Me.btnmood = New System.Windows.Forms.Button()
        Me.pnljournal = New System.Windows.Forms.Panel()
        Me.btnjournal = New System.Windows.Forms.Button()
        Me.pnltodo = New System.Windows.Forms.Panel()
        Me.btntodo = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnreq = New System.Windows.Forms.Button()
        Me.pnluser = New System.Windows.Forms.Panel()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnsignout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.flpchat = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblchatwith = New System.Windows.Forms.Label()
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.btnsend = New System.Windows.Forms.Button()
        Me.dgvactivechats = New System.Windows.Forms.DataGridView()
        Me.tmrchat = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dgvactivechats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.Panel5)
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
        Me.Panel1.Size = New System.Drawing.Size(235, 651)
        Me.Panel1.TabIndex = 61
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel5.Controls.Add(Me.pnlcounseling)
        Me.Panel5.Controls.Add(Me.btncounseling)
        Me.Panel5.Controls.Add(Me.pnlfind)
        Me.Panel5.Controls.Add(Me.btnfindcounselor)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Button3)
        Me.Panel5.Controls.Add(Me.pnlfinance)
        Me.Panel5.Controls.Add(Me.btnfinance)
        Me.Panel5.Controls.Add(Me.pnlmood)
        Me.Panel5.Controls.Add(Me.btnmood)
        Me.Panel5.Controls.Add(Me.pnljournal)
        Me.Panel5.Controls.Add(Me.btnjournal)
        Me.Panel5.Controls.Add(Me.pnltodo)
        Me.Panel5.Controls.Add(Me.btntodo)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(235, 651)
        Me.Panel5.TabIndex = 54
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
        'pnlfind
        '
        Me.pnlfind.BackColor = System.Drawing.Color.Chocolate
        Me.pnlfind.Location = New System.Drawing.Point(0, 405)
        Me.pnlfind.Name = "pnlfind"
        Me.pnlfind.Size = New System.Drawing.Size(18, 57)
        Me.pnlfind.TabIndex = 40
        Me.pnlfind.Visible = False
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
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Chocolate
        Me.Panel6.Location = New System.Drawing.Point(0, 105)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(18, 57)
        Me.Panel6.TabIndex = 38
        Me.Panel6.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = Global.SelfcareProject.My.Resources.Resources.icons8_user_25
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(0, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 57)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Account Center"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Image = Global.SelfcareProject.My.Resources.Resources.icons8_logout_25
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(0, 591)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(235, 57)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Sign Out"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = True
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
        'pnlmood
        '
        Me.pnlmood.BackColor = System.Drawing.Color.Chocolate
        Me.pnlmood.Location = New System.Drawing.Point(0, 285)
        Me.pnlmood.Name = "pnlmood"
        Me.pnlmood.Size = New System.Drawing.Size(18, 57)
        Me.pnlmood.TabIndex = 33
        Me.pnlmood.Visible = False
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
        'pnljournal
        '
        Me.pnljournal.BackColor = System.Drawing.Color.Chocolate
        Me.pnljournal.Location = New System.Drawing.Point(0, 225)
        Me.pnljournal.Name = "pnljournal"
        Me.pnljournal.Size = New System.Drawing.Size(18, 57)
        Me.pnljournal.TabIndex = 31
        Me.pnljournal.Visible = False
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
        'pnltodo
        '
        Me.pnltodo.BackColor = System.Drawing.Color.Chocolate
        Me.pnltodo.Location = New System.Drawing.Point(0, 165)
        Me.pnltodo.Name = "pnltodo"
        Me.pnltodo.Size = New System.Drawing.Size(18, 57)
        Me.pnltodo.TabIndex = 29
        Me.pnltodo.Visible = False
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Chocolate
        Me.Panel3.Location = New System.Drawing.Point(0, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(18, 57)
        Me.Panel3.TabIndex = 40
        Me.Panel3.Visible = False
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
        'pnluser
        '
        Me.pnluser.BackColor = System.Drawing.Color.Chocolate
        Me.pnluser.Location = New System.Drawing.Point(0, 137)
        Me.pnluser.Name = "pnluser"
        Me.pnluser.Size = New System.Drawing.Size(18, 57)
        Me.pnluser.TabIndex = 38
        Me.pnluser.Visible = False
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
        Me.btnsignout.Location = New System.Drawing.Point(0, 590)
        Me.btnsignout.Name = "btnsignout"
        Me.btnsignout.Size = New System.Drawing.Size(235, 57)
        Me.btnsignout.TabIndex = 36
        Me.btnsignout.Text = "Sign Out"
        Me.btnsignout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsignout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnsignout.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.lblwelcome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(917, 49)
        Me.Panel2.TabIndex = 60
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(917, 49)
        Me.Panel7.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 27)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = " "
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
        'flpchat
        '
        Me.flpchat.Location = New System.Drawing.Point(474, 104)
        Me.flpchat.Name = "flpchat"
        Me.flpchat.Size = New System.Drawing.Size(431, 529)
        Me.flpchat.TabIndex = 63
        '
        'lblchatwith
        '
        Me.lblchatwith.AutoSize = True
        Me.lblchatwith.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchatwith.Location = New System.Drawing.Point(474, 64)
        Me.lblchatwith.Name = "lblchatwith"
        Me.lblchatwith.Size = New System.Drawing.Size(21, 27)
        Me.lblchatwith.TabIndex = 64
        Me.lblchatwith.Text = "-"
        '
        'txtmessage
        '
        Me.txtmessage.Location = New System.Drawing.Point(479, 640)
        Me.txtmessage.Multiline = True
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(357, 48)
        Me.txtmessage.TabIndex = 65
        '
        'btnsend
        '
        Me.btnsend.Image = Global.SelfcareProject.My.Resources.Resources.icons8_send_30__1_
        Me.btnsend.Location = New System.Drawing.Point(843, 640)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(62, 48)
        Me.btnsend.TabIndex = 66
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'dgvactivechats
        '
        Me.dgvactivechats.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvactivechats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvactivechats.Location = New System.Drawing.Point(241, 58)
        Me.dgvactivechats.Name = "dgvactivechats"
        Me.dgvactivechats.RowHeadersWidth = 62
        Me.dgvactivechats.RowTemplate.Height = 28
        Me.dgvactivechats.Size = New System.Drawing.Size(227, 630)
        Me.dgvactivechats.TabIndex = 67
        '
        'tmrchat
        '
        Me.tmrchat.Interval = 2000
        '
        'ChatRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(917, 700)
        Me.Controls.Add(Me.dgvactivechats)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.txtmessage)
        Me.Controls.Add(Me.lblchatwith)
        Me.Controls.Add(Me.flpchat)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChatRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChatRoom"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.dgvactivechats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnreq As Button
    Friend WithEvents pnluser As Panel
    Friend WithEvents btnuser As Button
    Friend WithEvents btnsignout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblwelcome As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pnlcounseling As Panel
    Friend WithEvents btncounseling As Button
    Friend WithEvents pnlfind As Panel
    Friend WithEvents btnfindcounselor As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents pnlfinance As Panel
    Friend WithEvents btnfinance As Button
    Friend WithEvents pnlmood As Panel
    Friend WithEvents btnmood As Button
    Friend WithEvents pnljournal As Panel
    Friend WithEvents btnjournal As Button
    Friend WithEvents pnltodo As Panel
    Friend WithEvents btntodo As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents flpchat As FlowLayoutPanel
    Friend WithEvents lblchatwith As Label
    Friend WithEvents txtmessage As TextBox
    Friend WithEvents btnsend As Button
    Friend WithEvents dgvactivechats As DataGridView
    Friend WithEvents tmrchat As Timer
End Class
