'## Descriptions ##'
'## NameSpaces System.Data.SqlClient ใช้สำหรับเชื่อมต่อกับฐานข้อมูล เช่น SELECT UPDATE INSERT DELETE ##
'## NameSpaces DevExpress.XtraGrid.Views.Grid สำหรับ จัดการ Event ต่าง ๆ ใน Datagridview ##

Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid

Module VBcode
    '## Descriptions ##'
    '## Massegebox Error ใช้สำหรับ แสดงการแจ้งเตือนปันหาต่าง ๆ  ในโปรแกรม ##
    '## Parameters text As String สำหรับ สำหรับ เพิ่มข้อมูลที่ต้องการแสดง ##
    Friend Sub Msg_error(text As String, Optional title As String = "ผิดพลาด")
        MsgBox(text, vbCritical + vbOKOnly, title)
    End Sub
    '## Descriptions ##'
    '## Sub Messegebox OK ใช้สำหรับ แสดงการแจ้งเตือนข้อความ เช่น ยินดีด้วย,สำเร็จแล้ว,เสร็จสิ้นแล้ว ในโปรแกรม ##
    '## Parameters text As String สำหรับ เพิ่มข้อมูลที่ต้องการแสดง ##

    Friend Sub Msg_OK(text As String, Optional title As String = "สำเร็จ")
        MsgBox(text, vbInformation + vbOKOnly, title)
    End Sub
    '## Descriptions ##
    '## Function Confirm แสดงปุ่มแจ้งเตือน ขึ้นให้ผู้ใช้ยืนยัน ใช้รวมกับ IF ##
    '## Parameter สองตัว สำหรับ แสดงข้อความแจ้งเตือน ##

    Friend Function Msg_confirm(text As String, Optional title As String = "แจ้งเตือน")
        Return MsgBox(text, vbQuestion + vbYesNo, title)
    End Function
    '## Descriptions ##
    '## เข้าถึงข้อมูล Environment ใช้สำหรับ ตรวจสอบ สภาพแวดล้อมของเครื่อง Computer Client ##

    Friend pc As String = Environment.MachineName
    '## Descriptions ##
    '## Sub สำหรับทำ เก็บ HistoryLog ในฐานข้อมูล SCANDB สามารถกำหนด Parameters Detail ภายใน ##
    '## ข้อมูลที่เก็บคือ วันที่นำเข้าข้อมูล , ชื่อเข้าสู่ระบบ , ชื่อ-นามสกุลที่สมัคร , IP Address , ComputerName , รายละเอียดข้อมูล ##
    '## ดึงข้อมูลจาก User Name ที่เข้าใช้งานระบบ ## 
    '## Parameters _status As String ใช้สำหรับใส่ข้อความรายละเอียด ##

    Friend Sub _Getlogdata(_status As String)
        connect()
        _sql = $"SELECT * FROM tbl_login WHERE USERID = '{FrmLogin.txt_idlog.Text}'"
        cmd = New SqlCommand(_sql, cn)
        DA = New SqlDataAdapter(cmd)
        DA.Fill(DS, "Fullname")

        sql = ($"INSERT INTO tbl_logfiles(LOGDATE,LOGUSER,LOGNAME,LOGIP,LOGPCNAME,LOGDETAIL)VALUES(GETDATE(),'{FrmLogin.txt_idlog.Text}','{DS.Tables("Fullname").Rows(0)("USRNAME")}','{FrmLogin.aws.LocalIP}','{pc}','{_status}')")
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

        cn.Close()

    End Sub
    '## Descriptions ##
    '## Sub Clear Datagridview ใช้สำหรับลบ ข้อมูล ถ้า Datagridview นั้นมีข้อมูลค้างอยู่ ##
    '## Parameters sender As Object ในการผ่านข้อมูล Datagridview ที่ต้องการใช้เพิ่มข้อมูล ##

    Friend Sub _cleardatagrid(sender As DataGridView)

        If (sender.Rows.Count > 0) Or (sender.ColumnCount > 0) Then

            sender.DataSource = Nothing

        End If

    End Sub

    '## Descriptions ##
    '## Sub ส่งข้อมูลจาก Array เข้าไปใน Combobox ทำงานโดยใช้ Method Clear ข้อมูลทั้งหมดจาก Combobox ##
    '## แล้วใช้ Method Items.AddRange() เพิ่ม ข้อมูล Array ไปใน Combobox ##
    '## ใช้ Method SelectedIndex เพื่อเลือก Array แรก สุดมาแสดง ##
    '## Parametes _combobox As Object ใช้เพิ่ม Combobox เข้าไปใน Sub ##
    '## Parameters ar As String() ใช้เพิ่ม Array ข้อมูลที่ต้องการ ##
    Friend Sub _cboArray(_combobox As Object, ar As String())

        _combobox.Items.clear()

        _combobox.Items.AddRange(ar)
        _combobox.SelectedIndex = 0

    End Sub

    '## Descriptions ##
    '## Sub ใช้ในการเพิ่มข้อมูล Combobox ในการดึงข้อมูลจาก Database หรือ SQLSERVER ทำการเชื่อมต่อ ฐานข้อมูล จากนั้นใช้ เคลียข้อมูลใน Combobox แล้ว Query ข้อมูลคอลัมน์ ที่ต้องการนำมาแสดง โดยใช้ Loop While ในการอ่านข้อมูลในคอลัมน์ที่ Query มาแล้วเพิ่มเข้า ##
    '## Parameters _combobox As Object ใช้เพิ่ม Combobox เข้าไปใน
    '## Parameters _columns As String อ้างถึงชื่อคอลัมน์ของข้อมูลที่จะนำมาแสดง
    '## Parameters _tables As String ใช้อ้างถึงชื่อตารางที่จะนำข้อมูลมาแสดง

    Friend Sub _comboboxadd(_combobox As Object, _columns As String, _tables As String)

        connect()

        _combobox.Items.clear()

        sql = $"SELECT DISTINCT {_columns} FROM {_tables}"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            _combobox.Items.Add($"{DR(_columns)}")
        End While

        DR.Close()
        _combobox.SelectedIndex = 0

    End Sub

    '## Descriptions ##
    '## Sub _convertnum ใช้เปลี่ยนตัวเลขเป็นจำนวนเงินมีจุดทศนิยม 2 ตำแหน่ง

    Friend Sub _convertnum(_current As Object)
        If (Str(_current.text) <> "") AndAlso (Not IsNumeric(_current.text)) Then

            Exit Sub

        Else

            _current.text = CDbl(_current.text).ToString("##,##0.00")

        End If
    End Sub
    '## Descriptions ##
    '## Sub Permissions ใช้กำหนดสิทธิในการเข้าถึง Object หรือ ฟอร์ม ต่างๆ โดยการดึง สิทธิข้อมูลผู้ใช้จากฐานข้อมูล แล้วกำหนดการใช้งานข้อมูล ของสิทธินั้น ๆ  ##
    '## Parameters _userid As String ใช้ในการกำหนด Username ในการอ้างถึง สิทธิ ในการใช้ข้อมูล ##
    '## Parameters _userpass As String ใช้ในการกำหนด Password ในการอ้างถึง สิทธิ ในการใช้ข้อมูล ##

    Friend Sub Permissions(_userid As String, _userpass As String)

        connect()

        sql = $"SELECT USRGROUP FROM tbl_login WHERE USERID = '{_userid}' AND USRPASSWORD = '{_userpass}'"
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "table")

        Dim _Group As String = DS.Tables("table").Rows(0)("USRGROUP")

        Select Case _Group
            Case "Admin"
                FrmMastermain.accms.Enabled = False
                FrmMastermain.settingms.Enabled = False
                FrmMastermain.Historyms.Enabled = False
                FrmMastermain.MENU_Uploads_SCANPDF.Enabled = False
                FrmMastermain.Menu_Upload_Execution.Enabled = False
                FrmMastermain.tab_execution.Enabled = False
                FrmMastermain.IPManagement.Enabled = False
            Case "Collector"
                FrmMastermain.accms.Enabled = False
                FrmMastermain.settingms.Enabled = False
                FrmMastermain.Historyms.Enabled = False
                FrmMastermain.MENU_Uploads_SCANPDF.Enabled = False
                FrmMastermain.Menu_Upload_Execution.Enabled = False
                FrmMastermain.settingms.Enabled = False
                FrmMastermain.IPManagement.Enabled = False
                FrmMastermain.menu_accounting_search.Enabled = False

        End Select

        cn.Close()

    End Sub

    '## Descriptions ##
    '## Sub _autocomplete ใข้ในการสร้าง AutoComplete จากข้อมูลใน Database ให้กับ TextBox เพื่อง่ายต่อการค้นหาข้อมูล ใช้ Loop While ในการอ่านข้อมูลจากฐานข้อมูล มาแสดง เป็น List เวลาค้นหา ข้อมูลต่าง ๆ ##
    '## Parameters ByRef sender As TextBox ใช้ในการเพิ่ม TextBox ที่ต้องการทำ AutoComplete ##
    '## Parameters _columns As String ใช้กำหนด คอลัมน์ ในการค้นหาข้อมูล ##
    '## Parameters _table As String ใช้กำหนด ตาราง ในการค้นหาข้อมูล ##

    Public Sub _autocomplete(ByRef sender As TextBox, _columns As String, _table As String)

        connect()

        sql = $"SELECT {_columns} FROM {_table}"

        Dim cmd As New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()

        While reader.Read()
            autocomp.Add(reader(_columns))
        End While

        reader.Close()

        sender.AutoCompleteMode = AutoCompleteMode.Suggest
        sender.AutoCompleteSource = AutoCompleteSource.CustomSource
        sender.AutoCompleteCustomSource = autocomp

    End Sub

    '## Descriptions ##
    '## Function เก็บค่าวันที่ ##
    '## Parameter datetime As DateTime ใช้รับค่าข้อมูลประเภท เวลา/วันที่ ##

    Public Function Getdate(datetime As DateTime)

        Dim strMonthDaye As String
        Dim strYeare As String
        Dim styMonthDayYeare As String
        Dim time As String
        time = Format(datetime, "H:mm:ss")
        strYeare = Format(datetime, "yyyy") - 543
        strMonthDaye = Format(datetime, "MM-dd")
        styMonthDayYeare = strYeare & "-" & strMonthDaye
        Return styMonthDayYeare

    End Function

    '## Descriptions ##
    '## Function เก็บค่าวันที่ และเวลาสุดท้ายของวัน ##
    '## Parameter datetime As DateTime ใช้รับค่าข้อมูลประเภท เวลา/วันที่ ##

    Public Function Getdateend(datetime As DateTime)
        Dim strMonthDaye As String
        Dim strYeare As String
        Dim styMonthDayYeare As String
        Dim time As String
        time = Format(datetime, "H:mm:ss")
        strYeare = Format(datetime, "yyyy") - 543
        strMonthDaye = Format(datetime, "MM-dd")
        styMonthDayYeare = strYeare & "-" & strMonthDaye
        Return styMonthDayYeare & " 23:59:59"
    End Function

