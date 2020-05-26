<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPasssetting
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
        Me.chk_Password = New System.Windows.Forms.CheckBox()
        Me.txt_passagains = New System.Windows.Forms.TextBox()
        Me.txt_passchanges = New System.Windows.Forms.TextBox()
        Me.txt_passbefores = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_no = New System.Windows.Forms.Button()
        Me.cmd_ok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chk_Password
        '
        Me.chk_Password.AutoSize = True
        Me.chk_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_Password.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_Password.Location = New System.Drawing.Point(168, 91)
        Me.chk_Password.Name = "chk_Password"
        Me.chk_Password.Size = New System.Drawing.Size(93, 20)
        Me.chk_Password.TabIndex = 27
        Me.chk_Password.Text = "แสดงรหัสผ่าน"
        Me.chk_Password.UseVisualStyleBackColor = True
        '
        'txt_passagains
        '
        Me.txt_passagains.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_passagains.Location = New System.Drawing.Point(168, 159)
        Me.txt_passagains.Name = "txt_passagains"
        Me.txt_passagains.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_passagains.Size = New System.Drawing.Size(246, 26)
        Me.txt_passagains.TabIndex = 26
        '
        'txt_passchanges
        '
        Me.txt_passchanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_passchanges.Location = New System.Drawing.Point(168, 117)
        Me.txt_passchanges.Name = "txt_passchanges"
        Me.txt_passchanges.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_passchanges.Size = New System.Drawing.Size(246, 26)
        Me.txt_passchanges.TabIndex = 25
        '
        'txt_passbefores
        '
        Me.txt_passbefores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_passbefores.Location = New System.Drawing.Point(168, 59)
        Me.txt_passbefores.Name = "txt_passbefores"
        Me.txt_passbefores.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_passbefores.Size = New System.Drawing.Size(246, 26)
        Me.txt_passbefores.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "กรอกรหัสผ่านอีกครั้ง :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "กรอกรหัสผ่านใหม่ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "กรอกรหัสผ่านเดิม :"
        '
        'cmd_no
        '
        Me.cmd_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_no.Location = New System.Drawing.Point(322, 210)
        Me.cmd_no.Name = "cmd_no"
        Me.cmd_no.Size = New System.Drawing.Size(92, 32)
        Me.cmd_no.TabIndex = 29
        Me.cmd_no.Text = "ยกเลิก"
        Me.cmd_no.UseVisualStyleBackColor = True
        '
        'cmd_ok
        '
        Me.cmd_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_ok.Location = New System.Drawing.Point(224, 210)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(92, 32)
        Me.cmd_ok.TabIndex = 28
        Me.cmd_ok.Text = "ยืนยัน"
        Me.cmd_ok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "กรุณากรอกข้อมูลให้ครบทุกช่อง !"
        '
        'FrmPasssetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 258)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_no)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.chk_Password)
        Me.Controls.Add(Me.txt_passagains)
        Me.Controls.Add(Me.txt_passchanges)
        Me.Controls.Add(Me.txt_passbefores)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPasssetting"
        Me.Text = "ตั้งค่ารหัสผ่าน"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_Password As CheckBox
    Friend WithEvents txt_passagains As TextBox
    Friend WithEvents txt_passchanges As TextBox
    Friend WithEvents txt_passbefores As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_no As Button
    Friend WithEvents cmd_ok As Button
    Friend WithEvents Label1 As Label
End Class
