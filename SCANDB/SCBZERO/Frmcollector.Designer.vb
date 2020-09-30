<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmcollector
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmcollector))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbl_Performance_Upload = New System.Windows.Forms.Label()
        Me.ProgressBar_Performance_Upload = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Performance_path = New System.Windows.Forms.TextBox()
        Me.Dtgv_Zero_collector = New System.Windows.Forms.DataGridView()
        Me.Cmd_Performance_ImportPerformance = New System.Windows.Forms.Button()
        Me.Cmd_Performance_Findexcel = New System.Windows.Forms.Button()
        Me.Cmd_Performance_ImportPayment = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Dtgv_Zero_collector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1006, 731)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(998, 705)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Performance"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbl_Performance_Upload)
        Me.TabPage2.Controls.Add(Me.ProgressBar_Performance_Upload)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Txt_Performance_path)
        Me.TabPage2.Controls.Add(Me.Dtgv_Zero_collector)
        Me.TabPage2.Controls.Add(Me.Cmd_Performance_ImportPerformance)
        Me.TabPage2.Controls.Add(Me.Cmd_Performance_Findexcel)
        Me.TabPage2.Controls.Add(Me.Cmd_Performance_ImportPayment)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(998, 705)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Performance Update"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbl_Performance_Upload
        '
        Me.lbl_Performance_Upload.AutoSize = True
        Me.lbl_Performance_Upload.Location = New System.Drawing.Point(883, 25)
        Me.lbl_Performance_Upload.Name = "lbl_Performance_Upload"
        Me.lbl_Performance_Upload.Size = New System.Drawing.Size(24, 13)
        Me.lbl_Performance_Upload.TabIndex = 28
        Me.lbl_Performance_Upload.Text = "0/0"
        '
        'ProgressBar_Performance_Upload
        '
        Me.ProgressBar_Performance_Upload.Location = New System.Drawing.Point(674, 19)
        Me.ProgressBar_Performance_Upload.Name = "ProgressBar_Performance_Upload"
        Me.ProgressBar_Performance_Upload.Size = New System.Drawing.Size(203, 23)
        Me.ProgressBar_Performance_Upload.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Path Files :"
        '
        'Txt_Performance_path
        '
        Me.Txt_Performance_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Txt_Performance_path.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Performance_path.Location = New System.Drawing.Point(185, 22)
        Me.Txt_Performance_path.Name = "Txt_Performance_path"
        Me.Txt_Performance_path.Size = New System.Drawing.Size(271, 20)
        Me.Txt_Performance_path.TabIndex = 25
        '
        'Dtgv_Zero_collector
        '
        Me.Dtgv_Zero_collector.AllowUserToAddRows = False
        Me.Dtgv_Zero_collector.AllowUserToDeleteRows = False
        Me.Dtgv_Zero_collector.BackgroundColor = System.Drawing.SystemColors.Window
        Me.Dtgv_Zero_collector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_Zero_collector.GridColor = System.Drawing.Color.Black
        Me.Dtgv_Zero_collector.Location = New System.Drawing.Point(8, 49)
        Me.Dtgv_Zero_collector.Name = "Dtgv_Zero_collector"
        Me.Dtgv_Zero_collector.ReadOnly = True
        Me.Dtgv_Zero_collector.RowHeadersVisible = False
        Me.Dtgv_Zero_collector.Size = New System.Drawing.Size(984, 644)
        Me.Dtgv_Zero_collector.TabIndex = 21
        '
        'Cmd_Performance_ImportPerformance
        '
        Me.Cmd_Performance_ImportPerformance.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_Performance_ImportPerformance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_Performance_ImportPerformance.Image = Global.SCANDB.My.Resources.Resources.table_add
        Me.Cmd_Performance_ImportPerformance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Performance_ImportPerformance.Location = New System.Drawing.Point(8, 19)
        Me.Cmd_Performance_ImportPerformance.Name = "Cmd_Performance_ImportPerformance"
        Me.Cmd_Performance_ImportPerformance.Size = New System.Drawing.Size(111, 24)
        Me.Cmd_Performance_ImportPerformance.TabIndex = 20
        Me.Cmd_Performance_ImportPerformance.Text = "Sent To Server"
        Me.Cmd_Performance_ImportPerformance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Performance_ImportPerformance.UseVisualStyleBackColor = False
        '
        'Cmd_Performance_Findexcel
        '
        Me.Cmd_Performance_Findexcel.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_Performance_Findexcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_Performance_Findexcel.Image = Global.SCANDB.My.Resources.Resources.page_excel1
        Me.Cmd_Performance_Findexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Performance_Findexcel.Location = New System.Drawing.Point(462, 19)
        Me.Cmd_Performance_Findexcel.Name = "Cmd_Performance_Findexcel"
        Me.Cmd_Performance_Findexcel.Size = New System.Drawing.Size(86, 24)
        Me.Cmd_Performance_Findexcel.TabIndex = 23
        Me.Cmd_Performance_Findexcel.Text = "Find Excel"
        Me.Cmd_Performance_Findexcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Performance_Findexcel.UseVisualStyleBackColor = False
        '
        'Cmd_Performance_ImportPayment
        '
        Me.Cmd_Performance_ImportPayment.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_Performance_ImportPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_Performance_ImportPayment.Image = Global.SCANDB.My.Resources.Resources.coins_add
        Me.Cmd_Performance_ImportPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Performance_ImportPayment.Location = New System.Drawing.Point(554, 19)
        Me.Cmd_Performance_ImportPayment.Name = "Cmd_Performance_ImportPayment"
        Me.Cmd_Performance_ImportPayment.Size = New System.Drawing.Size(114, 24)
        Me.Cmd_Performance_ImportPayment.TabIndex = 22
        Me.Cmd_Performance_ImportPayment.Text = "Import Payment"
        Me.Cmd_Performance_ImportPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Performance_ImportPayment.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
        '
        'Frmcollector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmcollector"
        Me.Text = "Performance (SCBZero)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Dtgv_Zero_collector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Txt_Performance_path As TextBox
    Friend WithEvents Dtgv_Zero_collector As DataGridView
    Friend WithEvents Cmd_Performance_ImportPerformance As Button
    Friend WithEvents Cmd_Performance_Findexcel As Button
    Friend WithEvents Cmd_Performance_ImportPayment As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Performance_Upload As Label
    Friend WithEvents ProgressBar_Performance_Upload As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
