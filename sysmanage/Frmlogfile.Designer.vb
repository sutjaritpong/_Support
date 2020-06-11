<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmlogfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmlogfile))
        Me.dtgvlogfile = New System.Windows.Forms.DataGridView()
        Me.txt_find = New System.Windows.Forms.TextBox()
        Me.lbl_find = New System.Windows.Forms.Label()
        Me.lbl_check = New System.Windows.Forms.Label()
        Me.cbo_where = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cmd_text = New System.Windows.Forms.Button()
        Me.cmd_find = New System.Windows.Forms.Button()
        Me.cmd_refresh = New System.Windows.Forms.Button()
        Me.DateTimestart = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeend = New System.Windows.Forms.DateTimePicker()
        Me.Labeltime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_statusexport = New System.Windows.Forms.Label()
        Me.lbl_countdtgv = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_countdata = New System.Windows.Forms.Label()
        Me.txt_detaillog = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dtgvlogfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvlogfile
        '
        Me.dtgvlogfile.AllowUserToAddRows = False
        Me.dtgvlogfile.AllowUserToDeleteRows = False
        Me.dtgvlogfile.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dtgvlogfile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgvlogfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvlogfile.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.dtgvlogfile.Location = New System.Drawing.Point(15, 74)
        Me.dtgvlogfile.Name = "dtgvlogfile"
        Me.dtgvlogfile.ReadOnly = True
        Me.dtgvlogfile.RowHeadersVisible = False
        Me.dtgvlogfile.Size = New System.Drawing.Size(745, 643)
        Me.dtgvlogfile.TabIndex = 0
        '
        'txt_find
        '
        Me.txt_find.BackColor = System.Drawing.SystemColors.Window
        Me.txt_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_find.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_find.Location = New System.Drawing.Point(315, 8)
        Me.txt_find.Name = "txt_find"
        Me.txt_find.Size = New System.Drawing.Size(204, 22)
        Me.txt_find.TabIndex = 3
        '
        'lbl_find
        '
        Me.lbl_find.AutoSize = True
        Me.lbl_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_find.Location = New System.Drawing.Point(218, 12)
        Me.lbl_find.Name = "lbl_find"
        Me.lbl_find.Size = New System.Drawing.Size(92, 16)
        Me.lbl_find.TabIndex = 4
        Me.lbl_find.Text = "เงื่อนไขการค้นหา :"
        '
        'lbl_check
        '
        Me.lbl_check.AutoSize = True
        Me.lbl_check.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_check.Location = New System.Drawing.Point(12, 11)
        Me.lbl_check.Name = "lbl_check"
        Me.lbl_check.Size = New System.Drawing.Size(76, 16)
        Me.lbl_check.TabIndex = 5
        Me.lbl_check.Text = "หัวข้อที่ค้นหา :"
        '
        'cbo_where
        '
        Me.cbo_where.FormattingEnabled = True
        Me.cbo_where.Location = New System.Drawing.Point(91, 9)
        Me.cbo_where.Name = "cbo_where"
        Me.cbo_where.Size = New System.Drawing.Size(121, 21)
        Me.cbo_where.TabIndex = 6
        '
        'cmd_text
        '
        Me.cmd_text.Image = Global.SCANDB.My.Resources.Resources.Excel_icon
        Me.cmd_text.Location = New System.Drawing.Point(329, 40)
        Me.cmd_text.Name = "cmd_text"
        Me.cmd_text.Size = New System.Drawing.Size(36, 28)
        Me.cmd_text.TabIndex = 7
        Me.cmd_text.UseVisualStyleBackColor = True
        '
        'cmd_find
        '
        Me.cmd_find.Image = Global.SCANDB.My.Resources.Resources.search
        Me.cmd_find.Location = New System.Drawing.Point(525, 6)
        Me.cmd_find.Name = "cmd_find"
        Me.cmd_find.Size = New System.Drawing.Size(36, 28)
        Me.cmd_find.TabIndex = 2
        Me.cmd_find.UseVisualStyleBackColor = True
        '
        'cmd_refresh
        '
        Me.cmd_refresh.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__40_
        Me.cmd_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_refresh.Location = New System.Drawing.Point(567, 6)
        Me.cmd_refresh.Name = "cmd_refresh"
        Me.cmd_refresh.Size = New System.Drawing.Size(101, 28)
        Me.cmd_refresh.TabIndex = 1
        Me.cmd_refresh.Text = "รีเฟรช"
        Me.cmd_refresh.UseVisualStyleBackColor = True
        '
        'DateTimestart
        '
        Me.DateTimestart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimestart.Location = New System.Drawing.Point(71, 45)
        Me.DateTimestart.Name = "DateTimestart"
        Me.DateTimestart.Size = New System.Drawing.Size(96, 20)
        Me.DateTimestart.TabIndex = 8
        '
        'DateTimeend
        '
        Me.DateTimeend.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeend.Location = New System.Drawing.Point(221, 45)
        Me.DateTimeend.Name = "DateTimeend"
        Me.DateTimeend.Size = New System.Drawing.Size(102, 20)
        Me.DateTimeend.TabIndex = 9
        '
        'Labeltime
        '
        Me.Labeltime.AutoSize = True
        Me.Labeltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Labeltime.Location = New System.Drawing.Point(13, 45)
        Me.Labeltime.Name = "Labeltime"
        Me.Labeltime.Size = New System.Drawing.Size(52, 16)
        Me.Labeltime.TabIndex = 10
        Me.Labeltime.Text = "จากวันที่ :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ถึงวันที่ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "สถานะ Export :"
        '
        'lbl_statusexport
        '
        Me.lbl_statusexport.AutoSize = True
        Me.lbl_statusexport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_statusexport.Location = New System.Drawing.Point(463, 44)
        Me.lbl_statusexport.Name = "lbl_statusexport"
        Me.lbl_statusexport.Size = New System.Drawing.Size(90, 18)
        Me.lbl_statusexport.TabIndex = 13
        Me.lbl_statusexport.Text = "ไม่มีการทำงาน"
        '
        'lbl_countdtgv
        '
        Me.lbl_countdtgv.AutoSize = True
        Me.lbl_countdtgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_countdtgv.ForeColor = System.Drawing.Color.Blue
        Me.lbl_countdtgv.Location = New System.Drawing.Point(649, 45)
        Me.lbl_countdtgv.Name = "lbl_countdtgv"
        Me.lbl_countdtgv.Size = New System.Drawing.Size(44, 20)
        Me.lbl_countdtgv.TabIndex = 14
        Me.lbl_countdtgv.Text = "xxxxx"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(692, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "/"
        '
        'lbl_countdata
        '
        Me.lbl_countdata.AutoSize = True
        Me.lbl_countdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_countdata.ForeColor = System.Drawing.Color.Blue
        Me.lbl_countdata.Location = New System.Drawing.Point(711, 44)
        Me.lbl_countdata.Name = "lbl_countdata"
        Me.lbl_countdata.Size = New System.Drawing.Size(44, 20)
        Me.lbl_countdata.TabIndex = 16
        Me.lbl_countdata.Text = "xxxxx"
        '
        'txt_detaillog
        '
        Me.txt_detaillog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_detaillog.ForeColor = System.Drawing.Color.Black
        Me.txt_detaillog.Location = New System.Drawing.Point(766, 104)
        Me.txt_detaillog.Multiline = True
        Me.txt_detaillog.Name = "txt_detaillog"
        Me.txt_detaillog.Size = New System.Drawing.Size(230, 337)
        Me.txt_detaillog.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(766, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 27)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "รายละเอียด :"
        '
        'Frmlogfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_detaillog)
        Me.Controls.Add(Me.lbl_countdata)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_countdtgv)
        Me.Controls.Add(Me.lbl_statusexport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Labeltime)
        Me.Controls.Add(Me.DateTimeend)
        Me.Controls.Add(Me.DateTimestart)
        Me.Controls.Add(Me.cmd_text)
        Me.Controls.Add(Me.cbo_where)
        Me.Controls.Add(Me.lbl_check)
        Me.Controls.Add(Me.lbl_find)
        Me.Controls.Add(Me.txt_find)
        Me.Controls.Add(Me.cmd_find)
        Me.Controls.Add(Me.cmd_refresh)
        Me.Controls.Add(Me.dtgvlogfile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmlogfile"
        Me.Text = "ประวัติการใช้งานระบบ"
        CType(Me.dtgvlogfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgvlogfile As DataGridView
    Friend WithEvents cmd_refresh As Button
    Friend WithEvents cmd_find As Button
    Friend WithEvents txt_find As TextBox
    Friend WithEvents lbl_find As Label
    Friend WithEvents lbl_check As Label
    Friend WithEvents cbo_where As ComboBox
    Friend WithEvents cmd_text As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents DateTimestart As DateTimePicker
    Friend WithEvents DateTimeend As DateTimePicker
    Friend WithEvents Labeltime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_statusexport As Label
    Friend WithEvents lbl_countdtgv As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_countdata As Label
    Friend WithEvents txt_detaillog As TextBox
    Friend WithEvents Label4 As Label
End Class
