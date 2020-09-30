<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.lbl_loginlogo = New System.Windows.Forms.Label()
        Me.chk_rememuser = New System.Windows.Forms.CheckBox()
        Me.chk_Password = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_passlog = New System.Windows.Forms.TextBox()
        Me.txt_idlog = New System.Windows.Forms.TextBox()
        Me.lblnetstatus = New System.Windows.Forms.Label()
        Me.internetcheck = New System.ComponentModel.BackgroundWorker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.aws = New AxMSWinsockLib.AxWinsock()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Ptb_connection = New System.Windows.Forms.PictureBox()
        CType(Me.aws, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ptb_connection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_loginlogo
        '
        Me.lbl_loginlogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_loginlogo.AutoSize = True
        Me.lbl_loginlogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_loginlogo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_loginlogo.Location = New System.Drawing.Point(60, 28)
        Me.lbl_loginlogo.Name = "lbl_loginlogo"
        Me.lbl_loginlogo.Size = New System.Drawing.Size(237, 73)
        Me.lbl_loginlogo.TabIndex = 5
        Me.lbl_loginlogo.Text = "LOGIN"
        '
        'chk_rememuser
        '
        Me.chk_rememuser.AutoSize = True
        Me.chk_rememuser.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.chk_rememuser.Location = New System.Drawing.Point(29, 190)
        Me.chk_rememuser.Name = "chk_rememuser"
        Me.chk_rememuser.Size = New System.Drawing.Size(128, 17)
        Me.chk_rememuser.TabIndex = 20
        Me.chk_rememuser.Text = "Remember Username"
        Me.chk_rememuser.UseVisualStyleBackColor = True
        '
        'chk_Password
        '
        Me.chk_Password.AutoSize = True
        Me.chk_Password.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.chk_Password.Location = New System.Drawing.Point(29, 283)
        Me.chk_Password.Name = "chk_Password"
        Me.chk_Password.Size = New System.Drawing.Size(102, 17)
        Me.chk_Password.TabIndex = 19
        Me.chk_Password.Text = "Show Password"
        Me.chk_Password.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(29, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 28)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(25, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 28)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "USERNAME"
        '
        'txt_passlog
        '
        Me.txt_passlog.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_passlog.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_passlog.Location = New System.Drawing.Point(29, 242)
        Me.txt_passlog.Name = "txt_passlog"
        Me.txt_passlog.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_passlog.Size = New System.Drawing.Size(301, 35)
        Me.txt_passlog.TabIndex = 2
        '
        'txt_idlog
        '
        Me.txt_idlog.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_idlog.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_idlog.Location = New System.Drawing.Point(30, 149)
        Me.txt_idlog.Name = "txt_idlog"
        Me.txt_idlog.Size = New System.Drawing.Size(300, 35)
        Me.txt_idlog.TabIndex = 1
        '
        'lblnetstatus
        '
        Me.lblnetstatus.AutoSize = True
        Me.lblnetstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblnetstatus.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblnetstatus.Location = New System.Drawing.Point(156, 444)
        Me.lblnetstatus.Name = "lblnetstatus"
        Me.lblnetstatus.Size = New System.Drawing.Size(140, 16)
        Me.lblnetstatus.TabIndex = 25
        Me.lblnetstatus.Text = "Connection Status :"
        '
        'internetcheck
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(9, 443)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Version"
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_version.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_version.Location = New System.Drawing.Point(70, 444)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(35, 15)
        Me.lbl_version.TabIndex = 28
        Me.lbl_version.Text = "1.10"
        '
        'aws
        '
        Me.aws.Enabled = True
        Me.aws.Location = New System.Drawing.Point(1, 0)
        Me.aws.Name = "aws"
        Me.aws.OcxState = CType(resources.GetObject("aws.OcxState"), System.Windows.Forms.AxHost.State)
        Me.aws.Size = New System.Drawing.Size(28, 28)
        Me.aws.TabIndex = 30
        Me.aws.Visible = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.White
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnlogin.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnlogin.Image = Global.SCANDB.My.Resources.Resources._32x32accept
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogin.Location = New System.Drawing.Point(38, 326)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(119, 45)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "      OK"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.White
        Me.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btncancel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btncancel.Image = Global.SCANDB.My.Resources.Resources._32x32delete
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.Location = New System.Drawing.Point(192, 326)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(119, 45)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Ptb_connection
        '
        Me.Ptb_connection.Location = New System.Drawing.Point(302, 428)
        Me.Ptb_connection.Name = "Ptb_connection"
        Me.Ptb_connection.Size = New System.Drawing.Size(32, 32)
        Me.Ptb_connection.TabIndex = 29
        Me.Ptb_connection.TabStop = False
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btncancel
        Me.ClientSize = New System.Drawing.Size(344, 468)
        Me.Controls.Add(Me.aws)
        Me.Controls.Add(Me.Ptb_connection)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblnetstatus)
        Me.Controls.Add(Me.chk_rememuser)
        Me.Controls.Add(Me.chk_Password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txt_passlog)
        Me.Controls.Add(Me.txt_idlog)
        Me.Controls.Add(Me.lbl_loginlogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.aws, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ptb_connection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_loginlogo As Label
    Friend WithEvents chk_rememuser As CheckBox
    Friend WithEvents chk_Password As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btncancel As Button
    Friend WithEvents btnlogin As Button
    Friend WithEvents txt_passlog As TextBox
    Friend WithEvents txt_idlog As TextBox
    Friend WithEvents lblnetstatus As Label
    Friend WithEvents internetcheck As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_version As Label
    Friend WithEvents Ptb_connection As PictureBox
    Friend WithEvents aws As AxMSWinsockLib.AxWinsock
End Class
