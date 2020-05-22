Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Module VBcode

    Friend Sub Msg_error(text As String, Optional title As String = "ผิดพลาด")
        MsgBox(text, vbCritical + vbOKOnly, title)          'Massegebox Error ใช้สำหรับ แสดงการแจ้งเตือนปันหาต่าง ๆ ในโปรแกรม
    End Sub
    Friend Sub Msg_OK(text As String, Optional title As String = "สำเร็จ")
        MsgBox(text, vbInformation + vbOKOnly, title)
    End Sub
    Friend Function Msg_confirm(text As String, Optional title As String = "แจ้งเตือน")
        Return MsgBox(text, vbQuestion + vbYesNo, title)
    End Function

    Friend pc As String = Environment.MachineName

    Friend Function _Getlogdata(_status As String)
        connect()
        _sql = $"SELECT * FROM tbl_login WHERE USERID = '{FrmLogin.txt_idlog.Text}'"
        cmd = New SqlCommand(_sql, cn)
        DA = New SqlDataAdapter(cmd)
        DA.Fill(DS, "Fullname")

        sql = ($"INSERT INTO tbl_logfiles(LOGDATE,LOGUSER,LOGNAME,LOGIP,LOGPCNAME,LOGDETAIL)VALUES(GETDATE(),'{FrmLogin.txt_idlog.Text}','{DS.Tables("Fullname").Rows(0)("USRNAME")}','{FrmLogin.aws.LocalIP}','{pc}','{_status}')")
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        cn.Close()
    End Function
    Friend Function _cleardatagrid(sender As Object)

        If sender.rows.count > 0 Then

            sender.DataSource = Nothing

        End If

    End Function
    '##### เพิ่มข้อมูลจากฐานข้อมูลเข้า Combobox ########
    Friend Sub _cboArray(_combobox As Object, ar() As String)

        _combobox.Items.clear()

        _combobox.Items.AddRange(ar)
        _combobox.SelectedIndex = 0

    End Sub


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
                FrmMain.accms.Enabled = False
                FrmMain.settingms.Enabled = False
                FrmMain.Historyms.Enabled = False
                FrmMain.Uploads.Enabled = False
                FrmMain.Upload_exe.Enabled = False
                FrmMain.tab_execution.Enabled = False
            Case "Collector"
                FrmMain.accms.Enabled = False
                FrmMain.settingms.Enabled = False
                FrmMain.Historyms.Enabled = False
                FrmMain.Uploads.Enabled = False
                FrmMain.Upload_exe.Enabled = False
                FrmMain.settingms.Enabled = False
        End Select

    End Sub

    Public Function GetCellValue(gv As GridView, Column As Integer) As String
        Try
            Return gv.GetRowCellValue(gv.GetSelectedRows(0), gv.Columns(Column)).ToString()
        Catch ex As Exception
        End Try
    End Function
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


