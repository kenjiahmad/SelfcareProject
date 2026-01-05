<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinanceTracker
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbexpense = New System.Windows.Forms.RadioButton()
        Me.rbincome = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.lbltotalincome = New System.Windows.Forms.Label()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.lbltotalexpense = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lblblnc = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtsearch = New System.Windows.Forms.DateTimePicker()
        Me.dgvfinance = New System.Windows.Forms.DataGridView()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlcounseling = New System.Windows.Forms.Panel()
        Me.btncounseling = New System.Windows.Forms.Button()
        Me.pnlfind = New System.Windows.Forms.Panel()
        Me.btnfindcounselor = New System.Windows.Forms.Button()
        Me.pnluser = New System.Windows.Forms.Panel()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnsignout = New System.Windows.Forms.Button()
        Me.pnlfinance = New System.Windows.Forms.Panel()
        Me.btnfinance = New System.Windows.Forms.Button()
        Me.pnlmood = New System.Windows.Forms.Panel()
        Me.btnmood = New System.Windows.Forms.Button()
        Me.pnljournal = New System.Windows.Forms.Panel()
        Me.btnjournal = New System.Windows.Forms.Button()
        Me.pnltodo = New System.Windows.Forms.Panel()
        Me.btntodo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvfinance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbexpense)
        Me.GroupBox1.Controls.Add(Me.rbincome)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(260, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 71)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction Type"
        '
        'rbexpense
        '
        Me.rbexpense.AutoSize = True
        Me.rbexpense.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbexpense.Location = New System.Drawing.Point(115, 28)
        Me.rbexpense.Name = "rbexpense"
        Me.rbexpense.Size = New System.Drawing.Size(97, 25)
        Me.rbexpense.TabIndex = 1
        Me.rbexpense.TabStop = True
        Me.rbexpense.Text = "Expense"
        Me.rbexpense.UseVisualStyleBackColor = True
        '
        'rbincome
        '
        Me.rbincome.AutoSize = True
        Me.rbincome.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbincome.Location = New System.Drawing.Point(22, 28)
        Me.rbincome.Name = "rbincome"
        Me.rbincome.Size = New System.Drawing.Size(92, 25)
        Me.rbincome.TabIndex = 0
        Me.rbincome.TabStop = True
        Me.rbincome.Text = "Income"
        Me.rbincome.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.lblwelcome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 49)
        Me.Panel2.TabIndex = 83
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
        'txtdescription
        '
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescription.Location = New System.Drawing.Point(260, 228)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(226, 42)
        Me.txtdescription.TabIndex = 94
        '
        'lbltotalincome
        '
        Me.lbltotalincome.AutoSize = True
        Me.lbltotalincome.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalincome.Location = New System.Drawing.Point(505, 226)
        Me.lbltotalincome.Name = "lbltotalincome"
        Me.lbltotalincome.Size = New System.Drawing.Size(15, 24)
        Me.lbltotalincome.TabIndex = 99
        Me.lbltotalincome.Text = " "
        '
        'lblbalance
        '
        Me.lblbalance.AutoSize = True
        Me.lblbalance.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.Location = New System.Drawing.Point(505, 145)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(18, 27)
        Me.lblbalance.TabIndex = 97
        Me.lblbalance.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(257, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(504, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 25)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "Total Expense"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(504, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Total Income"
        '
        'txtamount
        '
        Me.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtamount.Location = New System.Drawing.Point(260, 305)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(226, 21)
        Me.txtamount.TabIndex = 96
        '
        'lbltotalexpense
        '
        Me.lbltotalexpense.AutoSize = True
        Me.lbltotalexpense.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalexpense.Location = New System.Drawing.Point(505, 305)
        Me.lbltotalexpense.Name = "lbltotalexpense"
        Me.lbltotalexpense.Size = New System.Drawing.Size(15, 24)
        Me.lbltotalexpense.TabIndex = 101
        Me.lbltotalexpense.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 27)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Finance Tracker"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.BurlyWood
        Me.btnadd.FlatAppearance.BorderSize = 0
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(261, 356)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(225, 38)
        Me.btnadd.TabIndex = 90
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lblblnc
        '
        Me.lblblnc.AutoSize = True
        Me.lblblnc.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblblnc.Location = New System.Drawing.Point(504, 116)
        Me.lblblnc.Name = "lblblnc"
        Me.lblblnc.Size = New System.Drawing.Size(91, 27)
        Me.lblblnc.TabIndex = 89
        Me.lblblnc.Text = "Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 412)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Search by due:"
        '
        'dtsearch
        '
        Me.dtsearch.Location = New System.Drawing.Point(418, 410)
        Me.dtsearch.Name = "dtsearch"
        Me.dtsearch.Size = New System.Drawing.Size(316, 28)
        Me.dtsearch.TabIndex = 86
        '
        'dgvfinance
        '
        Me.dgvfinance.BackgroundColor = System.Drawing.Color.MistyRose
        Me.dgvfinance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfinance.Location = New System.Drawing.Point(260, 447)
        Me.dgvfinance.Name = "dgvfinance"
        Me.dgvfinance.RowHeadersWidth = 62
        Me.dgvfinance.RowTemplate.Height = 28
        Me.dgvfinance.Size = New System.Drawing.Size(474, 173)
        Me.dgvfinance.TabIndex = 85
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.BurlyWood
        Me.btndelete.FlatAppearance.BorderSize = 0
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(509, 356)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(225, 38)
        Me.btndelete.TabIndex = 92
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 102
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
        'pnluser
        '
        Me.pnluser.BackColor = System.Drawing.Color.Chocolate
        Me.pnluser.Location = New System.Drawing.Point(0, 105)
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
        Me.btnuser.Location = New System.Drawing.Point(0, 105)
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
        'FinanceTracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(760, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.lbltotalincome)
        Me.Controls.Add(Me.lblbalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.lbltotalexpense)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lblblnc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtsearch)
        Me.Controls.Add(Me.dgvfinance)
        Me.Controls.Add(Me.btndelete)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FinanceTracker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FinanceTracker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvfinance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbexpense As RadioButton
    Friend WithEvents rbincome As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblwelcome As Label
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents lbltotalincome As Label
    Friend WithEvents lblbalance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtamount As TextBox
    Friend WithEvents lbltotalexpense As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents lblblnc As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtsearch As DateTimePicker
    Friend WithEvents dgvfinance As DataGridView
    Friend WithEvents btndelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlcounseling As Panel
    Friend WithEvents btncounseling As Button
    Friend WithEvents pnlfind As Panel
    Friend WithEvents btnfindcounselor As Button
    Friend WithEvents pnluser As Panel
    Friend WithEvents btnuser As Button
    Friend WithEvents btnsignout As Button
    Friend WithEvents pnlfinance As Panel
    Friend WithEvents btnfinance As Button
    Friend WithEvents pnlmood As Panel
    Friend WithEvents btnmood As Button
    Friend WithEvents pnljournal As Panel
    Friend WithEvents btnjournal As Button
    Friend WithEvents pnltodo As Panel
    Friend WithEvents btntodo As Button
End Class
