<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityLog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.dgvlog = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnsignout = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvlog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 42)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "LOG ACTIVITY"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.lblwelcome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(695, 49)
        Me.Panel2.TabIndex = 84
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
        'dgvlog
        '
        Me.dgvlog.BackgroundColor = System.Drawing.Color.Linen
        Me.dgvlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlog.Location = New System.Drawing.Point(13, 170)
        Me.dgvlog.Name = "dgvlog"
        Me.dgvlog.RowHeadersWidth = 62
        Me.dgvlog.RowTemplate.Height = 28
        Me.dgvlog.Size = New System.Drawing.Size(663, 349)
        Me.dgvlog.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 27)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = "Search by: "
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(136, 126)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(540, 28)
        Me.txtsearch.TabIndex = 88
        '
        'btnsignout
        '
        Me.btnsignout.BackColor = System.Drawing.Color.Transparent
        Me.btnsignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnsignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsignout.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsignout.Image = Global.SelfcareProject.My.Resources.Resources.icons8_logout_20
        Me.btnsignout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsignout.Location = New System.Drawing.Point(13, 540)
        Me.btnsignout.Name = "btnsignout"
        Me.btnsignout.Size = New System.Drawing.Size(147, 57)
        Me.btnsignout.TabIndex = 90
        Me.btnsignout.Text = "Sign Out"
        Me.btnsignout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsignout.UseVisualStyleBackColor = False
        '
        'ActivityLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(695, 609)
        Me.Controls.Add(Me.btnsignout)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvlog)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ActivityLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ActivityLog"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvlog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblwelcome As Label
    Friend WithEvents dgvlog As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnsignout As Button
End Class
