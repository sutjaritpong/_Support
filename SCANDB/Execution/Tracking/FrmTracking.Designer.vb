<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTracking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTracking))
        Me.cmd_links = New System.Windows.Forms.Button()
        Me.cmd_edit = New System.Windows.Forms.Button()
        Me.cmd_cancel = New System.Windows.Forms.Button()
        Me.cmd_save = New System.Windows.Forms.Button()
        Me.txt_red = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_court = New System.Windows.Forms.TextBox()
        Me.txt_cusid = New System.Windows.Forms.TextBox()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbo_empexe = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_datesend = New System.Windows.Forms.CheckBox()
        Me.dtp_date_send = New System.Windows.Forms.DateTimePicker()
        Me.cbo_document = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dtgv_Accounting = New System.Windows.Forms.DataGridView()
        Me.cbo_owner = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_detail = New System.Windows.Forms.ComboBox()
        Me.cbo_waning = New System.Windows.Forms.ComboBox()
        Me.txt_detail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dtgv_Tracking = New System.Windows.Forms.DataGridView()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.chk_datetracking = New System.Windows.Forms.CheckBox()
        Me.dtp_date_verify = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Tracking = New System.Windows.Forms.Label()
        Me.Lbl_Accounting = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Account = New System.Windows.Forms.TextBox()
        Me.Txt_tkmoney = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_date_work = New System.Windows.Forms.DateTimePicker()
        Me.cmd_filter = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Lbl_Primary = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Cmd_LinkDatabase = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cmd_delete = New System.Windows.Forms.Button()
        Me.Cmd_update = New System.Windows.Forms.Button()
        Me.Group_search = New System.Windows.Forms.GroupBox()
        Me.Cmd_find = New System.Windows.Forms.Button()
        Me.txt_find = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_type_find = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.Dtgv_Accounting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtgv_Tracking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Group_search.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_links
        '
        Me.cmd_links.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_links.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_links.Image = Global.SCANDB.My.Resources.Resources.search
        Me.cmd_links.Location = New System.Drawing.Point(8, 92)
        Me.cmd_links.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_links.Name = "cmd_links"
        Me.cmd_links.Size = New System.Drawing.Size(144, 29)
        Me.cmd_links.TabIndex = 2
        Me.cmd_links.Text = "แสดงข้อมูลใบงาน"
        Me.cmd_links.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_links.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_links.UseVisualStyleBackColor = False
        '
        'cmd_edit
        '
        Me.cmd_edit.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_edit.Image = Global.SCANDB.My.Resources.Resources.edit_icon16x16
        Me.cmd_edit.Location = New System.Drawing.Point(8, 130)
        Me.cmd_edit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(144, 29)
        Me.cmd_edit.TabIndex = 11
        Me.cmd_edit.Text = "แก้ไข"
        Me.cmd_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_edit.UseVisualStyleBackColor = False
        '
        'cmd_cancel
        '
        Me.cmd_cancel.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_cancel.Image = Global.SCANDB.My.Resources.Resources.edit_delete_icon16x16
        Me.cmd_cancel.Location = New System.Drawing.Point(8, 165)
        Me.cmd_cancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(144, 29)
        Me.cmd_cancel.TabIndex = 13
        Me.cmd_cancel.Text = "ยกเลิก"
        Me.cmd_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cancel.UseVisualStyleBackColor = False
        '
        'cmd_save
        '
        Me.cmd_save.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_save.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.cmd_save.Location = New System.Drawing.Point(7, 25)
        Me.cmd_save.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(144, 29)
        Me.cmd_save.TabIndex = 14
        Me.cmd_save.Text = "บันทึกข้อมูล"
        Me.cmd_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_save.UseVisualStyleBackColor = False
        '
        'txt_red
        '
        Me.txt_red.ForeColor = System.Drawing.Color.Red
        Me.txt_red.Location = New System.Drawing.Point(114, 130)
        Me.txt_red.Name = "txt_red"
        Me.txt_red.Size = New System.Drawing.Size(158, 23)
        Me.txt_red.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(77, 159)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 18)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "ศาล"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(47, 130)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 18)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "เลขคดีแดง"
        '
        'txt_court
        '
        Me.txt_court.Location = New System.Drawing.Point(114, 156)
        Me.txt_court.Name = "txt_court"
        Me.txt_court.Size = New System.Drawing.Size(158, 23)
        Me.txt_court.TabIndex = 8
        '
        'txt_cusid
        '
        Me.txt_cusid.Location = New System.Drawing.Point(114, 49)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(158, 23)
        Me.txt_cusid.TabIndex = 4
        '
        'txt_cusname
        '
        Me.txt_cusname.Location = New System.Drawing.Point(114, 104)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(158, 23)
        Me.txt_cusname.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 18)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "เลขบัตรประชาชน"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(36, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 18)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "ชื่อ-นามสกุล"
        '
        'cbo_empexe
        '
        Me.cbo_empexe.FormattingEnabled = True
        Me.cbo_empexe.Location = New System.Drawing.Point(436, 22)
        Me.cbo_empexe.Name = "cbo_empexe"
        Me.cbo_empexe.Size = New System.Drawing.Size(232, 26)
        Me.cbo_empexe.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "เจ้าหน้าที่บังคับคดี"
        '
        'chk_datesend
        '
        Me.chk_datesend.AutoSize = True
        Me.chk_datesend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datesend.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datesend.Location = New System.Drawing.Point(299, 74)
        Me.chk_datesend.Name = "chk_datesend"
        Me.chk_datesend.Size = New System.Drawing.Size(131, 22)
        Me.chk_datesend.TabIndex = 124
        Me.chk_datesend.Text = "วันที่ใบงานแถลงบัญชี"
        Me.chk_datesend.UseVisualStyleBackColor = True
        '
        'dtp_date_send
        '
        Me.dtp_date_send.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_send.Location = New System.Drawing.Point(436, 74)
        Me.dtp_date_send.Name = "dtp_date_send"
        Me.dtp_date_send.Size = New System.Drawing.Size(116, 23)
        Me.dtp_date_send.TabIndex = 9
        '
        'cbo_document
        '
        Me.cbo_document.FormattingEnabled = True
        Me.cbo_document.Location = New System.Drawing.Point(436, 100)
        Me.cbo_document.Name = "cbo_document"
        Me.cbo_document.Size = New System.Drawing.Size(232, 26)
        Me.cbo_document.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "ใบงานแถลงบัญชี"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(259, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "รายละเอียด"
        '
        'Dtgv_Accounting
        '
        Me.Dtgv_Accounting.AllowUserToAddRows = False
        Me.Dtgv_Accounting.AllowUserToDeleteRows = False
        Me.Dtgv_Accounting.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.Dtgv_Accounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_Accounting.Location = New System.Drawing.Point(3, 3)
        Me.Dtgv_Accounting.Name = "Dtgv_Accounting"
        Me.Dtgv_Accounting.ReadOnly = True
        Me.Dtgv_Accounting.RowHeadersVisible = False
        Me.Dtgv_Accounting.Size = New System.Drawing.Size(672, 220)
        Me.Dtgv_Accounting.TabIndex = 131
        '
        'cbo_owner
        '
        Me.cbo_owner.FormattingEnabled = True
        Me.cbo_owner.Location = New System.Drawing.Point(114, 22)
        Me.cbo_owner.Name = "cbo_owner"
        Me.cbo_owner.Size = New System.Drawing.Size(158, 26)
        Me.cbo_owner.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 18)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "PRODUCT"
        '
        'cbo_detail
        '
        Me.cbo_detail.FormattingEnabled = True
        Me.cbo_detail.Location = New System.Drawing.Point(327, 214)
        Me.cbo_detail.Name = "cbo_detail"
        Me.cbo_detail.Size = New System.Drawing.Size(341, 26)
        Me.cbo_detail.TabIndex = 17
        '
        'cbo_waning
        '
        Me.cbo_waning.ForeColor = System.Drawing.Color.Red
        Me.cbo_waning.FormattingEnabled = True
        Me.cbo_waning.Location = New System.Drawing.Point(558, 73)
        Me.cbo_waning.Name = "cbo_waning"
        Me.cbo_waning.Size = New System.Drawing.Size(110, 26)
        Me.cbo_waning.TabIndex = 14
        '
        'txt_detail
        '
        Me.txt_detail.ForeColor = System.Drawing.Color.Red
        Me.txt_detail.Location = New System.Drawing.Point(434, 132)
        Me.txt_detail.Multiline = True
        Me.txt_detail.Name = "txt_detail"
        Me.txt_detail.Size = New System.Drawing.Size(234, 76)
        Me.txt_detail.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "หมายเหตุ"
        '
        'Dtgv_Tracking
        '
        Me.Dtgv_Tracking.AllowUserToAddRows = False
        Me.Dtgv_Tracking.AllowUserToDeleteRows = False
        Me.Dtgv_Tracking.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dtgv_Tracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_Tracking.GridColor = System.Drawing.SystemColors.ControlText
        Me.Dtgv_Tracking.Location = New System.Drawing.Point(3, 3)
        Me.Dtgv_Tracking.Name = "Dtgv_Tracking"
        Me.Dtgv_Tracking.ReadOnly = True
        Me.Dtgv_Tracking.RowHeadersVisible = False
        Me.Dtgv_Tracking.Size = New System.Drawing.Size(672, 220)
        Me.Dtgv_Tracking.TabIndex = 136
        '
        'cmd_search
        '
        Me.cmd_search.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_search.Image = Global.SCANDB.My.Resources.Resources.folder_explore
        Me.cmd_search.Location = New System.Drawing.Point(8, 22)
        Me.cmd_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(144, 29)
        Me.cmd_search.TabIndex = 137
        Me.cmd_search.Text = "ค้นหาข้อมูลตรวจสำนวน"
        Me.cmd_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_search.UseVisualStyleBackColor = False
        '
        'cmd_clear
        '
        Me.cmd_clear.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_clear.Image = Global.SCANDB.My.Resources.Resources.Actions_edit_rename_icon24x24
        Me.cmd_clear.Location = New System.Drawing.Point(8, 200)
        Me.cmd_clear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(144, 29)
        Me.cmd_clear.TabIndex = 140
        Me.cmd_clear.Text = "เคลียข้อมูล"
        Me.cmd_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_clear.UseVisualStyleBackColor = False
        '
        'chk_datetracking
        '
        Me.chk_datetracking.AutoSize = True
        Me.chk_datetracking.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datetracking.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datetracking.Location = New System.Drawing.Point(327, 51)
        Me.chk_datetracking.Name = "chk_datetracking"
        Me.chk_datetracking.Size = New System.Drawing.Size(103, 22)
        Me.chk_datetracking.TabIndex = 12
        Me.chk_datetracking.Text = "วันที่ในใบคำร้อง"
        Me.chk_datetracking.UseVisualStyleBackColor = True
        '
        'dtp_date_verify
        '
        Me.dtp_date_verify.CustomFormat = ""
        Me.dtp_date_verify.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_verify.Location = New System.Drawing.Point(436, 49)
        Me.dtp_date_verify.Name = "dtp_date_verify"
        Me.dtp_date_verify.Size = New System.Drawing.Size(116, 23)
        Me.dtp_date_verify.TabIndex = 13
        '
        'Lbl_Tracking
        '
        Me.Lbl_Tracking.AutoSize = True
        Me.Lbl_Tracking.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Tracking.Location = New System.Drawing.Point(0, 226)
        Me.Lbl_Tracking.Name = "Lbl_Tracking"
        Me.Lbl_Tracking.Size = New System.Drawing.Size(94, 18)
        Me.Lbl_Tracking.TabIndex = 145
        Me.Lbl_Tracking.Text = "ผลลัพธ์การค้นหา"
        '
        'Lbl_Accounting
        '
        Me.Lbl_Accounting.AutoSize = True
        Me.Lbl_Accounting.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Accounting.Location = New System.Drawing.Point(0, 226)
        Me.Lbl_Accounting.Name = "Lbl_Accounting"
        Me.Lbl_Accounting.Size = New System.Drawing.Size(94, 18)
        Me.Lbl_Accounting.TabIndex = 146
        Me.Lbl_Accounting.Text = "ผลลัพธ์การค้นหา"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txt_Account)
        Me.GroupBox1.Controls.Add(Me.Txt_tkmoney)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtp_date_work)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_cusname)
        Me.GroupBox1.Controls.Add(Me.txt_cusid)
        Me.GroupBox1.Controls.Add(Me.chk_datetracking)
        Me.GroupBox1.Controls.Add(Me.txt_court)
        Me.GroupBox1.Controls.Add(Me.dtp_date_verify)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_red)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbo_empexe)
        Me.GroupBox1.Controls.Add(Me.txt_detail)
        Me.GroupBox1.Controls.Add(Me.dtp_date_send)
        Me.GroupBox1.Controls.Add(Me.cbo_waning)
        Me.GroupBox1.Controls.Add(Me.chk_datesend)
        Me.GroupBox1.Controls.Add(Me.cbo_detail)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbo_owner)
        Me.GroupBox1.Controls.Add(Me.cbo_document)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 345)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 252)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลตรวจสำนวน"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 18)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "เลขที่สัญญา"
        '
        'Txt_Account
        '
        Me.Txt_Account.Location = New System.Drawing.Point(114, 76)
        Me.Txt_Account.Name = "Txt_Account"
        Me.Txt_Account.Size = New System.Drawing.Size(158, 23)
        Me.Txt_Account.TabIndex = 5
        '
        'Txt_tkmoney
        '
        Me.Txt_tkmoney.Location = New System.Drawing.Point(114, 185)
        Me.Txt_tkmoney.Name = "Txt_tkmoney"
        Me.Txt_tkmoney.Size = New System.Drawing.Size(158, 23)
        Me.Txt_tkmoney.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 18)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "ตรวจสำนวนพบเงิน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "เดือนที่ลงข้อมูล"
        '
        'dtp_date_work
        '
        Me.dtp_date_work.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_work.Location = New System.Drawing.Point(114, 214)
        Me.dtp_date_work.Name = "dtp_date_work"
        Me.dtp_date_work.Size = New System.Drawing.Size(116, 23)
        Me.dtp_date_work.TabIndex = 10
        '
        'cmd_filter
        '
        Me.cmd_filter.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_filter.Image = Global.SCANDB.My.Resources.Resources.filter_icon16x16
        Me.cmd_filter.Location = New System.Drawing.Point(9, 127)
        Me.cmd_filter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_filter.Name = "cmd_filter"
        Me.cmd_filter.Size = New System.Drawing.Size(144, 29)
        Me.cmd_filter.TabIndex = 148
        Me.cmd_filter.Text = "กรองข้อมูลพนักงาน"
        Me.cmd_filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_filter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_filter.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 66)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(686, 273)
        Me.TabControl1.TabIndex = 149
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Lbl_Primary)
        Me.TabPage1.Controls.Add(Me.Dtgv_Tracking)
        Me.TabPage1.Controls.Add(Me.Lbl_Tracking)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(678, 247)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ข้อมูลใบคำร้องขอตรวจสำนวน"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Lbl_Primary
        '
        Me.Lbl_Primary.AutoSize = True
        Me.Lbl_Primary.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Primary.Location = New System.Drawing.Point(640, 226)
        Me.Lbl_Primary.Name = "Lbl_Primary"
        Me.Lbl_Primary.Size = New System.Drawing.Size(32, 18)
        Me.Lbl_Primary.TabIndex = 148
        Me.Lbl_Primary.Text = "PK?"
        Me.Lbl_Primary.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Dtgv_Accounting)
        Me.TabPage2.Controls.Add(Me.Lbl_Accounting)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(678, 247)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ข้อมูลส่งแถลงบัญชี"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Cmd_LinkDatabase
        '
        Me.Cmd_LinkDatabase.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_LinkDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_LinkDatabase.Image = Global.SCANDB.My.Resources.Resources.table_lightning
        Me.Cmd_LinkDatabase.Location = New System.Drawing.Point(8, 57)
        Me.Cmd_LinkDatabase.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cmd_LinkDatabase.Name = "Cmd_LinkDatabase"
        Me.Cmd_LinkDatabase.Size = New System.Drawing.Size(144, 29)
        Me.Cmd_LinkDatabase.TabIndex = 150
        Me.Cmd_LinkDatabase.Text = "ลิ้งค์ข้อมูลจากระบบอื่น"
        Me.Cmd_LinkDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_LinkDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cmd_LinkDatabase.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cmd_LinkDatabase)
        Me.GroupBox2.Controls.Add(Me.cmd_links)
        Me.GroupBox2.Controls.Add(Me.cmd_search)
        Me.GroupBox2.Controls.Add(Me.cmd_filter)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(705, 345)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(159, 252)
        Me.GroupBox2.TabIndex = 151
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ฟังชั่นค้นหาข้อมูล"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cmd_delete)
        Me.GroupBox3.Controls.Add(Me.Cmd_update)
        Me.GroupBox3.Controls.Add(Me.cmd_clear)
        Me.GroupBox3.Controls.Add(Me.cmd_save)
        Me.GroupBox3.Controls.Add(Me.cmd_edit)
        Me.GroupBox3.Controls.Add(Me.cmd_cancel)
        Me.GroupBox3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(705, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(159, 273)
        Me.GroupBox3.TabIndex = 152
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "แก้ไข/เพิ่ม/อัพลบข้อมูล"
        '
        'Cmd_delete
        '
        Me.Cmd_delete.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_delete.Image = Global.SCANDB.My.Resources.Resources.delete1
        Me.Cmd_delete.Location = New System.Drawing.Point(8, 95)
        Me.Cmd_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cmd_delete.Name = "Cmd_delete"
        Me.Cmd_delete.Size = New System.Drawing.Size(144, 29)
        Me.Cmd_delete.TabIndex = 142
        Me.Cmd_delete.Text = "ลบข้อมูล"
        Me.Cmd_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cmd_delete.UseVisualStyleBackColor = False
        '
        'Cmd_update
        '
        Me.Cmd_update.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_update.Image = Global.SCANDB.My.Resources.Resources.application_form_edit
        Me.Cmd_update.Location = New System.Drawing.Point(7, 60)
        Me.Cmd_update.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cmd_update.Name = "Cmd_update"
        Me.Cmd_update.Size = New System.Drawing.Size(144, 29)
        Me.Cmd_update.TabIndex = 141
        Me.Cmd_update.Text = "อัพเดตข้อมูล"
        Me.Cmd_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cmd_update.UseVisualStyleBackColor = False
        '
        'Group_search
        '
        Me.Group_search.Controls.Add(Me.Cmd_find)
        Me.Group_search.Controls.Add(Me.txt_find)
        Me.Group_search.Controls.Add(Me.Label6)
        Me.Group_search.Controls.Add(Me.cbo_type_find)
        Me.Group_search.Controls.Add(Me.Label11)
        Me.Group_search.Location = New System.Drawing.Point(13, 3)
        Me.Group_search.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Group_search.Name = "Group_search"
        Me.Group_search.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Group_search.Size = New System.Drawing.Size(851, 57)
        Me.Group_search.TabIndex = 153
        Me.Group_search.TabStop = False
        '
        'Cmd_find
        '
        Me.Cmd_find.BackColor = System.Drawing.Color.White
        Me.Cmd_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_find.Image = Global.SCANDB.My.Resources.Resources.Find_16x16
        Me.Cmd_find.Location = New System.Drawing.Point(700, 16)
        Me.Cmd_find.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Cmd_find.Name = "Cmd_find"
        Me.Cmd_find.Size = New System.Drawing.Size(144, 29)
        Me.Cmd_find.TabIndex = 2
        Me.Cmd_find.Text = "ค้นหา"
        Me.Cmd_find.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cmd_find.UseVisualStyleBackColor = False
        '
        'txt_find
        '
        Me.txt_find.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_find.Location = New System.Drawing.Point(434, 20)
        Me.txt_find.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txt_find.Name = "txt_find"
        Me.txt_find.Size = New System.Drawing.Size(222, 23)
        Me.txt_find.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ข้อมูลที่ต้องการค้นหา :"
        '
        'cbo_type_find
        '
        Me.cbo_type_find.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_type_find.FormattingEnabled = True
        Me.cbo_type_find.Location = New System.Drawing.Point(122, 17)
        Me.cbo_type_find.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.cbo_type_find.Name = "cbo_type_find"
        Me.cbo_type_find.Size = New System.Drawing.Size(181, 26)
        Me.cbo_type_find.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 20)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ค้นหาข้อมูลจาก :"
        '
        'FrmTracking
        '
        Me.AcceptButton = Me.cmd_links
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(1004, 725)
        Me.Controls.Add(Me.Group_search)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTracking"
        Me.Text = "เพิ่มข้อมูลตรวจสำนวน"
        CType(Me.Dtgv_Accounting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtgv_Tracking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Group_search.ResumeLayout(False)
        Me.Group_search.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_links As Button
    Friend WithEvents cmd_edit As Button
    Friend WithEvents cmd_cancel As Button
    Friend WithEvents cmd_save As Button
    Friend WithEvents txt_red As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_court As TextBox
    Friend WithEvents txt_cusid As TextBox
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbo_empexe As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chk_datesend As CheckBox
    Friend WithEvents dtp_date_send As DateTimePicker
    Friend WithEvents cbo_document As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Dtgv_Accounting As DataGridView
    Friend WithEvents cbo_owner As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbo_detail As ComboBox
    Friend WithEvents cbo_waning As ComboBox
    Friend WithEvents txt_detail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Dtgv_Tracking As DataGridView
    Friend WithEvents cmd_search As Button
    Friend WithEvents cmd_clear As Button
    Friend WithEvents chk_datetracking As CheckBox
    Friend WithEvents dtp_date_verify As DateTimePicker
    Friend WithEvents Lbl_Tracking As Label
    Friend WithEvents Lbl_Accounting As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_filter As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_date_work As DateTimePicker
    Friend WithEvents Txt_tkmoney As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_Account As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Cmd_LinkDatabase As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Cmd_delete As Button
    Friend WithEvents Cmd_update As Button
    Friend WithEvents Group_search As GroupBox
    Friend WithEvents Cmd_find As Button
    Friend WithEvents txt_find As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_type_find As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Lbl_Primary As Label
End Class
