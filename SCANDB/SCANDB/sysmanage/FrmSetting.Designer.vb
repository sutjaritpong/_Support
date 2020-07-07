<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSetting))
        Me.Lable2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_daylimit = New System.Windows.Forms.TextBox()
        Me.txt_passlimit = New System.Windows.Forms.TextBox()
        Me.cmd_editsetting = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_changepass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lable2
        '
        Me.Lable2.AutoSize = True
        Me.Lable2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lable2.Location = New System.Drawing.Point(28, 26)
        Me.Lable2.Name = "Lable2"
        Me.Lable2.Size = New System.Drawing.Size(117, 16)
        Me.Lable2.TabIndex = 1
        Me.Lable2.Text = "เข้าระบบผิดพลาดไม่เกิน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ขาดการใข้งานติดต่อไม่เกิน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ครั้ง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(261, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "วัน"
        '
        'txt_daylimit
        '
        Me.txt_daylimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_daylimit.Location = New System.Drawing.Point(155, 53)
        Me.txt_daylimit.Name = "txt_daylimit"
        Me.txt_daylimit.Size = New System.Drawing.Size(100, 22)
        Me.txt_daylimit.TabIndex = 6
        '
        'txt_passlimit
        '
        Me.txt_passlimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_passlimit.Location = New System.Drawing.Point(155, 23)
        Me.txt_passlimit.Name = "txt_passlimit"
        Me.txt_passlimit.Size = New System.Drawing.Size(100, 22)
        Me.txt_passlimit.TabIndex = 5
        '
        'cmd_editsetting
        '
        Me.cmd_editsetting.Image = Global.SCANDB.My.Resources.Resources.refresh
        Me.cmd_editsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_editsetting.Location = New System.Drawing.Point(137, 122)
        Me.cmd_editsetting.Name = "cmd_editsetting"
        Me.cmd_editsetting.Size = New System.Drawing.Size(118, 23)
        Me.cmd_editsetting.TabIndex = 9
        Me.cmd_editsetting.Text = "เปลี่ยนแปลงข้อมูล"
        Me.cmd_editsetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_editsetting.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "เปลี่ยนรหัสผ่านทุก"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(261, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "วัน"
        '
        'txt_changepass
        '
        Me.txt_changepass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_changepass.Location = New System.Drawing.Point(155, 85)
        Me.txt_changepass.Name = "txt_changepass"
        Me.txt_changepass.Size = New System.Drawing.Size(100, 22)
        Me.txt_changepass.TabIndex = 12
        '
        'FrmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 157)
        Me.Controls.Add(Me.txt_changepass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_editsetting)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_daylimit)
        Me.Controls.Add(Me.txt_passlimit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lable2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSetting"
        Me.Text = "ตั้งค่าโปรแกรม"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lable2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_daylimit As TextBox
    Friend WithEvents txt_passlimit As TextBox
    Friend WithEvents cmd_editsetting As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_changepass As TextBox
End Class
