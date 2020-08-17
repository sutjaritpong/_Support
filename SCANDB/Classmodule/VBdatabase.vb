Imports System.Data.SqlClient
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

    Friend cnLegal As New SqlConnection("SERVER=FDSSERVER_1;Initial Catalog=LegaldB;Persist Security Info=True;User ID=sa;Password=1971;")
    Friend cmdlegal As New SqlCommand
    Friend DALegal As New SqlDataAdapter
    Friend DSLegal As New DataSet
    Friend DTLegal As New DataTable
    Friend DRLegal As SqlDataReader
    Friend sqll As String = ""
#End Region

#Region "Code ที่ใช้เกี่ยวกับฐานข้อมูล"

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
