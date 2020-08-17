<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKKB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKKB))
        Me.AxAcroPDFkkb = New AxAcroPDFLib.AxAcroPDF()
        Me.txt_searchkkb = New System.Windows.Forms.TextBox()
        Me.txt_typeselkkb = New System.Windows.Forms.TextBox()
        Me.txt_Prodselkkb = New System.Windows.Forms.TextBox()
        Me.txt_accselkkb = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.dtgvshowkkb = New System.Windows.Forms.DataGridView()
        Me.cmd_selectkkb = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_bankselkkb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AxAcroPDFkkb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvshowkkb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDFkkb
        '
        Me.AxAcroPDFkkb.Dock = System.Windows.Forms.DockStyle.Right
        Me.AxAcroPDFkkb.Enabled = True
        Me.AxAcroPDFkkb.Location = New System.Drawing.Point(491, 0)
        Me.AxAcroPDFkkb.Name = "AxAcroPDFkkb"
        Me.AxAcroPDFkkb.OcxState = CType(resources.GetObject("AxAcroPDFkkb.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDFkkb.Size = New System.Drawing.Size(517, 729)
        Me.AxAcroPDFkkb.TabIndex = 91
        '
        'txt_searchkkb
        '
        Me.txt_searchkkb.Location = New System.Drawing.Point(84, 6)
        Me.txt_searchkkb.Name = "txt_searchkkb"
        Me.txt_searchkkb.Size = New System.Drawing.Size(229, 20)
        Me.txt_searchkkb.TabIndex = 1
        '
        'txt_typeselkkb
        '
        Me.txt_typeselkkb.Location = New System.Drawing.Point(84, 308)
        Me.txt_typeselkkb.Name = "txt_typeselkkb"
        Me.txt_typeselkkb.ReadOnly = True
        Me.txt_typeselkkb.Size = New System.Drawing.Size(249, 20)
        Me.txt_typeselkkb.TabIndex = 85
        '
        'txt_Prodselkkb
        '
        Me.txt_Prodselkkb.Location = New System.Drawing.Point(84, 256)
        Me.txt_Prodselkkb.Name = "txt_Prodselkkb"
        Me.txt_Prodselkkb.ReadOnly = True
        Me.txt_Prodselkkb.Size = New System.Drawing.Size(249, 20)
        Me.txt_Prodselkkb.TabIndex = 84
        '
        'txt_accselkkb
        '
        Me.txt_accselkkb.Location = New System.Drawing.Point(84, 230)
        Me.txt_accselkkb.Name = "txt_accselkkb"
        Me.txt_accselkkb.ReadOnly = True
        Me.txt_accselkkb.Size = New System.Drawing.Size(249, 20)
        Me.txt_accselkkb.TabIndex = 81
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
        'dtgvshowkkb
        '
        Me.dtgvshowkkb.AllowUserToAddRows = False
        Me.dtgvshowkkb.AllowUserToDeleteRows = False
        Me.dtgvshowkkb.BackgroundColor = System.Drawing.Color.White
        Me.dtgvshowkkb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgvshowkkb.GridColor = System.Drawing.Color.Black
        Me.dtgvshowkkb.Location = New System.Drawing.Point(13, 33)
        Me.dtgvshowkkb.Name = "dtgvshowkkb"
        Me.dtgvshowkkb.ReadOnly = True
        Me.dtgvshowkkb.Size = New System.Drawing.Size(471, 185)
        Me.dtgvshowkkb.TabIndex = 82
        '
        'cmd_selectkkb
        '
        Me.cmd_selectkkb.BackColor = System.Drawing.Color.White
        Me.cmd_selectkkb.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__42_
        Me.cmd_selectkkb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_selectkkb.Location = New System.Drawing.Point(319, 4)
        Me.cmd_selectkkb.Name = "cmd_selectkkb"
        Me.cmd_selectkkb.Size = New System.Drawing.Size(84, 23)
        Me.cmd_selectkkb.TabIndex = 2
        Me.cmd_selectkkb.Text = "ค้นหา"
        Me.cmd_selectkkb.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Untitled_7
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(339, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'txt_bankselkkb
        '
        Me.txt_bankselkkb.Location = New System.Drawing.Point(84, 282)
        Me.txt_bankselkkb.Name = "txt_bankselkkb"
        Me.txt_bankselkkb.ReadOnly = True
        Me.txt_bankselkkb.Size = New System.Drawing.Size(249, 20)
        Me.txt_bankselkkb.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "ธนาคาร :"
        '
        'FrmKKB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.txt_bankselkkb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxAcroPDFkkb)
        Me.Controls.Add(Me.txt_searchkkb)
        Me.Controls.Add(Me.txt_typeselkkb)
        Me.Controls.Add(Me.txt_Prodselkkb)
        Me.Controls.Add(Me.txt_accselkkb)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.dtgvshowkkb)
        Me.Controls.Add(Me.cmd_selectkkb)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmKKB"
        Me.Text = "ค้นหาเอกสาร KKB"
        CType(Me.AxAcroPDFkkb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvshowkkb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxAcroPDFkkb As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents txt_searchkkb As TextBox
    Friend WithEvents txt_typeselkkb As TextBox
    Friend WithEvents txt_Prodselkkb As TextBox
    Friend WithEvents txt_accselkkb As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmd_clear As Button
    Friend WithEvents dtgvshowkkb As DataGridView
    Friend WithEvents cmd_selectkkb As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_bankselkkb As TextBox
    Friend WithEvents Label1 As Label
End Class
