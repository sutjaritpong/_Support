<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmreportexe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmreportexe))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgv_reportsm = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_start = New System.Windows.Forms.DateTimePicker()
        Me.date_end = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_bank = New System.Windows.Forms.ComboBox()
        Me.cbo_hubs = New System.Windows.Forms.ComboBox()
        Me.cbo_name = New System.Windows.Forms.ComboBox()
        Me.cmd_export = New System.Windows.Forms.Button()
        Me.cmd_view = New System.Windows.Forms.Button()
        Me.Chkb_fullname = New System.Windows.Forms.CheckBox()
        Me.chkb_date = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_countreport = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_statuspb = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.Pb_Export = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cmd_alldata = New System.Windows.Forms.Button()
        Me.chkb_condition = New System.Windows.Forms.CheckBox()
        CType(Me.dtgv_reportsm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(360, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "รายงาน แถลงบัญชี-รับจ่าย"
        '
        'dtgv_reportsm
        '
        Me.dtgv_reportsm.AllowUserToAddRows = False
        Me.dtgv_reportsm.AllowUserToDeleteRows = False
        Me.dtgv_reportsm.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dtgv_reportsm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_reportsm.Location = New System.Drawing.Point(12, 293)
        Me.dtgv_reportsm.Name = "dtgv_reportsm"
        Me.dtgv_reportsm.ReadOnly = True
        Me.dtgv_reportsm.RowHeadersVisible = False
        Me.dtgv_reportsm.Size = New System.Drawing.Size(984, 381)
        Me.dtgv_reportsm.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(366, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ธนาคาร"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(327, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ศูนย์ประสานงาน"
        '
        'date_start
        '
        Me.date_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_start.Location = New System.Drawing.Point(421, 149)
        Me.date_start.Name = "date_start"
        Me.date_start.Size = New System.Drawing.Size(98, 20)
        Me.date_start.TabIndex = 8
        '
        'date_end
        '
        Me.date_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_end.Location = New System.Drawing.Point(550, 149)
        Me.date_end.Name = "date_end"
        Me.date_end.Size = New System.Drawing.Size(98, 20)
        Me.date_end.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(525, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "-"
        '
        'cbo_bank
        '
        Me.cbo_bank.FormattingEnabled = True
        Me.cbo_bank.Location = New System.Drawing.Point(420, 64)
        Me.cbo_bank.Name = "cbo_bank"
        Me.cbo_bank.Size = New System.Drawing.Size(227, 21)
        Me.cbo_bank.TabIndex = 11
        '
        'cbo_hubs
        '
        Me.cbo_hubs.FormattingEnabled = True
        Me.cbo_hubs.Location = New System.Drawing.Point(420, 95)
        Me.cbo_hubs.Name = "cbo_hubs"
        Me.cbo_hubs.Size = New System.Drawing.Size(227, 21)
        Me.cbo_hubs.TabIndex = 12
        '
        'cbo_name
        '
        Me.cbo_name.FormattingEnabled = True
        Me.cbo_name.Location = New System.Drawing.Point(420, 122)
        Me.cbo_name.Name = "cbo_name"
        Me.cbo_name.Size = New System.Drawing.Size(227, 21)
        Me.cbo_name.TabIndex = 14
        '
        'cmd_export
        '
        Me.cmd_export.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_export.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_export.ForeColor = System.Drawing.Color.Blue
        Me.cmd_export.Image = Global.SCANDB.My.Resources.Resources.page_white_excel
        Me.cmd_export.Location = New System.Drawing.Point(548, 190)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(142, 35)
        Me.cmd_export.TabIndex = 17
        Me.cmd_export.Text = "ส่งออกข้อมูล"
        Me.cmd_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_export.UseVisualStyleBackColor = False
        '
        'cmd_view
        '
        Me.cmd_view.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_view.ForeColor = System.Drawing.Color.Blue
        Me.cmd_view.Image = Global.SCANDB.My.Resources.Resources.table_add
        Me.cmd_view.Location = New System.Drawing.Point(375, 190)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(142, 35)
        Me.cmd_view.TabIndex = 16
        Me.cmd_view.Text = "แสดงข้อมูลตามเงื่อนไข"
        Me.cmd_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_view.UseVisualStyleBackColor = False
        '
        'Chkb_fullname
        '
        Me.Chkb_fullname.AutoSize = True
        Me.Chkb_fullname.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Chkb_fullname.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkb_fullname.ForeColor = System.Drawing.Color.Blue
        Me.Chkb_fullname.Location = New System.Drawing.Point(329, 122)
        Me.Chkb_fullname.Name = "Chkb_fullname"
        Me.Chkb_fullname.Size = New System.Drawing.Size(85, 22)
        Me.Chkb_fullname.TabIndex = 18
        Me.Chkb_fullname.Text = "ชื่อพนักงาน"
        Me.Chkb_fullname.UseVisualStyleBackColor = True
        '
        'chkb_date
        '
        Me.chkb_date.AutoSize = True
        Me.chkb_date.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkb_date.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkb_date.ForeColor = System.Drawing.Color.Blue
        Me.chkb_date.Location = New System.Drawing.Point(325, 149)
        Me.chkb_date.Name = "chkb_date"
        Me.chkb_date.Size = New System.Drawing.Size(90, 22)
        Me.chkb_date.TabIndex = 19
        Me.chkb_date.Text = "วันที่ส่งใบงาน"
        Me.chkb_date.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(850, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "จำนวนข้อมูล"
        '
        'lbl_countreport
        '
        Me.lbl_countreport.AutoSize = True
        Me.lbl_countreport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_countreport.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_countreport.Location = New System.Drawing.Point(930, 270)
        Me.lbl_countreport.Name = "lbl_countreport"
        Me.lbl_countreport.Size = New System.Drawing.Size(18, 20)
        Me.lbl_countreport.TabIndex = 21
        Me.lbl_countreport.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(967, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "แถว"
        '
        'lbl_statuspb
        '
        Me.lbl_statuspb.AutoSize = True
        Me.lbl_statuspb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_statuspb.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statuspb.Location = New System.Drawing.Point(12, 270)
        Me.lbl_statuspb.Name = "lbl_statuspb"
        Me.lbl_statuspb.Size = New System.Drawing.Size(42, 20)
        Me.lbl_statuspb.TabIndex = 23
        Me.lbl_statuspb.Text = "0 / 0"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_status.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(77, 270)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(42, 20)
        Me.lbl_status.TabIndex = 26
        Me.lbl_status.Text = "สถานะ"
        '
        'Pb_Export
        '
        Me.Pb_Export.BackColor = System.Drawing.SystemColors.Window
        Me.Pb_Export.Location = New System.Drawing.Point(138, 267)
        Me.Pb_Export.Name = "Pb_Export"
        Me.Pb_Export.Size = New System.Drawing.Size(182, 23)
        Me.Pb_Export.TabIndex = 27
        '
        'cmd_alldata
        '
        Me.cmd_alldata.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_alldata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_alldata.ForeColor = System.Drawing.Color.Blue
        Me.cmd_alldata.Image = Global.SCANDB.My.Resources.Resources.folder_explore
        Me.cmd_alldata.Location = New System.Drawing.Point(189, 24)
        Me.cmd_alldata.Name = "cmd_alldata"
        Me.cmd_alldata.Size = New System.Drawing.Size(109, 35)
        Me.cmd_alldata.TabIndex = 28
        Me.cmd_alldata.Text = "ดูข้อมูลท้ังหมด"
        Me.cmd_alldata.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_alldata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_alldata.UseVisualStyleBackColor = False
        '
        'chkb_condition
        '
        Me.chkb_condition.AutoSize = True
        Me.chkb_condition.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkb_condition.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkb_condition.ForeColor = System.Drawing.Color.Blue
        Me.chkb_condition.Location = New System.Drawing.Point(201, 63)
        Me.chkb_condition.Name = "chkb_condition"
        Me.chkb_condition.Size = New System.Drawing.Size(97, 22)
        Me.chkb_condition.TabIndex = 29
        Me.chkb_condition.Text = "กำหนดเงื่อนไข"
        Me.chkb_condition.UseVisualStyleBackColor = True
        '
        'Frmreportexe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.chkb_condition)
        Me.Controls.Add(Me.cmd_alldata)
        Me.Controls.Add(Me.Pb_Export)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.lbl_statuspb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_countreport)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkb_date)
        Me.Controls.Add(Me.Chkb_fullname)
        Me.Controls.Add(Me.cmd_export)
        Me.Controls.Add(Me.cmd_view)
        Me.Controls.Add(Me.cbo_name)
        Me.Controls.Add(Me.cbo_hubs)
        Me.Controls.Add(Me.cbo_bank)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date_end)
        Me.Controls.Add(Me.date_start)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgv_reportsm)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmreportexe"
        Me.Text = "รายงานแถลงบัญชี"
        CType(Me.dtgv_reportsm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgv_reportsm As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents date_start As DateTimePicker
    Friend WithEvents date_end As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_bank As ComboBox
    Friend WithEvents cbo_hubs As ComboBox
    Friend WithEvents cbo_name As ComboBox
    Friend WithEvents cmd_view As Button
    Friend WithEvents cmd_export As Button
    Friend WithEvents Chkb_fullname As CheckBox
    Friend WithEvents chkb_date As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_countreport As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_statuspb As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents Pb_Export As ProgressBar
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmd_alldata As Button
    Friend WithEvents chkb_condition As CheckBox
End Class