End Module

'#### เพิ่มวินาที
'timenow = DateAndTime.TimeOfDay.AddSeconds(+1)

'#### UPDATE Parameter เช็คค่า Parameters และเพิ่มค่า DBNull.value ####
' Private Sub UpdateData()
'     sql = "UPDATE Product SET CatID = @cid, SupID = @sid, ProName = @name, 
'   Price = @prc, Stock = @stk, Expire = @exp, Detail = @dtl, Picture = @pic 
'            WHERE ProID = @pid"

'     Command.CommandText = sql
'     Command.Parameters.Clear()
'     Command.Parameters.AddWithValue("pid", TextID.Text)
'     Command.Parameters.AddWithValue("cid", ComboCategory.SelectedValue)
'     Command.Parameters.AddWithValue("sid", ComboSupplier.SelectedValue)
'     Command.Parameters.AddWithValue("name", TextName.Text)
'     Command.Parameters.AddWithValue("prc", TextPrice.Text)
'     Command.Parameters.AddWithValue("stk", TextStock.Text)
'     Command.Parameters.AddWithValue("dtl", TextDetail.Text)

'     Dim dateStr = $"{DateTimePicker1.Value.Year}/
'					{DateTimePicker1.Value.Month}/
'					{DateTimePicker1.Value.Day}"

