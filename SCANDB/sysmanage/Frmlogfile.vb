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

Public Class Frmlogfile
    Private Sub Frmlogfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        _Datetimeformatshort(DateTimestart)
        _Datetimeformatshort(DateTimeend)

        Dim itms() As String = {"ชื่อเข้าระบบ", "ชื่อพนักงาน", "IP", "PC", "รายละเอียด"}
        cbo_where.Items.AddRange(itms)                                          '// เพิ่ม Dropdown ใน Combobox
        cbo_where.SelectedIndex = 0

        sql = "SELECT COUNT(*) As countdatas FROM tbl_logfiles"            '// นับจำนวน ROWS ข้อมูลใน Table SQL
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
    '## Sql command ในการ ค้นหาข้อมูล โดยกำหนดเงื่อนไข การค้นหา ด้วยคำสั่ง BETWEEN AND 
    Private Sub loaddatagrid()

        DateTimestart.Value = DateTime.Now.AddDays(0)
        DateTimeend.Value = DateTime.Now.AddDays(1)

        Dim header() As String = {"วันที่เข้าใช้", "ชื่อที่เข้าระบบ", "ชื่อผู้ใช้", "IP", "PC NAME", "รายละเอียด"}
        sql = "SELECT * FROM tbl_logfiles  WHERE LOGDATE BETWEEN @sdate AND @edate ORDER BY LOGDATE DESC"
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
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_refresh.Click
        dtgvlogfile.DataSource.clear()
        loaddatagrid()
    End Sub
    Private Sub cmd_find_Click(sender As Object, e As EventArgs) Handles cmd_find.Click

        dtgvlogfile.DataSource.clear()

        Dim headerdgv() As String = {"วันที่", "ชื่อที่เข้าระบบ", "ชื่อผู้ใช้", "IP", "PC NAME", "รายละเอียด"}
        Dim sqll As String = "SELECT * FROM tbl_logfiles WHERE LOGDATE BETWEEN @sdate AND @edate AND "

        Select Case cbo_where.SelectedItem
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

    End Sub

    '## ปุ่มสำหรับดึงข้อมูล log มา เป็นรูปแบบ Excel อ่่านค่าจาก datagridview แล้วดึงข้อมูล มาใส่ใน ไฟล์ Excel
    Private Sub cmd_text_Click(sender As Object, e As EventArgs) Handles cmd_text.Click

        Try

            lbl_statusexport.Text = "โปรดรอ..."
            cmd_text.Enabled = False
            cmd_refresh.Enabled = False
            cmd_find.Enabled = False

            SaveFileDialog1.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls|Excel Workbook (*.xlsx)|*.xlsx"

            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer
                Dim y As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                For i = 0 To dtgvlogfile.RowCount - 2

                    For y = 0 To dtgvlogfile.ColumnCount - 1

                        For x As Integer = 1 To dtgvlogfile.Columns.Count

                            xlWorkSheet.Cells(1, x) = dtgvlogfile.Columns(x - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, y + 1) = dtgvlogfile(y, i).Value.ToString()

                        Next

                    Next

                Next
                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                Msg_OK("การ Export ข้อมูลสำเร็จ" & vbCrLf & "File are Saved at : " & SaveFileDialog1.FileName)
                lbl_statusexport.Text = "ไม่มีการทำงาน"
                cmd_text.Enabled = True
                cmd_find.Enabled = True
                cmd_refresh.Enabled = True
            Else
                lbl_statusexport.Text = "ไม่มีการทำงาน"
                cmd_text.Enabled = True
                cmd_find.Enabled = True
                cmd_refresh.Enabled = True
                Return

            End If

        Catch ex As Exception

            Msg_error("การ Export ข้อมูลล้มเหลว !!")
            lbl_statusexport.Text = "ไม่มีการทำงาน"
            cmd_text.Enabled = True
            cmd_find.Enabled = True
            cmd_refresh.Enabled = True

            Return
        End Try

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub dtgvlogfile_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvlogfile.CellClick

        txt_detaillog.Text = "วันที่ : " & dtgvlogfile.CurrentRow.Cells(0).Value.ToString & vbNewLine & "ชื่อ-นามสกุล : " & dtgvlogfile.CurrentRow.Cells(1).Value.ToString & vbNewLine & "USER : " & dtgvlogfile.CurrentRow.Cells(2).Value.ToString & vbNewLine & "IP : " & dtgvlogfile.CurrentRow.Cells(3).Value.ToString & vbNewLine & "COMPUTER NAME : " & dtgvlogfile.CurrentRow.Cells(4).Value.ToString & vbNewLine & "รายละเอียด : " & vbNewLine & dtgvlogfile.CurrentRow.Cells(5).Value.ToString

    End Sub

    Private Sub Frmlogfile_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub
End Class