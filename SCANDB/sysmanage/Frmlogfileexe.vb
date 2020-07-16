Option Explicit On
Imports System.Data.SqlClient
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports System.Globalization
Imports System.Data.OleDb
Imports System.Linq
Public Class frmlogfileexe
    Private Sub frmlogfileexe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        _Datetimeformatshort(DateTimestart)
        _Datetimeformatshort(DateTimeend)
        _Datetimeformatshort(dtp_log_date)

        connect()
        Dim itms() As String = {"ชื่อเข้าระบบ", "ชื่อพนักงาน", "IP", "PC", "รายละเอียด"}
        cbo_where.Items.AddRange(itms)                                          '// เพิ่ม Dropdown ใน Combobox
        cbo_where.SelectedIndex = 0

        sql = "SELECT COUNT(*) As countdatas FROM Execution_logfiles"            '// นับจำนวน ROWS ข้อมูลใน Table SQL
        cmd.CommandText = sql
        DA.SelectCommand = cmd
        DA.Fill(DS, "countdata")
        lbl_countdata.Text = DS.Tables("countdata").Rows(0)("countdatas")

        loaddatagrid()
        lbl_countdtgv.Text = dtgvlogfile.Rows.Count                        '// นับจำนวนแถวใน Datagridview

        For Each col As DataGridViewColumn In dtgvlogfile.Columns

            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Next

    End Sub

    Private Sub loaddatagrid()

        DateTimestart.Value = DateTime.Now.AddDays(0)
        DateTimeend.Value = DateTime.Now.AddDays(1)

        Dim header() As String = {"วันที่เข้าใช้", "เลขที่บัตรประชาชน", "เลขที่สัญญา", "ชื่อที่เข้าระบบ", "ชื่อผู้ใช้", "IP", "PC NAME", "รายละเอียด"}
        sql = "SELECT * FROM Execution_logfiles  WHERE LOGDATE BETWEEN @sdate AND @edate ORDER BY LOGDATE DESC"
        With cmd
            .Parameters.Clear()
            .Parameters.Add("@sdate", SqlDbType.Date).Value = DateTimestart.Value
            .Parameters.Add("@edate", SqlDbType.Date).Value = DateTimeend.Value
            .Connection = cn
            .CommandText = sql
            .CommandType = CommandType.Text
        End With
        DA.SelectCommand = cmd
        DA.Fill(DS, "refresh")
        With dtgvlogfile
            For i = 0 To header.Length - 1            'ใช้ loop For อ่านและแสดงข้อมูล 
                .DataSource = DS.Tables("refresh")
                .Columns(i).HeaderText = header(i)

            Next
        End With

        sql = "SELECT COUNT(*) As countdatas FROM tbl_logfiles"
        cmd.CommandText = sql
        DA.SelectCommand = cmd
        DA.Fill(DS, "countdata")

        lbl_countdata.Text = DS.Tables("countdata").Rows(0)("countdatas")
        lbl_countdtgv.Text = dtgvlogfile.Rows.Count

        For Each col As DataGridViewColumn In dtgvlogfile.Columns

            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Next

        dtgvlogfile.Columns(0).DefaultCellStyle.Format = "dd-MMM-yy HH:mm:ss"

    End Sub

    Private Sub cmd_refresh_Click(sender As Object, e As EventArgs) Handles cmd_refresh.Click
        dtgvlogfile.DataSource.clear()
        loaddatagrid()
    End Sub

    Private Sub cmd_find_Click(sender As Object, e As EventArgs) Handles cmd_find.Click
        dtgvlogfile.DataSource.clear()

        Dim headerdgv() As String = {"วันที่", "เลขที่บัตรประชาชน", "เลขที่สัญญา", "ชื่อที่เข้าระบบ", "ชื่อผู้ใช้", "IP", "PC NAME", "รายละเอียด"}
        Dim sqll As String = "SELECT * FROM Execution_logfiles WHERE LOGDATE BETWEEN @sdate AND @edate AND "

        Select Case cbo_where.SelectedItem
            Case "เลขที่บัตรประชาชน" : sqll &= "Customer_id_card"
            Case "เลขที่สัญญา" : sqll &= "Customer_account"
            Case "ชื่อเข้าระบบ" : sqll &= "LOGUSER "
            Case "ชื่อพนักงาน" : sqll &= "LOGNAME "
            Case "IP" : sqll &= "LOGIP "
            Case "PC" : sqll &= "LOGPCNAME "
            Case "รายละเอียด" : sqll &= "LOGDETAIL "
        End Select

        sqll &= $"LIKE '%{txt_find.Text}%' ORDER BY LOGDATE DESC"
        With cmd
            .Parameters.Clear()
            .Parameters.Add("@sdate", SqlDbType.Date).Value = DateTimestart.Value
            .Parameters.Add("@edate", SqlDbType.Date).Value = DateTimeend.Value
            .CommandText = sqll
        End With
        DA.SelectCommand = cmd
        DA.Fill(DS, "find")

        With dtgvlogfile
            For i = 0 To headerdgv.Length - 1
                .DataSource = DS.Tables("find")
                .Columns(i).HeaderText = headerdgv(i)

            Next

        End With

        lbl_countdtgv.Text = dtgvlogfile.Rows.Count

        For Each col As DataGridViewColumn In dtgvlogfile.Columns

            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Next

        dtgvlogfile.Columns(0).DefaultCellStyle.Format = "dd-MMM-yy HH:mm:ss"

    End Sub

    Private Sub cmd_report_Click(sender As Object, e As EventArgs) Handles cmd_report.Click

        With FrmlogexeRV
            .MdiParent = Me                             '// แสดง Form ตั้งค่า USER & PASSWORD
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub
    Private Sub frmlogfileexe_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub

    Private Sub dtgvlogfile_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvlogfile.CellClick
        dtp_log_date.Text = dtgvlogfile.CurrentRow.Cells(0).Value.ToString
        txt_log_idcard.Text = dtgvlogfile.CurrentRow.Cells(1).Value.ToString
        txt_log_account.Text = dtgvlogfile.CurrentRow.Cells(2).Value.ToString
        txt_customer_user.Text = dtgvlogfile.CurrentRow.Cells(3).Value.ToString
        txt_log_fullname.Text = dtgvlogfile.CurrentRow.Cells(4).Value.ToString
        txt_log_ip.Text = dtgvlogfile.CurrentRow.Cells(5).Value.ToString
        txt_log_pcname.Text = dtgvlogfile.CurrentRow.Cells(6).Value.ToString
        txt_log_detail.Text = dtgvlogfile.CurrentRow.Cells(7).Value.ToString
    End Sub
End Class