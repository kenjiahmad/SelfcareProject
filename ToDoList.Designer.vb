<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ToDoList
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
        Me.btnhistory = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.dtdue = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtsearch = New System.Windows.Forms.DateTimePicker()
        Me.dgvtodo = New System.Windows.Forms.DataGridView()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnshowall = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlcounseling = New System.Windows.Forms.Panel()
        Me.pnlfind = New System.Windows.Forms.Panel()
        Me.pnluser = New System.Windows.Forms.Panel()
        Me.pnlfinance = New System.Windows.Forms.Panel()
        Me.pnlmood = New System.Windows.Forms.Panel()
        Me.pnljournal = New System.Windows.Forms.Panel()
        Me.pnltodo = New System.Windows.Forms.Panel()
        Me.btncounseling = New System.Windows.Forms.Button()
        Me.btnfindcounselor = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnsignout = New System.Windows.Forms.Button()
        Me.btnfinance = New System.Windows.Forms.Button()
        Me.btnmood = New System.Windows.Forms.Button()
        Me.btnjournal = New System.Windows.Forms.Button()
        Me.btntodo = New System.Windows.Forms.Button()
        CType(Me.dgvtodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnhistory
        '
        Me.btnhistory.BackColor = System.Drawing.Color.BurlyWood
        Me.btnhistory.FlatAppearance.BorderSize = 0
        Me.btnhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhistory.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhistory.Location = New System.Drawing.Point(260, 584)
        Me.btnhistory.Name = "btnhistory"
        Me.btnhistory.Size = New System.Drawing.Size(222, 38)
        Me.btnhistory.TabIndex = 59
        Me.btnhistory.Text = "View Completed"
        Me.btnhistory.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 27)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "To-do List"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.BurlyWood
        Me.btndelete.FlatAppearance.BorderSize = 0
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(512, 260)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(222, 38)
        Me.btndelete.TabIndex = 57
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.BurlyWood
        Me.btnadd.FlatAppearance.BorderSize = 0
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(260, 258)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(205, 38)
        Me.btnadd.TabIndex = 56
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'dtdue
        '
        Me.dtdue.Location = New System.Drawing.Point(260, 214)
        Me.dtdue.Name = "dtdue"
        Me.dtdue.Size = New System.Drawing.Size(205, 28)
        Me.dtdue.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 24)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Due"
        '
        'txtdescription
        '
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescription.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(512, 149)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(222, 91)
        Me.txtdescription.TabIndex = 53
        '
        'txttitle
        '
        Me.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitle.Location = New System.Drawing.Point(260, 150)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(205, 21)
        Me.txttitle.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(508, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 24)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 24)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Search by due:"
        '
        'dtsearch
        '
        Me.dtsearch.Location = New System.Drawing.Point(418, 315)
        Me.dtsearch.Name = "dtsearch"
        Me.dtsearch.Size = New System.Drawing.Size(316, 28)
        Me.dtsearch.TabIndex = 48
        '
        'dgvtodo
        '
        Me.dgvtodo.BackgroundColor = System.Drawing.Color.MistyRose
        Me.dgvtodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtodo.Location = New System.Drawing.Point(260, 353)
        Me.dgvtodo.Name = "dgvtodo"
        Me.dgvtodo.RowHeadersWidth = 62
        Me.dgvtodo.RowTemplate.Height = 28
        Me.dgvtodo.Size = New System.Drawing.Size(474, 220)
        Me.dgvtodo.TabIndex = 47
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.lblwelcome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 49)
        Me.Panel2.TabIndex = 45
        '
        'btnshowall
        '
        Me.btnshowall.BackColor = System.Drawing.Color.BurlyWood
        Me.btnshowall.FlatAppearance.BorderSize = 0
        Me.btnshowall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnshowall.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshowall.Location = New System.Drawing.Point(512, 584)
        Me.btnshowall.Name = "btnshowall"
        Me.btnshowall.Size = New System.Drawing.Size(222, 38)
        Me.btnshowall.TabIndex = 61
        Me.btnshowall.Text = "Show All"
        Me.btnshowall.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 62
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
        'pnlfind
        '
        Me.pnlfind.BackColor = System.Drawing.Color.Chocolate
        Me.pnlfind.Location = New System.Drawing.Point(0, 405)
        Me.pnlfind.Name = "pnlfind"
        Me.pnlfind.Size = New System.Drawing.Size(18, 57)
        Me.pnlfind.TabIndex = 40
        Me.pnlfind.Visible = False
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
        'pnlfinance
        '
        Me.pnlfinance.BackColor = System.Drawing.Color.Chocolate
        Me.pnlfinance.Location = New System.Drawing.Point(0, 345)
        Me.pnlfinance.Name = "pnlfinance"
        Me.pnlfinance.Size = New System.Drawing.Size(18, 57)
        Me.pnlfinance.TabIndex = 35
        Me.pnlfinance.Visible = False
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
        'pnljournal
        '
        Me.pnljournal.BackColor = System.Drawing.Color.Chocolate
        Me.pnljournal.Location = New System.Drawing.Point(0, 225)
        Me.pnljournal.Name = "pnljournal"
        Me.pnljournal.Size = New System.Drawing.Size(18, 57)
        Me.pnljournal.TabIndex = 31
        Me.pnljournal.Visible = False
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
        Me.btncounseling.Text = "Chat Room"
        Me.btncounseling.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncounseling.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btncounseling.UseVisualStyleBackColor = True
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
        'ToDoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(760, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnshowall)
        Me.Controls.Add(Me.btnhistory)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.dtdue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtsearch)
        Me.Controls.Add(Me.dgvtodo)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ToDoList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ToDoList"
        CType(Me.dgvtodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnhistory As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents dtdue As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents txttitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtsearch As DateTimePicker
    Friend WithEvents dgvtodo As DataGridView
    Friend WithEvents lblwelcome As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnshowall As Button
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
