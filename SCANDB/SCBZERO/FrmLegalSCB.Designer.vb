<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLegalSCB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLegalSCB))
        Me.Group_detail = New System.Windows.Forms.GroupBox()
        Me.Lbl_Osbalance = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_sumLegal = New System.Windows.Forms.Label()
        Me.Lbl_Legalscb = New System.Windows.Forms.Label()
        Me.Lbl_Legalzero = New System.Windows.Forms.Label()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.lbl_datetoday = New System.Windows.Forms.Label()
        Me.lbl_timer = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Cmd_ExportExcel = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.cbo_finds = New System.Windows.Forms.ComboBox()
        Me.Dtgv_SCBLEGAL = New System.Windows.Forms.DataGridView()
        Me.Dtgv_LawCollector = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dtgv_lawmonth = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Dtgv_LawRinv = New System.Windows.Forms.DataGridView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Group_detail.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Dtgv_SCBLEGAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtgv_LawCollector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dtgv_lawmonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dtgv_LawRinv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group_detail
        '
        Me.Group_detail.BackColor = System.Drawing.SystemColors.Window
        Me.Group_detail.Controls.Add(Me.Lbl_Osbalance)
        Me.Group_detail.Controls.Add(Me.Label5)
        Me.Group_detail.Controls.Add(Me.Lbl_sumLegal)
        Me.Group_detail.Controls.Add(Me.Lbl_Legalscb)
        Me.Group_detail.Controls.Add(Me.Lbl_Legalzero)
        Me.Group_detail.Controls.Add(Me.lbl_count)
        Me.Group_detail.Controls.Add(Me.lbl_datetoday)
        Me.Group_detail.Controls.Add(Me.lbl_timer)
        Me.Group_detail.Location = New System.Drawing.Point(713, 1)
        Me.Group_detail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Group_detail.Name = "Group_detail"
        Me.Group_detail.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Group_detail.Size = New System.Drawing.Size(293, 148)
        Me.Group_detail.TabIndex = 88
        Me.Group_detail.TabStop = False
        '
        'Lbl_Osbalance
        '
        Me.Lbl_Osbalance.BackColor = System.Drawing.Color.White
        Me.Lbl_Osbalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Osbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Osbalance.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Lbl_Osbalance.Location = New System.Drawing.Point(142, 102)
        Me.Lbl_Osbalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Osbalance.Name = "Lbl_Osbalance"
        Me.Lbl_Osbalance.Size = New System.Drawing.Size(141, 27)
        Me.Lbl_Osbalance.TabIndex = 14
        Me.Lbl_Osbalance.Text = "xxx"
        Me.Lbl_Osbalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(8, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 27)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Balance"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_sumLegal
        '
        Me.Lbl_sumLegal.BackColor = System.Drawing.Color.White
        Me.Lbl_sumLegal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_sumLegal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_sumLegal.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Lbl_sumLegal.Location = New System.Drawing.Point(142, 75)
        Me.Lbl_sumLegal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_sumLegal.Name = "Lbl_sumLegal"
        Me.Lbl_sumLegal.Size = New System.Drawing.Size(141, 27)
        Me.Lbl_sumLegal.TabIndex = 12
        Me.Lbl_sumLegal.Text = "xxx"
        Me.Lbl_sumLegal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Legalscb
        '
        Me.Lbl_Legalscb.BackColor = System.Drawing.Color.White
        Me.Lbl_Legalscb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Legalscb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Legalscb.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Lbl_Legalscb.Location = New System.Drawing.Point(142, 48)
        Me.Lbl_Legalscb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Legalscb.Name = "Lbl_Legalscb"
        Me.Lbl_Legalscb.Size = New System.Drawing.Size(141, 27)
        Me.Lbl_Legalscb.TabIndex = 11
        Me.Lbl_Legalscb.Text = "xxx"
        Me.Lbl_Legalscb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Legalzero
        '
        Me.Lbl_Legalzero.BackColor = System.Drawing.Color.White
        Me.Lbl_Legalzero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Legalzero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Legalzero.ForeColor = System.Drawing.Color.MediumSlateBlue
        Me.Lbl_Legalzero.Location = New System.Drawing.Point(142, 19)
        Me.Lbl_Legalzero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Legalzero.Name = "Lbl_Legalzero"
        Me.Lbl_Legalzero.Size = New System.Drawing.Size(141, 29)
        Me.Lbl_Legalzero.TabIndex = 10
        Me.Lbl_Legalzero.Text = "xxx"
        Me.Lbl_Legalzero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_count
        '
        Me.lbl_count.BackColor = System.Drawing.Color.White
        Me.lbl_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_count.ForeColor = System.Drawing.Color.Blue
        Me.lbl_count.Location = New System.Drawing.Point(8, 75)
        Me.lbl_count.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(139, 27)
        Me.lbl_count.TabIndex = 9
        Me.lbl_count.Text = "ข้อมูลทั้งหมด"
        Me.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_datetoday
        '
        Me.lbl_datetoday.BackColor = System.Drawing.Color.White
        Me.lbl_datetoday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_datetoday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_datetoday.ForeColor = System.Drawing.Color.Blue
        Me.lbl_datetoday.Location = New System.Drawing.Point(8, 48)
        Me.lbl_datetoday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_datetoday.Name = "lbl_datetoday"
        Me.lbl_datetoday.Size = New System.Drawing.Size(139, 27)
        Me.lbl_datetoday.TabIndex = 1
        Me.lbl_datetoday.Text = "ไม่ใช่ ZERO"
        Me.lbl_datetoday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_timer
        '
        Me.lbl_timer.BackColor = System.Drawing.Color.White
        Me.lbl_timer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_timer.ForeColor = System.Drawing.Color.Blue
        Me.lbl_timer.Location = New System.Drawing.Point(8, 19)
        Me.lbl_timer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_timer.Name = "lbl_timer"
        Me.lbl_timer.Size = New System.Drawing.Size(139, 29)
        Me.lbl_timer.TabIndex = 0
        Me.lbl_timer.Text = "ฟ้อง ZERO"
        Me.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Cmd_ExportExcel)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.cmd_search)
        Me.GroupBox5.Controls.Add(Me.cbo_finds)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(7, 1)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Size = New System.Drawing.Size(700, 65)
        Me.GroupBox5.TabIndex = 89
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ค้นหาข้อมูล"
        '
        'Cmd_ExportExcel
        '
        Me.Cmd_ExportExcel.BackColor = System.Drawing.Color.White
        Me.Cmd_ExportExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_ExportExcel.ForeColor = System.Drawing.Color.Blue
        Me.Cmd_ExportExcel.Image = Global.SCANDB.My.Resources.Resources.Excel_icon
        Me.Cmd_ExportExcel.Location = New System.Drawing.Point(467, 19)
        Me.Cmd_ExportExcel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Cmd_ExportExcel.Name = "Cmd_ExportExcel"
        Me.Cmd_ExportExcel.Size = New System.Drawing.Size(143, 33)
        Me.Cmd_ExportExcel.TabIndex = 94
        Me.Cmd_ExportExcel.Text = "Export Excel File"
        Me.Cmd_ExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_ExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cmd_ExportExcel.UseVisualStyleBackColor = False
        Me.Cmd_ExportExcel.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 18)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "ประเภทข้อมูล"
        '
        'cmd_search
        '
        Me.cmd_search.BackColor = System.Drawing.Color.White
        Me.cmd_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_search.Image = CType(resources.GetObject("cmd_search.Image"), System.Drawing.Image)
        Me.cmd_search.Location = New System.Drawing.Point(338, 19)
        Me.cmd_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(121, 33)
        Me.cmd_search.TabIndex = 3
        Me.cmd_search.Text = "ค้นหาข้อมูล"
        Me.cmd_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_search.UseVisualStyleBackColor = False
        '
        'cbo_finds
        '
        Me.cbo_finds.FormattingEnabled = True
        Me.cbo_finds.Location = New System.Drawing.Point(87, 24)
        Me.cbo_finds.Name = "cbo_finds"
        Me.cbo_finds.Size = New System.Drawing.Size(244, 26)
        Me.cbo_finds.TabIndex = 1
        '
        'Dtgv_SCBLEGAL
        '
        Me.Dtgv_SCBLEGAL.AllowUserToAddRows = False
        Me.Dtgv_SCBLEGAL.AllowUserToDeleteRows = False
        Me.Dtgv_SCBLEGAL.BackgroundColor = System.Drawing.Color.White
        Me.Dtgv_SCBLEGAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_SCBLEGAL.EnableHeadersVisualStyles = False
        Me.Dtgv_SCBLEGAL.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtgv_SCBLEGAL.Location = New System.Drawing.Point(7, 74)
        Me.Dtgv_SCBLEGAL.Name = "Dtgv_SCBLEGAL"
        Me.Dtgv_SCBLEGAL.ReadOnly = True
        Me.Dtgv_SCBLEGAL.RowHeadersVisible = False
        Me.Dtgv_SCBLEGAL.Size = New System.Drawing.Size(700, 365)
        Me.Dtgv_SCBLEGAL.TabIndex = 90
        '
        'Dtgv_LawCollector
        '
        Me.Dtgv_LawCollector.AllowUserToAddRows = False
        Me.Dtgv_LawCollector.AllowUserToDeleteRows = False
        Me.Dtgv_LawCollector.BackgroundColor = System.Drawing.Color.White
        Me.Dtgv_LawCollector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_LawCollector.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtgv_LawCollector.Location = New System.Drawing.Point(8, 22)
        Me.Dtgv_LawCollector.Name = "Dtgv_LawCollector"
        Me.Dtgv_LawCollector.ReadOnly = True
        Me.Dtgv_LawCollector.RowHeadersVisible = False
        Me.Dtgv_LawCollector.Size = New System.Drawing.Size(279, 250)
        Me.Dtgv_LawCollector.TabIndex = 92
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dtgv_LawCollector)
        Me.GroupBox1.Location = New System.Drawing.Point(713, 445)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 280)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "งานฟ้อง/USER"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dtgv_lawmonth)
        Me.GroupBox2.Location = New System.Drawing.Point(713, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 284)
        Me.GroupBox2.TabIndex = 94
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "งานฟ้องทั้งหมด"
        '
        'Dtgv_lawmonth
        '
        Me.Dtgv_lawmonth.AllowUserToAddRows = False
        Me.Dtgv_lawmonth.AllowUserToDeleteRows = False
        Me.Dtgv_lawmonth.BackgroundColor = System.Drawing.Color.White
        Me.Dtgv_lawmonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_lawmonth.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtgv_lawmonth.Location = New System.Drawing.Point(8, 22)
        Me.Dtgv_lawmonth.Name = "Dtgv_lawmonth"
        Me.Dtgv_lawmonth.ReadOnly = True
        Me.Dtgv_lawmonth.RowHeadersVisible = False
        Me.Dtgv_lawmonth.Size = New System.Drawing.Size(279, 251)
        Me.Dtgv_lawmonth.TabIndex = 92
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dtgv_LawRinv)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 445)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(396, 280)
        Me.GroupBox3.TabIndex = 94
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "งานสืบ"
        '
        'Dtgv_LawRinv
        '
        Me.Dtgv_LawRinv.AllowUserToAddRows = False
        Me.Dtgv_LawRinv.AllowUserToDeleteRows = False
        Me.Dtgv_LawRinv.BackgroundColor = System.Drawing.Color.White
        Me.Dtgv_LawRinv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_LawRinv.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtgv_LawRinv.Location = New System.Drawing.Point(10, 22)
        Me.Dtgv_LawRinv.Name = "Dtgv_LawRinv"
        Me.Dtgv_LawRinv.ReadOnly = True
        Me.Dtgv_LawRinv.RowHeadersVisible = False
        Me.Dtgv_LawRinv.Size = New System.Drawing.Size(380, 252)
        Me.Dtgv_LawRinv.TabIndex = 92
        '
        'FrmLegalSCB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Dtgv_SCBLEGAL)
        Me.Controls.Add(Me.Group_detail)
        Me.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLegalSCB"
        Me.Text = "งานฟ้อง ZERO(LEGAL SCB)"
        Me.Group_detail.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Dtgv_SCBLEGAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtgv_LawCollector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dtgv_lawmonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dtgv_LawRinv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Group_detail As GroupBox
    Friend WithEvents Lbl_Osbalance As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lbl_sumLegal As Label
    Friend WithEvents Lbl_Legalscb As Label
    Friend WithEvents Lbl_Legalzero As Label
    Friend WithEvents lbl_count As Label
    Friend WithEvents lbl_datetoday As Label
    Friend WithEvents lbl_timer As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmd_search As Button
    Friend WithEvents cbo_finds As ComboBox
    Friend WithEvents Dtgv_SCBLEGAL As DataGridView
    Friend WithEvents Dtgv_LawCollector As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Dtgv_lawmonth As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Dtgv_LawRinv As DataGridView
    Friend WithEvents Cmd_ExportExcel As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
