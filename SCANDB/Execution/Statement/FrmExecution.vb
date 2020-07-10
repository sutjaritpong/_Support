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

        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        _Datetimeformatshort(dtp_datesheet)
        _Datetimeformatshort(dtp_tracking_date)
        _Datetimeformatshort(dtp_verify_date)

        'Dim dt As DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat
        'Me.dtp_dateexework.CustomFormat = "dd MMM yyyy"
        'Me.dtp_dateexework.Format = DateTimePickerFormat.Custom
        'Me.dtp_datesheet.CustomFormat = "dd MMM yyyy"
        'Me.dtp_datesheet.Format = DateTimePickerFormat.Custom
        'Me.dtp_tracking.CustomFormat = "dd MMM yyyy"
        'Me.dtp_tracking.Format = DateTimePickerFormat.Custom

        sql = "SELECT EMPLOYEES_KEY,EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '02-EXECUTION'"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            cbo_employees_exe.Items.Add($"{DR("EXEEMPLOYEES")}")
        End While

        DR.Close()
        cbo_employees_exe.SelectedItem = 0

        Dim types() As String = {"ธนาคาร", "เลขประจำตัวประชาชน", "เลขที่สัญญา", "ชื่อ-นามสกุล", "ศาล", "คดีดำ", "คดีแดง", "เลขเก็บ", "กรม", "ศูนย์ประสานงาน", "ชื่อพนักงาน", "พนักงานบังคับคดี"}

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
    Public Sub clear_text()

        txt_black.Text = ""
        txt_detail1.Text = ""
        txt_employee.Text = ""
        cbo_employees_exe.Text = ""
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
        txt_count_acc.Text = ""
        txt_collec_nosend.Text = ""
        txt_tracking_detail.Text = ""
        txt_tracking_nosheet.Text = ""
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

            If addacc(0) <> "" Then
                cbo_acc.Items.Add(addacc(0))
            End If
            If addacc(1) <> "" Then
                cbo_acc.Items.Add(addacc(1))
            End If
            If addacc(2) <> "" Then
                cbo_acc.Items.Add(addacc(2))
            End If

            cbo_acc.SelectedIndex = 0

            txt_count_acc.Text = cbo_acc.Items.Count

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
            cbo_employees_exe.Text = dtgv_search.CurrentRow.Cells(21).Value.ToString
            dtp_tracking_date.Text = dtgv_search.CurrentRow.Cells(22).Value.ToString
            txt_tracking_nosheet.Text = dtgv_search.CurrentRow.Cells(23).Value.ToString
            txt_collec_nosend.Text = dtgv_search.CurrentRow.Cells(24).Value.ToString
            txt_tracking_detail.Text = dtgv_search.CurrentRow.Cells(25).Value.ToString
            dtp_verify_date.Text = dtgv_search.CurrentRow.Cells(26).Value.ToString
            txt_verify_result.Text = dtgv_search.CurrentRow.Cells(27).Value.ToString
            txt_verify_comment.Text = dtgv_search.CurrentRow.Cells(28).Value.ToString

            If (txt_total.Text <> "") AndAlso (Not IsNumeric(txt_total.Text)) Then


            Else

                txt_total.Text = CDbl(txt_total.Text).ToString("##,##0.00")

            End If

            If dtgv_search.CurrentRow.Cells(15).Value.ToString <> "" Then

                chk_datesheet.Checked = True
            Else

                chk_datesheet.Checked = False

            End If

            If dtgv_search.CurrentRow.Cells(22).Value.ToString <> "" Then

                chk_tracking_date.Checked = True

            Else

                chk_tracking_date.Checked = False

            End If

            If dtgv_search.CurrentRow.Cells(27).Value.ToString <> "" Then

                chk_verify_date.Checked = True

            Else

                chk_verify_date.Checked = False

            End If

        Catch ex As Exception

            Reader()

        End Try

    End Sub

    Private Sub cmd_find_Click(sender As Object, e As EventArgs) Handles cmd_find.Click
        If Application.OpenForms().OfType(Of FrmfindExecution).Any Then
            With FrmfindExecution
                .Focus()
            End With
        Else
            clear_text()

            FrmfindExecution.ShowDialog()
            FrmfindExecution.StartPosition = FormStartPosition.CenterScreen

        End If

    End Sub
    Friend Sub Reader()

        dtp_tracking_date.Enabled = False
        dtp_verify_date.Enabled = False
        dtp_datesheet.Enabled = False
        cbo_court.Enabled = False
        cbo_department.Enabled = False
        cbo_acc.Enabled = False
        cbo_employees_exe.Enabled = False

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
        txt_verify_result.ReadOnly = True
        txt_verify_comment.ReadOnly = True
        txt_tracking_detail.ReadOnly = True
        txt_tracking_nosheet.ReadOnly = True
        txt_collec_nosend.ReadOnly = True
        txt_count_acc.ReadOnly = True

        chk_datesheet.Enabled = False
        chk_tracking_date.Enabled = False
        chk_verify_date.Enabled = False

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
        cbo_employees_exe.Enabled = True
        txt_verify_result.ReadOnly = False
        txt_verify_comment.ReadOnly = False
        txt_tracking_detail.ReadOnly = False
        txt_tracking_nosheet.ReadOnly = False
        txt_collec_nosend.ReadOnly = False
        txt_count_acc.ReadOnly = False

        chk_datesheet.Enabled = True
        chk_tracking_date.Enabled = True
        chk_verify_date.Enabled = True

    End Sub
    Public Sub loaddatagridviews()

        connect()

        Dim header() As String = {"ธนาคาร", "เลขประจำตัวประชาชน", "ชื่อลูกค้า", "เลขที่สัญญา1", "เลขที่สัญญา2", "เลขที่สัญญา3", "ศาล", "คดีดำ", "คดีแดง", "เลขเก็บ", "กรมบังคับคดี", "จำนวนเงิน", "ชื่อพนักงานตามใบงาน", "เบอร์โทรศัพท์", "ศูนย์ประสานงาน", "วันที่ส่งใบงาน", "ชื่อสกุล-พนักงาน", "หมายเหตุ", "ผลปฎิบัติงาน", "HUB", "Result", "เจ้าหน้าที่บังคับคดี", "วันที่ใบคำร้อง", "ใบงานที่ทาง MIS ออก", "Collectorส่งมาออกใบงาน", "รายละเอียดตามคำร้อง", "วันที่บังคับคดีไปตรวจสำนวน", "สถานะ", "รายละเอียด"}
        Dim p As Integer = header.Length

        If txt_search.Text = "" Then
            Msg_error("กรุณากรอกข้อมูลในช่องค้นหา")
            Return
        End If

        Dim sqll As String = "SELECT ES.EXEBANK, ES.EXEID,ES.EXECUSTOMER,ES.EXEACC1,ES.EXEACC2,ES.EXEACC3,ES.EXECOURT,ES.EXEBLACK,ES.EXERED,ES.EXENUMBER,ES.EXEDEPARTMENT,ES.EXETOTAL,ES.EXEEMPLOYEE,ES.EXEPHONE,ES.EXEHUB,ES.EXEDATEWORK,ES.EXEFULLNAME,ES.EXEDETAIL,ES.EXEPERFORMANCE,ES.EXEHUBS,ES.EXERESULT,Emp.EXEEMPLOYEES,ET.Tracking_date_sheet,ET.Tracking_nosheet,ET.Tracking_Collector_nosend,ET.Tracking_detail,EV.Execution_verify_date,Ev.Execution_verify_result,Ev.Execution_verify_comment
    FROM EXESM As ES LEFT JOIN Execution_verify AS EV On EV.Customer_id_card = ES.EXEID LEFT JOIN EXEEMPLOYEE AS Emp ON EV.EMPLOYEES_KEY = Emp.EMPLOYEES_KEY LEFT JOIN EXETRACKING AS ET ON ES.EXEID = ET.Customer_idc WHERE "

        Select Case cbo_type.SelectedItem

            Case "ธนาคาร" : sqll &= "ES.EXEBANK "
            Case "เลขประจำตัวประชาชน" : sqll &= "ES.EXEID "
            Case "เลขที่สัญญา" : sqll &= $"ES.EXEACC1 LIKE'%{txt_search.Text}%' OR ES.EXEACC2 LIKE '%{txt_search.Text}%' OR ES.EXEACC3 "
            Case "ชื่อ-นามสกุล" : sqll &= "ES.EXECUSTOMER "
            Case "ศาล" : sqll &= "ES.EXECOURT "
            Case "คดีดำ" : sqll &= "ES.EXEBLACK "
            Case "คดีแดง" : sqll &= "ES.EXERED "
            Case "เลขเก็บ" : sqll &= "ES.EXENUMBER "
            Case "กรม" : sqll &= "ES.EXEDEPARTMENT "
            Case "ศูนย์ประสานงาน" : sqll &= "ES.EXEHUB "
            Case "ชื่อพนักงาน" : sqll &= "ES.EXEFULLNAME "
            Case "พนักงานบังคับคดี" : sqll &= "Emp.EXEEMPLOYEES "

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
                If x = 15 Then
                    Continue For
                End If
                dtgv_search.Columns(x).Visible = False

            Next
        Next
        _datagrid_format_dateshort(dtgv_search, 15)
        cn.Close()

    End Sub


    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click

        connect()
        Dim _datetime_sheet As DateTime = dtp_datesheet.Text
        Dim _datetime_verify As DateTime = dtp_verify_date.Text
        Dim _datetime_tracking As DateTime = dtp_tracking_date.Text
        Dim _pk As String = $"{txt_product.Text}-{txt_idcus.Text}-{_datetime_sheet}-{txt_hubs.Text}"
        Dim _verify_pk As String = $"{txt_product.Text}-{txt_idcus.Text}-{_datetime_verify}"
        Dim _tracking_pk As String = $"{txt_product.Text}-{txt_idcus.Text}-{_datetime_tracking}"

        If txt_idcus.Text = "" Or txt_namecus.Text = "" Or txt_nameem.Text = "" Then
            Msg_error("กรุณาตรวจสอบ ชื่อลูกค้า เลขประจำตัวประชาชน หรือชื่อผู้ส่งใบงาน")
            Return
        Else

            sql = $"SELECT EMPLOYEES_KEY FROM EXEEMPLOYEE WHERE EXEEMPLOYEES = @emp"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("emp", cbo_employees_exe.Text)
            DA.SelectCommand = cmd
            DS = New DataSet
            DA.Fill(DS, "_emp")

            sql = $"UPDATE EXESM SET EXEKEY= @exesm_key,EXEBANK= @owner,EXEID= @idcus,EXECUSTOMER= @namecus"

            If txt_count_acc.Text = 1 Then
                sql &= $",EXEACC1 = @acc1"
            ElseIf txt_count_acc.Text = 2 Then
                sql &= $",EXEACC1 = @acc1,EXEACC2 = @acc2"
            ElseIf txt_count_acc.Text = 3 Then
                sql &= $",EXEACC1 = @acc1,EXEACC2 = @acc2,EXEACC3 = @acc3"
            End If

            sql &= $",EXECOURT= @court,EXEBLACK= @black,EXERED= @red,EXENUMBER= @number,EXETOTAL= @total,EXEEMPLOYEE= @nameemp,EXEPHONE= @phone,EXEHUB= @hub,EXEDATEWORK= @dtsheet,EXEFULLNAME= @empfull,EXEDETAIL= @detail,EXEPERFORMANCE = @performance,EXERESULT= @result WHERE EXEKEY = @exesm_key;"

            sql &= $"UPDATE Execution_verify SET Execution_verify_pk = @vrpk,Customer_owner = @owner,Customer_id_card = @idcus,Customer_account = @acc1,Customer_fullname = @namecus,EMPLOYEES_KEY = @idemp,Execution_verify_date = @vrdate,Execution_verify_result = @vrresult,Execution_verify_comment = @vrcomment WHERE Execution_verify_pk = @vrpk;"

            sql &= $"UPDATE EXETRACKING SET Tracking_pk = @tkpk ,Customer_owner = @owner ,Customer_idc = @idcus ,Customer_fullname = @namecus,tracking_court = @court,tracking_red = @red,tracking_date_sheet = @tkdate,tracking_detail = @tkdetail,tracking_nosheet = @nosheet,Tracking_collector_nosend = @tksend,EMPLOYEES_KEY = @idemp WHERE Tracking_pk = @tkpk;"

            cmd = New SqlCommand(sql, cn)

            With cmd

                .Parameters.Clear()
                .Parameters.AddWithValue("exesm_key", _pk)
                .Parameters.AddWithValue("owner", txt_product.Text)
                .Parameters.AddWithValue("idcus", txt_idcus.Text)

                If txt_count_acc.Text = 1 Then
                    .Parameters.AddWithValue("acc1", cbo_acc.Items(0))
                ElseIf txt_count_acc.Text = 2 Then
                    .Parameters.AddWithValue("acc1", cbo_acc.Items(0))
                    .Parameters.AddWithValue("acc2", cbo_acc.Items(1))
                ElseIf txt_count_acc.Text = 3 Then
                    .Parameters.AddWithValue("acc1", cbo_acc.Items(0))
                    .Parameters.AddWithValue("acc2", cbo_acc.Items(1))
                    .Parameters.AddWithValue("acc3", cbo_acc.Items(2))
                End If

                .Parameters.AddWithValue("namecus", txt_namecus.Text)
                .Parameters.AddWithValue("court", cbo_court.Text)
                .Parameters.AddWithValue("black", txt_black.Text)
                .Parameters.AddWithValue("red", txt_red.Text)
                .Parameters.AddWithValue("number", txt_number.Text)
                .Parameters.AddWithValue("total", CInt(txt_total.Text))
                .Parameters.AddWithValue("nameemp", txt_nameem.Text)
                .Parameters.AddWithValue("phone", txt_phone.Text)
                .Parameters.AddWithValue("hub", txt_hub.Text)
                .Parameters.AddWithValue("dtsheet", dtp_datesheet.Text)
                .Parameters.AddWithValue("empfull", txt_employee.Text)
                .Parameters.AddWithValue("Detail", txt_detail1.Text)
                .Parameters.AddWithValue("performance", txt_performance.Text)
                .Parameters.AddWithValue("result", txt_result.Text)
                .Parameters.AddWithValue("vrpk", _verify_pk)
                .Parameters.AddWithValue("idemp", CInt(DS.Tables("_emp").Rows(0)("EMPLOYEES_KEY")))
                .Parameters.AddWithValue("vrdate", dtp_verify_date.Text)
                .Parameters.AddWithValue("vrresult", txt_verify_result.Text)
                .Parameters.AddWithValue("vrcomment", txt_verify_comment.Text)
                .Parameters.AddWithValue("tkpk", _tracking_pk)
                .Parameters.AddWithValue("tkdate", dtp_tracking_date.Text)
                .Parameters.AddWithValue("tkdetail", txt_tracking_detail.Text)
                .Parameters.AddWithValue("nosheet", txt_tracking_nosheet.Text)
                .Parameters.AddWithValue("tksend", txt_collec_nosend.Text)
                .Parameters.AddWithValue("empfullname", cbo_employees_exe.Text)
                .ExecuteNonQuery()

            End With

            If dtgv_search.Rows.Count <> 0 Then

                _Getlogdataexe($"เลขที่บัตรประชาชน {txt_idcus.Text} {vbNewLine} ชื่อลูกค้า {txt_namecus.Text} {vbNewLine} ชื่อพนักงาน {cbo_employees_exe.Text}", $"'{txt_idcus.Text}'", $"'{cbo_acc.Text}'")
                dtgv_search.DataSource.clear()
                    loaddatagridviews()
                    cell_refresh()

                Msg_OK("บันทึกข้อมูลสำเร็จ")

            Else
                    Msg_error("ไม่พบข้อมูลที่ต้องการอัพเดต")
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


    Private Sub FrmExecution_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


        cn.Close()
        Me.Dispose()

    End Sub

    Private Sub dtgv_search_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgv_search.CellMouseUp

        clear_text()

        If e.RowIndex = -1 Then Exit Sub

        With dtgv_search

            Dim dtgvrows_acc() As String = {CStr(dtgv_search.Rows.Item(e.RowIndex).Cells(3).Value.ToString), CStr(dtgv_search.Rows.Item(e.RowIndex).Cells(4).Value.ToString), CStr(dtgv_search.Rows.Item(e.RowIndex).Cells(5).Value.ToString)}

            txt_product.Text = CStr(.Rows.Item(e.RowIndex).Cells(0).Value.ToString)
            txt_idcus.Text = CStr(.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
            txt_namecus.Text = CStr(.Rows.Item(e.RowIndex).Cells(2).Value.ToString)

            cbo_acc.Items.Clear()

            If dtgvrows_acc(0) <> "" Then
                cbo_acc.Items.Add(dtgvrows_acc(0))
            End If

            If dtgvrows_acc(1) <> "" Then
                cbo_acc.Items.Add(dtgvrows_acc(1))
            End If

            If dtgvrows_acc(2) <> "" Then
                cbo_acc.Items.Add(dtgvrows_acc(2))
            End If

            cbo_acc.SelectedIndex = 0
            txt_count_acc.Text = cbo_acc.Items.Count

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

            cbo_employees_exe.Text = CStr(.Rows.Item(e.RowIndex).Cells(21).Value.ToString)

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

        If (txt_total.Text <> "") AndAlso (Not IsNumeric(txt_total.Text)) Then


        Else

            txt_total.Text = CDbl(txt_total.Text).ToString("##,##0.00")

        End If

        Reader()

    End Sub
End Class


