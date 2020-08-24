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
        Me.Lbl_SumLegal = New System.Windows.Forms.Label()
        Me.Lbl_LegalSCB = New System.Windows.Forms.Label()
        Me.Lbl_Legalzero = New System.Windows.Forms.Label()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.lbl_datetoday = New System.Windows.Forms.Label()
        Me.lbl_SCB = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmd_finds = New System.Windows.Forms.Button()
        Me.cbo_finds = New System.Windows.Forms.ComboBox()
        Me.Dtgv_SCBLEGAL = New System.Windows.Forms.DataGridView()
        Me.Dtgv_Lawmonth = New System.Windows.Forms.DataGridView()
        Me.Group_detail.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Dtgv_SCBLEGAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtgv_Lawmonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group_detail
        '
        Me.Group_detail.BackColor = System.Drawing.SystemColors.Window
        Me.Group_detail.Controls.Add(Me.Lbl_SumLegal)
        Me.Group_detail.Controls.Add(Me.Lbl_LegalSCB)
        Me.Group_detail.Controls.Add(Me.Lbl_Legalzero)
        Me.Group_detail.Controls.Add(Me.lbl_count)
        Me.Group_detail.Controls.Add(Me.lbl_datetoday)
        Me.Group_detail.Controls.Add(Me.lbl_SCB)
        Me.Group_detail.Location = New System.Drawing.Point(504, 3)
        Me.Group_detail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Group_detail.Name = "Group_detail"
        Me.Group_detail.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Group_detail.Size = New System.Drawing.Size(304, 110)
        Me.Group_detail.TabIndex = 105
        Me.Group_detail.TabStop = False
        Me.Group_detail.Text = "รวมข้อมูล"
        '
        'Lbl_SumLegal
        '
        Me.Lbl_SumLegal.BackColor = System.Drawing.Color.White
        Me.Lbl_SumLegal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_SumLegal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_SumLegal.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Lbl_SumLegal.Location = New System.Drawing.Point(148, 72)
        Me.Lbl_SumLegal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_SumLegal.Name = "Lbl_SumLegal"
        Me.Lbl_SumLegal.Size = New System.Drawing.Size(133, 27)
        Me.Lbl_SumLegal.TabIndex = 15
        Me.Lbl_SumLegal.Text = "XXXX"
        Me.Lbl_SumLegal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_LegalSCB
        '
        Me.Lbl_LegalSCB.BackColor = System.Drawing.Color.White
        Me.Lbl_LegalSCB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_LegalSCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_LegalSCB.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Lbl_LegalSCB.Location = New System.Drawing.Point(148, 45)
        Me.Lbl_LegalSCB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_LegalSCB.Name = "Lbl_LegalSCB"
        Me.Lbl_LegalSCB.Size = New System.Drawing.Size(133, 27)
        Me.Lbl_LegalSCB.TabIndex = 14
        Me.Lbl_LegalSCB.Text = "XXXX"
        Me.Lbl_LegalSCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Legalzero
        '
        Me.Lbl_Legalzero.BackColor = System.Drawing.Color.White
        Me.Lbl_Legalzero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Legalzero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Lbl_Legalzero.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Lbl_Legalzero.Location = New System.Drawing.Point(148, 16)
        Me.Lbl_Legalzero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Legalzero.Name = "Lbl_Legalzero"
        Me.Lbl_Legalzero.Size = New System.Drawing.Size(133, 29)
        Me.Lbl_Legalzero.TabIndex = 13
        Me.Lbl_Legalzero.Text = "XXXX"
        Me.Lbl_Legalzero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_count
        '
        Me.lbl_count.BackColor = System.Drawing.SystemColors.Desktop
        Me.lbl_count.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_count.ForeColor = System.Drawing.Color.Purple
        Me.lbl_count.Location = New System.Drawing.Point(7, 72)
        Me.lbl_count.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(133, 27)
        Me.lbl_count.TabIndex = 9
        Me.lbl_count.Text = "ข้อมูลทั้งหมด"
        Me.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_datetoday
        '
        Me.lbl_datetoday.BackColor = System.Drawing.SystemColors.Desktop
        Me.lbl_datetoday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_datetoday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_datetoday.ForeColor = System.Drawing.Color.Purple
        Me.lbl_datetoday.Location = New System.Drawing.Point(7, 45)
        Me.lbl_datetoday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_datetoday.Name = "lbl_datetoday"
        Me.lbl_datetoday.Size = New System.Drawing.Size(133, 27)
        Me.lbl_datetoday.TabIndex = 1
        Me.lbl_datetoday.Text = "Legal SCB"
        Me.lbl_datetoday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SCB
        '
        Me.lbl_SCB.BackColor = System.Drawing.Color.White
        Me.lbl_SCB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_SCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_SCB.ForeColor = System.Drawing.Color.Purple
        Me.lbl_SCB.Location = New System.Drawing.Point(7, 16)
        Me.lbl_SCB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_SCB.Name = "lbl_SCB"
        Me.lbl_SCB.Size = New System.Drawing.Size(133, 29)
        Me.lbl_SCB.TabIndex = 0
        Me.lbl_SCB.Text = "ฟ้อง ZERO"
        Me.lbl_SCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.cmd_finds)
        Me.GroupBox6.Controls.Add(Me.cbo_finds)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Indigo
        Me.GroupBox6.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox6.Size = New System.Drawing.Size(486, 54)
        Me.GroupBox6.TabIndex = 106
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ค้นหาข้อมูล"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 18)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "ประเภทข้อมูล"
        '
        'cmd_finds
        '
        Me.cmd_finds.BackColor = System.Drawing.Color.White
        Me.cmd_finds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_finds.ForeColor = System.Drawing.Color.Indigo
        Me.cmd_finds.Image = Global.SCANDB.My.Resources.Resources.Find_16x16
        Me.cmd_finds.Location = New System.Drawing.Point(337, 13)
        Me.cmd_finds.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_finds.Name = "cmd_finds"
        Me.cmd_finds.Size = New System.Drawing.Size(133, 29)
        Me.cmd_finds.TabIndex = 4
        Me.cmd_finds.Text = "ค้นหาข้อมูล"
        Me.cmd_finds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_finds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_finds.UseVisualStyleBackColor = False
        '
        'cbo_finds
        '
        Me.cbo_finds.FormattingEnabled = True
        Me.cbo_finds.Location = New System.Drawing.Point(92, 17)
        Me.cbo_finds.Name = "cbo_finds"
        Me.cbo_finds.Size = New System.Drawing.Size(238, 21)
        Me.cbo_finds.TabIndex = 92
        '
        'Dtgv_SCBLEGAL
        '
        Me.Dtgv_SCBLEGAL.AllowUserToAddRows = False
        Me.Dtgv_SCBLEGAL.AllowUserToDeleteRows = False
        Me.Dtgv_SCBLEGAL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dtgv_SCBLEGAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_SCBLEGAL.GridColor = System.Drawing.Color.Black
        Me.Dtgv_SCBLEGAL.Location = New System.Drawing.Point(12, 65)
        Me.Dtgv_SCBLEGAL.Name = "Dtgv_SCBLEGAL"
        Me.Dtgv_SCBLEGAL.ReadOnly = True
        Me.Dtgv_SCBLEGAL.RowHeadersVisible = False
        Me.Dtgv_SCBLEGAL.Size = New System.Drawing.Size(486, 352)
        Me.Dtgv_SCBLEGAL.TabIndex = 104
        Me.Dtgv_SCBLEGAL.Visible = False
        '
        'Dtgv_Lawmonth
        '
        Me.Dtgv_Lawmonth.AllowUserToAddRows = False
        Me.Dtgv_Lawmonth.AllowUserToDeleteRows = False
        Me.Dtgv_Lawmonth.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dtgv_Lawmonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_Lawmonth.GridColor = System.Drawing.Color.Black
        Me.Dtgv_Lawmonth.Location = New System.Drawing.Point(504, 119)
        Me.Dtgv_Lawmonth.Name = "Dtgv_Lawmonth"
        Me.Dtgv_Lawmonth.ReadOnly = True
        Me.Dtgv_Lawmonth.RowHeadersVisible = False
        Me.Dtgv_Lawmonth.Size = New System.Drawing.Size(304, 298)
        Me.Dtgv_Lawmonth.TabIndex = 107
        '
        'FrmLegalSCB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Dtgv_Lawmonth)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Group_detail)
        Me.Controls.Add(Me.Dtgv_SCBLEGAL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLegalSCB"
        Me.Text = "ข้อมูล Legal (SCB)"
        Me.Group_detail.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Dtgv_SCBLEGAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtgv_Lawmonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Group_detail As GroupBox
    Friend WithEvents Lbl_SumLegal As Label
    Friend WithEvents Lbl_LegalSCB As Label
    Friend WithEvents Lbl_Legalzero As Label
    Friend WithEvents lbl_count As Label
    Friend WithEvents lbl_datetoday As Label
    Friend WithEvents lbl_SCB As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmd_finds As Button
    Friend WithEvents cbo_finds As ComboBox
    Friend WithEvents Dtgv_SCBLEGAL As DataGridView
    Friend WithEvents Dtgv_Lawmonth As DataGridView
End Class
