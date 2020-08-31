Imports System.Data.SqlClient
Imports System.Data
Module VBdatabase
    'ช่วยให้การ เพิ่ม ลบ แก้ไข แสดง ข้อมูลจาก Database เป็นเรื่องสะดวกรวดเร็วยิ่งขึ้น
#Region "ประกาศตัวแปร"
    'Friend cn As New SqlConnection("Data Source=FDS061;Initial Catalog=ScanPDF;Integrated Security=True")
    Friend cn As New SqlConnection("SERVER=FDSSERVER_1;Initial Catalog=ScanPDF;Persist Security Info=True;User ID=sa;Password=1971;")
    Friend cmd As New SqlCommand
    Friend DA As New SqlDataAdapter
    Friend DS As New DataSet
    Friend DT As New DataTable
    Friend DR As SqlDataReader

    Friend sql As String = ""
    Friend _sql As String = ""
    Friend sqll As String = ""

    Friend cnLegal As New SqlConnection("SERVER= FDSSERVER_1;Initial Catalog=LegaldB;Persist Security Info=True;User ID=sa;Password=1971;")
    Friend cmdlegal As New SqlCommand
    Friend DALegal As New SqlDataAdapter
    Friend DSLegal As New DataSet
    Friend DTLegal As New DataTable
    Friend DRLegal As SqlDataReader

    Friend cn_SCB As New SqlConnection("SERVER=FDS-SERVER;Initial Catalog=SCBdB;Persist Security Info=True;User ID=sa;Password=1971;")
    Friend cn_KKB As New SqlConnection("SERVER=FDS-SERVER;Initial Catalog=KKBdB;Persist Security Info=True;User ID=sa;Password=1971;")
    Friend cn_TMB As New SqlConnection("SERVER=FDS-SERVER;Initial Catalog=TMBdB;Persist Security Info=True;User ID=sa;Password=1971;")
    Friend cn_UOB As New SqlConnection("SERVER=FDS-SERVER;Initial Catalog=UOBdB;Persist Security Info=True;User ID=sa;Password=1971;")
    Friend cn_GE As New SqlConnection("SERVER=FDS-SERVER;Initial Catalog=GEdB;Persist Security Info=True;User ID=sa;Password=1971;")
    Friend cn_KBANK As New SqlConnection("SERVER=FDS-SERVER;Initial Catalog=KBANKdB;Persist Security Info=True;User ID=sa;Password=1971;")
    Friend cn_TMBSME As New SqlConnection("SERVER=FDS-SERVER;Initial Catalog=TMBSMEdB;Persist Security Info=True;User ID=sa;Password=1971;")
    Friend cn_TBANK As New SqlConnection("SERVER=FDS-SERVER;Initial Catalog=TBANKdB;Persist Security Info=True;User ID=sa;Password=1971;")

    Friend cmd_Collec As New SqlCommand
    Friend DA_Collec As New SqlDataAdapter
    Friend DS_Collec As New DataSet
    Friend DT_Collec As New DataTable
    Friend DR_Collec As SqlDataReader



#End Region

