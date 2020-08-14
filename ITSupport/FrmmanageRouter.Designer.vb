<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmmanageRouter
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmmanageRouter))
        Me.dtgv_router = New System.Windows.Forms.DataGridView()
        Me.cmd_router_reload = New System.Windows.Forms.Button()
        Me.cmd_router_save = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Dtp_router_lastup = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_router_status = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_router_detail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_router_dhcpstart = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_router_wifiuser = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_router_dhcpend = New System.Windows.Forms.TextBox()
        Me.txt_router_wifipass = New System.Windows.Forms.TextBox()
        Me.txt_router_ip = New System.Windows.Forms.TextBox()
        Me.txt_router_password = New System.Windows.Forms.TextBox()
        Me.txt_router_Brand = New System.Windows.Forms.TextBox()
        Me.txt_router_user = New System.Windows.Forms.TextBox()
        Me.cmd_router_edit = New System.Windows.Forms.Button()
        Me.cmd_router_delete = New System.Windows.Forms.Button()
        CType(Me.dtgv_router, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgv_router
        '
        Me.dtgv_router.AllowUserToAddRows = False
        Me.dtgv_router.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgv_router.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv_router.BackgroundColor = System.Drawing.Color.White
        Me.dtgv_router.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_router.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv_router.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_router.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv_router.GridColor = System.Drawing.Color.Navy
        Me.dtgv_router.Location = New System.Drawing.Point(12, 183)
        Me.dtgv_router.Name = "dtgv_router"
        Me.dtgv_router.ReadOnly = True
        Me.dtgv_router.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dtgv_router.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgv_router.Size = New System.Drawing.Size(984, 534)
        Me.dtgv_router.TabIndex = 36
        '
        'cmd_router_reload
        '
        Me.cmd_router_reload.AutoSize = True
        Me.cmd_router_reload.BackColor = System.Drawing.Color.White
        Me.cmd_router_reload.ForeColor = System.Drawing.Color.Black
        Me.cmd_router_reload.Image = Global.SCANDB.My.Resources.Resources.refresh
        Me.cmd_router_reload.Location = New System.Drawing.Point(754, 129)
        Me.cmd_router_reload.Name = "cmd_router_reload"
        Me.cmd_router_reload.Size = New System.Drawing.Size(96, 30)
        Me.cmd_router_reload.TabIndex = 48
        Me.cmd_router_reload.Text = "RELOAD"
        Me.cmd_router_reload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_router_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_router_reload.UseVisualStyleBackColor = False
        '
        'cmd_router_save
        '
        Me.cmd_router_save.AutoSize = True
        Me.cmd_router_save.BackColor = System.Drawing.Color.White
        Me.cmd_router_save.ForeColor = System.Drawing.Color.Black
        Me.cmd_router_save.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.cmd_router_save.Location = New System.Drawing.Point(754, 21)
        Me.cmd_router_save.Name = "cmd_router_save"
        Me.cmd_router_save.Size = New System.Drawing.Size(96, 30)
        Me.cmd_router_save.TabIndex = 45
        Me.cmd_router_save.Text = "SAVE"
        Me.cmd_router_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_router_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_router_save.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dtp_router_lastup)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_router_status)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_router_detail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_router_dhcpstart)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_router_wifiuser)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_router_dhcpend)
        Me.GroupBox1.Controls.Add(Me.txt_router_wifipass)
        Me.GroupBox1.Controls.Add(Me.txt_router_ip)
        Me.GroupBox1.Controls.Add(Me.txt_router_password)
        Me.GroupBox1.Controls.Add(Me.txt_router_Brand)
        Me.GroupBox1.Controls.Add(Me.txt_router_user)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 165)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอียด"
        '
        'Dtp_router_lastup
        '
        Me.Dtp_router_lastup.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_router_lastup.Location = New System.Drawing.Point(623, 16)
        Me.Dtp_router_lastup.Name = "Dtp_router_lastup"
        Me.Dtp_router_lastup.Size = New System.Drawing.Size(101, 23)
        Me.Dtp_router_lastup.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(520, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "LASTUPDATE"
        '
        'txt_router_status
        '
        Me.txt_router_status.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_router_status.ForeColor = System.Drawing.Color.Red
        Me.txt_router_status.Location = New System.Drawing.Point(93, 132)
        Me.txt_router_status.Name = "txt_router_status"
        Me.txt_router_status.Size = New System.Drawing.Size(147, 23)
        Me.txt_router_status.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(40, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Brand"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(10, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(279, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "WIFI-NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(36, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(19, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(282, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "DHCP-END"
        '
        'txt_router_detail
        '
        Me.txt_router_detail.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_router_detail.ForeColor = System.Drawing.Color.Blue
        Me.txt_router_detail.Location = New System.Drawing.Point(367, 132)
        Me.txt_router_detail.Name = "txt_router_detail"
        Me.txt_router_detail.Size = New System.Drawing.Size(147, 23)
        Me.txt_router_detail.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(265, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "DHCP-START"
        '
        'txt_router_dhcpstart
        '
        Me.txt_router_dhcpstart.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_router_dhcpstart.ForeColor = System.Drawing.Color.Blue
        Me.txt_router_dhcpstart.Location = New System.Drawing.Point(367, 74)
        Me.txt_router_dhcpstart.Name = "txt_router_dhcpstart"
        Me.txt_router_dhcpstart.Size = New System.Drawing.Size(147, 23)
        Me.txt_router_dhcpstart.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(283, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "WIFI-PASS"
        '
        'txt_router_wifiuser
        '
        Me.txt_router_wifiuser.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_router_wifiuser.ForeColor = System.Drawing.Color.Blue
        Me.txt_router_wifiuser.Location = New System.Drawing.Point(367, 16)
        Me.txt_router_wifiuser.Name = "txt_router_wifiuser"
        Me.txt_router_wifiuser.Size = New System.Drawing.Size(147, 23)
        Me.txt_router_wifiuser.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(313, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 18)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Detail"
        '
        'txt_router_dhcpend
        '
        Me.txt_router_dhcpend.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_router_dhcpend.ForeColor = System.Drawing.Color.Blue
        Me.txt_router_dhcpend.Location = New System.Drawing.Point(367, 103)
        Me.txt_router_dhcpend.Name = "txt_router_dhcpend"
        Me.txt_router_dhcpend.Size = New System.Drawing.Size(147, 23)
        Me.txt_router_dhcpend.TabIndex = 9
        '
        'txt_router_wifipass
        '
        Me.txt_router_wifipass.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_router_wifipass.ForeColor = System.Drawing.Color.Blue
        Me.txt_router_wifipass.Location = New System.Drawing.Point(367, 45)
        Me.txt_router_wifipass.Name = "txt_router_wifipass"
        Me.txt_router_wifipass.Size = New System.Drawing.Size(147, 23)
        Me.txt_router_wifipass.TabIndex = 7
        '
        'txt_router_ip
        '
        Me.txt_router_ip.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_router_ip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_router_ip.Location = New System.Drawing.Point(93, 16)
        Me.txt_router_ip.Name = "txt_router_ip"
        Me.txt_router_ip.Size = New System.Drawing.Size(147, 23)
        Me.txt_router_ip.TabIndex = 1
        '
        'txt_router_password
        '
        Me.txt_router_password.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_router_password.ForeColor = System.Drawing.Color.Blue
        Me.txt_router_password.Location = New System.Drawing.Point(93, 103)
        Me.txt_router_password.Name = "txt_router_password"
        Me.txt_router_password.Size = New System.Drawing.Size(147, 23)
        Me.txt_router_password.TabIndex = 4
        '
        'txt_router_Brand
        '
        Me.txt_router_Brand.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_router_Brand.ForeColor = System.Drawing.Color.Blue
        Me.txt_router_Brand.Location = New System.Drawing.Point(93, 45)
        Me.txt_router_Brand.Name = "txt_router_Brand"
        Me.txt_router_Brand.Size = New System.Drawing.Size(147, 23)
        Me.txt_router_Brand.TabIndex = 2
        '
        'txt_router_user
        '
        Me.txt_router_user.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_router_user.ForeColor = System.Drawing.Color.Blue
        Me.txt_router_user.Location = New System.Drawing.Point(93, 74)
        Me.txt_router_user.Name = "txt_router_user"
        Me.txt_router_user.Size = New System.Drawing.Size(147, 23)
        Me.txt_router_user.TabIndex = 3
        '
        'cmd_router_edit
        '
        Me.cmd_router_edit.AutoSize = True
        Me.cmd_router_edit.BackColor = System.Drawing.Color.White
        Me.cmd_router_edit.ForeColor = System.Drawing.Color.Black
        Me.cmd_router_edit.Image = Global.SCANDB.My.Resources.Resources.Actions_edit_rename_icon24x24
        Me.cmd_router_edit.Location = New System.Drawing.Point(754, 57)
        Me.cmd_router_edit.Name = "cmd_router_edit"
        Me.cmd_router_edit.Size = New System.Drawing.Size(96, 30)
        Me.cmd_router_edit.TabIndex = 47
        Me.cmd_router_edit.Text = "EDIT"
        Me.cmd_router_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_router_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_router_edit.UseVisualStyleBackColor = False
        '
        'cmd_router_delete
        '
        Me.cmd_router_delete.AutoSize = True
        Me.cmd_router_delete.BackColor = System.Drawing.Color.White
        Me.cmd_router_delete.ForeColor = System.Drawing.Color.Black
        Me.cmd_router_delete.Image = Global.SCANDB.My.Resources.Resources.delete1
        Me.cmd_router_delete.Location = New System.Drawing.Point(754, 93)
        Me.cmd_router_delete.Name = "cmd_router_delete"
        Me.cmd_router_delete.Size = New System.Drawing.Size(96, 30)
        Me.cmd_router_delete.TabIndex = 46
        Me.cmd_router_delete.Text = "DELETE"
        Me.cmd_router_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_router_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_router_delete.UseVisualStyleBackColor = False
        '
        'FrmmanageRouter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.cmd_router_reload)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtgv_router)
        Me.Controls.Add(Me.cmd_router_save)
        Me.Controls.Add(Me.cmd_router_delete)
        Me.Controls.Add(Me.cmd_router_edit)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmmanageRouter"
        Me.Text = "ข้อมูล WIFI ROUTER"
        CType(Me.dtgv_router, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgv_router As DataGridView
    Friend WithEvents cmd_router_reload As Button
    Friend WithEvents cmd_router_save As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_router_status As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_router_detail As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_router_dhcpstart As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_router_dhcpend As TextBox
    Friend WithEvents txt_router_password As TextBox
    Friend WithEvents txt_router_user As TextBox
    Friend WithEvents cmd_router_edit As Button
    Friend WithEvents cmd_router_delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_router_wifiuser As TextBox
    Friend WithEvents txt_router_wifipass As TextBox
    Friend WithEvents txt_router_ip As TextBox
    Friend WithEvents txt_router_Brand As TextBox
    Friend WithEvents Dtp_router_lastup As DateTimePicker
    Friend WithEvents Label11 As Label
End Class
