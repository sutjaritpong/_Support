Option Explicit On
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Imports System.IO

Public Class FrmInsolvent

    '## นำข้อมูลจากตาราง EXESM คอลัมน์ EXEBANK มาแสดงใน Combobox โดยใช้ Sub _comboboxadd() มี Parameters สองตัว จากนั้นให้ Query จำนวนข้อมูลในตาราง EXEINSOLVENT มาแสดงโดยใช้คำสั่ง SELECT COUNT 

    Private Sub FrmInsolvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _cleartext()
        connect()

        _comboboxadd(cbo_owner, "EXEBANK", "EXESM")
        cbo_owner.SelectedIndex = -1

        sql = "SELECT COUNT(*) FROM EXEINSOLVENT"
        cmd.CommandText = sql
        cmd.ExecuteScalar()
        Dim countcmd As Integer = cmd.ExecuteScalar()
        lbl_count.Text = cmd_excuteScalar() & " ราย"


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
    Sub _cleartext()

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
        txt_total_receipt.Text = ""
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

    Sub _subreadonly()
        txt_black.ReadOnly = True
    End Sub

    '## Sub สำหรับการ Save ข้อมูล ลงใน ฐานข้อมูล EXEINSOLVENT โดยใช้คำสั่ง INSERT 
    Sub _saveinformation()

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
        cmd.Parameters.AddWithValue("receipt", txt_total_receipt.Text)
        cmd.Parameters.AddWithValue("receiptdescription", txt_receipt_description.Text)
        cmd.Parameters.AddWithValue("total", txt_total.Text)
        cmd.Parameters.AddWithValue("datesend", dtp_date_send.Text)


        Dim comple As Integer = cmd.ExecuteNonQuery()
        If comple > 0 Then
            Msg_OK("เพิ่มข้อมูลสำเร็จ")
            _cleartext()
        Else
            Msg_error("เพิ่มข้อมูลล้มเหลว")

        End If

    End Sub
    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click
        _saveinformation()
    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click
        _cleartext()
    End Sub
End Class