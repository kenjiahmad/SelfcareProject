<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindCounselor
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
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.lblspecialist = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbio = New System.Windows.Forms.TextBox()
        Me.dgvcounselor = New System.Windows.Forms.DataGridView()
        Me.btnsendreq = New System.Windows.Forms.Button()
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
        CType(Me.dgvcounselor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(253, 121)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(58, 22)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(252, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 27)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Find Counselor"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.lblwelcome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 49)
        Me.Panel2.TabIndex = 54
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
        'lblspecialist
        '
        Me.lblspecialist.AutoSize = True
        Me.lblspecialist.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblspecialist.Location = New System.Drawing.Point(253, 156)
        Me.lblspecialist.Name = "lblspecialist"
        Me.lblspecialist.Size = New System.Drawing.Size(80, 21)
        Me.lblspecialist.TabIndex = 56
        Me.lblspecialist.Text = "Specialist"
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.Location = New System.Drawing.Point(253, 190)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(40, 21)
        Me.lblage.TabIndex = 57
        Me.lblage.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(500, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 21)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Bio"
        '
        'txtbio
        '
        Me.txtbio.Enabled = False
        Me.txtbio.Location = New System.Drawing.Point(504, 154)
        Me.txtbio.Multiline = True
        Me.txtbio.Name = "txtbio"
        Me.txtbio.Size = New System.Drawing.Size(231, 57)
        Me.txtbio.TabIndex = 59
        '
        'dgvcounselor
        '
        Me.dgvcounselor.BackgroundColor = System.Drawing.Color.Linen
        Me.dgvcounselor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcounselor.Location = New System.Drawing.Point(257, 241)
        Me.dgvcounselor.Name = "dgvcounselor"
        Me.dgvcounselor.RowHeadersWidth = 62
        Me.dgvcounselor.RowTemplate.Height = 28
        Me.dgvcounselor.Size = New System.Drawing.Size(478, 330)
        Me.dgvcounselor.TabIndex = 60
        '
        'btnsendreq
        '
        Me.btnsendreq.BackColor = System.Drawing.Color.SandyBrown
        Me.btnsendreq.FlatAppearance.BorderSize = 0
        Me.btnsendreq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsendreq.Location = New System.Drawing.Point(362, 584)
        Me.btnsendreq.Name = "btnsendreq"
        Me.btnsendreq.Size = New System.Drawing.Size(275, 42)
        Me.btnsendreq.TabIndex = 61
        Me.btnsendreq.Text = "Send Chat Request"
        Me.btnsendreq.UseVisualStyleBackColor = False
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
        'FindCounselor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(760, 644)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnsendreq)
        Me.Controls.Add(Me.dgvcounselor)
        Me.Controls.Add(Me.txtbio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblage)
        Me.Controls.Add(Me.lblspecialist)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblname)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FindCounselor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChattingUser"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvcounselor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblname As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblwelcome As Label
    Friend WithEvents lblspecialist As Label
    Friend WithEvents lblage As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbio As TextBox
    Friend WithEvents dgvcounselor As DataGridView
    Friend WithEvents btnsendreq As Button
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
