<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDomainServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDomainServer))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_server_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_server_ram = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_server_harddisk = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_server_veros = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_server_model = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_server_sql = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_server_detail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_server_cpu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_server_type = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_server_antivirus = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_server_manufacturer = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_server_IP = New System.Windows.Forms.TextBox()
        Me.txt_server_user = New System.Windows.Forms.TextBox()
        Me.txt_server_hostname = New System.Windows.Forms.TextBox()
        Me.txt_server_domain = New System.Windows.Forms.TextBox()
        Me.cmd_server_reload = New System.Windows.Forms.Button()
        Me.cmd_server_save = New System.Windows.Forms.Button()
        Me.cmd_server_edit = New System.Windows.Forms.Button()
        Me.cmd_server_delete = New System.Windows.Forms.Button()
        Me.dtgv_Server = New System.Windows.Forms.DataGridView()
        Me.Dtp_server_setos = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgv_Server, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_server_pass)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_server_ram)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_server_harddisk)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_server_veros)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_server_model)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_server_sql)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_server_detail)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_server_cpu)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_server_type)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_server_antivirus)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_server_manufacturer)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_server_IP)
        Me.GroupBox1.Controls.Add(Me.txt_server_user)
        Me.GroupBox1.Controls.Add(Me.txt_server_hostname)
        Me.GroupBox1.Controls.Add(Me.txt_server_domain)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 165)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอียด"
        '
        'txt_server_pass
        '
        Me.txt_server_pass.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_pass.ForeColor = System.Drawing.Color.Red
        Me.txt_server_pass.Location = New System.Drawing.Point(86, 132)
        Me.txt_server_pass.Name = "txt_server_pass"
        Me.txt_server_pass.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_pass.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(5, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IP address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(5, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hostname"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(20, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Domain"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(249, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Microsolf SQL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(12, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Password"
        '
        'txt_server_ram
        '
        Me.txt_server_ram.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_ram.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_ram.Location = New System.Drawing.Point(595, 103)
        Me.txt_server_ram.Name = "txt_server_ram"
        Me.txt_server_ram.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_ram.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(3, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Username"
        '
        'txt_server_harddisk
        '
        Me.txt_server_harddisk.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_harddisk.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_harddisk.Location = New System.Drawing.Point(595, 74)
        Me.txt_server_harddisk.Name = "txt_server_harddisk"
        Me.txt_server_harddisk.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_harddisk.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(276, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Antivirus"
        '
        'txt_server_veros
        '
        Me.txt_server_veros.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_veros.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_veros.Location = New System.Drawing.Point(352, 132)
        Me.txt_server_veros.Name = "txt_server_veros"
        Me.txt_server_veros.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_veros.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(300, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Model"
        '
        'txt_server_model
        '
        Me.txt_server_model.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_model.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_model.Location = New System.Drawing.Point(352, 74)
        Me.txt_server_model.Name = "txt_server_model"
        Me.txt_server_model.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_model.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(247, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Manufacturer"
        '
        'txt_server_sql
        '
        Me.txt_server_sql.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_sql.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_sql.Location = New System.Drawing.Point(352, 16)
        Me.txt_server_sql.Name = "txt_server_sql"
        Me.txt_server_sql.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_sql.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(553, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "CPU"
        '
        'txt_server_detail
        '
        Me.txt_server_detail.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_detail.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_detail.Location = New System.Drawing.Point(595, 132)
        Me.txt_server_detail.Name = "txt_server_detail"
        Me.txt_server_detail.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_detail.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(550, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 18)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Type"
        '
        'txt_server_cpu
        '
        Me.txt_server_cpu.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_cpu.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_cpu.Location = New System.Drawing.Point(595, 45)
        Me.txt_server_cpu.Name = "txt_server_cpu"
        Me.txt_server_cpu.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_cpu.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(268, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 18)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "VersionOS"
        '
        'txt_server_type
        '
        Me.txt_server_type.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_type.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_type.Location = New System.Drawing.Point(595, 16)
        Me.txt_server_type.Name = "txt_server_type"
        Me.txt_server_type.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_type.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(541, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 18)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Detail"
        '
        'txt_server_antivirus
        '
        Me.txt_server_antivirus.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_antivirus.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_antivirus.Location = New System.Drawing.Point(352, 103)
        Me.txt_server_antivirus.Name = "txt_server_antivirus"
        Me.txt_server_antivirus.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_antivirus.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(551, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 18)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "RAM"
        '
        'txt_server_manufacturer
        '
        Me.txt_server_manufacturer.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_manufacturer.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_manufacturer.Location = New System.Drawing.Point(352, 45)
        Me.txt_server_manufacturer.Name = "txt_server_manufacturer"
        Me.txt_server_manufacturer.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_manufacturer.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(522, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 18)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Harddisk"
        '
        'txt_server_IP
        '
        Me.txt_server_IP.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_IP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_server_IP.Location = New System.Drawing.Point(86, 16)
        Me.txt_server_IP.Name = "txt_server_IP"
        Me.txt_server_IP.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_IP.TabIndex = 1
        '
        'txt_server_user
        '
        Me.txt_server_user.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_user.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_user.Location = New System.Drawing.Point(86, 103)
        Me.txt_server_user.Name = "txt_server_user"
        Me.txt_server_user.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_user.TabIndex = 4
        '
        'txt_server_hostname
        '
        Me.txt_server_hostname.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_hostname.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_hostname.Location = New System.Drawing.Point(86, 45)
        Me.txt_server_hostname.Name = "txt_server_hostname"
        Me.txt_server_hostname.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_hostname.TabIndex = 2
        '
        'txt_server_domain
        '
        Me.txt_server_domain.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_server_domain.ForeColor = System.Drawing.Color.Blue
        Me.txt_server_domain.Location = New System.Drawing.Point(86, 74)
        Me.txt_server_domain.Name = "txt_server_domain"
        Me.txt_server_domain.Size = New System.Drawing.Size(157, 23)
        Me.txt_server_domain.TabIndex = 3
        '
        'cmd_server_reload
        '
        Me.cmd_server_reload.AutoSize = True
        Me.cmd_server_reload.BackColor = System.Drawing.Color.White
        Me.cmd_server_reload.ForeColor = System.Drawing.Color.Black
        Me.cmd_server_reload.Image = Global.SCANDB.My.Resources.Resources.refresh
        Me.cmd_server_reload.Location = New System.Drawing.Point(900, 143)
        Me.cmd_server_reload.Name = "cmd_server_reload"
        Me.cmd_server_reload.Size = New System.Drawing.Size(96, 30)
        Me.cmd_server_reload.TabIndex = 47
        Me.cmd_server_reload.Text = "RELOAD"
        Me.cmd_server_reload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_server_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_server_reload.UseVisualStyleBackColor = False
        '
        'cmd_server_save
        '
        Me.cmd_server_save.AutoSize = True
        Me.cmd_server_save.BackColor = System.Drawing.Color.White
        Me.cmd_server_save.ForeColor = System.Drawing.Color.Black
        Me.cmd_server_save.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.cmd_server_save.Location = New System.Drawing.Point(798, 108)
        Me.cmd_server_save.Name = "cmd_server_save"
        Me.cmd_server_save.Size = New System.Drawing.Size(96, 30)
        Me.cmd_server_save.TabIndex = 44
        Me.cmd_server_save.Text = "SAVE"
        Me.cmd_server_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_server_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_server_save.UseVisualStyleBackColor = False
        '
        'cmd_server_edit
        '
        Me.cmd_server_edit.AutoSize = True
        Me.cmd_server_edit.BackColor = System.Drawing.Color.White
        Me.cmd_server_edit.ForeColor = System.Drawing.Color.Black
        Me.cmd_server_edit.Image = Global.SCANDB.My.Resources.Resources.Actions_edit_rename_icon24x24
        Me.cmd_server_edit.Location = New System.Drawing.Point(798, 143)
        Me.cmd_server_edit.Name = "cmd_server_edit"
        Me.cmd_server_edit.Size = New System.Drawing.Size(96, 30)
        Me.cmd_server_edit.TabIndex = 46
        Me.cmd_server_edit.Text = "EDIT"
        Me.cmd_server_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_server_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_server_edit.UseVisualStyleBackColor = False
        '
        'cmd_server_delete
        '
        Me.cmd_server_delete.AutoSize = True
        Me.cmd_server_delete.BackColor = System.Drawing.Color.White
        Me.cmd_server_delete.ForeColor = System.Drawing.Color.Black
        Me.cmd_server_delete.Image = Global.SCANDB.My.Resources.Resources.delete1
        Me.cmd_server_delete.Location = New System.Drawing.Point(900, 108)
        Me.cmd_server_delete.Name = "cmd_server_delete"
        Me.cmd_server_delete.Size = New System.Drawing.Size(96, 30)
        Me.cmd_server_delete.TabIndex = 45
        Me.cmd_server_delete.Text = "DELETE"
        Me.cmd_server_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_server_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_server_delete.UseVisualStyleBackColor = False
        '
        'dtgv_Server
        '
        Me.dtgv_Server.AllowUserToAddRows = False
        Me.dtgv_Server.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgv_Server.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv_Server.BackgroundColor = System.Drawing.Color.White
        Me.dtgv_Server.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_Server.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv_Server.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_Server.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv_Server.GridColor = System.Drawing.Color.Navy
        Me.dtgv_Server.Location = New System.Drawing.Point(12, 183)
        Me.dtgv_Server.Name = "dtgv_Server"
        Me.dtgv_Server.ReadOnly = True
        Me.dtgv_Server.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dtgv_Server.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgv_Server.Size = New System.Drawing.Size(984, 528)
        Me.dtgv_Server.TabIndex = 48
        '
        'Dtp_server_setos
        '
        Me.Dtp_server_setos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_server_setos.Location = New System.Drawing.Point(878, 31)
        Me.Dtp_server_setos.Name = "Dtp_server_setos"
        Me.Dtp_server_setos.Size = New System.Drawing.Size(101, 20)
        Me.Dtp_server_setos.TabIndex = 50
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(797, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 18)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "SETUP OS"
        '
        'FrmDomainServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Dtp_server_setos)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtgv_Server)
        Me.Controls.Add(Me.cmd_server_reload)
        Me.Controls.Add(Me.cmd_server_save)
        Me.Controls.Add(Me.cmd_server_edit)
        Me.Controls.Add(Me.cmd_server_delete)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDomainServer"
        Me.Text = "รายละเอียด PC-Server"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgv_Server, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_server_pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_server_ram As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_server_harddisk As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_server_veros As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_server_model As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_server_sql As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_server_detail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_server_cpu As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_server_type As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_server_antivirus As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_server_manufacturer As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_server_IP As TextBox
    Friend WithEvents txt_server_user As TextBox
    Friend WithEvents txt_server_hostname As TextBox
    Friend WithEvents txt_server_domain As TextBox
    Friend WithEvents cmd_server_reload As Button
    Friend WithEvents cmd_server_save As Button
    Friend WithEvents cmd_server_edit As Button
    Friend WithEvents cmd_server_delete As Button
    Friend WithEvents dtgv_Server As DataGridView
    Friend WithEvents Dtp_server_setos As DateTimePicker
    Friend WithEvents Label16 As Label
End Class
