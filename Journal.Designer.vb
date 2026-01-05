<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Journal
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
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.dgvjournal = New System.Windows.Forms.DataGridView()
        Me.txttitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtcontent = New System.Windows.Forms.TextBox()
        Me.dtsearch = New System.Windows.Forms.DateTimePicker()
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
        Me.Panel2.SuspendLayout()
        CType(Me.dgvjournal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.BurlyWood
        Me.btndelete.FlatAppearance.BorderSize = 0
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(509, 359)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(225, 38)
        Me.btndelete.TabIndex = 72
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.lblwelcome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 49)
        Me.Panel2.TabIndex = 61
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
        'dgvjournal
        '
        Me.dgvjournal.BackgroundColor = System.Drawing.Color.MistyRose
        Me.dgvjournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvjournal.Location = New System.Drawing.Point(260, 447)
        Me.dgvjournal.Name = "dgvjournal"
        Me.dgvjournal.RowHeadersWidth = 62
        Me.dgvjournal.RowTemplate.Height = 28
        Me.dgvjournal.Size = New System.Drawing.Size(474, 173)
        Me.dgvjournal.TabIndex = 63
        '
        'txttitle
        '
        Me.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttitle.Location = New System.Drawing.Point(260, 152)
        Me.txttitle.Multiline = True
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(474, 28)
        Me.txttitle.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 24)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Content"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 24)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Search by due:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 27)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Journal"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.BurlyWood
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(261, 359)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(225, 38)
        Me.btnsave.TabIndex = 70
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtcontent
        '
        Me.txtcontent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcontent.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontent.Location = New System.Drawing.Point(261, 210)
        Me.txtcontent.Multiline = True
        Me.txtcontent.Name = "txtcontent"
        Me.txtcontent.Size = New System.Drawing.Size(473, 128)
        Me.txtcontent.TabIndex = 69
        '
        'dtsearch
        '
        Me.dtsearch.Location = New System.Drawing.Point(418, 408)
        Me.dtsearch.Name = "dtsearch"
        Me.dtsearch.Size = New System.Drawing.Size(316, 28)
        Me.dtsearch.TabIndex = 64
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
        Me.Panel1.TabIndex = 73
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
        'Journal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(760, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvjournal)
        Me.Controls.Add(Me.txttitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtcontent)
        Me.Controls.Add(Me.dtsearch)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Journal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvjournal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btndelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblwelcome As Label
    Friend WithEvents dgvjournal As DataGridView
    Friend WithEvents txttitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents txtcontent As TextBox
    Friend WithEvents dtsearch As DateTimePicker
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
