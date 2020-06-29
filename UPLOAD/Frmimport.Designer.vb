<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmimport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmimport))
        Me.txt_import = New System.Windows.Forms.TextBox()
        Me.cmd_openfile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgv_view = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_products = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_countimport = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cmd_toserver = New System.Windows.Forms.Button()
        Me.cmd_import = New System.Windows.Forms.Button()
        Me.Main_progressbar = New System.Windows.Forms.ProgressBar()
        Me.lbl_statusprogress = New System.Windows.Forms.Label()
        CType(Me.dtgv_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_import
        '
        Me.txt_import.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_import.Location = New System.Drawing.Point(125, 12)
        Me.txt_import.Name = "txt_import"
        Me.txt_import.Size = New System.Drawing.Size(651, 22)
        Me.txt_import.TabIndex = 0
        '
        'cmd_openfile
        '
        Me.cmd_openfile.BackColor = System.Drawing.Color.White
        Me.cmd_openfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_openfile.Location = New System.Drawing.Point(782, 11)
        Me.cmd_openfile.Name = "cmd_openfile"
        Me.cmd_openfile.Size = New System.Drawing.Size(30, 23)
        Me.cmd_openfile.TabIndex = 1
        Me.cmd_openfile.Text = "..."
        Me.cmd_openfile.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "แหล่งข้อมูล :"
        '
        'dtgv_view
        '
        Me.dtgv_view.AllowUserToAddRows = False
        Me.dtgv_view.AllowUserToDeleteRows = False
        Me.dtgv_view.BackgroundColor = System.Drawing.Color.White
        Me.dtgv_view.GridColor = System.Drawing.Color.Black
        Me.dtgv_view.Location = New System.Drawing.Point(27, 88)
        Me.dtgv_view.Name = "dtgv_view"
        Me.dtgv_view.ReadOnly = True
        Me.dtgv_view.RowHeadersVisible = False
        Me.dtgv_view.Size = New System.Drawing.Size(901, 608)
        Me.dtgv_view.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Product ข้อมูล :"
        '
        'cbo_products
        '
        Me.cbo_products.FormattingEnabled = True
        Me.cbo_products.Location = New System.Drawing.Point(125, 46)
        Me.cbo_products.Name = "cbo_products"
        Me.cbo_products.Size = New System.Drawing.Size(75, 21)
        Me.cbo_products.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "จำนวนข้อมูล :"
        '
        'lbl_countimport
        '
        Me.lbl_countimport.AutoSize = True
        Me.lbl_countimport.Location = New System.Drawing.Point(285, 49)
        Me.lbl_countimport.Name = "lbl_countimport"
        Me.lbl_countimport.Size = New System.Drawing.Size(42, 13)
        Me.lbl_countimport.TabIndex = 9
        Me.lbl_countimport.Text = "XXXXX"
        '
        'BackgroundWorker1
        '
        '
        'cmd_toserver
        '
        Me.cmd_toserver.BackColor = System.Drawing.Color.White
        Me.cmd_toserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_toserver.Image = Global.SCANDB.My.Resources.Resources.Upload_24x24
        Me.cmd_toserver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_toserver.Location = New System.Drawing.Point(798, 44)
        Me.cmd_toserver.Name = "cmd_toserver"
        Me.cmd_toserver.Size = New System.Drawing.Size(130, 31)
        Me.cmd_toserver.TabIndex = 7
        Me.cmd_toserver.Text = "Send to Server"
        Me.cmd_toserver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_toserver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_toserver.UseVisualStyleBackColor = False
        '
        'cmd_import
        '
        Me.cmd_import.BackColor = System.Drawing.Color.White
        Me.cmd_import.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_import.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.cmd_import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_import.Location = New System.Drawing.Point(818, 7)
        Me.cmd_import.Name = "cmd_import"
        Me.cmd_import.Size = New System.Drawing.Size(110, 31)
        Me.cmd_import.TabIndex = 3
        Me.cmd_import.Text = "Import Data"
        Me.cmd_import.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_import.UseVisualStyleBackColor = False
        '
        'Main_progressbar
        '
        Me.Main_progressbar.Location = New System.Drawing.Point(27, 702)
        Me.Main_progressbar.Name = "Main_progressbar"
        Me.Main_progressbar.Size = New System.Drawing.Size(177, 23)
        Me.Main_progressbar.TabIndex = 10
        '
        'lbl_statusprogress
        '
        Me.lbl_statusprogress.AutoSize = True
        Me.lbl_statusprogress.Location = New System.Drawing.Point(210, 707)
        Me.lbl_statusprogress.Name = "lbl_statusprogress"
        Me.lbl_statusprogress.Size = New System.Drawing.Size(24, 13)
        Me.lbl_statusprogress.TabIndex = 11
        Me.lbl_statusprogress.Text = "0 %"
        '
        'Frmimport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1009, 729)
        Me.Controls.Add(Me.lbl_statusprogress)
        Me.Controls.Add(Me.Main_progressbar)
        Me.Controls.Add(Me.lbl_countimport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmd_toserver)
        Me.Controls.Add(Me.cbo_products)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgv_view)
        Me.Controls.Add(Me.cmd_import)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_openfile)
        Me.Controls.Add(Me.txt_import)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmimport"
        Me.Text = "โหลดข้อมูลเข้าระบบ"
        CType(Me.dtgv_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_import As TextBox
    Friend WithEvents cmd_openfile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_import As Button
    Friend WithEvents dtgv_view As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_products As ComboBox
    Friend WithEvents cmd_toserver As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_countimport As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Main_progressbar As ProgressBar
    Friend WithEvents lbl_statusprogress As Label
End Class