#Region "Code ที่ใช้เกี่ยวกับฐานข้อมูล"
    '''' <summary>
    '''' เปิดใช้งานฐานข้อมูล LegaldB
    '''' </summary>
    '''' <remarks></remarks>
    Friend Sub Connect_(ConnectdB As Object)
        Try
            If ConnectdB.State = ConnectionState.Closed Then ConnectdB.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '''' <summary>
    '''' เปิดใช้งานฐานข้อมูล LegaldB
    '''' </summary>
    '''' <remarks></remarks>
    Friend Sub Connect_legal()
        Try
            If cnLegal.State = ConnectionState.Closed Then cnLegal.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' เปิดใช้งานฐานข้อมูล
    ''' </summary>
    ''' <remarks></remarks>
    Friend Sub Connect()
        Try
            If cn.State = ConnectionState.Closed Then cn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' รับค่า Return จากฐานข้อมูล เป็นผลการดำเนินการคำสั่ง sql  ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร sql ก่อน
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function Cmd_excuteNonquery()
        Connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery
    End Function
    ''' <summary>
    ''' รับข้อมูล Return จากฐานข้อมูล เป็นข้อมูลค่าเดียว ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร sql ก่อน
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function Cmd_excuteScalar()
        Connect()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar()
    End Function
    ''' <summary>
    ''' ดึงข้อมูลจากฐานข้อมูลไปแสดงใน DataGridView ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร sql ก่อน
    ''' </summary>
    ''' <param name="your_datagridView">ชื่อของ DataGrid ที่จะให้แสดงข้อมูล</param>
    ''' <remarks> ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร sql ก่อน</remarks>
    Friend Sub Cmd_excuteToDataGridView(your_datagridView As DataGridView)
        Connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        your_datagridView.DataSource = DS.Tables("table")
    End Sub
    ''' <summary>
    ''' ดึงข้อมูลจากฐานข้อมูลมาเก็บไว้ ใน DataTable ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร sql ก่อน
    ''' </summary>
    ''' <returns>DataTable</returns>
    ''' <remarks></remarks>
    Friend Function Cmd_excuteToDataTable()
        Connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS.Tables("table")
    End Function
    ''' <summary>
    ''' ดึงข้อมูลจากฐานข้อมูลมาเก็บไว้ ใน DataSet ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร sql ก่อน
    ''' </summary>
    ''' <returns>DataSet</returns>
    ''' <remarks></remarks>
    Friend Function Cmd_excuteToDataSet()
        Connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Return DS
    End Function

    ''' <summary>
    ''' ดึงข้อมูลในฐานข้อมูลมาแสดงใน ComboBox หรือ Listbox ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร sql ก่อน
    ''' </summary>
    ''' <param name="your_comboBox_or_ListBox">ชื่อ combobox หรือ listbox ที่ต้องการให้แสดงข้อมูล</param>
    ''' <remarks></remarks>
    Friend Sub Cmd_excuteComboBoxAndListBox(your_comboBox_or_ListBox As Object)
        Connect()
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()
        your_comboBox_or_ListBox.Items.Clear()
        While DR.Read
            your_comboBox_or_ListBox.Items.Add(DR(0))
        End While
        DR.Close()
    End Sub

    ''' <summary>
    ''' ดึงรูปภาพออกมาจากฐานข้อมูล และแสดงไปยัง PictureBox ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร sql ก่อน
    ''' </summary>
    ''' <param name="Your_PictureBox">ชื่อของ Picture ที่คุณจะให้รูปภาพแสดง</param>
    ''' <remarks></remarks>
    Friend Sub Cmd_excuteImageToPictureBox(Your_PictureBox As PictureBox)
        Connect()
        cmd = New SqlCommand(sql, cn)
        Dim imageData() As Byte = cmd.ExecuteScalar()
        Your_PictureBox.Image = Image.FromStream(New IO.MemoryStream(CType(imageData, Byte())))
    End Sub

    ''' <summary>
    ''' ดึงรูปภาพออกมาจากฐานข้อมูล ให้กำหนดคำสั่ง query ข้อมูลในตัวแปร sql ก่อน"
    ''' </summary>
    ''' <returns>Image</returns>
    ''' <remarks></remarks>
    Friend Function Cmd_excuteImage() As Image
        Connect()
        Dim imageData() As Byte = Cmd_excuteScalar(sql)
        Return Image.FromStream(New IO.MemoryStream(CType(imageData, Byte())))
    End Function
    ''' <summary>
    ''' แปลงภาพใน PictureBox เพื่อบันทึกลงฐานข้อมูล ต้องใช้ผ่าน Parameters.AddWithValue
    ''' </summary>
    ''' <param name="your_pictureBox">ชื่อ PictureBox ของคุณที่จะแปลงภาพ</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function Convert_PictureBox_toDatabase(your_pictureBox As PictureBox)
        Dim memmory As New IO.MemoryStream
        your_pictureBox.Image.Save(memmory, Imaging.ImageFormat.Bmp)
        Dim pic_ready() As Byte = memmory.ToArray()
        Return pic_ready.ToArray()
    End Function
#End Region
End Module
'Option Explicit On
'Imports System.Data.SqlClient
'Public Class FrmLegalSCB
'    Private Sub FrmLegalSCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        Dim Clockmonth As DateTime = DateTime.Now.AddMonths(-1).AddDays(1)
'        Console.WriteLine(Clockmonth)
'        Dim Clockafter As DateTime = DateTime.Now.AddMonths(0)
'        Console.WriteLine(Clockafter)


'        Connect_legal()

'        Dim Typescb() As String = {"ZERO", "ไม่ใช่ZERO", "SCBงานคดีทั้งหมด"}

'        cbo_finds.Items.Clear()

'        cbo_finds.Items.AddRange(Typescb)

'        cbo_finds.SelectedIndex = 0

