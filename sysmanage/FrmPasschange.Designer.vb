<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPasschange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPasschange))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_passbefore = New System.Windows.Forms.TextBox()
        Me.txt_passnew = New System.Windows.Forms.TextBox()
        Me.txt_passagain = New System.Windows.Forms.TextBox()
        Me.chk_Password = New System.Windows.Forms.CheckBox()
        Me.cmd_ok = New System.Windows.Forms.Button()
        Me.cmd_no = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "กรุณา เปลี่ยนรหัสผ่านของคุณเพื่อเข้าใช้งานระบบ!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "กรอกรหัสผ่านเดิม :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "กรอกรหัสผ่านใหม่ :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "กรอกรหัสผ่านอีกครั้ง :"
        '
        'txt_passbefore
        '
        Me.txt_passbefore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_passbefore.Location = New System.Drawing.Point(173, 101)
        Me.txt_passbefore.Name = "txt_passbefore"
        Me.txt_passbefore.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_passbefore.Size = New System.Drawing.Size(246, 26)
        Me.txt_passbefore.TabIndex = 4
        '
        'txt_passnew
        '
        Me.txt_passnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_passnew.Location = New System.Drawing.Point(173, 159)
        Me.txt_passnew.Name = "txt_passnew"
        Me.txt_passnew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_passnew.Size = New System.Drawing.Size(246, 26)
        Me.txt_passnew.TabIndex = 5
        '
        'txt_passagain
        '
        Me.txt_passagain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_passagain.Location = New System.Drawing.Point(173, 201)
        Me.txt_passagain.Name = "txt_passagain"
        Me.txt_passagain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_passagain.Size = New System.Drawing.Size(246, 26)
        Me.txt_passagain.TabIndex = 6
        '
        'chk_Password
        '
        Me.chk_Password.AutoSize = True
        Me.chk_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_Password.ForeColor = System.Drawing.Color.Blue
        Me.chk_Password.Location = New System.Drawing.Point(173, 133)
        Me.chk_Password.Name = "chk_Password"
        Me.chk_Password.Size = New System.Drawing.Size(93, 20)
        Me.chk_Password.TabIndex = 20
        Me.chk_Password.Text = "แสดงรหัสผ่าน"
        Me.chk_Password.UseVisualStyleBackColor = True
        '
        'cmd_ok
        '
        Me.cmd_ok.BackColor = System.Drawing.Color.White
        Me.cmd_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_ok.ForeColor = System.Drawing.Color.Blue
        Me.cmd_ok.Location = New System.Drawing.Point(228, 245)
        Me.cmd_ok.Name = "cmd_ok"
        Me.cmd_ok.Size = New System.Drawing.Size(92, 32)
        Me.cmd_ok.TabIndex = 21
        Me.cmd_ok.Text = "ยืนยัน"
        Me.cmd_ok.UseVisualStyleBackColor = False
        '
        'cmd_no
        '
        Me.cmd_no.BackColor = System.Drawing.Color.White
        Me.cmd_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_no.Location = New System.Drawing.Point(326, 245)
        Me.cmd_no.Name = "cmd_no"
        Me.cmd_no.Size = New System.Drawing.Size(92, 32)
        Me.cmd_no.TabIndex = 22
        Me.cmd_no.Text = "ยกเลิก"
        Me.cmd_no.UseVisualStyleBackColor = False
        '
        'FrmPasschange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(455, 317)
        Me.Controls.Add(Me.cmd_no)
        Me.Controls.Add(Me.cmd_ok)
        Me.Controls.Add(Me.chk_Password)
        Me.Controls.Add(Me.txt_passagain)
        Me.Controls.Add(Me.txt_passnew)
        Me.Controls.Add(Me.txt_passbefore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPasschange"
        Me.Text = "เปลี่ยนรหัสผ่าน"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_passbefore As TextBox
    Friend WithEvents txt_passnew As TextBox
    Friend WithEvents txt_passagain As TextBox
    Friend WithEvents chk_Password As CheckBox
    Friend WithEvents cmd_ok As Button
    Friend WithEvents cmd_no As Button
End Class
