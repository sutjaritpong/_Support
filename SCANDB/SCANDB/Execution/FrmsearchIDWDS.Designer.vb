<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmsearchIDWDS
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
        Me.txt_searchacc = New System.Windows.Forms.TextBox()
        Me.btn_searchid = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_searchacc
        '
        Me.txt_searchacc.Location = New System.Drawing.Point(12, 12)
        Me.txt_searchacc.Name = "txt_searchacc"
        Me.txt_searchacc.Size = New System.Drawing.Size(302, 20)
        Me.txt_searchacc.TabIndex = 0
        '
        'btn_searchid
        '
        Me.btn_searchid.Location = New System.Drawing.Point(126, 38)
        Me.btn_searchid.Name = "btn_searchid"
        Me.btn_searchid.Size = New System.Drawing.Size(75, 23)
        Me.btn_searchid.TabIndex = 1
        Me.btn_searchid.Text = "ค้นหา"
        Me.btn_searchid.UseVisualStyleBackColor = True
        '
        'FrmsearchIDWDS
        '
        Me.AcceptButton = Me.btn_searchid
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 78)
        Me.Controls.Add(Me.btn_searchid)
        Me.Controls.Add(Me.txt_searchacc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmsearchIDWDS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลขที่สัญญาลูกค้า"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_searchacc As TextBox
    Friend WithEvents btn_searchid As Button
End Class
