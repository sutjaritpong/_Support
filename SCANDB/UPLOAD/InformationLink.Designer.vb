﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformationLink
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformationLink))
        Me.Cmd_Delete = New System.Windows.Forms.Button()
        Me.chk_senddata = New System.Windows.Forms.CheckBox()
        Me.lbl_countimport = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_toserver = New System.Windows.Forms.Button()
        Me.cmd_import = New System.Windows.Forms.Button()
        Me.cmd_openfile = New System.Windows.Forms.Button()
        Me.Dtgv_Exe = New System.Windows.Forms.DataGridView()
        Me.txt_Importfile = New System.Windows.Forms.TextBox()
        Me.cbo_products = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_flow = New System.Windows.Forms.Label()
        Me.lbl_statusprogress = New System.Windows.Forms.Label()
        Me.Main_progressbar = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Cmd_Link = New System.Windows.Forms.Button()
        CType(Me.Dtgv_Exe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmd_Delete
        '
        Me.Cmd_Delete.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_Delete.Image = Global.SCANDB.My.Resources.Resources.table_row_delete
        Me.Cmd_Delete.Location = New System.Drawing.Point(876, 6)
        Me.Cmd_Delete.Name = "Cmd_Delete"
        Me.Cmd_Delete.Size = New System.Drawing.Size(107, 31)
        Me.Cmd_Delete.TabIndex = 35
        Me.Cmd_Delete.Text = "ลบข้อมูลซ้ำ"
        Me.Cmd_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cmd_Delete.UseVisualStyleBackColor = False
        '
        'chk_senddata
        '
        Me.chk_senddata.AutoSize = True
        Me.chk_senddata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chk_senddata.Location = New System.Drawing.Point(529, 49)
        Me.chk_senddata.Name = "chk_senddata"
        Me.chk_senddata.Size = New System.Drawing.Size(185, 20)
        Me.chk_senddata.TabIndex = 34
        Me.chk_senddata.Text = "เช็คซ้ำ(ถ้าซ้ำไม่ต้องโหลดเข้าระบบ)"
        Me.chk_senddata.UseVisualStyleBackColor = True
        '
        'lbl_countimport
        '
        Me.lbl_countimport.AutoSize = True
        Me.lbl_countimport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_countimport.Location = New System.Drawing.Point(448, 52)
        Me.lbl_countimport.Name = "lbl_countimport"
        Me.lbl_countimport.Size = New System.Drawing.Size(44, 15)
        Me.lbl_countimport.TabIndex = 33
        Me.lbl_countimport.Text = "XXXXX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(369, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "จำนวนข้อมูล :"
        '
        'cmd_toserver
        '
        Me.cmd_toserver.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_toserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_toserver.Image = Global.SCANDB.My.Resources.Resources.Upload_24x24
        Me.cmd_toserver.Location = New System.Drawing.Point(725, 43)
        Me.cmd_toserver.Name = "cmd_toserver"
        Me.cmd_toserver.Size = New System.Drawing.Size(145, 31)
        Me.cmd_toserver.TabIndex = 31
        Me.cmd_toserver.Text = "Send to Server"
        Me.cmd_toserver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_toserver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_toserver.UseVisualStyleBackColor = False
        '
        'cmd_import
        '
        Me.cmd_import.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_import.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_import.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.cmd_import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_import.Location = New System.Drawing.Point(604, 6)
        Me.cmd_import.Name = "cmd_import"
        Me.cmd_import.Size = New System.Drawing.Size(110, 31)
        Me.cmd_import.TabIndex = 30
        Me.cmd_import.Text = "Import Data"
        Me.cmd_import.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_import.UseVisualStyleBackColor = False
        '
        'cmd_openfile
        '
        Me.cmd_openfile.BackColor = System.Drawing.SystemColors.Window
        Me.cmd_openfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmd_openfile.Location = New System.Drawing.Point(568, 10)
        Me.cmd_openfile.Name = "cmd_openfile"
        Me.cmd_openfile.Size = New System.Drawing.Size(30, 23)
        Me.cmd_openfile.TabIndex = 29
        Me.cmd_openfile.Text = "..."
        Me.cmd_openfile.UseVisualStyleBackColor = False
        '
        'Dtgv_Exe
        '
        Me.Dtgv_Exe.AllowUserToAddRows = False
        Me.Dtgv_Exe.AllowUserToDeleteRows = False
        Me.Dtgv_Exe.BackgroundColor = System.Drawing.SystemColors.Window
        Me.Dtgv_Exe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dtgv_Exe.GridColor = System.Drawing.Color.Black
        Me.Dtgv_Exe.Location = New System.Drawing.Point(12, 84)
        Me.Dtgv_Exe.Name = "Dtgv_Exe"
        Me.Dtgv_Exe.ReadOnly = True
        Me.Dtgv_Exe.RowHeadersVisible = False
        Me.Dtgv_Exe.Size = New System.Drawing.Size(984, 598)
        Me.Dtgv_Exe.TabIndex = 28
        '
        'txt_Importfile
        '
        Me.txt_Importfile.Location = New System.Drawing.Point(105, 12)
        Me.txt_Importfile.Name = "txt_Importfile"
        Me.txt_Importfile.Size = New System.Drawing.Size(457, 20)
        Me.txt_Importfile.TabIndex = 27
        '
        'cbo_products
        '
        Me.cbo_products.FormattingEnabled = True
        Me.cbo_products.Location = New System.Drawing.Point(104, 47)
        Me.cbo_products.Name = "cbo_products"
        Me.cbo_products.Size = New System.Drawing.Size(230, 21)
        Me.cbo_products.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Product ข้อมูล :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "แหล่งข้อมูล :"
        '
        'lbl_flow
        '
        Me.lbl_flow.AutoSize = True
        Me.lbl_flow.Location = New System.Drawing.Point(775, 696)
        Me.lbl_flow.Name = "lbl_flow"
        Me.lbl_flow.Size = New System.Drawing.Size(95, 13)
        Me.lbl_flow.TabIndex = 38
        Me.lbl_flow.Text = "ไม่มีข้อมูลทำงานอยู่"
        Me.lbl_flow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_flow.UseWaitCursor = True
        '
        'lbl_statusprogress
        '
        Me.lbl_statusprogress.AutoSize = True
        Me.lbl_statusprogress.Location = New System.Drawing.Point(197, 696)
        Me.lbl_statusprogress.Name = "lbl_statusprogress"
        Me.lbl_statusprogress.Size = New System.Drawing.Size(30, 13)
        Me.lbl_statusprogress.TabIndex = 37
        Me.lbl_statusprogress.Text = "0 / 0"
        '
        'Main_progressbar
        '
        Me.Main_progressbar.Location = New System.Drawing.Point(14, 692)
        Me.Main_progressbar.Name = "Main_progressbar"
        Me.Main_progressbar.Size = New System.Drawing.Size(177, 23)
        Me.Main_progressbar.TabIndex = 36
        '
        'BackgroundWorker1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Cmd_Link
        '
        Me.Cmd_Link.BackColor = System.Drawing.SystemColors.Window
        Me.Cmd_Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cmd_Link.Image = Global.SCANDB.My.Resources.Resources.Download_24x24
        Me.Cmd_Link.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Link.Location = New System.Drawing.Point(725, 6)
        Me.Cmd_Link.Name = "Cmd_Link"
        Me.Cmd_Link.Size = New System.Drawing.Size(145, 31)
        Me.Cmd_Link.TabIndex = 39
        Me.Cmd_Link.Text = "Import Information"
        Me.Cmd_Link.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Link.UseVisualStyleBackColor = False
        '
        'InformationLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Cmd_Link)
        Me.Controls.Add(Me.lbl_flow)
        Me.Controls.Add(Me.lbl_statusprogress)
        Me.Controls.Add(Me.Main_progressbar)
        Me.Controls.Add(Me.Cmd_Delete)
        Me.Controls.Add(Me.chk_senddata)
        Me.Controls.Add(Me.lbl_countimport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmd_toserver)
        Me.Controls.Add(Me.cmd_import)
        Me.Controls.Add(Me.cmd_openfile)
        Me.Controls.Add(Me.Dtgv_Exe)
        Me.Controls.Add(Me.txt_Importfile)
        Me.Controls.Add(Me.cbo_products)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InformationLink"
        Me.Text = "InformationLink"
        CType(Me.Dtgv_Exe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmd_Delete As Button
    Friend WithEvents chk_senddata As CheckBox
    Friend WithEvents lbl_countimport As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmd_toserver As Button
    Friend WithEvents cmd_import As Button
    Friend WithEvents cmd_openfile As Button
    Friend WithEvents Dtgv_Exe As DataGridView
    Friend WithEvents txt_Importfile As TextBox
    Friend WithEvents cbo_products As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_flow As Label
    Friend WithEvents lbl_statusprogress As Label
    Friend WithEvents Main_progressbar As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Cmd_Link As Button
End Class