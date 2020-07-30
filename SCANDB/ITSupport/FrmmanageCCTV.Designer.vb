<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmmanageCCTV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmmanageCCTV))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_cctv_location = New System.Windows.Forms.TextBox()
        Me.txt_cctv_hubs = New System.Windows.Forms.TextBox()
        Me.txt_cctv_user = New System.Windows.Forms.TextBox()
        Me.txt_cctv_password = New System.Windows.Forms.TextBox()
        Me.txt_cctv_serail = New System.Windows.Forms.TextBox()
        Me.txt_cctv_remark = New System.Windows.Forms.TextBox()
        Me.txt_cctv_type = New System.Windows.Forms.TextBox()
        Me.txt_cctv_other = New System.Windows.Forms.TextBox()
        Me.txt_cctv_solfware = New System.Windows.Forms.TextBox()
        Me.txt_cctv_apps = New System.Windows.Forms.TextBox()
        Me.txt_cctv_port = New System.Windows.Forms.TextBox()
        Me.txt_cctv_ip = New System.Windows.Forms.TextBox()
        Me.txt_cctv_camera = New System.Windows.Forms.TextBox()
        Me.txt_cctv_brand = New System.Windows.Forms.TextBox()
        Me.txt_cctv_region = New System.Windows.Forms.TextBox()
        Me.dtgv_cctv = New System.Windows.Forms.DataGridView()
        Me.cmd_cctv_delete = New System.Windows.Forms.Button()
        Me.cmd_cctv_edit = New System.Windows.Forms.Button()
        Me.cmd_cctv_save = New System.Windows.Forms.Button()
        Me.cmd_cctv_reload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_cctv_filter = New System.Windows.Forms.ComboBox()
        Me.cmd_cctv_filter = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dtgv_cctv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "สถานที่ตั้ง"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(39, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hubs"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(3, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(7, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Serail No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(263, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Region"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(278, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Apps"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(269, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Brand"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(252, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Solfware"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(255, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 18)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Camera"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(515, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 18)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "เพิ่มเติม"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(515, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "ประเภท"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(484, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 18)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "IP address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(525, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 18)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Port"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(498, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 18)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Remark"
        '
        'txt_cctv_location
        '
        Me.txt_cctv_location.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_location.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_cctv_location.Location = New System.Drawing.Point(86, 16)
        Me.txt_cctv_location.Name = "txt_cctv_location"
        Me.txt_cctv_location.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_location.TabIndex = 1
        '
        'txt_cctv_hubs
        '
        Me.txt_cctv_hubs.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_hubs.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_hubs.Location = New System.Drawing.Point(86, 45)
        Me.txt_cctv_hubs.Name = "txt_cctv_hubs"
        Me.txt_cctv_hubs.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_hubs.TabIndex = 2
        '
        'txt_cctv_user
        '
        Me.txt_cctv_user.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_user.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_user.Location = New System.Drawing.Point(86, 74)
        Me.txt_cctv_user.Name = "txt_cctv_user"
        Me.txt_cctv_user.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_user.TabIndex = 3
        '
        'txt_cctv_password
        '
        Me.txt_cctv_password.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_password.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_password.Location = New System.Drawing.Point(86, 103)
        Me.txt_cctv_password.Name = "txt_cctv_password"
        Me.txt_cctv_password.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_password.TabIndex = 4
        '
        'txt_cctv_serail
        '
        Me.txt_cctv_serail.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_serail.ForeColor = System.Drawing.Color.Red
        Me.txt_cctv_serail.Location = New System.Drawing.Point(86, 132)
        Me.txt_cctv_serail.Name = "txt_cctv_serail"
        Me.txt_cctv_serail.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_serail.TabIndex = 5
        '
        'txt_cctv_remark
        '
        Me.txt_cctv_remark.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_remark.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_remark.Location = New System.Drawing.Point(565, 132)
        Me.txt_cctv_remark.Name = "txt_cctv_remark"
        Me.txt_cctv_remark.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_remark.TabIndex = 15
        '
        'txt_cctv_type
        '
        Me.txt_cctv_type.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_type.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_type.Location = New System.Drawing.Point(565, 45)
        Me.txt_cctv_type.Name = "txt_cctv_type"
        Me.txt_cctv_type.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_type.TabIndex = 12
        '
        'txt_cctv_other
        '
        Me.txt_cctv_other.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_other.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_other.Location = New System.Drawing.Point(565, 16)
        Me.txt_cctv_other.Name = "txt_cctv_other"
        Me.txt_cctv_other.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_other.TabIndex = 11
        '
        'txt_cctv_solfware
        '
        Me.txt_cctv_solfware.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_solfware.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_solfware.Location = New System.Drawing.Point(322, 103)
        Me.txt_cctv_solfware.Name = "txt_cctv_solfware"
        Me.txt_cctv_solfware.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_solfware.TabIndex = 9
        '
        'txt_cctv_apps
        '
        Me.txt_cctv_apps.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_apps.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_apps.Location = New System.Drawing.Point(322, 45)
        Me.txt_cctv_apps.Name = "txt_cctv_apps"
        Me.txt_cctv_apps.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_apps.TabIndex = 7
        '
        'txt_cctv_port
        '
        Me.txt_cctv_port.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_port.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_port.Location = New System.Drawing.Point(565, 103)
        Me.txt_cctv_port.Name = "txt_cctv_port"
        Me.txt_cctv_port.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_port.TabIndex = 14
        '
        'txt_cctv_ip
        '
        Me.txt_cctv_ip.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_ip.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_ip.Location = New System.Drawing.Point(565, 74)
        Me.txt_cctv_ip.Name = "txt_cctv_ip"
        Me.txt_cctv_ip.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_ip.TabIndex = 13
        '
        'txt_cctv_camera
        '
        Me.txt_cctv_camera.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_camera.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_camera.Location = New System.Drawing.Point(322, 132)
        Me.txt_cctv_camera.Name = "txt_cctv_camera"
        Me.txt_cctv_camera.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_camera.TabIndex = 10
        '
        'txt_cctv_brand
        '
        Me.txt_cctv_brand.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_brand.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_brand.Location = New System.Drawing.Point(322, 74)
        Me.txt_cctv_brand.Name = "txt_cctv_brand"
        Me.txt_cctv_brand.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_brand.TabIndex = 8
        '
        'txt_cctv_region
        '
        Me.txt_cctv_region.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cctv_region.ForeColor = System.Drawing.Color.Blue
        Me.txt_cctv_region.Location = New System.Drawing.Point(322, 16)
        Me.txt_cctv_region.Name = "txt_cctv_region"
        Me.txt_cctv_region.Size = New System.Drawing.Size(157, 23)
        Me.txt_cctv_region.TabIndex = 6
        '
        'dtgv_cctv
        '
        Me.dtgv_cctv.AllowUserToAddRows = False
        Me.dtgv_cctv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgv_cctv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv_cctv.BackgroundColor = System.Drawing.Color.White
        Me.dtgv_cctv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_cctv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv_cctv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_cctv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv_cctv.GridColor = System.Drawing.Color.Navy
        Me.dtgv_cctv.Location = New System.Drawing.Point(12, 174)
        Me.dtgv_cctv.Name = "dtgv_cctv"
        Me.dtgv_cctv.ReadOnly = True
        Me.dtgv_cctv.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dtgv_cctv.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgv_cctv.Size = New System.Drawing.Size(984, 528)
        Me.dtgv_cctv.TabIndex = 35
        '
        'cmd_cctv_delete
        '
        Me.cmd_cctv_delete.AutoSize = True
        Me.cmd_cctv_delete.BackColor = System.Drawing.Color.White
        Me.cmd_cctv_delete.ForeColor = System.Drawing.Color.Black
        Me.cmd_cctv_delete.Image = Global.SCANDB.My.Resources.Resources.delete1
        Me.cmd_cctv_delete.Location = New System.Drawing.Point(896, 62)
        Me.cmd_cctv_delete.Name = "cmd_cctv_delete"
        Me.cmd_cctv_delete.Size = New System.Drawing.Size(96, 30)
        Me.cmd_cctv_delete.TabIndex = 17
        Me.cmd_cctv_delete.Text = "DELETE"
        Me.cmd_cctv_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cctv_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cctv_delete.UseVisualStyleBackColor = False
        '
        'cmd_cctv_edit
        '
        Me.cmd_cctv_edit.AutoSize = True
        Me.cmd_cctv_edit.BackColor = System.Drawing.Color.White
        Me.cmd_cctv_edit.ForeColor = System.Drawing.Color.Black
        Me.cmd_cctv_edit.Image = Global.SCANDB.My.Resources.Resources.Actions_edit_rename_icon24x24
        Me.cmd_cctv_edit.Location = New System.Drawing.Point(794, 97)
        Me.cmd_cctv_edit.Name = "cmd_cctv_edit"
        Me.cmd_cctv_edit.Size = New System.Drawing.Size(96, 30)
        Me.cmd_cctv_edit.TabIndex = 18
        Me.cmd_cctv_edit.Text = "EDIT"
        Me.cmd_cctv_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cctv_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cctv_edit.UseVisualStyleBackColor = False
        '
        'cmd_cctv_save
        '
        Me.cmd_cctv_save.AutoSize = True
        Me.cmd_cctv_save.BackColor = System.Drawing.Color.White
        Me.cmd_cctv_save.ForeColor = System.Drawing.Color.Black
        Me.cmd_cctv_save.Image = Global.SCANDB.My.Resources.Resources.Save_16x16
        Me.cmd_cctv_save.Location = New System.Drawing.Point(794, 62)
        Me.cmd_cctv_save.Name = "cmd_cctv_save"
        Me.cmd_cctv_save.Size = New System.Drawing.Size(96, 30)
        Me.cmd_cctv_save.TabIndex = 16
        Me.cmd_cctv_save.Text = "SAVE"
        Me.cmd_cctv_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cctv_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cctv_save.UseVisualStyleBackColor = False
        '
        'cmd_cctv_reload
        '
        Me.cmd_cctv_reload.AutoSize = True
        Me.cmd_cctv_reload.BackColor = System.Drawing.Color.White
        Me.cmd_cctv_reload.ForeColor = System.Drawing.Color.Black
        Me.cmd_cctv_reload.Image = Global.SCANDB.My.Resources.Resources.refresh
        Me.cmd_cctv_reload.Location = New System.Drawing.Point(896, 97)
        Me.cmd_cctv_reload.Name = "cmd_cctv_reload"
        Me.cmd_cctv_reload.Size = New System.Drawing.Size(96, 30)
        Me.cmd_cctv_reload.TabIndex = 19
        Me.cmd_cctv_reload.Text = "RELOAD"
        Me.cmd_cctv_reload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cctv_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cctv_reload.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cctv_serail)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_port)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_ip)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_camera)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_brand)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_region)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_remark)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_type)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_other)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_solfware)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_apps)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_location)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_password)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_hubs)
        Me.GroupBox1.Controls.Add(Me.txt_cctv_user)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 165)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายละเอียด"
        '
        'cbo_cctv_filter
        '
        Me.cbo_cctv_filter.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_cctv_filter.FormattingEnabled = True
        Me.cbo_cctv_filter.Location = New System.Drawing.Point(6, 19)
        Me.cbo_cctv_filter.Name = "cbo_cctv_filter"
        Me.cbo_cctv_filter.Size = New System.Drawing.Size(127, 26)
        Me.cbo_cctv_filter.TabIndex = 20
        '
        'cmd_cctv_filter
        '
        Me.cmd_cctv_filter.AutoSize = True
        Me.cmd_cctv_filter.BackColor = System.Drawing.Color.White
        Me.cmd_cctv_filter.ForeColor = System.Drawing.Color.Black
        Me.cmd_cctv_filter.Image = Global.SCANDB.My.Resources.Resources.filter_icon16x16
        Me.cmd_cctv_filter.Location = New System.Drawing.Point(139, 16)
        Me.cmd_cctv_filter.Name = "cmd_cctv_filter"
        Me.cmd_cctv_filter.Size = New System.Drawing.Size(96, 30)
        Me.cmd_cctv_filter.TabIndex = 21
        Me.cmd_cctv_filter.Text = "Filter"
        Me.cmd_cctv_filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cctv_filter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_cctv_filter.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbo_cctv_filter)
        Me.GroupBox2.Controls.Add(Me.cmd_cctv_filter)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(757, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 53)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ภูมิภาค"
        '
        'FrmmanageCCTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmd_cctv_reload)
        Me.Controls.Add(Me.cmd_cctv_save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_cctv_edit)
        Me.Controls.Add(Me.cmd_cctv_delete)
        Me.Controls.Add(Me.dtgv_cctv)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmmanageCCTV"
        Me.Text = "รายละเอียด CCTV"
        CType(Me.dtgv_cctv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_cctv_location As TextBox
    Friend WithEvents txt_cctv_hubs As TextBox
    Friend WithEvents txt_cctv_user As TextBox
    Friend WithEvents txt_cctv_password As TextBox
    Friend WithEvents txt_cctv_serail As TextBox
    Friend WithEvents txt_cctv_remark As TextBox
    Friend WithEvents txt_cctv_type As TextBox
    Friend WithEvents txt_cctv_other As TextBox
    Friend WithEvents txt_cctv_solfware As TextBox
    Friend WithEvents txt_cctv_apps As TextBox
    Friend WithEvents txt_cctv_port As TextBox
    Friend WithEvents txt_cctv_ip As TextBox
    Friend WithEvents txt_cctv_camera As TextBox
    Friend WithEvents txt_cctv_brand As TextBox
    Friend WithEvents txt_cctv_region As TextBox
    Friend WithEvents dtgv_cctv As DataGridView
    Friend WithEvents cmd_cctv_delete As Button
    Friend WithEvents cmd_cctv_edit As Button
    Friend WithEvents cmd_cctv_save As Button
    Friend WithEvents cmd_cctv_reload As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_cctv_filter As ComboBox
    Friend WithEvents cmd_cctv_filter As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
