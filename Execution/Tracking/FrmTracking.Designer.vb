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
        Me.dtgv_tracking = New System.Windows.Forms.DataGridView()
        Me.cbo_owner = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_detail = New System.Windows.Forms.ComboBox()
        Me.cbo_waning = New System.Windows.Forms.ComboBox()
        Me.txt_detail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgv_invalid = New System.Windows.Forms.DataGridView()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.chk_datetracking = New System.Windows.Forms.CheckBox()
        Me.dtp_date_verify = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_invalid = New System.Windows.Forms.Label()
        Me.lbl_tracking = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_date_work = New System.Windows.Forms.DateTimePicker()
        Me.cmd_filter = New System.Windows.Forms.Button()
        CType(Me.dtgv_tracking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgv_invalid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_links
        '
        Me.cmd_links.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_links.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_links.Image = Global.SCANDB.My.Resources.Resources.search
        Me.cmd_links.Location = New System.Drawing.Point(16, 583)
        Me.cmd_links.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_links.Name = "cmd_links"
        Me.cmd_links.Size = New System.Drawing.Size(133, 29)
        Me.cmd_links.TabIndex = 2
        Me.cmd_links.Text = "แสดงข้อมูล"
        Me.cmd_links.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_links.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_links.UseVisualStyleBackColor = False
        '
        'cmd_edit
        '
        Me.cmd_edit.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_edit.Image = Global.SCANDB.My.Resources.Resources.edit_icon16x16
        Me.cmd_edit.Location = New System.Drawing.Point(157, 583)
        Me.cmd_edit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(133, 29)
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
        Me.cmd_cancel.Location = New System.Drawing.Point(300, 583)
        Me.cmd_cancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(133, 29)
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
        Me.cmd_save.Location = New System.Drawing.Point(443, 583)
        Me.cmd_save.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(133, 29)
        Me.cmd_save.TabIndex = 14
        Me.cmd_save.Text = "บันทึก"
        Me.cmd_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_save.UseVisualStyleBackColor = False
        '
        'txt_red
        '
        Me.txt_red.ForeColor = System.Drawing.Color.Red
        Me.txt_red.Location = New System.Drawing.Point(114, 101)
        Me.txt_red.Name = "txt_red"
        Me.txt_red.Size = New System.Drawing.Size(158, 23)
        Me.txt_red.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(77, 130)
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
        Me.Label12.Location = New System.Drawing.Point(47, 101)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 18)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "เลขคดีแดง"
        '
        'txt_court
        '
        Me.txt_court.Location = New System.Drawing.Point(114, 127)
        Me.txt_court.Name = "txt_court"
        Me.txt_court.Size = New System.Drawing.Size(158, 23)
        Me.txt_court.TabIndex = 6
        '
        'txt_cusid
        '
        Me.txt_cusid.Location = New System.Drawing.Point(114, 49)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(158, 23)
        Me.txt_cusid.TabIndex = 1
        '
        'txt_cusname
        '
        Me.txt_cusname.Location = New System.Drawing.Point(114, 75)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(158, 23)
        Me.txt_cusname.TabIndex = 4
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
        Me.Label15.Location = New System.Drawing.Point(36, 75)
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
        Me.cbo_empexe.TabIndex = 7
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
        Me.cbo_document.TabIndex = 11
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
        Me.Label4.Location = New System.Drawing.Point(207, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "รายละเอียด"
        '
        'dtgv_tracking
        '
        Me.dtgv_tracking.AllowUserToAddRows = False
        Me.dtgv_tracking.AllowUserToDeleteRows = False
        Me.dtgv_tracking.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dtgv_tracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_tracking.Location = New System.Drawing.Point(18, 459)
        Me.dtgv_tracking.Name = "dtgv_tracking"
        Me.dtgv_tracking.ReadOnly = True
        Me.dtgv_tracking.RowHeadersVisible = False
        Me.dtgv_tracking.Size = New System.Drawing.Size(558, 118)
        Me.dtgv_tracking.TabIndex = 131
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
        Me.cbo_detail.Location = New System.Drawing.Point(277, 248)
        Me.cbo_detail.Name = "cbo_detail"
        Me.cbo_detail.Size = New System.Drawing.Size(391, 26)
        Me.cbo_detail.TabIndex = 12
        '
        'cbo_waning
        '
        Me.cbo_waning.ForeColor = System.Drawing.Color.Red
        Me.cbo_waning.FormattingEnabled = True
        Me.cbo_waning.Location = New System.Drawing.Point(558, 73)
        Me.cbo_waning.Name = "cbo_waning"
        Me.cbo_waning.Size = New System.Drawing.Size(110, 26)
        Me.cbo_waning.TabIndex = 133
        '
        'txt_detail
        '
        Me.txt_detail.ForeColor = System.Drawing.Color.Red
        Me.txt_detail.Location = New System.Drawing.Point(434, 132)
        Me.txt_detail.Multiline = True
        Me.txt_detail.Name = "txt_detail"
        Me.txt_detail.Size = New System.Drawing.Size(234, 110)
        Me.txt_detail.TabIndex = 134
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
        'dtgv_invalid
        '
        Me.dtgv_invalid.AllowUserToAddRows = False
        Me.dtgv_invalid.AllowUserToDeleteRows = False
        Me.dtgv_invalid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgv_invalid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_invalid.GridColor = System.Drawing.SystemColors.ControlText
        Me.dtgv_invalid.Location = New System.Drawing.Point(18, 315)
        Me.dtgv_invalid.Name = "dtgv_invalid"
        Me.dtgv_invalid.ReadOnly = True
        Me.dtgv_invalid.RowHeadersVisible = False
        Me.dtgv_invalid.Size = New System.Drawing.Size(558, 118)
        Me.dtgv_invalid.TabIndex = 136
        '
        'cmd_search
        '
        Me.cmd_search.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_search.Image = Global.SCANDB.My.Resources.Resources.folder_explore
        Me.cmd_search.Location = New System.Drawing.Point(157, 618)
        Me.cmd_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(133, 29)
        Me.cmd_search.TabIndex = 137
        Me.cmd_search.Text = "ค้นหาข้อมูล"
        Me.cmd_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_search.UseVisualStyleBackColor = False
        '
        'cmd_clear
        '
        Me.cmd_clear.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_clear.Image = Global.SCANDB.My.Resources.Resources.Actions_edit_rename_icon24x24
        Me.cmd_clear.Location = New System.Drawing.Point(18, 618)
        Me.cmd_clear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(133, 29)
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
        Me.chk_datetracking.TabIndex = 142
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
        Me.dtp_date_verify.TabIndex = 141
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "ข้อมูลใบคำร้อง"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 436)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 18)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "ข้อมูลส่งแถลงบัญชี"
        '
        'lbl_invalid
        '
        Me.lbl_invalid.AutoSize = True
        Me.lbl_invalid.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invalid.Location = New System.Drawing.Point(102, 292)
        Me.lbl_invalid.Name = "lbl_invalid"
        Me.lbl_invalid.Size = New System.Drawing.Size(94, 18)
        Me.lbl_invalid.TabIndex = 145
        Me.lbl_invalid.Text = "ผลลัพธ์การค้นหา"
        '
        'lbl_tracking
        '
        Me.lbl_tracking.AutoSize = True
        Me.lbl_tracking.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tracking.Location = New System.Drawing.Point(124, 436)
        Me.lbl_tracking.Name = "lbl_tracking"
        Me.lbl_tracking.Size = New System.Drawing.Size(94, 18)
        Me.lbl_tracking.TabIndex = 146
        Me.lbl_tracking.Text = "ผลลัพธ์การค้นหา"
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(21, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 286)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลตรวจสำนวน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "เดือนที่ลงข้อมูล"
        '
        'dtp_date_work
        '
        Me.dtp_date_work.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_work.Location = New System.Drawing.Point(114, 154)
        Me.dtp_date_work.Name = "dtp_date_work"
        Me.dtp_date_work.Size = New System.Drawing.Size(116, 23)
        Me.dtp_date_work.TabIndex = 143
        '
        'cmd_filter
        '
        Me.cmd_filter.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_filter.Image = Global.SCANDB.My.Resources.Resources.filter_icon16x16
        Me.cmd_filter.Location = New System.Drawing.Point(298, 618)
        Me.cmd_filter.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_filter.Name = "cmd_filter"
        Me.cmd_filter.Size = New System.Drawing.Size(133, 29)
        Me.cmd_filter.TabIndex = 148
        Me.cmd_filter.Text = "กรองข้อมูลพนักงาน"
        Me.cmd_filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_filter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_filter.UseVisualStyleBackColor = False
        '
        'FrmTracking
        '
        Me.AcceptButton = Me.cmd_links
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(1004, 725)
        Me.Controls.Add(Me.cmd_filter)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_tracking)
        Me.Controls.Add(Me.lbl_invalid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmd_search)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.dtgv_invalid)
        Me.Controls.Add(Me.dtgv_tracking)
        Me.Controls.Add(Me.cmd_links)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_save)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTracking"
        Me.Text = "เพิ่มข้อมูลตรวจสำนวน"
        CType(Me.dtgv_tracking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgv_invalid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents dtgv_tracking As DataGridView
    Friend WithEvents cbo_owner As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbo_detail As ComboBox
    Friend WithEvents cbo_waning As ComboBox
    Friend WithEvents txt_detail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgv_invalid As DataGridView
    Friend WithEvents cmd_search As Button
    Friend WithEvents cmd_clear As Button
    Friend WithEvents chk_datetracking As CheckBox
    Friend WithEvents dtp_date_verify As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_invalid As Label
    Friend WithEvents lbl_tracking As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_filter As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dtp_date_work As DateTimePicker
End Class
