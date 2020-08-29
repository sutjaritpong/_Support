<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmsaveWDS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmsaveWDS))
        Me.txt_detail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_red = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_cusacc = New System.Windows.Forms.TextBox()
        Me.txt_cusphone = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cusid = New System.Windows.Forms.TextBox()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.txt_cuscus = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_black = New System.Windows.Forms.TextBox()
        Me.chk_datepayment = New System.Windows.Forms.CheckBox()
        Me.chk_datewds = New System.Windows.Forms.CheckBox()
        Me.chk_datecollector = New System.Windows.Forms.CheckBox()
        Me.dtp_datewds = New System.Windows.Forms.DateTimePicker()
        Me.dtp_payment = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_payment = New System.Windows.Forms.RichTextBox()
        Me.dtp_datecollector = New System.Windows.Forms.DateTimePicker()
        Me.cbo_hub = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_owner = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_empexe = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_empadmin = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Cmd_Link_Collector = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_savecancel = New System.Windows.Forms.Button()
        Me.lbl_link = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_detail
        '
        Me.txt_detail.Location = New System.Drawing.Point(39, 241)
        Me.txt_detail.Multiline = True
        Me.txt_detail.Name = "txt_detail"
        Me.txt_detail.Size = New System.Drawing.Size(288, 110)
        Me.txt_detail.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(39, 218)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 18)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "รายละเอียด ข้อมูลอื่น ๆ"
        '
        'txt_red
        '
        Me.txt_red.ForeColor = System.Drawing.Color.Red
        Me.txt_red.Location = New System.Drawing.Point(503, 155)
        Me.txt_red.Name = "txt_red"
        Me.txt_red.Size = New System.Drawing.Size(145, 20)
        Me.txt_red.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(441, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "เลขคดีดำ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(426, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 18)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "เลขที่สัญญา"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Window
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(408, 183)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 18)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "เบอร์ติดต่อลูกค้า"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(436, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 18)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "เลขคดีแดง"
        '
        'txt_cusacc
        '
        Me.txt_cusacc.Location = New System.Drawing.Point(503, 40)
        Me.txt_cusacc.Name = "txt_cusacc"
        Me.txt_cusacc.Size = New System.Drawing.Size(146, 20)
        Me.txt_cusacc.TabIndex = 6
        '
        'txt_cusphone
        '
        Me.txt_cusphone.Location = New System.Drawing.Point(503, 183)
        Me.txt_cusphone.Name = "txt_cusphone"
        Me.txt_cusphone.Size = New System.Drawing.Size(145, 20)
        Me.txt_cusphone.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(431, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 18)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "เลขที่ลูกหนี้"
        '
        'txt_cusid
        '
        Me.txt_cusid.Location = New System.Drawing.Point(502, 12)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(146, 20)
        Me.txt_cusid.TabIndex = 5
        '
        'txt_cusname
        '
        Me.txt_cusname.Location = New System.Drawing.Point(503, 96)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(146, 20)
        Me.txt_cusname.TabIndex = 8
        '
        'txt_cuscus
        '
        Me.txt_cuscus.Location = New System.Drawing.Point(503, 68)
        Me.txt_cuscus.Name = "txt_cuscus"
        Me.txt_cuscus.Size = New System.Drawing.Size(146, 20)
        Me.txt_cuscus.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(401, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 18)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "เลขบัตรประชาชน"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(425, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 18)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "ชื่อ-นามสกุล"
        '
        'txt_black
        '
        Me.txt_black.Location = New System.Drawing.Point(503, 124)
        Me.txt_black.Name = "txt_black"
        Me.txt_black.Size = New System.Drawing.Size(145, 20)
        Me.txt_black.TabIndex = 9
        '
        'chk_datepayment
        '
        Me.chk_datepayment.AutoSize = True
        Me.chk_datepayment.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datepayment.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datepayment.Location = New System.Drawing.Point(426, 284)
        Me.chk_datepayment.Name = "chk_datepayment"
        Me.chk_datepayment.Size = New System.Drawing.Size(100, 22)
        Me.chk_datepayment.TabIndex = 167
        Me.chk_datepayment.Text = "วันที่ลูกค้าชำระ"
        Me.chk_datepayment.UseVisualStyleBackColor = True
        '
        'chk_datewds
        '
        Me.chk_datewds.AutoSize = True
        Me.chk_datewds.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datewds.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datewds.Location = New System.Drawing.Point(397, 258)
        Me.chk_datewds.Name = "chk_datewds"
        Me.chk_datewds.Size = New System.Drawing.Size(129, 22)
        Me.chk_datewds.TabIndex = 145
        Me.chk_datewds.Text = "วันที่ไปถอนอายัด/ยึด"
        Me.chk_datewds.UseVisualStyleBackColor = True
        '
        'chk_datecollector
        '
        Me.chk_datecollector.AutoSize = True
        Me.chk_datecollector.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datecollector.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datecollector.Location = New System.Drawing.Point(357, 230)
        Me.chk_datecollector.Name = "chk_datecollector"
        Me.chk_datecollector.Size = New System.Drawing.Size(169, 22)
        Me.chk_datecollector.TabIndex = 121
        Me.chk_datecollector.Text = "Collector ส่งถอนอายัด/ยึด"
        Me.chk_datecollector.UseVisualStyleBackColor = True
        '
        'dtp_datewds
        '
        Me.dtp_datewds.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datewds.Location = New System.Drawing.Point(532, 259)
        Me.dtp_datewds.Name = "dtp_datewds"
        Me.dtp_datewds.Size = New System.Drawing.Size(116, 20)
        Me.dtp_datewds.TabIndex = 13
        '
        'dtp_payment
        '
        Me.dtp_payment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_payment.Location = New System.Drawing.Point(532, 287)
        Me.dtp_payment.Name = "dtp_payment"
        Me.dtp_payment.Size = New System.Drawing.Size(116, 20)
        Me.dtp_payment.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Window
        Me.Label18.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(435, 314)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 18)
        Me.Label18.TabIndex = 180
        Me.Label18.Text = "จำนวนเงินที่ชำระ"
        '
        'txt_payment
        '
        Me.txt_payment.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payment.ForeColor = System.Drawing.Color.Green
        Me.txt_payment.Location = New System.Drawing.Point(533, 313)
        Me.txt_payment.Name = "txt_payment"
        Me.txt_payment.Size = New System.Drawing.Size(116, 26)
        Me.txt_payment.TabIndex = 15
        Me.txt_payment.Text = ""
        '
        'dtp_datecollector
        '
        Me.dtp_datecollector.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datecollector.Location = New System.Drawing.Point(532, 231)
        Me.dtp_datecollector.Name = "dtp_datecollector"
        Me.dtp_datecollector.Size = New System.Drawing.Size(116, 20)
        Me.dtp_datecollector.TabIndex = 12
        '
        'cbo_hub
        '
        Me.cbo_hub.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbo_hub.FormattingEnabled = True
        Me.cbo_hub.Location = New System.Drawing.Point(167, 50)
        Me.cbo_hub.Name = "cbo_hub"
        Me.cbo_hub.Size = New System.Drawing.Size(160, 21)
        Me.cbo_hub.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "ศูนย์ประสานงาน"
        '
        'cbo_owner
        '
        Me.cbo_owner.FormattingEnabled = True
        Me.cbo_owner.Location = New System.Drawing.Point(169, 21)
        Me.cbo_owner.Name = "cbo_owner"
        Me.cbo_owner.Size = New System.Drawing.Size(158, 21)
        Me.cbo_owner.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "PRODUCT"
        '
        'cbo_empexe
        '
        Me.cbo_empexe.FormattingEnabled = True
        Me.cbo_empexe.Location = New System.Drawing.Point(133, 165)
        Me.cbo_empexe.Name = "cbo_empexe"
        Me.cbo_empexe.Size = New System.Drawing.Size(194, 21)
        Me.cbo_empexe.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "เจ้าหน้าที่บังคับคดี"
        '
        'cbo_empadmin
        '
        Me.cbo_empadmin.FormattingEnabled = True
        Me.cbo_empadmin.Location = New System.Drawing.Point(133, 134)
        Me.cbo_empadmin.Name = "cbo_empadmin"
        Me.cbo_empadmin.Size = New System.Drawing.Size(194, 21)
        Me.cbo_empadmin.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Admin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(455, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "STATUS :"
        '
        'txt_status
        '
        Me.txt_status.ForeColor = System.Drawing.Color.Violet
        Me.txt_status.Location = New System.Drawing.Point(533, 345)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(116, 20)
        Me.txt_status.TabIndex = 16
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.Window
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.btn_save.Location = New System.Drawing.Point(40, 357)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(133, 29)
        Me.btn_save.TabIndex = 21
        Me.btn_save.Text = "บันทึกข้อมูล"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Cmd_Link_Collector
        '
        Me.Cmd_Link_Collector.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_Link_Collector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Link_Collector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_Link_Collector.Image = Global.SCANDB.My.Resources.Resources.connect
        Me.Cmd_Link_Collector.Location = New System.Drawing.Point(179, 357)
        Me.Cmd_Link_Collector.Name = "Cmd_Link_Collector"
        Me.Cmd_Link_Collector.Size = New System.Drawing.Size(133, 29)
        Me.Cmd_Link_Collector.TabIndex = 182
        Me.Cmd_Link_Collector.Text = "ดึงข้อมูล"
        Me.Cmd_Link_Collector.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Link_Collector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cmd_Link_Collector.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Customer_service_icon32x32
        Me.PictureBox1.Location = New System.Drawing.Point(31, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 181
        Me.PictureBox1.TabStop = False
        '
        'btn_savecancel
        '
        Me.btn_savecancel.BackColor = System.Drawing.SystemColors.Window
        Me.btn_savecancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_savecancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_savecancel.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__16_
        Me.btn_savecancel.Location = New System.Drawing.Point(318, 357)
        Me.btn_savecancel.Name = "btn_savecancel"
        Me.btn_savecancel.Size = New System.Drawing.Size(133, 29)
        Me.btn_savecancel.TabIndex = 22
        Me.btn_savecancel.Text = "ยกเลิก"
        Me.btn_savecancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_savecancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_savecancel.UseVisualStyleBackColor = False
        '
        'lbl_link
        '
        Me.lbl_link.AutoSize = True
        Me.lbl_link.BackColor = System.Drawing.SystemColors.Window
        Me.lbl_link.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_link.Location = New System.Drawing.Point(293, 218)
        Me.lbl_link.Name = "lbl_link"
        Me.lbl_link.Size = New System.Drawing.Size(0, 18)
        Me.lbl_link.TabIndex = 183
        '
        'FrmsaveWDS
        '
        Me.AcceptButton = Me.btn_save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(686, 415)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_link)
        Me.Controls.Add(Me.Cmd_Link_Collector)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.cbo_empexe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_empadmin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbo_hub)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_owner)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_datepayment)
        Me.Controls.Add(Me.chk_datewds)
        Me.Controls.Add(Me.chk_datecollector)
        Me.Controls.Add(Me.dtp_datewds)
        Me.Controls.Add(Me.dtp_payment)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txt_payment)
        Me.Controls.Add(Me.dtp_datecollector)
        Me.Controls.Add(Me.txt_red)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_cusacc)
        Me.Controls.Add(Me.txt_cusphone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_cusid)
        Me.Controls.Add(Me.txt_cusname)
        Me.Controls.Add(Me.txt_cuscus)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_black)
        Me.Controls.Add(Me.btn_savecancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_detail)
        Me.Controls.Add(Me.Label11)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmsaveWDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "บันทีกข้อมูลถอนอายัด/ยึดทรัพย์"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_detail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_savecancel As Button
    Friend WithEvents txt_red As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_cusacc As TextBox
    Friend WithEvents txt_cusphone As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_cusid As TextBox
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents txt_cuscus As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_black As TextBox
    Friend WithEvents chk_datepayment As CheckBox
    Friend WithEvents chk_datewds As CheckBox
    Friend WithEvents chk_datecollector As CheckBox
    Friend WithEvents dtp_datewds As DateTimePicker
    Friend WithEvents dtp_payment As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_payment As RichTextBox
    Friend WithEvents dtp_datecollector As DateTimePicker
    Friend WithEvents cbo_hub As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_owner As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_empexe As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_empadmin As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_status As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cmd_Link_Collector As Button
    Friend WithEvents lbl_link As Label
End Class