'     Command.Parameters.AddWithValue("exp", dateStr)

'     If Not (PictureBox1.Image Is Nothing) Then
'         Dim pic() As Byte = ReadImage()
'         Command.Parameters.AddWithValue("pic", pic)
'     Else
'         Command.Parameters.AddWithValue("pic", DBNull.Value)
'     End If

'     Dim r As Integer = Command.ExecuteNonQuery()
'     If r = -1 Then
'         MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")
'     Else
'         MessageBox.Show("ข้อมูลได้รับการแก้ไขแล้ว")
'         BindingData()
'     End If
' End Sub

' #### UPDATE Parameter เช็คค่า Parameters และเพิ่มค่า DBNull.value ####
'Private Sub InsertData()
'    sql = "INSERT INTO Product(CatID, SupID, ProName, Price, Stock, Expire, Detail, Picture) 
'           VALUES(@cid, @sid, @name, @prc, @stk, @exp, @dtl, @pic)"

'    Command.CommandText = sql
'    Command.Parameters.Clear()
'    '-- ข้อมูลที่ทำ Complex Binding ต้องอ่านค่าจากพร็อปเพอร์ตี้ SelectedValue 
'    '-- ซึ่งเป็นค่า CatID ที่เชื่อมโยงระหว่างตาราง Category กับตาราง Product
'    '-- และ SupID ก็เชื่อมโยงระหว่างตาราง Supplier กับตาราง Product เช่นเดียวกัน
'    Command.Parameters.AddWithValue("cid", ComboCategory.SelectedValue)
'    Command.Parameters.AddWithValue("name", TextName.Text)
'    Command.Parameters.AddWithValue("prc", TextPrice.Text)
'    Command.Parameters.AddWithValue("stk", TextStock.Text)
'    Command.Parameters.AddWithValue("sid", ComboSupplier.SelectedValue)
'    Command.Parameters.AddWithValue("dtl", TextDetail.Text)

'    '-- อ่านค่า ปี/เดือน/วัน จาก DateTimePicker
'    Dim dateStr = $"{DateTimePicker1.Value.Year}/
'				{DateTimePicker1.Value.Month}/
'				{DateTimePicker1.Value.Day}"

'    Command.Parameters.AddWithValue("exp", dateStr)

'    If Not (PictureBox1.Image Is Nothing) Then
'        Dim pic() As Byte = ReadImage()
'        Command.Parameters.AddWithValue("pic", pic)
'    Else
'        Command.Parameters.AddWithValue("pic", DBNull.Value)
'    End If

'    Dim r As Integer = Command.ExecuteNonQuery()
'    If r = -1 Then
'        MessageBox.Show("เกิดข้อผิดพลาด ไม่สามารถเพิ่มข้อมูลได้")
'    Else
'        MessageBox.Show("บันทึกข้อมูลแล้ว")
'        BindingData()
'    End If
'End Sub


