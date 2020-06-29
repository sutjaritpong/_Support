Option Explicit On
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Net
Imports Microsoft.Win32
Imports System.Globalization
'## ip As IPAddress() ตัวแปรสำหรับเก็บค่า IP Computer Client ที่เข้ามาใช้งาน ##
'## internetstatus As Boolean ตัวแปรใช้เช็คค่า True False ในการเชื่อมต่อ Network ##
Public Class FrmLogin

    Dim ip As IPAddress()
    Dim internetstatus As Boolean

    '## Event Load เรียกใช้เมื่อเปิด Form ให้ทำการ เช็คสถานะ Internet มีการเก็บ ค่า Username ไว้ใน Setting เพื่อให้ง่ายต่อการใช้งานระบบ ##

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        internetcheck.RunWorkerAsync()

        txt_idlog.Text = My.Settings.username

        '## จำ USERID ที่ใช้ล็อคอินล่าสุด

        If My.Settings.username = "" Then

            chk_rememuser.Checked = False

        Else

            chk_rememuser.Checked = True

        End If
    End Sub

    '## ปุ่มล็อคอิน มีเงื่อนไขในการเช็คข้อมูลต่าง ๆ ในการดึงข้อมูลจาก Database เงื่อนไขได้แก่ เช็คข้อมูลว่ากรอก Username Password หรือไม่, ดึงข้อมูล ID จากฐานข้อมูลเช็ค Username ถ้าไม่มีให้แจ้งเตือนผู้ใช้ หรือ กรณีใส่ข้อมูลผิด หลังจากข้อมุลถูกต้องให้ตรวจสอบว่า พบรหัสผ่าน ที่ตรงกับ UserID นี้หรือไม่ เช็ค Password ถ้าผิด ให้แจ้งเตือน ถ้าใส่รหัสผ่านผิดให้นับจำนวนครั้ง ที่ใส่ผิดถ้าเกินจำนวนที่กำหนด ให้ ระงับสิทธิการเข้าใช้งานโปรแกรม เงื่อนไขเกี่ยวกับวันที่เข้าใช้งาน วันที่สร้างรหัส วันที่เปลี่ยนรหัส โดยกำหนด เงื่อนไขถ้าเกินเวลา ที่กำหนดไว้ในตาราง tbl_setting ให้ระงับการใช้งาน หรือถ้าเกินเวลาหมดอายุของรหัสผ่าน ให้ User ทำการเปลี่ยนรหัส ##

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        connect()

        Dim _userid As String = txt_idlog.Text
        Dim _pass As String = txt_passlog.Text

        '## เช็คข้อมูลว่ากรอก Username Password หรือไม่ ##

        If txt_idlog.Text = "" Or txt_passlog.Text = "" Then
            Msg_error("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        '## ดึงข้อมูล ID จากฐานข้อมูลในตาราง tbl_login คอลัมน์ USERID ถ้าไม่มีให้แจ้งเตือนผู้ใช้ หรือ กรณีใส่ข้อมูลผิด ##

        sql = ($"SELECT * FROM tbl_login WHERE USERID = '{txt_idlog.Text}'")
        Dim cmd As New SqlCommand(sql, cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim DS As New DataSet
        DA.Fill(DS, "table")
        If DS.Tables("table").Rows.Count <= 0 Then
            Msg_error("ไม่มี USER ในระบบ")
            Return
        End If

        '## หลังจากข้อมุลถูกต้องให้ตรวจสอบว่า พบรหัสผ่าน ที่ตรงกับ UserID นี้หรือไม่ เช็ค Password ถ้าผิด ให้แจ้งเตือน ##

        _sql = ("SELECT * FROM tbl_login WHERE USERID = '" & txt_idlog.Text & "'And USRPASSWORD = '" & txt_passlog.Text & "' ")
        cmd.CommandText = _sql
        DA.SelectCommand = cmd
        DA.Fill(DS, "CHECKPASS")
        Dim count_user As Integer = DS.Tables("CHECKPASS").Rows.Count

        If count_user = 0 Then
            MsgBox("กรุณากรอกชื่อหรือรหัสผ่านให้ถูกต้อง")
            txt_passlog.Text = ""
            txt_idlog.Select()

            '## เช็คจำนวนครั้งที่ใส่รหัสผิดให้เพิ่มขึ้นทีละ 1 และเพิ่มลงไปในฐานข้อมูล จากตาราง Tbl_login คอลัมน์ USRPASSFAIL  ##

            _sql = ($"UPDATE tbl_login SET USRPASSFAIL = USRPASSFAIL+1 WHERE USERID = '{txt_idlog.Text}'")
            cmd.CommandText = _sql
            cmd.ExecuteScalar()


            _sql = ($"SELECT * FROM tbl_login WHERE USERID = '{txt_idlog.Text}'")
            cmd.CommandText = _sql
            DA.SelectCommand = cmd
            DA.Fill(DS, "FAIL")

            '## เรียกการตั้งค่าจำนวนครั้งในการใส่รหัสผิดจากฐานข้อมุล ตาราง tbl_setting

            _sql = ("SELECT * FROM tbl_setting")
            cmd.CommandText = _sql
            DA.SelectCommand = cmd
            DA.Fill(DS, "checkpass")

            '## อัพเดทสถานะผู่้ใช้ให้ ล็อค กรณีที่ใส่รหัสผิดเกินจำนวนครั้งที่กำหนด โดยการนำ ข้อมูลจำนวนครั้งจากตาราง tbl_login มาเทียบค่า กับข้อกำหนดจาก ตาราง tbl_setting ถ้า เกินจำนวนครั้งให้ ระงับการใช้งานโปรแกรม

            If DS.Tables("FAIL").Rows(0)("USRPASSFAIL") > DS.Tables("checkpass").Rows(0)("Faillimit") Then
                _sql = ($"UPDATE tbl_login SET USRLOCK = '1' WHERE USERID = '{txt_idlog.Text}'")
                cmd.CommandText = _sql
                cmd.ExecuteScalar()

                Msg_error("คุณใส่รหัสผ่านผิดเกินจำนวนที่กำหนดกรุณาแจ้งผู้ดูแล")

                cn.Close()

                Exit Sub

            End If

        Else

            '## เงื่อนไขเกี่ยวกับวันที่เข้าใช้งาน วันที่สร้างรหัส วันที่เปลี่ยนรหัส โดยกำหนด เงื่อนไขถ้าเกินเวลา ที่กำหนดไว้ในตาราง tbl_setting ให้ระงับการใช้งาน หรือถ้าเกินเวลาหมดอายุของรหัสผ่าน ให้ User ทำการเปลี่ยนรหัส ##

            '## เช็ควันที่ล็อคอินล่าสุดจาก ในตาราง tbl_login คอลัมน์ USRPASCHANGE ถ้าลบกับวันที่ปัจจุบันได้ มากกว่าหรือเท่ากับ วันที่กำหนดให้ ในตาราง tbl_setting แสดงหน้าเปลี่ยนรหัสผ่าน ##

            sql = $"SELECT *,DATEDIFF(DAY,USRPASCHANGE,GETDATE()) as Changepass  FROM tbl_login WHERE USERID = '{txt_idlog.Text}' AND USRPASSWORD = '{txt_passlog.Text}'"
            cmd.CommandText = sql
            DA.SelectCommand = cmd
            DA.Fill(DS, "timechange")

            sql = "SELECT * FROM tbl_setting"
            cmd.CommandText = sql
            DA.SelectCommand = cmd
            DA.Fill(DS, "limitpass")

            Dim checkdiffpass As Integer = DS.Tables("timechange").Rows(0)("Changepass")
            Dim checklimitpass As Integer = DS.Tables("limitpass").Rows(0)("Changelimit")

            If checkdiffpass >= checklimitpass Then

                If Application.OpenForms().OfType(Of FrmPasschange).Any Then

                    FrmPasschange.Focus()
                Else
                    FrmPasschange.ShowDialog()
                    FrmPasschange.StartPosition = FormStartPosition.CenterScreen
                    txt_idlog.Enabled = False
                    txt_passlog.Enabled = False
                    Return

                End If

            End If

            '## เช็ควันที่ล็อคอิน ถ้าลบกับวันที่ ปัจจุบันเกินที่กำหนดให้ทำการระงับการเข้าใช้งาน โดยการนำวันที่ จากตาราง tbl_login คอลัมน์ USRLOGIN - กับวันที่ ปัจจุบันโดยใช้คำสั่ง GETDATE ดึงวันที่ปัจจุบัน และใช้ คำสั่ง DATEDIFF หาความต่างของวัน เพื่อนำไปเปรียบเทียบกับข้อกำหนด ใน ตาราง tbl_setting ถ้าเกินกำหนดให้ระงับการใช้งานของ USERNAME ##

            sql = $"SELECT *,DATEDIFF(DAY,USRLOGIN,GETDATE())as Age  FROM tbl_login WHERE USERID = '{txt_idlog.Text}' AND USRPASSWORD = '{txt_passlog.Text}'"
            cmd.CommandText = sql
            DA.SelectCommand = cmd
            DA.Fill(DS, "TIME")

            sql = "SELECT * FROM tbl_setting"
            cmd.CommandText = sql
            DA.SelectCommand = cmd
            DA.Fill(DS, "checkday")

            Dim checkdiff As Integer = DS.Tables("TIME").Rows(0)("Age")
            Dim checkday As Integer = DS.Tables("checkday").Rows(0)("daylimit")

            '## ถ้าเงื่อนไขเป็นจริงให้ทำการอัพเดตค่า True ในตาราง tbl_login คอลัมน์ USRLOCK แล้วแจ้งเตือนผู้ใช้ว่าถูกระงับการใช้งาน ##

            If checkdiff >= checkday Then
                sql = $"UPDATE tbl_login SET USRLOCK = '1' WHERE USERID = '{txt_idlog.Text}' AND USRPASSWORD = '{txt_passlog.Text}'"
                cmd.CommandText = sql
                cmd.ExecuteScalar()
                Msg_error("ไม่ได้ล็อคอินนานเกินกำหนด กรุณาแจ้งผู้ดูแลระบบ")

            End If

            '## เช็ค USERID จากตาราง tbl_login ที่ทำการ กรอกข้อมูลเข้ามาใน TextBox ว่าสถานะ USRLOCK เป็น True หรือ False ถ้า เป็น True ให้แจ้งเตือนการระงับการใช้งานของ USER ถ้าเป็น False ให้ USER เข้าสู่หน้าหลักของโปรแกรม ##

            sql = $"Select * FROM tbl_login WHERE USERID = '{txt_idlog.Text}'and USRPASSWORD = '{txt_passlog.Text}'"
            cmd.CommandText = sql
            DA.SelectCommand = cmd
            DA.Fill(DS, "Lock")

            Dim check As Boolean = DS.Tables("LOCK").Rows(0)("USRLOCK")

            If check <> False Then

                Msg_error("ไม่สามารถเข้าสู่ระบบได้เนื่องจาก ขาดการใช้งานหรือจำนวนครั้ง ในการใส่รหัสผ่านผิดเกินกำหนด โปรดติดต่อผู้ดูแล!")

                cn.Close()
                Return

            End If

            '## อัพเดทเวลาล็อคอินล่าสุดเข้าฐานข้อมูล ในตาราง tbl_login คอลัมน์ USRLOGIN

            sql = ("UPDATE tbl_login SET USRLOGIN = GETDATE() WHERE USERID ='" & txt_idlog.Text & "' AND USRPASSWORD = '" & txt_passlog.Text & "' ")
            cmd_excuteScalar()

            Msg_OK("Login สำเร็จ!")
            Me.Hide()
            FrmMastermain.Show()

            '## นำเข้ามูลต่าง ๆ ที่จำเป็นไปแสดงในหน้า Main เช่น IPAddress,UserID ฯลฯ เพื่อนำไปใช้ในการเก็บ History Log ##

            sql = ("SELECT * FROM tbl_login WHERE USERID = '" & txt_idlog.Text & "'AND USRPASSWORD = '" & txt_passlog.Text & "' ")

            Dim dts As DataTable = cmd_excuteToDataTable()

            With FrmMastermain
                .tsl_ip.Text = aws.LocalIP                  '## แสดง IP
                .tsl_id.Text = dts.Rows(0)("USERID")        '## แสดง ID
                .tsl_username.Text = dts.Rows(0)("USRNAME")     '## แสดง FULLNAME ชื่อเต็ม
                .tsl_group.Text = dts.Rows(0)("USRGROUP")       '## แสดง กลุ่มงาน เช่น Admin Collletor
                .tsl_time.Text = Date.Now                           '## แสดงเวลาที่ใช้ล็อคอินปัจจุบัน
                .tsl_pcname.Text = pc
                .tsl_version.Text = lbl_version.Text                '## แสดงเวอร์ชั่นที่ใช้งานในปัจจุบัน

            End With

            cn.Close()

            '## Sub กำหนด สิทธิในการใช้งาน Form ต่าง เรียกใช้งานผ่าน Modules VBcode.vb

            Permissions(_userid, _pass)

        End If

    End Sub

    '## button สำหรับ ปิดโปรแกรม หรือ ยกเลิกการใช้งาน

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        If Msg_confirm("คุณต้องการออกจากโปรแกรมหรือไม่") = vbYes Then End

    End Sub

    '## PasswordChar  คือแสดงรหัสผ่านเป้นอะไร เช่นในที่นี้ใช้ "•" เพื่อปกปิดข้อมูล รหัสผ่านของ User
    '## ปุ่ม check ให้แสดงหรือซ่อน Password

    Private Sub chk_Password_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Password.CheckedChanged

        If chk_Password.Checked = True Then
            txt_passlog.PasswordChar = ""
        Else
            txt_passlog.PasswordChar = "•"
        End If

    End Sub

    '## เช็คว่ามีการจำ USERID เคยล็อคอินล่าสุดไหม ถ้า Checkbox ติ๊กถูกให้เก็บข้อมูลผู้ใช้

    Private Sub chk_rememuser_CheckedChanged(sender As Object, e As EventArgs) Handles chk_rememuser.CheckedChanged

        If chk_rememuser.Checked = True Then

            My.Settings.username = txt_idlog.Text
        Else

            My.Settings.username = ""

        End If

        My.Settings.Save()

    End Sub

    '## ฟังชั่นเช็คระบบ internet โดยใช้ toolbox winsock ##

    Private Sub internetcheck_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles internetcheck.DoWork

        If My.Computer.Network.IsAvailable Then

            internetstatus = True

        Else

            internetstatus = False

        End If
    End Sub

    '## เช็คระบบ INTERNET ถ้าไม่เชื่อมต่อให้เป็น Available หรือ ถ้าไม่เชื่อมต่อให้เป็น Not Available ##

    Private Sub internetcheck_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles internetcheck.RunWorkerCompleted

        If internetstatus = True Then

            'lblnetstatus.Text = "Connection Status : Available"
            Ptb_connection.Image = My.Resources.server_connect
        Else
            'lblnetstatus.Text = "Connection Status : Not Available"
            Ptb_connection.Image = My.Resources.server_error
        End If

        internetcheck.RunWorkerAsync()

    End Sub

    '## Event ปิดฟอร์ม ให้ทำการ ออกจากฐานข้อมูล ปิดการทำงานทั้งหมด ##

    Private Sub FrmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Dispose()
        cn.Close()
        Me.Dispose()
        End

    End Sub

End Class
