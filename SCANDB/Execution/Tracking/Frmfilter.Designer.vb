<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmfilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmfilter))
        Me.dtp_date_start = New System.Windows.Forms.DateTimePicker()
        Me.dtp_date_end = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_search = New System.Windows.Forms.Button()
        Me.cbo_empexe = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_empexe = New System.Windows.Forms.CheckBox()
        Me.dtgv_filter = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_result = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgv_filter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtp_date_start
        '
        Me.dtp_date_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_start.Location = New System.Drawing.Point(74, 19)
        Me.dtp_date_start.Name = "dtp_date_start"
        Me.dtp_date_start.Size = New System.Drawing.Size(95, 20)
        Me.dtp_date_start.TabIndex = 143
        '
        'dtp_date_end
        '
        Me.dtp_date_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date_end.Location = New System.Drawing.Point(227, 19)
        Me.dtp_date_end.Name = "dtp_date_end"
        Me.dtp_date_end.Size = New System.Drawing.Size(98, 20)
        Me.dtp_date_end.TabIndex = 142
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 18)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "จากวันที่"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "ถึงวันที่"
        '
        'cmd_search
        '
        Me.cmd_search.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_search.Image = Global.SCANDB.My.Resources.Resources.folder_explore
        Me.cmd_search.Location = New System.Drawing.Point(629, 14)
        Me.cmd_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd_search.Name = "cmd_search"
        Me.cmd_search.Size = New System.Drawing.Size(93, 29)
        Me.cmd_search.TabIndex = 146
        Me.cmd_search.Text = "ค้นหา"
        Me.cmd_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_search.UseVisualStyleBackColor = False
        '
        'cbo_empexe
        '
        Me.cbo_empexe.FormattingEnabled = True
        Me.cbo_empexe.Location = New System.Drawing.Point(444, 18)
        Me.cbo_empexe.Name = "cbo_empexe"
        Me.cbo_empexe.Size = New System.Drawing.Size(178, 21)
        Me.cbo_empexe.TabIndex = 147
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_empexe)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmd_search)
        Me.GroupBox1.Controls.Add(Me.dtp_date_end)
        Me.GroupBox1.Controls.Add(Me.cbo_empexe)
        Me.GroupBox1.Controls.Add(Me.dtp_date_start)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 55)
        Me.GroupBox1.TabIndex = 149
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "กรองข้อมูล"
        '
        'chk_empexe
        '
        Me.chk_empexe.AutoSize = True
        Me.chk_empexe.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_empexe.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_empexe.Location = New System.Drawing.Point(328, 18)
        Me.chk_empexe.Name = "chk_empexe"
        Me.chk_empexe.Size = New System.Drawing.Size(110, 22)
        Me.chk_empexe.TabIndex = 148
        Me.chk_empexe.Text = "พนักงานบังคับคดี"
        Me.chk_empexe.UseVisualStyleBackColor = True
        '
        'dtgv_filter
        '
        Me.dtgv_filter.AllowUserToAddRows = False
        Me.dtgv_filter.AllowUserToDeleteRows = False
        Me.dtgv_filter.BackgroundColor = System.Drawing.Color.White
        Me.dtgv_filter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_filter.Location = New System.Drawing.Point(12, 64)
        Me.dtgv_filter.Name = "dtgv_filter"
        Me.dtgv_filter.ReadOnly = True
        Me.dtgv_filter.RowHeadersVisible = False
        Me.dtgv_filter.Size = New System.Drawing.Size(984, 550)
        Me.dtgv_filter.TabIndex = 150
        Me.dtgv_filter.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_result)
        Me.GroupBox2.Location = New System.Drawing.Point(747, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 54)
        Me.GroupBox2.TabIndex = 151
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ผลลัพธ์การค้นหา"
        '
        'lbl_result
        '
        Me.lbl_result.AutoSize = True
        Me.lbl_result.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_result.ForeColor = System.Drawing.Color.Red
        Me.lbl_result.Location = New System.Drawing.Point(6, 18)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(80, 21)
        Me.lbl_result.TabIndex = 146
        Me.lbl_result.Text = "???????"
        '
        'Frmfilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 635)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtgv_filter)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmfilter"
        Me.Text = "ค้นหาข้อมูลพนักงาน"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgv_filter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtp_date_start As DateTimePicker
    Friend WithEvents dtp_date_end As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_search As Button
    Friend WithEvents cbo_empexe As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_empexe As CheckBox
    Friend WithEvents dtgv_filter As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_result As Label
End Class
