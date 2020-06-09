Option Explicit On
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Imports System.IO

Public Class FrmInsolvent
    '## สร้างตัวแปร Array ชื่อ _headertext() เก็บหัวตารางเพื่อแสดงใน Datagridview และเพิ่ม Item เป็นหัวข้อในการค้นหา
    Dim _headertext() As String = {"ธนาคาร", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "เลขคดีดำ", "เลขคดีแดง", "ศาล"}

    '## นำข้อมูลจากตาราง EXESM คอลัมน์ EXEBANK มาแสดงใน Combobox โดยใช้ Sub _comboboxadd() มี Parameters สองตัว จากนั้นให้ Query จำนวนข้อมูลในตาราง EXEINSOLVENT มาแสดงโดยใช้คำสั่ง SELECT COUNT 

    Private Sub FrmInsolvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _cleartext()
        connect()

        _cboArray(cbo_finds, _headertext)

        _comboboxadd(cbo_owner, "EXEBANK", "EXESM")
        cbo_owner.SelectedIndex = -1

        sql = "SELECT COUNT(*) FROM EXEINSOLVENT"
        cmd.CommandText = sql
        cmd.ExecuteScalar()
        Dim countcmd As Integer = cmd.ExecuteScalar()
        lbl_count.Text = cmd_excuteScalar() & " ราย"

        _cleardatagrid(dtgv_insolvent)

        _subreadonly()

        cn.Close()
    End Sub

    Private Sub Chk_date_request_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_date_request.CheckedChanged

        If Chk_date_request.Checked = True Then

            dtp_date_request.Enabled = True
        Else
            dtp_date_request.Enabled = False
        End If

    End Sub

    Private Sub chk_verify_insolvent_CheckedChanged(sender As Object, e As EventArgs) Handles chk_verify_insolvent.CheckedChanged

        If chk_verify_insolvent.Checked = True Then

            dtp_verify_insolvent.Enabled = True
        Else
            dtp_verify_insolvent.Enabled = False
        End If

    End Sub

    '## Checkbox ใช้สำหรับเปิดใช้งาน Datetimepicker โดยดูจากสถานะของ Checkbox ว่าเป็น True หรือ False
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_send.CheckedChanged

        If chk_date_send.Checked = True Then

            dtp_date_send.Enabled = True
        Else
            dtp_date_send.Enabled = False
        End If


    End Sub
    '## Timer ใช้สำหรับแสดงเวลา หรือนาฬิกา บน Object label 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim dt As DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat

        lbl_timer.Text = DateAndTime.TimeString             '//ตั้งเวลาโปรแกรม

        lbl_datetoday.Text = DateAndTime.Today.ToShortDateString        '//ตั้งเวลาวันที่ 

    End Sub
    '## Sub สำหรับเคลียข้อมูลต่าง ๆ ใน Textbox,datetimepicker,combobox,chkbox
    Private Sub _cleartext()

        txt_black.Text = ""
        txt_company.Text = ""
        txt_court.Text = ""
        txt_court_isolvent.Text = ""
        txt_cusid.Text = ""
        txt_cusname.Text = ""
        txt_description.Text = ""
        txt_number_insolvent.Text = ""
        txt_receipt_description.Text = ""
        txt_red.Text = ""
        txt_search.Text = ""
        txt_total.Text = ""
        txt_receipt.Text = ""
        cbo_owner.Text = ""
        dtp_date_request.Text = ""
        dtp_date_send.Text = ""
        dtp_verify_insolvent.Text = ""
        Chk_date_request.Checked = False
        chk_date_send.Checked = False
        chk_verify_insolvent.Checked = False

        If Chk_date_request.Checked = False Then
            dtp_date_request.Enabled = False
        End If
        If chk_date_send.Checked = False Then
            dtp_date_send.Enabled = False
        End If
        If chk_verify_insolvent.Checked = False Then
            dtp_verify_insolvent.Enabled = False
        End If
    End Sub
    '## Sub ห้ามการแก้ไขข้อมูล Method Readonly
    Private Sub _subreadonly()

        txt_black.ReadOnly = True
        txt_company.ReadOnly = True
        txt_court.ReadOnly = True
        txt_court_isolvent.ReadOnly = True
        txt_cusid.ReadOnly = True
        txt_cusname.ReadOnly = True
        txt_description.ReadOnly = True
        txt_number_insolvent.ReadOnly = True
        txt_receipt_description.ReadOnly = True
        txt_red.ReadOnly = True
        txt_total.ReadOnly = True
        txt_receipt.ReadOnly = True

        '## เนื่องจาก Combobox,checkbox,datetimepicker ไม่มี Method Readonly จึงใช้ Method Enable แทน
        chk_date_send.Enabled = False
        Chk_date_request.Enabled = False
        chk_verify_insolvent.Enabled = False

        cbo_owner.Enabled = False

        dtgv_insolvent.Visible = False

        If Chk_date_request.Enabled = False Then
            dtp_date_request.Enabled = False
        End If
        If chk_date_send.Enabled = False Then
            dtp_date_send.Enabled = False
        End If
        If chk_verify_insolvent.Enabled = False Then
            dtp_verify_insolvent.Enabled = False
        End If

    End Sub

    '## Sub ใช้สำหรับเปิดใช้งานการแก้ไขข้อมูล
    Private Sub _Written()

        txt_black.ReadOnly = False
        txt_company.ReadOnly = False
        txt_court.ReadOnly = False
        txt_court_isolvent.ReadOnly = False
        txt_cusid.ReadOnly = False
        txt_cusname.ReadOnly = False
        txt_description.ReadOnly = False
        txt_number_insolvent.ReadOnly = False
        txt_receipt_description.ReadOnly = False
        txt_red.ReadOnly = False
        txt_total.ReadOnly = False
        txt_receipt.ReadOnly = False

        '## เนื่องจาก Combobox,checkbox,datetimepicker ไม่มี Method Readonly จึงใช้ Method Enable แทน
        chk_date_send.Enabled = True
        Chk_date_request.Enabled = True
        chk_verify_insolvent.Enabled = True

        cbo_owner.Enabled = True


    End Sub

    '## Sub สำหรับการ Save ข้อมูล ลงใน ฐานข้อมูล EXEINSOLVENT โดยใช้คำสั่ง INSERT 
    Private Sub _saveinformation()

        Dim _datetime_sheet As DateTime = dtp_date_request.Text
        Dim _keys As String = $"{cbo_owner.Text}-{txt_cusid.Text}-{_datetime_sheet}"

        connect()

        sql = $"SELECT COUNT(*) FROM EXEINSOLVENT WHERE insolvent_pk = '{_keys}'"
        cmd.CommandText = sql

        Dim counts As Integer = cmd.ExecuteScalar()
        If counts > 0 Then
            Msg_error("ข้อมูลนี้มีในระบบแล้ว")
            Return
        End If

        sql = "INSERT INTO EXEINSOLVENT(insolvent_pk,insolvent_owner,insolvent_idc,insolvent_company,insolvent_fullname,insolvent_department,insolvent_number,insolvent_black,insolvent_red,insolvent_court,insolvent_description,insolvent_date_request,insolvent_date_verify,insolvent_receipt,insolvent_receipt_description,insolvent_total,insolvent_send)VALUES(@insolventkey,@owner,@idc,@company,@fullname,@Department,@number,@black,@red,@court,@description,"
        If Chk_date_request.Checked = True Then
            sql &= $"@daterequest,"
        Else
            sql &= "NULL,"
        End If
        If chk_verify_insolvent.Checked = True Then
            sql &= $"@dateverify,"
        Else
            sql &= "NULL,"
        End If

        sql &= "@receipt,@receiptdescription,@total,"

        If chk_date_send.Checked = True Then
            sql &= $"@datesend)"
        Else
            sql &= "NULL)"
        End If

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("insolventkey", _keys)
        cmd.Parameters.AddWithValue("owner", cbo_owner.Text)
        cmd.Parameters.AddWithValue("idc", txt_cusid.Text)
        cmd.Parameters.AddWithValue("company", txt_company.Text)
        cmd.Parameters.AddWithValue("fullname", txt_cusname.Text)
        cmd.Parameters.AddWithValue("Department", txt_court_isolvent.Text)
        cmd.Parameters.AddWithValue("number", txt_number_insolvent.Text)
        cmd.Parameters.AddWithValue("black", txt_black.Text)
        cmd.Parameters.AddWithValue("red", txt_red.Text)
        cmd.Parameters.AddWithValue("court", txt_court.Text)
        cmd.Parameters.AddWithValue("description", txt_description.Text)
        cmd.Parameters.AddWithValue("daterequest", dtp_date_request.Text)
        cmd.Parameters.AddWithValue("dateverify", dtp_verify_insolvent.Text)
        cmd.Parameters.AddWithValue("receipt", txt_receipt.Text)
        cmd.Parameters.AddWithValue("receiptdescription", txt_receipt_description.Text)
        cmd.Parameters.AddWithValue("total", txt_total.Text)
        cmd.Parameters.AddWithValue("datesend", dtp_date_send.Text)


        Dim comple As Integer = cmd.ExecuteNonQuery()
        If comple > 0 Then
            Msg_OK("เพิ่มข้อมูลสำเร็จ")
            _cleartext()
            cn.Close()
        Else
            Msg_error("เพิ่มข้อมูลล้มเหลว")
            cn.Close()
        End If

    End Sub
    '## Sub สำหรับ ลบข้อมูล จากตาราง EXEINSOLVENT โดยอิงจาก Product และ ID แล้ว
    Private Sub _deleteinformation()

        '## Functions massagebox เรียกหน้าต่างยืนยันพร้อมคำเตือน ก่อนกระทำ Statement ต่อไปภายในคำสั่ง 
        If Msg_confirm("คุณต้องการลบข้อมูลหรือไม่") = vbYes Then

            connect()
            sql = "DELETE FROM EXEINSOLVENT WHERE insolvent_owner = @owner AND insolvent_idc = @idc"
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("owner", cbo_owner.Text)
            cmd.Parameters.AddWithValue("idc", txt_cusid.Text)
            Dim nons As Integer = cmd.ExecuteNonQuery()
            If nons > 0 Then
                Msg_OK("ลบข้อมูลสำเร็จ")
                cn.Close()
            Else
                Msg_error("ลบข้อมูลล้มเหลว")
                cn.Close()
            End If

        End If

    End Sub
    '## Sub สำหรับ ค้นหาข้อมูล จากตาราง EXEINSOLVENT โดยอิงคอลัมน์หรือประเภทข้อมูลการค้นหาจาก Combobox
    Private Sub _findinformation()

        dtgv_insolvent.Visible = True

        If dtgv_insolvent.RowCount > 0 Or dtgv_insolvent.ColumnCount > 0 Then
            dtgv_insolvent.DataSource = Nothing

        End If

        connect()

            _sql = "SELECT insolvent_owner,insolvent_idc,insolvent_fullname,insolvent_black,insolvent_red,insolvent_court FROM EXEINSOLVENT WHERE "

            Select Case cbo_finds.SelectedItem
                Case "ธนาคาร" : _sql &= "insolvent_owner "
                Case "เลขบัตรประชาชน" : _sql &= "insolvent_idc "
                Case "ชื่อ-นามสกุล" : _sql &= "insolvent_fullname "
                Case "เลขคดีดำ" : _sql &= "insolvent_black "
                Case "เลขคดีแดง" : _sql &= "insolvent_red "
                Case "ศาล" : _sql &= "insolvent_court "
            End Select

            _sql &= $"LIKE '%{txt_search.Text}%' ORDER BY insolvent_owner "
            cmd = New SqlCommand(_sql, cn)
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "insolvents")

            dtgv_insolvent.DataSource = DS.Tables("insolvents")

            For i = 0 To _headertext.Length - 1
                dtgv_insolvent.Columns(i).HeaderText = _headertext(i)
            Next
            cn.Close()

    End Sub
    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click
        _saveinformation()
        _subreadonly()
    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click
        _cleartext()
        _subreadonly()
    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click
        _Written()
    End Sub

    Private Sub cmd_delete_Click(sender As Object, e As EventArgs) Handles cmd_delete.Click
        _deleteinformation()
        _cleartext()
    End Sub

    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_finds.Click
        _findinformation()
    End Sub

    Private Sub dtgv_insolvent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_insolvent.CellClick
        Try
            cbo_owner.Text = dtgv_insolvent.CurrentRow.Cells(0).Value
            txt_cusid.Text = dtgv_insolvent.CurrentRow.Cells(1).Value
            txt_cusname.Text = dtgv_insolvent.CurrentRow.Cells(2).Value
            txt_black.Text = dtgv_insolvent.CurrentRow.Cells(3).Value
            txt_red.Text = dtgv_insolvent.CurrentRow.Cells(4).Value
            txt_court.Text = dtgv_insolvent.CurrentRow.Cells(5).Value

            connect()

            sql = $"SELECT * FROM EXEINSOLVENT WHERE insolvent_owner = '{dtgv_insolvent.CurrentRow.Cells(0).Value}' And insolvent_idc = '{dtgv_insolvent.CurrentRow.Cells(1).Value}' "
            cmd = New SqlCommand(sql, cn)
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "cellclick")

            If DS.Tables("cellclick").Rows(0)("insolvent_date_request").ToString = "" Or vbNull Then
                Chk_date_request.Checked = False
            Else
                Chk_date_request.Checked = True
            End If
            If DS.Tables("cellclick").Rows(0)("insolvent_date_verify").ToString = "" Or vbNull Then
                chk_verify_insolvent.Checked = False
            Else
                chk_verify_insolvent.Checked = True
            End If


            txt_company.Text = DS.Tables("cellclick").Rows(0)("insolvent_company").ToString
                txt_court_isolvent.Text = DS.Tables("cellclick").Rows(0)("insolvent_department").ToString
                txt_number_insolvent.Text = DS.Tables("cellclick").Rows(0)("insolvent_number").ToString
                txt_description.Text = DS.Tables("cellclick").Rows(0)("insolvent_description").ToString
                dtp_date_request.Text = DS.Tables("cellclick").Rows(0)("insolvent_date_request").ToString
                dtp_verify_insolvent.Text = DS.Tables("cellclick").Rows(0)("insolvent_date_verify").ToString
                txt_receipt.Text = DS.Tables("cellclick").Rows(0)("insolvent_receipt").ToString
                txt_receipt_description.Text = DS.Tables("cellclick").Rows(0)("insolvent_receipt_description").ToString
                txt_total.Text = DS.Tables("cellclick").Rows(0)("insolvent_total").ToString
                dtp_date_send.Text = DS.Tables("cellclick").Rows(0)("insolvent_send").ToString

                If (txt_total.Text <> "") AndAlso (Not IsNumeric(txt_total.Text)) Then


            Else

                txt_total.Text = CDbl(txt_total.Text).ToString("##,##0.00")

            End If

            If (txt_receipt.Text <> "") AndAlso (Not IsNumeric(txt_receipt.Text)) Then

            Else

                txt_receipt.Text = CDbl(txt_receipt.Text).ToString("##,##0.00")

            End If

        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub FrmInsolvent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub
End Class