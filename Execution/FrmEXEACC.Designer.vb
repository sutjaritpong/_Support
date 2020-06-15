<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEXEACC
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEXEACC))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chk_date_work = New System.Windows.Forms.CheckBox()
        Me.txt_red = New System.Windows.Forms.TextBox()
        Me.dtp_datework = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cusid = New System.Windows.Forms.TextBox()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_black = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_owner = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_detail_receipt = New System.Windows.Forms.TextBox()
        Me.dtp_date_receipt = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_total_receipt = New System.Windows.Forms.TextBox()
        Me.dtgv_exeacc = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmd_delete = New System.Windows.Forms.Button()
        Me.cmd_send = New System.Windows.Forms.Button()
        Me.cmd_edit = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.Group_detail = New System.Windows.Forms.GroupBox()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.lbl_datetoday = New System.Windows.Forms.Label()
        Me.lbl_timer = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.cbo_search = New System.Windows.Forms.ComboBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_detail_receipt2 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_total_receipt2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_detail_receipt3 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_total_receipt3 = New System.Windows.Forms.TextBox()
        Me.chk_date_receipt = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lbl_count_find = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgv_exeacc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Group_detail.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chk_date_work)
        Me.GroupBox4.Controls.Add(Me.txt_red)
        Me.GroupBox4.Controls.Add(Me.dtp_datework)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_status)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txt_cusid)
        Me.GroupBox4.Controls.Add(Me.txt_cusname)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txt_black)
        Me.GroupBox4.Location = New System.Drawing.Point(33, 135)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox4.Size = New System.Drawing.Size(311, 201)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ข้อมูลลูกค้า"
        '
        'chk_date_work
        '
        Me.chk_date_work.AutoSize = True
        Me.chk_date_work.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_date_work.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_date_work.Location = New System.Drawing.Point(19, 152)
        Me.chk_date_work.Name = "chk_date_work"
        Me.chk_date_work.Size = New System.Drawing.Size(94, 20)
        Me.chk_date_work.TabIndex = 95
        Me.chk_date_work.Text = "เดือนที่ลงข้อมูล"
        Me.chk_date_work.ThreeState = True
        Me.chk_date_work.UseVisualStyleBackColor = True
        '
        'txt_red
        '
        Me.txt_red.ForeColor = System.Drawing.Color.Red
        Me.txt_red.Location = New System.Drawing.Point(119, 100)
        Me.txt_red.Name = "txt_red"
        Me.txt_red.Size = New System.Drawing.Size(178, 20)
        Me.txt_red.TabIndex = 8
        '
        'dtp_datework
        '
        Me.dtp_datework.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datework.Location = New System.Drawing.Point(119, 152)
        Me.dtp_datework.Name = "dtp_datework"
        Me.dtp_datework.Size = New System.Drawing.Size(116, 20)
        Me.dtp_datework.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "เลขคดีดำ"
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(119, 126)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(178, 20)
        Me.txt_status.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(48, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 20)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "STATUS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "เลขคดีแดง"
        '
        'txt_cusid
        '
        Me.txt_cusid.Location = New System.Drawing.Point(119, 22)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(178, 20)
        Me.txt_cusid.TabIndex = 5
        '
        'txt_cusname
        '
        Me.txt_cusname.Location = New System.Drawing.Point(119, 48)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(178, 20)
        Me.txt_cusname.TabIndex = 6
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
        'txt_black
        '
        Me.txt_black.Location = New System.Drawing.Point(119, 74)
        Me.txt_black.Name = "txt_black"
        Me.txt_black.Size = New System.Drawing.Size(178, 20)
        Me.txt_black.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_owner)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(311, 70)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Owner"
        '
        'cbo_owner
        '
        Me.cbo_owner.FormattingEnabled = True
        Me.cbo_owner.Location = New System.Drawing.Point(119, 23)
        Me.cbo_owner.Name = "cbo_owner"
        Me.cbo_owner.Size = New System.Drawing.Size(178, 23)
        Me.cbo_owner.TabIndex = 4
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "รายละเอียดใบเสร็จ 1"
        '
        'txt_detail_receipt
        '
        Me.txt_detail_receipt.Location = New System.Drawing.Point(128, 37)
        Me.txt_detail_receipt.Multiline = True
        Me.txt_detail_receipt.Name = "txt_detail_receipt"
        Me.txt_detail_receipt.Size = New System.Drawing.Size(313, 54)
        Me.txt_detail_receipt.TabIndex = 12
        '
        'dtp_date_receipt
        '
        Me.dtp_date_receipt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_receipt.Location = New System.Drawing.Point(128, 99)
        Me.dtp_date_receipt.Name = "dtp_date_receipt"
        Me.dtp_date_receipt.Size = New System.Drawing.Size(115, 22)
        Me.dtp_date_receipt.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 20)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "จำนวนเงินในใบเสร็จ 1"
        '
        'txt_total_receipt
        '
        Me.txt_total_receipt.ForeColor = System.Drawing.Color.Orange
        Me.txt_total_receipt.Location = New System.Drawing.Point(128, 9)
        Me.txt_total_receipt.Name = "txt_total_receipt"
        Me.txt_total_receipt.Size = New System.Drawing.Size(169, 22)
        Me.txt_total_receipt.TabIndex = 11
        '
        'dtgv_exeacc
        '
        Me.dtgv_exeacc.AllowUserToAddRows = False
        Me.dtgv_exeacc.AllowUserToDeleteRows = False
        Me.dtgv_exeacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_exeacc.Location = New System.Drawing.Point(33, 547)
        Me.dtgv_exeacc.Name = "dtgv_exeacc"
        Me.dtgv_exeacc.ReadOnly = True
        Me.dtgv_exeacc.Size = New System.Drawing.Size(941, 138)
        Me.dtgv_exeacc.TabIndex = 86
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmd_delete)
        Me.GroupBox3.Controls.Add(Me.cmd_send)
        Me.GroupBox3.Controls.Add(Me.cmd_edit)
        Me.GroupBox3.Controls.Add(Me.cmd_cancel)
        Me.GroupBox3.Controls.Add(Me.cmd_save)
        Me.GroupBox3.Location = New System.Drawing.Point(829, 134)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(145, 202)
        Me.GroupBox3.TabIndex = 88
        Me.GroupBox3.TabStop = False
        '
        'cmd_delete
        '
        Me.cmd_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_delete.Image = Global.SCANDB.My.Resources.Resources.arrow_redo
        Me.cmd_delete.Location = New System.Drawing.Point(6, 160)
        Me.cmd_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_delete.Name = "cmd_delete"
        Me.cmd_delete.Size = New System.Drawing.Size(133, 29)
        Me.cmd_delete.TabIndex = 22
        Me.cmd_delete.Text = "เคลียร์ข้อมูล"
        Me.cmd_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_delete.UseVisualStyleBackColor = True
        '
        'cmd_send
        '
        Me.cmd_send.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_send.Image = Global.SCANDB.My.Resources.Resources.add
        Me.cmd_send.Location = New System.Drawing.Point(5, 19)
        Me.cmd_send.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_send.Name = "cmd_send"
        Me.cmd_send.Size = New System.Drawing.Size(133, 29)
        Me.cmd_send.TabIndex = 18
        Me.cmd_send.Text = "เพิ่มข้อมูล"
        Me.cmd_send.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_send.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_send.UseVisualStyleBackColor = True
        '
        'cmd_edit
        '
        Me.cmd_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_edit.Image = Global.SCANDB.My.Resources.Resources.edit_icon16x16
        Me.cmd_edit.Location = New System.Drawing.Point(6, 125)
        Me.cmd_edit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(133, 29)
        Me.cmd_edit.TabIndex = 19
        Me.cmd_edit.Text = "แก้ไข"
        Me.cmd_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_edit.UseVisualStyleBackColor = True
        '
        'cmd_cancel
        '
        Me.cmd_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_cancel.Image = Global.SCANDB.My.Resources.Resources.edit_delete_icon16x16
        Me.cmd_cancel.Location = New System.Drawing.Point(5, 90)
        Me.cmd_cancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(133, 29)
        Me.cmd_cancel.TabIndex = 20
        Me.cmd_cancel.Text = "ยกเลิก"
        Me.cmd_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'cmd_save
        '
        Me.cmd_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_save.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.cmd_save.Location = New System.Drawing.Point(5, 54)
        Me.cmd_save.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(133, 29)
        Me.cmd_save.TabIndex = 21
        Me.cmd_save.Text = "อัพเดตข้อมูล"
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
        Me.Group_detail.Location = New System.Drawing.Point(829, 12)
        Me.Group_detail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Group_detail.Name = "Group_detail"
        Me.Group_detail.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Group_detail.Size = New System.Drawing.Size(145, 116)
        Me.Group_detail.TabIndex = 87
        Me.Group_detail.TabStop = False
        '
        'lbl_count
        '
        Me.lbl_count.BackColor = System.Drawing.SystemColors.InfoText
        Me.lbl_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_count.ForeColor = System.Drawing.Color.Orange
        Me.lbl_count.Location = New System.Drawing.Point(7, 72)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 12)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(290, 37)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "ข้อมูลบังคับคดีตั้งเรื่อง"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.cmd_search)
        Me.GroupBox5.Controls.Add(Me.cbo_search)
        Me.GroupBox5.Controls.Add(Me.txt_search)
        Me.GroupBox5.Location = New System.Drawing.Point(33, 480)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Size = New System.Drawing.Size(660, 65)
        Me.GroupBox5.TabIndex = 77
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ค้นหาข้อมูล"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 27)
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
        Me.Label12.Location = New System.Drawing.Point(231, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 20)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "ข้อมูลที่ต้องการหา"
        '
        'cmd_search
        '
        Me.cmd_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_search.Image = Global.SCANDB.My.Resources.Resources.Find_16x16
        Me.cmd_search.Location = New System.Drawing.Point(511, 23)
        Me.cmd_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(133, 29)
        Me.cmd_search.TabIndex = 3
        Me.cmd_search.Text = "ค้นหาข้อมูล"
        Me.cmd_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_search.UseVisualStyleBackColor = True
        '
        'cbo_search
        '
        Me.cbo_search.FormattingEnabled = True
        Me.cbo_search.Location = New System.Drawing.Point(89, 26)
        Me.cbo_search.Name = "cbo_search"
        Me.cbo_search.Size = New System.Drawing.Size(137, 23)
        Me.cbo_search.TabIndex = 1
        '
        'txt_search
        '
        Me.txt_search.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search.Location = New System.Drawing.Point(334, 26)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(170, 22)
        Me.txt_search.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 20)
        Me.Label14.TabIndex = 93
        Me.Label14.Text = "รายละเอียดใบเสร็จ 2"
        '
        'txt_detail_receipt2
        '
        Me.txt_detail_receipt2.Location = New System.Drawing.Point(128, 37)
        Me.txt_detail_receipt2.Multiline = True
        Me.txt_detail_receipt2.Name = "txt_detail_receipt2"
        Me.txt_detail_receipt2.Size = New System.Drawing.Size(313, 54)
        Me.txt_detail_receipt2.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 20)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "จำนวนเงินในใบเสร็จ 2"
        '
        'txt_total_receipt2
        '
        Me.txt_total_receipt2.ForeColor = System.Drawing.Color.Orange
        Me.txt_total_receipt2.Location = New System.Drawing.Point(128, 9)
        Me.txt_total_receipt2.Name = "txt_total_receipt2"
        Me.txt_total_receipt2.Size = New System.Drawing.Size(170, 22)
        Me.txt_total_receipt2.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Window
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 20)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "รายละเอียดใบเสร็จ 3"
        '
        'txt_detail_receipt3
        '
        Me.txt_detail_receipt3.Location = New System.Drawing.Point(128, 37)
        Me.txt_detail_receipt3.Multiline = True
        Me.txt_detail_receipt3.Name = "txt_detail_receipt3"
        Me.txt_detail_receipt3.Size = New System.Drawing.Size(313, 54)
        Me.txt_detail_receipt3.TabIndex = 17
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Window
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 20)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "จำนวนเงินในใบเสร็จ 3"
        '
        'txt_total_receipt3
        '
        Me.txt_total_receipt3.ForeColor = System.Drawing.Color.Orange
        Me.txt_total_receipt3.Location = New System.Drawing.Point(128, 9)
        Me.txt_total_receipt3.Name = "txt_total_receipt3"
        Me.txt_total_receipt3.Size = New System.Drawing.Size(170, 22)
        Me.txt_total_receipt3.TabIndex = 16
        '
        'chk_date_receipt
        '
        Me.chk_date_receipt.AutoSize = True
        Me.chk_date_receipt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_date_receipt.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_date_receipt.Location = New System.Drawing.Point(23, 99)
        Me.chk_date_receipt.Name = "chk_date_receipt"
        Me.chk_date_receipt.Size = New System.Drawing.Size(99, 20)
        Me.chk_date_receipt.TabIndex = 95
        Me.chk_date_receipt.Text = "วันที่บนใบเสร็จ 1"
        Me.chk_date_receipt.ThreeState = True
        Me.chk_date_receipt.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(352, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(470, 171)
        Me.TabControl1.TabIndex = 140
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chk_date_receipt)
        Me.TabPage1.Controls.Add(Me.dtp_date_receipt)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txt_detail_receipt)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txt_total_receipt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(462, 142)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ใบเสร็จ 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txt_total_receipt2)
        Me.TabPage2.Controls.Add(Me.txt_detail_receipt2)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(462, 142)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ใบเสร็จ 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt_total_receipt3)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.txt_detail_receipt3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(462, 142)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ใบเสร็จ 3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lbl_count_find
        '
        Me.lbl_count_find.AutoSize = True
        Me.lbl_count_find.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_count_find.Location = New System.Drawing.Point(27, 433)
        Me.lbl_count_find.Name = "lbl_count_find"
        Me.lbl_count_find.Size = New System.Drawing.Size(136, 32)
        Me.lbl_count_find.TabIndex = 141
        Me.lbl_count_find.Text = "ผลการค้นหา..."
        '
        'FrmEXEACC
        '
        Me.AcceptButton = Me.cmd_search
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.lbl_count_find)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Group_detail)
        Me.Controls.Add(Me.dtgv_exeacc)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEXEACC"
        Me.Text = "บังคับคดีตั้งเรื่อง"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgv_exeacc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.Group_detail.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_red As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cusid As TextBox
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_black As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_owner As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtp_datework As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_detail_receipt As TextBox
    Friend WithEvents dtp_date_receipt As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_status As TextBox
    Friend WithEvents txt_total_receipt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtgv_exeacc As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmd_send As Button
    Friend WithEvents cmd_edit As Button
    Friend WithEvents cmd_cancel As Button
    Friend WithEvents cmd_save As Button
    Friend WithEvents Group_detail As GroupBox
    Friend WithEvents lbl_count As Label
    Friend WithEvents lbl_datetoday As Label
    Friend WithEvents lbl_timer As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmd_search As Button
    Friend WithEvents cbo_search As ComboBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_detail_receipt2 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_total_receipt2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_detail_receipt3 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_total_receipt3 As TextBox
    Friend WithEvents chk_date_work As CheckBox
    Friend WithEvents chk_date_receipt As CheckBox
    Friend WithEvents cmd_delete As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lbl_count_find As Label
End Class
