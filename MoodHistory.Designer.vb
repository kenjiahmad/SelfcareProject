<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoodHistory
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtsearch = New System.Windows.Forms.DateTimePicker()
        Me.dgvhistory = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblwelcome = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnshowall = New System.Windows.Forms.Button()
        CType(Me.dgvhistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 27)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Mood History"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 24)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Search by date:"
        '
        'dtsearch
        '
        Me.dtsearch.Location = New System.Drawing.Point(160, 128)
        Me.dtsearch.Name = "dtsearch"
        Me.dtsearch.Size = New System.Drawing.Size(239, 28)
        Me.dtsearch.TabIndex = 76
        '
        'dgvhistory
        '
        Me.dgvhistory.BackgroundColor = System.Drawing.Color.MistyRose
        Me.dgvhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhistory.Location = New System.Drawing.Point(17, 176)
        Me.dgvhistory.Name = "dgvhistory"
        Me.dgvhistory.RowHeadersWidth = 62
        Me.dgvhistory.RowTemplate.Height = 28
        Me.dgvhistory.Size = New System.Drawing.Size(382, 339)
        Me.dgvhistory.TabIndex = 75
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.lblwelcome)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(419, 49)
        Me.Panel2.TabIndex = 74
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
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.BurlyWood
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(205, 533)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(194, 38)
        Me.btnback.TabIndex = 79
        Me.btnback.Text = "Back to Mood Tracker"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnshowall
        '
        Me.btnshowall.BackColor = System.Drawing.Color.BurlyWood
        Me.btnshowall.FlatAppearance.BorderSize = 0
        Me.btnshowall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnshowall.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshowall.Location = New System.Drawing.Point(12, 533)
        Me.btnshowall.Name = "btnshowall"
        Me.btnshowall.Size = New System.Drawing.Size(173, 38)
        Me.btnshowall.TabIndex = 80
        Me.btnshowall.Text = "Show All"
        Me.btnshowall.UseVisualStyleBackColor = False
        '
        'MoodHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(419, 592)
        Me.Controls.Add(Me.btnshowall)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtsearch)
        Me.Controls.Add(Me.dgvhistory)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnback)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MoodHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MoodHistory"
        CType(Me.dgvhistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtsearch As DateTimePicker
    Friend WithEvents dgvhistory As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblwelcome As Label
    Friend WithEvents btnback As Button
    Friend WithEvents btnshowall As Button
End Class
