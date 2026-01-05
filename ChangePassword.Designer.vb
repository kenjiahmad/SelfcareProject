<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.chkshowpassword = New System.Windows.Forms.CheckBox()
        Me.txtconfirmpassword = New System.Windows.Forms.TextBox()
        Me.txtnewpassword = New System.Windows.Forms.TextBox()
        Me.txtoldpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.BurlyWood
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Location = New System.Drawing.Point(66, 356)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(224, 43)
        Me.btnsave.TabIndex = 19
        Me.btnsave.Text = "Change Password"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.BurlyWood
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Location = New System.Drawing.Point(305, 356)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(224, 43)
        Me.btncancel.TabIndex = 18
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'chkshowpassword
        '
        Me.chkshowpassword.AutoSize = True
        Me.chkshowpassword.Location = New System.Drawing.Point(305, 298)
        Me.chkshowpassword.Name = "chkshowpassword"
        Me.chkshowpassword.Size = New System.Drawing.Size(155, 25)
        Me.chkshowpassword.TabIndex = 17
        Me.chkshowpassword.Text = "Show Password"
        Me.chkshowpassword.UseVisualStyleBackColor = True
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtconfirmpassword.Location = New System.Drawing.Point(305, 261)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.Size = New System.Drawing.Size(224, 21)
        Me.txtconfirmpassword.TabIndex = 16
        Me.txtconfirmpassword.UseSystemPasswordChar = True
        '
        'txtnewpassword
        '
        Me.txtnewpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnewpassword.Location = New System.Drawing.Point(305, 208)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.Size = New System.Drawing.Size(224, 21)
        Me.txtnewpassword.TabIndex = 15
        Me.txtnewpassword.UseSystemPasswordChar = True
        '
        'txtoldpassword
        '
        Me.txtoldpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtoldpassword.Location = New System.Drawing.Point(305, 156)
        Me.txtoldpassword.Name = "txtoldpassword"
        Me.txtoldpassword.Size = New System.Drawing.Size(224, 21)
        Me.txtoldpassword.TabIndex = 14
        Me.txtoldpassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Confirm New Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "New Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Current Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Change Password"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(590, 450)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.chkshowpassword)
        Me.Controls.Add(Me.txtconfirmpassword)
        Me.Controls.Add(Me.txtnewpassword)
        Me.Controls.Add(Me.txtoldpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsave As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents chkshowpassword As CheckBox
    Friend WithEvents txtconfirmpassword As TextBox
    Friend WithEvents txtnewpassword As TextBox
    Friend WithEvents txtoldpassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
