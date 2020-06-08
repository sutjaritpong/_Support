<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTMB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTMB))
        Me.AxAcroPDFtmb = New AxAcroPDFLib.AxAcroPDF()
        Me.txt_searchtmb = New System.Windows.Forms.TextBox()
        Me.txt_typeseltmb = New System.Windows.Forms.TextBox()
        Me.txt_bankseltmb = New System.Windows.Forms.TextBox()
        Me.txt_accseltmb = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.dtgvshowtmb = New System.Windows.Forms.DataGridView()
        Me.cmd_selecttmb = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_prodseltmb = New System.Windows.Forms.TextBox()
        CType(Me.AxAcroPDFtmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvshowtmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDFtmb
        '
        Me.AxAcroPDFtmb.Dock = System.Windows.Forms.DockStyle.Right
        Me.AxAcroPDFtmb.Enabled = True
        Me.AxAcroPDFtmb.Location = New System.Drawing.Point(491, 0)
        Me.AxAcroPDFtmb.Name = "AxAcroPDFtmb"
        Me.AxAcroPDFtmb.OcxState = CType(resources.GetObject("AxAcroPDFtmb.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDFtmb.Size = New System.Drawing.Size(517, 729)
        Me.AxAcroPDFtmb.TabIndex = 103
        '
        'txt_searchtmb
        '
        Me.txt_searchtmb.Location = New System.Drawing.Point(84, 6)
        Me.txt_searchtmb.Name = "txt_searchtmb"
        Me.txt_searchtmb.Size = New System.Drawing.Size(229, 20)
        Me.txt_searchtmb.TabIndex = 1
        '
        'txt_typeseltmb
        '
        Me.txt_typeseltmb.Location = New System.Drawing.Point(84, 310)
        Me.txt_typeseltmb.Name = "txt_typeseltmb"
        Me.txt_typeseltmb.ReadOnly = True
        Me.txt_typeseltmb.Size = New System.Drawing.Size(249, 20)
        Me.txt_typeseltmb.TabIndex = 97
        '
        'txt_bankseltmb
        '
        Me.txt_bankseltmb.Location = New System.Drawing.Point(84, 284)
        Me.txt_bankseltmb.Name = "txt_bankseltmb"
        Me.txt_bankseltmb.ReadOnly = True
        Me.txt_bankseltmb.Size = New System.Drawing.Size(249, 20)
        Me.txt_bankseltmb.TabIndex = 96
        '
        'txt_accseltmb
        '
        Me.txt_accseltmb.Location = New System.Drawing.Point(84, 230)
        Me.txt_accseltmb.Name = "txt_accseltmb"
        Me.txt_accseltmb.ReadOnly = True
        Me.txt_accseltmb.Size = New System.Drawing.Size(249, 20)
        Me.txt_accseltmb.TabIndex = 93
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 101
        Me.Label25.Text = "เลขที่สัญญา :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(27, 311)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 16)
        Me.Label22.TabIndex = 100
        Me.Label22.Text = "ประเภท :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(28, 284)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 16)
        Me.Label21.TabIndex = 99
        Me.Label21.Text = "ธนาคาร :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 98
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
        'dtgvshowtmb
        '
        Me.dtgvshowtmb.AllowUserToAddRows = False
        Me.dtgvshowtmb.AllowUserToDeleteRows = False
        Me.dtgvshowtmb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgvshowtmb.Location = New System.Drawing.Point(13, 33)
        Me.dtgvshowtmb.Name = "dtgvshowtmb"
        Me.dtgvshowtmb.ReadOnly = True
        Me.dtgvshowtmb.Size = New System.Drawing.Size(471, 185)
        Me.dtgvshowtmb.TabIndex = 94
        '
        'cmd_selecttmb
        '
        Me.cmd_selecttmb.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__42_
        Me.cmd_selecttmb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_selecttmb.Location = New System.Drawing.Point(319, 4)
        Me.cmd_selecttmb.Name = "cmd_selecttmb"
        Me.cmd_selecttmb.Size = New System.Drawing.Size(84, 23)
        Me.cmd_selecttmb.TabIndex = 2
        Me.cmd_selecttmb.Text = "ค้นหา"
        Me.cmd_selecttmb.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Untitled_3
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(339, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 104
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Product :"
        '
        'txt_prodseltmb
        '
        Me.txt_prodseltmb.Location = New System.Drawing.Point(84, 256)
        Me.txt_prodseltmb.Name = "txt_prodseltmb"
        Me.txt_prodseltmb.ReadOnly = True
        Me.txt_prodseltmb.Size = New System.Drawing.Size(249, 20)
        Me.txt_prodseltmb.TabIndex = 107
        '
        'FrmTMB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.txt_prodseltmb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxAcroPDFtmb)
        Me.Controls.Add(Me.txt_searchtmb)
        Me.Controls.Add(Me.txt_typeseltmb)
        Me.Controls.Add(Me.txt_bankseltmb)
        Me.Controls.Add(Me.txt_accseltmb)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.dtgvshowtmb)
        Me.Controls.Add(Me.cmd_selecttmb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTMB"
        Me.Text = "ค้นหาเอกสาร TMB"
        CType(Me.AxAcroPDFtmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvshowtmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxAcroPDFtmb As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents txt_searchtmb As TextBox
    Friend WithEvents txt_typeseltmb As TextBox
    Friend WithEvents txt_bankseltmb As TextBox
    Friend WithEvents txt_accseltmb As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmd_clear As Button
    Friend WithEvents dtgvshowtmb As DataGridView
    Friend WithEvents cmd_selecttmb As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_prodseltmb As TextBox
End Class
