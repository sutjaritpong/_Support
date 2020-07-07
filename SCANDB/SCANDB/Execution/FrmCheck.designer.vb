<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCheck))
        Me.dtgv_check = New System.Windows.Forms.DataGridView()
        Me.txt_totalcheck = New System.Windows.Forms.TextBox()
        Me.txt_numcheck = New System.Windows.Forms.TextBox()
        Me.txt_hub = New System.Windows.Forms.TextBox()
        Me.txt_checkbank = New System.Windows.Forms.TextBox()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.txt_refund = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.txt_cusid = New System.Windows.Forms.TextBox()
        Me.txt_cusname = New System.Windows.Forms.TextBox()
        Me.txt_cusaccno = New System.Windows.Forms.TextBox()
        Me.txt_cusacc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_editch = New System.Windows.Forms.Button()
        Me.btn_savech = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbo_cusowner = New System.Windows.Forms.ComboBox()
        Me.dtp_checksend = New System.Windows.Forms.DateTimePicker()
        Me.chk_checksend = New System.Windows.Forms.CheckBox()
        Me.chk_datecheck = New System.Windows.Forms.CheckBox()
        Me.dtp_datecheck = New System.Windows.Forms.DateTimePicker()
        CType(Me.dtgv_check, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgv_check
        '
        Me.dtgv_check.AllowUserToAddRows = False
        Me.dtgv_check.AllowUserToDeleteRows = False
        Me.dtgv_check.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgv_check.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgv_check.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_check.Location = New System.Drawing.Point(36, 27)
        Me.dtgv_check.Name = "dtgv_check"
        Me.dtgv_check.ReadOnly = True
        Me.dtgv_check.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgv_check.Size = New System.Drawing.Size(629, 107)
        Me.dtgv_check.TabIndex = 0
        '
        'txt_totalcheck
        '
        Me.txt_totalcheck.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalcheck.ForeColor = System.Drawing.Color.Orange
        Me.txt_totalcheck.Location = New System.Drawing.Point(261, 269)
        Me.txt_totalcheck.Name = "txt_totalcheck"
        Me.txt_totalcheck.Size = New System.Drawing.Size(163, 22)
        Me.txt_totalcheck.TabIndex = 18
        '
        'txt_numcheck
        '
        Me.txt_numcheck.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numcheck.Location = New System.Drawing.Point(104, 216)
        Me.txt_numcheck.Name = "txt_numcheck"
        Me.txt_numcheck.Size = New System.Drawing.Size(131, 22)
        Me.txt_numcheck.TabIndex = 16
        '
        'txt_hub
        '
        Me.txt_hub.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hub.Location = New System.Drawing.Point(104, 190)
        Me.txt_hub.Name = "txt_hub"
        Me.txt_hub.Size = New System.Drawing.Size(131, 22)
        Me.txt_hub.TabIndex = 15
        '
        'txt_checkbank
        '
        Me.txt_checkbank.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_checkbank.Location = New System.Drawing.Point(104, 242)
        Me.txt_checkbank.Name = "txt_checkbank"
        Me.txt_checkbank.Size = New System.Drawing.Size(131, 22)
        Me.txt_checkbank.TabIndex = 14
        '
        'txt_note
        '
        Me.txt_note.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_note.Location = New System.Drawing.Point(493, 285)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(179, 59)
        Me.txt_note.TabIndex = 24
        '
        'txt_refund
        '
        Me.txt_refund.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_refund.ForeColor = System.Drawing.Color.Red
        Me.txt_refund.Location = New System.Drawing.Point(541, 208)
        Me.txt_refund.Name = "txt_refund"
        Me.txt_refund.Size = New System.Drawing.Size(131, 22)
        Me.txt_refund.TabIndex = 23
        '
        'txt_total
        '
        Me.txt_total.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(541, 182)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(131, 22)
        Me.txt_total.TabIndex = 22
        '
        'txt_cusid
        '
        Me.txt_cusid.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cusid.Location = New System.Drawing.Point(104, 322)
        Me.txt_cusid.Name = "txt_cusid"
        Me.txt_cusid.Size = New System.Drawing.Size(131, 22)
        Me.txt_cusid.TabIndex = 19
        '
        'txt_cusname
        '
        Me.txt_cusname.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cusname.Location = New System.Drawing.Point(261, 323)
        Me.txt_cusname.Name = "txt_cusname"
        Me.txt_cusname.Size = New System.Drawing.Size(163, 22)
        Me.txt_cusname.TabIndex = 27
        '
        'txt_cusaccno
        '
        Me.txt_cusaccno.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cusaccno.Location = New System.Drawing.Point(261, 216)
        Me.txt_cusaccno.Name = "txt_cusaccno"
        Me.txt_cusaccno.Size = New System.Drawing.Size(163, 22)
        Me.txt_cusaccno.TabIndex = 26
        '
        'txt_cusacc
        '
        Me.txt_cusacc.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cusacc.Location = New System.Drawing.Point(261, 175)
        Me.txt_cusacc.Name = "txt_cusacc"
        Me.txt_cusacc.Size = New System.Drawing.Size(163, 22)
        Me.txt_cusacc.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "PRODUCT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "เช็คธนาคาร"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "สาขา"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "เลขที่เช็ค"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(261, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "จำนวนเงินตามเช็ค"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "เลขบัตรประชาชน"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(261, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 18)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "เลขที่สัญญา"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(261, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 18)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "เลขที่ลูกหนี้"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(261, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 18)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "ชื่อ-นามสกุล"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(482, 185)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 18)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "เงินส่วนได้"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(470, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 18)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "ค่าใช้จ่ายคืน"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(493, 267)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 18)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "หมายเหตุ"
        '
        'btn_editch
        '
        Me.btn_editch.BackColor = System.Drawing.SystemColors.Window
        Me.btn_editch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_editch.Image = Global.SCANDB.My.Resources.Resources.edit_icon16x16
        Me.btn_editch.Location = New System.Drawing.Point(166, 391)
        Me.btn_editch.Name = "btn_editch"
        Me.btn_editch.Size = New System.Drawing.Size(133, 29)
        Me.btn_editch.TabIndex = 47
        Me.btn_editch.Text = "แก้ไขข้อมูล"
        Me.btn_editch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_editch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_editch.UseVisualStyleBackColor = False
        '
        'btn_savech
        '
        Me.btn_savech.BackColor = System.Drawing.SystemColors.Window
        Me.btn_savech.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_savech.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_savech.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.btn_savech.Location = New System.Drawing.Point(29, 391)
        Me.btn_savech.Name = "btn_savech"
        Me.btn_savech.Size = New System.Drawing.Size(133, 29)
        Me.btn_savech.TabIndex = 48
        Me.btn_savech.Text = "บันทึกข้อมูล"
        Me.btn_savech.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_savech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_savech.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.Window
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_cancel.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__16_
        Me.btn_cancel.Location = New System.Drawing.Point(535, 391)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(133, 29)
        Me.btn_cancel.TabIndex = 49
        Me.btn_cancel.Text = "ยกเลิก"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Image = Global.SCANDB.My.Resources.Resources.add
        Me.Button1.Location = New System.Drawing.Point(305, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 29)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "เพิ่มข้อมูล"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbo_cusowner
        '
        Me.cbo_cusowner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_cusowner.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_cusowner.FormattingEnabled = True
        Me.cbo_cusowner.Location = New System.Drawing.Point(104, 153)
        Me.cbo_cusowner.Name = "cbo_cusowner"
        Me.cbo_cusowner.Size = New System.Drawing.Size(131, 24)
        Me.cbo_cusowner.TabIndex = 53
        '
        'dtp_checksend
        '
        Me.dtp_checksend.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_checksend.Location = New System.Drawing.Point(576, 159)
        Me.dtp_checksend.Name = "dtp_checksend"
        Me.dtp_checksend.Size = New System.Drawing.Size(96, 20)
        Me.dtp_checksend.TabIndex = 54
        '
        'chk_checksend
        '
        Me.chk_checksend.AutoSize = True
        Me.chk_checksend.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_checksend.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_checksend.Location = New System.Drawing.Point(443, 159)
        Me.chk_checksend.Name = "chk_checksend"
        Me.chk_checksend.Size = New System.Drawing.Size(127, 20)
        Me.chk_checksend.TabIndex = 55
        Me.chk_checksend.Text = "วันที่ส่งเช็คเข้า BANK"
        Me.chk_checksend.ThreeState = True
        Me.chk_checksend.UseVisualStyleBackColor = True
        '
        'chk_datecheck
        '
        Me.chk_datecheck.AutoSize = True
        Me.chk_datecheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_datecheck.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_datecheck.Location = New System.Drawing.Point(41, 270)
        Me.chk_datecheck.Name = "chk_datecheck"
        Me.chk_datecheck.Size = New System.Drawing.Size(75, 20)
        Me.chk_datecheck.TabIndex = 57
        Me.chk_datecheck.Text = "วันทืี่ในเช็ค"
        Me.chk_datecheck.ThreeState = True
        Me.chk_datecheck.UseVisualStyleBackColor = True
        '
        'dtp_datecheck
        '
        Me.dtp_datecheck.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_datecheck.Location = New System.Drawing.Point(122, 270)
        Me.dtp_datecheck.Name = "dtp_datecheck"
        Me.dtp_datecheck.Size = New System.Drawing.Size(113, 20)
        Me.dtp_datecheck.TabIndex = 56
        '
        'FrmCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(711, 443)
        Me.Controls.Add(Me.chk_datecheck)
        Me.Controls.Add(Me.dtp_datecheck)
        Me.Controls.Add(Me.chk_checksend)
        Me.Controls.Add(Me.dtp_checksend)
        Me.Controls.Add(Me.cbo_cusowner)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_savech)
        Me.Controls.Add(Me.btn_editch)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cusname)
        Me.Controls.Add(Me.txt_cusaccno)
        Me.Controls.Add(Me.txt_cusacc)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.txt_refund)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_cusid)
        Me.Controls.Add(Me.txt_totalcheck)
        Me.Controls.Add(Me.txt_numcheck)
        Me.Controls.Add(Me.txt_hub)
        Me.Controls.Add(Me.txt_checkbank)
        Me.Controls.Add(Me.dtgv_check)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เช็คบังคับคดี"
        CType(Me.dtgv_check, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgv_check As DataGridView
    Friend WithEvents txt_totalcheck As TextBox
    Friend WithEvents txt_numcheck As TextBox
    Friend WithEvents txt_hub As TextBox
    Friend WithEvents txt_checkbank As TextBox
    Friend WithEvents txt_note As TextBox
    Friend WithEvents txt_refund As TextBox
    Friend WithEvents txt_total As TextBox
    Friend WithEvents txt_cusid As TextBox
    Friend WithEvents txt_cusname As TextBox
    Friend WithEvents txt_cusaccno As TextBox
    Friend WithEvents txt_cusacc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_editch As Button
    Friend WithEvents btn_savech As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbo_cusowner As ComboBox
    Friend WithEvents dtp_checksend As DateTimePicker
    Friend WithEvents chk_checksend As CheckBox
    Friend WithEvents chk_datecheck As CheckBox
    Friend WithEvents dtp_datecheck As DateTimePicker
End Class
