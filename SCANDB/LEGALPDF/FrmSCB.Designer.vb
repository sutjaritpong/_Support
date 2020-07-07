<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSCB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSCB))
        Me.AxAcroPDFscb = New AxAcroPDFLib.AxAcroPDF()
        Me.txt_searchscb = New System.Windows.Forms.TextBox()
        Me.txt_typeselscb = New System.Windows.Forms.TextBox()
        Me.txt_Prodselscb = New System.Windows.Forms.TextBox()
        Me.txt_accselscb = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.dtgvshowscb = New System.Windows.Forms.DataGridView()
        Me.cmd_selectscb = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_bankselscb = New System.Windows.Forms.TextBox()
        Me.txtbanksel = New System.Windows.Forms.Label()
        CType(Me.AxAcroPDFscb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvshowscb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDFscb
        '
        Me.AxAcroPDFscb.Dock = System.Windows.Forms.DockStyle.Right
        Me.AxAcroPDFscb.Enabled = True
        Me.AxAcroPDFscb.Location = New System.Drawing.Point(491, 0)
        Me.AxAcroPDFscb.Name = "AxAcroPDFscb"
        Me.AxAcroPDFscb.OcxState = CType(resources.GetObject("AxAcroPDFscb.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDFscb.Size = New System.Drawing.Size(517, 729)
        Me.AxAcroPDFscb.TabIndex = 79
        '
        'txt_searchscb
        '
        Me.txt_searchscb.Location = New System.Drawing.Point(84, 6)
        Me.txt_searchscb.Name = "txt_searchscb"
        Me.txt_searchscb.Size = New System.Drawing.Size(229, 20)
        Me.txt_searchscb.TabIndex = 1
        '
        'txt_typeselscb
        '
        Me.txt_typeselscb.Location = New System.Drawing.Point(84, 308)
        Me.txt_typeselscb.Name = "txt_typeselscb"
        Me.txt_typeselscb.ReadOnly = True
        Me.txt_typeselscb.Size = New System.Drawing.Size(249, 20)
        Me.txt_typeselscb.TabIndex = 73
        '
        'txt_Prodselscb
        '
        Me.txt_Prodselscb.Location = New System.Drawing.Point(84, 256)
        Me.txt_Prodselscb.Name = "txt_Prodselscb"
        Me.txt_Prodselscb.ReadOnly = True
        Me.txt_Prodselscb.Size = New System.Drawing.Size(249, 20)
        Me.txt_Prodselscb.TabIndex = 72
        '
        'txt_accselscb
        '
        Me.txt_accselscb.Location = New System.Drawing.Point(84, 230)
        Me.txt_accselscb.Name = "txt_accselscb"
        Me.txt_accselscb.ReadOnly = True
        Me.txt_accselscb.Size = New System.Drawing.Size(249, 20)
        Me.txt_accselscb.TabIndex = 69
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 77
        Me.Label25.Text = "เลขที่สัญญา :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(27, 308)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 16)
        Me.Label22.TabIndex = 76
        Me.Label22.Text = "ประเภท :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(18, 257)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 16)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "Product :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "เลขที่สัญญา :"
        '
        'cmd_clear
        '
        Me.cmd_clear.BackColor = System.Drawing.Color.White
        Me.cmd_clear.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__40_
        Me.cmd_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_clear.Location = New System.Drawing.Point(409, 4)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(75, 23)
        Me.cmd_clear.TabIndex = 3
        Me.cmd_clear.Text = "เคลีย"
        Me.cmd_clear.UseVisualStyleBackColor = False
        '
        'dtgvshowscb
        '
        Me.dtgvshowscb.AllowUserToAddRows = False
        Me.dtgvshowscb.AllowUserToDeleteRows = False
        Me.dtgvshowscb.BackgroundColor = System.Drawing.Color.White
        Me.dtgvshowscb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgvshowscb.Location = New System.Drawing.Point(13, 33)
        Me.dtgvshowscb.Name = "dtgvshowscb"
        Me.dtgvshowscb.ReadOnly = True
        Me.dtgvshowscb.Size = New System.Drawing.Size(471, 185)
        Me.dtgvshowscb.TabIndex = 70
        '
        'cmd_selectscb
        '
        Me.cmd_selectscb.BackColor = System.Drawing.Color.White
        Me.cmd_selectscb.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__42_
        Me.cmd_selectscb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_selectscb.Location = New System.Drawing.Point(319, 4)
        Me.cmd_selectscb.Name = "cmd_selectscb"
        Me.cmd_selectscb.Size = New System.Drawing.Size(84, 23)
        Me.cmd_selectscb.TabIndex = 2
        Me.cmd_selectscb.Text = "ค้นหา"
        Me.cmd_selectscb.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Untitled_2
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(339, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'txt_bankselscb
        '
        Me.txt_bankselscb.Location = New System.Drawing.Point(84, 282)
        Me.txt_bankselscb.Name = "txt_bankselscb"
        Me.txt_bankselscb.ReadOnly = True
        Me.txt_bankselscb.Size = New System.Drawing.Size(249, 20)
        Me.txt_bankselscb.TabIndex = 95
        '
        'txtbanksel
        '
        Me.txtbanksel.AutoSize = True
        Me.txtbanksel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtbanksel.Location = New System.Drawing.Point(28, 282)
        Me.txtbanksel.Name = "txtbanksel"
        Me.txtbanksel.Size = New System.Drawing.Size(50, 16)
        Me.txtbanksel.TabIndex = 96
        Me.txtbanksel.Text = "ธนาคาร :"
        '
        'FrmSCB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.txt_bankselscb)
        Me.Controls.Add(Me.txtbanksel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxAcroPDFscb)
        Me.Controls.Add(Me.txt_searchscb)
        Me.Controls.Add(Me.txt_typeselscb)
        Me.Controls.Add(Me.txt_Prodselscb)
        Me.Controls.Add(Me.txt_accselscb)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.dtgvshowscb)
        Me.Controls.Add(Me.cmd_selectscb)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSCB"
        Me.Text = "ค้นหาเอกสาร SCB"
        CType(Me.AxAcroPDFscb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvshowscb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxAcroPDFscb As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents txt_searchscb As TextBox
    Friend WithEvents txt_typeselscb As TextBox
    Friend WithEvents txt_Prodselscb As TextBox
    Friend WithEvents txt_accselscb As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmd_clear As Button
    Friend WithEvents dtgvshowscb As DataGridView
    Friend WithEvents cmd_selectscb As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_bankselscb As TextBox
    Friend WithEvents txtbanksel As Label
End Class
