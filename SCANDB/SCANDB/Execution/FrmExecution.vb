Option Explicit On
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.ComponentModel
Imports Microsoft.Win32
Imports System.Globalization
Imports System.Threading
Public Class FrmExecution
    Private Sub FrmExecution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refresh()

        connect()

        'Dim dt As DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat
        'Me.dtp_dateexework.CustomFormat = "dd MMM yyyy"
        'Me.dtp_dateexework.Format = DateTimePickerFormat.Custom
        'Me.dtp_datesheet.CustomFormat = "dd MMM yyyy"
        'Me.dtp_datesheet.Format = DateTimePickerFormat.Custom
        'Me.dtp_tracking.CustomFormat = "dd MMM yyyy"
        'Me.dtp_tracking.Format = DateTimePickerFormat.Custom

        sql = "SELECT COUNT(*) AS COUNTS FROM EXESM "
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "countrow")

        lbl_count.Text = DS.Tables("countrow").Rows(0)("COUNTS") & "" & "ราย"

        Dim types() As String = {"ธนาคาร", "เลขประจำตัวประชาชน", "ชื่อ-นามสกุล", "ศาล", "คดีดำ", "คดีแดง", "เลขเก็บ", "กรม", "ศูนย์ประสานงาน", "ชื่อพนักงาน"}

        cbo_type.Items.AddRange(types)
        cbo_type.SelectedIndex = 0

        sql = "SELECT DISTINCT EXECOURT FROM EXESM"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            cbo_court.Items.Add($"{DR("EXECOURT")}")
        End While

        DR.Close()
        cbo_court.SelectedItem = 0


        sql = "SELECT DISTINCT EXEDEPARTMENT FROM EXESM"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            cbo_department.Items.Add($"{DR("EXEDEPARTMENT")}")
        End While

        DR.Close()
        cbo_department.SelectedItem = 0

        cn.Close()

    End Sub

    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        If dtgv_search.Rows.Count <> 0 Then

            dtgv_search.DataSource.clear()
            loaddatagridviews()
            Return
        Else

            loaddatagridviews()
            Return
        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dt As DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat

        lbl_timer.Text = DateAndTime.TimeString             '//ตั้งเวลาโปรแกรม

        lbl_datetoday.Text = DateAndTime.Today.ToShortDateString        '//ตั้งเวลาวันที่ 

    End Sub

    Private Sub txt_total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 '// key code ของตัวเลขจะอยู่ระหว่าง 48 ถึง 57 ซึ่ง 48 คือเลข 0 57 คือเลข 9 ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 '// ปุ่ม backspace = 8,ปุ่ม enter = 13,ปุ่ม delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกตัวเลข")
        End Select
    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click

        Write()
        If chk_datesheet.Checked = True Then

            dtp_datesheet.Enabled = True

        Else

            dtp_datesheet.Enabled = False

        End If

        If chk_tracking.Checked = True Then

            dtp_tracking.Enabled = True

        Else

            dtp_tracking.Enabled = False

        End If

        If chk_dateexework.Checked = True Then

            dtp_dateexework.Enabled = True

        Else

            dtp_dateexework.Enabled = False

        End If

    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click

        cell_refresh()
        Refresh()

    End Sub
    Sub clear_text()

        txt_black.Text = ""
        txt_detail1.Text = ""
        txt_detail2.Text = ""
        txt_detail3.Text = ""
        txt_employee.Text = ""
        txt_EmployeeExE.Text = ""
        txt_hub.Text = ""
        txt_hubs.Text = ""
        txt_idcus.Text = ""
        txt_namecus.Text = ""
        txt_nameem.Text = ""
        txt_number.Text = ""
        txt_perfor.Text = ""
        txt_performance.Text = ""
        txt_phone.Text = ""
        txt_product.Text = ""
        txt_red.Text = ""
        txt_result.Text = ""
        txt_verifyResult.Text = ""
        txt_total.Text = ""
        dtp_dateexework.Text = ""
        dtp_datesheet.Text = ""
        dtp_tracking.Text = ""
        cbo_acc.Text = ""
        cbo_court.Text = ""
        cbo_department.Text = ""
        chk_tracking.Checked = False
        chk_datesheet.Checked = False
        chk_dateexework.Checked = False

        If chk_dateexework.Checked = False Then

            dtp_dateexework.Enabled = False

        End If


        If chk_datesheet.Checked = False Then

            dtp_datesheet.Enabled = False

        End If


        If chk_tracking.Checked = False Then

            dtp_tracking.Enabled = False

        End If


    End Sub
    Sub cell_refresh()

        Reader()
        clear_text()

        Try
            Dim addacc() = {dtgv_search.CurrentRow.Cells(4).Value.ToString, dtgv_search.CurrentRow.Cells(5).Value.ToString, dtgv_search.CurrentRow.Cells(6).Value.ToString}
            txt_product.Text = dtgv_search.CurrentRow.Cells(1).Value.ToString
            txt_idcus.Text = dtgv_search.CurrentRow.Cells(2).Value.ToString
            txt_namecus.Text = dtgv_search.CurrentRow.Cells(3).Value.ToString
            cbo_acc.Items.Clear()
            cbo_acc.Items.AddRange(addacc)
            cbo_acc.SelectedIndex = 0
            cbo_court.Text = dtgv_search.CurrentRow.Cells(7).Value.ToString
            txt_black.Text = dtgv_search.CurrentRow.Cells(8).Value.ToString
            txt_red.Text = dtgv_search.CurrentRow.Cells(9).Value.ToString
            txt_number.Text = dtgv_search.CurrentRow.Cells(10).Value.ToString
            cbo_department.Text = dtgv_search.CurrentRow.Cells(11).Value.ToString
            txt_total.Text = CDbl(dtgv_search.CurrentRow.Cells(12).Value)
            txt_nameem.Text = dtgv_search.CurrentRow.Cells(13).Value.ToString
            txt_phone.Text = dtgv_search.CurrentRow.Cells(14).Value.ToString
            txt_hub.Text = dtgv_search.CurrentRow.Cells(15).Value.ToString
            dtp_datesheet.Text = dtgv_search.CurrentRow.Cells(16).Value.ToString
            txt_employee.Text = dtgv_search.CurrentRow.Cells(17).Value.ToString
            txt_detail1.Text = dtgv_search.CurrentRow.Cells(18).Value.ToString
            txt_performance.Text = dtgv_search.CurrentRow.Cells(19).Value.ToString
            txt_hubs.Text = dtgv_search.CurrentRow.Cells(21).Value.ToString
            txt_result.Text = dtgv_search.CurrentRow.Cells(22).Value.ToString
            dtp_tracking.Text = dtgv_search.CurrentRow.Cells(23).Value.ToString
            txt_perfor.Text = dtgv_search.CurrentRow.Cells(24).Value.ToString
            dtp_dateexework.Text = dtgv_search.CurrentRow.Cells(25).Value.ToString
            txt_detail2.Text = dtgv_search.CurrentRow.Cells(26).Value.ToString
            txt_detail3.Text = dtgv_search.CurrentRow.Cells(27).Value.ToString
            txt_EmployeeExE.Text = dtgv_search.CurrentRow.Cells(28).Value.ToString
            txt_verifyResult.Text = dtgv_search.CurrentRow.Cells(29).Value.ToString
            'txt_total.Text = CDbl(txt_total.Text).ToString("##,##0.00")

        Catch ex As Exception
            Reader()
            MsgBox(ex)
        End Try
    End Sub

    Private Sub cmd_find_Click(sender As Object, e As EventArgs) Handles cmd_find.Click

        clear_text()
        Frmfind.Show()

    End Sub
    Friend Sub Reader()

        dtp_datesheet.Enabled = False
        cbo_court.Enabled = False
        cbo_department.Enabled = False
        cbo_acc.Enabled = False
        txt_product.ReadOnly = True
        txt_idcus.ReadOnly = True
        txt_namecus.ReadOnly = True
        txt_black.ReadOnly = True
        txt_red.ReadOnly = True
        txt_number.ReadOnly = True
        txt_total.ReadOnly = True
        txt_nameem.ReadOnly = True
        txt_phone.ReadOnly = True
        txt_hub.ReadOnly = True
        txt_employee.ReadOnly = True
        txt_detail1.ReadOnly = True
        txt_hubs.ReadOnly = True
        txt_performance.ReadOnly = True
        txt_result.ReadOnly = True
        txt_EmployeeExE.ReadOnly = True
        dtp_tracking.Enabled = False
        txt_perfor.ReadOnly = True
        txt_verifyResult.ReadOnly = True
        dtp_dateexework.Enabled = False
        txt_detail2.ReadOnly = True
        txt_detail3.ReadOnly = True
        chk_datesheet.Enabled = False
        chk_tracking.Enabled = False
        chk_dateexework.Enabled = False

    End Sub
    Friend Sub Write()

        dtp_tracking.Enabled = True
        dtp_datesheet.Enabled = True
        cbo_court.Enabled = True
        cbo_department.Enabled = True
        cbo_acc.Enabled = True
        txt_product.ReadOnly = False
        txt_idcus.ReadOnly = False
        txt_namecus.ReadOnly = False
        txt_black.ReadOnly = False
        txt_red.ReadOnly = False
        txt_number.ReadOnly = False
        txt_total.ReadOnly = False
        txt_nameem.ReadOnly = False
        txt_phone.ReadOnly = False
        txt_hub.ReadOnly = False
        txt_employee.ReadOnly = False
        txt_detail1.ReadOnly = False
        txt_performance.ReadOnly = False
        txt_result.ReadOnly = False
        txt_hubs.ReadOnly = False
        txt_EmployeeExE.ReadOnly = False
        txt_perfor.ReadOnly = False
        txt_verifyResult.ReadOnly = False
        txt_detail2.ReadOnly = False
        txt_detail3.ReadOnly = False
        chk_datesheet.Enabled = True
        chk_tracking.Enabled = True
        chk_dateexework.Enabled = True

    End Sub
    Public Sub loaddatagridviews()

        connect()

        Dim header() As String = {"Logfile", "ธนาคาร", "เลขประจำตัวประชาชน", "ชื่อลูกค้า", "เลขที่สัญญา1", "เลขที่สัญญา2", "เลขที่สัญญา3", "ศาล", "คดีดำ", "คดีแดง", "เลขเก็บ", "กรมบังคับคดี", "จำนวนเงิน", "ชื่อพนักงานตามใบงาน", "เบอร์โทรศัพท์", "ศูนย์ประสานงาน", "วันที่ส่งใบงาน", "ชื่อสกุลพนักงาน", "หมายเหตุ", "ผลปฎิบัติงาน", "เดือนที่ออกใบงาน", "HUB", "Result", "วันที่ทำบัญชีรับจ่าย", "เจ้าหน้าที่บังคับคดี"}
        If txt_search.Text = "" Then
            Msg_error("กรุณากรอกข้อมูลในช่องค้นหา")
            Return
        End If

        Dim sqll As String = "SELECT EXESM.*,ET.EXEDATE,EV.EXEPERFOR,EV.EXERESDT,EV.EXEDET1,EV.EXEDET2,EV.EXEEMP,EV.EXERESULT FROM EXESM LEFT JOIN EXETRACKING AS ET ON EXESM.EXEID= ET.EXEIDC LEFT JOIN EXEVERIFY AS EV ON EXESM.EXEID = EV.EXEIDC WHERE "

        Select Case cbo_type.SelectedItem
            Case "ธนาคาร" : sqll &= "EXESM.EXEBANK "
            Case "เลขประจำตัวประชาชน" : sqll &= "EXESM.EXEID "
            Case "ชื่อ-นามสกุล" : sqll &= "EXESM.EXECUSTOMER "
            Case "ศาล" : sqll &= "EXESM.EXECOURT "
            Case "คดีดำ" : sqll &= "EXESM.EXEBLACK "
            Case "คดีแดง" : sqll &= "EXESM.EXERED "
            Case "เลขเก็บ" : sqll &= "EXESM.EXENUMBER "
            Case "กรม" : sqll &= "EXESM.EXEDEPARTMENT "
            Case "ศูนย์ประสานงาน" : sqll &= "EXESM.EXEHUB "
            Case "ชื่อพนักงาน" : sqll &= "EXESM.EXEFULLNAME "

        End Select

        sqll &= $"Like '%{txt_search.Text}%' ORDER BY EXEDATEWORK "
        cmd.CommandText = sqll
        DA.SelectCommand = cmd
        DA.Fill(DS, "find")

        If DS.Tables("find").Rows.Count <= 0 Then

            Msg_error("ไม่พบข้อมูลที่ค้นหา")
            Return

        End If

        For i = 0 To header.Length - 1

            dtgv_search.DataSource = DS.Tables("find")
            dtgv_search.Columns(i).HeaderText = header(i)
            dtgv_search.Columns(0).Visible = False

            For x = 23 To 29 Step +1

                dtgv_search.Columns(x).Visible = False

            Next
        Next

        cn.Close()

    End Sub


    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click

        connect()

        If txt_idcus.Text = "" Or txt_namecus.Text = "" Or txt_nameem.Text = "" Then
            Msg_error("กรุณาตรวจสอบ ชื่อลูกค้า เลขประจำตัวประชาชน หรือชื่อผู้ส่งใบงาน")
            Return
        Else
            sql = $"UPDATE EXESM SET EXEKEY='{txt_idcus.Text}-{txt_product.Text}-{lbl_datetoday.Text}-{lbl_timer.Text}',EXEBANK='{txt_product.Text}',EXEID='{txt_idcus.Text}',EXECUSTOMER= '{txt_namecus.Text}',EXECOURT='{cbo_court.Text}',EXEBLACK='{txt_black.Text}',EXERED= '{txt_red.Text}',EXENUMBER='{txt_number.Text}',EXETOTAL='{txt_total.Text}',EXEEMPLOYEE= '{txt_nameem.Text}',EXEPHONE='{txt_phone.Text}',EXEHUB='{txt_hub.Text}',EXEDATEWORK= '{dtp_datesheet.Text}',EXEFULLNAME='{txt_employee.Text}',EXEDETAIL='{txt_detail1.Text}',EXEPERFORMANCE = '{txt_performance.Text}',EXERESULT='{ txt_result.Text}' WHERE EXEID='{txt_idcus.Text}' AND EXEFULLNAME = '{txt_employee.Text}';
            UPDATE EXETRACKING SET EXEDATE = '{dtp_tracking.Text}' WHERE EXEIDC = '{txt_idcus.Text}';
            UPDATE EXEVERIFY SET EXEPERFOR = '{txt_perfor.Text}',EXEDET1 = '{txt_detail2.Text}',EXEDET2 = '{txt_detail3.Text}',EXEEMP = '{txt_EmployeeExE.Text}',EXERESULT = '{txt_verifyResult.Text}',EXERESDT = '{dtp_dateexework.Text}' WHERE EXEIDC = '{txt_idcus.Text}' ;"

            cmd_excuteScalar()

            If dtgv_search.Rows.Count <> 0 Then

                dtgv_search.DataSource.clear()
                loaddatagridviews()
                cell_refresh()

                Msg_OK("บันทึกข้อมูลสำเร็จ")


            End If

        End If

        cn.Close()

    End Sub

    Private Sub chk_tracking_CheckedChanged(sender As Object, e As EventArgs) Handles chk_tracking.CheckedChanged

        If chk_tracking.Checked = True Then

            dtp_tracking.Enabled = True

        Else

            dtp_tracking.Enabled = False

        End If
    End Sub

    Private Sub chk_datework_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datesheet.CheckedChanged

        If chk_datesheet.Checked = True Then

            dtp_datesheet.Enabled = True

        Else

            dtp_datesheet.Enabled = False

        End If
    End Sub

    Private Sub chk_dateexework_CheckedChanged(sender As Object, e As EventArgs) Handles chk_dateexework.CheckedChanged

        If chk_dateexework.Checked = True Then

            dtp_dateexework.Enabled = True

        Else

            dtp_dateexework.Enabled = False

        End If

    End Sub


    Private Sub dtgv_search_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgv_search.CellMouseUp

        clear_text()


        If e.RowIndex = -1 Then Exit Sub

        With dtgv_search

            Dim addacc() = {CStr(.Rows.Item(e.RowIndex).Cells(4).Value.ToString), CStr(.Rows.Item(e.RowIndex).Cells(5).Value.ToString), CStr(.Rows.Item(e.RowIndex).Cells(6).Value.ToString)}
            txt_product.Text = CStr(.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
            txt_idcus.Text = CStr(.Rows.Item(e.RowIndex).Cells(2).Value.ToString)
            txt_namecus.Text = CStr(.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
            cbo_acc.Items.Clear()
            cbo_acc.Items.AddRange(addacc)
            cbo_acc.SelectedIndex = 0
            cbo_court.Text = CStr(.Rows.Item(e.RowIndex).Cells(7).Value.ToString)
            txt_black.Text = CStr(.Rows.Item(e.RowIndex).Cells(8).Value.ToString)
            txt_red.Text = CStr(.Rows.Item(e.RowIndex).Cells(9).Value.ToString)
            txt_number.Text = CStr(.Rows.Item(e.RowIndex).Cells(10).Value.ToString)
            cbo_department.Text = CStr(.Rows.Item(e.RowIndex).Cells(11).Value.ToString)
            txt_total.Text = CDbl(.Rows.Item(e.RowIndex).Cells(12).Value.ToString)
            txt_nameem.Text = CStr(.Rows.Item(e.RowIndex).Cells(13).Value.ToString)
            txt_phone.Text = CStr(.Rows.Item(e.RowIndex).Cells(14).Value.ToString)
            txt_hub.Text = CStr(.Rows.Item(e.RowIndex).Cells(15).Value.ToString)
            dtp_datesheet.Text = CStr(.Rows.Item(e.RowIndex).Cells(16).Value.ToString)
            txt_employee.Text = CStr(.Rows.Item(e.RowIndex).Cells(17).Value.ToString)
            txt_detail1.Text = CStr(.Rows.Item(e.RowIndex).Cells(18).Value.ToString)
            txt_performance.Text = CStr(.Rows.Item(e.RowIndex).Cells(19).Value.ToString)
            txt_hubs.Text = CStr(.Rows.Item(e.RowIndex).Cells(21).Value.ToString)
            txt_result.Text = CStr(.Rows.Item(e.RowIndex).Cells(22).Value.ToString)
            dtp_tracking.Text = CStr(.Rows.Item(e.RowIndex).Cells(23).Value.ToString)
            txt_perfor.Text = CStr(.Rows.Item(e.RowIndex).Cells(24).Value.ToString)
            dtp_dateexework.Text = CStr(.Rows.Item(e.RowIndex).Cells(25).Value.ToString)
            txt_detail2.Text = CStr(.Rows.Item(e.RowIndex).Cells(26).Value.ToString)
            txt_detail3.Text = CStr(.Rows.Item(e.RowIndex).Cells(27).Value.ToString)
            txt_EmployeeExE.Text = CStr(.Rows.Item(e.RowIndex).Cells(28).Value.ToString)
            txt_verifyResult.Text = CStr(.Rows.Item(e.RowIndex).Cells(29).Value.ToString)

        End With

        If dtgv_search.Rows.Item(e.RowIndex).Cells(16).Value.ToString <> "" Then

            chk_datesheet.Checked = True
            'Else

            '    chk_datesheet.Checked = True

        End If

        If dtgv_search.Rows.Item(e.RowIndex).Cells(23).Value.ToString <> "" Then

            chk_tracking.Checked = True

            'Else

            'chk_tracking.Checked = True

        End If

        If dtgv_search.Rows.Item(e.RowIndex).Cells(25).Value.ToString <> "" Then

            chk_dateexework.Checked = True

            'Else

            'chk_tracking.Checked = True

        End If

        Reader()

    End Sub


End Class