'        sqll = "SELECT COUNT(*) FROM dbCUS WHERE CUSOWN = 'SCB' AND CUSBUC = 'ZERO';"
'        cmdlegal = New SqlCommand(sqll, cnLegal)
'        Dim Count_zero As Integer = cmdlegal.ExecuteScalar()

'        Lbl_Legalzero.Text = Count_zero.ToString & " " & "บัญชี"

'        sqll = "SELECT COUNT(*) FROM dbCUS WHERE CUSOWN = 'SCB' AND CUSBUC IS NULL;"
'        cmdlegal = New SqlCommand(sqll, cnLegal)
'        Dim Count_nonzero As Integer = cmdlegal.ExecuteScalar()

'        Lbl_LegalSCB.Text = Count_nonzero.ToString & " " & "บัญชี"

'        sqll = "SELECT COUNT(*) FROM dbCUS WHERE CUSOWN = 'SCB';"
'        cmdlegal = New SqlCommand(sqll, cnLegal)
'        Dim Count_alllegal As Integer = cmdlegal.ExecuteScalar()

'        Lbl_SumLegal.Text = Count_alllegal.ToString & " " & "บัญชี"

'        sqll = "SELECT COUNT(dbCUS.CUSACC) [บัญชีที่ฟ้อง/(เดือน)],SUM(dbLAW.LAWSBAL) [ทุนทรัพย์รวม/(เดือน)],DATENAME(mm,DATEADD(mm,(DATEPART(MONTH,dbLAW.LAWSUE)),0)) [วันที่ฟ้อง/(เดือน)] FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE CUSOWN = 'SCB' AND CUSBUC = 'ZERO' GROUP BY GROUPING SETS((DATEPART(MONTH,dbLAW.LAWSUE)),())"
'        cmdlegal = New SqlCommand(sqll, cnLegal)
'        DALegal = New SqlDataAdapter(cmdlegal)
'        DSLegal = New DataSet
'        DALegal.Fill(DSLegal, "Grouping")


'        With Dtgv_LawMonth
'            .DataSource = DSLegal.Tables("Grouping")
'        End With

'        Dim num As Integer

'        For i = 0 To Dtgv_LawMonth.RowCount - 1

'            'If Integer.TryParse(Dtgv_LawMonth.Rows(i).Cells(1).Value(), num) Then
'            '    Convert.ToInt32(Dtgv_LawMonth.Rows(i).Cells(1).Value())
'            'End If

'            If (IsNumeric(Dtgv_LawMonth.Rows(i).Cells(1).Value)) Then
'                num = Dtgv_LawMonth.Rows(i).Cells(1).Value
'            End If

'        Next

'        For Each col As DataGridViewColumn In Dtgv_LawMonth.Columns
'            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
'        Next

'        sqll = "SELECT RFCUS.CUSUSA [COLLECTOR],COUNT(dbCUS.CUSACC) [จำนวนงานที่ฟ้อง]FROM [FDSSERVER_1].[Legaldb].[dbo].[dbCUS] INNER JOIN [FDS-SERVER].[SCBdB].[dbo].[RFCUS] ON dbCUS.CUSACC = RFCUS.CUSCNO WHERE dbCUS.CUSBUC = 'ZERO' GROUP BY GROUPING SETS ((RFCUS.CUSUSA),())"
'        cmdlegal = New SqlCommand(sqll, cnLegal)
'        DALegal = New SqlDataAdapter(cmdlegal)
'        DSLegal = New DataSet
'        DALegal.Fill(DSLegal, "Groupcollector")

'        With Dtgv_LawCollector

'            .DataSource = DSLegal.Tables("Groupcollector")

'        End With

'        For Each col As DataGridViewColumn In Dtgv_LawCollector.Columns
'            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
'        Next



'    End Sub

'    Private Sub Cmd_finds_Click(sender As Object, e As EventArgs) Handles cmd_finds.Click

'        Dtgv_SCBLEGAL.Visible = True

'        If Dtgv_SCBLEGAL.RowCount > 0 Then

'            Dtgv_SCBLEGAL.DataSource = Nothing

'        End If

'        Connect_legal()

