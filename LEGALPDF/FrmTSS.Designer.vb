<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTSS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTSS))
        Me.AxAcroPDFtss = New AxAcroPDFLib.AxAcroPDF()
        Me.txt_searchtss = New System.Windows.Forms.TextBox()
        Me.txt_typeseltss = New System.Windows.Forms.TextBox()
        Me.txt_Prodseltss = New System.Windows.Forms.TextBox()
        Me.txt_accseltss = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.dtgvshowtss = New System.Windows.Forms.DataGridView()
        Me.cmd_selecttss = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_bankseltss = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AxAcroPDFtss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvshowtss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDFtss
        '
        Me.AxAcroPDFtss.Dock = System.Windows.Forms.DockStyle.Right
        Me.AxAcroPDFtss.Enabled = True
        Me.AxAcroPDFtss.Location = New System.Drawing.Point(491, 0)
        Me.AxAcroPDFtss.Name = "AxAcroPDFtss"
        Me.AxAcroPDFtss.OcxState = CType(resources.GetObject("AxAcroPDFtss.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDFtss.Size = New System.Drawing.Size(517, 729)
        Me.AxAcroPDFtss.TabIndex = 91
        '
        'txt_searchtss
        '
        Me.txt_searchtss.Location = New System.Drawing.Point(84, 6)
        Me.txt_searchtss.Name = "txt_searchtss"
        Me.txt_searchtss.Size = New System.Drawing.Size(229, 20)
        Me.txt_searchtss.TabIndex = 1
        '
        'txt_typeseltss
        '
        Me.txt_typeseltss.Location = New System.Drawing.Point(84, 308)
        Me.txt_typeseltss.Name = "txt_typeseltss"
        Me.txt_typeseltss.ReadOnly = True
        Me.txt_typeseltss.Size = New System.Drawing.Size(249, 20)
        Me.txt_typeseltss.TabIndex = 85
        '
        'txt_Prodseltss
        '
        Me.txt_Prodseltss.Location = New System.Drawing.Point(84, 256)
        Me.txt_Prodseltss.Name = "txt_Prodseltss"
        Me.txt_Prodseltss.ReadOnly = True
        Me.txt_Prodseltss.Size = New System.Drawing.Size(249, 20)
        Me.txt_Prodseltss.TabIndex = 84
        '
        'txt_accseltss
        '
        Me.txt_accseltss.Location = New System.Drawing.Point(84, 230)
        Me.txt_accseltss.Name = "txt_accseltss"
        Me.txt_accseltss.ReadOnly = True
        Me.txt_accseltss.Size = New System.Drawing.Size(249, 20)
        Me.txt_accseltss.TabIndex = 81
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 89
        Me.Label25.Text = "เลขที่สัญญา :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(27, 308)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 16)
        Me.Label22.TabIndex = 88
        Me.Label22.Text = "ประเภท :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(18, 257)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 16)
        Me.Label21.TabIndex = 87
        Me.Label21.Text = "Product :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 86
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
        'dtgvshowtss
        '
        Me.dtgvshowtss.AllowUserToAddRows = False
        Me.dtgvshowtss.AllowUserToDeleteRows = False
        Me.dtgvshowtss.BackgroundColor = System.Drawing.Color.White
        Me.dtgvshowtss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgvshowtss.GridColor = System.Drawing.Color.Black
        Me.dtgvshowtss.Location = New System.Drawing.Point(13, 33)
        Me.dtgvshowtss.Name = "dtgvshowtss"
        Me.dtgvshowtss.ReadOnly = True
        Me.dtgvshowtss.Size = New System.Drawing.Size(471, 185)
        Me.dtgvshowtss.TabIndex = 82
        '
        'cmd_selecttss
        '
        Me.cmd_selecttss.BackColor = System.Drawing.Color.White
        Me.cmd_selecttss.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__42_
        Me.cmd_selecttss.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_selecttss.Location = New System.Drawing.Point(319, 4)
        Me.cmd_selecttss.Name = "cmd_selecttss"
        Me.cmd_selecttss.Size = New System.Drawing.Size(84, 23)
        Me.cmd_selecttss.TabIndex = 2
        Me.cmd_selecttss.Text = "ค้นหา"
        Me.cmd_selecttss.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Untitled_5
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(339, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'txt_bankseltss
        '
        Me.txt_bankseltss.Location = New System.Drawing.Point(84, 282)
        Me.txt_bankseltss.Name = "txt_bankseltss"
        Me.txt_bankseltss.ReadOnly = True
        Me.txt_bankseltss.Size = New System.Drawing.Size(249, 20)
        Me.txt_bankseltss.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "ธนาคาร :"
        '
        'FrmTSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.txt_bankseltss)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxAcroPDFtss)
        Me.Controls.Add(Me.txt_searchtss)
        Me.Controls.Add(Me.txt_typeseltss)
        Me.Controls.Add(Me.txt_Prodseltss)
        Me.Controls.Add(Me.txt_accseltss)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.dtgvshowtss)
        Me.Controls.Add(Me.cmd_selecttss)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTSS"
        Me.Text = "ค้นหาเอกสาร TSS"
        CType(Me.AxAcroPDFtss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvshowtss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxAcroPDFtss As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents txt_searchtss As TextBox
    Friend WithEvents txt_typeseltss As TextBox
    Friend WithEvents txt_Prodseltss As TextBox
    Friend WithEvents txt_accseltss As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmd_clear As Button
    Friend WithEvents dtgvshowtss As DataGridView
    Friend WithEvents cmd_selecttss As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_bankseltss As TextBox
    Friend WithEvents Label1 As Label
End Class
