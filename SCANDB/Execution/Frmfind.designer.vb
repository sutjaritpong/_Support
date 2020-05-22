<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmfind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmfind))
        Me.txt_findid = New System.Windows.Forms.TextBox()
        Me.cmd_find = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_findid
        '
        Me.txt_findid.Location = New System.Drawing.Point(49, 12)
        Me.txt_findid.Name = "txt_findid"
        Me.txt_findid.Size = New System.Drawing.Size(194, 20)
        Me.txt_findid.TabIndex = 0
        '
        'cmd_find
        '
        Me.cmd_find.Location = New System.Drawing.Point(87, 42)
        Me.cmd_find.Name = "cmd_find"
        Me.cmd_find.Size = New System.Drawing.Size(75, 23)
        Me.cmd_find.TabIndex = 1
        Me.cmd_find.Text = "ค้นหา"
        Me.cmd_find.UseVisualStyleBackColor = True
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Location = New System.Drawing.Point(168, 42)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 2
        Me.cmd_cancel.Text = "ยกเลิก"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Preview_24x24
        Me.PictureBox1.Location = New System.Drawing.Point(19, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Frmfind
        '
        Me.AcceptButton = Me.cmd_find
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(279, 77)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_find)
        Me.Controls.Add(Me.txt_findid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmfind"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาเลขที่บัตรประชาชน"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_findid As TextBox
    Friend WithEvents cmd_find As Button
    Friend WithEvents cmd_cancel As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
