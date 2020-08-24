<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcollector
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
        Me.cmd_import = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Dtgv_Exe = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Dtgv_Exe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_import
        '
        Me.cmd_import.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_import.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_import.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.cmd_import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_import.Location = New System.Drawing.Point(25, 12)
        Me.cmd_import.Name = "cmd_import"
        Me.cmd_import.Size = New System.Drawing.Size(154, 31)
        Me.cmd_import.TabIndex = 15
        Me.cmd_import.Text = "Import Performance"
        Me.cmd_import.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_import.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Dtgv_Exe
        '
        Me.Dtgv_Exe.AllowUserToAddRows = False
        Me.Dtgv_Exe.AllowUserToDeleteRows = False
        Me.Dtgv_Exe.BackgroundColor = System.Drawing.SystemColors.Window
        Me.Dtgv_Exe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_Exe.GridColor = System.Drawing.Color.Black
        Me.Dtgv_Exe.Location = New System.Drawing.Point(25, 49)
        Me.Dtgv_Exe.Name = "Dtgv_Exe"
        Me.Dtgv_Exe.ReadOnly = True
        Me.Dtgv_Exe.RowHeadersVisible = False
        Me.Dtgv_Exe.Size = New System.Drawing.Size(786, 404)
        Me.Dtgv_Exe.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Image = Global.SCANDB.My.Resources.Resources.server_connect
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(672, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 40)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Import Payment"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Window
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(185, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 31)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Import HUB"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Window
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(306, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 31)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Daily_Payment"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Frmcollector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Dtgv_Exe)
        Me.Controls.Add(Me.cmd_import)
        Me.Name = "Frmcollector"
        Me.Text = "Frmcollector"
        CType(Me.Dtgv_Exe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmd_import As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Dtgv_Exe As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
