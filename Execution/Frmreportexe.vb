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
Imports Microsoft
Public Class Frmreportexe

    Dim headerdgv() As String = {"ธนาคาร", "เลขประจำตัวประชาชน", "ชื่อ-นามสกุล", "เลขที่สัญญา 1", "เลขที่สัญญา 2", "เลขที่สัญญา 3", "ศาล", "คดีดำ", "คดีแดง", "เลขเก็บ", "กรม", "จำนวนเงิน", "ชื่อเจ้าของใบงาน", "เบอร์ติดต่อ", "ศูนย์ประสานงาน", "วันที่ออกใบงาน", "ชื่อ-นามสกุลพนักงาน", "รายละเอียด", "ผลปฎิบัติงาน", "เดือนที่ออกใบงาน", "HUBS", "ผลลัพธ์"}

    Private Sub Frmsummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        disables()

        cbo_name.Enabled = False
        date_end.Enabled = False
        date_start.Enabled = False


        Dim products() As String = {"KBANK", "SCB", "TMB", "TBANK", "KKB", "UOB", "TSS"}

        cbo_bank.Items.AddRange(products)
        cbo_bank.SelectedItem = 0

        sql = $"SELECT DISTINCT(EXEHUBS) FROM EXESM"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()

            cbo_hubs.Items.Add($"{DR("EXEHUBS")}")

        End While

        DR.Close()

        cbo_hubs.SelectedItem = 0

        cbo_bank.SelectedItem = 0


        cn.Close()

    End Sub

    Private Sub Chkb_fullname_CheckedChanged(sender As Object, e As EventArgs) Handles Chkb_fullname.CheckedChanged

        connect()

        If Chkb_fullname.Checked = True Then

            cbo_name.Items.Clear()
            cbo_name.Enabled = True

            sql = $"SELECT DISTINCT(EXEFULLNAME) FROM EXESM  WHERE EXEHUBS = '{cbo_hubs.Text}' "
            cmd = New SqlCommand(sql, cn)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()

                cbo_name.Items.Add($"{reader("EXEFULLNAME")}")

            End While

            reader.Close()
        End If

        If Chkb_fullname.Checked = False Then

            cbo_name.Items.Clear()
            cbo_name.Enabled = False

        End If

        cn.Close()

    End Sub

    Private Sub cmd_alldata_Click(sender As Object, e As EventArgs) Handles cmd_alldata.Click

        connect()

        Dim sql As String = $"SELECT * FROM EXESM ORDER BY EXEDATEWORK "

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "tables")

        For i = 0 To headerdgv.Length - 1

            dtgv_reportsm.DataSource = DS.Tables("tables")
            dtgv_reportsm.Columns(i).HeaderText = headerdgv(i)
            dtgv_reportsm.Columns(0).Visible = False

        Next

        lbl_countreport.Text = dtgv_reportsm.Rows.Count

        cn.Close()

    End Sub

    Private Sub cmd_view_Click(sender As Object, e As EventArgs) Handles cmd_view.Click

        connect()

        If dtgv_reportsm.RowCount <> 0 Then

            lbl_countreport.Text = 0
            dtgv_reportsm.DataSource.clear()


            Return
        End If


        Dim sqll As String = $"SELECT EXEBANK ,EXEID ,EXECUSTOMER ,EXEACC1 ,EXEACC2 ,EXEACC3 ,EXECOURT ,EXEBLACK ,EXERED ,EXENUMBER ,EXEDEPARTMENT ,EXETOTAL ,EXEEMPLOYEE ,EXEPHONE ,EXEHUB ,EXEDATEWORK ,EXEFULLNAME ,EXEDETAIL ,EXEPERFORMANCE ,EXEDATERESULT ,EXEHUBS ,EXERESULT FROM EXESM  WHERE EXEBANK = '{cbo_bank.Text}' "

        If cbo_hubs.Text <> "" Then

            sqll &= $" AND EXEHUBS = '{cbo_hubs.Text}'"

        End If

        If Chkb_fullname.Checked = True Then

            sqll &= $" And EXEFULLNAME = '{cbo_name.Text}' "

        End If
        If chkb_date.Checked = True Then

            sqll &= $"And EXEDATEWORK BETWEEN @sdate And @edate "

        End If

        sqll &= $"ORDER BY EXEDATEWORK"

        With cmd
            .Parameters.Clear()
            .Parameters.Add("@sdate", SqlDbType.Date).Value = date_start.Value
            .Parameters.Add("@edate", SqlDbType.Date).Value = date_end.Value
            .CommandText = sqll
        End With

        DA.SelectCommand = cmd
        DA.Fill(DS, "find")

        With dtgv_reportsm

            For i = 0 To headerdgv.Length - 1
                .DataSource = DS.Tables("find")
                .Columns(i).HeaderText = headerdgv(i)

            Next

        End With

        lbl_countreport.Text = dtgv_reportsm.Rows.Count

        cn.Close()

    End Sub

    Private Sub chkb_date_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_date.CheckedChanged

        If chkb_date.Checked = True Then

            date_start.Enabled = True
            date_end.Enabled = True

        End If

        If chkb_date.Checked = False Then

            date_start.Enabled = False
            date_end.Enabled = False
            date_start.Text = ""
            date_end.Text = ""


        End If

    End Sub

    Private Sub cmd_export_Click(sender As Object, e As EventArgs) Handles cmd_export.Click
        If dtgv_reportsm.Rows.Count = 0 Or dtgv_reportsm.Columns.Count = 0 Then

            Msg_error("กรุณา แสดงข้อมูล ก่อน Export ทุกครั้ง")

        End If

        Exportexcel()

        cn.Close()

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


    Public Sub Exportexcel()
        Dim columnscount As Integer = dtgv_reportsm.Columns.Count
        Dim O As Integer = dtgv_reportsm.Rows.Count
        Dim Max As Integer = 100

        Try

            lbl_status.Text = "โปรดรอ..."
            cmd_export.Enabled = False            '// ปุ่มสำหรับดึงข้อมูล log มา เป็นรูปแบบ Excel อ่่านค่าจาก datagridview แล้วดึงข้อมูล
            cmd_view.Enabled = False              '// มาใส่ใน ไฟล์ Excel


            SaveFileDialog1.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls|Excel Workbook (*.xlsx)|*.xlsx"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer


                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("Sheet1")

                For Each column In dtgv_reportsm.Columns
                    xlWorkSheet.Cells(i + 2, column.index + 1).value = column.Name
                Next
                For i = 0 To dtgv_reportsm.Rows.Count - 1
                    Dim columnindex As Integer = 0
                    Do Until columnindex = columnscount
                        xlWorkSheet.Cells(i + 2, columnindex + 1).value = dtgv_reportsm.Item(columnindex, i).Value.ToString
                        columnindex += 1
                        lbl_statuspb.Text = i.ToString & "/" & dtgv_reportsm.Rows.Count.ToString
                        Pb_Export.Value = (i / O) * Max
                        Threading.Thread.Sleep(100)
                    Loop
                Next

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                lbl_statuspb.Text = i.ToString & "/" & dtgv_reportsm.Rows.Count.ToString
                Msg_OK("การ Export ข้อมูลสำเร็จ" & vbCrLf & "File are Saved at : " & SaveFileDialog1.FileName)
                lbl_status.Text = "ไม่มีการทำงาน"
                cmd_export.Enabled = True
                cmd_view.Enabled = True

            Else

                lbl_status.Text = "ไม่มีการทำงาน"
                cmd_export.Enabled = True
                cmd_view.Enabled = True
                Return

            End If

        Catch ex As Exception

            Msg_error("การ Export ข้อมูลล้มเหลว !!")
            lbl_status.Text = "ไม่มีการทำงาน"
            cmd_view.Enabled = True
            cmd_export.Enabled = True

            Return

        End Try

    End Sub

    Sub disables()

        cbo_bank.Enabled = False
        cbo_hubs.Enabled = False
        cbo_hubs.Enabled = False
        cmd_view.Enabled = False
        chkb_date.Enabled = False
        Chkb_fullname.Enabled = False
    End Sub

    Sub enables()

        cbo_bank.Enabled = True
        cbo_hubs.Enabled = True
        cbo_hubs.Enabled = True
        cmd_view.Enabled = True
        chkb_date.Enabled = True
        Chkb_fullname.Enabled = True

    End Sub

    Private Sub chkb_condition_CheckedChanged(sender As Object, e As EventArgs) Handles chkb_condition.CheckedChanged
        If chkb_condition.Checked = True Then

            enables()

        ElseIf chkb_condition.Checked = False Then

            disables()

        End If

    End Sub

End Class