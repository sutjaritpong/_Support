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

        Dim types() As String = {"ธนาคาร", "เลขประจำตัวประชาชน", "ชื่อ-นามสกุล", "ศาล", "คดีดำ", "คดีแดง", "เลขเก็บ", "กรม", "ศูนย์ประสานงาน", "ชื่อพนักงาน", "พนักงานบังคับคดี"}

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

    Private Sub txt_total_KeyPress(sender As Object, e As KeyPressEventArgs)
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

        If chk_tracking_date.Checked = True Then

            dtp_tracking_date.Enabled = True

        Else

            dtp_tracking_date.Enabled = False

        End If

        If chk_verify_date.Checked = True Then

            dtp_verify_date.Enabled = True

        Else

            dtp_verify_date.Enabled = False

        End If

    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click

        cell_refresh()
        Refresh()

    End Sub
    Sub clear_text()

        txt_black.Text = ""
        txt_detail1.Text = ""

        txt_employee.Text = ""
        txt_EmployeeExE.Text = ""
        txt_hub.Text = ""
        txt_hubs.Text = ""
        txt_idcus.Text = ""
        txt_namecus.Text = ""
        txt_nameem.Text = ""
        txt_number.Text = ""
        txt_verify_result.Text = ""
        txt_performance.Text = ""
        txt_phone.Text = ""
        txt_product.Text = ""
        txt_red.Text = ""
        txt_result.Text = ""
        txt_verify_comment.Text = ""
        txt_total.Text = ""
        dtp_verify_date.Text = ""
        dtp_datesheet.Text = ""
        dtp_tracking_date.Text = ""
        cbo_acc.Text = ""
        cbo_court.Text = ""
        cbo_department.Text = ""
        chk_tracking_date.Checked = False
        chk_datesheet.Checked = False
        chk_verify_date.Checked = False

        If chk_verify_date.Checked = False Then

            dtp_verify_date.Enabled = False

        End If


        If chk_datesheet.Checked = False Then

            dtp_datesheet.Enabled = False

        End If


        If chk_tracking_date.Checked = False Then

            dtp_tracking_date.Enabled = False

        End If


    End Sub
    Sub cell_refresh()

        Reader()
        clear_text()

        Try
            Dim addacc() = {dtgv_search.CurrentRow.Cells(3).Value.ToString, dtgv_search.CurrentRow.Cells(4).Value.ToString, dtgv_search.CurrentRow.Cells(5).Value.ToString}
            txt_product.Text = dtgv_search.CurrentRow.Cells(0).Value.ToString
            txt_idcus.Text = dtgv_search.CurrentRow.Cells(1).Value.ToString
            txt_namecus.Text = dtgv_search.CurrentRow.Cells(2).Value.ToString
            cbo_acc.Items.Clear()
            cbo_acc.Items.AddRange(addacc)
            cbo_acc.SelectedIndex = 0
            cbo_court.Text = dtgv_search.CurrentRow.Cells(6).Value.ToString
            txt_black.Text = dtgv_search.CurrentRow.Cells(7).Value.ToString
            txt_red.Text = dtgv_search.CurrentRow.Cells(8).Value.ToString
            txt_number.Text = dtgv_search.CurrentRow.Cells(9).Value.ToString
            cbo_department.Text = dtgv_search.CurrentRow.Cells(10).Value.ToString
            txt_total.Text = CDbl(dtgv_search.CurrentRow.Cells(11).Value)
            txt_nameem.Text = dtgv_search.CurrentRow.Cells(12).Value.ToString
            txt_phone.Text = dtgv_search.CurrentRow.Cells(13).Value.ToString
            txt_hub.Text = dtgv_search.CurrentRow.Cells(14).Value.ToString
            dtp_datesheet.Text = dtgv_search.CurrentRow.Cells(15).Value.ToString
            txt_employee.Text = dtgv_search.CurrentRow.Cells(16).Value.ToString
            txt_detail1.Text = dtgv_search.CurrentRow.Cells(17).Value.ToString
            txt_performance.Text = dtgv_search.CurrentRow.Cells(18).Value.ToString
            txt_hubs.Text = dtgv_search.CurrentRow.Cells(19).Value.ToString
            txt_result.Text = dtgv_search.CurrentRow.Cells(20).Value.ToString
            txt_EmployeeExE.Text = dtgv_search.CurrentRow.Cells(21).Value.ToString
            dtp_tracking_date.Text = dtgv_search.CurrentRow.Cells(22).Value.ToString
            txt_tracking_nosheet.Text = dtgv_search.CurrentRow.Cells(23).Value.ToString
            txt_collec_nosend.Text = dtgv_search.CurrentRow.Cells(24).Value.ToString
            txt_tracking_detail.Text = dtgv_search.CurrentRow.Cells(25).Value.ToString
            dtp_verify_date.Text = dtgv_search.CurrentRow.Cells(26).Value.ToString
            txt_verify_result.Text = dtgv_search.CurrentRow.Cells(27).Value.ToString
            txt_verify_comment.Text = dtgv_search.CurrentRow.Cells(28).Value.ToString



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

        dtp_tracking_date.Enabled = False
        dtp_verify_date.Enabled = False
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
        txt_verify_result.ReadOnly = True
        txt_verify_comment.ReadOnly = True
        txt_tracking_detail.ReadOnly = True
        txt_tracking_nosheet.ReadOnly = True
        txt_collec_nosend.ReadOnly = True

        chk_datesheet.Enabled = False
        chk_tracking_date.Enabled = False
        chk_verify_date.Enabled = False

        txt_total.Text = CDbl(txt_total.Text).ToString("##,##0.00")
    End Sub
    Friend Sub Write()


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
        txt_verify_result.ReadOnly = False
        txt_verify_comment.ReadOnly = False
        txt_tracking_detail.ReadOnly = False
        txt_tracking_nosheet.ReadOnly = False
        txt_collec_nosend.ReadOnly = False

        chk_datesheet.Enabled = True
        chk_tracking_date.Enabled = True
        chk_verify_date.Enabled = True

    End Sub
    Public Sub loaddatagridviews()

        connect()

        Dim header() As String = {"ธนาคาร", "เลขประจำตัวประชาชน", "ชื่อลูกค้า", "เลขที่สัญญา1", "เลขที่สัญญา2", "เลขที่สัญญา3", "ศาล", "คดีดำ", "คดีแดง", "เลขเก็บ", "กรมบังคับคดี", "จำนวนเงิน", "ชื่อพนักงานตามใบงาน", "เบอร์โทรศัพท์", "ศูนย์ประสานงาน", "วันที่ส่งใบงาน", "ชื่อสกุล-พนักงาน", "หมายเหตุ", "ผลปฎิบัติงาน", "HUB", "Result", "เจ้าหน้าที่บังคับคดี", "วันที่ใบคำร้อง", "ใบงานที่ทาง MIS ออก", "Collectorส่งมาออกใบงาน", "รายละเอียดตามคำร้อง", "วันที่บังคับคดีไปตรวจสำนวน", "สถานะ", "รายละเอียด"}
        Dim p As Integer = header.Length

        Console.WriteLine(p)

        If txt_search.Text = "" Then
            Msg_error("กรุณากรอกข้อมูลในช่องค้นหา")
            Return
        End If

        Dim sqll As String = "SELECT ES.EXEBANK, ES.EXEID,ES.EXECUSTOMER,ES.EXEACC1,ES.EXEACC2,ES.EXEACC3,ES.EXECOURT,ES.EXEBLACK,ES.EXERED,ES.EXENUMBER,ES.EXEDEPARTMENT,ES.EXETOTAL,ES.EXEEMPLOYEE,ES.EXEPHONE,ES.EXEHUB,ES.EXEDATEWORK,ES.EXEFULLNAME,ES.EXEDETAIL,ES.EXEPERFORMANCE,ES.EXEHUBS,ES.EXERESULT,Emp.EXEEMPLOYEES,ET.Tracking_date_sheet,ET.Tracking_nosheet,ET.Tracking_Collector_nosend,ET.Tracking_detail,EV.Execution_verify_date,Ev.Execution_verify_result,Ev.Execution_verify_comment
    FROM EXESM As ES LEFT JOIN Execution_verify AS EV On EV.Customer_id_card = ES.EXEID LEFT JOIN EXEEMPLOYEE AS Emp ON EV.Execution_id_employees = EMPLOYEES_KEY LEFT JOIN EXETRACKING AS ET ON ES.EXEID = ET.Customer_idc WHERE "


        Select Case cbo_type.SelectedItem

            Case "ธนาคาร" : sqll &= "ES.EXEBANK "
            Case "เลขประจำตัวประชาชน" : sqll &= "EXESM.EXEID "
            Case "ชื่อ-นามสกุล" : sqll &= "EXESM.EXECUSTOMER "
            Case "ศาล" : sqll &= "ES.EXECOURT "
            Case "คดีดำ" : sqll &= "ES.EXEBLACK "
            Case "คดีแดง" : sqll &= "ES.EXERED "
            Case "เลขเก็บ" : sqll &= "ES.EXENUMBER "
            Case "กรม" : sqll &= "ES.EXEDEPARTMENT "
            Case "ศูนย์ประสานงาน" : sqll &= "ES.EXEHUB "
            Case "ชื่อพนักงาน" : sqll &= "ES.EXEFULLNAME "
            Case "พนักงานบังคับคดี" : sqll &= "Emp.EXEEMPPLOYEES "

        End Select

        sqll &= $"Like '%{txt_search.Text}%' ORDER BY ES.EXEDATEWORK "

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

            For x = 9 To 28 Step +1

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
            sql = $"UPDATE EXESM SET EXEKEY='{txt_idcus.Text}-{txt_product.Text}-{lbl_datetoday.Text}-{lbl_timer.Text}',EXEBANK='{txt_product.Text}',EXEID='{txt_idcus.Text}',EXECUSTOMER= '{txt_namecus.Text}',EXECOURT='{cbo_court.Text}',EXEBLACK='{txt_black.Text}',EXERED= '{txt_red.Text}',EXENUMBER='{txt_number.Text}',EXETOTAL='{txt_total.Text}',EXEEMPLOYEE= '{txt_nameem.Text}',EXEPHONE='{txt_phone.Text}',EXEHUB='{txt_hub.Text}',EXEDATEWORK= '{dtp_datesheet.Text}',EXEFULLNAME='{txt_employee.Text}',EXEDETAIL='{txt_detail1.Text}',EXEPERFORMANCE = '{txt_performance.Text}',EXERESULT='{ txt_result.Text}' WHERE EXEID='{txt_idcus.Text}' AND EXEFULLNAME = '{txt_employee.Text}';"



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

    Private Sub chk_tracking_CheckedChanged(sender As Object, e As EventArgs)

        If chk_tracking_date.Checked = True Then

            dtp_tracking_date.Enabled = True

        Else

            dtp_tracking_date.Enabled = False

        End If
    End Sub

    Private Sub chk_datework_CheckedChanged(sender As Object, e As EventArgs)

        If chk_datesheet.Checked = True Then

            dtp_datesheet.Enabled = True

        Else

            dtp_datesheet.Enabled = False

        End If
    End Sub

    Private Sub chk_dateexework_CheckedChanged(sender As Object, e As EventArgs)

        If chk_verify_date.Checked = True Then

            dtp_verify_date.Enabled = True

        Else

            dtp_verify_date.Enabled = False

        End If

    End Sub


    Private Sub dtgv_search_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgv_search.CellMouseUp

        clear_text()


        If e.RowIndex = -1 Then Exit Sub

        With dtgv_search

            Dim addacc() = {CStr(.Rows.Item(e.RowIndex).Cells(3).Value.ToString), CStr(.Rows.Item(e.RowIndex).Cells(4).Value.ToString), CStr(.Rows.Item(e.RowIndex).Cells(5).Value.ToString)}
            txt_product.Text = CStr(.Rows.Item(e.RowIndex).Cells(0).Value.ToString)
            txt_idcus.Text = CStr(.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
            txt_namecus.Text = CStr(.Rows.Item(e.RowIndex).Cells(2).Value.ToString)
            cbo_acc.Items.Clear()
            cbo_acc.Items.AddRange(addacc)
            cbo_acc.SelectedIndex = 0
            cbo_court.Text = CStr(.Rows.Item(e.RowIndex).Cells(6).Value.ToString)
            txt_black.Text = CStr(.Rows.Item(e.RowIndex).Cells(7).Value.ToString)
            txt_red.Text = CStr(.Rows.Item(e.RowIndex).Cells(8).Value.ToString)
            txt_number.Text = CStr(.Rows.Item(e.RowIndex).Cells(9).Value.ToString)
            cbo_department.Text = CStr(.Rows.Item(e.RowIndex).Cells(10).Value.ToString)
            txt_total.Text = CDbl(.Rows.Item(e.RowIndex).Cells(11).Value.ToString)
            txt_nameem.Text = CStr(.Rows.Item(e.RowIndex).Cells(12).Value.ToString)
            txt_phone.Text = CStr(.Rows.Item(e.RowIndex).Cells(13).Value.ToString)
            txt_hub.Text = CStr(.Rows.Item(e.RowIndex).Cells(14).Value.ToString)
            dtp_datesheet.Text = CStr(.Rows.Item(e.RowIndex).Cells(15).Value.ToString)
            txt_employee.Text = CStr(.Rows.Item(e.RowIndex).Cells(16).Value.ToString)
            txt_detail1.Text = CStr(.Rows.Item(e.RowIndex).Cells(17).Value.ToString)
            txt_performance.Text = CStr(.Rows.Item(e.RowIndex).Cells(18).Value.ToString)
            txt_hubs.Text = CStr(.Rows.Item(e.RowIndex).Cells(19).Value.ToString)
            txt_result.Text = CStr(.Rows.Item(e.RowIndex).Cells(20).Value.ToString)

            txt_EmployeeExE.Text = CStr(.Rows.Item(e.RowIndex).Cells(21).Value.ToString)

            dtp_tracking_date.Text = CStr(.Rows.Item(e.RowIndex).Cells(22).Value.ToString)
            txt_tracking_nosheet.Text = CStr(.Rows.Item(e.RowIndex).Cells(23).Value.ToString)
            txt_collec_nosend.Text = CStr(.Rows.Item(e.RowIndex).Cells(24).Value.ToString)
            txt_tracking_detail.Text = CStr(.Rows.Item(e.RowIndex).Cells(25).Value.ToString)


            dtp_verify_date.Text = CStr(.Rows.Item(e.RowIndex).Cells(26).Value.ToString)
            txt_verify_result.Text = CStr(.Rows.Item(e.RowIndex).Cells(27).Value.ToString)
            txt_verify_comment.Text = CStr(.Rows.Item(e.RowIndex).Cells(28).Value.ToString)



        End With

        If dtgv_search.Rows.Item(e.RowIndex).Cells(15).Value.ToString <> "" Then

            chk_datesheet.Checked = True
        Else

            chk_datesheet.Checked = False

        End If

        If dtgv_search.Rows.Item(e.RowIndex).Cells(22).Value.ToString <> "" Then

            chk_tracking_date.Checked = True

        Else

            chk_tracking_date.Checked = False

        End If

        If dtgv_search.Rows.Item(e.RowIndex).Cells(27).Value.ToString <> "" Then

            chk_verify_date.Checked = True

        Else

            chk_verify_date.Checked = False

        End If

        Reader()

    End Sub


End Class


