<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsolvent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInsolvent))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_owner = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_company = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_court = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_red = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cusid = New System.Windows.Forms.TextBox()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_black = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_verify_insolvent = New System.Windows.Forms.CheckBox()
        Me.Chk_date_request = New System.Windows.Forms.CheckBox()
        Me.dtp_verify_insolvent = New System.Windows.Forms.DateTimePicker()
        Me.dtp_date_request = New System.Windows.Forms.DateTimePicker()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_number_insolvent = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_court_isolvent = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_date_send = New System.Windows.Forms.CheckBox()
        Me.dtp_date_send = New System.Windows.Forms.DateTimePicker()
        Me.txt_total_receipt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_receipt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmd_send = New System.Windows.Forms.Button()
        Me.cmd_edit = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.Group_detail = New System.Windows.Forms.GroupBox()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.lbl_datetoday = New System.Windows.Forms.Label()
        Me.lbl_timer = New System.Windows.Forms.Label()
        Me.dtgv_insolvent = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Group_detail.SuspendLayout()
        CType(Me.dtgv_insolvent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_owner)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 51)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(311, 70)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Owner"
        '
        'cbo_owner
        '
        Me.cbo_owner.FormattingEnabled = True
        Me.cbo_owner.Location = New System.Drawing.Point(119, 23)
        Me.cbo_owner.Name = "cbo_owner"
        Me.cbo_owner.Size = New System.Drawing.Size(184, 21)
        Me.cbo_owner.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 20)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "PRODUCT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(270, 37)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ข้อมูลลูกค้าล้มละลาย"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_company)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txt_court)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txt_red)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txt_cusid)
        Me.GroupBox4.Controls.Add(Me.txt_cusname)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txt_black)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 131)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Size = New System.Drawing.Size(311, 202)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ข้อมูลลูกค้า"
        '
        'txt_company
        '
        Me.txt_company.Location = New System.Drawing.Point(119, 64)
        Me.txt_company.Name = "txt_company"
        Me.txt_company.Size = New System.Drawing.Size(170, 20)
        Me.txt_company.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 20)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "บริษัท"
        '
        'txt_court
        '
        Me.txt_court.Location = New System.Drawing.Point(119, 168)
        Me.txt_court.Name = "txt_court"
        Me.txt_court.Size = New System.Drawing.Size(170, 20)
        Me.txt_court.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "ศาล"
        '
        'txt_red
        '
        Me.txt_red.ForeColor = System.Drawing.Color.Red
        Me.txt_red.Location = New System.Drawing.Point(119, 142)
        Me.txt_red.Name = "txt_red"
        Me.txt_red.Size = New System.Drawing.Size(170, 20)
        Me.txt_red.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "เลขคดีดำ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "เลขคดีแดง"
        '
        'txt_cusid
        '
        Me.txt_cusid.Location = New System.Drawing.Point(119, 36)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(170, 20)
        Me.txt_cusid.TabIndex = 64
        '
        'txt_cusname
        '
        Me.txt_cusname.Location = New System.Drawing.Point(119, 90)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(170, 20)
        Me.txt_cusname.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "เลขบัตรประชาชน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "ชื่อ-นามสกุล"
        '
        'txt_black
        '
        Me.txt_black.Location = New System.Drawing.Point(119, 116)
        Me.txt_black.Name = "txt_black"
        Me.txt_black.Size = New System.Drawing.Size(170, 20)
        Me.txt_black.TabIndex = 83
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_verify_insolvent)
        Me.GroupBox2.Controls.Add(Me.Chk_date_request)
        Me.GroupBox2.Controls.Add(Me.dtp_verify_insolvent)
        Me.GroupBox2.Controls.Add(Me.dtp_date_request)
        Me.GroupBox2.Controls.Add(Me.txt_description)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_number_insolvent)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_court_isolvent)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 131)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(335, 202)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ข้อมูลล้มละลาย"
        '
        'chk_verify_insolvent
        '
        Me.chk_verify_insolvent.AutoSize = True
        Me.chk_verify_insolvent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_verify_insolvent.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_verify_insolvent.ForeColor = System.Drawing.Color.Blue
        Me.chk_verify_insolvent.Location = New System.Drawing.Point(17, 140)
        Me.chk_verify_insolvent.Name = "chk_verify_insolvent"
        Me.chk_verify_insolvent.Size = New System.Drawing.Size(120, 22)
        Me.chk_verify_insolvent.TabIndex = 96
        Me.chk_verify_insolvent.Text = "นัดตรวจคำขอชำระ"
        Me.chk_verify_insolvent.UseVisualStyleBackColor = True
        '
        'Chk_date_request
        '
        Me.Chk_date_request.AutoSize = True
        Me.Chk_date_request.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Chk_date_request.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_date_request.ForeColor = System.Drawing.Color.Blue
        Me.Chk_date_request.Location = New System.Drawing.Point(5, 116)
        Me.Chk_date_request.Name = "Chk_date_request"
        Me.Chk_date_request.Size = New System.Drawing.Size(132, 22)
        Me.Chk_date_request.TabIndex = 95
        Me.Chk_date_request.Text = "วันที่คำขอนัดชำระหนี้"
        Me.Chk_date_request.UseVisualStyleBackColor = True
        '
        'dtp_verify_insolvent
        '
        Me.dtp_verify_insolvent.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_verify_insolvent.Location = New System.Drawing.Point(143, 142)
        Me.dtp_verify_insolvent.Name = "dtp_verify_insolvent"
        Me.dtp_verify_insolvent.Size = New System.Drawing.Size(116, 20)
        Me.dtp_verify_insolvent.TabIndex = 94
        '
        'dtp_date_request
        '
        Me.dtp_date_request.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_request.Location = New System.Drawing.Point(143, 116)
        Me.dtp_date_request.Name = "dtp_date_request"
        Me.dtp_date_request.Size = New System.Drawing.Size(116, 20)
        Me.dtp_date_request.TabIndex = 92
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(143, 88)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(170, 20)
        Me.txt_description.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(81, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "หมายเหตุ"
        '
        'txt_number_insolvent
        '
        Me.txt_number_insolvent.Location = New System.Drawing.Point(143, 62)
        Me.txt_number_insolvent.Name = "txt_number_insolvent"
        Me.txt_number_insolvent.Size = New System.Drawing.Size(170, 20)
        Me.txt_number_insolvent.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "เลขคดีล้มละลาย"
        '
        'txt_court_isolvent
        '
        Me.txt_court_isolvent.Location = New System.Drawing.Point(143, 36)
        Me.txt_court_isolvent.Name = "txt_court_isolvent"
        Me.txt_court_isolvent.Size = New System.Drawing.Size(170, 20)
        Me.txt_court_isolvent.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(62, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 20)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "ศาลล้มละลาย"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chk_date_send)
        Me.GroupBox3.Controls.Add(Me.dtp_date_send)
        Me.GroupBox3.Controls.Add(Me.txt_total_receipt)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_receipt)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_total)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 343)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Size = New System.Drawing.Size(311, 160)
        Me.GroupBox3.TabIndex = 97
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ข้อมูลล้มละลาย"
        '
        'chk_date_send
        '
        Me.chk_date_send.AutoSize = True
        Me.chk_date_send.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_date_send.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_date_send.ForeColor = System.Drawing.Color.Blue
        Me.chk_date_send.Location = New System.Drawing.Point(6, 113)
        Me.chk_date_send.Name = "chk_date_send"
        Me.chk_date_send.Size = New System.Drawing.Size(121, 22)
        Me.chk_date_send.TabIndex = 95
        Me.chk_date_send.Text = "เดือนที่ได้รับเอกสาร"
        Me.chk_date_send.UseVisualStyleBackColor = True
        '
        'dtp_date_send
        '
        Me.dtp_date_send.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_send.Location = New System.Drawing.Point(133, 113)
        Me.dtp_date_send.Name = "dtp_date_send"
        Me.dtp_date_send.Size = New System.Drawing.Size(116, 20)
        Me.dtp_date_send.TabIndex = 92
        '
        'txt_total_receipt
        '
        Me.txt_total_receipt.Location = New System.Drawing.Point(133, 87)
        Me.txt_total_receipt.Name = "txt_total_receipt"
        Me.txt_total_receipt.Size = New System.Drawing.Size(170, 20)
        Me.txt_total_receipt.TabIndex = 70
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(53, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 20)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "ใบเสร็จรับเงิน"
        '
        'txt_receipt
        '
        Me.txt_receipt.Location = New System.Drawing.Point(133, 61)
        Me.txt_receipt.Name = "txt_receipt"
        Me.txt_receipt.Size = New System.Drawing.Size(170, 20)
        Me.txt_receipt.TabIndex = 68
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 20)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "รายละเอียดใบเสร็จ"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(133, 35)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(170, 20)
        Me.txt_total.TabIndex = 64
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 20)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "จำนวนเงินขอชำระหนี้"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmd_send)
        Me.GroupBox5.Controls.Add(Me.cmd_edit)
        Me.GroupBox5.Controls.Add(Me.cmd_cancel)
        Me.GroupBox5.Controls.Add(Me.cmd_save)
        Me.GroupBox5.Location = New System.Drawing.Point(850, 131)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox5.Size = New System.Drawing.Size(145, 202)
        Me.GroupBox5.TabIndex = 98
        Me.GroupBox5.TabStop = False
        '
        'cmd_send
        '
        Me.cmd_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_send.Image = Global.SCANDB.My.Resources.Resources.add
        Me.cmd_send.Location = New System.Drawing.Point(7, 36)
        Me.cmd_send.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_send.Name = "cmd_send"
        Me.cmd_send.Size = New System.Drawing.Size(133, 29)
        Me.cmd_send.TabIndex = 3
        Me.cmd_send.Text = "เพิ่มข้อมูลลูกค้า"
        Me.cmd_send.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_send.UseVisualStyleBackColor = True
        '
        'cmd_edit
        '
        Me.cmd_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_edit.Image = Global.SCANDB.My.Resources.Resources.edit_icon16x16
        Me.cmd_edit.Location = New System.Drawing.Point(7, 72)
        Me.cmd_edit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(133, 29)
        Me.cmd_edit.TabIndex = 2
        Me.cmd_edit.Text = "แก้ไข"
        Me.cmd_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_edit.UseVisualStyleBackColor = True
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_cancel.Image = Global.SCANDB.My.Resources.Resources.edit_delete_icon16x16
        Me.cmd_cancel.Location = New System.Drawing.Point(7, 107)
        Me.cmd_cancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(133, 29)
        Me.cmd_cancel.TabIndex = 1
        Me.cmd_cancel.Text = "ยกเลิก"
        Me.cmd_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'cmd_save
        '
        Me.cmd_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_save.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.cmd_save.Location = New System.Drawing.Point(7, 142)
        Me.cmd_save.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(133, 29)
        Me.cmd_save.TabIndex = 0
        Me.cmd_save.Text = "บันทึก"
        Me.cmd_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'Group_detail
        '
        Me.Group_detail.BackColor = System.Drawing.SystemColors.Window
        Me.Group_detail.Controls.Add(Me.lbl_count)
        Me.Group_detail.Controls.Add(Me.lbl_datetoday)
        Me.Group_detail.Controls.Add(Me.lbl_timer)
        Me.Group_detail.Location = New System.Drawing.Point(850, 12)
        Me.Group_detail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Group_detail.Name = "Group_detail"
        Me.Group_detail.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Group_detail.Size = New System.Drawing.Size(145, 116)
        Me.Group_detail.TabIndex = 99
        Me.Group_detail.TabStop = False
        '
        'lbl_count
        '
        Me.lbl_count.BackColor = System.Drawing.SystemColors.InfoText
        Me.lbl_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_count.ForeColor = System.Drawing.Color.Orange
        Me.lbl_count.Location = New System.Drawing.Point(6, 72)
        Me.lbl_count.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(133, 27)
        Me.lbl_count.TabIndex = 9
        Me.lbl_count.Text = "ข้อมูลทั้งหมด"
        Me.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_datetoday
        '
        Me.lbl_datetoday.BackColor = System.Drawing.SystemColors.InfoText
        Me.lbl_datetoday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_datetoday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_datetoday.ForeColor = System.Drawing.Color.Lime
        Me.lbl_datetoday.Location = New System.Drawing.Point(7, 45)
        Me.lbl_datetoday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_datetoday.Name = "lbl_datetoday"
        Me.lbl_datetoday.Size = New System.Drawing.Size(133, 27)
        Me.lbl_datetoday.TabIndex = 1
        Me.lbl_datetoday.Text = "Date"
        Me.lbl_datetoday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_timer
        '
        Me.lbl_timer.BackColor = System.Drawing.SystemColors.InfoText
        Me.lbl_timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_timer.ForeColor = System.Drawing.Color.Lime
        Me.lbl_timer.Location = New System.Drawing.Point(7, 16)
        Me.lbl_timer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_timer.Name = "lbl_timer"
        Me.lbl_timer.Size = New System.Drawing.Size(133, 29)
        Me.lbl_timer.TabIndex = 0
        Me.lbl_timer.Text = "Time"
        Me.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtgv_insolvent
        '
        Me.dtgv_insolvent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgv_insolvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_insolvent.Location = New System.Drawing.Point(20, 567)
        Me.dtgv_insolvent.Name = "dtgv_insolvent"
        Me.dtgv_insolvent.Size = New System.Drawing.Size(656, 150)
        Me.dtgv_insolvent.TabIndex = 100
        Me.dtgv_insolvent.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.cbo_search)
        Me.GroupBox6.Controls.Add(Me.txt_search)
        Me.GroupBox6.Location = New System.Drawing.Point(20, 505)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox6.Size = New System.Drawing.Size(655, 54)
        Me.GroupBox6.TabIndex = 101
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ค้นหาข้อมูล"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 20)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "ประเภทข้อมูล"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(234, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 20)
        Me.Label16.TabIndex = 91
        Me.Label16.Text = "ข้อมูลที่ต้องการหา"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Image = Global.SCANDB.My.Resources.Resources.Find_16x16
        Me.Button1.Location = New System.Drawing.Point(514, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ค้นหาข้อมูล"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbo_search
        '
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Location = New System.Drawing.Point(92, 17)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(137, 21)
        Me.cbo_search.TabIndex = 92
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(337, 17)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(170, 22)
        Me.txt_search.TabIndex = 91
        '
        'FrmInsolvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.dtgv_insolvent)
        Me.Controls.Add(Me.Group_detail)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInsolvent"
        Me.Text = "คดีล้มละลาย"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.Group_detail.ResumeLayout(False)
        CType(Me.dtgv_insolvent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_owner As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_company As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_red As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cusid As TextBox
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_black As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_court_isolvent As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_court As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_number_insolvent As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_verify_insolvent As DateTimePicker
    Friend WithEvents dtp_date_request As DateTimePicker
    Friend WithEvents chk_verify_insolvent As CheckBox
    Friend WithEvents Chk_date_request As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chk_date_send As CheckBox
    Friend WithEvents dtp_date_send As DateTimePicker
    Friend WithEvents txt_total_receipt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_receipt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cmd_send As Button
    Friend WithEvents cmd_edit As Button
    Friend WithEvents cmd_cancel As Button
    Friend WithEvents cmd_save As Button
    Friend WithEvents Group_detail As GroupBox
    Friend WithEvents lbl_count As Label
    Friend WithEvents lbl_datetoday As Label
    Friend WithEvents lbl_timer As Label
    Friend WithEvents dtgv_insolvent As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cbo_search As ComboBox
    Friend WithEvents txt_search As TextBox
End Class
