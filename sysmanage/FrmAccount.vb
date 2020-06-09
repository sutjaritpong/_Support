Option Explicit On
Imports System.Data.SqlClient
Public Class FrmAccount
    Dim time = DateAndTime.Now
    Dim lock As Boolean = 0
    Private Sub FrmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Loadtabledata()

        With cbo_group
            .Items.Add("Admin")                     '//เพิ่มข้อมูล ใน ComboBox ให้ผู้ใช้เลือกใช้งาน 
            .Items.Add("Collector")
            .Items.Add("Supervisor")

        End With

        dgvaccount.Columns(1).Visible = False

    End Sub
    Private Sub dgvaccount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvaccount.CellClick

        Try
            Userid.Text = dgvaccount.CurrentRow.Cells(0).Value
            Password.Text = dgvaccount.CurrentRow.Cells(1).Value        '//ถ้าคลิกที่ Cell ในดาต้ากริดให้ดึงข้อมูลมาแสดง
            Fullname.Text = dgvaccount.CurrentRow.Cells(2).Value
            cbo_group.Text = dgvaccount.CurrentRow.Cells(3).Value
        Catch

        End Try                 '// ครอบด้วย Try ป้องกัน Error แต่จะทำให้โปรแกรมทำงานได้ช้าลง

    End Sub

    Private Sub Loadtabledata()             '// การสร้าง Sub หรือ Function เพื่อลดปันหาการใช้คำสั่งซ้ำกันหลาย ๆ ที่

        connect()

        Dim header() As String = {"ชื่อผู้ใช้", "รหัสผ่าน", "ชื่อนามสกุล", "กลุ่ม", "เวลาเข้าใช้", "เวลาที่ลงทะเบียน", "จำนวนที่ใส่รหัสผิด", "สถานะ"}
        sql = ("SELECT * FROM tbl_login") '// ประกาศตัวแปรเป็น LOADDATA เพื่อนำมาใช้กับคำสั่ง SELECT เพื่อแสดงข้อมูล
        connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        With dgvaccount

            For i = 0 To header.Length - 1
                .DataSource = DS.Tables("table")        '// เนื่องจากข้อมูลเป็น อาเรย์(Array) จึงเริ่มนับ จาก 0 ไม่ใช่ นับจาก 1
                .Columns(i).HeaderText = header(i)
                For Each col As DataGridViewColumn In dgvaccount.Columns
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                Next
            Next

        End With

        cn.Close()

    End Sub

    Private Sub cmd_delete_Click(sender As Object, e As EventArgs) Handles cmd_delete.Click

        connect()

        Try

            If Msg_confirm("ต้องการลบบัญชีผู้ใช้นี้หรือไม่") = vbYes Then


                _Getlogdata($"ลบบัญชีผู้ใช้{dgvaccount.CurrentRow.Cells(0).Value}")

                connect()

                sql = ("DELETE FROM tbl_login WHERE USERID='" & dgvaccount.CurrentRow.Cells(0).Value & "'")
                cmd_excuteScalar()
                Loadtabledata()

            End If

        Catch ex As Exception

            MsgBox("ไม่มีข้อมูล", MsgBoxStyle.Critical)

        End Try

        cn.Close()

    End Sub
    Private Sub cmd_register_Click(sender As Object, e As EventArgs) Handles cmd_register.Click

        connect()

        If Userid.Text = "" Then                           '// ปุ่มสำหรับ Register เพื่อนำข้อมูลผู้สมัครเข้าไปเก็บในฐาน ข้อมูล
            MsgBox("กรุณากรอกชื่อผู้ใช้", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Password.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่าน", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Fullname.Text = "" Then
            MsgBox("กรุุณากรอกชื่อนามสกุล", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If cbo_group.Text = "" Then
            MsgBox("กรุณากรอกกลุ่ม", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Msg_confirm("คุณต้องการลงทะเบียนใช่หรือไม่") = vbNo Then Return

        sql = "SELECT COUNT(*) FROM tbl_login WHERE USERID = '" & Userid.Text & "'"

        If cmd_excuteScalar() > 0 Then
            Msg_error(" Username นี้มีอยู่แล้วในระบบ")                 '// เช็ค ก่อนนำข้อมูลผู้ใช้เข้าระบบ ว่า มีข้อมูลอยู่ในระบบแล้วหรือไม่ (เช็คซ้ำ)
            Userid.Select()
            Return

        End If

        sql = ("INSERT INTO tbl_login (USERID,USRPASSWORD,USRNAME,USRGROUP,USRLOGIN,USRREGIS,USRPASSFAIL,USRLOCK,USRPASCHANGE)VALUES('" & Userid.Text & "','" & Password.Text & "','" & Fullname.Text & "','" & cbo_group.Text & "','" & time & "','" & time & "','0','0',GETDATE())")

        If cmd_excuteNonquery() = 0 Then        '// เพิ่ม USERID ของผู้ใช้ในระบบ คนใหม่
            Msg_error("ลงทะเบียนล้มเหลว")
        Else
            Msg_OK("ลงทะเบียนสำเร็จ")
            Loadtabledata()

            _Getlogdata($"เพิ่มบัญชีผู้ใช้{Userid.Text}")

        End If

        cn.Close()

    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click

        connect()

        If Msg_confirm("คุณต้องการแก้ไขข้อมูลใช่หรือไม่") = vbYes Then

            sql = ("UPDATE tbl_login SET USRPASSWORD='" & Password.Text & "',USRNAME='" & Fullname.Text & "',USRGROUP='" & cbo_group.Text & "',USRLOGIN=GETDATE(),USRPASSFAIL='0',USRLOCK='" & dgvaccount.CurrentRow.Cells(7).Value & "',USRPASCHANGE=GETDATE() WHERE USERID='" & Userid.Text & "'")

            cmd_excuteScalar()
            MsgBox("แก้ไขข้อมูลสำเร็จ", MsgBoxStyle.Information)
            Loadtabledata()

            _Getlogdata($"แก้ไขข้อมูลบัญชีผู้ใช้{Userid.Text}")

            Userid.Clear()                      'แก้ไขข้อมูล โดยตรงที่ละ USER โดยใช้ Datagridview Even Cellclick ดึงข้อมูลมา
            Password.Clear()
            Fullname.Clear()
            cbo_group.Text = ""

            cn.Close()

        End If

    End Sub

    Private Sub cmd_unlockall_Click(sender As Object, e As EventArgs) Handles cmd_unlockall.Click

        connect()

        sql = ($"UPDATE tbl_login SET USRLOGIN = '{time}',USRPASSFAIL = '{0}',USRLOCK = '{0}'")

        cmd_excuteScalar()              '// ปลดล็อคทุก USER ที่ล็อคอยู่ให้ใช้งานได้ปกติ
        Loadtabledata()

        cn.Close()

    End Sub

    Private Sub FrmAccount_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub
End Class