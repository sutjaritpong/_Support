<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAccount))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Fullname = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Userid = New System.Windows.Forms.TextBox()
        Me.dgvaccount = New System.Windows.Forms.DataGridView()
        Me.cbo_group = New System.Windows.Forms.ComboBox()
        Me.cmd_edit = New System.Windows.Forms.Button()
        Me.cmd_delete = New System.Windows.Forms.Button()
        Me.cmd_register = New System.Windows.Forms.Button()
        Me.cmd_unlockall = New System.Windows.Forms.Button()
        CType(Me.dgvaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(337, 498)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Group :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(337, 469)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Full Name :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 495)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Password :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 469)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "USER :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 498)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(274, 469)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 51
        '
        'Fullname
        '
        Me.Fullname.Location = New System.Drawing.Point(398, 466)
        Me.Fullname.Name = "Fullname"
        Me.Fullname.Size = New System.Drawing.Size(238, 20)
        Me.Fullname.TabIndex = 3
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(90, 492)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(238, 20)
        Me.Password.TabIndex = 2
        '
        'Userid
        '
        Me.Userid.Location = New System.Drawing.Point(90, 466)
        Me.Userid.Name = "Userid"
        Me.Userid.Size = New System.Drawing.Size(238, 20)
        Me.Userid.TabIndex = 1
        '
        'dgvaccount
        '
        Me.dgvaccount.Location = New System.Drawing.Point(12, 12)
        Me.dgvaccount.Name = "dgvaccount"
        Me.dgvaccount.Size = New System.Drawing.Size(984, 401)
        Me.dgvaccount.TabIndex = 46
        '
        'cbo_group
        '
        Me.cbo_group.FormattingEnabled = True
        Me.cbo_group.Location = New System.Drawing.Point(398, 492)
        Me.cbo_group.Name = "cbo_group"
        Me.cbo_group.Size = New System.Drawing.Size(238, 21)
        Me.cbo_group.TabIndex = 4
        '
        'cmd_edit
        '
        Me.cmd_edit.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_edit.Image = Global.SCANDB.My.Resources.Resources.Undo_16x16
        Me.cmd_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_edit.Location = New System.Drawing.Point(852, 418)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(144, 33)
        Me.cmd_edit.TabIndex = 7
        Me.cmd_edit.Text = "แก้ไข"
        Me.cmd_edit.UseVisualStyleBackColor = False
        '
        'cmd_delete
        '
        Me.cmd_delete.BackColor = System.Drawing.Color.GhostWhite
        Me.cmd_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_delete.Image = Global.SCANDB.My.Resources.Resources.delete
        Me.cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_delete.Location = New System.Drawing.Point(702, 418)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(144, 33)
        Me.cmd_delete.TabIndex = 6
        Me.cmd_delete.Text = "ลบ"
        Me.cmd_delete.UseVisualStyleBackColor = False
        '
        'cmd_register
        '
        Me.cmd_register.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_register.Image = Global.SCANDB.My.Resources.Resources.add
        Me.cmd_register.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_register.Location = New System.Drawing.Point(552, 418)
        Me.cmd_register.Name = "cmd_register"
        Me.cmd_register.Size = New System.Drawing.Size(144, 33)
        Me.cmd_register.TabIndex = 5
        Me.cmd_register.Text = "เพิ่ม"
        Me.cmd_register.UseVisualStyleBackColor = False
        '
        'cmd_unlockall
        '
        Me.cmd_unlockall.BackColor = System.Drawing.Color.GhostWhite
        Me.cmd_unlockall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_unlockall.Image = Global.SCANDB.My.Resources.Resources.Key_32x32
        Me.cmd_unlockall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_unlockall.Location = New System.Drawing.Point(28, 527)
        Me.cmd_unlockall.Name = "cmd_unlockall"
        Me.cmd_unlockall.Size = New System.Drawing.Size(210, 38)
        Me.cmd_unlockall.TabIndex = 59
        Me.cmd_unlockall.Text = "   ปลดล็อคผู้ใช้ทั้งหมด"
        Me.cmd_unlockall.UseVisualStyleBackColor = False
        '
        'FrmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.cmd_unlockall)
        Me.Controls.Add(Me.cbo_group)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Fullname)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Userid)
        Me.Controls.Add(Me.dgvaccount)
        Me.Controls.Add(Me.cmd_register)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAccount"
        Me.Text = "ตั้งค่าบัญชี"
        CType(Me.dgvaccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmd_edit As Button
    Friend WithEvents cmd_delete As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Fullname As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Userid As TextBox
    Friend WithEvents dgvaccount As DataGridView
    Friend WithEvents cmd_register As Button
    Friend WithEvents cbo_group As ComboBox
    Friend WithEvents cmd_unlockall As Button
End Class
