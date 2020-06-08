<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUOB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUOB))
        Me.AxAcroPDFuob = New AxAcroPDFLib.AxAcroPDF()
        Me.txt_searchuob = New System.Windows.Forms.TextBox()
        Me.txt_typeseluob = New System.Windows.Forms.TextBox()
        Me.txt_Prodseluob = New System.Windows.Forms.TextBox()
        Me.txt_accseluob = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtgvshowuob = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.cmd_selectuob = New System.Windows.Forms.Button()
        Me.txt_bankseluob = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AxAcroPDFuob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvshowuob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDFuob
        '
        Me.AxAcroPDFuob.Dock = System.Windows.Forms.DockStyle.Right
        Me.AxAcroPDFuob.Enabled = True
        Me.AxAcroPDFuob.Location = New System.Drawing.Point(491, 0)
        Me.AxAcroPDFuob.Name = "AxAcroPDFuob"
        Me.AxAcroPDFuob.OcxState = CType(resources.GetObject("AxAcroPDFuob.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDFuob.Size = New System.Drawing.Size(517, 729)
        Me.AxAcroPDFuob.TabIndex = 115
        '
        'txt_searchuob
        '
        Me.txt_searchuob.Location = New System.Drawing.Point(84, 6)
        Me.txt_searchuob.Name = "txt_searchuob"
        Me.txt_searchuob.Size = New System.Drawing.Size(229, 20)
        Me.txt_searchuob.TabIndex = 1
        '
        'txt_typeseluob
        '
        Me.txt_typeseluob.Location = New System.Drawing.Point(84, 308)
        Me.txt_typeseluob.Name = "txt_typeseluob"
        Me.txt_typeseluob.ReadOnly = True
        Me.txt_typeseluob.Size = New System.Drawing.Size(249, 20)
        Me.txt_typeseluob.TabIndex = 109
        '
        'txt_Prodseluob
        '
        Me.txt_Prodseluob.Location = New System.Drawing.Point(84, 256)
        Me.txt_Prodseluob.Name = "txt_Prodseluob"
        Me.txt_Prodseluob.ReadOnly = True
        Me.txt_Prodseluob.Size = New System.Drawing.Size(249, 20)
        Me.txt_Prodseluob.TabIndex = 108
        '
        'txt_accseluob
        '
        Me.txt_accseluob.Location = New System.Drawing.Point(84, 230)
        Me.txt_accseluob.Name = "txt_accseluob"
        Me.txt_accseluob.ReadOnly = True
        Me.txt_accseluob.Size = New System.Drawing.Size(249, 20)
        Me.txt_accseluob.TabIndex = 105
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(66, 13)
        Me.Label25.TabIndex = 113
        Me.Label25.Text = "เลขที่สัญญา :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(27, 308)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 16)
        Me.Label22.TabIndex = 112
        Me.Label22.Text = "ประเภท :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(18, 256)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 16)
        Me.Label21.TabIndex = 111
        Me.Label21.Text = "Product :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(10, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 16)
        Me.Label16.TabIndex = 110
        Me.Label16.Text = "เลขที่สัญญา :"
        '
        'dtgvshowuob
        '
        Me.dtgvshowuob.AllowUserToAddRows = False
        Me.dtgvshowuob.AllowUserToDeleteRows = False
        Me.dtgvshowuob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgvshowuob.Location = New System.Drawing.Point(13, 33)
        Me.dtgvshowuob.Name = "dtgvshowuob"
        Me.dtgvshowuob.ReadOnly = True
        Me.dtgvshowuob.Size = New System.Drawing.Size(471, 185)
        Me.dtgvshowuob.TabIndex = 106
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SCANDB.My.Resources.Resources.Untitled_1
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(339, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'cmd_clear
        '
        Me.cmd_clear.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__40_
        Me.cmd_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_clear.Location = New System.Drawing.Point(409, 4)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(75, 23)
        Me.cmd_clear.TabIndex = 1
        Me.cmd_clear.Text = "เคลีย"
        Me.cmd_clear.UseVisualStyleBackColor = True
        '
        'cmd_selectuob
        '
        Me.cmd_selectuob.Image = Global.SCANDB.My.Resources.Resources._16x16_icon__42_
        Me.cmd_selectuob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_selectuob.Location = New System.Drawing.Point(319, 4)
        Me.cmd_selectuob.Name = "cmd_selectuob"
        Me.cmd_selectuob.Size = New System.Drawing.Size(84, 23)
        Me.cmd_selectuob.TabIndex = 1
        Me.cmd_selectuob.Text = "ค้นหา"
        Me.cmd_selectuob.UseVisualStyleBackColor = True
        '
        'txt_bankseluob
        '
        Me.txt_bankseluob.Location = New System.Drawing.Point(84, 282)
        Me.txt_bankseluob.Name = "txt_bankseluob"
        Me.txt_bankseluob.ReadOnly = True
        Me.txt_bankseluob.Size = New System.Drawing.Size(249, 20)
        Me.txt_bankseluob.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "ธนาคาร :"
        '
        'FrmUOB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.txt_bankseluob)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AxAcroPDFuob)
        Me.Controls.Add(Me.txt_searchuob)
        Me.Controls.Add(Me.txt_typeseluob)
        Me.Controls.Add(Me.txt_Prodseluob)
        Me.Controls.Add(Me.txt_accseluob)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.dtgvshowuob)
        Me.Controls.Add(Me.cmd_selectuob)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmUOB"
        Me.Text = "ค้นหาเอกสาร UOB"
        CType(Me.AxAcroPDFuob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvshowuob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxAcroPDFuob As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents txt_searchuob As TextBox
    Friend WithEvents txt_typeseluob As TextBox
    Friend WithEvents txt_Prodseluob As TextBox
    Friend WithEvents txt_accseluob As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmd_clear As Button
    Friend WithEvents dtgvshowuob As DataGridView
    Friend WithEvents cmd_selectuob As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_bankseluob As TextBox
    Friend WithEvents Label1 As Label
End Class
