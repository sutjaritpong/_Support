Imports System.Data.SqlClient
Public Class FrmSetting
    Private Sub FrmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SELECTdayPass()
    End Sub
    Private Sub cmd_editsetting_Click(sender As Object, e As EventArgs) Handles cmd_editsetting.Click
        If txt_passlimit.Text = "" OrElse txt_daylimit.Text = "" Then
            Msg_error("กรุณาเพิ่มข้อมูลในช่องว่าง")
            Return
        End If
        If txt_changepass.Text = "" Then
            Msg_error("กรุณาเพิ่มข้อมูลในช่องว่าง")
        End If
        If txt_passlimit.Text > 10 Or txt_daylimit.Text > 10 Then
            Msg_error("คุณกรอกจำนวนวันที่เกินกำหนด หรือ จำนวนครั้งในการใส่รหัสผ่านผิดมากเกินไป")
            Return
        End If

        If Msg_confirm("คุณต้องการอัพเดทข้อมูลใช่หรือไม่") = vbYes Then
            sql = $"UPDATE tbl_setting SET faillimit = '{txt_passlimit.Text}',daylimit = '{txt_daylimit.Text}',changelimit = '{txt_changepass.Text}',daysettinglast = GETDATE()"
            cmd = New SqlCommand(sql, cn)
            Dim cq As Integer = cmd.ExecuteNonQuery()
            If cq < 0 Then
                Msg_error("แก้ไขข้อมูลล้มเหลว")
            Else
                Msg_OK("แก้ไขข้อมูลสำเร็จ")
                SELECTdayPass()
            End If
        End If
        SELECTdayPass()
    End Sub

    Sub SELECTdayPass()
        sql = "SELECT * FROM tbl_setting"
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "table")
        txt_passlimit.Text = DS.Tables("table").Rows(0)("faillimit")
        txt_daylimit.Text = DS.Tables("table").Rows(0)("daylimit")
        txt_changepass.Text = DS.Tables("table").Rows(0)("changelimit")
    End Sub

    Private Sub txt_daylimit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_daylimit.KeyPress
        If (e.KeyChar < Chr(49) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(13) Then
            e.Handled = True
            Msg_error("กรุณากรอกตัวเลข 1-9")
        End If
        'Select Case Asc(e.KeyChar)
        'Case 48 To 57 '// key code ของตัวเลขจะอยู่ระหว่าง 48 ถึง 57 ซึ่ง 48 คือเลข 0 57 คือเลข 9 ตามลำดับ
        ' e.Handled = False
        'Case 8, 13, 46 '// ปุ่ม backspace = 8,ปุ่ม enter = 13,ปุ่ม delete = 46
        ' e.Handled = False
        'Case Else
        'e.Handled = True
        'Msg_error("กรุณากรอกตัวเลข")
        'End Select
    End Sub

    Private Sub txt_passlimit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_passlimit.KeyPress
        If (e.KeyChar < Chr(49) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(13) Then
            e.Handled = True
            Msg_error("กรุณากรอกตัวเลข 1-9")
        End If
    End Sub
    Private Sub txt_changpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_changepass.KeyPress
        If (e.KeyChar < Chr(49) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(13) Then
            e.Handled = True
            Msg_error("กรุณากรอกตัวเลข 1-9")
        End If
    End Sub

    Private Sub FrmSetting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class