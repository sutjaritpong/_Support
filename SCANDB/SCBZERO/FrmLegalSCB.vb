Option Explicit On
Imports System.Data.SqlClient
Public Class FrmLegalSCB
    Private Sub FrmLegalSCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Lbl_LegalSCB.Text = Count_nonzero.ToString & " " & "บัญชี"

        sqll = "SELECT COUNT(*) FROM dbCUS WHERE CUSOWN = 'SCB';"
        cmdlegal = New SqlCommand(sqll, cnLegal)
        Dim Count_alllegal As Integer = cmdlegal.ExecuteScalar()

        Lbl_SumLegal.Text = Count_alllegal.ToString & " " & "บัญชี"

        sqll = "SELECT COUNT(CUSACC)  FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE (dbCUS.CUSOWN) ='SCB' AND dbCUS.CUSBUC = 'ZERO' AND  ORDER BY dbCUS.CUSNUM;"


        sqll = "SELECT COUNT(dbCUS.CUSACC) [บัญชีที่ฟ้อง/(เดือน)],SUM(dbLAW.LAWSBAL) [ทุนทรัพย์รวม/(เดือน)],DATEPART(MONTH,dbLAW.LAWSUE) [วันที่ฟ้อง/(เดือน)] FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE CUSOWN = 'SCB' AND CUSBUC = 'ZERO' GROUP BY GROUPING SETS((DATEPART(MONTH,dbLAW.LAWSUE)),())"
        cmdlegal = New SqlCommand(sqll, cnLegal)
        DALegal = New SqlDataAdapter(cmdlegal)
        DSLegal = New DataSet
        DALegal.Fill(DSLegal, "Grouping")


        With Dtgv_Lawmonth
            .DataSource = DSLegal.Tables("Grouping")
        End With

        'For i = 0 To Dtgv_Lawmonth.RowCount - 1
        '    Dtgv_Lawmonth.Rows(i).Cells(1).Value = CDbl(Dtgv_Lawmonth.Rows(i).Cells(1).Value).ToString("##,##0.00")
        'Next

    End Sub

    Private Sub Cmd_finds_Click(sender As Object, e As EventArgs) Handles cmd_finds.Click

        Dtgv_SCBLEGAL.Visible = True

        If Dtgv_SCBLEGAL.RowCount > 0 Then

            Dtgv_SCBLEGAL.DataSource = Nothing

        End If

        Connect_legal()

        Select Case cbo_finds.SelectedItem
            Case "ZERO" : sqll = "SELECT dbCUS.CUSOWN AS ธนาคาร, dbCUS.CUSNUM AS [สำนวน No], dbCUS.CUSACC AS หมายเลขบัญชี, dbCUS.CUSCUS AS [Ref No], dbCUS.CUSREF AS [เลขที่ LIS], dbCUS.CUSNAM AS [ชื่อ-นามสกุล], dbCUS.CUSIDC AS ID, dbCUS.CUSPRO AS Product, dbLAW.LAWSUE AS วันฟ้อง, dbLAW.LAWBLK AS คดีดำ, dbDOC.DOCAPP AS [วันที่รับเอกสาร app], dbDOC.DOCSTM AS [วันที่รับเอกสาร STM], dbCUS.CUSBUC AS Bucket, dbCUS.CUSCLS AS Class, '' AS Type, '' AS ทุนทรัพย์รวม, dbLAW.LAWSBAL AS ทุนทรัพย์บัตร, dbLAW.LAWSPRI AS ต้นเงิน, dbLAW.LAWSINT AS ดอกเบี้ย, dbLAW.LAWSFEE AS ค่าธรรมเนียมศาล, dbLAW.LAWENF1F AS ค่าส่งคำคู่ความ, dbLAW.LAWDMED AS วันไกล่เกลีย, dbLAW.LAWTMED AS เวลาไกล่เกลี่ย, dbLAW.LAWDINV AS วันสืบ, dbLAW.LAWTINV AS เวลา, dbLAW.LAWRINV AS ผลสืบ, dbCUS.CUSSTA AS STATUS, dbLAW.LAWCOU AS ศาล, dbLAW.LAWYER AS ทนาย, dbLAW.LAWRED AS คดีแดง, dbLAW.LAWJUD AS [วันที่พิพากษา/วันที่ทำยอม], dbLAW.LAWWIT AS ถอนฟ้อง, dbLAW.LAWENF1 AS วันที่นำคำบังคับ, dbLAW.LAWENF2 AS วันออกหมายตั้ง, dbLAW.LAWENF3 AS วันออกหมายบังคับคดี, dbLAW.LAWREF AS วันแถลงงดบังคับคดี, dbLAW.LAWDREF AS วันที่คืนค่าธรรมเนียมศาล, dbLAW.LAWJREF AS จำนวนค่าธรรมเนียมศาล, dbLAW.LAWCHQ AS เลขที่เช็ค, dbLAW.LAWREP AS วันที่รายงานคำพิพากษาให้ธนาคาร, dbLAW.LAWRDOC AS [วันที่คืนเอกสารสืบให้ admin], dbLAW.LAWTYP AS ผลพิพากษา, dbLAW.LAWSEN AS คำพิพากษา, dbLAW.LAWCOM AS สัญญายอม FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE (dbCUS.CUSOWN) ='SCB' AND dbCUS.CUSBUC = 'ZERO' ORDER BY dbCUS.CUSNUM;"

            Case "ไม่ใช่ZERO" : sqll = sqll = "SELECT dbCUS.CUSOWN AS ธนาคาร, dbCUS.CUSNUM AS [สำนวน No], dbCUS.CUSACC AS หมายเลขบัญชี, dbCUS.CUSCUS AS [Ref No], dbCUS.CUSREF AS [เลขที่ LIS], dbCUS.CUSNAM AS [ชื่อ-นามสกุล], dbCUS.CUSIDC AS ID, dbCUS.CUSPRO AS Product, dbLAW.LAWSUE AS วันฟ้อง, dbLAW.LAWBLK AS คดีดำ, dbDOC.DOCAPP AS [วันที่รับเอกสาร app], dbDOC.DOCSTM AS [วันที่รับเอกสาร STM], dbCUS.CUSBUC AS Bucket, dbCUS.CUSCLS AS Class, '' AS Type, '' AS ทุนทรัพย์รวม, dbLAW.LAWSBAL AS ทุนทรัพย์บัตร, dbLAW.LAWSPRI AS ต้นเงิน, dbLAW.LAWSINT AS ดอกเบี้ย, dbLAW.LAWSFEE AS ค่าธรรมเนียมศาล, dbLAW.LAWENF1F AS ค่าส่งคำคู่ความ, dbLAW.LAWDMED AS วันไกล่เกลีย, dbLAW.LAWTMED AS เวลาไกล่เกลี่ย, dbLAW.LAWDINV AS วันสืบ, dbLAW.LAWTINV AS เวลา, dbLAW.LAWRINV AS ผลสืบ, dbCUS.CUSSTA AS STATUS, dbLAW.LAWCOU AS ศาล, dbLAW.LAWYER AS ทนาย, dbLAW.LAWRED AS คดีแดง, dbLAW.LAWJUD AS [วันที่พิพากษา/วันที่ทำยอม], dbLAW.LAWWIT AS ถอนฟ้อง, dbLAW.LAWENF1 AS วันที่นำคำบังคับ, dbLAW.LAWENF2 AS วันออกหมายตั้ง, dbLAW.LAWENF3 AS วันออกหมายบังคับคดี, dbLAW.LAWREF AS วันแถลงงดบังคับคดี, dbLAW.LAWDREF AS วันที่คืนค่าธรรมเนียมศาล, dbLAW.LAWJREF AS จำนวนค่าธรรมเนียมศาล, dbLAW.LAWCHQ AS เลขที่เช็ค, dbLAW.LAWREP AS วันที่รายงานคำพิพากษาให้ธนาคาร, dbLAW.LAWRDOC AS [วันที่คืนเอกสารสืบให้ admin], dbLAW.LAWTYP AS ผลพิพากษา, dbLAW.LAWSEN AS คำพิพากษา, dbLAW.LAWCOM AS สัญญายอม FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE (dbCUS.CUSOWN) ='SCB' AND dbCUS.CUSBUC IS NULL ORDER BY dbCUS.CUSNUM;"

            Case "SCBงานคดีทั้งหมด" : sqll = sqll = "SELECT dbCUS.CUSOWN AS ธนาคาร, dbCUS.CUSNUM AS [สำนวน No], dbCUS.CUSACC AS หมายเลขบัญชี, dbCUS.CUSCUS AS [Ref No], dbCUS.CUSREF AS [เลขที่ LIS], dbCUS.CUSNAM AS [ชื่อ-นามสกุล], dbCUS.CUSIDC AS ID, dbCUS.CUSPRO AS Product, dbLAW.LAWSUE AS วันฟ้อง, dbLAW.LAWBLK AS คดีดำ, dbDOC.DOCAPP AS [วันที่รับเอกสาร app], dbDOC.DOCSTM AS [วันที่รับเอกสาร STM], dbCUS.CUSBUC AS Bucket, dbCUS.CUSCLS AS Class, '' AS Type, '' AS ทุนทรัพย์รวม, dbLAW.LAWSBAL AS ทุนทรัพย์บัตร, dbLAW.LAWSPRI AS ต้นเงิน, dbLAW.LAWSINT AS ดอกเบี้ย, dbLAW.LAWSFEE AS ค่าธรรมเนียมศาล, dbLAW.LAWENF1F AS ค่าส่งคำคู่ความ, dbLAW.LAWDMED AS วันไกล่เกลีย, dbLAW.LAWTMED AS เวลาไกล่เกลี่ย, dbLAW.LAWDINV AS วันสืบ, dbLAW.LAWTINV AS เวลา, dbLAW.LAWRINV AS ผลสืบ, dbCUS.CUSSTA AS STATUS, dbLAW.LAWCOU AS ศาล, dbLAW.LAWYER AS ทนาย, dbLAW.LAWRED AS คดีแดง, dbLAW.LAWJUD AS [วันที่พิพากษา/วันที่ทำยอม], dbLAW.LAWWIT AS ถอนฟ้อง, dbLAW.LAWENF1 AS วันที่นำคำบังคับ, dbLAW.LAWENF2 AS วันออกหมายตั้ง, dbLAW.LAWENF3 AS วันออกหมายบังคับคดี, dbLAW.LAWREF AS วันแถลงงดบังคับคดี, dbLAW.LAWDREF AS วันที่คืนค่าธรรมเนียมศาล, dbLAW.LAWJREF AS จำนวนค่าธรรมเนียมศาล, dbLAW.LAWCHQ AS เลขที่เช็ค, dbLAW.LAWREP AS วันที่รายงานคำพิพากษาให้ธนาคาร, dbLAW.LAWRDOC AS [วันที่คืนเอกสารสืบให้ admin], dbLAW.LAWTYP AS ผลพิพากษา, dbLAW.LAWSEN AS คำพิพากษา, dbLAW.LAWCOM AS สัญญายอม FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE (dbCUS.CUSOWN) ='SCB' ORDER BY dbCUS.CUSNUM;"

        End Select

        cmdlegal = New SqlCommand(sqll, cnLegal)
        DALegal = New SqlDataAdapter(cmdlegal)
        DSLegal = New DataSet
        DALegal.Fill(DSLegal, "Sort")

        With Dtgv_SCBLEGAL
            .DataSource = DSLegal.Tables("sort")
        End With

    End Sub

End Class