''Option Explicit On
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Net
Imports Microsoft.Win32
Imports System.Globalization
Public Class FrmLogin
    Dim ip As IPAddress()
    Dim internetstatus As Boolean

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()

        internetcheck.RunWorkerAsync()

        txt_idlog.Text = My.Settings.username

        If My.Settings.username = "" Then                   '// จำUSERID ที่ใช้ล็อคอินล่าสุด

            chk_rememuser.Checked = False

        Else

            chk_rememuser.Checked = True

        End If
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim _userid As String = txt_idlog.Text
        Dim _pass As String = txt_passlog.Text

        If txt_idlog.Text = "" Or txt_passlog.Text = "" Then
            Msg_error("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        sql = ("SELECT * FROM tbl_login WHERE USERID = '" & txt_idlog.Text & "'")
        Dim cmd As New SqlCommand(sql, cn)                      '// ดึงข้อมูล ID จากฐานข้อมูลถ้าไม่มีให้แจ้งเตือนผู้ใช้
        Dim DA As New SqlDataAdapter(cmd)
        Dim DS As New DataSet
        DA.Fill(DS, "table")
        If DS.Tables("table").Rows.Count <= 0 Then
            Msg_error("ไม่มี USER ในระบบ")
            Return
        End If

        _sql = ("SELECT * FROM tbl_login WHERE USERID = '" & txt_idlog.Text & "'And USRPASSWORD = '" & txt_passlog.Text & "' ")
        cmd.CommandText = _sql
        DA.SelectCommand = cmd
        DA.Fill(DS, "CHECKPASS")                                            '//เช็คPassword ถ้าผิด ให้แจ้งเตือน
        Dim count_user As Integer = DS.Tables("CHECKPASS").Rows.Count

        If count_user = 0 Then
            MsgBox("กรุณากรอกชื่อหรือรหัสผ่านให้ถูกต้อง")
            txt_passlog.Text = ""
            txt_idlog.Select()
            _sql = ($"UPDATE tbl_login SET USRPASSFAIL = USRPASSFAIL+1 WHERE USERID = '{txt_idlog.Text}'")
            cmd.CommandText = _sql
            cmd.ExecuteScalar()             '//เช็คจำนวนครั้งที่ใส่รหัสผิดให้เพิ่มขึ้นทีละ 1 
            _sql = ($"SELECT * FROM tbl_login WHERE USERID = '{txt_idlog.Text}'")
            cmd.CommandText = _sql
            DA.SelectCommand = cmd
            DA.Fill(DS, "FAIL")
            _sql = ("SELECT * FROM tbl_setting")
            cmd.CommandText = _sql
            DA.SelectCommand = cmd
            DA.Fill(DS, "checkpass")

            If DS.Tables("FAIL").Rows(0)("USRPASSFAIL") > DS.Tables("checkpass").Rows(0)("Faillimit") Then
                _sql = ($"UPDATE tbl_login SET USRLOCK = '1' WHERE USERID = '{txt_idlog.Text}'")
                cmd.CommandText = _sql                                      '// อัพเดทสถานะผู่้ใช้ให้ล็อค ในกรณี ที่ใส่รหัสผิดเกินกำหนด
                cmd.ExecuteScalar()
                Msg_error("คุณใส่รหัสผ่านผิดเกินจำนวนที่กำหนดกรุณาแจ้งผู้ดูแล")      '//เช็คถ้ารหัสผ่านผิดเกิน 3 ครั้งให้ ล็อค!

                Exit Sub

            End If

        Else
            sql = $"SELECT *,DATEDIFF(DAY,USRPASCHANGE,GETDATE())as Changepass  FROM tbl_login WHERE USERID = '{txt_idlog.Text}' AND USRPASSWORD = '{txt_passlog.Text}'"
            cmd.CommandText = sql
            DA.SelectCommand = cmd                  '//เช็ควันที่ล็อคอิน ถ้าลบกับวันที่ต้องเปลี่ยนรหัสเกินที่กำหนดให้ แสดงหน้าเปลี่ยนรหัสผ่าน
            DA.Fill(DS, "timechange")
            sql = "SELECT * FROM tbl_setting"
            cmd.CommandText = sql
            DA.SelectCommand = cmd
            DA.Fill(DS, "limitpass")
            Dim checkdiffpass As Integer = DS.Tables("timechange").Rows(0)("Changepass")
            Dim checklimitpass As Integer = DS.Tables("limitpass").Rows(0)("Changelimit")

            If checkdiffpass >= checklimitpass Then
                FrmPasschange.Show()
                txt_idlog.Enabled = False
                txt_passlog.Enabled = False
                Return

            End If

            sql = $"SELECT *,DATEDIFF(DAY,USRLOGIN,GETDATE())as Age  FROM tbl_login WHERE USERID = '{txt_idlog.Text}' AND USRPASSWORD = '{txt_passlog.Text}'"
            cmd.CommandText = sql
                DA.SelectCommand = cmd                  '//เช็ควันที่ล็อคอิน ถ้าลบกับวันที่ ปัจจุบันเกินที่กำหนดให้ล็อค
                DA.Fill(DS, "TIME")
                sql = "SELECT * FROM tbl_setting"
                cmd.CommandText = sql
                DA.SelectCommand = cmd
                DA.Fill(DS, "checkday")
                Dim checkdiff As Integer = DS.Tables("TIME").Rows(0)("Age")
                Dim checkday As Integer = DS.Tables("checkday").Rows(0)("daylimit")
                If checkdiff >= checkday Then
                    sql = $"UPDATE tbl_login SET USRLOCK = '1' WHERE USERID = '{txt_idlog.Text}' AND USRPASSWORD = '{txt_passlog.Text}'"
                    cmd.CommandText = sql
                    cmd.ExecuteScalar()
                Msg_error("ไม่ได้ล็อคอินนานเกินกำหนด กรุณาแจ้งผู้ดูแลระบบ")

            End If

            sql = $"Select * FROM tbl_login WHERE USERID = '{txt_idlog.Text}'and USRPASSWORD = '{txt_passlog.Text}'"
            cmd.CommandText = sql
                DA.SelectCommand = cmd                      '// เช็ค USERID ที่ทำการล็อคอินเข้ามาถ้า สถานะเป็นล็อคให้แจ้งเตือน
                DA.Fill(DS, "Lock")
                Dim check As Boolean = DS.Tables("LOCK").Rows(0)("USRLOCK")

            If check <> False Then
                Msg_error("ไม่สามารถเข้าสู่ระบบได้เนื่องจาก ขาดการใช้งานหรือจำนวนครั้ง ในการใส่รหัสผ่านผิดเกินกำหนด โปรดติดต่อผู้ดูแล!")
                Return

            End If
            sql = ("UPDATE tbl_login SET USRLOGIN = GETDATE() WHERE USERID ='" & txt_idlog.Text & "' AND USRPASSWORD = '" & txt_passlog.Text & "' ")          '// อัพเดทเวลาล็อคอินล่าสุดเข้าฐานข้อมูล
            cmd_excuteScalar()
            Msg_OK("Login สำเร็จ!")
                Me.Hide()
                FrmMain.Show()
                sql = ("SELECT * FROM tbl_login WHERE USERID = '" & txt_idlog.Text & "'AND USRPASSWORD = '" & txt_passlog.Text & "' ")
                Dim dts As DataTable = cmd_excuteToDataTable()              '//นำเข้ามูลต่าง ๆ ที่จำเป็นไปแสดงในหน้า Main

            With FrmMain
                .tsl_ip.Text = aws.LocalIP                  '// แสดง IP
                .tsl_id.Text = dts.Rows(0)("USERID")        '// แสดง ID
                .tsl_username.Text = dts.Rows(0)("USRNAME")     '// แสดง FULLNAME ชื่อเต็ม
                .tsl_group.Text = dts.Rows(0)("USRGROUP")       '// แสดง กลุ่มงาน เช่น Admin Collletor
                .tsl_time.Text = Date.Now                           '// แสดงเวลาที่ใช้ล็อคอินปัจจุบัน
                .tsl_pcname.Text = pc
                .tsl_version.Text = lbl_version.Text                '// แสดงเวอร์ชั่นที่ใช้งานในปัจจุบัน

            End With

            Permissions(_userid, _pass)

        End If

    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        If Msg_confirm("คุณต้องการออกจากโปรแกรมหรือไม่") = vbYes Then End

    End Sub
    Private Sub chk_Password_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Password.CheckedChanged

        If chk_Password.Checked = True Then         '// ปุ่ม check ให้แสดงหรือซ่อน Password
            txt_passlog.PasswordChar = ""     '// PasswordChar  คือแสดงรหัสผ่านเป้นอะไร
        Else
            txt_passlog.PasswordChar = "•"
        End If

    End Sub
    Private Sub chk_rememuser_CheckedChanged(sender As Object, e As EventArgs) Handles chk_rememuser.CheckedChanged

        If chk_rememuser.Checked = True Then

            My.Settings.username = txt_idlog.Text              '// เช็คว่ามีการจำ USERID เคยล็อคอินล่าสุดไหม ถ้า Checkbox ติ๊กถูกให้จำรหัสผ่าน
        Else

            My.Settings.username = ""

        End If

        My.Settings.Save()

    End Sub

    Private Sub internetcheck_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles internetcheck.DoWork

        If My.Computer.Network.IsAvailable Then                         '// ฟังชั่นเช็คระบบ internet โดยใช้ toolbox winsock

            internetstatus = True

        Else

            internetstatus = False

        End If
    End Sub

    Private Sub internetcheck_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles internetcheck.RunWorkerCompleted

        If internetstatus = True Then

            lblnetstatus.Text = "Connection Status : Available"             '// เช็คระบบ INTERNET ถ้าไม่เชื่อมต่อให้เป็น Available
        Else

            lblnetstatus.Text = "Connection Status : Not Available"         '// เช็คระบบ INTERNET ถ้าไม่เชื่อมต่อให้เป็น Not Available
        End If

        internetcheck.RunWorkerAsync()

    End Sub

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.Dispose()
        cn.Close()

        End

    End Sub

End Class
