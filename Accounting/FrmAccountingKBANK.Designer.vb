<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAccountingKBANK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAccountingKBANK))
        Me.Ax_pdf_invoice = New AxAcroPDFLib.AxAcroPDF()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.dtgv_invoice_list = New System.Windows.Forms.DataGridView()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.Grb_detail = New System.Windows.Forms.GroupBox()
        Me.cmd_find_scan = New System.Windows.Forms.Button()
        Me.txt_invoice2 = New System.Windows.Forms.TextBox()
        Me.txt_type_master = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmd_clears = New System.Windows.Forms.Button()
        Me.txt_type_legal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_invoice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_receipt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_capital = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_court = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_blackred = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_send_invoice = New System.Windows.Forms.CheckBox()
        Me.Chk_date_legal = New System.Windows.Forms.CheckBox()
        Me.dtp_send_invoice = New System.Windows.Forms.DateTimePicker()
        Me.dtp_date_legal = New System.Windows.Forms.DateTimePicker()
        Me.txt_namecus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cuscus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_order = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgv_find_scan = New System.Windows.Forms.DataGridView()
        CType(Me.Ax_pdf_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtgv_invoice_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb_detail.SuspendLayout()
        CType(Me.dtgv_find_scan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ax_pdf_invoice
        '
        Me.Ax_pdf_invoice.Enabled = True
        Me.Ax_pdf_invoice.Location = New System.Drawing.Point(406, 52)
        Me.Ax_pdf_invoice.Name = "Ax_pdf_invoice"
        Me.Ax_pdf_invoice.OcxState = CType(resources.GetObject("Ax_pdf_invoice.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ax_pdf_invoice.Size = New System.Drawing.Size(602, 676)
        Me.Ax_pdf_invoice.TabIndex = 0
        Me.Ax_pdf_invoice.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.cmd_search)
        Me.GroupBox5.Controls.Add(Me.cbo_search)
        Me.GroupBox5.Controls.Add(Me.txt_search)
        Me.GroupBox5.Location = New System.Drawing.Point(406, -2)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Size = New System.Drawing.Size(601, 55)
        Me.GroupBox5.TabIndex = 78
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ค้นหาข้อมูล"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 20)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "ประเภทข้อมูล"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(244, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 20)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "ข้อมูลที่ต้องการหา"
        '
        'cmd_search
        '
        Me.cmd_search.BackColor = System.Drawing.Color.White
        Me.cmd_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_search.Image = Global.SCANDB.My.Resources.Resources.Find_16x16
        Me.cmd_search.Location = New System.Drawing.Point(499, 16)
        Me.cmd_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(93, 29)
        Me.cmd_search.TabIndex = 3
        Me.cmd_search.Text = "ค้นหาข้อมูล"
        Me.cmd_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_search.UseVisualStyleBackColor = False
        '
        'cbo_search
        '
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Location = New System.Drawing.Point(101, 18)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(137, 21)
        Me.cbo_search.TabIndex = 1
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(349, 19)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(143, 22)
        Me.txt_search.TabIndex = 2
        '
        'dtgv_invoice_list
        '
        Me.dtgv_invoice_list.AllowUserToAddRows = False
        Me.dtgv_invoice_list.AllowUserToDeleteRows = False
        Me.dtgv_invoice_list.BackgroundColor = System.Drawing.Color.White
        Me.dtgv_invoice_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_invoice_list.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgv_invoice_list.Location = New System.Drawing.Point(1, 52)
        Me.dtgv_invoice_list.Name = "dtgv_invoice_list"
        Me.dtgv_invoice_list.ReadOnly = True
        Me.dtgv_invoice_list.RowHeadersVisible = False
        Me.dtgv_invoice_list.Size = New System.Drawing.Size(295, 134)
        Me.dtgv_invoice_list.TabIndex = 79
        Me.dtgv_invoice_list.Visible = False
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_search.Location = New System.Drawing.Point(13, 12)
        Me.lbl_search.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(356, 31)
        Me.lbl_search.TabIndex = 80
        Me.lbl_search.Text = "ค้นหาเอกสารเบิก-จ่าย KBANK"
        '
        'Grb_detail
        '
        Me.Grb_detail.Controls.Add(Me.cmd_find_scan)
        Me.Grb_detail.Controls.Add(Me.txt_invoice2)
        Me.Grb_detail.Controls.Add(Me.txt_type_master)
        Me.Grb_detail.Controls.Add(Me.Label11)
        Me.Grb_detail.Controls.Add(Me.cmd_clears)
        Me.Grb_detail.Controls.Add(Me.txt_type_legal)
        Me.Grb_detail.Controls.Add(Me.Label10)
        Me.Grb_detail.Controls.Add(Me.txt_invoice)
        Me.Grb_detail.Controls.Add(Me.Label6)
        Me.Grb_detail.Controls.Add(Me.txt_receipt)
        Me.Grb_detail.Controls.Add(Me.Label5)
        Me.Grb_detail.Controls.Add(Me.txt_capital)
        Me.Grb_detail.Controls.Add(Me.Label4)
        Me.Grb_detail.Controls.Add(Me.txt_court)
        Me.Grb_detail.Controls.Add(Me.Label3)
        Me.Grb_detail.Controls.Add(Me.txt_blackred)
        Me.Grb_detail.Controls.Add(Me.Label2)
        Me.Grb_detail.Controls.Add(Me.chk_send_invoice)
        Me.Grb_detail.Controls.Add(Me.Chk_date_legal)
        Me.Grb_detail.Controls.Add(Me.dtp_send_invoice)
        Me.Grb_detail.Controls.Add(Me.dtp_date_legal)
        Me.Grb_detail.Controls.Add(Me.txt_namecus)
        Me.Grb_detail.Controls.Add(Me.Label9)
        Me.Grb_detail.Controls.Add(Me.txt_cuscus)
        Me.Grb_detail.Controls.Add(Me.Label7)
        Me.Grb_detail.Controls.Add(Me.txt_order)
        Me.Grb_detail.Controls.Add(Me.Label1)
        Me.Grb_detail.Location = New System.Drawing.Point(1, 194)
        Me.Grb_detail.Margin = New System.Windows.Forms.Padding(5)
        Me.Grb_detail.Name = "Grb_detail"
        Me.Grb_detail.Padding = New System.Windows.Forms.Padding(5)
        Me.Grb_detail.Size = New System.Drawing.Size(295, 382)
        Me.Grb_detail.TabIndex = 87
        Me.Grb_detail.TabStop = False
        Me.Grb_detail.Text = "รายละเอียด"
        Me.Grb_detail.Visible = False
        '
        'cmd_find_scan
        '
        Me.cmd_find_scan.BackColor = System.Drawing.Color.White
        Me.cmd_find_scan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_find_scan.Image = Global.SCANDB.My.Resources.Resources.folder_find1
        Me.cmd_find_scan.Location = New System.Drawing.Point(12, 342)
        Me.cmd_find_scan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_find_scan.Name = "cmd_find_scan"
        Me.cmd_find_scan.Size = New System.Drawing.Size(127, 29)
        Me.cmd_find_scan.TabIndex = 16
        Me.cmd_find_scan.Text = "ค้นหาเอกสาร"
        Me.cmd_find_scan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_find_scan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_find_scan.UseVisualStyleBackColor = False
        '
        'txt_invoice2
        '
        Me.txt_invoice2.ForeColor = System.Drawing.Color.Crimson
        Me.txt_invoice2.Location = New System.Drawing.Point(203, 229)
        Me.txt_invoice2.Name = "txt_invoice2"
        Me.txt_invoice2.Size = New System.Drawing.Size(81, 20)
        Me.txt_invoice2.TabIndex = 12
        '
        'txt_type_master
        '
        Me.txt_type_master.ForeColor = System.Drawing.Color.Blue
        Me.txt_type_master.Location = New System.Drawing.Point(114, 307)
        Me.txt_type_master.Name = "txt_type_master"
        Me.txt_type_master.Size = New System.Drawing.Size(170, 20)
        Me.txt_type_master.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "ประเภทบัญชี"
        '
        'cmd_clears
        '
        Me.cmd_clears.BackColor = System.Drawing.Color.White
        Me.cmd_clears.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_clears.Image = Global.SCANDB.My.Resources.Resources.arrow_redo
        Me.cmd_clears.Location = New System.Drawing.Point(153, 342)
        Me.cmd_clears.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_clears.Name = "cmd_clears"
        Me.cmd_clears.Size = New System.Drawing.Size(127, 29)
        Me.cmd_clears.TabIndex = 17
        Me.cmd_clears.Text = "เคลียร์ข้อมูล"
        Me.cmd_clears.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_clears.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_clears.UseVisualStyleBackColor = False
        '
        'txt_type_legal
        '
        Me.txt_type_legal.ForeColor = System.Drawing.Color.Blue
        Me.txt_type_legal.Location = New System.Drawing.Point(114, 281)
        Me.txt_type_legal.Name = "txt_type_legal"
        Me.txt_type_legal.Size = New System.Drawing.Size(170, 20)
        Me.txt_type_legal.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 20)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "ประเภทการเบิก"
        '
        'txt_invoice
        '
        Me.txt_invoice.ForeColor = System.Drawing.Color.Crimson
        Me.txt_invoice.Location = New System.Drawing.Point(114, 229)
        Me.txt_invoice.Name = "txt_invoice"
        Me.txt_invoice.Size = New System.Drawing.Size(83, 20)
        Me.txt_invoice.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "ชุดเบิกที่"
        '
        'txt_receipt
        '
        Me.txt_receipt.ForeColor = System.Drawing.Color.SeaGreen
        Me.txt_receipt.Location = New System.Drawing.Point(114, 203)
        Me.txt_receipt.Name = "txt_receipt"
        Me.txt_receipt.Size = New System.Drawing.Size(170, 20)
        Me.txt_receipt.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "ค่าฤชาธรรมเนียม"
        '
        'txt_capital
        '
        Me.txt_capital.ForeColor = System.Drawing.Color.Indigo
        Me.txt_capital.Location = New System.Drawing.Point(114, 177)
        Me.txt_capital.Name = "txt_capital"
        Me.txt_capital.Size = New System.Drawing.Size(170, 20)
        Me.txt_capital.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "ทุนทรัพย์"
        '
        'txt_court
        '
        Me.txt_court.ForeColor = System.Drawing.Color.Blue
        Me.txt_court.Location = New System.Drawing.Point(114, 151)
        Me.txt_court.Name = "txt_court"
        Me.txt_court.Size = New System.Drawing.Size(170, 20)
        Me.txt_court.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "ชื่อศาล"
        '
        'txt_blackred
        '
        Me.txt_blackred.ForeColor = System.Drawing.Color.Blue
        Me.txt_blackred.Location = New System.Drawing.Point(114, 99)
        Me.txt_blackred.Name = "txt_blackred"
        Me.txt_blackred.Size = New System.Drawing.Size(170, 20)
        Me.txt_blackred.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "เลขที่คดี"
        '
        'chk_send_invoice
        '
        Me.chk_send_invoice.AutoSize = True
        Me.chk_send_invoice.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_send_invoice.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_send_invoice.ForeColor = System.Drawing.Color.Blue
        Me.chk_send_invoice.Location = New System.Drawing.Point(13, 255)
        Me.chk_send_invoice.Name = "chk_send_invoice"
        Me.chk_send_invoice.Size = New System.Drawing.Size(108, 22)
        Me.chk_send_invoice.TabIndex = 96
        Me.chk_send_invoice.Text = "วัน/เดือน/ปีที่เบิก"
        Me.chk_send_invoice.UseVisualStyleBackColor = True
        '
        'Chk_date_legal
        '
        Me.Chk_date_legal.AutoSize = True
        Me.Chk_date_legal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Chk_date_legal.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_date_legal.ForeColor = System.Drawing.Color.Blue
        Me.Chk_date_legal.Location = New System.Drawing.Point(13, 125)
        Me.Chk_date_legal.Name = "Chk_date_legal"
        Me.Chk_date_legal.Size = New System.Drawing.Size(108, 22)
        Me.Chk_date_legal.TabIndex = 95
        Me.Chk_date_legal.Text = "วัน/เดือน/ปี ฟ้อง"
        Me.Chk_date_legal.UseVisualStyleBackColor = True
        '
        'dtp_send_invoice
        '
        Me.dtp_send_invoice.CalendarForeColor = System.Drawing.Color.Blue
        Me.dtp_send_invoice.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_send_invoice.Location = New System.Drawing.Point(127, 255)
        Me.dtp_send_invoice.Name = "dtp_send_invoice"
        Me.dtp_send_invoice.Size = New System.Drawing.Size(157, 20)
        Me.dtp_send_invoice.TabIndex = 13
        '
        'dtp_date_legal
        '
        Me.dtp_date_legal.CalendarForeColor = System.Drawing.Color.Blue
        Me.dtp_date_legal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_legal.Location = New System.Drawing.Point(127, 125)
        Me.dtp_date_legal.Name = "dtp_date_legal"
        Me.dtp_date_legal.Size = New System.Drawing.Size(157, 20)
        Me.dtp_date_legal.TabIndex = 8
        '
        'txt_namecus
        '
        Me.txt_namecus.ForeColor = System.Drawing.Color.Blue
        Me.txt_namecus.Location = New System.Drawing.Point(114, 73)
        Me.txt_namecus.Name = "txt_namecus"
        Me.txt_namecus.Size = New System.Drawing.Size(170, 20)
        Me.txt_namecus.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "ชื่อ-นามสกุล"
        '
        'txt_cuscus
        '
        Me.txt_cuscus.ForeColor = System.Drawing.Color.Blue
        Me.txt_cuscus.Location = New System.Drawing.Point(114, 47)
        Me.txt_cuscus.Name = "txt_cuscus"
        Me.txt_cuscus.Size = New System.Drawing.Size(170, 20)
        Me.txt_cuscus.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "เลขที่ลูกหนี้"
        '
        'txt_order
        '
        Me.txt_order.ForeColor = System.Drawing.Color.Blue
        Me.txt_order.Location = New System.Drawing.Point(114, 21)
        Me.txt_order.Name = "txt_order"
        Me.txt_order.Size = New System.Drawing.Size(170, 20)
        Me.txt_order.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "ลำดับที่"
        '
        'dtgv_find_scan
        '
        Me.dtgv_find_scan.AllowUserToAddRows = False
        Me.dtgv_find_scan.AllowUserToDeleteRows = False
        Me.dtgv_find_scan.BackgroundColor = System.Drawing.Color.White
        Me.dtgv_find_scan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_find_scan.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgv_find_scan.Location = New System.Drawing.Point(296, 52)
        Me.dtgv_find_scan.Name = "dtgv_find_scan"
        Me.dtgv_find_scan.ReadOnly = True
        Me.dtgv_find_scan.RowHeadersVisible = False
        Me.dtgv_find_scan.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dtgv_find_scan.Size = New System.Drawing.Size(110, 134)
        Me.dtgv_find_scan.TabIndex = 88
        Me.dtgv_find_scan.Visible = False
        '
        'FrmAccountingKBANK
        '
        Me.AcceptButton = Me.cmd_search
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.dtgv_find_scan)
        Me.Controls.Add(Me.Grb_detail)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.dtgv_invoice_list)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Ax_pdf_invoice)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAccountingKBANK"
        Me.Text = "ข้อมูลเบิก KBANK"
        CType(Me.Ax_pdf_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtgv_invoice_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb_detail.ResumeLayout(False)
        Me.Grb_detail.PerformLayout()
        CType(Me.dtgv_find_scan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ax_pdf_invoice As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmd_search As Button
    Friend WithEvents cbo_search As ComboBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents dtgv_invoice_list As DataGridView
    Friend WithEvents lbl_search As Label
    Friend WithEvents Grb_detail As GroupBox
    Friend WithEvents txt_type_master As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_type_legal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_invoice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_receipt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_capital As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_court As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_blackred As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chk_send_invoice As CheckBox
    Friend WithEvents Chk_date_legal As CheckBox
    Friend WithEvents dtp_send_invoice As DateTimePicker
    Friend WithEvents dtp_date_legal As DateTimePicker
    Friend WithEvents txt_namecus As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cuscus As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_order As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_clears As Button
    Friend WithEvents cmd_find_scan As Button
    Friend WithEvents dtgv_find_scan As DataGridView
    Friend WithEvents txt_invoice2 As TextBox
End Class
