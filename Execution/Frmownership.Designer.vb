<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmownership
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmownership))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chk_date_work = New System.Windows.Forms.CheckBox()
        Me.dtp_datework = New System.Windows.Forms.DateTimePicker()
        Me.txt_cusid = New System.Windows.Forms.TextBox()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_owner = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_find = New System.Windows.Forms.TextBox()
        Me.cbo_type_find = New System.Windows.Forms.ComboBox()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_date_review = New System.Windows.Forms.CheckBox()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.dtp_date_review = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_Land_office = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_district = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_deed = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtgv_search = New System.Windows.Forms.DataGridView()
        Me.lbl_count_find = New System.Windows.Forms.Label()
        Me.cbo_surveypage = New System.Windows.Forms.ComboBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dtgv_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chk_date_work)
        Me.GroupBox4.Controls.Add(Me.dtp_datework)
        Me.GroupBox4.Controls.Add(Me.txt_cusid)
        Me.GroupBox4.Controls.Add(Me.txt_cusname)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 152)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Size = New System.Drawing.Size(311, 119)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ข้อมูลลูกค้า"
        '
        'chk_date_work
        '
        Me.chk_date_work.AutoSize = True
        Me.chk_date_work.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_date_work.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_date_work.Location = New System.Drawing.Point(41, 74)
        Me.chk_date_work.Name = "chk_date_work"
        Me.chk_date_work.Size = New System.Drawing.Size(75, 22)
        Me.chk_date_work.TabIndex = 95
        Me.chk_date_work.Text = "วันที่ส่งคัด"
        Me.chk_date_work.ThreeState = True
        Me.chk_date_work.UseVisualStyleBackColor = True
        '
        'dtp_datework
        '
        Me.dtp_datework.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datework.Location = New System.Drawing.Point(119, 74)
        Me.dtp_datework.Name = "dtp_datework"
        Me.dtp_datework.Size = New System.Drawing.Size(85, 20)
        Me.dtp_datework.TabIndex = 90
        '
        'txt_cusid
        '
        Me.txt_cusid.ForeColor = System.Drawing.Color.Red
        Me.txt_cusid.Location = New System.Drawing.Point(119, 22)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(178, 20)
        Me.txt_cusid.TabIndex = 64
        '
        'txt_cusname
        '
        Me.txt_cusname.ForeColor = System.Drawing.Color.Blue
        Me.txt_cusname.Location = New System.Drawing.Point(119, 48)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(178, 20)
        Me.txt_cusname.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 22)
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
        Me.Label3.Location = New System.Drawing.Point(41, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "ชื่อ-นามสกุล"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_owner)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 75)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(311, 62)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Owner"
        '
        'cbo_owner
        '
        Me.cbo_owner.ForeColor = System.Drawing.Color.Blue
        Me.cbo_owner.FormattingEnabled = True
        Me.cbo_owner.Location = New System.Drawing.Point(119, 23)
        Me.cbo_owner.Name = "cbo_owner"
        Me.cbo_owner.Size = New System.Drawing.Size(178, 21)
        Me.cbo_owner.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 20)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "PRODUCT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 37)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "ข้อมูลสืบกรรมสิทธิ์"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_find)
        Me.GroupBox3.Controls.Add(Me.cbo_type_find)
        Me.GroupBox3.Controls.Add(Me.cmd_search)
        Me.GroupBox3.Location = New System.Drawing.Point(335, 75)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Size = New System.Drawing.Size(666, 62)
        Me.GroupBox3.TabIndex = 93
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหาข้อมูล"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 20)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "ประเภทข้อมูล"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(245, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 20)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "ข้อมูลที่ต้องการหา"
        '
        'txt_find
        '
        Me.txt_find.ForeColor = System.Drawing.Color.DarkOrange
        Me.txt_find.Location = New System.Drawing.Point(350, 23)
        Me.txt_find.Name = "txt_find"
        Me.txt_find.Size = New System.Drawing.Size(170, 20)
        Me.txt_find.TabIndex = 2
        '
        'cbo_type_find
        '
        Me.cbo_type_find.ForeColor = System.Drawing.Color.Blue
        Me.cbo_type_find.FormattingEnabled = True
        Me.cbo_type_find.Location = New System.Drawing.Point(92, 23)
        Me.cbo_type_find.Name = "cbo_type_find"
        Me.cbo_type_find.Size = New System.Drawing.Size(147, 21)
        Me.cbo_type_find.TabIndex = 1
        '
        'cmd_search
        '
        Me.cmd_search.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_search.Image = Global.SCANDB.My.Resources.Resources.Find_16x16
        Me.cmd_search.Location = New System.Drawing.Point(527, 20)
        Me.cmd_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(133, 29)
        Me.cmd_search.TabIndex = 3
        Me.cmd_search.Text = "ค้นหาข้อมูล"
        Me.cmd_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_search.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_date_review)
        Me.GroupBox2.Controls.Add(Me.txt_result)
        Me.GroupBox2.Controls.Add(Me.dtp_date_review)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(335, 152)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(311, 119)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ผลตรวจกรรมสิทธิ์"
        '
        'chk_date_review
        '
        Me.chk_date_review.AutoSize = True
        Me.chk_date_review.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_date_review.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_date_review.Location = New System.Drawing.Point(11, 48)
        Me.chk_date_review.Name = "chk_date_review"
        Me.chk_date_review.Size = New System.Drawing.Size(115, 22)
        Me.chk_date_review.TabIndex = 97
        Me.chk_date_review.Text = "วันที่ได้รับผลตรวจ"
        Me.chk_date_review.ThreeState = True
        Me.chk_date_review.UseVisualStyleBackColor = True
        '
        'txt_result
        '
        Me.txt_result.ForeColor = System.Drawing.Color.Red
        Me.txt_result.Location = New System.Drawing.Point(132, 22)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(85, 20)
        Me.txt_result.TabIndex = 64
        '
        'dtp_date_review
        '
        Me.dtp_date_review.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_review.Location = New System.Drawing.Point(132, 48)
        Me.dtp_date_review.Name = "dtp_date_review"
        Me.dtp_date_review.Size = New System.Drawing.Size(85, 20)
        Me.dtp_date_review.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "ผลการตรวจกรรมสิทธิ์"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbo_surveypage)
        Me.GroupBox5.Controls.Add(Me.txt_address)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.cbo_Land_office)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txt_location)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txt_district)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.cbo_deed)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 281)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Size = New System.Drawing.Size(632, 209)
        Me.GroupBox5.TabIndex = 96
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "รายละเอียดกรรมสิทธิ์"
        '
        'txt_address
        '
        Me.txt_address.ForeColor = System.Drawing.Color.Blue
        Me.txt_address.Location = New System.Drawing.Point(119, 162)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(328, 20)
        Me.txt_address.TabIndex = 108
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(81, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 20)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "ที่อยู่"
        '
        'cbo_Land_office
        '
        Me.cbo_Land_office.ForeColor = System.Drawing.Color.Red
        Me.cbo_Land_office.FormattingEnabled = True
        Me.cbo_Land_office.Location = New System.Drawing.Point(119, 135)
        Me.cbo_Land_office.Name = "cbo_Land_office"
        Me.cbo_Land_office.Size = New System.Drawing.Size(328, 21)
        Me.cbo_Land_office.TabIndex = 106
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "สำนักงานที่ดิน"
        '
        'txt_location
        '
        Me.txt_location.ForeColor = System.Drawing.Color.Blue
        Me.txt_location.Location = New System.Drawing.Point(119, 109)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(178, 20)
        Me.txt_location.TabIndex = 102
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "สถานที่"
        '
        'txt_district
        '
        Me.txt_district.ForeColor = System.Drawing.Color.Blue
        Me.txt_district.Location = New System.Drawing.Point(119, 83)
        Me.txt_district.Name = "txt_district"
        Me.txt_district.Size = New System.Drawing.Size(178, 20)
        Me.txt_district.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "ตำบล/อำเภอ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "หน้าสำรวจ"
        '
        'cbo_deed
        '
        Me.cbo_deed.ForeColor = System.Drawing.Color.Blue
        Me.cbo_deed.FormattingEnabled = True
        Me.cbo_deed.Location = New System.Drawing.Point(119, 30)
        Me.cbo_deed.Name = "cbo_deed"
        Me.cbo_deed.Size = New System.Drawing.Size(178, 21)
        Me.cbo_deed.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "เลขโฉนด"
        '
        'dtgv_search
        '
        Me.dtgv_search.AllowUserToAddRows = False
        Me.dtgv_search.AllowUserToDeleteRows = False
        Me.dtgv_search.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dtgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_search.GridColor = System.Drawing.Color.Black
        Me.dtgv_search.Location = New System.Drawing.Point(14, 554)
        Me.dtgv_search.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.dtgv_search.Name = "dtgv_search"
        Me.dtgv_search.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_search.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv_search.RowHeadersVisible = False
        Me.dtgv_search.Size = New System.Drawing.Size(980, 142)
        Me.dtgv_search.TabIndex = 97
        '
        'lbl_count_find
        '
        Me.lbl_count_find.AutoSize = True
        Me.lbl_count_find.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_count_find.Location = New System.Drawing.Point(12, 519)
        Me.lbl_count_find.Name = "lbl_count_find"
        Me.lbl_count_find.Size = New System.Drawing.Size(136, 32)
        Me.lbl_count_find.TabIndex = 142
        Me.lbl_count_find.Text = "ผลการค้นหา..."
        '
        'cbo_surveypage
        '
        Me.cbo_surveypage.ForeColor = System.Drawing.Color.Blue
        Me.cbo_surveypage.FormattingEnabled = True
        Me.cbo_surveypage.Location = New System.Drawing.Point(119, 57)
        Me.cbo_surveypage.Name = "cbo_surveypage"
        Me.cbo_surveypage.Size = New System.Drawing.Size(178, 21)
        Me.cbo_surveypage.TabIndex = 109
        '
        'Frmownership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.lbl_count_find)
        Me.Controls.Add(Me.dtgv_search)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmownership"
        Me.Text = "Frmownership"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dtgv_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chk_date_work As CheckBox
    Friend WithEvents dtp_datework As DateTimePicker
    Friend WithEvents txt_cusid As TextBox
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_owner As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_find As TextBox
    Friend WithEvents cbo_type_find As ComboBox
    Friend WithEvents cmd_search As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk_date_review As CheckBox
    Friend WithEvents txt_result As TextBox
    Friend WithEvents dtp_date_review As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbo_deed As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_Land_office As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_location As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_district As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtgv_search As DataGridView
    Friend WithEvents lbl_count_find As Label
    Friend WithEvents cbo_surveypage As ComboBox
End Class
