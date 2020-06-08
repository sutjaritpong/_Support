<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTBANK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTBANK))
        Me.AxAcroPDFtbank = New AxAcroPDFLib.AxAcroPDF()
        Me.txt_searchtbank = New System.Windows.Forms.TextBox()
        Me.txt_typeseltbank = New System.Windows.Forms.TextBox()
        Me.txt_bankseltbank = New System.Windows.Forms.TextBox()
        Me.txt_accseltbank = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.dtgvshowtbank = New System.Windows.Forms.DataGridView()
        Me.cmd_selectkbank = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_Prodseltbank = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AxAcroPDFtbank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvshowtbank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDFtbank
        '
        Me.AxAcroPDFtbank.Dock = System.Windows.Forms.DockStyle.Right
        Me.AxAcroPDFtbank.Enabled = True
        Me.AxAcroPDFtbank.Location = New System.Drawing.Point(491, 0)
        Me.AxAcroPDFtbank.Name = "AxAcroPDFtbank"
        Me.AxAcroPDFtbank.OcxState = CType(resources.GetObject("AxAcroPDFtbank.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDFtbank.Size = New System.Drawing.Size(517, 729)
        Me.AxAcroPDFtbank.TabIndex = 67
        '
        'txt_searchtbank
        '
        Me.txt_searchtbank.Location = New System.Drawing.Point(84, 6)
        Me.txt_searchtbank.Name = "txt_searchtbank"
        Me.txt_searchtbank.Size = New System.Drawing.Size(229, 20)
        Me.txt_searchtbank.TabIndex = 1
        '
        'txt_typeseltbank
        '
        Me.txt_typeseltbank.Location = New System.Drawing.Point(84, 308)
        Me.txt_typeseltbank.Name = "txt_typeseltbank"
        Me.txt_typeseltbank.ReadOnly = True
        Me.txt_typeseltbank.Size = New System.Drawing.Size(249, 20)
        Me.txt_typeseltbank.TabIndex = 61
        '
        'txt_bankseltbank
        '
        Me.txt_bankseltbank.Location = New System.Drawing.Point(84, 282)
        Me.txt_bankseltbank.Name = "txt_bankseltbank"
        Me.txt_bankseltbank.ReadOnly = True
        Me.txt_bankseltbank.Size = New System.Drawing.Size(249, 20)
        Me.txt_bankseltbank.TabIndex = 60
        '
        'txt_accseltbank
        '
        Me.txt_accseltbank.Location = New System.Drawing.Point(84, 230)
        Me.txt_accseltbank.Name = "txt_accseltbank"
        Me.txt_accseltbank.ReadOnly = True
        Me.txt_accseltbank.Size = New System.Drawing.Size(249, 20)
        Me.txt_accseltbank.TabIndex = 57
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 65
        Me.Label25.Text = "เลขที่สัญญา :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(27, 308)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 16)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "ประเภท :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(28, 282)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 16)
        Me.Label21.TabIndex = 63
        Me.Label21.Text = "ธนาคาร :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "เลขที่สัญญา :"
        '
        'cmd_clear
        '
        Me.cmd_clear.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__40_
        Me.cmd_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_clear.Location = New System.Drawing.Point(409, 4)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(75, 23)
        Me.cmd_clear.TabIndex = 3
        Me.cmd_clear.Text = "เคลีย"
        Me.cmd_clear.UseVisualStyleBackColor = True
        '
        'dtgvshowtbank
        '
        Me.dtgvshowtbank.AllowUserToAddRows = False
        Me.dtgvshowtbank.AllowUserToDeleteRows = False
        Me.dtgvshowtbank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgvshowtbank.Location = New System.Drawing.Point(13, 33)
        Me.dtgvshowtbank.Name = "dtgvshowtbank"
        Me.dtgvshowtbank.ReadOnly = True
        Me.dtgvshowtbank.Size = New System.Drawing.Size(471, 185)
        Me.dtgvshowtbank.TabIndex = 58
        '
        'cmd_selectkbank
        '
        Me.cmd_selectkbank.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__42_
        Me.cmd_selectkbank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_selectkbank.Location = New System.Drawing.Point(319, 4)
        Me.cmd_selectkbank.Name = "cmd_selectkbank"
        Me.cmd_selectkbank.Size = New System.Drawing.Size(84, 23)
        Me.cmd_selectkbank.TabIndex = 2
        Me.cmd_selectkbank.Text = "ค้นหา"
        Me.cmd_selectkbank.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Untitled_6
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(339, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'txt_Prodseltbank
        '
        Me.txt_Prodseltbank.Location = New System.Drawing.Point(84, 256)
        Me.txt_Prodseltbank.Name = "txt_Prodseltbank"
        Me.txt_Prodseltbank.ReadOnly = True
        Me.txt_Prodseltbank.Size = New System.Drawing.Size(249, 20)
        Me.txt_Prodseltbank.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Product :"
        '
        'FrmTBANK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.txt_Prodseltbank)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxAcroPDFtbank)
        Me.Controls.Add(Me.txt_searchtbank)
        Me.Controls.Add(Me.txt_typeseltbank)
        Me.Controls.Add(Me.txt_bankseltbank)
        Me.Controls.Add(Me.txt_accseltbank)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.dtgvshowtbank)
        Me.Controls.Add(Me.cmd_selectkbank)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTBANK"
        Me.Text = "ค้นหาเอกสาร TBANK"
        CType(Me.AxAcroPDFtbank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvshowtbank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxAcroPDFtbank As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents txt_searchtbank As TextBox
    Friend WithEvents txt_typeseltbank As TextBox
    Friend WithEvents txt_bankseltbank As TextBox
    Friend WithEvents txt_accseltbank As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmd_clear As Button
    Friend WithEvents dtgvshowtbank As DataGridView
    Friend WithEvents cmd_selectkbank As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_Prodseltbank As TextBox
    Friend WithEvents Label1 As Label
End Class
