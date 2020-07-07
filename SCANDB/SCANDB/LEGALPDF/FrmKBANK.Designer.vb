<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmKBANK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKBANK))
        Me.txt_searchkbank = New System.Windows.Forms.TextBox()
        Me.txt_typeselkbank = New System.Windows.Forms.TextBox()
        Me.txt_Prodselkbank = New System.Windows.Forms.TextBox()
        Me.txt_accselkbank = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.dtgvshowkbank = New System.Windows.Forms.DataGridView()
        Me.cmd_selectkbank = New System.Windows.Forms.Button()
        Me.AxAcroPDFkbank = New AxAcroPDFLib.AxAcroPDF()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_bankselkbank = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtgvshowkbank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDFkbank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_searchkbank
        '
        Me.txt_searchkbank.Location = New System.Drawing.Point(84, 6)
        Me.txt_searchkbank.Name = "txt_searchkbank"
        Me.txt_searchkbank.Size = New System.Drawing.Size(229, 20)
        Me.txt_searchkbank.TabIndex = 1
        '
        'txt_typeselkbank
        '
        Me.txt_typeselkbank.Location = New System.Drawing.Point(84, 308)
        Me.txt_typeselkbank.Name = "txt_typeselkbank"
        Me.txt_typeselkbank.ReadOnly = True
        Me.txt_typeselkbank.Size = New System.Drawing.Size(249, 20)
        Me.txt_typeselkbank.TabIndex = 47
        '
        'txt_Prodselkbank
        '
        Me.txt_Prodselkbank.Location = New System.Drawing.Point(84, 256)
        Me.txt_Prodselkbank.Name = "txt_Prodselkbank"
        Me.txt_Prodselkbank.ReadOnly = True
        Me.txt_Prodselkbank.Size = New System.Drawing.Size(249, 20)
        Me.txt_Prodselkbank.TabIndex = 46
        '
        'txt_accselkbank
        '
        Me.txt_accselkbank.Location = New System.Drawing.Point(84, 230)
        Me.txt_accselkbank.Name = "txt_accselkbank"
        Me.txt_accselkbank.ReadOnly = True
        Me.txt_accselkbank.Size = New System.Drawing.Size(249, 20)
        Me.txt_accselkbank.TabIndex = 43
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "เลขที่สัญญา :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(27, 308)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 16)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "ประเภท :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(18, 257)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 16)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Product :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 48
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
        'dtgvshowkbank
        '
        Me.dtgvshowkbank.AllowUserToAddRows = False
        Me.dtgvshowkbank.AllowUserToDeleteRows = False
        Me.dtgvshowkbank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgvshowkbank.Location = New System.Drawing.Point(13, 33)
        Me.dtgvshowkbank.Name = "dtgvshowkbank"
        Me.dtgvshowkbank.ReadOnly = True
        Me.dtgvshowkbank.Size = New System.Drawing.Size(471, 185)
        Me.dtgvshowkbank.TabIndex = 44
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
        'AxAcroPDFkbank
        '
        Me.AxAcroPDFkbank.Enabled = True
        Me.AxAcroPDFkbank.Location = New System.Drawing.Point(747, 0)
        Me.AxAcroPDFkbank.Name = "AxAcroPDFkbank"
        Me.AxAcroPDFkbank.OcxState = CType(resources.GetObject("AxAcroPDFkbank.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDFkbank.Size = New System.Drawing.Size(517, 985)
        Me.AxAcroPDFkbank.TabIndex = 55
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Untitled_4
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(339, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'txt_bankselkbank
        '
        Me.txt_bankselkbank.Location = New System.Drawing.Point(84, 282)
        Me.txt_bankselkbank.Name = "txt_bankselkbank"
        Me.txt_bankselkbank.ReadOnly = True
        Me.txt_bankselkbank.Size = New System.Drawing.Size(249, 20)
        Me.txt_bankselkbank.TabIndex = 102
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "ธนาคาร :"
        '
        'FrmKBANK
        '
        Me.AcceptButton = Me.cmd_selectkbank
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.txt_bankselkbank)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxAcroPDFkbank)
        Me.Controls.Add(Me.txt_searchkbank)
        Me.Controls.Add(Me.txt_typeselkbank)
        Me.Controls.Add(Me.txt_Prodselkbank)
        Me.Controls.Add(Me.txt_accselkbank)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.dtgvshowkbank)
        Me.Controls.Add(Me.cmd_selectkbank)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmKBANK"
        Me.Text = "ค้นหาเอกสาร KBANK"
        CType(Me.dtgvshowkbank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxAcroPDFkbank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_searchkbank As TextBox
    Friend WithEvents txt_typeselkbank As TextBox
    Friend WithEvents txt_Prodselkbank As TextBox
    Friend WithEvents txt_accselkbank As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmd_clear As Button
    Friend WithEvents dtgvshowkbank As DataGridView
    Friend WithEvents cmd_selectkbank As Button
    Friend WithEvents AxAcroPDFkbank As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_bankselkbank As TextBox
    Friend WithEvents Label1 As Label
End Class
