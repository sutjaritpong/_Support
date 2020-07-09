<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmmanageIP
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmmanageIP))
        Me.dtgvip = New System.Windows.Forms.DataGridView()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_find = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txt_ip = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.txt_product = New System.Windows.Forms.TextBox()
        Me.txt_floor = New System.Windows.Forms.TextBox()
        Me.txt_server = New System.Windows.Forms.TextBox()
        Me.txt_domain = New System.Windows.Forms.TextBox()
        Me.IP = New System.Windows.Forms.Label()
        Me.label99 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_detail = New System.Windows.Forms.TextBox()
        Me.cbo_filter = New System.Windows.Forms.ComboBox()
        Me.chk_filter = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_migrate_ip = New System.Windows.Forms.TextBox()
        Me.dtp_edit = New System.Windows.Forms.DateTimePicker()
        Me.cmd_migrate_ip = New System.Windows.Forms.Button()
        Me.cmd_delete = New System.Windows.Forms.Button()
        Me.cmd_edit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.cmd_refresh = New System.Windows.Forms.Button()
        Me.cmd_search = New System.Windows.Forms.Button()
        CType(Me.dtgvip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvip
        '
        Me.dtgvip.AllowUserToAddRows = False
        Me.dtgvip.AllowUserToDeleteRows = False
        Me.dtgvip.BackgroundColor = System.Drawing.Color.Black
        Me.dtgvip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgvip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvip.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvip.GridColor = System.Drawing.Color.Red
        Me.dtgvip.Location = New System.Drawing.Point(15, 43)
        Me.dtgvip.Name = "dtgvip"
        Me.dtgvip.ReadOnly = True
        Me.dtgvip.RowHeadersVisible = False
        Me.dtgvip.Size = New System.Drawing.Size(812, 763)
        Me.dtgvip.TabIndex = 0
        '
        'cbo_type
        '
        Me.cbo_type.BackColor = System.Drawing.Color.Black
        Me.cbo_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_type.ForeColor = System.Drawing.Color.White
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Location = New System.Drawing.Point(87, 11)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(178, 24)
        Me.cbo_type.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ค้นหาจาก :"
        '
        'txt_find
        '
        Me.txt_find.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_find.ForeColor = System.Drawing.Color.White
        Me.txt_find.Location = New System.Drawing.Point(760, 11)
        Me.txt_find.Name = "txt_find"
        Me.txt_find.Size = New System.Drawing.Size(184, 22)
        Me.txt_find.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(620, 13)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(134, 18)
        Me.label2.TabIndex = 4
        Me.label2.Text = "กรอกข้อมูลที่จะค้นหา :"
        '
        'txt_ip
        '
        Me.txt_ip.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_ip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_ip.ForeColor = System.Drawing.Color.Red
        Me.txt_ip.Location = New System.Drawing.Point(15, 40)
        Me.txt_ip.Name = "txt_ip"
        Me.txt_ip.ReadOnly = True
        Me.txt_ip.Size = New System.Drawing.Size(170, 22)
        Me.txt_ip.TabIndex = 5
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.Lime
        Me.txt_name.Location = New System.Drawing.Point(15, 84)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(170, 22)
        Me.txt_name.TabIndex = 6
        '
        'txt_fullname
        '
        Me.txt_fullname.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_fullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_fullname.ForeColor = System.Drawing.Color.Lime
        Me.txt_fullname.Location = New System.Drawing.Point(15, 128)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(170, 22)
        Me.txt_fullname.TabIndex = 7
        '
        'txt_position
        '
        Me.txt_position.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_position.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_position.ForeColor = System.Drawing.Color.Lime
        Me.txt_position.Location = New System.Drawing.Point(15, 172)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(170, 22)
        Me.txt_position.TabIndex = 8
        '
        'txt_product
        '
        Me.txt_product.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_product.ForeColor = System.Drawing.Color.Lime
        Me.txt_product.Location = New System.Drawing.Point(15, 216)
        Me.txt_product.Name = "txt_product"
        Me.txt_product.Size = New System.Drawing.Size(170, 22)
        Me.txt_product.TabIndex = 9
        '
        'txt_floor
        '
        Me.txt_floor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_floor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_floor.ForeColor = System.Drawing.Color.Lime
        Me.txt_floor.Location = New System.Drawing.Point(15, 260)
        Me.txt_floor.Name = "txt_floor"
        Me.txt_floor.Size = New System.Drawing.Size(170, 22)
        Me.txt_floor.TabIndex = 10
        '
        'txt_server
        '
        Me.txt_server.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_server.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_server.ForeColor = System.Drawing.Color.Lime
        Me.txt_server.Location = New System.Drawing.Point(15, 304)
        Me.txt_server.Name = "txt_server"
        Me.txt_server.Size = New System.Drawing.Size(170, 22)
        Me.txt_server.TabIndex = 11
        '
        'txt_domain
        '
        Me.txt_domain.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_domain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_domain.ForeColor = System.Drawing.Color.Lime
        Me.txt_domain.Location = New System.Drawing.Point(17, 348)
        Me.txt_domain.Name = "txt_domain"
        Me.txt_domain.Size = New System.Drawing.Size(168, 22)
        Me.txt_domain.TabIndex = 12
        '
        'IP
        '
        Me.IP.AutoSize = True
        Me.IP.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.IP.ForeColor = System.Drawing.Color.White
        Me.IP.Location = New System.Drawing.Point(12, 21)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(74, 16)
        Me.IP.TabIndex = 16
        Me.IP.Text = "IP Address"
        '
        'label99
        '
        Me.label99.AutoSize = True
        Me.label99.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.label99.ForeColor = System.Drawing.Color.White
        Me.label99.Location = New System.Drawing.Point(14, 65)
        Me.label99.Name = "label99"
        Me.label99.Size = New System.Drawing.Size(77, 16)
        Me.label99.TabIndex = 17
        Me.label99.Text = "NICKNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "FULLNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "POSITION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "PRODUCT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "FLOOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "SERVER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "DOMAIN"
        '
        'txt_detail
        '
        Me.txt_detail.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txt_detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_detail.ForeColor = System.Drawing.Color.Red
        Me.txt_detail.Location = New System.Drawing.Point(15, 21)
        Me.txt_detail.Multiline = True
        Me.txt_detail.Name = "txt_detail"
        Me.txt_detail.Size = New System.Drawing.Size(227, 88)
        Me.txt_detail.TabIndex = 24
        '
        'cbo_filter
        '
        Me.cbo_filter.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cbo_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_filter.ForeColor = System.Drawing.Color.White
        Me.cbo_filter.FormattingEnabled = True
        Me.cbo_filter.Location = New System.Drawing.Point(371, 11)
        Me.cbo_filter.Name = "cbo_filter"
        Me.cbo_filter.Size = New System.Drawing.Size(193, 24)
        Me.cbo_filter.TabIndex = 29
        '
        'chk_filter
        '
        Me.chk_filter.AutoSize = True
        Me.chk_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_filter.ForeColor = System.Drawing.Color.White
        Me.chk_filter.Location = New System.Drawing.Point(282, 11)
        Me.chk_filter.Name = "chk_filter"
        Me.chk_filter.Size = New System.Drawing.Size(79, 22)
        Me.chk_filter.TabIndex = 32
        Me.chk_filter.Text = "ตัวกรอง :"
        Me.chk_filter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.IP)
        Me.GroupBox1.Controls.Add(Me.txt_ip)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_fullname)
        Me.GroupBox1.Controls.Add(Me.txt_position)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txt_product)
        Me.GroupBox1.Controls.Add(Me.txt_floor)
        Me.GroupBox1.Controls.Add(Me.txt_server)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_domain)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.label99)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(836, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 409)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail (รายละเอียด)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_migrate_ip)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_migrate_ip)
        Me.GroupBox2.Controls.Add(Me.dtp_edit)
        Me.GroupBox2.Controls.Add(Me.txt_detail)
        Me.GroupBox2.Controls.Add(Me.cmd_delete)
        Me.GroupBox2.Controls.Add(Me.cmd_edit)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(836, 454)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 352)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Description (คำบรรยาย)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(15, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Migrate IP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(14, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "วันที่แก้ไขข้อมูล"
        '
        'txt_migrate_ip
        '
        Me.txt_migrate_ip.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_migrate_ip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_migrate_ip.ForeColor = System.Drawing.Color.Lime
        Me.txt_migrate_ip.Location = New System.Drawing.Point(17, 202)
        Me.txt_migrate_ip.Name = "txt_migrate_ip"
        Me.txt_migrate_ip.Size = New System.Drawing.Size(168, 22)
        Me.txt_migrate_ip.TabIndex = 28
        '
        'dtp_edit
        '
        Me.dtp_edit.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDark
        Me.dtp_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_edit.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_edit.Location = New System.Drawing.Point(99, 113)
        Me.dtp_edit.Name = "dtp_edit"
        Me.dtp_edit.Size = New System.Drawing.Size(103, 22)
        Me.dtp_edit.TabIndex = 35
        '
        'cmd_migrate_ip
        '
        Me.cmd_migrate_ip.AutoSize = True
        Me.cmd_migrate_ip.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cmd_migrate_ip.ForeColor = System.Drawing.Color.White
        Me.cmd_migrate_ip.Image = Global.SCANDB.My.Resources.Resources.arrow_switch
        Me.cmd_migrate_ip.Location = New System.Drawing.Point(191, 198)
        Me.cmd_migrate_ip.Name = "cmd_migrate_ip"
        Me.cmd_migrate_ip.Size = New System.Drawing.Size(42, 30)
        Me.cmd_migrate_ip.TabIndex = 40
        Me.cmd_migrate_ip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_migrate_ip.UseVisualStyleBackColor = False
        '
        'cmd_delete
        '
        Me.cmd_delete.AutoSize = True
        Me.cmd_delete.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cmd_delete.ForeColor = System.Drawing.Color.White
        Me.cmd_delete.Image = Global.SCANDB.My.Resources.Resources.delete1
        Me.cmd_delete.Location = New System.Drawing.Point(115, 141)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(87, 30)
        Me.cmd_delete.TabIndex = 28
        Me.cmd_delete.Text = "DELETE"
        Me.cmd_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_delete.UseVisualStyleBackColor = False
        '
        'cmd_edit
        '
        Me.cmd_edit.AutoSize = True
        Me.cmd_edit.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cmd_edit.ForeColor = System.Drawing.Color.White
        Me.cmd_edit.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.cmd_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_edit.Location = New System.Drawing.Point(15, 141)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(90, 30)
        Me.cmd_edit.TabIndex = 15
        Me.cmd_edit.Text = "       EDIT"
        Me.cmd_edit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Connection_icon32x32
        Me.PictureBox1.Location = New System.Drawing.Point(201, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'btn_filter
        '
        Me.btn_filter.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btn_filter.ForeColor = System.Drawing.Color.White
        Me.btn_filter.Image = Global.SCANDB.My.Resources.Resources.folder_find1
        Me.btn_filter.Location = New System.Drawing.Point(570, 7)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(33, 30)
        Me.btn_filter.TabIndex = 31
        Me.btn_filter.UseVisualStyleBackColor = False
        '
        'cmd_refresh
        '
        Me.cmd_refresh.AutoSize = True
        Me.cmd_refresh.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cmd_refresh.ForeColor = System.Drawing.Color.White
        Me.cmd_refresh.Image = Global.SCANDB.My.Resources.Resources.refresh
        Me.cmd_refresh.Location = New System.Drawing.Point(989, 7)
        Me.cmd_refresh.Name = "cmd_refresh"
        Me.cmd_refresh.Size = New System.Drawing.Size(33, 30)
        Me.cmd_refresh.TabIndex = 4
        Me.cmd_refresh.UseVisualStyleBackColor = False
        '
        'cmd_search
        '
        Me.cmd_search.AutoSize = True
        Me.cmd_search.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cmd_search.Image = Global.SCANDB.My.Resources.Resources.search
        Me.cmd_search.Location = New System.Drawing.Point(950, 7)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(33, 30)
        Me.cmd_search.TabIndex = 3
        Me.cmd_search.UseVisualStyleBackColor = False
        '
        'FrmmanageIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1136, 825)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chk_filter)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.cbo_filter)
        Me.Controls.Add(Me.cmd_refresh)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txt_find)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_type)
        Me.Controls.Add(Me.dtgvip)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmmanageIP"
        Me.Text = "MANAGEMENTIP"
        CType(Me.dtgvip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgvip As DataGridView
    Friend WithEvents cbo_type As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_find As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents txt_ip As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_fullname As TextBox
    Friend WithEvents txt_position As TextBox
    Friend WithEvents txt_product As TextBox
    Friend WithEvents txt_floor As TextBox
    Friend WithEvents txt_server As TextBox
    Friend WithEvents txt_domain As TextBox
    Friend WithEvents cmd_search As Button
    Friend WithEvents cmd_refresh As Button
    Friend WithEvents cmd_edit As Button
    Friend WithEvents IP As Label
    Friend WithEvents label99 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_detail As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmd_delete As Button
    Friend WithEvents cbo_filter As ComboBox
    Friend WithEvents btn_filter As Button
    Friend WithEvents chk_filter As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtp_edit As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_migrate_ip As TextBox
    Friend WithEvents cmd_migrate_ip As Button
End Class
