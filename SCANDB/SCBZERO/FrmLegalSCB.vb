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

Public Class FrmLegalSCB

    Private Sub FrmLegalSCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cmd_ExportExcel.Enabled = False

        Dim Clockmonth As DateTime = DateTime.Now.AddMonths(-1).AddDays(1)
        Console.WriteLine(Clockmonth)
        Dim Clockafter As DateTime = DateTime.Now.AddMonths(0)
        Console.WriteLine(Clockafter)


        Connect_legal()

        Dim Typescb() As String = {"ZERO", "ไม่ใช่ZERO", "SCBงานคดีทั้งหมด"}

        cbo_finds.Items.Clear()

        cbo_finds.Items.AddRange(Typescb)

        cbo_finds.SelectedIndex = 0

        sqll = "SELECT COUNT(*) FROM dbCUS WHERE CUSOWN = 'SCB' AND CUSBUC = 'ZERO';"
        cmdlegal = New SqlCommand(sqll, cnLegal)
        Dim Count_zero As Integer = cmdlegal.ExecuteScalar()

        Lbl_Legalzero.Text = Count_zero.ToString & " " & "บัญชี"

        sqll = "SELECT COUNT(*) FROM dbCUS WHERE CUSOWN = 'SCB' AND CUSBUC IS NULL;"
        cmdlegal = New SqlCommand(sqll, cnLegal)
        Dim Count_nonzero As Integer = cmdlegal.ExecuteScalar()

        Lbl_Legalscb.Text = Count_nonzero.ToString & " " & "บัญชี"

        sqll = "SELECT COUNT(*) FROM dbCUS WHERE CUSOWN = 'SCB';"
        cmdlegal = New SqlCommand(sqll, cnLegal)
        Dim Count_alllegal As Integer = cmdlegal.ExecuteScalar()

        Lbl_sumLegal.Text = Count_alllegal.ToString & " " & "บัญชี"

        sqll = "SELECT SUM(RFCUS.CUSBAL) FROM [FDS-SERVER].[SCBdB].[dbo].[RFCUS]"

        cmdlegal = New SqlCommand(sqll, cnLegal)
        Dim Sum_Balance As Integer = cmdlegal.ExecuteScalar()

        Lbl_Osbalance.Text = Sum_Balance.ToString("##,##0.00")



        sqll = "SELECT COUNT(dbCUS.CUSACC) [บัญชีที่ฟ้อง/(เดือน)],SUM(dbLAW.LAWSBAL) [ทุนทรัพย์รวม/(เดือน)],DATENAME(mm,DATEADD(mm,(DATEPART(MONTH,dbLAW.LAWSUE)),0)) [วันที่ฟ้อง/(เดือน)] FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE CUSOWN = 'SCB' AND CUSBUC = 'ZERO' GROUP BY GROUPING SETS((DATEPART(MONTH,dbLAW.LAWSUE)),())"
        cmdlegal = New SqlCommand(sqll, cnLegal)
        DALegal = New SqlDataAdapter(cmdlegal)
        DSLegal = New DataSet
        DALegal.Fill(DSLegal, "Grouping")


        With Dtgv_lawmonth
            .DataSource = DSLegal.Tables("Grouping")
        End With

        Dim num As Integer

        For i = 0 To Dtgv_lawmonth.RowCount - 1

            'If Integer.TryParse(Dtgv_LawMonth.Rows(i).Cells(1).Value(), num) Then
            '    Convert.ToInt32(Dtgv_LawMonth.Rows(i).Cells(1).Value())
            'End If

            If (IsNumeric(Dtgv_lawmonth.Rows(i).Cells(1).Value)) Then
                num = Dtgv_lawmonth.Rows(i).Cells(1).Value
            End If

        Next

        For Each col As DataGridViewColumn In Dtgv_lawmonth.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        sqll = "SELECT RFCUS.CUSUSA [COLLECTOR],COUNT(dbCUS.CUSACC) [จำนวนงานที่ฟ้อง]FROM [FDSSERVER_1].[Legaldb].[dbo].[dbCUS] LEFT JOIN [FDS-SERVER].[SCBdB].[dbo].[RFCUS] ON dbCUS.CUSACC = RFCUS.CUSCNO WHERE dbCUS.CUSBUC = 'ZERO' GROUP BY GROUPING SETS ((RFCUS.CUSUSA),())"
        cmdlegal = New SqlCommand(sqll, cnLegal)
        DALegal = New SqlDataAdapter(cmdlegal)
        DSLegal = New DataSet
        DALegal.Fill(DSLegal, "Groupcollector")

        With Dtgv_LawCollector

            .DataSource = DSLegal.Tables("Groupcollector")

        End With

        For Each col As DataGridViewColumn In Dtgv_LawCollector.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next



    End Sub


    Private Sub Cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        Dtgv_SCBLEGAL.Visible = True

        If Dtgv_SCBLEGAL.RowCount > 0 Then

            Dtgv_SCBLEGAL.DataSource = Nothing

        End If

        Connect_legal()

        Select Case cbo_finds.SelectedItem
            Case "ZERO" : sqll = "SELECT dbCUS.CUSOWN AS ธนาคาร, dbCUS.CUSNUM AS [สำนวน No], dbCUS.CUSACC AS หมายเลขบัญชี, dbCUS.CUSCUS AS [Ref No], dbCUS.CUSREF AS [เลขที่ LIS], dbCUS.CUSNAM AS [ชื่อ-นามสกุล], dbCUS.CUSIDC AS ID, dbCUS.CUSPRO AS Product, dbLAW.LAWSUE AS วันฟ้อง, dbLAW.LAWBLK AS คดีดำ, dbDOC.DOCAPP AS [วันที่รับเอกสาร app], dbDOC.DOCSTM AS [วันที่รับเอกสาร STM], dbCUS.CUSBUC AS Bucket, dbCUS.CUSCLS AS Class, '' AS [Type], '' AS ทุนทรัพย์รวม, dbLAW.LAWSBAL AS ทุนทรัพย์บัตร, dbLAW.LAWSPRI AS ต้นเงิน, dbLAW.LAWSINT AS ดอกเบี้ย, dbLAW.LAWSFEE AS ค่าธรรมเนียมศาล, dbLAW.LAWENF1F AS ค่าส่งคำคู่ความ, dbLAW.LAWDMED AS วันไกล่เกลีย, dbLAW.LAWTMED AS เวลาไกล่เกลี่ย, dbLAW.LAWDINV AS วันสืบ, dbLAW.LAWTINV AS เวลา, dbLAW.LAWRINV AS ผลสืบ, dbCUS.CUSSTA AS STATUS, dbLAW.LAWCOU AS ศาล, dbLAW.LAWYER AS ทนาย, dbLAW.LAWRED AS คดีแดง, dbLAW.LAWJUD AS [วันที่พิพากษา/วันที่ทำยอม], dbLAW.LAWWIT AS ถอนฟ้อง, dbLAW.LAWENF1 AS วันที่นำคำบังคับ, dbLAW.LAWENF2 AS วันออกหมายตั้ง, dbLAW.LAWENF3 AS วันออกหมายบังคับคดี, dbLAW.LAWREF AS วันแถลงงดบังคับคดี, dbLAW.LAWDREF AS วันที่คืนค่าธรรมเนียมศาล, dbLAW.LAWJREF AS จำนวนค่าธรรมเนียมศาล, dbLAW.LAWCHQ AS เลขที่เช็ค, dbLAW.LAWREP AS วันที่รายงานคำพิพากษาให้ธนาคาร, dbLAW.LAWRDOC AS [วันที่คืนเอกสารสืบให้ admin], dbLAW.LAWTYP AS ผลพิพากษา, dbLAW.LAWSEN AS คำพิพากษา, dbLAW.LAWCOM AS สัญญายอม FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE (dbCUS.CUSOWN) ='SCB' AND dbCUS.CUSBUC = 'ZERO' ORDER BY dbCUS.CUSNUM;"

            Case "ไม่ใช่ZERO" : sqll = "SELECT dbCUS.CUSOWN AS ธนาคาร, dbCUS.CUSNUM AS [สำนวน No], dbCUS.CUSACC AS หมายเลขบัญชี, dbCUS.CUSCUS AS [Ref No], dbCUS.CUSREF AS [เลขที่ LIS], dbCUS.CUSNAM AS [ชื่อ-นามสกุล], dbCUS.CUSIDC AS ID, dbCUS.CUSPRO AS Product, dbLAW.LAWSUE AS วันฟ้อง, dbLAW.LAWBLK AS คดีดำ, dbDOC.DOCAPP AS [วันที่รับเอกสาร app], dbDOC.DOCSTM AS [วันที่รับเอกสาร STM], dbCUS.CUSBUC AS Bucket, dbCUS.CUSCLS AS Class, '' AS [Type], '' AS ทุนทรัพย์รวม, dbLAW.LAWSBAL AS ทุนทรัพย์บัตร, dbLAW.LAWSPRI AS ต้นเงิน, dbLAW.LAWSINT AS ดอกเบี้ย, dbLAW.LAWSFEE AS ค่าธรรมเนียมศาล, dbLAW.LAWENF1F AS ค่าส่งคำคู่ความ, dbLAW.LAWDMED AS วันไกล่เกลีย, dbLAW.LAWTMED AS เวลาไกล่เกลี่ย, dbLAW.LAWDINV AS วันสืบ, dbLAW.LAWTINV AS เวลา, dbLAW.LAWRINV AS ผลสืบ, dbCUS.CUSSTA AS STATUS, dbLAW.LAWCOU AS ศาล, dbLAW.LAWYER AS ทนาย, dbLAW.LAWRED AS คดีแดง, dbLAW.LAWJUD AS [วันที่พิพากษา/วันที่ทำยอม], dbLAW.LAWWIT AS ถอนฟ้อง, dbLAW.LAWENF1 AS วันที่นำคำบังคับ, dbLAW.LAWENF2 AS วันออกหมายตั้ง, dbLAW.LAWENF3 AS วันออกหมายบังคับคดี, dbLAW.LAWREF AS วันแถลงงดบังคับคดี, dbLAW.LAWDREF AS วันที่คืนค่าธรรมเนียมศาล, dbLAW.LAWJREF AS จำนวนค่าธรรมเนียมศาล, dbLAW.LAWCHQ AS เลขที่เช็ค, dbLAW.LAWREP AS วันที่รายงานคำพิพากษาให้ธนาคาร, dbLAW.LAWRDOC AS [วันที่คืนเอกสารสืบให้ admin], dbLAW.LAWTYP AS ผลพิพากษา, dbLAW.LAWSEN AS คำพิพากษา, dbLAW.LAWCOM AS สัญญายอม FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE (dbCUS.CUSOWN) ='SCB' AND dbCUS.CUSBUC IS NULL ORDER BY dbCUS.CUSNUM;"

            Case "SCBงานคดีทั้งหมด" : sqll = "SELECT dbCUS.CUSOWN AS ธนาคาร, dbCUS.CUSNUM AS [สำนวน No], dbCUS.CUSACC AS หมายเลขบัญชี, dbCUS.CUSCUS AS [Ref No], dbCUS.CUSREF AS [เลขที่ LIS], dbCUS.CUSNAM AS [ชื่อ-นามสกุล], dbCUS.CUSIDC AS ID, dbCUS.CUSPRO AS Product, dbLAW.LAWSUE AS วันฟ้อง, dbLAW.LAWBLK AS คดีดำ, dbDOC.DOCAPP AS [วันที่รับเอกสาร app], dbDOC.DOCSTM AS [วันที่รับเอกสาร STM], dbCUS.CUSBUC AS Bucket, dbCUS.CUSCLS AS Class, '' AS [Type], '' AS ทุนทรัพย์รวม, dbLAW.LAWSBAL AS ทุนทรัพย์บัตร, dbLAW.LAWSPRI AS ต้นเงิน, dbLAW.LAWSINT AS ดอกเบี้ย, dbLAW.LAWSFEE AS ค่าธรรมเนียมศาล, dbLAW.LAWENF1F AS ค่าส่งคำคู่ความ, dbLAW.LAWDMED AS วันไกล่เกลีย, dbLAW.LAWTMED AS เวลาไกล่เกลี่ย, dbLAW.LAWDINV AS วันสืบ, dbLAW.LAWTINV AS เวลา, dbLAW.LAWRINV AS ผลสืบ, dbCUS.CUSSTA AS STATUS, dbLAW.LAWCOU AS ศาล, dbLAW.LAWYER AS ทนาย, dbLAW.LAWRED AS คดีแดง, dbLAW.LAWJUD AS [วันที่พิพากษา/วันที่ทำยอม], dbLAW.LAWWIT AS ถอนฟ้อง, dbLAW.LAWENF1 AS วันที่นำคำบังคับ, dbLAW.LAWENF2 AS วันออกหมายตั้ง, dbLAW.LAWENF3 AS วันออกหมายบังคับคดี, dbLAW.LAWREF AS วันแถลงงดบังคับคดี, dbLAW.LAWDREF AS วันที่คืนค่าธรรมเนียมศาล, dbLAW.LAWJREF AS จำนวนค่าธรรมเนียมศาล, dbLAW.LAWCHQ AS เลขที่เช็ค, dbLAW.LAWREP AS วันที่รายงานคำพิพากษาให้ธนาคาร, dbLAW.LAWRDOC AS [วันที่คืนเอกสารสืบให้ admin], dbLAW.LAWTYP AS ผลพิพากษา, dbLAW.LAWSEN AS คำพิพากษา, dbLAW.LAWCOM AS สัญญายอม FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE (dbCUS.CUSOWN) ='SCB' ORDER BY dbCUS.CUSNUM;"

        End Select

        cmdlegal = New SqlCommand(sqll, cnLegal)
        DALegal = New SqlDataAdapter(cmdlegal)
        DSLegal = New DataSet
        DALegal.Fill(DSLegal, "Sort")

        With Dtgv_SCBLEGAL
            .DataSource = DSLegal.Tables("sort")
        End With



    End Sub

    Private Sub Dtgv_LawCollector_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgv_LawCollector.CellClick

        If Dtgv_LawRinv.Rows.Count = 0 Then

            LinkRinv()
            LinkRinvDetail()

        Else

            Dtgv_LawRinv.DataSource = Nothing

        End If

    End Sub

    Private Sub LinkRinv()

        Connect_legal()

        sql = $"SELECT RFCUS.CUSUSA [COLLECTOR],COUNT(dbCUS.CUSACC) [จำนวนบัญชี/พิพากษา],DATENAME(mm,DATEADD(mm,(DATEPART(MONTH,dbLAW.LAWJUD)),0)) [เดือนที่พิพากษา/วันที่ทำยอม],dbLAW.LAWRINV AS ผลสืบ FROM [FDSSERVER_1].[Legaldb].[dbo].[dbCUS] INNER JOIN [FDSSERVER_1].[Legaldb].[dbo].[dbLAW] ON dbCUS.CUSACC = dbLAW.LAWACC INNER JOIN [FDS-SERVER].[SCBdB].[dbo].[RFCUS] ON dbCUS.CUSACC = RFCUS.CUSCNO WHERE dbCUS.CUSBUC = 'ZERO' AND RFCUS.CUSUSA = '{Dtgv_LawCollector.CurrentRow.Cells(0).Value}' GROUP BY GROUPING SETS ((RFCUS.CUSUSA,dbLAW.LAWRINV,(DATEPART(MONTH,dbLAW.LAWJUD))),()) ORDER BY DATENAME(mm,DATEADD(mm,(DATEPART(MONTH,dbLAW.LAWJUD)),0)) ASC"

        cmd = New SqlCommand(sql, cnLegal)
        DALegal = New SqlDataAdapter(cmd)
        DSLegal = New DataSet
        DALegal.Fill(DSLegal, "GroupRinv")

        With Dtgv_LawRinv

            .DataSource = DSLegal.Tables("GroupRinv")

        End With

        For Each col As DataGridViewColumn In Dtgv_LawCollector.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next


    End Sub

    Private Sub LinkRinvDetail()

        sql = $"SELECT dbCUS.CUSOWN AS ธนาคาร, dbCUS.CUSNUM AS [สำนวน No], dbCUS.CUSACC AS หมายเลขบัญชี, dbCUS.CUSCUS AS [Ref No], dbCUS.CUSREF AS [เลขที่ LIS], dbCUS.CUSNAM AS [ชื่อ-นามสกุล], dbCUS.CUSIDC AS ID, dbCUS.CUSPRO AS Product, dbLAW.LAWSUE AS วันฟ้อง, dbLAW.LAWBLK AS คดีดำ, dbDOC.DOCAPP AS [วันที่รับเอกสาร app], dbDOC.DOCSTM AS [วันที่รับเอกสาร STM], dbCUS.CUSBUC AS Bucket, dbCUS.CUSCLS AS Class, '' AS Type, '' AS ทุนทรัพย์รวม, dbLAW.LAWSBAL AS ทุนทรัพย์บัตร, dbLAW.LAWSPRI AS ต้นเงิน, dbLAW.LAWSINT AS ดอกเบี้ย, dbLAW.LAWSFEE AS ค่าธรรมเนียมศาล, dbLAW.LAWENF1F AS ค่าส่งคำคู่ความ, dbLAW.LAWDMED AS วันไกล่เกลีย, dbLAW.LAWTMED AS เวลาไกล่เกลี่ย, dbLAW.LAWDINV AS วันสืบ, dbLAW.LAWTINV AS เวลา, dbLAW.LAWRINV AS ผลสืบ, dbCUS.CUSSTA AS STATUS, dbLAW.LAWCOU AS ศาล, dbLAW.LAWYER AS ทนาย, dbLAW.LAWRED AS คดีแดง, dbLAW.LAWJUD AS [วันที่พิพากษา/วันที่ทำยอม], dbLAW.LAWWIT AS ถอนฟ้อง, dbLAW.LAWENF1 AS วันที่นำคำบังคับ, dbLAW.LAWENF2 AS วันออกหมายตั้ง, dbLAW.LAWENF3 AS วันออกหมายบังคับคดี, dbLAW.LAWREF AS วันแถลงงดบังคับคดี, dbLAW.LAWDREF AS วันที่คืนค่าธรรมเนียมศาล, dbLAW.LAWJREF AS จำนวนค่าธรรมเนียมศาล, dbLAW.LAWCHQ AS เลขที่เช็ค, dbLAW.LAWREP AS วันที่รายงานคำพิพากษาให้ธนาคาร, dbLAW.LAWRDOC AS [วันที่คืนเอกสารสืบให้ admin], dbLAW.LAWTYP AS ผลพิพากษา, dbLAW.LAWSEN AS คำพิพากษา, dbLAW.LAWCOM AS สัญญายอม,RFCUS.CUSUSA 
          FROM FDSSERVER_1.LegaldB.dbo.dbCUS LEFT JOIN FDSSERVER_1.LegaldB.dbo.dbLAW On dbCUS.CUSACC = dbLAW.LAWACC LEFT JOIN FDSSERVER_1.LegaldB.dbo.dbDOC On dbCUS.CUSACC = dbDOC.DOCACC INNER JOIN [FDS-SERVER].[SCBdB].[dbo].[RFCUS] ON dbCUS.CUSACC = RFCUS.CUSCNO WHERE (dbCUS.CUSOWN) ='SCB' AND dbCUS.CUSBUC = 'ZERO' AND RFCUS.CUSUSA = '{Dtgv_LawCollector.CurrentRow.Cells(0).Value}' ORDER BY dbLAW.LAWSUE DESC;"

        cmd = New SqlCommand(sql, cnLegal)
        DALegal = New SqlDataAdapter(cmd)
        DSLegal = New DataSet
        DALegal.Fill(DSLegal, "GroupRinv")

        With Dtgv_SCBLEGAL

            .DataSource = DSLegal.Tables("GroupRinv")

        End With


    End Sub

    Private Sub Cmd_ExportExcel_Click(sender As Object, e As EventArgs) Handles Cmd_ExportExcel.Click

    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    'Private Sub CreateExcelFile()

    'Imports Excel = Microsoft.Office.Interop.Excel
    'Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
    'Imports Microsoft.Office.Interop

    '    Dim xlapp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()

    '    If xlapp Is Nothing Then
    '        Msg_error("Excel is not properly installed")
    '        Return
    '    End If

    '    Dim xlWorkBook As Excel.Workbook
    '    Dim xlWorkSheet As Excel.Worksheet
    '    Dim misvalue As Object = System.Reflection.Missing.Value

    '    xlWorkBook = xlapp.Workbooks.Add(misvalue)
    '    xlWorkSheet = xlWorkBook.Sheets("Sheet1")
    '    xlWorkSheet.Cells(1, 1) = "Sheet 1 content"

    '    xlWorkBook.SaveAs("d:\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue,
    '     Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue)
    '    xlWorkBook.Close(True, misvalue, misvalue)
    '    xlapp.Quit()

    '    releaseObject(xlWorkSheet)
    '    releaseObject(xlWorkBook)
    '    releaseObject(xlapp)

    '    MessageBox.Show("Excel file created , you can find the file d:\csharp-Excel.xls")
    'End Sub



End Class