<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmfindExecution
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmfindExecution))
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_find = New System.Windows.Forms.Button()
        Me.txt_findid = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Location = New System.Drawing.Point(191, 38)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 5
        Me.cmd_cancel.Text = "ยกเลิก"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'cmd_find
        '
        Me.cmd_find.Location = New System.Drawing.Point(110, 38)
        Me.cmd_find.Name = "cmd_find"
        Me.cmd_find.Size = New System.Drawing.Size(75, 23)
        Me.cmd_find.TabIndex = 4
        Me.cmd_find.Text = "ค้นหา"
        Me.cmd_find.UseVisualStyleBackColor = True
        '
        'txt_findid
        '
        Me.txt_findid.Location = New System.Drawing.Point(110, 12)
        Me.txt_findid.Name = "txt_findid"
        Me.txt_findid.Size = New System.Drawing.Size(194, 20)
        Me.txt_findid.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 20)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "เลขบัตรประชาชน"
        '
        'FrmfindExecution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 71)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_find)
        Me.Controls.Add(Me.txt_findid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmfindExecution"
        Me.Text = "ค้นหาข้อมูลตรวจสำนวน"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_cancel As Button
    Friend WithEvents cmd_find As Button
    Friend WithEvents txt_findid As TextBox
    Friend WithEvents Label14 As Label
End Class
