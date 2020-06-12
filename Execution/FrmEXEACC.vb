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
        cbo_owner.SelectedIndex = 0

        _countdata()

        cn.Close()
        _read()
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

        Dim _text() As Object = {cbo_owner.Text, txt_black.Text, txt_cusid.Text, txt_cusname.Text, txt_detail_receipt.Text, txt_red.Text, txt_search.Text, txt_status.Text, txt_total_receipt.Text}

        Dim _bound As Integer = UBound(_text)

        For i = 0 To _bound

            _text(i) = ""

        Next

    End Sub
    Private Sub _read()

        cbo_owner.Enabled = False  'enable = false if readonly = true
        dtp_date_receipt.Enabled = False
        dtp_datework.Enabled = False

        txt_cusid.ReadOnly = True
        txt_cusname.ReadOnly = True
        txt_black.ReadOnly = True
        txt_red.ReadOnly = True
        txt_status.ReadOnly = True
        txt_total_receipt.ReadOnly = True
        txt_detail_receipt.ReadOnly = True

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

            Msg_error("ไม่พบข้อมูลที่ค้นหา")
            Return

        End If

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

        cn.Close()

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
        txt_detail_receipt.ReadOnly = False

    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click
        _write()                '# แก้ไขข้อมูล !
    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click
        _read()                 '# ยกเลิกการแก้ไข !
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

        Catch ex As Exception


        End Try

    End Sub

    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click

        connect()

        If txt_cusid.Text = "" Then         '# เช็คข้อมูลเลขที่บัตรประชาชน ว่าเป็นค่าว่างหรือไม่

            Msg_error("กรุณากรอกเลขบัตรประชาชนลูกค้า")

            Return

        End If

        If txt_cusname.Text = "" Then

            Msg_error("กรุณากรอกชื่อ-นามสกุลของลูกค้า")

            Return

        End If

        sql = $"SELECT COUNT(*) AS verify FROM EXEACC WHERE ACCKEY = '{cbo_owner.Text}-{txt_cusid.Text}-{dtp_date_receipt.Text}'"

        If cmd_excuteScalar() > 0 Then '# เช็คข้อมูลในฐานข้อมูลถ้ามีข้อมูลอยู่แล้ว ให้ Update ถ้ายังไม่มี ให้ Insert

            If Msg_confirm("คุณต้องอัพเดทข้อมูล ใช่ หรือ ไม่", "แจ้งเตือน") = vbYes Then


                sql = $"UPDATE EXEACC SET ACCBLACK = @black,ACCRED = @red,ACCSTATUS = @status,ACCDATE = @date_work,ACCTOTAL = @total,ACCDETAIL = @detail,ACCMONTH = @date_send WHERE ACCBANK = @bank AND ACCIDC = @idc AND ACCCUSNAM = @cusname"

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
                    _read()

                End If

            Else

                If Msg_confirm("คุณต้องการเพิ่มข้อมูลใหม่หรือไม่", "แจ้งเตือน") = vbYes Then

                    If txt_cusid.Text = "" Then

                        Msg_error("กรุณากรอกเลขบัตรประชาชนลูกค้า")
                        Return

                    End If

                    If txt_cusname.Text = "" Then

                        Msg_error("กรุณากรอกชื่อ-นามสกุลของลูกค้า")
                        Return

                    End If

                    connect()

                    sql = "INSERT INTO EXEACC(ACCKEY,ACCBANK,ACCIDC,ACCCUSNAM,ACCBLACK,ACCRED,ACCSTATUS,ACCDATE,ACCTOTAL,ACCDETAIL,ACCMONTH)VALUES(@KEY,@bank,@idc,@cusname,@black,@red,@status,@date_work,@total,@detail,@date_send)"

                    cmd.CommandText = sql
                    cmd.Parameters.Clear()

                    Dim _date As DateTime = dtp_date_receipt.Text
                    Dim acckey = $"{cbo_owner.Text}-{txt_cusid.Text}-{_date}"

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
                    cmd.Parameters.AddWithValue("date_send", dtp_datework.Text)

                    Dim r As Integer = cmd.ExecuteNonQuery()
                    If r = -1 Then

                        Msg_error("เกิดข้อผิดพลาดไม่สามารถเพิ่มข้อมูลได้")

                    Else


                        _Getlogdata($"เพิ่มข้อมูลตั้งเรื่อง {cbo_owner.Text}-{txt_cusid.Text}-{txt_cusname.Text}")
                        _Cleartext()
                        _countdata()
                        Msg_OK("บันทึกข้อมูลสำเร็จ")

                    End If

                End If

                cn.Close()

            End If

        End If

    End Sub

    Private Sub cmd_send_Click(sender As Object, e As EventArgs) Handles cmd_send.Click

        _Cleartext()
        _cleardatagrid(dtgv_exeacc)
        _write()

    End Sub

    Private Sub FrmEXEACC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class