<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmimportAccounting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmimportAccounting))
        Me.lbl_statusprogress = New System.Windows.Forms.Label()
        Me.Main_progressbar = New System.Windows.Forms.ProgressBar()
        Me.lbl_countimport = New System.Windows.Forms.Label()
        Me.lbl_grandtotal = New System.Windows.Forms.Label()
        Me.cbo_products = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgv_view = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_openfile = New System.Windows.Forms.Button()
        Me.txt_import = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cmd_cut_check = New System.Windows.Forms.Button()
        Me.cmd_toserver = New System.Windows.Forms.Button()
        Me.cmd_import = New System.Windows.Forms.Button()
        Me.cbo_types_Accounting = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dtgv_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_statusprogress
        '
        Me.lbl_statusprogress.AutoSize = True
        Me.lbl_statusprogress.Location = New System.Drawing.Point(454, 674)
        Me.lbl_statusprogress.Name = "lbl_statusprogress"
        Me.lbl_statusprogress.Size = New System.Drawing.Size(24, 13)
        Me.lbl_statusprogress.TabIndex = 23
        Me.lbl_statusprogress.Text = "0 %"
        Me.lbl_statusprogress.Visible = False
        '
        'Main_progressbar
        '
        Me.Main_progressbar.BackColor = System.Drawing.Color.GreenYellow
        Me.Main_progressbar.ForeColor = System.Drawing.Color.Red
        Me.Main_progressbar.Location = New System.Drawing.Point(271, 672)
        Me.Main_progressbar.Name = "Main_progressbar"
        Me.Main_progressbar.Size = New System.Drawing.Size(177, 18)
        Me.Main_progressbar.TabIndex = 22
        Me.Main_progressbar.Visible = False
        '
        'lbl_countimport
        '
        Me.lbl_countimport.AutoSize = True
        Me.lbl_countimport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_countimport.Location = New System.Drawing.Point(138, 674)
        Me.lbl_countimport.Name = "lbl_countimport"
        Me.lbl_countimport.Size = New System.Drawing.Size(44, 15)
        Me.lbl_countimport.TabIndex = 21
        Me.lbl_countimport.Text = "XXXXX"
        Me.lbl_countimport.Visible = False
        '
        'lbl_grandtotal
        '
        Me.lbl_grandtotal.AutoSize = True
        Me.lbl_grandtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_grandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_grandtotal.Location = New System.Drawing.Point(59, 672)
        Me.lbl_grandtotal.Name = "lbl_grandtotal"
        Me.lbl_grandtotal.Size = New System.Drawing.Size(73, 18)
        Me.lbl_grandtotal.TabIndex = 20
        Me.lbl_grandtotal.Text = "จำนวนข้อมูล :"
        Me.lbl_grandtotal.Visible = False
        '
        'cbo_products
        '
        Me.cbo_products.ForeColor = System.Drawing.Color.Blue
        Me.cbo_products.FormattingEnabled = True
        Me.cbo_products.Location = New System.Drawing.Point(174, 54)
        Me.cbo_products.Name = "cbo_products"
        Me.cbo_products.Size = New System.Drawing.Size(88, 21)
        Me.cbo_products.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Product ข้อมูล :"
        '
        'dtgv_view
        '
        Me.dtgv_view.AllowUserToAddRows = False
        Me.dtgv_view.AllowUserToDeleteRows = False
        Me.dtgv_view.BackgroundColor = System.Drawing.Color.White
        Me.dtgv_view.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgv_view.Location = New System.Drawing.Point(58, 88)
        Me.dtgv_view.Name = "dtgv_view"
        Me.dtgv_view.ReadOnly = True
        Me.dtgv_view.RowHeadersVisible = False
        Me.dtgv_view.Size = New System.Drawing.Size(901, 583)
        Me.dtgv_view.TabIndex = 16
        Me.dtgv_view.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "แหล่งข้อมูล :"
        '
        'cmd_openfile
        '
        Me.cmd_openfile.BackColor = System.Drawing.Color.White
        Me.cmd_openfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_openfile.Location = New System.Drawing.Point(808, 15)
        Me.cmd_openfile.Name = "cmd_openfile"
        Me.cmd_openfile.Size = New System.Drawing.Size(30, 23)
        Me.cmd_openfile.TabIndex = 13
        Me.cmd_openfile.Text = "..."
        Me.cmd_openfile.UseVisualStyleBackColor = False
        '
        'txt_import
        '
        Me.txt_import.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_import.Location = New System.Drawing.Point(151, 16)
        Me.txt_import.Name = "txt_import"
        Me.txt_import.Size = New System.Drawing.Size(651, 22)
        Me.txt_import.TabIndex = 12
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BackgroundWorker1
        '
        '
        'cmd_cut_check
        '
        Me.cmd_cut_check.BackColor = System.Drawing.Color.White
        Me.cmd_cut_check.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_cut_check.Image = Global.SCANDB.My.Resources.Resources.Cut_24x24
        Me.cmd_cut_check.Location = New System.Drawing.Point(688, 48)
        Me.cmd_cut_check.Name = "cmd_cut_check"
        Me.cmd_cut_check.Size = New System.Drawing.Size(130, 31)
        Me.cmd_cut_check.TabIndex = 24
        Me.cmd_cut_check.Text = "ตัดรายการซ้ำ"
        Me.cmd_cut_check.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cut_check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cut_check.UseVisualStyleBackColor = False
        '
        'cmd_toserver
        '
        Me.cmd_toserver.BackColor = System.Drawing.Color.White
        Me.cmd_toserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_toserver.Image = Global.SCANDB.My.Resources.Resources.Upload_24x24
        Me.cmd_toserver.Location = New System.Drawing.Point(824, 48)
        Me.cmd_toserver.Name = "cmd_toserver"
        Me.cmd_toserver.Size = New System.Drawing.Size(130, 31)
        Me.cmd_toserver.TabIndex = 19
        Me.cmd_toserver.Text = "ส่งเข้าเซิฟเวอร์"
        Me.cmd_toserver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_toserver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_toserver.UseVisualStyleBackColor = False
        '
        'cmd_import
        '
        Me.cmd_import.BackColor = System.Drawing.Color.White
        Me.cmd_import.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_import.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.cmd_import.Location = New System.Drawing.Point(844, 11)
        Me.cmd_import.Name = "cmd_import"
        Me.cmd_import.Size = New System.Drawing.Size(110, 31)
        Me.cmd_import.TabIndex = 15
        Me.cmd_import.Text = "นำเข้าข้อมูล"
        Me.cmd_import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_import.UseVisualStyleBackColor = False
        '
        'cbo_types_Accounting
        '
        Me.cbo_types_Accounting.ForeColor = System.Drawing.Color.Blue
        Me.cbo_types_Accounting.FormattingEnabled = True
        Me.cbo_types_Accounting.Location = New System.Drawing.Point(358, 54)
        Me.cbo_types_Accounting.Name = "cbo_types_Accounting"
        Me.cbo_types_Accounting.Size = New System.Drawing.Size(105, 21)
        Me.cbo_types_Accounting.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(268, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ประเภทการเบิก :"
        '
        'FrmimportAccounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.cbo_types_Accounting)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmd_cut_check)
        Me.Controls.Add(Me.lbl_statusprogress)
        Me.Controls.Add(Me.Main_progressbar)
        Me.Controls.Add(Me.lbl_countimport)
        Me.Controls.Add(Me.lbl_grandtotal)
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
        Me.Name = "FrmimportAccounting"
        Me.Text = "อัพโหลด INVOICE KBANK"
        CType(Me.dtgv_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_statusprogress As Label
    Friend WithEvents Main_progressbar As ProgressBar
    Friend WithEvents lbl_countimport As Label
    Friend WithEvents lbl_grandtotal As Label
    Friend WithEvents cmd_toserver As Button
    Friend WithEvents cbo_products As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtgv_view As DataGridView
    Friend WithEvents cmd_import As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_openfile As Button
    Friend WithEvents txt_import As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmd_cut_check As Button
    Friend WithEvents cbo_types_Accounting As ComboBox
    Friend WithEvents Label4 As Label
End Class
