Option Explicit On
Imports System.Data.SqlClient
Public Class FrmPasssetting
    Private Sub FrmPasssetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Chk_Password_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Password.CheckedChanged

        If chk_Password.Checked = True Then         '// ปุ่ม check ให้แสดงหรือซ่อน Password
            txt_passbefores.PasswordChar = ""     '// PasswordChar  คือแสดงรหัสผ่านเป้นอะไร
        Else
            txt_passbefores.PasswordChar = "•"
        End If

    End Sub

    Private Sub Cmd_ok_Click(sender As Object, e As EventArgs) Handles cmd_ok.Click
        Connect()
        sql = $"SELECT USRPASSWORD FROM tbl_login WHERE USERID = '{FrmLogin.txt_idlog.Text}'"
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "check")

        If txt_passbefores.Text <> DS.Tables("check").Rows(0)("USRPASSWORD") Then
            Msg_error("รหัสผ่านเดิมไม่ตรงกัน กรุณากรอกรหัสผ่านเดิมอีกครั้ง")      '// เช็คว่า ข้อมูลที่กรอกลงบน textbox ตรงกับใน ฐานข้อมูลรึป่าว
            Return
        End If
        If txt_passchanges.Text = DS.Tables("check").Rows(0)("USRPASSWORD") Then
            Msg_error("กรุณา กรอกรหัสผ่านใหม่ห้ามให้เหมือนกับรหัสผ่านปัจจุบัน")         '// เช็คว่าข้อมูลที่กรอกลงบน textbox ซ้ำกับอันเก่ารึป่าว
            Return                                                       '//เนื่องจากเป็นการระบุรหัสผ่านใหม่จึงต้องห้ามซ้ำกับอันเก่า
        End If
        If txt_passchanges.Text <> txt_passagains.Text Then      '//เช็คข้อมูลรหัสผ่านใหม่ (textช่องบน) เหมือนกับ (ช่องล่าง)ที่ให้กรอกซ้ำอีกครั้ง
            Msg_error("กรุณากรอกรหัสผ่านใหม่ให้ตรงกันทั้งสองอัน")        '// ถ้าไม่เหมือนให้กรอกใหม่
            Return
        Else

            _sql = $"UPDATE tbl_login SET USRPASSWORD = '{txt_passchanges.Text}',USRPASCHANGE = GETDATE() WHERE USERID = '{FrmLogin.txt_idlog.Text}'"
            cmd.CommandText = _sql
            cmd.ExecuteScalar()

            Msg_OK("เปลี่ยนรหัสผ่านสำเร็จ")

            Getlogdata($"ผู้ใช้ {FrmLogin.txt_idlog.Text} ได้เปลี่ยนแปลงรหัสผ่าน")
            cn.Close()
        End If
    End Sub

    Private Sub Cmd_no_Click(sender As Object, e As EventArgs) Handles cmd_no.Click

        txt_passbefores.Clear()
        txt_passagains.Clear()
        txt_passbefores.Clear()
        Me.Close()

    End Sub

    Private Sub FrmPasssetting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.Dispose()

    End Sub
End Class