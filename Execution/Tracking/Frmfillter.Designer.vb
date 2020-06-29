<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmfillter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmfillter))
        Me.dtp_date_verify = New System.Windows.Forms.DateTimePicker()
        Me.dtp_date_send = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'dtp_date_verify
        '
        Me.dtp_date_verify.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_verify.Location = New System.Drawing.Point(57, 97)
        Me.dtp_date_verify.Name = "dtp_date_verify"
        Me.dtp_date_verify.Size = New System.Drawing.Size(116, 20)
        Me.dtp_date_verify.TabIndex = 143
        '
        'dtp_date_send
        '
        Me.dtp_date_send.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_send.Location = New System.Drawing.Point(231, 97)
        Me.dtp_date_send.Name = "dtp_date_send"
        Me.dtp_date_send.Size = New System.Drawing.Size(116, 20)
        Me.dtp_date_send.TabIndex = 142
        '
        'Frmfillter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 633)
        Me.Controls.Add(Me.dtp_date_verify)
        Me.Controls.Add(Me.dtp_date_send)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmfillter"
        Me.Text = "ค้นหาข้อมูลพนักงาน"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtp_date_verify As DateTimePicker
    Friend WithEvents dtp_date_send As DateTimePicker
End Class
