<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogfileexe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogfileexe))
        Me.lbl_countdata = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_countdtgv = New System.Windows.Forms.Label()
        Me.DateTimeend = New System.Windows.Forms.DateTimePicker()
        Me.DateTimestart = New System.Windows.Forms.DateTimePicker()
        Me.cbo_where = New System.Windows.Forms.ComboBox()
        Me.txt_find = New System.Windows.Forms.TextBox()
        Me.dtgvlogfile = New System.Windows.Forms.DataGridView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_log_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_log_idcard = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_log_account = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_customer_user = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_log_fullname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_log_ip = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_log_pcname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_log_detail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmd_refresh = New System.Windows.Forms.Button()
        Me.cmd_find = New System.Windows.Forms.Button()
        Me.cmd_report = New System.Windows.Forms.Button()
        CType(Me.dtgvlogfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_countdata
        '
        Me.lbl_countdata.AutoSize = True
        Me.lbl_countdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_countdata.ForeColor = System.Drawing.Color.Blue
        Me.lbl_countdata.Location = New System.Drawing.Point(955, 146)
        Me.lbl_countdata.Name = "lbl_countdata"
        Me.lbl_countdata.Size = New System.Drawing.Size(44, 20)
        Me.lbl_countdata.TabIndex = 33
        Me.lbl_countdata.Text = "xxxxx"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(936, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "/"
        '
        'lbl_countdtgv
        '
        Me.lbl_countdtgv.AutoSize = True
        Me.lbl_countdtgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_countdtgv.ForeColor = System.Drawing.Color.Blue
        Me.lbl_countdtgv.Location = New System.Drawing.Point(886, 146)
        Me.lbl_countdtgv.Name = "lbl_countdtgv"
        Me.lbl_countdtgv.Size = New System.Drawing.Size(44, 20)
        Me.lbl_countdtgv.TabIndex = 31
        Me.lbl_countdtgv.Text = "xxxxx"
        '
        'DateTimeend
        '
        Me.DateTimeend.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeend.Location = New System.Drawing.Point(778, 17)
        Me.DateTimeend.Name = "DateTimeend"
        Me.DateTimeend.Size = New System.Drawing.Size(102, 22)
        Me.DateTimeend.TabIndex = 26
        '
        'DateTimestart
        '
        Me.DateTimestart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimestart.Location = New System.Drawing.Point(618, 19)
        Me.DateTimestart.Name = "DateTimestart"
        Me.DateTimestart.Size = New System.Drawing.Size(96, 22)
        Me.DateTimestart.TabIndex = 25
        '
        'cbo_where
        '
        Me.cbo_where.FormattingEnabled = True
        Me.cbo_where.Location = New System.Drawing.Point(106, 17)
        Me.cbo_where.Name = "cbo_where"
        Me.cbo_where.Size = New System.Drawing.Size(130, 24)
        Me.cbo_where.TabIndex = 23
        '
        'txt_find
        '
        Me.txt_find.BackColor = System.Drawing.SystemColors.Window
        Me.txt_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_find.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_find.Location = New System.Drawing.Point(345, 18)
        Me.txt_find.Name = "txt_find"
        Me.txt_find.Size = New System.Drawing.Size(204, 22)
        Me.txt_find.TabIndex = 20
        '
        'dtgvlogfile
        '
        Me.dtgvlogfile.AllowUserToAddRows = False
        Me.dtgvlogfile.AllowUserToDeleteRows = False
        Me.dtgvlogfile.BackgroundColor = System.Drawing.Color.White
        Me.dtgvlogfile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgvlogfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvlogfile.GridColor = System.Drawing.Color.Black
        Me.dtgvlogfile.Location = New System.Drawing.Point(15, 180)
        Me.dtgvlogfile.Name = "dtgvlogfile"
        Me.dtgvlogfile.ReadOnly = True
        Me.dtgvlogfile.RowHeadersVisible = False
        Me.dtgvlogfile.Size = New System.Drawing.Size(984, 537)
        Me.dtgvlogfile.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "วันที่ทำรายการ"
        '
        'dtp_log_date
        '
        Me.dtp_log_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_log_date.Location = New System.Drawing.Point(106, 17)
        Me.dtp_log_date.Name = "dtp_log_date"
        Me.dtp_log_date.Size = New System.Drawing.Size(104, 20)
        Me.dtp_log_date.TabIndex = 34
        '
        'txt_log_idcard
        '
        Me.txt_log_idcard.ForeColor = System.Drawing.Color.Blue
        Me.txt_log_idcard.Location = New System.Drawing.Point(106, 43)
        Me.txt_log_idcard.Name = "txt_log_idcard"
        Me.txt_log_idcard.Size = New System.Drawing.Size(140, 20)
        Me.txt_log_idcard.TabIndex = 104
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 18)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "เลขบัตรประชาชน"
        '
        'txt_log_account
        '
        Me.txt_log_account.ForeColor = System.Drawing.Color.Blue
        Me.txt_log_account.Location = New System.Drawing.Point(106, 69)
        Me.txt_log_account.Name = "txt_log_account"
        Me.txt_log_account.Size = New System.Drawing.Size(140, 20)
        Me.txt_log_account.TabIndex = 106
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "เลขที่สัญญา"
        '
        'txt_customer_user
        '
        Me.txt_customer_user.ForeColor = System.Drawing.Color.Blue
        Me.txt_customer_user.Location = New System.Drawing.Point(343, 18)
        Me.txt_customer_user.Name = "txt_customer_user"
        Me.txt_customer_user.Size = New System.Drawing.Size(140, 20)
        Me.txt_customer_user.TabIndex = 108
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(267, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "ชื่อบัญชีผู้ใช้"
        '
        'txt_log_fullname
        '
        Me.txt_log_fullname.ForeColor = System.Drawing.Color.Blue
        Me.txt_log_fullname.Location = New System.Drawing.Point(343, 44)
        Me.txt_log_fullname.Name = "txt_log_fullname"
        Me.txt_log_fullname.Size = New System.Drawing.Size(140, 20)
        Me.txt_log_fullname.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(267, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 18)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "ชื่อ-นามสกุล"
        '
        'txt_log_ip
        '
        Me.txt_log_ip.ForeColor = System.Drawing.Color.Red
        Me.txt_log_ip.Location = New System.Drawing.Point(343, 70)
        Me.txt_log_ip.Name = "txt_log_ip"
        Me.txt_log_ip.Size = New System.Drawing.Size(140, 20)
        Me.txt_log_ip.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(261, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 18)
        Me.Label9.TabIndex = 113
        Me.Label9.Text = "IP Address"
        '
        'txt_log_pcname
        '
        Me.txt_log_pcname.ForeColor = System.Drawing.Color.Blue
        Me.txt_log_pcname.Location = New System.Drawing.Point(580, 17)
        Me.txt_log_pcname.Name = "txt_log_pcname"
        Me.txt_log_pcname.Size = New System.Drawing.Size(156, 20)
        Me.txt_log_pcname.TabIndex = 114
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(505, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 18)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "PC Name"
        '
        'txt_log_detail
        '
        Me.txt_log_detail.ForeColor = System.Drawing.Color.Blue
        Me.txt_log_detail.Location = New System.Drawing.Point(580, 43)
        Me.txt_log_detail.Multiline = True
        Me.txt_log_detail.Name = "txt_log_detail"
        Me.txt_log_detail.Size = New System.Drawing.Size(275, 55)
        Me.txt_log_detail.TabIndex = 116
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(512, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "รายละเอียด"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(242, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 18)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "เงื่อนไขการค้นหา :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 18)
        Me.Label13.TabIndex = 119
        Me.Label13.Text = "หัวข้อการค้นหา :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(723, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 18)
        Me.Label14.TabIndex = 120
        Me.Label14.Text = "ถึงวันที่ :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(555, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 18)
        Me.Label15.TabIndex = 121
        Me.Label15.Text = "จากวันที่ :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimestart)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmd_find)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_find)
        Me.GroupBox1.Controls.Add(Me.cmd_report)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbo_where)
        Me.GroupBox1.Controls.Add(Me.DateTimeend)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(980, 49)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหาข้อมูล"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_log_account)
        Me.GroupBox2.Controls.Add(Me.txt_log_detail)
        Me.GroupBox2.Controls.Add(Me.cmd_refresh)
        Me.GroupBox2.Controls.Add(Me.dtp_log_date)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_log_pcname)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_log_idcard)
        Me.GroupBox2.Controls.Add(Me.txt_log_ip)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_log_fullname)
        Me.GroupBox2.Controls.Add(Me.txt_customer_user)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(861, 107)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รายละเอียด"
        '
        'cmd_refresh
        '
        Me.cmd_refresh.BackColor = System.Drawing.Color.White
        Me.cmd_refresh.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__40_
        Me.cmd_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_refresh.Location = New System.Drawing.Point(742, 12)
        Me.cmd_refresh.Name = "cmd_refresh"
        Me.cmd_refresh.Size = New System.Drawing.Size(113, 28)
        Me.cmd_refresh.TabIndex = 18
        Me.cmd_refresh.Text = "รีเฟรช"
        Me.cmd_refresh.UseVisualStyleBackColor = False
        '
        'cmd_find
        '
        Me.cmd_find.BackColor = System.Drawing.Color.White
        Me.cmd_find.Image = Global.SCANDB.My.Resources.Resources.search
        Me.cmd_find.Location = New System.Drawing.Point(886, 13)
        Me.cmd_find.Name = "cmd_find"
        Me.cmd_find.Size = New System.Drawing.Size(36, 28)
        Me.cmd_find.TabIndex = 19
        Me.cmd_find.UseVisualStyleBackColor = False
        '
        'cmd_report
        '
        Me.cmd_report.BackColor = System.Drawing.Color.White
        Me.cmd_report.Image = Global.SCANDB.My.Resources.Resources.Excel_icon
        Me.cmd_report.Location = New System.Drawing.Point(928, 13)
        Me.cmd_report.Name = "cmd_report"
        Me.cmd_report.Size = New System.Drawing.Size(36, 28)
        Me.cmd_report.TabIndex = 24
        Me.cmd_report.UseVisualStyleBackColor = False
        '
        'frmlogfileexe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_countdtgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_countdata)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtgvlogfile)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmlogfileexe"
        Me.Text = "ประวัติการแก้ไขข้อมูลบังคับคดี"
        CType(Me.dtgvlogfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_countdata As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_countdtgv As Label
    Friend WithEvents DateTimeend As DateTimePicker
    Friend WithEvents DateTimestart As DateTimePicker
    Friend WithEvents cmd_report As Button
    Friend WithEvents cbo_where As ComboBox
    Friend WithEvents txt_find As TextBox
    Friend WithEvents cmd_find As Button
    Friend WithEvents cmd_refresh As Button
    Friend WithEvents dtgvlogfile As DataGridView
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_log_date As DateTimePicker
    Friend WithEvents txt_log_idcard As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_log_account As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_customer_user As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_log_fullname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_log_ip As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_log_pcname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_log_detail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
