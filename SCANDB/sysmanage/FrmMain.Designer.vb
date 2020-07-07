<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsl_ip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsl_id = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslusername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsl_username = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslgroup = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsl_group = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsltime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsl_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslpcname = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsl_pcname = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslversion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsl_version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.txt_timer = New System.Windows.Forms.ToolStripTextBox()
        Me.txt_datetoday = New System.Windows.Forms.ToolStripTextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DbPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tab_execution = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_EXEverify = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_EXEStatement = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_EXEWDS = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_EXEACC = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_exeport = New System.Windows.Forms.ToolStripMenuItem()
        Me.tab_scanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.KBANKscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSSscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.TMBscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCBscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.UOBscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbankscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.KKBscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.ออกจากระบบToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.accms = New System.Windows.Forms.ToolStripMenuItem()
        Me.settingms = New System.Windows.Forms.ToolStripMenuItem()
        Me.Historyms = New System.Windows.Forms.ToolStripMenuItem()
        Me.changespassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.อพโหลดToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Uploads = New System.Windows.Forms.ToolStripMenuItem()
        Me.Upload_exe = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tab_report = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslip, Me.tsl_ip, Me.tslid, Me.tsl_id, Me.tslusername, Me.tsl_username, Me.tslgroup, Me.tsl_group, Me.tsltime, Me.tsl_time, Me.tslpcname, Me.tsl_pcname, Me.tslversion, Me.tsl_version})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 960)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1264, 25)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.StatusStrip1.UseWaitCursor = True
        '
        'tslip
        '
        Me.tslip.Name = "tslip"
        Me.tslip.Size = New System.Drawing.Size(28, 20)
        Me.tslip.Text = "IP :"
        '
        'tsl_ip
        '
        Me.tsl_ip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsl_ip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsl_ip.ForeColor = System.Drawing.Color.Green
        Me.tsl_ip.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsl_ip.Name = "tsl_ip"
        Me.tsl_ip.Size = New System.Drawing.Size(28, 20)
        Me.tsl_ip.Text = "xxx"
        Me.tsl_ip.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.tsl_ip.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'tslid
        '
        Me.tslid.Name = "tslid"
        Me.tslid.Size = New System.Drawing.Size(31, 20)
        Me.tslid.Text = "ID :"
        '
        'tsl_id
        '
        Me.tsl_id.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsl_id.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsl_id.ForeColor = System.Drawing.Color.DarkGreen
        Me.tsl_id.Name = "tsl_id"
        Me.tsl_id.Size = New System.Drawing.Size(28, 20)
        Me.tsl_id.Text = "xxx"
        Me.tsl_id.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'tslusername
        '
        Me.tslusername.Name = "tslusername"
        Me.tslusername.Size = New System.Drawing.Size(82, 20)
        Me.tslusername.Text = "Username :"
        '
        'tsl_username
        '
        Me.tsl_username.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsl_username.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsl_username.ForeColor = System.Drawing.Color.Green
        Me.tsl_username.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsl_username.Name = "tsl_username"
        Me.tsl_username.Size = New System.Drawing.Size(28, 20)
        Me.tsl_username.Text = "xxx"
        Me.tsl_username.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.tsl_username.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'tslgroup
        '
        Me.tslgroup.Name = "tslgroup"
        Me.tslgroup.Size = New System.Drawing.Size(57, 20)
        Me.tslgroup.Text = "Group :"
        '
        'tsl_group
        '
        Me.tsl_group.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsl_group.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsl_group.ForeColor = System.Drawing.Color.Green
        Me.tsl_group.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsl_group.Name = "tsl_group"
        Me.tsl_group.Size = New System.Drawing.Size(28, 20)
        Me.tsl_group.Text = "xxx"
        Me.tsl_group.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.tsl_group.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'tsltime
        '
        Me.tsltime.Name = "tsltime"
        Me.tsltime.Size = New System.Drawing.Size(90, 20)
        Me.tsltime.Text = "Time Login :"
        '
        'tsl_time
        '
        Me.tsl_time.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsl_time.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsl_time.ForeColor = System.Drawing.Color.Green
        Me.tsl_time.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tsl_time.Name = "tsl_time"
        Me.tsl_time.Size = New System.Drawing.Size(28, 20)
        Me.tsl_time.Text = "xxx"
        Me.tsl_time.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.tsl_time.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'tslpcname
        '
        Me.tslpcname.Name = "tslpcname"
        Me.tslpcname.Size = New System.Drawing.Size(70, 20)
        Me.tslpcname.Text = "PC Name"
        '
        'tsl_pcname
        '
        Me.tsl_pcname.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsl_pcname.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsl_pcname.ForeColor = System.Drawing.Color.Green
        Me.tsl_pcname.Name = "tsl_pcname"
        Me.tsl_pcname.Size = New System.Drawing.Size(28, 20)
        Me.tsl_pcname.Text = "xxx"
        Me.tsl_pcname.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'tslversion
        '
        Me.tslversion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslversion.Name = "tslversion"
        Me.tslversion.Size = New System.Drawing.Size(51, 20)
        Me.tslversion.Text = "Version"
        '
        'tsl_version
        '
        Me.tsl_version.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsl_version.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsl_version.ForeColor = System.Drawing.Color.Green
        Me.tsl_version.Name = "tsl_version"
        Me.tsl_version.Size = New System.Drawing.Size(28, 20)
        Me.tsl_version.Text = "xxx"
        Me.tsl_version.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DbPDFToolStripMenuItem, Me.SettingToolStripMenuItem, Me.txt_timer, Me.ToolStripMenuItem1, Me.txt_datetoday, Me.ToolStripMenuItem2, Me.อพโหลดToolStripMenuItem, Me.รายงานToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 32)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'txt_timer
        '
        Me.txt_timer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txt_timer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_timer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_timer.Name = "txt_timer"
        Me.txt_timer.ReadOnly = True
        Me.txt_timer.Size = New System.Drawing.Size(100, 28)
        Me.txt_timer.Text = "Timer"
        Me.txt_timer.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_datetoday
        '
        Me.txt_datetoday.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txt_datetoday.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_datetoday.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_datetoday.Name = "txt_datetoday"
        Me.txt_datetoday.ReadOnly = True
        Me.txt_datetoday.Size = New System.Drawing.Size(100, 28)
        Me.txt_datetoday.Text = "Date"
        Me.txt_datetoday.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(149, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DbPDFToolStripMenuItem
        '
        Me.DbPDFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tab_execution, Me.tab_scanpdf, Me.ออกจากระบบToolStripMenuItem})
        Me.DbPDFToolStripMenuItem.Image = Global.SCANDB.My.Resources.Resources.accept
        Me.DbPDFToolStripMenuItem.Name = "DbPDFToolStripMenuItem"
        Me.DbPDFToolStripMenuItem.Size = New System.Drawing.Size(54, 28)
        Me.DbPDFToolStripMenuItem.Text = "เมนู"
        '
        'tab_execution
        '
        Me.tab_execution.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_EXEverify, Me.Menu_EXEStatement, Me.Menu_EXEWDS, Me.Menu_EXEACC, Me.Menu_exeport})
        Me.tab_execution.Image = Global.SCANDB.My.Resources.Resources.Folder_Folder_Options_icon16x16
        Me.tab_execution.Name = "tab_execution"
        Me.tab_execution.Size = New System.Drawing.Size(209, 22)
        Me.tab_execution.Text = "บังคับคดี (Execution)"
        '
        'Menu_EXEverify
        '
        Me.Menu_EXEverify.Image = Global.SCANDB.My.Resources.Resources.textfield_add
        Me.Menu_EXEverify.Name = "Menu_EXEverify"
        Me.Menu_EXEverify.Size = New System.Drawing.Size(185, 22)
        Me.Menu_EXEverify.Text = "ลงข้อมูลตรวจสำนวน"
        '
        'Menu_EXEStatement
        '
        Me.Menu_EXEStatement.Image = Global.SCANDB.My.Resources.Resources.Properties_16x16
        Me.Menu_EXEStatement.Name = "Menu_EXEStatement"
        Me.Menu_EXEStatement.Size = New System.Drawing.Size(185, 22)
        Me.Menu_EXEStatement.Text = "แถลงบัญชีบังคับคดี"
        '
        'Menu_EXEWDS
        '
        Me.Menu_EXEWDS.Image = Global.SCANDB.My.Resources.Resources.Jury_Law_icon16x16
        Me.Menu_EXEWDS.Name = "Menu_EXEWDS"
        Me.Menu_EXEWDS.Size = New System.Drawing.Size(185, 22)
        Me.Menu_EXEWDS.Text = "ถอนอายัด/ยึด"
        '
        'Menu_EXEACC
        '
        Me.Menu_EXEACC.Image = Global.SCANDB.My.Resources.Resources.application_form_edit
        Me.Menu_EXEACC.Name = "Menu_EXEACC"
        Me.Menu_EXEACC.Size = New System.Drawing.Size(185, 22)
        Me.Menu_EXEACC.Text = "บังคับคดีตั้งเรื่อง"
        '
        'Menu_exeport
        '
        Me.Menu_exeport.Image = Global.SCANDB.My.Resources.Resources.group_go
        Me.Menu_exeport.Name = "Menu_exeport"
        Me.Menu_exeport.Size = New System.Drawing.Size(185, 22)
        Me.Menu_exeport.Text = "งานฟ้องเองส่งคัด ปกส."
        '
        'tab_scanpdf
        '
        Me.tab_scanpdf.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KBANKscanpdf, Me.TSSscanpdf, Me.TMBscanpdf, Me.SCBscanpdf, Me.UOBscanpdf, Me.Tbankscanpdf, Me.KKBscanpdf})
        Me.tab_scanpdf.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__42_
        Me.tab_scanpdf.Name = "tab_scanpdf"
        Me.tab_scanpdf.Size = New System.Drawing.Size(209, 22)
        Me.tab_scanpdf.Text = "ค้นหาเอกสาร PDF"
        '
        'KBANKscanpdf
        '
        Me.KBANKscanpdf.Name = "KBANKscanpdf"
        Me.KBANKscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.KBANKscanpdf.Text = "KBANK"
        '
        'TSSscanpdf
        '
        Me.TSSscanpdf.Name = "TSSscanpdf"
        Me.TSSscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.TSSscanpdf.Text = "TSS"
        '
        'TMBscanpdf
        '
        Me.TMBscanpdf.Name = "TMBscanpdf"
        Me.TMBscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.TMBscanpdf.Text = "TMB"
        '
        'SCBscanpdf
        '
        Me.SCBscanpdf.Name = "SCBscanpdf"
        Me.SCBscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.SCBscanpdf.Text = "SCB"
        '
        'UOBscanpdf
        '
        Me.UOBscanpdf.Name = "UOBscanpdf"
        Me.UOBscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.UOBscanpdf.Text = "UOB"
        '
        'Tbankscanpdf
        '
        Me.Tbankscanpdf.Name = "Tbankscanpdf"
        Me.Tbankscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.Tbankscanpdf.Text = "TBANK"
        '
        'KKBscanpdf
        '
        Me.KKBscanpdf.Name = "KKBscanpdf"
        Me.KKBscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.KKBscanpdf.Text = "KKB"
        '
        'ออกจากระบบToolStripMenuItem
        '
        Me.ออกจากระบบToolStripMenuItem.Image = Global.SCANDB.My.Resources.Resources.delete
        Me.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem"
        Me.ออกจากระบบToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.ออกจากระบบToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.accms, Me.settingms, Me.Historyms, Me.changespassword})
        Me.SettingToolStripMenuItem.Image = Global.SCANDB.My.Resources.Resources.process
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(61, 28)
        Me.SettingToolStripMenuItem.Text = "ตั้งค่า"
        '
        'accms
        '
        Me.accms.Image = Global.SCANDB.My.Resources.Resources.users
        Me.accms.Name = "accms"
        Me.accms.Size = New System.Drawing.Size(294, 22)
        Me.accms.Text = "ตั้งค่าบัญชีผู้ใช้ (Account)"
        '
        'settingms
        '
        Me.settingms.Image = Global.SCANDB.My.Resources.Resources.page_process
        Me.settingms.Name = "settingms"
        Me.settingms.Size = New System.Drawing.Size(294, 22)
        Me.settingms.Text = "กำหนดค่าการใช้งานโปรแกรม (Setting)"
        '
        'Historyms
        '
        Me.Historyms.Image = Global.SCANDB.My.Resources.Resources.full_page
        Me.Historyms.Name = "Historyms"
        Me.Historyms.Size = New System.Drawing.Size(294, 22)
        Me.Historyms.Text = "ประวัติการเข้าใช้โปรแกรม (Log file)"
        '
        'changespassword
        '
        Me.changespassword.Image = Global.SCANDB.My.Resources.Resources.Actions_edit_rename_icon24x24
        Me.changespassword.Name = "changespassword"
        Me.changespassword.Size = New System.Drawing.Size(294, 22)
        Me.changespassword.Text = "เปลี่ยนรหัสผ่านผู้ใช้ (Changes Password)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.Image = Global.SCANDB.My.Resources.Resources._32x32_clock
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 28)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.AutoSize = False
        Me.ToolStripMenuItem2.Image = Global.SCANDB.My.Resources.Resources._32x32_calendar_empty
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(28, 28)
        '
        'อพโหลดToolStripMenuItem
        '
        Me.อพโหลดToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Uploads, Me.Upload_exe})
        Me.อพโหลดToolStripMenuItem.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.อพโหลดToolStripMenuItem.Name = "อพโหลดToolStripMenuItem"
        Me.อพโหลดToolStripMenuItem.Size = New System.Drawing.Size(96, 28)
        Me.อพโหลดToolStripMenuItem.Text = "นำเข้าข้อมูล"
        '
        'Uploads
        '
        Me.Uploads.Image = Global.SCANDB.My.Resources.Resources.Upload_24x24
        Me.Uploads.Name = "Uploads"
        Me.Uploads.Size = New System.Drawing.Size(306, 22)
        Me.Uploads.Text = "อัพโหลดข้อมูล PDF (Upload to Database) "
        '
        'Upload_exe
        '
        Me.Upload_exe.Image = Global.SCANDB.My.Resources.Resources.system_database_add_icon16x16
        Me.Upload_exe.Name = "Upload_exe"
        Me.Upload_exe.Size = New System.Drawing.Size(306, 22)
        Me.Upload_exe.Text = "อัพโหลดข้อมูลบังคับคดี (Upload Execution)"
        '
        'รายงานToolStripMenuItem
        '
        Me.รายงานToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tab_report})
        Me.รายงานToolStripMenuItem.Image = Global.SCANDB.My.Resources.Resources.table_row_delete
        Me.รายงานToolStripMenuItem.Name = "รายงานToolStripMenuItem"
        Me.รายงานToolStripMenuItem.Size = New System.Drawing.Size(74, 28)
        Me.รายงานToolStripMenuItem.Text = "รายงาน"
        '
        'tab_report
        '
        Me.tab_report.Image = Global.SCANDB.My.Resources.Resources.table_lightning
        Me.tab_report.Name = "tab_report"
        Me.tab_report.Size = New System.Drawing.Size(229, 22)
        Me.tab_report.Text = "รายงานส่งแถลงทำบัญชี-รับจ่าย"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.Text = "Search Document Legal"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DbPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tab_scanpdf As ToolStripMenuItem
    Friend WithEvents KBANKscanpdf As ToolStripMenuItem
    Friend WithEvents TSSscanpdf As ToolStripMenuItem
    Friend WithEvents TMBscanpdf As ToolStripMenuItem
    Friend WithEvents SCBscanpdf As ToolStripMenuItem
    Friend WithEvents UOBscanpdf As ToolStripMenuItem
    Friend WithEvents Tbankscanpdf As ToolStripMenuItem
    Friend WithEvents KKBscanpdf As ToolStripMenuItem
    Friend WithEvents ออกจากระบบToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents accms As ToolStripMenuItem
    Friend WithEvents tslip As ToolStripStatusLabel
    Friend WithEvents tsl_ip As ToolStripStatusLabel
    Friend WithEvents tslusername As ToolStripStatusLabel
    Friend WithEvents tsl_username As ToolStripStatusLabel
    Friend WithEvents tslgroup As ToolStripStatusLabel
    Friend WithEvents tsl_group As ToolStripStatusLabel
    Friend WithEvents tsltime As ToolStripStatusLabel
    Friend WithEvents tsl_time As ToolStripStatusLabel
    Friend WithEvents tslid As ToolStripStatusLabel
    Friend WithEvents tsl_id As ToolStripStatusLabel
    Friend WithEvents Timer As Timer
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txt_timer As ToolStripTextBox
    Friend WithEvents txt_datetoday As ToolStripTextBox
    Friend WithEvents tslversion As ToolStripStatusLabel
    Friend WithEvents tsl_version As ToolStripStatusLabel
    Friend WithEvents settingms As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents tslpcname As ToolStripStatusLabel
    Friend WithEvents tsl_pcname As ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Historyms As ToolStripMenuItem
    Friend WithEvents changespassword As ToolStripMenuItem
    Friend WithEvents อพโหลดToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Uploads As ToolStripMenuItem
    Friend WithEvents tab_execution As ToolStripMenuItem
    Friend WithEvents Menu_EXEStatement As ToolStripMenuItem
    Friend WithEvents Upload_exe As ToolStripMenuItem
    Friend WithEvents Menu_EXEWDS As ToolStripMenuItem
    Friend WithEvents รายงานToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tab_report As ToolStripMenuItem
    Friend WithEvents Menu_EXEACC As ToolStripMenuItem
    Friend WithEvents Menu_exeport As ToolStripMenuItem
    Friend WithEvents Menu_EXEverify As ToolStripMenuItem
End Class