'        Select Case cbo_finds.SelectedItem
'            Case "ZERO" : sqll = "SELECT dbCUS.CUSOWN AS ธนาคาร, dbCUS.CUSNUM AS [สำนวน No], dbCUS.CUSACC AS หมายเลขบัญชี, dbCUS.CUSCUS AS [Ref No], dbCUS.CUSREF AS [เลขที่ LIS], dbCUS.CUSNAM AS [ชื่อ-นามสกุล], dbCUS.CUSIDC AS ID, dbCUS.CUSPRO AS Product, dbLAW.LAWSUE AS วันฟ้อง, dbLAW.LAWBLK AS คดีดำ, dbDOC.DOCAPP AS [วันที่รับเอกสาร app], dbDOC.DOCSTM AS [วันที่รับเอกสาร STM], dbCUS.CUSBUC AS Bucket, dbCUS.CUSCLS AS Class, '' AS Type, '' AS ทุนทรัพย์รวม, dbLAW.LAWSBAL AS ทุนทรัพย์บัตร, dbLAW.LAWSPRI AS ต้นเงิน, dbLAW.LAWSINT AS ดอกเบี้ย, dbLAW.LAWSFEE AS ค่าธรรมเนียมศาล, dbLAW.LAWENF1F AS ค่าส่งคำคู่ความ, dbLAW.LAWDMED AS วันไกล่เกลีย, dbLAW.LAWTMED AS เวลาไกล่เกลี่ย, dbLAW.LAWDINV AS วันสืบ, dbLAW.LAWTINV AS เวลา, dbLAW.LAWRINV AS ผลสืบ, dbCUS.CUSSTA AS STATUS, dbLAW.LAWCOU AS ศาล, dbLAW.LAWYER AS ทนาย, dbLAW.LAWRED AS คดีแดง, dbLAW.LAWJUD AS [วันที่พิพากษา/วันที่ทำยอม], dbLAW.LAWWIT AS ถอนฟ้อง, dbLAW.LAWENF1 AS วันที่นำคำบังคับ, dbLAW.LAWENF2 AS วันออกหมายตั้ง, dbLAW.LAWENF3 AS วันออกหมายบังคับคดี, dbLAW.LAWREF AS วันแถลงงดบังคับคดี, dbLAW.LAWDREF AS วันที่คืนค่าธรรมเนียมศาล, dbLAW.LAWJREF AS จำนวนค่าธรรมเนียมศาล, dbLAW.LAWCHQ AS เลขที่เช็ค, dbLAW.LAWREP AS วันที่รายงานคำพิพากษาให้ธนาคาร, dbLAW.LAWRDOC AS [วันที่คืนเอกสารสืบให้ admin], dbLAW.LAWTYP AS ผลพิพากษา, dbLAW.LAWSEN AS คำพิพากษา, dbLAW.LAWCOM AS สัญญายอม FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE (dbCUS.CUSOWN) ='SCB' AND dbCUS.CUSBUC = 'ZERO' ORDER BY dbCUS.CUSNUM;"

'            Case "ไม่ใช่ZERO" : sqll = sqll = "SELECT dbCUS.CUSOWN AS ธนาคาร, dbCUS.CUSNUM AS [สำนวน No], dbCUS.CUSACC AS หมายเลขบัญชี, dbCUS.CUSCUS AS [Ref No], dbCUS.CUSREF AS [เลขที่ LIS], dbCUS.CUSNAM AS [ชื่อ-นามสกุล], dbCUS.CUSIDC AS ID, dbCUS.CUSPRO AS Product, dbLAW.LAWSUE AS วันฟ้อง, dbLAW.LAWBLK AS คดีดำ, dbDOC.DOCAPP AS [วันที่รับเอกสาร app], dbDOC.DOCSTM AS [วันที่รับเอกสาร STM], dbCUS.CUSBUC AS Bucket, dbCUS.CUSCLS AS Class, '' AS Type, '' AS ทุนทรัพย์รวม, dbLAW.LAWSBAL AS ทุนทรัพย์บัตร, dbLAW.LAWSPRI AS ต้นเงิน, dbLAW.LAWSINT AS ดอกเบี้ย, dbLAW.LAWSFEE AS ค่าธรรมเนียมศาล, dbLAW.LAWENF1F AS ค่าส่งคำคู่ความ, dbLAW.LAWDMED AS วันไกล่เกลีย, dbLAW.LAWTMED AS เวลาไกล่เกลี่ย, dbLAW.LAWDINV AS วันสืบ, dbLAW.LAWTINV AS เวลา, dbLAW.LAWRINV AS ผลสืบ, dbCUS.CUSSTA AS STATUS, dbLAW.LAWCOU AS ศาล, dbLAW.LAWYER AS ทนาย, dbLAW.LAWRED AS คดีแดง, dbLAW.LAWJUD AS [วันที่พิพากษา/วันที่ทำยอม], dbLAW.LAWWIT AS ถอนฟ้อง, dbLAW.LAWENF1 AS วันที่นำคำบังคับ, dbLAW.LAWENF2 AS วันออกหมายตั้ง, dbLAW.LAWENF3 AS วันออกหมายบังคับคดี, dbLAW.LAWREF AS วันแถลงงดบังคับคดี, dbLAW.LAWDREF AS วันที่คืนค่าธรรมเนียมศาล, dbLAW.LAWJREF AS จำนวนค่าธรรมเนียมศาล, dbLAW.LAWCHQ AS เลขที่เช็ค, dbLAW.LAWREP AS วันที่รายงานคำพิพากษาให้ธนาคาร, dbLAW.LAWRDOC AS [วันที่คืนเอกสารสืบให้ admin], dbLAW.LAWTYP AS ผลพิพากษา, dbLAW.LAWSEN AS คำพิพากษา, dbLAW.LAWCOM AS สัญญายอม FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE (dbCUS.CUSOWN) ='SCB' AND dbCUS.CUSBUC IS NULL ORDER BY dbCUS.CUSNUM;"

