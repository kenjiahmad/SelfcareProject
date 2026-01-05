<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomingReq
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnreq = New System.Windows.Forms.Button()
        Me.pnluser = New System.Windows.Forms.Panel()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnsignout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvrequest = New System.Windows.Forms.DataGridView()
        Me.btnreject = New System.Windows.Forms.Button()
        Me.btnaccept = New System.Windows.Forms.Button()
        Me.tmrrefresh = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvrequest, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(235, 638)
        Me.Panel1.TabIndex = 61
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
        Me.btnsignout.Location = New System.Drawing.Point(0, 578)
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
        Me.Panel2.Controls.Add(Me.lblwelcome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(867, 49)
        Me.Panel2.TabIndex = 60
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(254, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 27)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Incoming Chat Request"
        '
        'dgvrequest
        '
        Me.dgvrequest.BackgroundColor = System.Drawing.Color.Linen
        Me.dgvrequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrequest.Location = New System.Drawing.Point(259, 114)
        Me.dgvrequest.Name = "dgvrequest"
        Me.dgvrequest.RowHeadersWidth = 62
        Me.dgvrequest.RowTemplate.Height = 28
        Me.dgvrequest.Size = New System.Drawing.Size(596, 458)
        Me.dgvrequest.TabIndex = 63
        '
        'btnreject
        '
        Me.btnreject.BackColor = System.Drawing.Color.SandyBrown
        Me.btnreject.FlatAppearance.BorderSize = 0
        Me.btnreject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreject.Location = New System.Drawing.Point(259, 603)
        Me.btnreject.Name = "btnreject"
        Me.btnreject.Size = New System.Drawing.Size(270, 58)
        Me.btnreject.TabIndex = 64
        Me.btnreject.Text = "REJECT"
        Me.btnreject.UseVisualStyleBackColor = False
        '
        'btnaccept
        '
        Me.btnaccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaccept.Location = New System.Drawing.Point(585, 603)
        Me.btnaccept.Name = "btnaccept"
        Me.btnaccept.Size = New System.Drawing.Size(270, 58)
        Me.btnaccept.TabIndex = 65
        Me.btnaccept.Text = "ACCEPT"
        Me.btnaccept.UseVisualStyleBackColor = True
        '
        'tmrrefresh
        '
        Me.tmrrefresh.Enabled = True
        Me.tmrrefresh.Interval = 3000
        '
        'IncomingReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(867, 687)
        Me.Controls.Add(Me.btnaccept)
        Me.Controls.Add(Me.btnreject)
        Me.Controls.Add(Me.dgvrequest)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IncomingReq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IncomingReq"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvrequest, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvrequest As DataGridView
    Friend WithEvents btnreject As Button
    Friend WithEvents btnaccept As Button
    Friend WithEvents tmrrefresh As Timer
End Class
