<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPort))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_date_send = New System.Windows.Forms.CheckBox()
        Me.cbo_status = New System.Windows.Forms.ComboBox()
        Me.txt_oa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_datesend = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_owner = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_countacc = New System.Windows.Forms.TextBox()
        Me.cbo_acc = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cusid = New System.Windows.Forms.TextBox()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cuscus = New System.Windows.Forms.TextBox()
        Me.dtgv_exeport = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_find = New System.Windows.Forms.TextBox()
        Me.cbo_type_find = New System.Windows.Forms.ComboBox()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_type_result = New System.Windows.Forms.ComboBox()
        Me.txt_review_description = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtp_date_review = New System.Windows.Forms.DateTimePicker()
        Me.chk_review = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chk_date_soc = New System.Windows.Forms.CheckBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_office = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtp_date_soc = New System.Windows.Forms.DateTimePicker()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.cmd_edit = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_delete = New System.Windows.Forms.Button()
        Me.cmd_update = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtgv_exeport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(419, 44)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ข้อมูลส่งคัด ประกันสังคม ฟ้องเอง"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_date_send)
        Me.GroupBox2.Controls.Add(Me.cbo_status)
        Me.GroupBox2.Controls.Add(Me.txt_oa)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtp_datesend)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 321)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(311, 113)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ช้อมูลลูกค้า"
        '
        'chk_date_send
        '
        Me.chk_date_send.AutoSize = True
        Me.chk_date_send.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_date_send.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_date_send.Location = New System.Drawing.Point(28, 77)
        Me.chk_date_send.Name = "chk_date_send"
        Me.chk_date_send.Size = New System.Drawing.Size(75, 22)
        Me.chk_date_send.TabIndex = 106
        Me.chk_date_send.Text = "วันที่ส่งคัด"
        Me.chk_date_send.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_date_send.UseVisualStyleBackColor = True
        '
        'cbo_status
        '
        Me.cbo_status.ForeColor = System.Drawing.Color.Blue
        Me.cbo_status.FormattingEnabled = True
        Me.cbo_status.Location = New System.Drawing.Point(122, 47)
        Me.cbo_status.Name = "cbo_status"
        Me.cbo_status.Size = New System.Drawing.Size(167, 24)
        Me.cbo_status.TabIndex = 10
        '
        'txt_oa
        '
        Me.txt_oa.ForeColor = System.Drawing.Color.Blue
        Me.txt_oa.Location = New System.Drawing.Point(122, 19)
        Me.txt_oa.Name = "txt_oa"
        Me.txt_oa.Size = New System.Drawing.Size(167, 22)
        Me.txt_oa.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 18)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "OA"
        '
        'dtp_datesend
        '
        Me.dtp_datesend.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datesend.Location = New System.Drawing.Point(122, 77)
        Me.dtp_datesend.Name = "dtp_datesend"
        Me.dtp_datesend.Size = New System.Drawing.Size(116, 22)
        Me.dtp_datesend.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 18)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "STATUS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_owner)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(311, 62)
        Me.GroupBox1.TabIndex = 91
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Owner"
        '
        'cbo_owner
        '
        Me.cbo_owner.ForeColor = System.Drawing.Color.Blue
        Me.cbo_owner.FormattingEnabled = True
        Me.cbo_owner.Location = New System.Drawing.Point(105, 23)
        Me.cbo_owner.Name = "cbo_owner"
        Me.cbo_owner.Size = New System.Drawing.Size(184, 24)
        Me.cbo_owner.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 18)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "PRODUCT"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_countacc)
        Me.GroupBox4.Controls.Add(Me.cbo_acc)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txt_cusid)
        Me.GroupBox4.Controls.Add(Me.txt_cusname)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txt_cuscus)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 130)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Size = New System.Drawing.Size(311, 181)
        Me.GroupBox4.TabIndex = 92
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ข้อมูลลูกค้า"
        '
        'txt_countacc
        '
        Me.txt_countacc.ForeColor = System.Drawing.Color.Blue
        Me.txt_countacc.Location = New System.Drawing.Point(283, 86)
        Me.txt_countacc.Name = "txt_countacc"
        Me.txt_countacc.Size = New System.Drawing.Size(25, 22)
        Me.txt_countacc.TabIndex = 84
        '
        'cbo_acc
        '
        Me.cbo_acc.ForeColor = System.Drawing.Color.Blue
        Me.cbo_acc.FormattingEnabled = True
        Me.cbo_acc.Location = New System.Drawing.Point(112, 85)
        Me.cbo_acc.Name = "cbo_acc"
        Me.cbo_acc.Size = New System.Drawing.Size(170, 24)
        Me.cbo_acc.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 18)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "เลขที่ลูกหนี้"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "เลขที่สัญญา"
        '
        'txt_cusid
        '
        Me.txt_cusid.ForeColor = System.Drawing.Color.Red
        Me.txt_cusid.Location = New System.Drawing.Point(112, 27)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(170, 22)
        Me.txt_cusid.TabIndex = 5
        '
        'txt_cusname
        '
        Me.txt_cusname.ForeColor = System.Drawing.Color.Blue
        Me.txt_cusname.Location = New System.Drawing.Point(112, 114)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(170, 22)
        Me.txt_cusname.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 29)
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
        Me.Label3.Location = New System.Drawing.Point(31, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "ชื่อ-นามสกุล"
        '
        'txt_cuscus
        '
        Me.txt_cuscus.ForeColor = System.Drawing.Color.Blue
        Me.txt_cuscus.Location = New System.Drawing.Point(112, 57)
        Me.txt_cuscus.Name = "txt_cuscus"
        Me.txt_cuscus.Size = New System.Drawing.Size(170, 22)
        Me.txt_cuscus.TabIndex = 6
        '
        'dtgv_exeport
        '
        Me.dtgv_exeport.AllowUserToAddRows = False
        Me.dtgv_exeport.AllowUserToDeleteRows = False
        Me.dtgv_exeport.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dtgv_exeport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_exeport.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgv_exeport.Location = New System.Drawing.Point(14, 511)
        Me.dtgv_exeport.Name = "dtgv_exeport"
        Me.dtgv_exeport.ReadOnly = True
        Me.dtgv_exeport.Size = New System.Drawing.Size(982, 159)
        Me.dtgv_exeport.TabIndex = 93
        Me.dtgv_exeport.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_find)
        Me.GroupBox3.Controls.Add(Me.cbo_type_find)
        Me.GroupBox3.Controls.Add(Me.cmd_search)
        Me.GroupBox3.Location = New System.Drawing.Point(328, 58)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox3.Size = New System.Drawing.Size(666, 62)
        Me.GroupBox3.TabIndex = 92
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ค้นหาข้อมูล"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 18)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "ประเภทข้อมูล"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(245, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 18)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "ข้อมูลที่ต้องการหา"
        '
        'txt_find
        '
        Me.txt_find.ForeColor = System.Drawing.Color.DarkOrange
        Me.txt_find.Location = New System.Drawing.Point(350, 23)
        Me.txt_find.Name = "txt_find"
        Me.txt_find.Size = New System.Drawing.Size(170, 22)
        Me.txt_find.TabIndex = 2
        '
        'cbo_type_find
        '
        Me.cbo_type_find.ForeColor = System.Drawing.Color.Blue
        Me.cbo_type_find.FormattingEnabled = True
        Me.cbo_type_find.Location = New System.Drawing.Point(92, 23)
        Me.cbo_type_find.Name = "cbo_type_find"
        Me.cbo_type_find.Size = New System.Drawing.Size(147, 24)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "ผล อนุมัติ/ไม่อนุมัติ"
        '
        'cbo_type_result
        '
        Me.cbo_type_result.ForeColor = System.Drawing.Color.Blue
        Me.cbo_type_result.FormattingEnabled = True
        Me.cbo_type_result.Location = New System.Drawing.Point(142, 27)
        Me.cbo_type_result.Name = "cbo_type_result"
        Me.cbo_type_result.Size = New System.Drawing.Size(170, 24)
        Me.cbo_type_result.TabIndex = 12
        '
        'txt_review_description
        '
        Me.txt_review_description.ForeColor = System.Drawing.Color.Blue
        Me.txt_review_description.Location = New System.Drawing.Point(142, 57)
        Me.txt_review_description.Name = "txt_review_description"
        Me.txt_review_description.Size = New System.Drawing.Size(170, 22)
        Me.txt_review_description.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(44, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 18)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "เหตุผลที่ไม่อนุมัติ"
        '
        'txt_user
        '
        Me.txt_user.ForeColor = System.Drawing.Color.Blue
        Me.txt_user.Location = New System.Drawing.Point(142, 85)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(170, 22)
        Me.txt_user.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(90, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 18)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "USER"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbo_type_result)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txt_user)
        Me.GroupBox5.Controls.Add(Me.dtp_date_review)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.chk_review)
        Me.GroupBox5.Controls.Add(Me.txt_review_description)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(328, 130)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(666, 181)
        Me.GroupBox5.TabIndex = 105
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "COLLECTOR REVIEW"
        '
        'dtp_date_review
        '
        Me.dtp_date_review.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_review.Location = New System.Drawing.Point(142, 113)
        Me.dtp_date_review.Name = "dtp_date_review"
        Me.dtp_date_review.Size = New System.Drawing.Size(116, 22)
        Me.dtp_date_review.TabIndex = 16
        '
        'chk_review
        '
        Me.chk_review.AutoSize = True
        Me.chk_review.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_review.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_review.Location = New System.Drawing.Point(58, 113)
        Me.chk_review.Name = "chk_review"
        Me.chk_review.Size = New System.Drawing.Size(78, 22)
        Me.chk_review.TabIndex = 98
        Me.chk_review.Text = "วันที่อนุมัติ"
        Me.chk_review.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chk_date_soc)
        Me.GroupBox6.Controls.Add(Me.txt_address)
        Me.GroupBox6.Controls.Add(Me.txt_office)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.dtp_date_soc)
        Me.GroupBox6.Location = New System.Drawing.Point(328, 321)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(666, 113)
        Me.GroupBox6.TabIndex = 106
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ผลการคัดประกันสังคม"
        '
        'chk_date_soc
        '
        Me.chk_date_soc.AutoSize = True
        Me.chk_date_soc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_date_soc.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_date_soc.Location = New System.Drawing.Point(21, 75)
        Me.chk_date_soc.Name = "chk_date_soc"
        Me.chk_date_soc.Size = New System.Drawing.Size(105, 22)
        Me.chk_date_soc.TabIndex = 105
        Me.chk_date_soc.Text = "วันที่รับผล ปกส."
        Me.chk_date_soc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_date_soc.UseVisualStyleBackColor = True
        '
        'txt_address
        '
        Me.txt_address.ForeColor = System.Drawing.Color.Blue
        Me.txt_address.Location = New System.Drawing.Point(88, 47)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(426, 22)
        Me.txt_address.TabIndex = 95
        '
        'txt_office
        '
        Me.txt_office.ForeColor = System.Drawing.Color.Red
        Me.txt_office.Location = New System.Drawing.Point(88, 21)
        Me.txt_office.Name = "txt_office"
        Me.txt_office.Size = New System.Drawing.Size(426, 22)
        Me.txt_office.TabIndex = 94
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Window
        Me.Label19.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(21, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 18)
        Me.Label19.TabIndex = 89
        Me.Label19.Text = "Address"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Window
        Me.Label17.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 18)
        Me.Label17.TabIndex = 93
        Me.Label17.Text = "OFFICE"
        '
        'dtp_date_soc
        '
        Me.dtp_date_soc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_soc.Location = New System.Drawing.Point(132, 75)
        Me.dtp_date_soc.Name = "dtp_date_soc"
        Me.dtp_date_soc.Size = New System.Drawing.Size(116, 22)
        Me.dtp_date_soc.TabIndex = 92
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_search.Location = New System.Drawing.Point(31, 457)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(136, 32)
        Me.lbl_search.TabIndex = 107
        Me.lbl_search.Text = "ผลการค้นหา..."
        '
        'cmd_edit
        '
        Me.cmd_edit.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_edit.Image = Global.SCANDB.My.Resources.Resources.edit_icon16x16
        Me.cmd_edit.Location = New System.Drawing.Point(579, 460)
        Me.cmd_edit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(133, 29)
        Me.cmd_edit.TabIndex = 110
        Me.cmd_edit.Text = "แก้ไขข้อมูล"
        Me.cmd_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_edit.UseVisualStyleBackColor = False
        '
        'cmd_cancel
        '
        Me.cmd_cancel.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_cancel.Image = Global.SCANDB.My.Resources.Resources.arrow_redo
        Me.cmd_cancel.Location = New System.Drawing.Point(720, 460)
        Me.cmd_cancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(133, 29)
        Me.cmd_cancel.TabIndex = 109
        Me.cmd_cancel.Text = "ยกเลิก"
        Me.cmd_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'cmd_delete
        '
        Me.cmd_delete.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_delete.Image = Global.SCANDB.My.Resources.Resources.delete1
        Me.cmd_delete.Location = New System.Drawing.Point(861, 460)
        Me.cmd_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(133, 29)
        Me.cmd_delete.TabIndex = 108
        Me.cmd_delete.Text = "ลบข้อมูล"
        Me.cmd_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_delete.UseVisualStyleBackColor = False
        '
        'cmd_update
        '
        Me.cmd_update.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_update.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.cmd_update.Location = New System.Drawing.Point(438, 460)
        Me.cmd_update.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(133, 29)
        Me.cmd_update.TabIndex = 97
        Me.cmd_update.Text = "บันทึกข้อมูล"
        Me.cmd_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_update.UseVisualStyleBackColor = False
        '
        'FrmPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1004, 725)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_delete)
        Me.Controls.Add(Me.cmd_update)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtgv_exeport)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPort"
        Me.Text = "ส่งคัดประกันสังคมฟ้องเอง"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dtgv_exeport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtp_datesend As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_owner As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cusid As TextBox
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cuscus As TextBox
    Friend WithEvents txt_countacc As TextBox
    Friend WithEvents cbo_acc As ComboBox
    Friend WithEvents dtgv_exeport As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_oa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_status As ComboBox
    Friend WithEvents txt_find As TextBox
    Friend WithEvents cbo_type_find As ComboBox
    Friend WithEvents cmd_search As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_type_result As ComboBox
    Friend WithEvents txt_review_description As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txt_office As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dtp_date_soc As DateTimePicker
    Friend WithEvents chk_date_send As CheckBox
    Friend WithEvents chk_date_soc As CheckBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents lbl_search As Label
    Friend WithEvents cmd_update As Button
    Friend WithEvents cmd_delete As Button
    Friend WithEvents cmd_cancel As Button
    Friend WithEvents cmd_edit As Button
    Friend WithEvents dtp_date_review As DateTimePicker
    Friend WithEvents chk_review As CheckBox
End Class