'            Case "SCBงานคดีทั้งหมด" : sqll = sqll = "SELECT dbCUS.CUSOWN AS ธนาคาร, dbCUS.CUSNUM AS [สำนวน No], dbCUS.CUSACC AS หมายเลขบัญชี, dbCUS.CUSCUS AS [Ref No], dbCUS.CUSREF AS [เลขที่ LIS], dbCUS.CUSNAM AS [ชื่อ-นามสกุล], dbCUS.CUSIDC AS ID, dbCUS.CUSPRO AS Product, dbLAW.LAWSUE AS วันฟ้อง, dbLAW.LAWBLK AS คดีดำ, dbDOC.DOCAPP AS [วันที่รับเอกสาร app], dbDOC.DOCSTM AS [วันที่รับเอกสาร STM], dbCUS.CUSBUC AS Bucket, dbCUS.CUSCLS AS Class, '' AS Type, '' AS ทุนทรัพย์รวม, dbLAW.LAWSBAL AS ทุนทรัพย์บัตร, dbLAW.LAWSPRI AS ต้นเงิน, dbLAW.LAWSINT AS ดอกเบี้ย, dbLAW.LAWSFEE AS ค่าธรรมเนียมศาล, dbLAW.LAWENF1F AS ค่าส่งคำคู่ความ, dbLAW.LAWDMED AS วันไกล่เกลีย, dbLAW.LAWTMED AS เวลาไกล่เกลี่ย, dbLAW.LAWDINV AS วันสืบ, dbLAW.LAWTINV AS เวลา, dbLAW.LAWRINV AS ผลสืบ, dbCUS.CUSSTA AS STATUS, dbLAW.LAWCOU AS ศาล, dbLAW.LAWYER AS ทนาย, dbLAW.LAWRED AS คดีแดง, dbLAW.LAWJUD AS [วันที่พิพากษา/วันที่ทำยอม], dbLAW.LAWWIT AS ถอนฟ้อง, dbLAW.LAWENF1 AS วันที่นำคำบังคับ, dbLAW.LAWENF2 AS วันออกหมายตั้ง, dbLAW.LAWENF3 AS วันออกหมายบังคับคดี, dbLAW.LAWREF AS วันแถลงงดบังคับคดี, dbLAW.LAWDREF AS วันที่คืนค่าธรรมเนียมศาล, dbLAW.LAWJREF AS จำนวนค่าธรรมเนียมศาล, dbLAW.LAWCHQ AS เลขที่เช็ค, dbLAW.LAWREP AS วันที่รายงานคำพิพากษาให้ธนาคาร, dbLAW.LAWRDOC AS [วันที่คืนเอกสารสืบให้ admin], dbLAW.LAWTYP AS ผลพิพากษา, dbLAW.LAWSEN AS คำพิพากษา, dbLAW.LAWCOM AS สัญญายอม FROM(dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC) LEFT JOIN dbDOC On dbCUS.CUSACC = dbDOC.DOCACC WHERE (dbCUS.CUSOWN) ='SCB' ORDER BY dbCUS.CUSNUM;"

'        End Select

'        cmdlegal = New SqlCommand(sqll, cnLegal)
'        DALegal = New SqlDataAdapter(cmdlegal)
'        DSLegal = New DataSet
'        DALegal.Fill(DSLegal, "Sort")

'        With Dtgv_SCBLEGAL
'            .DataSource = DSLegal.Tables("sort")
'        End With

'    End Sub

'    Private Sub Dtgv_LawCollector_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgv_LawCollector.CellClick





'End Class