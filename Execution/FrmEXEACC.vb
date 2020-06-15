Option Explicit On
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Public Class FrmEXEACC
    '## Array entity_ACC() นำไปใช้เพิ่ม Columns ใน Datagridview 
    Dim entity_ACC() As String = {"KEY", "ธนาคาร", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "เลขที่คดีดำ", "เลขที่คดีแดง", "Status", "วันที่ใบเสร็จ", "จำนวนเงินในใบเสร็จ", "ค่าใช้จ่ายอื่นๆ", "เดือนที่ลงข้อมูล"}

    Private Sub FrmEXEACC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()


        _cleardatagrid(dtgv_exeacc)

        cbo_owner.Items.Clear()
        cbo_search.Items.Clear()


        Dim header() As String = {"ธนาคาร", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "เลขที่คดีดำ", "เลขที่คดีแดง", "Status"}

        cbo_search.Items.AddRange(header)
        cbo_search.SelectedIndex = 0

        sql = "SELECT DISTINCT ACCBANK FROM EXEACC"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            cbo_owner.Items.Add($"{DR("ACCBANK")}")
        End While

        DR.Close()
        cbo_owner.SelectedIndex = -1

        _countdata()

        cn.Close()
        _readonly()

        dtgv_exeacc.Visible = False

    End Sub

    Private Sub _countdata()

        connect()
        sql = "SELECT COUNT(ACCKEY) AS count_exeacc FROM EXEACC"
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "table")
        lbl_count.Text = DS.Tables("table").Rows(0)("count_exeacc") & "" & "ราย"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim dt As DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat

        lbl_timer.Text = DateAndTime.TimeString             '//ตั้งเวลาโปรแกรม

        lbl_datetoday.Text = DateAndTime.Today.ToShortDateString        '//ตั้งเวลาวันที่ 

    End Sub

    Private Sub txt_totalbill_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total_receipt.KeyPress
        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub


    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        _datagrid()

    End Sub

    Sub _Cleartext()

        cbo_owner.Text = ""
        txt_black.Text = ""
        txt_cusid.Text = ""
        txt_cusname.Text = ""
        txt_detail_receipt.Text = ""
        txt_red.Text = ""
        txt_status.Text = ""
        txt_total_receipt.Text = ""
        txt_detail_receipt.Text = ""
        txt_total_receipt2.Text = ""
        txt_detail_receipt2.Text = ""
        txt_total_receipt3.Text = ""
        txt_total_receipt3.Text = ""
        dtp_datework.Text = ""
        dtp_date_receipt.Text = ""
        cbo_owner.Text = ""

        chk_date_work.Checked = False
        chk_date_receipt.Checked = False

        If chk_date_receipt.Checked = False Then
            dtp_date_receipt.Enabled = False
        End If
        If chk_date_work.Checked = False Then
            dtp_datework.Enabled = False
        End If
    End Sub
    Private Sub _readonly()

        cbo_owner.Enabled = False  'enable = false if readonly = true

        txt_cusid.ReadOnly = True
        txt_cusname.ReadOnly = True
        txt_black.ReadOnly = True
        txt_red.ReadOnly = True
        txt_status.ReadOnly = True

        txt_total_receipt.ReadOnly = True
        txt_total_receipt2.ReadOnly = True
        txt_total_receipt3.ReadOnly = True

        txt_detail_receipt.ReadOnly = True
        txt_detail_receipt2.ReadOnly = True
        txt_detail_receipt3.ReadOnly = True

        chk_date_receipt.Enabled = False
        chk_date_work.Enabled = False

        If chk_date_receipt.Enabled = False Then
            dtp_date_receipt.Enabled = False
        End If
        If chk_date_work.Enabled = False Then
            dtp_datework.Enabled = False
        End If

    End Sub
    Private Sub _write()

        cbo_owner.Enabled = True  '#enable = true if readonly = false
        dtp_date_receipt.Enabled = True
        dtp_datework.Enabled = True

        txt_cusid.ReadOnly = False
        txt_cusname.ReadOnly = False
        txt_black.ReadOnly = False
        txt_red.ReadOnly = False
        txt_status.ReadOnly = False
        txt_total_receipt.ReadOnly = False
        txt_total_receipt2.ReadOnly = False
        txt_total_receipt3.ReadOnly = False

        txt_detail_receipt.ReadOnly = False
        txt_detail_receipt2.ReadOnly = False
        txt_detail_receipt3.ReadOnly = False

        chk_date_work.Enabled = True
        chk_date_receipt.Enabled = True

    End Sub
    Private Sub _datagrid()

        connect()

        _cleardatagrid(dtgv_exeacc)
        _Cleartext()

        If txt_search.Text = "" Then
            Msg_error("กรุณากรอกข้อมุลที่ต้องการค้นหา")
            Return
        End If

        sql = $"SELECT * FROM EXEACC "

        Select Case cbo_search.SelectedItem

            Case "ธนาคาร" : sql &= $"WHERE ACCBANK"
            Case "เลขบัตรประชาชน" : sql &= $"WHERE ACCIDC"
            Case "ชื่อ-นามสกุล" : sql &= $"WHERE ACCCUSNAM"
            Case "เลขที่คดีดำ" : sql &= $"WHERE ACCBLACK"
            Case "เลขที่คดีแดง" : sql &= $"WHERE ACCRED"
            Case "Status" : sql &= $"WHERE ACCSTATUS"

        End Select

        sql &= $" LIKE '%{txt_search.Text}%' ORDER BY ACCMONTH"


        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "_search")

        If DS.Tables("_search").Rows.Count <= 0 Then

            lbl_count_find.Text = "ไม่พบข้อมูลที่ค้นหา.."
            lbl_count_find.ForeColor = Color.Red
            dtgv_exeacc.Visible = False
            Return

        Else

            With dtgv_exeacc
                .DataSource = DS.Tables("_search")

                For i = 0 To entity_ACC.Length - 1
                    .Columns(i).HeaderText = entity_ACC(i)
                    .Columns(0).Visible = False
                    .Columns(8).Visible = False
                    .Columns(9).Visible = False
                    .Columns(10).Visible = False
                    .Columns(11).Visible = False
                    .Columns(12).Visible = False
                    .Columns(13).Visible = False

                Next

            End With

            dtgv_exeacc.Visible = True
            lbl_count_find.Text = $"พบข้อมูล {dtgv_exeacc.RowCount.ToString} รายการ.."
            lbl_count_find.ForeColor = Color.Green

        End If

        cn.Close()

    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click
        _write()                '# แก้ไขข้อมูล !
    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click
        _readonly()                 '# ยกเลิกการแก้ไข !
    End Sub

    Private Sub dtgv_exeacc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_exeacc.CellClick

        _Cleartext()

        Try
            cbo_owner.Text = dtgv_exeacc.CurrentRow.Cells(1).Value.ToString
            txt_cusid.Text = dtgv_exeacc.CurrentRow.Cells(2).Value.ToString
            txt_cusname.Text = dtgv_exeacc.CurrentRow.Cells(3).Value.ToString
            txt_black.Text = dtgv_exeacc.CurrentRow.Cells(4).Value.ToString
            txt_red.Text = dtgv_exeacc.CurrentRow.Cells(5).Value.ToString
            txt_status.Text = dtgv_exeacc.CurrentRow.Cells(6).Value.ToString
            dtp_date_receipt.Text = dtgv_exeacc.CurrentRow.Cells(7).Value.ToString
            txt_total_receipt.Text = CInt(dtgv_exeacc.CurrentRow.Cells(8).Value)
            txt_detail_receipt.Text = dtgv_exeacc.CurrentRow.Cells(9).Value.ToString

            txt_total_receipt2.Text = CInt(dtgv_exeacc.CurrentRow.Cells(10).Value)
            txt_detail_receipt2.Text = dtgv_exeacc.CurrentRow.Cells(11).Value.ToString
            txt_total_receipt3.Text = CInt(dtgv_exeacc.CurrentRow.Cells(12).Value.ToString)
            txt_detail_receipt3.Text = dtgv_exeacc.CurrentRow.Cells(13).Value.ToString

            dtp_datework.Text = dtgv_exeacc.CurrentRow.Cells(14).Value.ToString

            CDbl(txt_total_receipt.Text).ToString("##,##0.00")
            CDbl(txt_total_receipt2.Text).ToString("##,##0.00")
            CDbl(txt_total_receipt3.Text).ToString("##,##0.00")

            If dtgv_exeacc.CurrentRow.Cells(7).Value.ToString = "" Then
                chk_date_receipt.Checked = False
            Else
                chk_date_receipt.Checked = True
            End If
            If dtgv_exeacc.CurrentRow.Cells(14).Value.ToString = "" Then

                chk_date_work.Checked = False
            Else
                chk_date_work.Checked = True
            End If

        Catch ex As Exception

        Finally
            _readonly()
        End Try


    End Sub

    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click

        connect()

        If txt_cusid.Text = "" Then         '# เช็คข้อมูลเลขที่บัตรประชาชน ว่าเป็นค่าว่างหรือไม่

            Msg_error("กรุณากรอกเลขบัตรประชาชนลูกค้า")
            Return

        End If

        If txt_cusname.Text = "" Then '## เช็คข้อมูลชื่อลูกค้า ใน Textbox ว่ามีการกรอกหรือไม่

            Msg_error("กรุณากรอกชื่อ-นามสกุลของลูกค้า")
            Return

        End If

        sql = $"SELECT COUNT(*) AS verify FROM EXEACC WHERE ACCKEY = '{cbo_owner.Text}-{txt_cusid.Text}-{dtp_date_receipt.Text}'"

        cmd = New SqlCommand(sql, cn)
        Dim i As Integer = cmd.ExecuteScalar()

        If i < 0 Then '# เช็คข้อมูลในฐานข้อมูลถ้ามีข้อมูลอยู่แล้ว ให้ Update ถ้ายังไม่มี ให้ Insert

            Msg_error("ไม่พบข้อมูลในระบบไม่สามารถแก้ไขข้อมูลได้")
            Return

        End If

        If Msg_confirm("ต้องการอัพเดตข้อมูล ใช่ หรือ ไม่", "แจ้งเตือน") = vbYes Then


            sql = $"UPDATE EXEACC SET ACCBLACK = @black,ACCRED = @red,ACCSTATUS = @status,ACCDATE = @date_work,ACCRECEIPT = @total,ACCRECEIPT_DETAIL = @detail,ACCRECEIPT_OTHER_2 = @total2,ACCRECEIPT_OTHER_DETAIL2 = @detail2,ACCRECEIPT_OTHER_3 = @total3,ACCRECEIPT_OTHER_DETAIL3 = @detail3,ACCMONTH = @date_send WHERE ACCBANK = @bank AND ACCIDC = @idc AND ACCCUSNAM = @cusname"

            cmd.CommandText = sql
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("bank", cbo_owner.Text)
            cmd.Parameters.AddWithValue("idc", txt_cusid.Text)
            cmd.Parameters.AddWithValue("cusname", txt_cusname.Text)
            cmd.Parameters.AddWithValue("black", txt_black.Text)
            cmd.Parameters.AddWithValue("red", txt_red.Text)
            cmd.Parameters.AddWithValue("status", txt_status.Text)
            cmd.Parameters.AddWithValue("total", txt_total_receipt.Text)
            cmd.Parameters.AddWithValue("detail", txt_detail_receipt.Text)
            cmd.Parameters.AddWithValue("date_work", dtp_date_receipt.Text)
            cmd.Parameters.AddWithValue("total2", txt_total_receipt2.Text)
            cmd.Parameters.AddWithValue("detail2", txt_detail_receipt2.Text)
            cmd.Parameters.AddWithValue("total3", txt_total_receipt3.Text)
            cmd.Parameters.AddWithValue("detail3", txt_detail_receipt3.Text)
            cmd.Parameters.AddWithValue("date_send", dtp_datework.Text)

            Dim r As Integer = cmd.ExecuteNonQuery()
            If r = -1 Then

                Msg_error("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")

            Else

                Msg_OK("แก้ไขข้อมูล สำเร็จ")
                _Getlogdata($"อัพเดทข้อมูลตั้งเรื่อง {cbo_owner.Text}-{txt_cusid.Text}-{txt_cusname.Text}")

            End If

            If dtgv_exeacc.Rows.Count <> 0 Then

                dtgv_exeacc.DataSource = Nothing

                _datagrid()
                _readonly()
                cn.Close()
            End If

        End If

    End Sub

    Private Sub cmd_send_Click(sender As Object, e As EventArgs) Handles cmd_send.Click
        Dim _date As DateTime = dtp_date_receipt.Text
        Dim acckey = $"{cbo_owner.Text}-{txt_cusid.Text}-{_date}"
        connect()

        If txt_cusid.Text = "" Then

                Msg_error("กรุณากรอกเลขบัตรประชาชนลูกค้า")
                Return

            End If

            If txt_cusname.Text = "" Then

                Msg_error("กรุณากรอกชื่อ-นามสกุลของลูกค้า")
                Return

            End If

        sql = $"SELECT COUNT(*) AS verify FROM EXEACC WHERE ACCKEY = '{acckey}'"

        cmd = New SqlCommand(sql, cn)
        Dim i As Integer = cmd.ExecuteScalar()
        If i > 0 Then '# เช็คข้อมูลในฐานข้อมูลถ้ามีข้อมูลอยู่แล้ว ให้ Update ถ้ายังไม่มี ให้ Insert

            Msg_error("มีข้อมูลนี้ในระบบแล้วกรุณาลองใหม่อีกครั้ง")
            Return

        End If

        If Msg_confirm("คุณต้องการเพิ่มข้อมูลใหม่หรือไม่", "แจ้งเตือน") = vbYes Then

            sql = "INSERT INTO EXEACC(ACCKEY,ACCBANK,ACCIDC,ACCCUSNAM,ACCBLACK,ACCRED,ACCSTATUS,ACCDATE,ACCRECEIPT,ACCRECEIPT_DETAIL,ACCRECEIPT_OTHER_2,ACCRECEIPT_OTHER_DETAIL2,ACCRECEIPT_OTHER_3,ACCRECEIPT_OTHER_DETAIL3,ACCMONTH)VALUES(@KEY,@bank,@idc,@cusname,@black,@red,@status,@date_work,@total,@detail,@total2,@detail2,@total3,@detail3,@date_send)"

            cmd.CommandText = sql
                cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("KEY", acckey)
                cmd.Parameters.AddWithValue("bank", cbo_owner.Text)
                cmd.Parameters.AddWithValue("idc", txt_cusid.Text)
                cmd.Parameters.AddWithValue("cusname", txt_cusname.Text)
                cmd.Parameters.AddWithValue("black", txt_black.Text)
                cmd.Parameters.AddWithValue("red", txt_red.Text)
                cmd.Parameters.AddWithValue("status", txt_status.Text)
                cmd.Parameters.AddWithValue("date_work", dtp_date_receipt.Text)
                cmd.Parameters.AddWithValue("total", txt_total_receipt.Text)
                cmd.Parameters.AddWithValue("detail", txt_detail_receipt.Text)
                cmd.Parameters.AddWithValue("total2", txt_total_receipt2.Text)
                cmd.Parameters.AddWithValue("detail2", txt_detail_receipt2.Text)
                cmd.Parameters.AddWithValue("total3", txt_total_receipt3.Text)
                cmd.Parameters.AddWithValue("detail3", txt_detail_receipt3.Text)
                cmd.Parameters.AddWithValue("date_send", dtp_datework.Text)

                Dim r As Integer = cmd.ExecuteNonQuery()
                If r = -1 Then

                    Msg_error("เกิดข้อผิดพลาดไม่สามารถเพิ่มข้อมูลได้")
                    cn.Close()
                Else

                    Msg_OK("บันทึกข้อมูลสำเร็จ")
                    _Getlogdata($"เพิ่มข้อมูลตั้งเรื่อง {cbo_owner.Text}-{txt_cusid.Text}-{txt_cusname.Text}")

                    _Cleartext()
                    _countdata()
                    _cleardatagrid(dtgv_exeacc)
                    cn.Close()
                End If

            End If

    End Sub
    '## Event Closing ใช้สำหรับกดปิดหรือสั่งปิดฟอร์มให้ ปิดการเชื่อมต่อของฐานข้อมูลด้วย
    Private Sub FrmEXEACC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub
    '## Method Checked ใน Event CheckedChanged ไว้สำหรับเช็คค่าในปัจจุบัน ของ Checkbox ว่าเป็น True หรือ False 
    Private Sub chk_date_work_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_work.CheckedChanged

        If chk_date_work.Checked = True Then

            dtp_datework.Enabled = True
        Else
            dtp_datework.Enabled = False

        End If

    End Sub
    '## Method Checked ใน Event CheckedChanged ไว้สำหรับเช็คค่าในปัจจุบัน ของ Checkbox ว่าเป็น True หรือ False 
    Private Sub chk_date_receipt_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_receipt.CheckedChanged

        If chk_date_receipt.Checked = True Then

            dtp_date_receipt.Enabled = True
        Else
            dtp_date_receipt.Enabled = False

        End If

    End Sub

    Private Sub cmd_delete_Click(sender As Object, e As EventArgs) Handles cmd_delete.Click

        _Cleartext()
        lbl_count_find.Text = "ผลการค้นหา..."
        lbl_count_find.ForeColor = Color.Blue
        dtgv_exeacc.DataSource = Nothing
        dtgv_exeacc.Visible = False
        txt_search.Text = ""

    End Sub

    Private Sub txt_total_receipt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total_receipt2.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub txt_total_receipt3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total_receipt3.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select


    End Sub
End Class