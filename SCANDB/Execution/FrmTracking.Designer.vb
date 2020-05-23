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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmd_find = New System.Windows.Forms.Button()
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
        Me.chk_datetracking = New System.Windows.Forms.CheckBox()
        Me.dtp_date_send = New System.Windows.Forms.DateTimePicker()
        Me.dtp_date_verify = New System.Windows.Forms.DateTimePicker()
        Me.cbo_document = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtgv_tracking = New System.Windows.Forms.DataGridView()
        Me.cbo_owner = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_detail = New System.Windows.Forms.ComboBox()
        Me.cbo_waning = New System.Windows.Forms.ComboBox()
        CType(Me.dtgv_tracking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(380, 44)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "เพิ่มข้อมูลใบงาน ตรวจสำนวน"
        '
        'cmd_find
        '
        Me.cmd_find.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_find.Image = Global.SCANDB.My.Resources.Resources.search
        Me.cmd_find.Location = New System.Drawing.Point(24, 299)
        Me.cmd_find.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_find.Name = "cmd_find"
        Me.cmd_find.Size = New System.Drawing.Size(133, 29)
        Me.cmd_find.TabIndex = 2
        Me.cmd_find.Text = "เลขที่บัตรประชาชน"
        Me.cmd_find.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_find.UseVisualStyleBackColor = False
        '
        'cmd_edit
        '
        Me.cmd_edit.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_edit.Image = Global.SCANDB.My.Resources.Resources.edit_icon16x16
        Me.cmd_edit.Location = New System.Drawing.Point(165, 299)
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
        Me.cmd_cancel.Location = New System.Drawing.Point(306, 299)
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
        Me.cmd_save.Location = New System.Drawing.Point(447, 299)
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
        Me.txt_red.Location = New System.Drawing.Point(140, 142)
        Me.txt_red.Name = "txt_red"
        Me.txt_red.Size = New System.Drawing.Size(158, 20)
        Me.txt_red.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(103, 168)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 20)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "ศาล"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(73, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 20)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "เลขคดีแดง"
        '
        'txt_court
        '
        Me.txt_court.Location = New System.Drawing.Point(140, 168)
        Me.txt_court.Name = "txt_court"
        Me.txt_court.Size = New System.Drawing.Size(158, 20)
        Me.txt_court.TabIndex = 6
        '
        'txt_cusid
        '
        Me.txt_cusid.Location = New System.Drawing.Point(140, 90)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(158, 20)
        Me.txt_cusid.TabIndex = 1
        '
        'txt_cusname
        '
        Me.txt_cusname.Location = New System.Drawing.Point(140, 116)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(158, 20)
        Me.txt_cusname.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(39, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 20)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "เลขบัตรประชาชน"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(62, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 111
        Me.Label15.Text = "ชื่อ-นามสกุล"
        '
        'cbo_empexe
        '
        Me.cbo_empexe.FormattingEnabled = True
        Me.cbo_empexe.Location = New System.Drawing.Point(511, 62)
        Me.cbo_empexe.Name = "cbo_empexe"
        Me.cbo_empexe.Size = New System.Drawing.Size(232, 21)
        Me.cbo_empexe.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "เจ้าหน้าที่บังคับคดี"
        '
        'chk_datesend
        '
        Me.chk_datesend.AutoSize = True
        Me.chk_datesend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datesend.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datesend.Location = New System.Drawing.Point(355, 114)
        Me.chk_datesend.Name = "chk_datesend"
        Me.chk_datesend.Size = New System.Drawing.Size(150, 22)
        Me.chk_datesend.TabIndex = 124
        Me.chk_datesend.Text = "วันที่ออกใบงานแถลงบัญชี"
        Me.chk_datesend.UseVisualStyleBackColor = True
        '
        'chk_datetracking
        '
        Me.chk_datetracking.AutoSize = True
        Me.chk_datetracking.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datetracking.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datetracking.Location = New System.Drawing.Point(383, 88)
        Me.chk_datetracking.Name = "chk_datetracking"
        Me.chk_datetracking.Size = New System.Drawing.Size(122, 22)
        Me.chk_datetracking.TabIndex = 123
        Me.chk_datetracking.Text = "วันที่ไปตรวจสำนวน"
        Me.chk_datetracking.UseVisualStyleBackColor = True
        '
        'dtp_date_send
        '
        Me.dtp_date_send.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_send.Location = New System.Drawing.Point(511, 115)
        Me.dtp_date_send.Name = "dtp_date_send"
        Me.dtp_date_send.Size = New System.Drawing.Size(116, 20)
        Me.dtp_date_send.TabIndex = 9
        '
        'dtp_date_verify
        '
        Me.dtp_date_verify.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_verify.Location = New System.Drawing.Point(511, 89)
        Me.dtp_date_verify.Name = "dtp_date_verify"
        Me.dtp_date_verify.Size = New System.Drawing.Size(116, 20)
        Me.dtp_date_verify.TabIndex = 8
        '
        'cbo_document
        '
        Me.cbo_document.FormattingEnabled = True
        Me.cbo_document.Location = New System.Drawing.Point(511, 141)
        Me.cbo_document.Name = "cbo_document"
        Me.cbo_document.Size = New System.Drawing.Size(232, 21)
        Me.cbo_document.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(394, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "ไม่มีใบงานแถลงบัญชี"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(441, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "รายละเอียด"
        '
        'dtgv_tracking
        '
        Me.dtgv_tracking.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.dtgv_tracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_tracking.Location = New System.Drawing.Point(22, 334)
        Me.dtgv_tracking.Name = "dtgv_tracking"
        Me.dtgv_tracking.Size = New System.Drawing.Size(558, 200)
        Me.dtgv_tracking.TabIndex = 131
        '
        'cbo_owner
        '
        Me.cbo_owner.FormattingEnabled = True
        Me.cbo_owner.Location = New System.Drawing.Point(140, 65)
        Me.cbo_owner.Name = "cbo_owner"
        Me.cbo_owner.Size = New System.Drawing.Size(158, 21)
        Me.cbo_owner.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(57, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 20)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "PRODUCT"
        '
        'cbo_detail
        '
        Me.cbo_detail.FormattingEnabled = True
        Me.cbo_detail.Location = New System.Drawing.Point(511, 168)
        Me.cbo_detail.Name = "cbo_detail"
        Me.cbo_detail.Size = New System.Drawing.Size(232, 21)
        Me.cbo_detail.TabIndex = 12
        '
        'cbo_waning
        '
        Me.cbo_waning.ForeColor = System.Drawing.Color.Red
        Me.cbo_waning.FormattingEnabled = True
        Me.cbo_waning.Location = New System.Drawing.Point(633, 114)
        Me.cbo_waning.Name = "cbo_waning"
        Me.cbo_waning.Size = New System.Drawing.Size(160, 21)
        Me.cbo_waning.TabIndex = 133
        '
        'FrmTracking
        '
        Me.AcceptButton = Me.cmd_save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(1004, 725)
        Me.Controls.Add(Me.cbo_waning)
        Me.Controls.Add(Me.cbo_detail)
        Me.Controls.Add(Me.cbo_owner)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtgv_tracking)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbo_document)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_datesend)
        Me.Controls.Add(Me.chk_datetracking)
        Me.Controls.Add(Me.dtp_date_send)
        Me.Controls.Add(Me.dtp_date_verify)
        Me.Controls.Add(Me.cbo_empexe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_red)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_court)
        Me.Controls.Add(Me.txt_cusid)
        Me.Controls.Add(Me.txt_cusname)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmd_find)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.Label8)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTracking"
        Me.Text = "เพิ่มข้อมูลตรวจสำนวน"
        CType(Me.dtgv_tracking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents cmd_find As Button
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
    Friend WithEvents chk_datetracking As CheckBox
    Friend WithEvents dtp_date_send As DateTimePicker
    Friend WithEvents dtp_date_verify As DateTimePicker
    Friend WithEvents cbo_document As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtgv_tracking As DataGridView
    Friend WithEvents cbo_owner As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbo_detail As ComboBox
    Friend WithEvents cbo_waning As ComboBox
End Class
