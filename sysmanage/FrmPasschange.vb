Option Explicit On
Imports System.Data.SqlClient

Public Class FrmPasschange
    Private Sub FrmPasschange_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub chk_Password_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Password.CheckedChanged
        If chk_Password.Checked = True Then         '// ปุ่ม check ให้แสดงหรือซ่อน Password
            txt_passbefore.PasswordChar = ""     '// PasswordChar  คือแสดงรหัสผ่านเป้นอะไร
        Else
            txt_passbefore.PasswordChar = "•"
        End If
    End Sub

    Private Sub cmd_ok_Click(sender As Object, e As EventArgs) Handles cmd_ok.Click

        sql = $"SELECT USRPASSWORD FROM tbl_login WHERE USERID = '{FrmLogin.txt_idlog.Text}'"
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "check")
        If txt_passbefore.Text <> DS.Tables("check").Rows(0)("USRPASSWORD") Then
            Msg_error("รหัสผ่านเดิมไม่ตรงกัน กรุณากรอกรหัสผ่านเดิมอีกครั้ง")      '// เช็คว่า ข้อมูลที่กรอกลงบน textbox ตรงกับใน ฐานข้อมูลรึป่าว
            Return
        End If
        If txt_passnew.Text = DS.Tables("check").Rows(0)("USRPASSWORD") Then
            Msg_error("กรุณา กรอกรหัสผ่านใหม่ห้ามให้เหมือนกับรหัสผ่านปัจจุบัน")         '// เช็คว่าข้อมูลที่กรอกลงบน textbox ซ้ำกับอันเก่ารึป่าว
            Return                                                       '//เนื่องจากเป็นการระบุรหัสผ่านใหม่จึงต้องห้ามซ้ำกับอันเก่า
        End If
        If txt_passnew.Text <> txt_passagain.Text Then      '//เช็คข้อมูลรหัสผ่านใหม่ (textช่องบน) เหมือนกับ (ช่องล่าง)ที่ให้กรอกซ้ำอีกครั้ง
            Msg_error("กรุณากรอกรหัสผ่านใหม่ให้ตรงกันทั้งสองอัน")        '// ถ้าไม่เหมือนให้กรอกใหม่
            Return
        Else

            Msg_OK("เปลี่ยนรหัสผ่านสำเร็จ")

            _sql = $"UPDATE tbl_login SET USRPASSWORD = '{txt_passnew.Text}',USRPASCHANGE = GETDATE() WHERE USERID = '{FrmLogin.txt_idlog.Text}'"
            cmd.CommandText = _sql
            cmd.ExecuteScalar()                                 '// อัพเดทรหัสผ่านใหม่ ! 
            FrmLogin.txt_idlog.Enabled = True
            FrmLogin.txt_passlog.Enabled = True

            sql = ("SELECT * FROM tbl_login WHERE USERID = '" & FrmLogin.txt_idlog.Text & "'")
            Dim dts As DataTable = cmd_excuteToDataTable()              '//นำเข้ามูลต่าง ๆ ที่จำเป็นไปแสดงในหน้า Main
            With FrmMastermain
                .tsl_ip.Text = FrmLogin.aws.LocalIP                  '// แสดง IP
                .tsl_id.Text = dts.Rows(0)("USERID")        '// แสดง ID
                .tsl_username.Text = dts.Rows(0)("USRNAME")     '// แสดง FULLNAME ชื่อเต็ม
                .tsl_group.Text = dts.Rows(0)("USRGROUP")       '// แสดง กลุ่มงาน เช่น Admin Collletor
                .tsl_time.Text = Date.Now                           '// แสดงเวลาที่ใช้ล็อคอินปัจจุบัน
                .tsl_pcname.Text = pc
                .tsl_version.Text = FrmLogin.lbl_version.Text                '// แสดงเวอร์ชั่นที่ใช้งานในปัจจุบัน
            End With

            If DS.Tables("table").Rows(0)("USRGROUP") = "Admin" Or DS.Tables("table").Rows(0)("USRGROUP") = "Collector" Then
                FrmMastermain.menu_accms.Enabled = False                   '// เช็คสิทธิ การเข้าถึงฟอร์มต่าง ๆ
                FrmMastermain.menu_settingms.Enabled = False
                FrmMastermain.menu_Historyms.Enabled = False
                FrmMastermain.MENU_Uploads_SCANPDF.Enabled = False

            End If

            sql = ("UPDATE tbl_login SET USRLOGIN = '" & FrmMastermain.tsl_time.Text & "' WHERE USERID ='" & FrmLogin.txt_idlog.Text & "'")          '// อัพเดทเวลาล็อคอินล่าสุดเข้าฐานข้อมูล
            cmd_excuteScalar()
            FrmMastermain.Show()
            Me.Close()
            FrmLogin.Hide()

            FrmLogin.txt_passlog.Text = ""

            _Getlogdata($"ผู้ใช้ {FrmLogin.txt_idlog.Text} ได้เปลี่ยนแปลงรหัสผ่าน")

        End If
    End Sub

    Private Sub cmd_no_Click(sender As Object, e As EventArgs) Handles cmd_no.Click

        Me.Dispose()
        txt_passnew.Clear()
        txt_passagain.Clear()
        txt_passbefore.Clear()
        Me.Close()
        FrmLogin.txt_idlog.Enabled = True
        FrmLogin.txt_passlog.Enabled = True

    End Sub
    Private Sub frmpasschange_closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.Dispose()
        FrmLogin.txt_idlog.Enabled = True
        FrmLogin.txt_passlog.Enabled = True

    End Sub
End Class