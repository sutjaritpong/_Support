<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExecution
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExecution))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Group_search = New System.Windows.Forms.GroupBox()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_find = New System.Windows.Forms.Button()
        Me.cmd_edit = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_tracking_detail = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_collec_nosend = New System.Windows.Forms.TextBox()
        Me.txt_verify_comment = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_tracking_nosheet = New System.Windows.Forms.TextBox()
        Me.txt_verify_result = New System.Windows.Forms.TextBox()
        Me.txt_detail1 = New System.Windows.Forms.TextBox()
        Me.chk_verify_date = New System.Windows.Forms.CheckBox()
        Me.dtp_verify_date = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_tracking_date = New System.Windows.Forms.DateTimePicker()
        Me.cbo_employees_exe = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.chk_tracking_date = New System.Windows.Forms.CheckBox()
        Me.txt_hubs = New System.Windows.Forms.TextBox()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.txt_performance = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_product = New System.Windows.Forms.TextBox()
        Me.txt_nameem = New System.Windows.Forms.TextBox()
        Me.txt_count_acc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_employee = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chk_datesheet = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.cbo_acc = New System.Windows.Forms.ComboBox()
        Me.txt_hub = New System.Windows.Forms.TextBox()
        Me.cbo_department = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_namecus = New System.Windows.Forms.TextBox()
        Me.txt_idcus = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_black = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.cbo_court = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_datesheet = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_red = New System.Windows.Forms.TextBox()
        Me.dtgv_search = New System.Windows.Forms.DataGridView()
        Me.Group_search.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtgv_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ค้นหาข้อมูลจาก :"
        '
        'Group_search
        '
        Me.Group_search.Controls.Add(Me.cmd_search)
        Me.Group_search.Controls.Add(Me.txt_search)
        Me.Group_search.Controls.Add(Me.Label2)
        Me.Group_search.Controls.Add(Me.cbo_type)
        Me.Group_search.Controls.Add(Me.Label1)
        Me.Group_search.Location = New System.Drawing.Point(3, 3)
        Me.Group_search.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Group_search.Name = "Group_search"
        Me.Group_search.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Group_search.Size = New System.Drawing.Size(819, 42)
        Me.Group_search.TabIndex = 1
        Me.Group_search.TabStop = False
        '
        'cmd_search
        '
        Me.cmd_search.BackColor = System.Drawing.Color.White
        Me.cmd_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_search.Image = Global.SCANDB.My.Resources.Resources.Find_16x16
        Me.cmd_search.Location = New System.Drawing.Point(682, 9)
        Me.cmd_search.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(121, 31)
        Me.cmd_search.TabIndex = 2
        Me.cmd_search.Text = "ค้นหา"
        Me.cmd_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_search.UseVisualStyleBackColor = False
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_search.Location = New System.Drawing.Point(441, 13)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(222, 22)
        Me.txt_search.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ข้อมูลที่ต้องการค้นหา :"
        '
        'cbo_type
        '
        Me.cbo_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Location = New System.Drawing.Point(115, 12)
        Me.cbo_type.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(181, 24)
        Me.cbo_type.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmd_find)
        Me.GroupBox2.Controls.Add(Me.cmd_edit)
        Me.GroupBox2.Controls.Add(Me.cmd_cancel)
        Me.GroupBox2.Controls.Add(Me.cmd_save)
        Me.GroupBox2.Location = New System.Drawing.Point(832, 3)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(169, 189)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'cmd_find
        '
        Me.cmd_find.BackColor = System.Drawing.Color.White
        Me.cmd_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_find.Image = Global.SCANDB.My.Resources.Resources.search
        Me.cmd_find.Location = New System.Drawing.Point(8, 18)
        Me.cmd_find.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cmd_find.Name = "cmd_find"
        Me.cmd_find.Size = New System.Drawing.Size(155, 33)
        Me.cmd_find.TabIndex = 3
        Me.cmd_find.Text = "เลขที่บัตรประชาชน"
        Me.cmd_find.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_find.UseVisualStyleBackColor = False
        '
        'cmd_edit
        '
        Me.cmd_edit.BackColor = System.Drawing.Color.White
        Me.cmd_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_edit.Image = Global.SCANDB.My.Resources.Resources.edit_icon16x16
        Me.cmd_edit.Location = New System.Drawing.Point(8, 60)
        Me.cmd_edit.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(155, 33)
        Me.cmd_edit.TabIndex = 4
        Me.cmd_edit.Text = "แก้ไข"
        Me.cmd_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_edit.UseVisualStyleBackColor = False
        '
        'cmd_cancel
        '
        Me.cmd_cancel.BackColor = System.Drawing.Color.White
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_cancel.Image = Global.SCANDB.My.Resources.Resources.edit_delete_icon16x16
        Me.cmd_cancel.Location = New System.Drawing.Point(8, 100)
        Me.cmd_cancel.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(155, 33)
        Me.cmd_cancel.TabIndex = 33
        Me.cmd_cancel.Text = "ยกเลิก"
        Me.cmd_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'cmd_save
        '
        Me.cmd_save.BackColor = System.Drawing.Color.White
        Me.cmd_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_save.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.cmd_save.Location = New System.Drawing.Point(8, 141)
        Me.cmd_save.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(155, 33)
        Me.cmd_save.TabIndex = 34
        Me.cmd_save.Text = "บันทึก"
        Me.cmd_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_save.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.txt_tracking_detail)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txt_collec_nosend)
        Me.GroupBox1.Controls.Add(Me.txt_verify_comment)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txt_tracking_nosheet)
        Me.GroupBox1.Controls.Add(Me.txt_verify_result)
        Me.GroupBox1.Controls.Add(Me.txt_detail1)
        Me.GroupBox1.Controls.Add(Me.chk_verify_date)
        Me.GroupBox1.Controls.Add(Me.dtp_verify_date)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(441, 391)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 291)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลตรวจสำนวน"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.Window
        Me.Label27.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(22, 121)
        Me.Label27.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(114, 18)
        Me.Label27.TabIndex = 87
        Me.Label27.Text = "รายละเอียดในใบคำร้อง"
        '
        'txt_tracking_detail
        '
        Me.txt_tracking_detail.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tracking_detail.ForeColor = System.Drawing.Color.Blue
        Me.txt_tracking_detail.Location = New System.Drawing.Point(146, 116)
        Me.txt_tracking_detail.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_tracking_detail.Name = "txt_tracking_detail"
        Me.txt_tracking_detail.Size = New System.Drawing.Size(136, 23)
        Me.txt_tracking_detail.TabIndex = 29
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.Window
        Me.Label26.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(41, 93)
        Me.Label26.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(95, 18)
        Me.Label26.TabIndex = 85
        Me.Label26.Text = "ไม่ส่งมาออกใบงาน"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Window
        Me.Label20.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 180)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(120, 18)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "คำอธิบาย ตรวจสำนวน"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Window
        Me.Label24.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(14, 232)
        Me.Label24.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(126, 18)
        Me.Label24.TabIndex = 79
        Me.Label24.Text = "หมายเหตุตอนออกใบงาน"
        '
        'txt_collec_nosend
        '
        Me.txt_collec_nosend.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_collec_nosend.ForeColor = System.Drawing.Color.Blue
        Me.txt_collec_nosend.Location = New System.Drawing.Point(146, 87)
        Me.txt_collec_nosend.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_collec_nosend.Name = "txt_collec_nosend"
        Me.txt_collec_nosend.Size = New System.Drawing.Size(136, 23)
        Me.txt_collec_nosend.TabIndex = 28
        '
        'txt_verify_comment
        '
        Me.txt_verify_comment.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_verify_comment.ForeColor = System.Drawing.Color.Blue
        Me.txt_verify_comment.Location = New System.Drawing.Point(144, 180)
        Me.txt_verify_comment.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_verify_comment.Multiline = True
        Me.txt_verify_comment.Name = "txt_verify_comment"
        Me.txt_verify_comment.Size = New System.Drawing.Size(237, 40)
        Me.txt_verify_comment.TabIndex = 32
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Window
        Me.Label25.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(47, 61)
        Me.Label25.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 18)
        Me.Label25.TabIndex = 83
        Me.Label25.Text = "ใบงานจาก MIS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Window
        Me.Label19.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 148)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 18)
        Me.Label19.TabIndex = 77
        Me.Label19.Text = "สถานะการตรวจสำนวน"
        '
        'txt_tracking_nosheet
        '
        Me.txt_tracking_nosheet.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tracking_nosheet.ForeColor = System.Drawing.Color.Blue
        Me.txt_tracking_nosheet.Location = New System.Drawing.Point(146, 58)
        Me.txt_tracking_nosheet.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_tracking_nosheet.Name = "txt_tracking_nosheet"
        Me.txt_tracking_nosheet.Size = New System.Drawing.Size(136, 23)
        Me.txt_tracking_nosheet.TabIndex = 27
        '
        'txt_verify_result
        '
        Me.txt_verify_result.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_verify_result.ForeColor = System.Drawing.Color.MediumPurple
        Me.txt_verify_result.Location = New System.Drawing.Point(146, 145)
        Me.txt_verify_result.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_verify_result.Multiline = True
        Me.txt_verify_result.Name = "txt_verify_result"
        Me.txt_verify_result.Size = New System.Drawing.Size(136, 24)
        Me.txt_verify_result.TabIndex = 31
        '
        'txt_detail1
        '
        Me.txt_detail1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_detail1.ForeColor = System.Drawing.Color.Blue
        Me.txt_detail1.Location = New System.Drawing.Point(144, 232)
        Me.txt_detail1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_detail1.Multiline = True
        Me.txt_detail1.Name = "txt_detail1"
        Me.txt_detail1.Size = New System.Drawing.Size(237, 30)
        Me.txt_detail1.TabIndex = 21
        '
        'chk_verify_date
        '
        Me.chk_verify_date.AutoSize = True
        Me.chk_verify_date.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_verify_date.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_verify_date.Location = New System.Drawing.Point(6, 25)
        Me.chk_verify_date.Name = "chk_verify_date"
        Me.chk_verify_date.Size = New System.Drawing.Size(134, 22)
        Me.chk_verify_date.TabIndex = 80
        Me.chk_verify_date.Text = "วันที่บังคับคดีไปทำงาน"
        Me.chk_verify_date.UseVisualStyleBackColor = True
        '
        'dtp_verify_date
        '
        Me.dtp_verify_date.CalendarForeColor = System.Drawing.Color.Blue
        Me.dtp_verify_date.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_verify_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_verify_date.Location = New System.Drawing.Point(148, 25)
        Me.dtp_verify_date.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.dtp_verify_date.Name = "dtp_verify_date"
        Me.dtp_verify_date.Size = New System.Drawing.Size(134, 23)
        Me.dtp_verify_date.TabIndex = 30
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.dtp_tracking_date)
        Me.GroupBox4.Controls.Add(Me.cbo_employees_exe)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.chk_tracking_date)
        Me.GroupBox4.Controls.Add(Me.txt_hubs)
        Me.GroupBox4.Controls.Add(Me.txt_result)
        Me.GroupBox4.Controls.Add(Me.txt_performance)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(441, 198)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(384, 195)
        Me.GroupBox4.TabIndex = 92
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ใบคำร้องขอตรวจสำนวน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 19)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "ผลปฎิบัติงาน"
        '
        'dtp_tracking_date
        '
        Me.dtp_tracking_date.CalendarForeColor = System.Drawing.Color.Blue
        Me.dtp_tracking_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_tracking_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tracking_date.Location = New System.Drawing.Point(165, 157)
        Me.dtp_tracking_date.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.dtp_tracking_date.Name = "dtp_tracking_date"
        Me.dtp_tracking_date.Size = New System.Drawing.Size(117, 22)
        Me.dtp_tracking_date.TabIndex = 26
        '
        'cbo_employees_exe
        '
        Me.cbo_employees_exe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_employees_exe.ForeColor = System.Drawing.Color.Blue
        Me.cbo_employees_exe.FormattingEnabled = True
        Me.cbo_employees_exe.Location = New System.Drawing.Point(146, 115)
        Me.cbo_employees_exe.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cbo_employees_exe.Name = "cbo_employees_exe"
        Me.cbo_employees_exe.Size = New System.Drawing.Size(136, 24)
        Me.cbo_employees_exe.TabIndex = 88
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.Window
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label23.Location = New System.Drawing.Point(45, 118)
        Me.Label23.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 16)
        Me.Label23.TabIndex = 76
        Me.Label23.Text = "เจ้าหน้าที่บังคับคดี"
        '
        'chk_tracking_date
        '
        Me.chk_tracking_date.AutoSize = True
        Me.chk_tracking_date.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_tracking_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_tracking_date.Location = New System.Drawing.Point(6, 159)
        Me.chk_tracking_date.Name = "chk_tracking_date"
        Me.chk_tracking_date.Size = New System.Drawing.Size(151, 20)
        Me.chk_tracking_date.TabIndex = 67
        Me.chk_tracking_date.Text = "วันที่ในใบคำร้องขอทำบัญชี"
        Me.chk_tracking_date.UseVisualStyleBackColor = True
        '
        'txt_hubs
        '
        Me.txt_hubs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_hubs.ForeColor = System.Drawing.Color.Red
        Me.txt_hubs.Location = New System.Drawing.Point(146, 50)
        Me.txt_hubs.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_hubs.Name = "txt_hubs"
        Me.txt_hubs.Size = New System.Drawing.Size(136, 22)
        Me.txt_hubs.TabIndex = 23
        '
        'txt_result
        '
        Me.txt_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_result.ForeColor = System.Drawing.Color.Blue
        Me.txt_result.Location = New System.Drawing.Point(146, 84)
        Me.txt_result.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_result.Multiline = True
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(136, 24)
        Me.txt_result.TabIndex = 24
        '
        'txt_performance
        '
        Me.txt_performance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_performance.ForeColor = System.Drawing.Color.Blue
        Me.txt_performance.Location = New System.Drawing.Point(146, 16)
        Me.txt_performance.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_performance.Multiline = True
        Me.txt_performance.Name = "txt_performance"
        Me.txt_performance.Size = New System.Drawing.Size(136, 24)
        Me.txt_performance.TabIndex = 22
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Window
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(99, 53)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 16)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "HUB"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(90, 87)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 16)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Result"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_product)
        Me.GroupBox3.Controls.Add(Me.txt_nameem)
        Me.GroupBox3.Controls.Add(Me.txt_count_acc)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txt_employee)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_phone)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.chk_datesheet)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_number)
        Me.GroupBox3.Controls.Add(Me.cbo_acc)
        Me.GroupBox3.Controls.Add(Me.txt_hub)
        Me.GroupBox3.Controls.Add(Me.cbo_department)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_namecus)
        Me.GroupBox3.Controls.Add(Me.txt_idcus)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt_black)
        Me.GroupBox3.Controls.Add(Me.txt_total)
        Me.GroupBox3.Controls.Add(Me.cbo_court)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.dtp_datesheet)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_red)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(432, 484)
        Me.GroupBox3.TabIndex = 91
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ข้อมูลใบงานแถลงบัญชี"
        '
        'txt_product
        '
        Me.txt_product.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_product.ForeColor = System.Drawing.Color.Blue
        Me.txt_product.Location = New System.Drawing.Point(154, 12)
        Me.txt_product.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_product.Name = "txt_product"
        Me.txt_product.Size = New System.Drawing.Size(230, 22)
        Me.txt_product.TabIndex = 5
        '
        'txt_nameem
        '
        Me.txt_nameem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_nameem.ForeColor = System.Drawing.Color.Blue
        Me.txt_nameem.Location = New System.Drawing.Point(154, 330)
        Me.txt_nameem.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_nameem.Name = "txt_nameem"
        Me.txt_nameem.Size = New System.Drawing.Size(230, 22)
        Me.txt_nameem.TabIndex = 16
        '
        'txt_count_acc
        '
        Me.txt_count_acc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_count_acc.ForeColor = System.Drawing.Color.Blue
        Me.txt_count_acc.Location = New System.Drawing.Point(360, 110)
        Me.txt_count_acc.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_count_acc.Name = "txt_count_acc"
        Me.txt_count_acc.Size = New System.Drawing.Size(24, 22)
        Me.txt_count_acc.TabIndex = 9
        Me.txt_count_acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 331)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "ชื่อบนใบงาน :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(72, 456)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "ชื่อพนักงาน :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Window
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(88, 16)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 16)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "ธนาคาร :"
        '
        'txt_employee
        '
        Me.txt_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_employee.ForeColor = System.Drawing.Color.Blue
        Me.txt_employee.Location = New System.Drawing.Point(154, 453)
        Me.txt_employee.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_employee.Name = "txt_employee"
        Me.txt_employee.Size = New System.Drawing.Size(230, 22)
        Me.txt_employee.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(75, 364)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "เบอร์ติดต่อ :"
        '
        'txt_phone
        '
        Me.txt_phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_phone.ForeColor = System.Drawing.Color.Blue
        Me.txt_phone.Location = New System.Drawing.Point(154, 361)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(230, 22)
        Me.txt_phone.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Window
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(77, 302)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 16)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "จำนวนเงิน :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Window
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(92, 211)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 16)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "เลขเก็บ :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(48, 397)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 16)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "ศูนย์ประสานงาน :"
        '
        'chk_datesheet
        '
        Me.chk_datesheet.AutoSize = True
        Me.chk_datesheet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datesheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_datesheet.Location = New System.Drawing.Point(44, 429)
        Me.chk_datesheet.Name = "chk_datesheet"
        Me.chk_datesheet.Size = New System.Drawing.Size(96, 20)
        Me.chk_datesheet.TabIndex = 61
        Me.chk_datesheet.Text = "วันที่ิออกใบงาน"
        Me.chk_datesheet.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "เลขที่สัญญา :"
        '
        'txt_number
        '
        Me.txt_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_number.ForeColor = System.Drawing.Color.Fuchsia
        Me.txt_number.Location = New System.Drawing.Point(154, 208)
        Me.txt_number.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(121, 22)
        Me.txt_number.TabIndex = 12
        '
        'cbo_acc
        '
        Me.cbo_acc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_acc.ForeColor = System.Drawing.Color.Blue
        Me.cbo_acc.FormattingEnabled = True
        Me.cbo_acc.Location = New System.Drawing.Point(154, 109)
        Me.cbo_acc.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cbo_acc.Name = "cbo_acc"
        Me.cbo_acc.Size = New System.Drawing.Size(205, 24)
        Me.cbo_acc.TabIndex = 8
        '
        'txt_hub
        '
        Me.txt_hub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_hub.ForeColor = System.Drawing.Color.Blue
        Me.txt_hub.Location = New System.Drawing.Point(154, 394)
        Me.txt_hub.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_hub.Name = "txt_hub"
        Me.txt_hub.Size = New System.Drawing.Size(230, 22)
        Me.txt_hub.TabIndex = 18
        '
        'cbo_department
        '
        Me.cbo_department.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_department.ForeColor = System.Drawing.Color.Blue
        Me.cbo_department.FormattingEnabled = True
        Me.cbo_department.Location = New System.Drawing.Point(154, 264)
        Me.cbo_department.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cbo_department.Name = "cbo_department"
        Me.cbo_department.Size = New System.Drawing.Size(230, 24)
        Me.cbo_department.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "เลขประจำตัวประชาชน :"
        '
        'txt_namecus
        '
        Me.txt_namecus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_namecus.ForeColor = System.Drawing.Color.Blue
        Me.txt_namecus.Location = New System.Drawing.Point(154, 77)
        Me.txt_namecus.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_namecus.Name = "txt_namecus"
        Me.txt_namecus.Size = New System.Drawing.Size(230, 22)
        Me.txt_namecus.TabIndex = 7
        '
        'txt_idcus
        '
        Me.txt_idcus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_idcus.ForeColor = System.Drawing.Color.Blue
        Me.txt_idcus.Location = New System.Drawing.Point(154, 44)
        Me.txt_idcus.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_idcus.Name = "txt_idcus"
        Me.txt_idcus.Size = New System.Drawing.Size(230, 22)
        Me.txt_idcus.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(64, 267)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 16)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "กรมบังคับคดี :"
        '
        'txt_black
        '
        Me.txt_black.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_black.Location = New System.Drawing.Point(154, 176)
        Me.txt_black.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_black.Name = "txt_black"
        Me.txt_black.Size = New System.Drawing.Size(121, 22)
        Me.txt_black.TabIndex = 11
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.DarkOrange
        Me.txt_total.Location = New System.Drawing.Point(154, 299)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(230, 22)
        Me.txt_total.TabIndex = 15
        '
        'cbo_court
        '
        Me.cbo_court.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbo_court.ForeColor = System.Drawing.Color.Blue
        Me.cbo_court.FormattingEnabled = True
        Me.cbo_court.Location = New System.Drawing.Point(154, 143)
        Me.cbo_court.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cbo_court.Name = "cbo_court"
        Me.cbo_court.Size = New System.Drawing.Size(230, 24)
        Me.cbo_court.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(82, 179)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 16)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "เลขคดีดำ :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(106, 146)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 16)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "ศาล :"
        '
        'dtp_datesheet
        '
        Me.dtp_datesheet.CalendarForeColor = System.Drawing.Color.Blue
        Me.dtp_datesheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtp_datesheet.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datesheet.Location = New System.Drawing.Point(154, 425)
        Me.dtp_datesheet.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.dtp_datesheet.Name = "dtp_datesheet"
        Me.dtp_datesheet.Size = New System.Drawing.Size(101, 22)
        Me.dtp_datesheet.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 81)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "ชื่อลูกค้า :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(75, 239)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 16)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "เลขคดีแดง :"
        '
        'txt_red
        '
        Me.txt_red.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_red.ForeColor = System.Drawing.Color.Red
        Me.txt_red.Location = New System.Drawing.Point(154, 236)
        Me.txt_red.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_red.Name = "txt_red"
        Me.txt_red.Size = New System.Drawing.Size(121, 22)
        Me.txt_red.TabIndex = 13
        '
        'dtgv_search
        '
        Me.dtgv_search.AllowUserToAddRows = False
        Me.dtgv_search.AllowUserToDeleteRows = False
        Me.dtgv_search.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dtgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_search.GridColor = System.Drawing.Color.Black
        Me.dtgv_search.Location = New System.Drawing.Point(6, 49)
        Me.dtgv_search.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.dtgv_search.Name = "dtgv_search"
        Me.dtgv_search.ReadOnly = True
        Me.dtgv_search.Size = New System.Drawing.Size(819, 143)
        Me.dtgv_search.TabIndex = 93
        '
        'FrmExecution
        '
        Me.AcceptButton = Me.cmd_search
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(1004, 725)
        Me.Controls.Add(Me.dtgv_search)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Group_search)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmExecution"
        Me.Text = "แถลงบัญชี"
        Me.Group_search.ResumeLayout(False)
        Me.Group_search.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtgv_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Group_search As GroupBox
    Friend WithEvents cmd_search As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_type As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmd_save As Button
    Friend WithEvents cmd_find As Button
    Friend WithEvents cmd_edit As Button
    Friend WithEvents cmd_cancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_tracking_detail As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_collec_nosend As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_tracking_nosheet As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label24 As Label
    Public WithEvents dtp_verify_date As DateTimePicker
    Friend WithEvents txt_verify_comment As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_verify_result As TextBox
    Friend WithEvents chk_verify_date As CheckBox
    Friend WithEvents txt_detail1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_tracking_date As DateTimePicker
    Friend WithEvents cbo_employees_exe As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents chk_tracking_date As CheckBox
    Friend WithEvents txt_hubs As TextBox
    Friend WithEvents txt_result As TextBox
    Friend WithEvents txt_performance As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_product As TextBox
    Friend WithEvents txt_nameem As TextBox
    Friend WithEvents txt_count_acc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_employee As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents chk_datesheet As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_number As TextBox
    Friend WithEvents cbo_acc As ComboBox
    Friend WithEvents txt_hub As TextBox
    Friend WithEvents cbo_department As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_namecus As TextBox
    Friend WithEvents txt_idcus As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_black As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents cbo_court As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtp_datesheet As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_red As TextBox
    Friend WithEvents dtgv_search As DataGridView
End Class
