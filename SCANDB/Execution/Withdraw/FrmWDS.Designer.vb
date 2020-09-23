<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWDS))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_hub = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbo_owner = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_checkview = New System.Windows.Forms.Button()
        Me.chk_datecheck = New System.Windows.Forms.CheckBox()
        Me.chk_datepayment = New System.Windows.Forms.CheckBox()
        Me.chk_datewds = New System.Windows.Forms.CheckBox()
        Me.chk_datecollector = New System.Windows.Forms.CheckBox()
        Me.dtp_datewds = New System.Windows.Forms.DateTimePicker()
        Me.dtp_payment = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_payment = New System.Windows.Forms.RichTextBox()
        Me.dtp_datecollector = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_refund = New System.Windows.Forms.RichTextBox()
        Me.dtp_daterefund = New System.Windows.Forms.DateTimePicker()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbo_empexe = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbo_empadmin = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_red = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_cusacc = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cusacc = New System.Windows.Forms.TextBox()
        Me.txt_cusphone = New System.Windows.Forms.TextBox()
        Me.lbl_cuscus = New System.Windows.Forms.Label()
        Me.txt_cusid = New System.Windows.Forms.TextBox()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.txt_cuscus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_black = New System.Windows.Forms.TextBox()
        Me.txt_detail1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtgv_data = New System.Windows.Forms.DataGridView()
        Me.datetimestart = New System.Windows.Forms.DateTimePicker()
        Me.datetimefinish = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_product = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmd_datediff = New System.Windows.Forms.Button()
        Me.cmd_detele = New System.Windows.Forms.Button()
        Me.cmd_addnew = New System.Windows.Forms.Button()
        Me.cmd_searchdate = New System.Windows.Forms.Button()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.cmd_edit = New System.Windows.Forms.Button()
        Me.cmd_find = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.Txt_PK_Acc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_PK_Owner = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_hub)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbo_owner)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Owner"
        '
        'cbo_hub
        '
        Me.cbo_hub.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbo_hub.FormattingEnabled = True
        Me.cbo_hub.Location = New System.Drawing.Point(100, 51)
        Me.cbo_hub.Name = "cbo_hub"
        Me.cbo_hub.Size = New System.Drawing.Size(160, 24)
        Me.cbo_hub.TabIndex = 78
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 18)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "ศูนย์ประสานงาน"
        '
        'cbo_owner
        '
        Me.cbo_owner.FormattingEnabled = True
        Me.cbo_owner.Location = New System.Drawing.Point(102, 22)
        Me.cbo_owner.Name = "cbo_owner"
        Me.cbo_owner.Size = New System.Drawing.Size(158, 24)
        Me.cbo_owner.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 18)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "PRODUCT"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_checkview)
        Me.GroupBox2.Controls.Add(Me.chk_datecheck)
        Me.GroupBox2.Controls.Add(Me.chk_datepayment)
        Me.GroupBox2.Controls.Add(Me.chk_datewds)
        Me.GroupBox2.Controls.Add(Me.chk_datecollector)
        Me.GroupBox2.Controls.Add(Me.dtp_datewds)
        Me.GroupBox2.Controls.Add(Me.dtp_payment)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txt_payment)
        Me.GroupBox2.Controls.Add(Me.dtp_datecollector)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_refund)
        Me.GroupBox2.Controls.Add(Me.dtp_daterefund)
        Me.GroupBox2.Controls.Add(Me.txt_status)
        Me.GroupBox2.Location = New System.Drawing.Point(288, 113)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(329, 244)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียด"
        '
        'cmd_checkview
        '
        Me.cmd_checkview.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_checkview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_checkview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_checkview.Image = Global.SCANDB.My.Resources.Resources.script_go
        Me.cmd_checkview.Location = New System.Drawing.Point(8, 202)
        Me.cmd_checkview.Name = "cmd_checkview"
        Me.cmd_checkview.Size = New System.Drawing.Size(107, 32)
        Me.cmd_checkview.TabIndex = 102
        Me.cmd_checkview.Text = "ข้อมูลเช็ค"
        Me.cmd_checkview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_checkview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_checkview.UseVisualStyleBackColor = False
        '
        'chk_datecheck
        '
        Me.chk_datecheck.AutoSize = True
        Me.chk_datecheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datecheck.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datecheck.Location = New System.Drawing.Point(114, 138)
        Me.chk_datecheck.Name = "chk_datecheck"
        Me.chk_datecheck.Size = New System.Drawing.Size(79, 22)
        Me.chk_datecheck.TabIndex = 96
        Me.chk_datecheck.Text = "วันทื่ส่งเช็ค"
        Me.chk_datecheck.UseVisualStyleBackColor = True
        '
        'chk_datepayment
        '
        Me.chk_datepayment.AutoSize = True
        Me.chk_datepayment.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datepayment.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datepayment.Location = New System.Drawing.Point(93, 82)
        Me.chk_datepayment.Name = "chk_datepayment"
        Me.chk_datepayment.Size = New System.Drawing.Size(100, 22)
        Me.chk_datepayment.TabIndex = 95
        Me.chk_datepayment.Text = "วันที่ลูกค้าชำระ"
        Me.chk_datepayment.UseVisualStyleBackColor = True
        '
        'chk_datewds
        '
        Me.chk_datewds.AutoSize = True
        Me.chk_datewds.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datewds.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datewds.Location = New System.Drawing.Point(64, 57)
        Me.chk_datewds.Name = "chk_datewds"
        Me.chk_datewds.Size = New System.Drawing.Size(129, 22)
        Me.chk_datewds.TabIndex = 94
        Me.chk_datewds.Text = "วันที่ไปถอนอายัด/ยึด"
        Me.chk_datewds.UseVisualStyleBackColor = True
        '
        'chk_datecollector
        '
        Me.chk_datecollector.AutoSize = True
        Me.chk_datecollector.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datecollector.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datecollector.Location = New System.Drawing.Point(24, 28)
        Me.chk_datecollector.Name = "chk_datecollector"
        Me.chk_datecollector.Size = New System.Drawing.Size(169, 22)
        Me.chk_datecollector.TabIndex = 93
        Me.chk_datecollector.Text = "Collector ส่งถอนอายัด/ยึด"
        Me.chk_datecollector.UseVisualStyleBackColor = True
        '
        'dtp_datewds
        '
        Me.dtp_datewds.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datewds.Location = New System.Drawing.Point(199, 57)
        Me.dtp_datewds.Name = "dtp_datewds"
        Me.dtp_datewds.Size = New System.Drawing.Size(116, 22)
        Me.dtp_datewds.TabIndex = 78
        '
        'dtp_payment
        '
        Me.dtp_payment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_payment.Location = New System.Drawing.Point(199, 85)
        Me.dtp_payment.Name = "dtp_payment"
        Me.dtp_payment.Size = New System.Drawing.Size(116, 22)
        Me.dtp_payment.TabIndex = 76
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Window
        Me.Label18.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(100, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 18)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "จำนวนเงินที่ชำระ"
        '
        'txt_payment
        '
        Me.txt_payment.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payment.ForeColor = System.Drawing.Color.Green
        Me.txt_payment.Location = New System.Drawing.Point(199, 113)
        Me.txt_payment.Name = "txt_payment"
        Me.txt_payment.Size = New System.Drawing.Size(116, 20)
        Me.txt_payment.TabIndex = 75
        Me.txt_payment.Text = ""
        '
        'dtp_datecollector
        '
        Me.dtp_datecollector.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datecollector.Location = New System.Drawing.Point(199, 29)
        Me.dtp_datecollector.Name = "dtp_datecollector"
        Me.dtp_datecollector.Size = New System.Drawing.Size(116, 22)
        Me.dtp_datecollector.TabIndex = 67
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(120, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 18)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "STATUS :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(98, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 18)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "ค่าใช้จ่ายคืนโจทย์"
        '
        'txt_refund
        '
        Me.txt_refund.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_refund.ForeColor = System.Drawing.Color.Red
        Me.txt_refund.Location = New System.Drawing.Point(199, 167)
        Me.txt_refund.Name = "txt_refund"
        Me.txt_refund.Size = New System.Drawing.Size(116, 20)
        Me.txt_refund.TabIndex = 71
        Me.txt_refund.Text = ""
        '
        'dtp_daterefund
        '
        Me.dtp_daterefund.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_daterefund.Location = New System.Drawing.Point(199, 139)
        Me.dtp_daterefund.Name = "dtp_daterefund"
        Me.dtp_daterefund.Size = New System.Drawing.Size(116, 22)
        Me.dtp_daterefund.TabIndex = 68
        '
        'txt_status
        '
        Me.txt_status.ForeColor = System.Drawing.Color.Violet
        Me.txt_status.Location = New System.Drawing.Point(199, 208)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(116, 22)
        Me.txt_status.TabIndex = 85
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.cbo_empexe)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.cbo_empadmin)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(288, 3)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(329, 102)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Execution"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Customer_service_icon32x32
        Me.PictureBox1.Location = New System.Drawing.Point(19, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'cbo_empexe
        '
        Me.cbo_empexe.FormattingEnabled = True
        Me.cbo_empexe.Location = New System.Drawing.Point(121, 52)
        Me.cbo_empexe.Name = "cbo_empexe"
        Me.cbo_empexe.Size = New System.Drawing.Size(194, 24)
        Me.cbo_empexe.TabIndex = 82
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 18)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "เจ้าหน้าที่บังคับคดี"
        '
        'cbo_empadmin
        '
        Me.cbo_empadmin.FormattingEnabled = True
        Me.cbo_empadmin.Location = New System.Drawing.Point(121, 21)
        Me.cbo_empadmin.Name = "cbo_empadmin"
        Me.cbo_empadmin.Size = New System.Drawing.Size(194, 24)
        Me.cbo_empadmin.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 18)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Admin"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_red)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.lbl_cusacc)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txt_cusacc)
        Me.GroupBox4.Controls.Add(Me.txt_cusphone)
        Me.GroupBox4.Controls.Add(Me.lbl_cuscus)
        Me.GroupBox4.Controls.Add(Me.txt_cusid)
        Me.GroupBox4.Controls.Add(Me.txt_cusname)
        Me.GroupBox4.Controls.Add(Me.txt_cuscus)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txt_black)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 113)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(267, 244)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ข้อมูลลูกค้า"
        '
        'txt_red
        '
        Me.txt_red.ForeColor = System.Drawing.Color.Red
        Me.txt_red.Location = New System.Drawing.Point(115, 170)
        Me.txt_red.Name = "txt_red"
        Me.txt_red.Size = New System.Drawing.Size(145, 22)
        Me.txt_red.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "เลขคดีดำ"
        '
        'lbl_cusacc
        '
        Me.lbl_cusacc.AutoSize = True
        Me.lbl_cusacc.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_cusacc.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cusacc.Location = New System.Drawing.Point(38, 56)
        Me.lbl_cusacc.Name = "lbl_cusacc"
        Me.lbl_cusacc.Size = New System.Drawing.Size(69, 18)
        Me.lbl_cusacc.TabIndex = 80
        Me.lbl_cusacc.Text = "เลขที่สัญญา"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 18)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "เบอร์ติดต่อลูกค้า"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "เลขคดีแดง"
        '
        'txt_cusacc
        '
        Me.txt_cusacc.Location = New System.Drawing.Point(115, 55)
        Me.txt_cusacc.Name = "txt_cusacc"
        Me.txt_cusacc.Size = New System.Drawing.Size(146, 22)
        Me.txt_cusacc.TabIndex = 81
        '
        'txt_cusphone
        '
        Me.txt_cusphone.Location = New System.Drawing.Point(115, 198)
        Me.txt_cusphone.Name = "txt_cusphone"
        Me.txt_cusphone.Size = New System.Drawing.Size(145, 22)
        Me.txt_cusphone.TabIndex = 89
        '
        'lbl_cuscus
        '
        Me.lbl_cuscus.AutoSize = True
        Me.lbl_cuscus.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_cuscus.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuscus.Location = New System.Drawing.Point(43, 84)
        Me.lbl_cuscus.Name = "lbl_cuscus"
        Me.lbl_cuscus.Size = New System.Drawing.Size(64, 18)
        Me.lbl_cuscus.TabIndex = 78
        Me.lbl_cuscus.Text = "เลขที่ลูกหนี้"
        '
        'txt_cusid
        '
        Me.txt_cusid.Location = New System.Drawing.Point(114, 27)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(146, 22)
        Me.txt_cusid.TabIndex = 64
        '
        'txt_cusname
        '
        Me.txt_cusname.Location = New System.Drawing.Point(115, 111)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(146, 22)
        Me.txt_cusname.TabIndex = 65
        '
        'txt_cuscus
        '
        Me.txt_cuscus.Location = New System.Drawing.Point(115, 83)
        Me.txt_cuscus.Name = "txt_cuscus"
        Me.txt_cuscus.Size = New System.Drawing.Size(146, 22)
        Me.txt_cuscus.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 18)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "เลขบัตรประชาชน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "ชื่อ-นามสกุล"
        '
        'txt_black
        '
        Me.txt_black.Location = New System.Drawing.Point(115, 139)
        Me.txt_black.Name = "txt_black"
        Me.txt_black.Size = New System.Drawing.Size(145, 22)
        Me.txt_black.TabIndex = 83
        '
        'txt_detail1
        '
        Me.txt_detail1.Location = New System.Drawing.Point(0, 0)
        Me.txt_detail1.Multiline = True
        Me.txt_detail1.Name = "txt_detail1"
        Me.txt_detail1.Size = New System.Drawing.Size(308, 111)
        Me.txt_detail1.TabIndex = 70
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 364)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(316, 140)
        Me.TabControl1.TabIndex = 92
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_detail1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(308, 111)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "รายละเอียด-ถอนอายัด/ยึด"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtgv_data
        '
        Me.dtgv_data.AllowUserToAddRows = False
        Me.dtgv_data.AllowUserToDeleteRows = False
        Me.dtgv_data.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dtgv_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_data.GridColor = System.Drawing.SystemColors.MenuText
        Me.dtgv_data.Location = New System.Drawing.Point(624, 113)
        Me.dtgv_data.Name = "dtgv_data"
        Me.dtgv_data.ReadOnly = True
        Me.dtgv_data.RowHeadersVisible = False
        Me.dtgv_data.Size = New System.Drawing.Size(372, 492)
        Me.dtgv_data.TabIndex = 95
        '
        'datetimestart
        '
        Me.datetimestart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimestart.Location = New System.Drawing.Point(712, 56)
        Me.datetimestart.Name = "datetimestart"
        Me.datetimestart.Size = New System.Drawing.Size(116, 22)
        Me.datetimestart.TabIndex = 98
        '
        'datetimefinish
        '
        Me.datetimefinish.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimefinish.Location = New System.Drawing.Point(712, 84)
        Me.datetimefinish.Name = "datetimefinish"
        Me.datetimefinish.Size = New System.Drawing.Size(116, 22)
        Me.datetimefinish.TabIndex = 97
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(654, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "จากวันที่"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(647, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 18)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "จนถึงวันที่"
        '
        'cbo_product
        '
        Me.cbo_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_product.FormattingEnabled = True
        Me.cbo_product.Location = New System.Drawing.Point(712, 24)
        Me.cbo_product.Name = "cbo_product"
        Me.cbo_product.Size = New System.Drawing.Size(116, 24)
        Me.cbo_product.TabIndex = 95
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(628, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "PRODUCT"
        '
        'cmd_datediff
        '
        Me.cmd_datediff.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_datediff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_datediff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_datediff.Image = Global.SCANDB.My.Resources.Resources.coins_delete
        Me.cmd_datediff.Location = New System.Drawing.Point(288, 557)
        Me.cmd_datediff.Name = "cmd_datediff"
        Me.cmd_datediff.Size = New System.Drawing.Size(194, 29)
        Me.cmd_datediff.TabIndex = 104
        Me.cmd_datediff.Text = "แสดงงานที่ยังไม่ได้ส่งเช็คเข้าแบงค์"
        Me.cmd_datediff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_datediff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_datediff.UseVisualStyleBackColor = False
        '
        'cmd_detele
        '
        Me.cmd_detele.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_detele.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_detele.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_detele.Image = Global.SCANDB.My.Resources.Resources.page_delete
        Me.cmd_detele.Location = New System.Drawing.Point(152, 557)
        Me.cmd_detele.Name = "cmd_detele"
        Me.cmd_detele.Size = New System.Drawing.Size(133, 29)
        Me.cmd_detele.TabIndex = 103
        Me.cmd_detele.Text = "ลบข้อมูล"
        Me.cmd_detele.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_detele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_detele.UseVisualStyleBackColor = False
        '
        'cmd_addnew
        '
        Me.cmd_addnew.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_addnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_addnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_addnew.Image = Global.SCANDB.My.Resources.Resources.page_add
        Me.cmd_addnew.Location = New System.Drawing.Point(12, 557)
        Me.cmd_addnew.Name = "cmd_addnew"
        Me.cmd_addnew.Size = New System.Drawing.Size(133, 29)
        Me.cmd_addnew.TabIndex = 102
        Me.cmd_addnew.Text = "เพิ่มข้อมูล"
        Me.cmd_addnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_addnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_addnew.UseVisualStyleBackColor = False
        '
        'cmd_searchdate
        '
        Me.cmd_searchdate.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_searchdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_searchdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_searchdate.Image = Global.SCANDB.My.Resources.Resources.calendar_empty
        Me.cmd_searchdate.Location = New System.Drawing.Point(847, 63)
        Me.cmd_searchdate.Name = "cmd_searchdate"
        Me.cmd_searchdate.Size = New System.Drawing.Size(116, 35)
        Me.cmd_searchdate.TabIndex = 101
        Me.cmd_searchdate.Text = "ค้นหาจากวันที่"
        Me.cmd_searchdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_searchdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_searchdate.UseVisualStyleBackColor = False
        '
        'cmd_search
        '
        Me.cmd_search.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_search.Image = Global.SCANDB.My.Resources.Resources.folder_find1
        Me.cmd_search.Location = New System.Drawing.Point(847, 24)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(116, 26)
        Me.cmd_search.TabIndex = 100
        Me.cmd_search.Text = "ค้นหาข้อมูล"
        Me.cmd_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_search.UseVisualStyleBackColor = False
        '
        'cmd_edit
        '
        Me.cmd_edit.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_edit.Image = Global.SCANDB.My.Resources.Resources.edit_icon16x16
        Me.cmd_edit.Location = New System.Drawing.Point(152, 522)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(133, 29)
        Me.cmd_edit.TabIndex = 94
        Me.cmd_edit.Text = "แก้ไข"
        Me.cmd_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_edit.UseVisualStyleBackColor = False
        '
        'cmd_find
        '
        Me.cmd_find.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_find.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_find.Image = Global.SCANDB.My.Resources.Resources.folder_explore
        Me.cmd_find.Location = New System.Drawing.Point(427, 522)
        Me.cmd_find.Name = "cmd_find"
        Me.cmd_find.Size = New System.Drawing.Size(133, 29)
        Me.cmd_find.TabIndex = 93
        Me.cmd_find.Text = "ค้นหาเลขที่สัญญา"
        Me.cmd_find.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_find.UseVisualStyleBackColor = False
        '
        'cmd_cancel
        '
        Me.cmd_cancel.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_cancel.Image = Global.SCANDB.My.Resources.Resources.refresh
        Me.cmd_cancel.Location = New System.Drawing.Point(288, 522)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(133, 29)
        Me.cmd_cancel.TabIndex = 75
        Me.cmd_cancel.Text = "ยกเลิก"
        Me.cmd_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'cmd_save
        '
        Me.cmd_save.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_save.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.cmd_save.Location = New System.Drawing.Point(13, 522)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(133, 29)
        Me.cmd_save.TabIndex = 74
        Me.cmd_save.Text = "บันทึกข้อมูล"
        Me.cmd_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_save.UseVisualStyleBackColor = False
        '
        'Txt_PK_Acc
        '
        Me.Txt_PK_Acc.Location = New System.Drawing.Point(1122, 676)
        Me.Txt_PK_Acc.Name = "Txt_PK_Acc"
        Me.Txt_PK_Acc.Size = New System.Drawing.Size(10, 22)
        Me.Txt_PK_Acc.TabIndex = 90
        Me.Txt_PK_Acc.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1099, 655)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 18)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "KEY"
        Me.Label2.Visible = False
        '
        'Txt_PK_Owner
        '
        Me.Txt_PK_Owner.Location = New System.Drawing.Point(1122, 704)
        Me.Txt_PK_Owner.Name = "Txt_PK_Owner"
        Me.Txt_PK_Owner.Size = New System.Drawing.Size(10, 22)
        Me.Txt_PK_Owner.TabIndex = 90
        Me.Txt_PK_Owner.Visible = False
        '
        'FrmWDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Txt_PK_Owner)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_PK_Acc)
        Me.Controls.Add(Me.cmd_datediff)
        Me.Controls.Add(Me.cmd_detele)
        Me.Controls.Add(Me.cmd_addnew)
        Me.Controls.Add(Me.cmd_searchdate)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.cbo_product)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.datetimestart)
        Me.Controls.Add(Me.datetimefinish)
        Me.Controls.Add(Me.dtgv_data)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_find)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmWDS"
        Me.Text = "ถอนอายัด/ยึดทรัพย์"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dtgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_cusacc As TextBox
    Friend WithEvents lbl_cusacc As Label
    Friend WithEvents txt_cuscus As TextBox
    Friend WithEvents lbl_cuscus As Label
    Friend WithEvents cbo_owner As ComboBox
    Friend WithEvents cmd_cancel As Button
    Friend WithEvents cmd_save As Button
    Friend WithEvents txt_refund As RichTextBox
    Friend WithEvents txt_detail1 As TextBox
    Friend WithEvents dtp_daterefund As DateTimePicker
    Friend WithEvents dtp_datecollector As DateTimePicker
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents txt_cusid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbo_hub As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chk_datecheck As CheckBox
    Friend WithEvents chk_datepayment As CheckBox
    Friend WithEvents chk_datewds As CheckBox
    Friend WithEvents chk_datecollector As CheckBox
    Friend WithEvents dtp_datewds As DateTimePicker
    Friend WithEvents dtp_payment As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_payment As RichTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_status As TextBox
    Friend WithEvents cbo_empexe As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbo_empadmin As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_red As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_cusphone As TextBox
    Friend WithEvents txt_black As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmd_find As Button
    Friend WithEvents cmd_edit As Button
    Friend WithEvents dtgv_data As DataGridView
    Friend WithEvents datetimestart As DateTimePicker
    Friend WithEvents datetimefinish As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_product As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmd_search As Button
    Friend WithEvents cmd_searchdate As Button
    Friend WithEvents cmd_checkview As Button
    Friend WithEvents cmd_addnew As Button
    Friend WithEvents cmd_detele As Button
    Friend WithEvents cmd_datediff As Button
    Friend WithEvents Txt_PK_Acc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_PK_Owner As TextBox
End Class
