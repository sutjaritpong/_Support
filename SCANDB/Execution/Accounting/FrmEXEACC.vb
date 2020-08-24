Option Explicit On
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Public Class FrmEXEACC
    '## Array entity_ACC() นำไปใช้เพิ่ม Columns ใน Datagridview 
    Friend entity_ACC() As String = {"KEY", "PRODUCT", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "เลขที่คดีดำ", "เลขที่คดีแดง", "Status", "วันที่ใบเสร็จ", "จำนวนเงินในใบเสร็จ", "รายละเอียดใบเสร็จ", "จำนวนเงินใบเสร็จที่ 2", "รายละเอียดใบเสร็จที่ 2", "จำนวนเงินใบเสร็จที่ 3", "รายละเอียดใบเสร็จที่ 3", "เดือนที่ลงข้อมูล", "เลขที่สัญญา", "ธนาคาร", "BILLCODE", "Type", "CODE"}

    Private Sub FrmEXEACC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connect()
        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        Datetimeformatshort(dtp_datework)
        Datetimeformatshort(dtp_date_receipt)

        cleardatagrid(dtgv_exeacc)


        cbo_status.Items.Clear()
        cbo_owner.Items.Clear()
        cbo_search.Items.Clear()

        Comboboxadd(cbo_status, "ACCSTATUS", "EXEACC")
        cbo_status.SelectedIndex = -1

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

        countdata()

        cn.Close()
        Readonly_obj()

        dtgv_exeacc.Visible = False


    End Sub

    Private Sub Countdata()

        Connect()
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

    Private Sub Txt_totalbill_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total_receipt.KeyPress
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


    Private Sub Cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        datagrid()

    End Sub

    Sub Cleartext()

        cbo_owner.Text = ""
        txt_black.Text = ""
        txt_cusid.Text = ""
        txt_cusname.Text = ""
        txt_detail_receipt.Text = ""
        txt_red.Text = ""
        cbo_status.Text = ""
        txt_total_receipt.Text = ""
        txt_detail_receipt.Text = ""
        txt_total_receipt2.Text = ""
        txt_detail_receipt2.Text = ""
        txt_total_receipt3.Text = ""
        txt_detail_receipt3.Text = ""
        dtp_datework.Text = ""
        dtp_date_receipt.Text = ""
        cbo_owner.Text = ""

        'LINK Legal data
        Txt_account.Text = ""
        Txt_bank.Text = ""
        Txt_Billcode.Text = ""
        Txt_productcode.Text = ""
        Txt_type.Text = ""


        chk_date_work.Checked = False
        chk_date_receipt.Checked = False

        If chk_date_receipt.Checked = False Then
            dtp_date_receipt.Enabled = False
        End If
        If chk_date_work.Checked = False Then
            dtp_datework.Enabled = False
        End If
    End Sub
    Private Sub Readonly_obj()

        cbo_owner.Enabled = False  'enable = false if readonly = true
        cbo_status.Enabled = False

        txt_cusid.ReadOnly = True
        txt_cusname.ReadOnly = True
        txt_black.ReadOnly = True
        txt_red.ReadOnly = True


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
    Private Sub Write_obj()

        cbo_owner.Enabled = True  '#enable = true if readonly = false
        cbo_status.Enabled = True

        txt_cusid.ReadOnly = False
        txt_cusname.ReadOnly = False
        txt_black.ReadOnly = False
        txt_red.ReadOnly = False

        txt_total_receipt.ReadOnly = False
        txt_total_receipt2.ReadOnly = False
        txt_total_receipt3.ReadOnly = False

        txt_detail_receipt.ReadOnly = False
        txt_detail_receipt2.ReadOnly = False
        txt_detail_receipt3.ReadOnly = False

        chk_date_work.Enabled = True
        chk_date_receipt.Enabled = True

    End Sub
    Private Sub LinK_Legal()

        Connect_legal()


        sqll = $"SELECT CUSACC,CUSTOWN,CUSCLS,CUSBUC,CUSPRO FROM dbCUS WHERE CUSOWN = '{cbo_owner.Text}' AND CUSIDC = '{txt_cusid.Text}'"
        cmdlegal = New SqlCommand(sqll, cnLegal)
        DALegal = New SqlDataAdapter(cmdlegal)
        DSLegal = New DataSet
        DALegal.Fill(DSLegal, "linklegal")

        If DSLegal.Tables("linklegal").Rows.Count <= 0 Then
            Lbl_linklegal.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
            Lbl_linklegal.ForeColor = Color.Red
        Else

            Txt_account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
            Txt_bank.Text = DSLegal.Tables("linklegal").Rows(0)("CUSTOWN").ToString
            Txt_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
            Txt_type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
            Txt_productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

            Lbl_linklegal.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
            Lbl_linklegal.ForeColor = Color.Green
        End If

    End Sub
    Private Sub Datagrid()

        Connect()

        Cleardatagrid(dtgv_exeacc)
        Cleartext()

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
            Datagrid_format_dateshort(dtgv_exeacc, 7)
            Datagrid_format_dateshort(dtgv_exeacc, 14)
            lbl_count_find.Text = $"พบข้อมูล {dtgv_exeacc.RowCount} รายการ.."
            lbl_count_find.ForeColor = Color.Green

        End If

        cn.Close()

    End Sub

    Private Sub Cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click
        Write_obj()                '# แก้ไขข้อมูล !
    End Sub

    Private Sub Cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click
        Readonly_obj()                 '# ยกเลิกการแก้ไข !
    End Sub

    Private Sub Dtgv_exeacc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_exeacc.CellClick

        Cleartext()

        Try
            cbo_owner.Text = dtgv_exeacc.CurrentRow.Cells(1).Value.ToString
            txt_cusid.Text = dtgv_exeacc.CurrentRow.Cells(2).Value.ToString
            txt_cusname.Text = dtgv_exeacc.CurrentRow.Cells(3).Value.ToString
            txt_black.Text = dtgv_exeacc.CurrentRow.Cells(4).Value.ToString
            txt_red.Text = dtgv_exeacc.CurrentRow.Cells(5).Value.ToString
            cbo_status.Text = dtgv_exeacc.CurrentRow.Cells(6).Value.ToString
            dtp_date_receipt.Text = dtgv_exeacc.CurrentRow.Cells(7).Value.ToString
            txt_total_receipt.Text = CInt(dtgv_exeacc.CurrentRow.Cells(8).Value)
            txt_detail_receipt.Text = dtgv_exeacc.CurrentRow.Cells(9).Value.ToString

            txt_total_receipt2.Text = CInt(dtgv_exeacc.CurrentRow.Cells(10).Value)
            txt_detail_receipt2.Text = dtgv_exeacc.CurrentRow.Cells(11).Value.ToString
            txt_total_receipt3.Text = CInt(dtgv_exeacc.CurrentRow.Cells(12).Value.ToString)
            txt_detail_receipt3.Text = dtgv_exeacc.CurrentRow.Cells(13).Value.ToString

            dtp_datework.Text = dtgv_exeacc.CurrentRow.Cells(14).Value.ToString

            LinK_Legal()

            Convertnum(txt_total_receipt)
            convertnum(txt_total_receipt2)
            convertnum(txt_total_receipt3)

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
            Readonly_obj()
        End Try


    End Sub

    Private Sub Cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click

        Connect()

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


            sql = $"UPDATE EXEACC SET ACCBLACK = @black,ACCRED = @red,ACCSTATUS = @status,ACCDATE = @date_work,ACCRECEIPT = @total,ACCRECEIPT_DETAIL = @detail,ACCRECEIPT_OTHER_2 = @total2,ACCRECEIPT_OTHER_DETAIL2 = @detail2,ACCRECEIPT_OTHER_3 = @total3,ACCRECEIPT_OTHER_DETAIL3 = @detail3,ACCMONTH = @date_send ,ACCACC = @Acc ,ACCTOWN = @Town,ACCBILLCODE = @Billcode,ACCTYPE = @Type,ACCPRODUCTCODE = @Productcode WHERE ACCBANK = @bank AND ACCIDC = @idc AND ACCCUSNAM = @cusname"

            cmd.CommandText = sql
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("bank", cbo_owner.Text)
            cmd.Parameters.AddWithValue("idc", txt_cusid.Text)
            cmd.Parameters.AddWithValue("cusname", txt_cusname.Text)
            cmd.Parameters.AddWithValue("black", txt_black.Text)
            cmd.Parameters.AddWithValue("red", txt_red.Text)
            cmd.Parameters.AddWithValue("status", cbo_status.Text)
            cmd.Parameters.AddWithValue("total", txt_total_receipt.Text)
            cmd.Parameters.AddWithValue("detail", txt_detail_receipt.Text)
            cmd.Parameters.AddWithValue("date_work", dtp_date_receipt.Text)
            cmd.Parameters.AddWithValue("total2", txt_total_receipt2.Text)
            cmd.Parameters.AddWithValue("detail2", txt_detail_receipt2.Text)
            cmd.Parameters.AddWithValue("total3", txt_total_receipt3.Text)
            cmd.Parameters.AddWithValue("detail3", txt_detail_receipt3.Text)
            cmd.Parameters.AddWithValue("date_send", dtp_datework.Text)

            ' # ข้อมูลที่ใช้เบิก TSS !

            cmd.Parameters.AddWithValue("Acc", Txt_account.Text)
            cmd.Parameters.AddWithValue("Town", Txt_bank.Text)
            cmd.Parameters.AddWithValue("Billcode", Txt_Billcode.Text)
            cmd.Parameters.AddWithValue("Type", Txt_type.Text)
            cmd.Parameters.AddWithValue("Productcode", Txt_productcode.Text)


            Dim r As Integer = cmd.ExecuteNonQuery()
            If r = -1 Then

                Msg_error("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")

            Else

                Msg_OK("แก้ไขข้อมูล สำเร็จ")
                Getlogdataexe($"แก้ไข ข้อมูลตั้งเรื่อง ธนาคาร {cbo_owner.Text} ID CARD {txt_cusid.Text} ชื่อ-นามสกุล {txt_cusname.Text}", $"'{txt_cusid.Text}'", $"{Txt_account.Text}")

            End If

            If dtgv_exeacc.Rows.Count <> 0 Then

                dtgv_exeacc.DataSource = Nothing

                Datagrid()
                Readonly_obj()
                cn.Close()
            End If

        End If

    End Sub



    Private Sub Cmd_send_Click(sender As Object, e As EventArgs) Handles cmd_send.Click
        Dim _date As DateTime = dtp_date_receipt.Text
        Dim acckey = $"{cbo_owner.Text}-{txt_cusid.Text}-{_date}"
        Connect()

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

            sql = "INSERT INTO EXEACC(ACCKEY,ACCBANK,ACCIDC,ACCCUSNAM,ACCBLACK,ACCRED,ACCSTATUS,ACCDATE,ACCRECEIPT,ACCRECEIPT_DETAIL,ACCRECEIPT_OTHER_2,ACCRECEIPT_OTHER_DETAIL2,ACCRECEIPT_OTHER_3,ACCRECEIPT_OTHER_DETAIL3,ACCMONTH,ACCACC,ACCTOWN,ACCBILLCODE,ACCTYPE,ACCPRODUCTCODE)VALUES(@KEY,@bank,@idc,@cusname,@black,@red,@status,@date_work,@total,@detail,@total2,@detail2,@total3,@detail3,@date_send,@Acc,@Town,@Billcode,@Types,@Productcode)"

            cmd.CommandText = sql
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("KEY", acckey)
            cmd.Parameters.AddWithValue("bank", cbo_owner.Text)
            cmd.Parameters.AddWithValue("idc", txt_cusid.Text)
            cmd.Parameters.AddWithValue("cusname", txt_cusname.Text)
            cmd.Parameters.AddWithValue("black", txt_black.Text)
            cmd.Parameters.AddWithValue("red", txt_red.Text)
            cmd.Parameters.AddWithValue("status", cbo_status.Text)
            cmd.Parameters.AddWithValue("date_work", dtp_date_receipt.Text)
            cmd.Parameters.AddWithValue("total", txt_total_receipt.Text)
            cmd.Parameters.AddWithValue("detail", txt_detail_receipt.Text)
            cmd.Parameters.AddWithValue("total2", txt_total_receipt2.Text)
            cmd.Parameters.AddWithValue("detail2", txt_detail_receipt2.Text)
            cmd.Parameters.AddWithValue("total3", txt_total_receipt3.Text)
            cmd.Parameters.AddWithValue("detail3", txt_detail_receipt3.Text)
            cmd.Parameters.AddWithValue("date_send", dtp_datework.Text)

            ' # ข้อมูลที่ใช้เบิก TSS !

            cmd.Parameters.AddWithValue("Acc", Txt_account.Text)
            cmd.Parameters.AddWithValue("Town", Txt_bank.Text)
            cmd.Parameters.AddWithValue("Billcode", Txt_Billcode.Text)
            cmd.Parameters.AddWithValue("Types", Txt_type.Text)
            cmd.Parameters.AddWithValue("Productcode", Txt_productcode.Text)

            Dim r As Integer = cmd.ExecuteNonQuery()
            If r = -1 Then

                Msg_error("เกิดข้อผิดพลาดไม่สามารถเพิ่มข้อมูลได้")
                cn.Close()
            Else

                Msg_OK("บันทึกข้อมูลสำเร็จ")
                Getlogdataexe($"เพิ่มข้อมูลตั้งเรื่อง {cbo_owner.Text}-{txt_cusid.Text}-{txt_cusname.Text}", txt_cusid.Text, "NULL")

                Cleartext()
                Countdata()
                Cleardatagrid(dtgv_exeacc)
                cn.Close()

            End If

        End If

    End Sub
    '## Event Closing ใช้สำหรับกดปิดหรือสั่งปิดฟอร์มให้ ปิดการเชื่อมต่อของฐานข้อมูลด้วย
    Private Sub FrmEXEACC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cnLegal.Close()
        cn.Close()
        Me.Dispose()

    End Sub
    '## Method Checked ใน Event CheckedChanged ไว้สำหรับเช็คค่าในปัจจุบัน ของ Checkbox ว่าเป็น True หรือ False 
    Private Sub Chk_date_work_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_work.CheckedChanged

        If chk_date_work.Checked = True Then

            dtp_datework.Enabled = True
        Else
            dtp_datework.Enabled = False

        End If

    End Sub
    '## Method Checked ใน Event CheckedChanged ไว้สำหรับเช็คค่าในปัจจุบัน ของ Checkbox ว่าเป็น True หรือ False 
    Private Sub Chk_date_receipt_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_receipt.CheckedChanged

        If chk_date_receipt.Checked = True Then

            dtp_date_receipt.Enabled = True
        Else
            dtp_date_receipt.Enabled = False

        End If

    End Sub

    Private Sub Cmd_delete_Click(sender As Object, e As EventArgs) Handles cmd_delete.Click

        Cleartext()
        lbl_count_find.Text = "ผลการค้นหา..."
        lbl_count_find.ForeColor = Color.Blue
        dtgv_exeacc.DataSource = Nothing
        dtgv_exeacc.Visible = False
        txt_search.Text = ""

    End Sub

    Private Sub Txt_total_receipt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total_receipt2.KeyPress

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

    Private Sub Txt_total_receipt3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total_receipt3.KeyPress

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

    Private Sub Cmd_Linkdata_Click(sender As Object, e As EventArgs) Handles Cmd_Linkdata.Click

        LinK_Legal()

    End Sub

End Class