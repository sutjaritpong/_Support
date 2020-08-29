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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcollector))
        Me.Cmd_ImportPerformance = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Dtgv_Zero_collector = New System.Windows.Forms.DataGridView()
        Me.Cmd_ImportPayment = New System.Windows.Forms.Button()
        Me.Cmd_ImportHub = New System.Windows.Forms.Button()
        Me.Cmd_Daily_Payment = New System.Windows.Forms.Button()
        CType(Me.Dtgv_Zero_collector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmd_ImportPerformance
        '
        Me.Cmd_ImportPerformance.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_ImportPerformance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_ImportPerformance.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.Cmd_ImportPerformance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_ImportPerformance.Location = New System.Drawing.Point(25, 12)
        Me.Cmd_ImportPerformance.Name = "Cmd_ImportPerformance"
        Me.Cmd_ImportPerformance.Size = New System.Drawing.Size(154, 31)
        Me.Cmd_ImportPerformance.TabIndex = 15
        Me.Cmd_ImportPerformance.Text = "Import Performance"
        Me.Cmd_ImportPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_ImportPerformance.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Dtgv_Zero_collector
        '
        Me.Dtgv_Zero_collector.AllowUserToAddRows = False
        Me.Dtgv_Zero_collector.AllowUserToDeleteRows = False
        Me.Dtgv_Zero_collector.BackgroundColor = System.Drawing.SystemColors.Window
        Me.Dtgv_Zero_collector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_Zero_collector.GridColor = System.Drawing.Color.Black
        Me.Dtgv_Zero_collector.Location = New System.Drawing.Point(25, 49)
        Me.Dtgv_Zero_collector.Name = "Dtgv_Zero_collector"
        Me.Dtgv_Zero_collector.ReadOnly = True
        Me.Dtgv_Zero_collector.RowHeadersVisible = False
        Me.Dtgv_Zero_collector.Size = New System.Drawing.Size(786, 404)
        Me.Dtgv_Zero_collector.TabIndex = 16
        '
        'Cmd_ImportPayment
        '
        Me.Cmd_ImportPayment.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_ImportPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_ImportPayment.Image = Global.SCANDB.My.Resources.Resources.server_connect
        Me.Cmd_ImportPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_ImportPayment.Location = New System.Drawing.Point(672, 3)
        Me.Cmd_ImportPayment.Name = "Cmd_ImportPayment"
        Me.Cmd_ImportPayment.Size = New System.Drawing.Size(139, 40)
        Me.Cmd_ImportPayment.TabIndex = 17
        Me.Cmd_ImportPayment.Text = "Import Payment"
        Me.Cmd_ImportPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_ImportPayment.UseVisualStyleBackColor = False
        '
        'Cmd_ImportHub
        '
        Me.Cmd_ImportHub.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_ImportHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_ImportHub.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.Cmd_ImportHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_ImportHub.Location = New System.Drawing.Point(185, 12)
        Me.Cmd_ImportHub.Name = "Cmd_ImportHub"
        Me.Cmd_ImportHub.Size = New System.Drawing.Size(115, 31)
        Me.Cmd_ImportHub.TabIndex = 18
        Me.Cmd_ImportHub.Text = "Import HUB"
        Me.Cmd_ImportHub.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_ImportHub.UseVisualStyleBackColor = False
        '
        'Cmd_Daily_Payment
        '
        Me.Cmd_Daily_Payment.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_Daily_Payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_Daily_Payment.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.Cmd_Daily_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Daily_Payment.Location = New System.Drawing.Point(306, 12)
        Me.Cmd_Daily_Payment.Name = "Cmd_Daily_Payment"
        Me.Cmd_Daily_Payment.Size = New System.Drawing.Size(129, 31)
        Me.Cmd_Daily_Payment.TabIndex = 19
        Me.Cmd_Daily_Payment.Text = "Daily_Payment"
        Me.Cmd_Daily_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Daily_Payment.UseVisualStyleBackColor = False
        '
        'Frmcollector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Cmd_Daily_Payment)
        Me.Controls.Add(Me.Cmd_ImportHub)
        Me.Controls.Add(Me.Cmd_ImportPayment)
        Me.Controls.Add(Me.Dtgv_Zero_collector)
        Me.Controls.Add(Me.Cmd_ImportPerformance)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmcollector"
        Me.Text = "Frmcollector"
        CType(Me.Dtgv_Zero_collector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cmd_ImportPerformance As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Dtgv_Zero_collector As DataGridView
    Friend WithEvents Cmd_ImportPayment As Button
    Friend WithEvents Cmd_ImportHub As Button
    Friend WithEvents Cmd_Daily_Payment As Button
End Class
