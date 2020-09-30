<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMastermain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMastermain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Main_menu_working = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_tab_execution = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_exeport = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ownership = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_EXEACC = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_EXEStatement = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_EXEverify = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_income = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_EXEWDS = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_insolvent = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_tab_scanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.KBANKscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSSscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.TMBscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.SCBscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.UOBscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tbankscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.KKBscanpdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_tab_Accounting = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_accounting_search = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Tab_Zero = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Tab_ScbLegal = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_tab_ScbCollector = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_tap_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Main_menu_setting = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_accms = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_settingms = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Historyms = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_changespassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_logexe = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_timer = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_datetoday = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Main_Menu_upload = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_upload_scan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENU_Uploads_SCANPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_list_Accounting = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_upload_exe = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Upload_Execution = New System.Windows.Forms.ToolStripMenuItem()
        Me.Main_Menu_report = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_tab_report = New System.Windows.Forms.ToolStripMenuItem()
        Me.สงออกขอมลบงคบคดToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ReportAccounting = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Reportstatement = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Reporttracking = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_ReportWDS = New System.Windows.Forms.ToolStripMenuItem()
        Me.Main_menu_it = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Main_menu_working, Me.Main_menu_setting, Me.txt_timer, Me.ToolStripMenuItem1, Me.txt_datetoday, Me.ToolStripMenuItem2, Me.Main_Menu_upload, Me.Main_Menu_report, Me.Main_menu_it})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 32)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Main_menu_working
        '
        Me.Main_menu_working.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_tab_execution, Me.Menu_tab_scanpdf, Me.Menu_tab_Accounting, Me.Menu_Tab_Zero, Me.Menu_tap_logout})
        Me.Main_menu_working.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Main_menu_working.Image = Global.SCANDB.My.Resources.Resources.accept
        Me.Main_menu_working.Name = "Main_menu_working"
        Me.Main_menu_working.Size = New System.Drawing.Size(54, 28)
        Me.Main_menu_working.Text = "เมนู"
        '
        'Menu_tab_execution
        '
        Me.Menu_tab_execution.BackColor = System.Drawing.Color.White
        Me.Menu_tab_execution.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_exeport, Me.Menu_ownership, Me.Menu_EXEACC, Me.Menu_EXEStatement, Me.Menu_EXEverify, Me.Menu_income, Me.Menu_EXEWDS, Me.Menu_insolvent})
        Me.Menu_tab_execution.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_tab_execution.Image = Global.SCANDB.My.Resources.Resources.link_break
        Me.Menu_tab_execution.Name = "Menu_tab_execution"
        Me.Menu_tab_execution.Size = New System.Drawing.Size(209, 22)
        Me.Menu_tab_execution.Text = "บังคับคดี (Execution)"
        '
        'Menu_exeport
        '
        Me.Menu_exeport.BackColor = System.Drawing.Color.White
        Me.Menu_exeport.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_exeport.Image = Global.SCANDB.My.Resources.Resources.group_go
        Me.Menu_exeport.Name = "Menu_exeport"
        Me.Menu_exeport.Size = New System.Drawing.Size(193, 22)
        Me.Menu_exeport.Text = "งานฟ้องเองส่งคัด ปกส."
        '
        'Menu_ownership
        '
        Me.Menu_ownership.BackColor = System.Drawing.Color.White
        Me.Menu_ownership.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_ownership.Image = Global.SCANDB.My.Resources.Resources.building
        Me.Menu_ownership.Name = "Menu_ownership"
        Me.Menu_ownership.Size = New System.Drawing.Size(193, 22)
        Me.Menu_ownership.Text = "ข้อมูล กรรมสิทธิ์ลูกค้า"
        '
        'Menu_EXEACC
        '
        Me.Menu_EXEACC.BackColor = System.Drawing.Color.White
        Me.Menu_EXEACC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_EXEACC.Image = Global.SCANDB.My.Resources.Resources.application_form_edit
        Me.Menu_EXEACC.Name = "Menu_EXEACC"
        Me.Menu_EXEACC.Size = New System.Drawing.Size(193, 22)
        Me.Menu_EXEACC.Text = "บังคับคดีตั้งเรื่อง"
        '
        'Menu_EXEStatement
        '
        Me.Menu_EXEStatement.BackColor = System.Drawing.Color.White
        Me.Menu_EXEStatement.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_EXEStatement.Image = Global.SCANDB.My.Resources.Resources.Properties_16x16
        Me.Menu_EXEStatement.Name = "Menu_EXEStatement"
        Me.Menu_EXEStatement.Size = New System.Drawing.Size(193, 22)
        Me.Menu_EXEStatement.Text = "แถลงบัญชีบังคับคดี"
        '
        'Menu_EXEverify
        '
        Me.Menu_EXEverify.BackColor = System.Drawing.Color.White
        Me.Menu_EXEverify.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_EXEverify.Image = Global.SCANDB.My.Resources.Resources.textfield_add
        Me.Menu_EXEverify.Name = "Menu_EXEverify"
        Me.Menu_EXEverify.Size = New System.Drawing.Size(193, 22)
        Me.Menu_EXEverify.Text = "ลงข้อมูลตรวจสำนวน"
        '
        'Menu_income
        '
        Me.Menu_income.BackColor = System.Drawing.Color.White
        Me.Menu_income.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_income.Image = Global.SCANDB.My.Resources.Resources.coins_add
        Me.Menu_income.Name = "Menu_income"
        Me.Menu_income.Size = New System.Drawing.Size(193, 22)
        Me.Menu_income.Text = "เงินส่วนได้/คชจ.คืนโจทก์"
        '
        'Menu_EXEWDS
        '
        Me.Menu_EXEWDS.BackColor = System.Drawing.Color.White
        Me.Menu_EXEWDS.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_EXEWDS.Image = Global.SCANDB.My.Resources.Resources.coins_delete1
        Me.Menu_EXEWDS.Name = "Menu_EXEWDS"
        Me.Menu_EXEWDS.Size = New System.Drawing.Size(193, 22)
        Me.Menu_EXEWDS.Text = "ถอนอายัด/ยึด"
        '
        'Menu_insolvent
        '
        Me.Menu_insolvent.BackColor = System.Drawing.Color.White
        Me.Menu_insolvent.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_insolvent.Image = Global.SCANDB.My.Resources.Resources.lorry_error
        Me.Menu_insolvent.Name = "Menu_insolvent"
        Me.Menu_insolvent.Size = New System.Drawing.Size(193, 22)
        Me.Menu_insolvent.Text = "ข้อมูลลูกค้าล้มละลาย"
        '
        'Menu_tab_scanpdf
        '
        Me.Menu_tab_scanpdf.BackColor = System.Drawing.Color.White
        Me.Menu_tab_scanpdf.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KBANKscanpdf, Me.TSSscanpdf, Me.TMBscanpdf, Me.SCBscanpdf, Me.UOBscanpdf, Me.Tbankscanpdf, Me.KKBscanpdf})
        Me.Menu_tab_scanpdf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_tab_scanpdf.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__42_
        Me.Menu_tab_scanpdf.Name = "Menu_tab_scanpdf"
        Me.Menu_tab_scanpdf.Size = New System.Drawing.Size(209, 22)
        Me.Menu_tab_scanpdf.Text = "ค้นหาเอกสาร PDF"
        '
        'KBANKscanpdf
        '
        Me.KBANKscanpdf.BackColor = System.Drawing.Color.White
        Me.KBANKscanpdf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.KBANKscanpdf.Image = Global.SCANDB.My.Resources.Resources.kbanklogo
        Me.KBANKscanpdf.Name = "KBANKscanpdf"
        Me.KBANKscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.KBANKscanpdf.Text = "KBANK"
        '
        'TSSscanpdf
        '
        Me.TSSscanpdf.BackColor = System.Drawing.Color.White
        Me.TSSscanpdf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TSSscanpdf.Image = Global.SCANDB.My.Resources.Resources.TSS01
        Me.TSSscanpdf.Name = "TSSscanpdf"
        Me.TSSscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.TSSscanpdf.Text = "TSS"
        '
        'TMBscanpdf
        '
        Me.TMBscanpdf.BackColor = System.Drawing.Color.White
        Me.TMBscanpdf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TMBscanpdf.Image = Global.SCANDB.My.Resources.Resources._5462_image_th
        Me.TMBscanpdf.Name = "TMBscanpdf"
        Me.TMBscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.TMBscanpdf.Text = "TMB"
        '
        'SCBscanpdf
        '
        Me.SCBscanpdf.BackColor = System.Drawing.Color.White
        Me.SCBscanpdf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.SCBscanpdf.Image = Global.SCANDB.My.Resources.Resources._478a0c35f396963d0f65352b61809cb1___korat_hotels
        Me.SCBscanpdf.Name = "SCBscanpdf"
        Me.SCBscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.SCBscanpdf.Text = "SCB"
        '
        'UOBscanpdf
        '
        Me.UOBscanpdf.BackColor = System.Drawing.Color.White
        Me.UOBscanpdf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.UOBscanpdf.Image = Global.SCANDB.My.Resources.Resources.UOB
        Me.UOBscanpdf.Name = "UOBscanpdf"
        Me.UOBscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.UOBscanpdf.Text = "UOB"
        '
        'Tbankscanpdf
        '
        Me.Tbankscanpdf.BackColor = System.Drawing.Color.White
        Me.Tbankscanpdf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Tbankscanpdf.Image = Global.SCANDB.My.Resources.Resources.TBANK
        Me.Tbankscanpdf.Name = "Tbankscanpdf"
        Me.Tbankscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.Tbankscanpdf.Text = "TBANK"
        '
        'KKBscanpdf
        '
        Me.KKBscanpdf.BackColor = System.Drawing.Color.White
        Me.KKBscanpdf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.KKBscanpdf.Image = Global.SCANDB.My.Resources.Resources.Kiatnakin_Bank_logo
        Me.KKBscanpdf.Name = "KKBscanpdf"
        Me.KKBscanpdf.Size = New System.Drawing.Size(117, 22)
        Me.KKBscanpdf.Text = "KKB"
        '
        'Menu_tab_Accounting
        '
        Me.Menu_tab_Accounting.BackColor = System.Drawing.Color.White
        Me.Menu_tab_Accounting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_accounting_search})
        Me.Menu_tab_Accounting.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_tab_Accounting.Image = Global.SCANDB.My.Resources.Resources.coins
        Me.Menu_tab_Accounting.Name = "Menu_tab_Accounting"
        Me.Menu_tab_Accounting.Size = New System.Drawing.Size(209, 22)
        Me.Menu_tab_Accounting.Text = "ค้นหาเอกสาร/ข้อมูล เบิก"
        Me.Menu_tab_Accounting.Visible = False
        '
        'menu_accounting_search
        '
        Me.menu_accounting_search.BackColor = System.Drawing.Color.White
        Me.menu_accounting_search.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.menu_accounting_search.Image = Global.SCANDB.My.Resources.Resources.kbanklogo
        Me.menu_accounting_search.Name = "menu_accounting_search"
        Me.menu_accounting_search.Size = New System.Drawing.Size(117, 22)
        Me.menu_accounting_search.Text = "KBANK"
        '
        'Menu_Tab_Zero
        '
        Me.Menu_Tab_Zero.BackColor = System.Drawing.Color.White
        Me.Menu_Tab_Zero.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Tab_ScbLegal, Me.Menu_tab_ScbCollector})
        Me.Menu_Tab_Zero.ForeColor = System.Drawing.Color.Indigo
        Me.Menu_Tab_Zero.Image = Global.SCANDB.My.Resources.Resources._478a0c35f396963d0f65352b61809cb1___korat_hotels
        Me.Menu_Tab_Zero.Name = "Menu_Tab_Zero"
        Me.Menu_Tab_Zero.Size = New System.Drawing.Size(209, 22)
        Me.Menu_Tab_Zero.Text = "ข้อมูล SCB (ZERO)"
        '
        'Menu_Tab_ScbLegal
        '
        Me.Menu_Tab_ScbLegal.ForeColor = System.Drawing.Color.Indigo
        Me.Menu_Tab_ScbLegal.Image = Global.SCANDB.My.Resources.Resources.filter_icon16x16
        Me.Menu_Tab_ScbLegal.Name = "Menu_Tab_ScbLegal"
        Me.Menu_Tab_ScbLegal.Size = New System.Drawing.Size(180, 22)
        Me.Menu_Tab_ScbLegal.Text = "SCB (LEGAL)"
        '
        'Menu_tab_ScbCollector
        '
        Me.Menu_tab_ScbCollector.ForeColor = System.Drawing.Color.Indigo
        Me.Menu_tab_ScbCollector.Image = Global.SCANDB.My.Resources.Resources.Customer_service_icon24x24
        Me.Menu_tab_ScbCollector.Name = "Menu_tab_ScbCollector"
        Me.Menu_tab_ScbCollector.Size = New System.Drawing.Size(180, 22)
        Me.Menu_tab_ScbCollector.Text = "SCB (COLLECTOR)"
        Me.Menu_tab_ScbCollector.Visible = False
        '
        'Menu_tap_logout
        '
        Me.Menu_tap_logout.BackColor = System.Drawing.Color.White
        Me.Menu_tap_logout.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_tap_logout.Image = Global.SCANDB.My.Resources.Resources.delete
        Me.Menu_tap_logout.Name = "Menu_tap_logout"
        Me.Menu_tap_logout.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.Menu_tap_logout.Size = New System.Drawing.Size(209, 22)
        Me.Menu_tap_logout.Text = "ออกจากระบบ"
        '
        'Main_menu_setting
        '
        Me.Main_menu_setting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_accms, Me.menu_settingms, Me.menu_Historyms, Me.menu_changespassword, Me.Menu_logexe})
        Me.Main_menu_setting.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Main_menu_setting.Image = Global.SCANDB.My.Resources.Resources.process
        Me.Main_menu_setting.Name = "Main_menu_setting"
        Me.Main_menu_setting.Size = New System.Drawing.Size(61, 28)
        Me.Main_menu_setting.Text = "ตั้งค่า"
        '
        'menu_accms
        '
        Me.menu_accms.BackColor = System.Drawing.Color.White
        Me.menu_accms.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.menu_accms.Image = Global.SCANDB.My.Resources.Resources.users
        Me.menu_accms.Name = "menu_accms"
        Me.menu_accms.Size = New System.Drawing.Size(294, 22)
        Me.menu_accms.Text = "ตั้งค่าบัญชีผู้ใช้ (Account)"
        '
        'menu_settingms
        '
        Me.menu_settingms.BackColor = System.Drawing.Color.White
        Me.menu_settingms.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.menu_settingms.Image = Global.SCANDB.My.Resources.Resources.page_process
        Me.menu_settingms.Name = "menu_settingms"
        Me.menu_settingms.Size = New System.Drawing.Size(294, 22)
        Me.menu_settingms.Text = "กำหนดค่าการใช้งานโปรแกรม (Setting)"
        '
        'menu_Historyms
        '
        Me.menu_Historyms.BackColor = System.Drawing.Color.White
        Me.menu_Historyms.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.menu_Historyms.Image = Global.SCANDB.My.Resources.Resources.full_page
        Me.menu_Historyms.Name = "menu_Historyms"
        Me.menu_Historyms.Size = New System.Drawing.Size(294, 22)
        Me.menu_Historyms.Text = "ประวัติการเข้าใช้โปรแกรม (Log file)"
        '
        'menu_changespassword
        '
        Me.menu_changespassword.BackColor = System.Drawing.Color.White
        Me.menu_changespassword.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.menu_changespassword.Image = Global.SCANDB.My.Resources.Resources.Actions_edit_rename_icon24x24
        Me.menu_changespassword.Name = "menu_changespassword"
        Me.menu_changespassword.Size = New System.Drawing.Size(294, 22)
        Me.menu_changespassword.Text = "เปลี่ยนรหัสผ่านผู้ใช้ (Changes Password)"
        '
        'Menu_logexe
        '
        Me.Menu_logexe.BackColor = System.Drawing.Color.White
        Me.Menu_logexe.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_logexe.Image = Global.SCANDB.My.Resources.Resources.monitor_lightning
        Me.Menu_logexe.Name = "Menu_logexe"
        Me.Menu_logexe.Size = New System.Drawing.Size(294, 22)
        Me.Menu_logexe.Text = "ประวัติการแก้ไขข้อมูล (Log file execution)"
        '
        'txt_timer
        '
        Me.txt_timer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txt_timer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_timer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_timer.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_timer.Name = "txt_timer"
        Me.txt_timer.ReadOnly = True
        Me.txt_timer.Size = New System.Drawing.Size(100, 28)
        Me.txt_timer.Text = "Timer"
        Me.txt_timer.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.Image = Global.SCANDB.My.Resources.Resources._32x32_clock
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 28)
        '
        'txt_datetoday
        '
        Me.txt_datetoday.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txt_datetoday.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_datetoday.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_datetoday.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txt_datetoday.Name = "txt_datetoday"
        Me.txt_datetoday.ReadOnly = True
        Me.txt_datetoday.Size = New System.Drawing.Size(100, 28)
        Me.txt_datetoday.Text = "Date"
        Me.txt_datetoday.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.AutoSize = False
        Me.ToolStripMenuItem2.Image = Global.SCANDB.My.Resources.Resources._32x32_calendar_empty
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(28, 28)
        '
        'Main_Menu_upload
        '
        Me.Main_Menu_upload.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_upload_scan, Me.Menu_upload_exe})
        Me.Main_Menu_upload.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Main_Menu_upload.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.Main_Menu_upload.Name = "Main_Menu_upload"
        Me.Main_Menu_upload.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Main_Menu_upload.Size = New System.Drawing.Size(96, 28)
        Me.Main_Menu_upload.Text = "นำเข้าข้อมูล"
        '
        'Menu_upload_scan
        '
        Me.Menu_upload_scan.BackColor = System.Drawing.Color.White
        Me.Menu_upload_scan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENU_Uploads_SCANPDF, Me.Menu_list_Accounting})
        Me.Menu_upload_scan.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_upload_scan.Image = Global.SCANDB.My.Resources.Resources.system_database_add_icon16x16
        Me.Menu_upload_scan.Name = "Menu_upload_scan"
        Me.Menu_upload_scan.Size = New System.Drawing.Size(218, 22)
        Me.Menu_upload_scan.Text = "UPLOAD ข้อมูล File SCAN"
        '
        'MENU_Uploads_SCANPDF
        '
        Me.MENU_Uploads_SCANPDF.BackColor = System.Drawing.Color.White
        Me.MENU_Uploads_SCANPDF.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.MENU_Uploads_SCANPDF.Image = Global.SCANDB.My.Resources.Resources.image_add
        Me.MENU_Uploads_SCANPDF.Name = "MENU_Uploads_SCANPDF"
        Me.MENU_Uploads_SCANPDF.Size = New System.Drawing.Size(306, 22)
        Me.MENU_Uploads_SCANPDF.Text = "อัพโหลดข้อมูล PDF (Upload to Database) "
        '
        'Menu_list_Accounting
        '
        Me.Menu_list_Accounting.BackColor = System.Drawing.Color.White
        Me.Menu_list_Accounting.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_list_Accounting.Image = Global.SCANDB.My.Resources.Resources.table_key
        Me.Menu_list_Accounting.Name = "Menu_list_Accounting"
        Me.Menu_list_Accounting.Size = New System.Drawing.Size(306, 22)
        Me.Menu_list_Accounting.Text = "รายละเอียดข้อมูลเบิก"
        Me.Menu_list_Accounting.Visible = False
        '
        'Menu_upload_exe
        '
        Me.Menu_upload_exe.BackColor = System.Drawing.Color.White
        Me.Menu_upload_exe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Upload_Execution})
        Me.Menu_upload_exe.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_upload_exe.Image = Global.SCANDB.My.Resources.Resources.database_add
        Me.Menu_upload_exe.Name = "Menu_upload_exe"
        Me.Menu_upload_exe.Size = New System.Drawing.Size(218, 22)
        Me.Menu_upload_exe.Text = "UPLOAD ข้อมูล บังคับคดี"
        '
        'Menu_Upload_Execution
        '
        Me.Menu_Upload_Execution.BackColor = System.Drawing.Color.White
        Me.Menu_Upload_Execution.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_Upload_Execution.Image = Global.SCANDB.My.Resources.Resources.database_connect
        Me.Menu_Upload_Execution.Name = "Menu_Upload_Execution"
        Me.Menu_Upload_Execution.Size = New System.Drawing.Size(300, 22)
        Me.Menu_Upload_Execution.Text = "อัพโหลดข้อมูลบังคับคดี (Upload Execution)"
        '
        'Main_Menu_report
        '
        Me.Main_Menu_report.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_tab_report, Me.สงออกขอมลบงคบคดToolStripMenuItem})
        Me.Main_Menu_report.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Main_Menu_report.Image = Global.SCANDB.My.Resources.Resources.table_row_delete
        Me.Main_Menu_report.Name = "Main_Menu_report"
        Me.Main_Menu_report.Size = New System.Drawing.Size(74, 28)
        Me.Main_Menu_report.Text = "รายงาน"
        '
        'menu_tab_report
        '
        Me.menu_tab_report.BackColor = System.Drawing.Color.White
        Me.menu_tab_report.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.menu_tab_report.Image = Global.SCANDB.My.Resources.Resources.table_lightning
        Me.menu_tab_report.Name = "menu_tab_report"
        Me.menu_tab_report.Size = New System.Drawing.Size(273, 22)
        Me.menu_tab_report.Text = "รายงานส่งแถลงทำบัญชี-รับจ่าย"
        '
        'สงออกขอมลบงคบคดToolStripMenuItem
        '
        Me.สงออกขอมลบงคบคดToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_ReportAccounting, Me.Menu_Reportstatement, Me.Menu_Reporttracking, Me.Menu_ReportWDS})
        Me.สงออกขอมลบงคบคดToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.สงออกขอมลบงคบคดToolStripMenuItem.Image = Global.SCANDB.My.Resources.Resources.page_white_excel
        Me.สงออกขอมลบงคบคดToolStripMenuItem.Name = "สงออกขอมลบงคบคดToolStripMenuItem"
        Me.สงออกขอมลบงคบคดToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.สงออกขอมลบงคบคดToolStripMenuItem.Text = "ส่งออกข้อมูลบังคับคดี (Export/Report)"
        Me.สงออกขอมลบงคบคดToolStripMenuItem.Visible = False
        '
        'Menu_ReportAccounting
        '
        Me.Menu_ReportAccounting.BackColor = System.Drawing.Color.White
        Me.Menu_ReportAccounting.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_ReportAccounting.Image = Global.SCANDB.My.Resources.Resources.report_go
        Me.Menu_ReportAccounting.Name = "Menu_ReportAccounting"
        Me.Menu_ReportAccounting.Size = New System.Drawing.Size(381, 22)
        Me.Menu_ReportAccounting.Text = "รายงานบังคับคดีตั้งเรื่อง/ใบเสร็จวางค่าใช้จ่าย (ReportViewer)"
        '
        'Menu_Reportstatement
        '
        Me.Menu_Reportstatement.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_Reportstatement.Image = Global.SCANDB.My.Resources.Resources.report_go
        Me.Menu_Reportstatement.Name = "Menu_Reportstatement"
        Me.Menu_Reportstatement.Size = New System.Drawing.Size(381, 22)
        Me.Menu_Reportstatement.Text = "รายงานใบงานแถลงบัญชีรับ-จ่าย (ReportViewer)"
        '
        'Menu_Reporttracking
        '
        Me.Menu_Reporttracking.BackColor = System.Drawing.Color.White
        Me.Menu_Reporttracking.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_Reporttracking.Image = Global.SCANDB.My.Resources.Resources.report_go
        Me.Menu_Reporttracking.Name = "Menu_Reporttracking"
        Me.Menu_Reporttracking.Size = New System.Drawing.Size(381, 22)
        Me.Menu_Reporttracking.Text = "รายงานตรวจสำนวนแถลงบัญชี (ReportViewer)"
        '
        'Menu_ReportWDS
        '
        Me.Menu_ReportWDS.BackColor = System.Drawing.Color.White
        Me.Menu_ReportWDS.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Menu_ReportWDS.Image = Global.SCANDB.My.Resources.Resources.report_go
        Me.Menu_ReportWDS.Name = "Menu_ReportWDS"
        Me.Menu_ReportWDS.Size = New System.Drawing.Size(381, 22)
        Me.Menu_ReportWDS.Text = "รายงานถอนอายัด/ยึด (ReportViewer)"
        '
        'Main_menu_it
        '
        Me.Main_menu_it.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Main_menu_it.Image = Global.SCANDB.My.Resources.Resources.support_icon24x24
        Me.Main_menu_it.Name = "Main_menu_it"
        Me.Main_menu_it.Size = New System.Drawing.Size(97, 28)
        Me.Main_menu_it.Text = "IT Support"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslip, Me.tsl_ip, Me.tslid, Me.tsl_id, Me.tslusername, Me.tsl_username, Me.tslgroup, Me.tsl_group, Me.tsltime, Me.tsl_time, Me.tslpcname, Me.tsl_pcname, Me.tslversion, Me.tsl_version})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 704)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1008, 25)
        Me.StatusStrip1.TabIndex = 6
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
        Me.tsl_ip.ForeColor = System.Drawing.SystemColors.HotTrack
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
        Me.tsl_id.ForeColor = System.Drawing.SystemColors.HotTrack
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
        Me.tsl_username.ForeColor = System.Drawing.SystemColors.HotTrack
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
        Me.tsl_group.ForeColor = System.Drawing.SystemColors.HotTrack
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
        Me.tsl_time.ForeColor = System.Drawing.SystemColors.HotTrack
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
        Me.tsl_pcname.ForeColor = System.Drawing.SystemColors.HotTrack
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
        Me.tsl_version.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.tsl_version.Name = "tsl_version"
        Me.tsl_version.Size = New System.Drawing.Size(28, 20)
        Me.tsl_version.Text = "xxx"
        Me.tsl_version.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'FrmMastermain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMastermain"
        Me.Text = "FDS COLLECTIONS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Main_menu_working As ToolStripMenuItem
    Friend WithEvents Menu_tab_execution As ToolStripMenuItem
    Friend WithEvents Menu_exeport As ToolStripMenuItem
    Friend WithEvents Menu_ownership As ToolStripMenuItem
    Friend WithEvents Menu_EXEACC As ToolStripMenuItem
    Friend WithEvents Menu_EXEStatement As ToolStripMenuItem
    Friend WithEvents Menu_EXEverify As ToolStripMenuItem
    Friend WithEvents Menu_EXEWDS As ToolStripMenuItem
    Friend WithEvents Menu_insolvent As ToolStripMenuItem
    Friend WithEvents Menu_tab_scanpdf As ToolStripMenuItem
    Friend WithEvents KBANKscanpdf As ToolStripMenuItem
    Friend WithEvents TSSscanpdf As ToolStripMenuItem
    Friend WithEvents TMBscanpdf As ToolStripMenuItem
    Friend WithEvents SCBscanpdf As ToolStripMenuItem
    Friend WithEvents UOBscanpdf As ToolStripMenuItem
    Friend WithEvents Tbankscanpdf As ToolStripMenuItem
    Friend WithEvents KKBscanpdf As ToolStripMenuItem
    Friend WithEvents Menu_tab_Accounting As ToolStripMenuItem
    Friend WithEvents menu_accounting_search As ToolStripMenuItem
    Friend WithEvents Menu_Tab_Zero As ToolStripMenuItem
    Friend WithEvents Menu_Tab_ScbLegal As ToolStripMenuItem
    Friend WithEvents Menu_tab_ScbCollector As ToolStripMenuItem
    Friend WithEvents Menu_tap_logout As ToolStripMenuItem
    Friend WithEvents Main_menu_setting As ToolStripMenuItem
    Friend WithEvents menu_accms As ToolStripMenuItem
    Friend WithEvents menu_settingms As ToolStripMenuItem
    Friend WithEvents menu_Historyms As ToolStripMenuItem
    Friend WithEvents menu_changespassword As ToolStripMenuItem
    Friend WithEvents Menu_logexe As ToolStripMenuItem
    Friend WithEvents txt_timer As ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txt_datetoday As ToolStripTextBox
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Main_Menu_upload As ToolStripMenuItem
    Friend WithEvents Menu_upload_scan As ToolStripMenuItem
    Friend WithEvents MENU_Uploads_SCANPDF As ToolStripMenuItem
    Friend WithEvents Menu_list_Accounting As ToolStripMenuItem
    Friend WithEvents Menu_upload_exe As ToolStripMenuItem
    Friend WithEvents Menu_Upload_Execution As ToolStripMenuItem
    Friend WithEvents Main_Menu_report As ToolStripMenuItem
    Friend WithEvents menu_tab_report As ToolStripMenuItem
    Friend WithEvents Main_menu_it As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslip As ToolStripStatusLabel
    Friend WithEvents tsl_ip As ToolStripStatusLabel
    Friend WithEvents tslid As ToolStripStatusLabel
    Friend WithEvents tsl_id As ToolStripStatusLabel
    Friend WithEvents tslusername As ToolStripStatusLabel
    Friend WithEvents tsl_username As ToolStripStatusLabel
    Friend WithEvents tslgroup As ToolStripStatusLabel
    Friend WithEvents tsl_group As ToolStripStatusLabel
    Friend WithEvents tsltime As ToolStripStatusLabel
    Friend WithEvents tsl_time As ToolStripStatusLabel
    Friend WithEvents tslpcname As ToolStripStatusLabel
    Friend WithEvents tsl_pcname As ToolStripStatusLabel
    Friend WithEvents tslversion As ToolStripStatusLabel
    Friend WithEvents tsl_version As ToolStripStatusLabel
    Friend WithEvents Menu_income As ToolStripMenuItem
    Friend WithEvents Timer As Timer
    Friend WithEvents สงออกขอมลบงคบคดToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu_ReportAccounting As ToolStripMenuItem
    Friend WithEvents Menu_Reportstatement As ToolStripMenuItem
    Friend WithEvents Menu_Reporttracking As ToolStripMenuItem
    Friend WithEvents Menu_ReportWDS As ToolStripMenuItem
End Class
