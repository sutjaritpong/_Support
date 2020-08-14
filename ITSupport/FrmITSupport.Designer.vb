<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmITSupport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmITSupport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_logIT = New System.Windows.Forms.Button()
        Me.cmd_servermanage = New System.Windows.Forms.Button()
        Me.cmd_CCTVmanage = New System.Windows.Forms.Button()
        Me.cmd_wifimanage = New System.Windows.Forms.Button()
        Me.cmd_ipmanage = New System.Windows.Forms.Button()
        Me.cmd_Pcmanage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(245, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(531, 39)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "INFORMATION TECHNOLOGY"
        '
        'cmd_logIT
        '
        Me.cmd_logIT.BackColor = System.Drawing.Color.White
        Me.cmd_logIT.Image = Global.SCANDB.My.Resources.Resources.LOGLOGO
        Me.cmd_logIT.Location = New System.Drawing.Point(608, 352)
        Me.cmd_logIT.Name = "cmd_logIT"
        Me.cmd_logIT.Size = New System.Drawing.Size(220, 220)
        Me.cmd_logIT.TabIndex = 5
        Me.cmd_logIT.UseVisualStyleBackColor = False
        '
        'cmd_servermanage
        '
        Me.cmd_servermanage.BackColor = System.Drawing.Color.White
        Me.cmd_servermanage.Image = Global.SCANDB.My.Resources.Resources._200725114849_v6bA
        Me.cmd_servermanage.Location = New System.Drawing.Point(382, 352)
        Me.cmd_servermanage.Name = "cmd_servermanage"
        Me.cmd_servermanage.Size = New System.Drawing.Size(220, 220)
        Me.cmd_servermanage.TabIndex = 4
        Me.cmd_servermanage.UseVisualStyleBackColor = False
        '
        'cmd_CCTVmanage
        '
        Me.cmd_CCTVmanage.BackColor = System.Drawing.Color.White
        Me.cmd_CCTVmanage.Image = Global.SCANDB.My.Resources.Resources.download1
        Me.cmd_CCTVmanage.Location = New System.Drawing.Point(608, 126)
        Me.cmd_CCTVmanage.Name = "cmd_CCTVmanage"
        Me.cmd_CCTVmanage.Size = New System.Drawing.Size(220, 220)
        Me.cmd_CCTVmanage.TabIndex = 3
        Me.cmd_CCTVmanage.UseVisualStyleBackColor = False
        '
        'cmd_wifimanage
        '
        Me.cmd_wifimanage.BackColor = System.Drawing.Color.White
        Me.cmd_wifimanage.Image = Global.SCANDB.My.Resources.Resources.wifi_sticker
        Me.cmd_wifimanage.Location = New System.Drawing.Point(156, 352)
        Me.cmd_wifimanage.Name = "cmd_wifimanage"
        Me.cmd_wifimanage.Size = New System.Drawing.Size(220, 220)
        Me.cmd_wifimanage.TabIndex = 2
        Me.cmd_wifimanage.UseVisualStyleBackColor = False
        '
        'cmd_ipmanage
        '
        Me.cmd_ipmanage.BackColor = System.Drawing.Color.White
        Me.cmd_ipmanage.Image = Global.SCANDB.My.Resources.Resources.logo_ip
        Me.cmd_ipmanage.Location = New System.Drawing.Point(382, 126)
        Me.cmd_ipmanage.Name = "cmd_ipmanage"
        Me.cmd_ipmanage.Size = New System.Drawing.Size(220, 220)
        Me.cmd_ipmanage.TabIndex = 1
        Me.cmd_ipmanage.UseVisualStyleBackColor = False
        '
        'cmd_Pcmanage
        '
        Me.cmd_Pcmanage.BackColor = System.Drawing.Color.White
        Me.cmd_Pcmanage.Image = Global.SCANDB.My.Resources.Resources._4aff9db9936e04513fde6a461fa1ee4a
        Me.cmd_Pcmanage.Location = New System.Drawing.Point(156, 126)
        Me.cmd_Pcmanage.Name = "cmd_Pcmanage"
        Me.cmd_Pcmanage.Size = New System.Drawing.Size(220, 220)
        Me.cmd_Pcmanage.TabIndex = 0
        Me.cmd_Pcmanage.UseVisualStyleBackColor = False
        '
        'FrmITSupport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_logIT)
        Me.Controls.Add(Me.cmd_servermanage)
        Me.Controls.Add(Me.cmd_CCTVmanage)
        Me.Controls.Add(Me.cmd_wifimanage)
        Me.Controls.Add(Me.cmd_ipmanage)
        Me.Controls.Add(Me.cmd_Pcmanage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmITSupport"
        Me.Text = "รายการที่ต้องการค้นหา"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Pcmanage As Button
    Friend WithEvents cmd_ipmanage As Button
    Friend WithEvents cmd_wifimanage As Button
    Friend WithEvents cmd_CCTVmanage As Button
    Friend WithEvents cmd_servermanage As Button
    Friend WithEvents cmd_logIT As Button
    Friend WithEvents Label1 As Label
End Class
