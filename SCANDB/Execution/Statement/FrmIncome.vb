Option Explicit On
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmIncome
    Private Sub FrmIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connect()

        Dim typefind() As String = {"ธนาคาร", "เลขบัตรประชาชน", "เลขที่สัญญา", "ขื่อ", "นามสกุล", "เลขที่คดีดำ", "เลขที่คดีแดง"}
        CboArray(Cbo_Income_find, typefind)
        Cbo_Income_find.SelectedIndex = 0

        Connect()

        Cbo_Income_Employees.Items.Clear()

        sql = $"SELECT DISTINCT EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '02-EXECUTION' "
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            Cbo_Income_Employees.Items.Add($"{DR("EXEEMPLOYEES")}")
        End While

        DR.Close()
        Cbo_Income_Employees.SelectedIndex = 0

        Comboboxadd(cbo_income_prefix, "Customer_prefix", "Execution_Income")
        cbo_income_prefix.SelectedIndex = -1

        Comboboxadd(Cbo_Income_Owner, "Customer_Owner", "Execution_Income")
        Cbo_Income_Owner.SelectedIndex = -1

        Comboboxadd(Cbo_Income_Type, "Income_type", "Execution_Income")
        Cbo_Income_Type.SelectedIndex = -1

        ClearText()
        ReadonlyText()

        Datetimeformatshort(Dtp_Income_DateSheet)
        Datetimeformatshort(Dtp_Income_Datework)

        Datetimeformatshort(Dtp_Income_Pay1)
        Datetimeformatshort(Dtp_Income_Pay2)
        Datetimeformatshort(Dtp_Income_Pay3)
        Datetimeformatshort(Dtp_Income_Pay4)
        Datetimeformatshort(Dtp_Income_Pay5)
        Datetimeformatshort(Dtp_Income_Pay6)
        Datetimeformatshort(Dtp_Income_Pay7)
        Datetimeformatshort(Dtp_Income_Pay8)
        Datetimeformatshort(Dtp_Income_Pay9)
        Datetimeformatshort(Dtp_Income_Pay10)
        Datetimeformatshort(Dtp_Income_Pay11)
        Datetimeformatshort(Dtp_Income_Pay12)
        Datetimeformatshort(Dtp_Income_Pay13)
        Datetimeformatshort(Dtp_Income_Pay14)
        Datetimeformatshort(Dtp_Income_Pay15)



    End Sub

    Private Sub ClearText()

        Dim Txt_Clear() As TextBox = {Txt_Income_Idcus, Txt_Income_Acc, Txt_Income_Accno, Txt_Income_Firstname, Txt_Income_Lastname, Txt_Income_Fullname, Txt_Income_Court, Txt_Income_Black, Txt_Income_Red, Txt_Income_Detail, Txt_Income_Total, Txt_Income_Refund, Txt_Income_Pay1, Txt_Income_Pay2, Txt_Income_Pay3, Txt_Income_Pay4, Txt_Income_Pay5, Txt_Income_Pay6, Txt_Income_Pay7, Txt_Income_Pay8, Txt_Income_Pay9, Txt_Income_Pay10, Txt_Income_Pay11, Txt_Income_Pay12, Txt_Income_Pay13, Txt_Income_Pay14, Txt_Income_Pay15, Txt_Income_GrandTotal}

        Dim Combo_clear() As ComboBox = {Cbo_Income_Employees, cbo_income_prefix, Cbo_Income_find, Cbo_Income_Owner, Cbo_Income_Type}

        Dim Datetimepicker_clear() As DateTimePicker = {Dtp_Income_DateSheet, Dtp_Income_Datework, Dtp_Income_Refund, Dtp_Income_Pay1, Dtp_Income_Pay2, Dtp_Income_Pay3, Dtp_Income_Pay4, Dtp_Income_Pay5, Dtp_Income_Pay6, Dtp_Income_Pay7, Dtp_Income_Pay8, Dtp_Income_Pay9, Dtp_Income_Pay10, Dtp_Income_Pay11, Dtp_Income_Pay12, Dtp_Income_Pay13, Dtp_Income_Pay14, Dtp_Income_Pay15}

        Dim Checkbok_Clear() As CheckBox = {Chk_Income_DateSheet, Chk_Income_Datework, Chk_Income_Refund, Chk_Income_Pay1, Chk_Income_Pay2, Chk_Income_Pay3, Chk_Income_Pay4, Chk_Income_Pay5, Chk_Income_Pay6, Chk_Income_Pay7, Chk_Income_Pay8, Chk_Income_Pay9, Chk_Income_Pay10, Chk_Income_Pay11, Chk_Income_Pay12, Chk_Income_Pay13, Chk_Income_Pay14, Chk_Income_Pay15}

        For i = 0 To Txt_Clear.Length - 1
            Txt_Clear(i).Text = ""
        Next

        For i = 0 To Combo_clear.Length - 1
            Combo_clear(i).SelectedIndex = -1
        Next

        For i = 0 To Datetimepicker_clear.Length - 1
            Datetimepicker_clear(i).Text = ""
        Next

        For i = 0 To Checkbok_Clear.Length - 1
            Checkbok_Clear(i).Checked = False
        Next

    End Sub

    Private Sub ReadonlyText()

        Dim Txt_Clear() As TextBox = {Txt_Income_Idcus, Txt_Income_Acc, Txt_Income_Accno, Txt_Income_Firstname, Txt_Income_Lastname, Txt_Income_Fullname, Txt_Income_Court, Txt_Income_Black, Txt_Income_Red, Txt_Income_Detail, Txt_Income_Total, Txt_Income_Refund, Txt_Income_Pay1, Txt_Income_Pay2, Txt_Income_Pay3, Txt_Income_Pay4, Txt_Income_Pay5, Txt_Income_Pay6, Txt_Income_Pay7, Txt_Income_Pay8, Txt_Income_Pay9, Txt_Income_Pay10, Txt_Income_Pay11, Txt_Income_Pay12, Txt_Income_Pay13, Txt_Income_Pay14, Txt_Income_Pay15, Txt_Income_GrandTotal}

        Dim Combo_clear() As ComboBox = {Cbo_Income_Employees, Cbo_Income_Owner, Cbo_Income_Type, cbo_income_prefix}

        Dim Datetimepicker_clear() As DateTimePicker = {Dtp_Income_DateSheet, Dtp_Income_Datework, Dtp_Income_Refund, Dtp_Income_Pay1, Dtp_Income_Pay2, Dtp_Income_Pay3, Dtp_Income_Pay4, Dtp_Income_Pay5, Dtp_Income_Pay6, Dtp_Income_Pay7, Dtp_Income_Pay8, Dtp_Income_Pay9, Dtp_Income_Pay10, Dtp_Income_Pay11, Dtp_Income_Pay12, Dtp_Income_Pay13, Dtp_Income_Pay14, Dtp_Income_Pay15}

        Dim Checkbok_Clear() As CheckBox = {Chk_Income_DateSheet, Chk_Income_Datework, Chk_Income_Refund, Chk_Income_Pay1, Chk_Income_Pay2, Chk_Income_Pay3, Chk_Income_Pay4, Chk_Income_Pay5, Chk_Income_Pay6, Chk_Income_Pay7, Chk_Income_Pay8, Chk_Income_Pay9, Chk_Income_Pay10, Chk_Income_Pay11, Chk_Income_Pay12, Chk_Income_Pay13, Chk_Income_Pay14, Chk_Income_Pay15}

        For i = 0 To Txt_Clear.Length - 1
            Txt_Clear(i).ReadOnly = True
        Next

        For i = 0 To Combo_clear.Length - 1
            Combo_clear(i).Enabled = False
        Next

        For i = 0 To Datetimepicker_clear.Length - 1
            Datetimepicker_clear(i).Enabled = False
        Next

    End Sub

    Private Sub Writtertext()

        Dim Txt_Clear() As TextBox = {Txt_Income_Idcus, Txt_Income_Acc, Txt_Income_Accno, Txt_Income_Firstname, Txt_Income_Lastname, Txt_Income_Fullname, Txt_Income_Court, Txt_Income_Black, Txt_Income_Red, Txt_Income_Detail, Txt_Income_Total, Txt_Income_Refund, Txt_Income_Pay1, Txt_Income_Pay2, Txt_Income_Pay3, Txt_Income_Pay4, Txt_Income_Pay5, Txt_Income_Pay6, Txt_Income_Pay7, Txt_Income_Pay8, Txt_Income_Pay9, Txt_Income_Pay10, Txt_Income_Pay11, Txt_Income_Pay12, Txt_Income_Pay13, Txt_Income_Pay14, Txt_Income_Pay15, Txt_Income_GrandTotal}

        Dim Combo_clear() As ComboBox = {Cbo_Income_Employees, Cbo_Income_find, cbo_income_prefix, Cbo_Income_Owner, Cbo_Income_Type}

        Dim Datetimepicker_clear() As DateTimePicker = {Dtp_Income_DateSheet, Dtp_Income_Datework, Dtp_Income_Refund, Dtp_Income_Pay1, Dtp_Income_Pay2, Dtp_Income_Pay3, Dtp_Income_Pay4, Dtp_Income_Pay5, Dtp_Income_Pay6, Dtp_Income_Pay7, Dtp_Income_Pay8, Dtp_Income_Pay9, Dtp_Income_Pay10, Dtp_Income_Pay11, Dtp_Income_Pay12, Dtp_Income_Pay13, Dtp_Income_Pay14, Dtp_Income_Pay15}

        Dim Checkbok_Clear() As CheckBox = {Chk_Income_DateSheet, Chk_Income_Datework, Chk_Income_Refund, Chk_Income_Pay1, Chk_Income_Pay2, Chk_Income_Pay3, Chk_Income_Pay4, Chk_Income_Pay5, Chk_Income_Pay6, Chk_Income_Pay7, Chk_Income_Pay8, Chk_Income_Pay9, Chk_Income_Pay10, Chk_Income_Pay11, Chk_Income_Pay12, Chk_Income_Pay13, Chk_Income_Pay14, Chk_Income_Pay15}

        For i = 0 To Txt_Clear.Length - 1

            Txt_Clear(i).ReadOnly = False

        Next

        For i = 0 To Combo_clear.Length - 1

            Combo_clear(i).Enabled = True

        Next

        For i = 0 To Datetimepicker_clear.Length - 1

            If Checkbok_Clear(i).Checked = True Then

                Datetimepicker_clear(i).Enabled = True

            Else

                Continue For

            End If

        Next

    End Sub
    Private Sub Query_Insert_Income()

        Connect()

        sql = $"SELECT * FROM EXEEMPLOYEE WHERE EXEEMPLOYEES = '{Cbo_Income_Employees.Text}'"
        cmd = New SqlCommand(sql, cn)
        Dim EMPKEY As Integer = cmd.ExecuteScalar()

        sql = $"INSERT INTO Execution_Income(Customer_Owner,Customer_Id_card,Customer_account,Customer_account_no,Customer_Prefix,Customer_Firstname,Customer_Lastname,Customer_Fullname,Income_court,Income_black,Income_red,EMPLOYEES_KEY,Income_type,Income_Detail,Income_date_sheet,Income_date_work,Income_total_check)VALUES('{Cbo_Income_Owner.Text}','{Txt_Income_Idcus.Text}','{Txt_Income_Acc.Text}','{Txt_Income_Accno.Text}','{cbo_income_prefix.Text}','{Txt_Income_Firstname.Text}','{Txt_Income_Lastname.Text}','{cbo_income_prefix.Text}{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}','{Txt_Income_Court.Text}','{Txt_Income_Black.Text}','{Txt_Income_Red.Text}',{EMPKEY},'{Cbo_Income_Type.Text}','{Txt_Income_Detail.Text}','{Dtp_Income_DateSheet.Text}','{Dtp_Income_Datework.Text}',{Int(Txt_Income_Total.Text)})"

        cmd = New SqlCommand(sql, cn)
        Dim Queryinsert As Integer = cmd.ExecuteNonQuery()

        If Queryinsert > 0 Then

            Lbl_Income_Invalid.Visible = True
            Lbl_Income_Invalid.ForeColor = Color.Green
            Lbl_Income_Invalid.Text = $"เพิ่มข้อมูล {Queryinsert} รายการ"

        Else
            Lbl_Income_Invalid.Visible = True
            Lbl_Income_Invalid.ForeColor = Color.Red
            Lbl_Income_Invalid.Text = $"เพิ่มล้มเหลว {Queryinsert} รายการ"
        End If

    End Sub

    Private Sub Query_Insert_IncomeResult()

        Connect()


        sqll = $"SELECT COUNT(Customer_id_card) FROM Execution_income_result WHERE Customer_id_card = '{Txt_Income_Idcus.Text}' And Customer_Account = '{Txt_Income_Acc.Text}';"

        cmd = New SqlCommand(sqll, cn)
        Dim Checktables As Integer = cmd.ExecuteScalar

        If Checktables <= 0 Then

            sql = $"INSERT INTO Execution_Income_Result(Customer_id_card,Customer_Account,Income_refund,Income_refund_date,Income_grandtotal,Income_statement_1,Income_refund_date1,Income_statement_2,Income_refund_date2,Income_statement_3,Income_refund_date3,Income_statement_4,Income_refund_date4,Income_statement_5,Income_refund_date5,Income_statement_6,Income_refund_date6,Income_statement_7,Income_refund_date7,Income_statement_8,Income_refund_date8,Income_statement_9,Income_refund_date9,Income_statement_10,Income_refund_date10,Income_statement_11,Income_refund_date11,Income_statement_12,Income_refund_date12,Income_statement_13,Income_refund_date13,Income_statement_14,Income_refund_date14,Income_statement_15,Income_refund_date15)VALUES('{Txt_Income_Idcus.Text}','{Txt_Income_Acc.Text}'"

            If Chk_Income_Refund.Checked = False Then
                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Refund.Text},'{Dtp_Income_Refund.Text}'"

            End If

            sql &= $",{Txt_Income_GrandTotal.Text}"

            If Chk_Income_Pay1.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay1.Text},'{Dtp_Income_Pay1.Text}'"

            End If

            If Chk_Income_Pay2.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay2.Text},'{Dtp_Income_Pay2.Text}'"

            End If

            If Chk_Income_Pay3.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay3.Text},'{Dtp_Income_Pay3.Text}'"

            End If

            If Chk_Income_Pay4.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay4.Text},'{Dtp_Income_Pay4.Text}'"

            End If

            If Chk_Income_Pay5.Checked = False Then
                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay5.Text},'{Dtp_Income_Pay5.Text}'"

            End If

            If Chk_Income_Pay6.Checked = False Then

                sql &= $",0,NULL"

            Else


                sql &= $",{Txt_Income_Pay6.Text},'{Dtp_Income_Pay6.Text}'"

            End If

            If Chk_Income_Pay7.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay7.Text},'{Dtp_Income_Pay7.Text}'"

            End If

            If Chk_Income_Pay8.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay8.Text},'{Dtp_Income_Pay8.Text}'"

            End If

            If Chk_Income_Pay9.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay9.Text},'{Dtp_Income_Pay9.Text}'"

            End If

            If Chk_Income_Pay10.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay10.Text},'{Dtp_Income_Pay10.Text}'"

            End If

            If Chk_Income_Pay11.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay11.Text},'{Dtp_Income_Pay11.Text}'"

            End If

            If Chk_Income_Pay12.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay12.Text},'{Dtp_Income_Pay12.Text}'"

            End If

            If Chk_Income_Pay13.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay13.Text},'{Dtp_Income_Pay13.Text}'"

            End If

            If Chk_Income_Pay14.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay14.Text},'{Dtp_Income_Pay14.Text}'"

            End If

            If Chk_Income_Pay15.Checked = False Then

                sql &= $",0,NULL"

            Else

                sql &= $",{Txt_Income_Pay15.Text},'{Dtp_Income_Pay15.Text}'"

            End If

            sql &= ")"

            cmd = New SqlCommand(sql, cn)
            Dim Queryinsertresult As Integer = cmd.ExecuteNonQuery()

            If Queryinsertresult > 0 Then

                Lbl_Income_Invalid.Visible = True
                Lbl_Income_Invalid.ForeColor = Color.Green
                Lbl_Income_Invalid.Text = $"เพิ่มข้อมูล {Queryinsertresult} รายการ"
                Getlogdataexe($"เพิ่มข้อมูลบัญชีรับจ่าย ธนาคาร {Cbo_Income_Owner.Text} ลูกค้าชื่อ{Txt_Income_Fullname.Text} ประเภท {Cbo_Income_Type.Text} จำนวนเงิน {Txt_Income_Total.Text}", $"'{Txt_Income_Idcus.Text}'", $"'{Txt_Income_Acc.Text}'")

            Else

                Lbl_Income_Invalid.Visible = True
                Lbl_Income_Invalid.ForeColor = Color.Red
                Lbl_Income_Invalid.Text = $"เพิ่มล้มเหลว {Queryinsertresult} รายการ"

            End If

        Else

            sql = $"UPDATE Execution_Income_Result SET"

            If Chk_Income_Refund.Checked = True Then

                sql &= $" Income_refund ={Txt_Income_Refund.Text},Income_refund_date ='{Dtp_Income_Refund.Text}',"
            Else
                sql &= " Income_refund =0,Income_refund_date = NULL,"

            End If

            sql &= $"Income_grandtotal = {Txt_Income_GrandTotal.Text},"

            If Chk_Income_Pay1.Checked = True Then

                sql &= $" Income_statement_1 = {Txt_Income_Pay1.Text} ,Income_refund_date1 ='{Dtp_Income_Pay1.Text}',"
            Else
                sql &= " Income_statement_1 = 0 ,Income_refund_date1 = NULL,"

            End If

            If Chk_Income_Pay2.Checked = True Then

                sql &= $" Income_statement_2 = {Txt_Income_Pay2.Text} ,Income_refund_date2 ='{Dtp_Income_Pay2.Text}',"
            Else
                sql &= " Income_statement_2 = 0 ,Income_refund_date2 = NULL,"

            End If

            If Chk_Income_Pay3.Checked = True Then

                sql &= $" Income_statement_3 = {Txt_Income_Pay3.Text} ,Income_refund_date3 ='{Dtp_Income_Pay3.Text}',"
            Else
                sql &= " Income_statement_3 = 0 ,Income_refund_date3 = NULL,"

            End If

            If Chk_Income_Pay4.Checked = True Then

                sql &= $" Income_statement_4 = {Txt_Income_Pay4.Text} ,Income_refund_date4 ='{Dtp_Income_Pay4.Text}',"
            Else
                sql &= " Income_statement_4 = 0 ,Income_refund_date4 = NULL,"

            End If


            If Chk_Income_Pay5.Checked = True Then

                sql &= $" Income_statement_5 = {Txt_Income_Pay5.Text} ,Income_refund_date5 ='{Dtp_Income_Pay5.Text}',"
            Else
                sql &= " Income_statement_5 = 0 ,Income_refund_date5 = NULL,"

            End If

            If Chk_Income_Pay6.Checked = True Then

                sql &= $" Income_statement_6 = {Txt_Income_Pay6.Text} ,Income_refund_date6 ='{Dtp_Income_Pay6.Text}',"
            Else
                sql &= " Income_statement_6 = 0 ,Income_refund_date6 = NULL,"

            End If

            If Chk_Income_Pay7.Checked = True Then

                sql &= $" Income_statement_7 = {Txt_Income_Pay7.Text} ,Income_refund_date7 ='{Dtp_Income_Pay7.Text}',"
            Else
                sql &= " Income_statement_7 = 0 ,Income_refund_date7 = NULL,"

            End If

            If Chk_Income_Pay8.Checked = True Then

                sql &= $" Income_statement_8 = {Txt_Income_Pay8.Text} ,Income_refund_date8 ='{Dtp_Income_Pay8.Text}',"
            Else
                sql &= " Income_statement_8 = 0 ,Income_refund_date8 = NULL,"

            End If

            If Chk_Income_Pay9.Checked = True Then

                sql &= $" Income_statement_9 = {Txt_Income_Pay9.Text} ,Income_refund_date9 ='{Dtp_Income_Pay9.Text}',"
            Else
                sql &= " Income_statement_9 = 0 ,Income_refund_date9 = NULL,"

            End If

            If Chk_Income_Pay10.Checked = True Then

                sql &= $" Income_statement_10 = {Txt_Income_Pay10.Text} ,Income_refund_date10 ='{Dtp_Income_Pay10.Text}',"
            Else
                sql &= " Income_statement_10 = 0 ,Income_refund_date10 = NULL,"

            End If

            If Chk_Income_Pay11.Checked = True Then

                sql &= $" Income_statement_11 = {Txt_Income_Pay11.Text} ,Income_refund_date11 ='{Dtp_Income_Pay11.Text}',"
            Else
                sql &= " Income_statement_11 = 0 ,Income_refund_date11 = NULL,"

            End If

            If Chk_Income_Pay12.Checked = True Then

                sql &= $" Income_statement_12 = {Txt_Income_Pay12.Text} ,Income_refund_date12 ='{Dtp_Income_Pay12.Text}',"
            Else
                sql &= " Income_statement_12 = 0 ,Income_refund_date12 = NULL,"

            End If


            If Chk_Income_Pay13.Checked = True Then

                sql &= $" Income_statement_13 = {Txt_Income_Pay13.Text} ,Income_refund_date13 ='{Dtp_Income_Pay13.Text}',"
            Else
                sql &= " Income_statement_13 = 0 ,Income_refund_date13 = NULL,"

            End If

            If Chk_Income_Pay14.Checked = True Then

                sql &= $" Income_statement_14 = {Txt_Income_Pay14.Text} ,Income_refund_date14 ='{Dtp_Income_Pay14.Text}',"
            Else
                sql &= " Income_statement_14 = 0 ,Income_refund_date14 = NULL,"

            End If

            If Chk_Income_Pay15.Checked = True Then

                sql &= $" Income_statement_15 = {Txt_Income_Pay15.Text} ,Income_refund_date15 ='{Dtp_Income_Pay15.Text}'"
            Else
                sql &= " Income_statement_15 = 0 ,Income_refund_date15 = NULL"

            End If

            sql &= $" WHERE Customer_id_card = '{Txt_Income_Idcus.Text}' AND Customer_Account = '{Txt_Income_Acc.Text}'"

            cmd = New SqlCommand(sql, cn)
            Dim QueryUpdateresult As Integer = cmd.ExecuteScalar

            If QueryUpdateresult > 0 Then

                Lbl_Income_Invalid.Visible = True
                Lbl_Income_Invalid.ForeColor = Color.Green
                Lbl_Income_Invalid.Text = $"อัพเดทข้อมูล {QueryUpdateresult} รายการ"

                Getlogdataexe($"อัพเดทข้อมูล บัญชีรับจ่าย ธนาคาร {Cbo_Income_Owner.Text} ลูกค้าชื่อ{Txt_Income_Fullname.Text} ประเภท {Cbo_Income_Type.Text} จำนวนเงิน {Txt_Income_Total.Text}", $"'{Txt_Income_Idcus.Text}'", $"'{Txt_Income_Acc.Text}'")

            Else

                Lbl_Income_Invalid.Visible = True
                Lbl_Income_Invalid.ForeColor = Color.Red
                Lbl_Income_Invalid.Text = $"อัพเดทล้มเหลว {QueryUpdateresult} รายการ"

            End If

        End If

    End Sub

    Private Sub Cmd_Income_Insert_Click(sender As Object, e As EventArgs) Handles Cmd_Income_Insert.Click

        If Txt_Income_Acc.Text = "" Then
            Msg_error("กรุณากรอก เลขที่สัญญา ที่ต้องการเพิ่มในระบบ")
            Exit Sub
        End If

        If Txt_Income_GrandTotal.Text = "" Then
            Msg_error("กรุณากรอกจำนวน รวมที่ชำระ")
            Exit Sub
        End If

        Query_Insert_Income()

        Query_Insert_IncomeResult()

        cn.Close()

        ClearText()

    End Sub

    Private Sub Chk_Income_DateSheet_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_DateSheet.CheckedChanged

        If Chk_Income_DateSheet.Checked = True Then

            Dtp_Income_DateSheet.Enabled = True
        Else
            Dtp_Income_DateSheet.Enabled = False

        End If

    End Sub

    Private Sub Chk_Income_Datework_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Datework.CheckedChanged

        If Chk_Income_Datework.Checked = True Then

            Dtp_Income_Datework.Enabled = True
        Else
            Dtp_Income_Datework.Enabled = False

        End If

    End Sub

    Private Sub Cmd_Income_Cancle_Click(sender As Object, e As EventArgs) Handles Cmd_Income_Cancle.Click

        ReadonlyText()

    End Sub

    Private Sub Cmd_Income_Edit_Click(sender As Object, e As EventArgs) Handles Cmd_Income_Edit.Click

        Writtertext()

    End Sub

    Private Sub Cmd_Income_Clear_Click(sender As Object, e As EventArgs) Handles Cmd_Income_Clear.Click

        ClearText()

    End Sub

    Private Sub Chk_Income_Refund_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Refund.CheckedChanged


        If Chk_Income_Refund.Checked = True Then

            Dtp_Income_Refund.Enabled = True
            Dtp_Income_Refund.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Refund.Enabled = False
            Dtp_Income_Refund.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay1.CheckedChanged

        If Chk_Income_Pay1.Checked = True Then

            Dtp_Income_Pay1.Enabled = True
            Dtp_Income_Pay1.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay1.Enabled = False
            Dtp_Income_Pay1.Text = ""

        End If

    End Sub

    Private Sub Chk_Income_Pay2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay2.CheckedChanged

        If Chk_Income_Pay2.Checked = True Then

            Dtp_Income_Pay2.Enabled = True
            Dtp_Income_Pay2.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay2.Enabled = False
            Dtp_Income_Pay2.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay3_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay3.CheckedChanged

        If Chk_Income_Pay3.Checked = True Then

            Dtp_Income_Pay3.Enabled = True
            Dtp_Income_Pay3.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay3.Enabled = False
            Dtp_Income_Pay3.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay4_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay4.CheckedChanged

        If Chk_Income_Pay4.Checked = True Then

            Dtp_Income_Pay4.Enabled = True
            Dtp_Income_Pay4.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay4.Enabled = False
            Dtp_Income_Pay4.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay5_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay5.CheckedChanged

        If Chk_Income_Pay5.Checked = True Then

            Dtp_Income_Pay5.Enabled = True
            Dtp_Income_Pay5.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay5.Enabled = False
            Dtp_Income_Pay5.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay6_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay6.CheckedChanged

        If Chk_Income_Pay6.Checked = True Then

            Dtp_Income_Pay6.Enabled = True
            Dtp_Income_Pay6.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay6.Enabled = False
            Dtp_Income_Pay6.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay7_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay7.CheckedChanged

        If Chk_Income_Pay7.Checked = True Then

            Dtp_Income_Pay7.Enabled = True
            Dtp_Income_Pay7.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay7.Enabled = False
            Dtp_Income_Pay7.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay8_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay8.CheckedChanged

        If Chk_Income_Pay8.Checked = True Then

            Dtp_Income_Pay8.Enabled = True
            Dtp_Income_Pay8.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay8.Enabled = False
            Dtp_Income_Pay8.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay9_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay9.CheckedChanged

        If Chk_Income_Pay9.Checked = True Then

            Dtp_Income_Pay9.Enabled = True
            Dtp_Income_Pay9.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay9.Enabled = False
            Dtp_Income_Pay9.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay10_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay10.CheckedChanged

        If Chk_Income_Pay10.Checked = True Then

            Dtp_Income_Pay10.Enabled = True
            Dtp_Income_Pay10.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay10.Enabled = False
            Dtp_Income_Pay10.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay11_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay11.CheckedChanged

        If Chk_Income_Pay11.Checked = True Then

            Dtp_Income_Pay11.Enabled = True
            Dtp_Income_Pay11.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay11.Enabled = False
            Dtp_Income_Pay11.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay12_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay12.CheckedChanged

        If Chk_Income_Pay12.Checked = True Then

            Dtp_Income_Pay12.Enabled = True
            Dtp_Income_Pay12.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay12.Enabled = False
            Dtp_Income_Pay12.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay13_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay13.CheckedChanged

        If Chk_Income_Pay13.Checked = True Then

            Dtp_Income_Pay13.Enabled = True
            Dtp_Income_Pay13.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay13.Enabled = False
            Dtp_Income_Pay13.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay14_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay14.CheckedChanged

        If Chk_Income_Pay14.Checked = True Then

            Dtp_Income_Pay14.Enabled = True
            Dtp_Income_Pay14.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay14.Enabled = False
            Dtp_Income_Pay14.Text = ""
        End If

    End Sub

    Private Sub Chk_Income_Pay15_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Income_Pay15.CheckedChanged

        If Chk_Income_Pay15.Checked = True Then

            Dtp_Income_Pay15.Enabled = True
            Dtp_Income_Pay15.Text = Dtp_Income_DateSheet.Text
        Else
            Dtp_Income_Pay15.Enabled = False
            Dtp_Income_Pay15.Text = ""
        End If

    End Sub

    Private Sub Cmd_Income_Update_Click(sender As Object, e As EventArgs) Handles Cmd_Income_Update.Click


        QueryupdateIncome()

        QueryupdateIncomeResult()

        cn.Close()
        ClearText()

    End Sub
    Private Sub QueryupdateIncome()

        Connect()

        sql = $"SELECT EMPLOYEES_KEY FROM EXEEMPLOYEE WHERE EXEEMPLOYEES = '{Cbo_Income_Employees.Text}'"
        cmd = New SqlCommand(sql, cn)
        Dim Query_empkey As Integer = cmd.ExecuteScalar()

        cmd = New SqlCommand(sql, cn)
        cmd.ExecuteScalar()

        sql = $"UPDATE Execution_Income SET Customer_owner= '{Cbo_Income_Owner.Text}' ,Customer_id_card= '{Txt_Income_Idcus.Text}',Customer_Account = '{Txt_Income_Acc.Text}',Customer_Account_no = '{Txt_Income_Accno.Text}',Customer_prefix = '{cbo_income_prefix.Text}',Customer_firstname = '{Txt_Income_Firstname.Text}',Customer_lastname = '{Txt_Income_Lastname.Text}',Customer_fullname= '{Txt_Income_Fullname.Text}',Income_court = '{Txt_Income_Court.Text}',Income_black ='{Txt_Income_Black.Text}',Income_red = '{Txt_Income_Red.Text}',EMPLOYEES_KEY = {Query_empkey} ,Income_type ='{Cbo_Income_Type.Text}',Income_detail = '{Txt_Income_Detail.Text}',Income_date_sheet = '{Dtp_Income_DateSheet.Text}',Income_date_work = '{Dtp_Income_Datework.Text}',Income_total_check = {Txt_Income_Total.Text} WHERE Income_key = '{Lbl_primarykey.Text}'"

        cmd = New SqlCommand(sql, cn)
        Dim QueryIncomeUpdate As Integer = cmd.ExecuteNonQuery()

        If QueryIncomeUpdate > 0 Then

            Lbl_Income_Invalid.Visible = True
            Lbl_Income_Invalid.ForeColor = Color.Green
            Lbl_Income_Invalid.Text = $"อัพเดทข้อมูล {QueryIncomeUpdate} รายการ"

            Getlogdataexe($"อัพเดทข้อมูล เงินส่วนได้ ธนาคาร {Cbo_Income_Owner.Text} ลูกค้าชื่อ{Txt_Income_Fullname.Text} ประเภท {Cbo_Income_Type.Text} จำนวนเงิน {Txt_Income_Total.Text}", $"'{Txt_Income_Idcus.Text}'", $"'{Txt_Income_Acc.Text}'")

        Else

            Lbl_Income_Invalid.Visible = True
            Lbl_Income_Invalid.ForeColor = Color.Red
            Lbl_Income_Invalid.Text = $"อัพเดทล้มเหลว {QueryIncomeUpdate} รายการ"




        End If

    End Sub
    Private Sub Cmd_Income_Linkdata_Click(sender As Object, e As EventArgs) Handles Cmd_Income_Linkdata.Click

        Linkdatebase_()

    End Sub
    Private Sub QueryupdateIncomeResult()

        sql = $"UPDATE Execution_Income_Result SET"

        If Chk_Income_Refund.Checked = True Then

            sql &= $" Income_refund ={Txt_Income_Refund.Text},Income_refund_date ='{Dtp_Income_Refund.Text}',"

        ElseIf Chk_Income_Refund.Checked = False Then

            sql &= " Income_refund =0,Income_refund_date = NULL,"

        End If

        sql &= $"Income_grandtotal = {Txt_Income_GrandTotal.Text},"

        If Chk_Income_Pay1.Checked = True Then

            sql &= $" Income_statement_1 = {Txt_Income_Pay1.Text} ,Income_refund_date1 ='{Dtp_Income_Pay1.Text}',"

        ElseIf Chk_Income_Pay1.Checked = False Then

            sql &= " Income_statement_1 = 0 ,Income_refund_date1 = NULL,"

        End If

        If Chk_Income_Pay2.Checked = True Then

            sql &= $" Income_statement_2 = {Txt_Income_Pay2.Text} ,Income_refund_date2 ='{Dtp_Income_Pay2.Text}',"

        ElseIf Chk_Income_Pay2.Checked = False Then

            sql &= " Income_statement_2 = 0 ,Income_refund_date2 = NULL,"

        End If

        If Chk_Income_Pay3.Checked = True Then

            sql &= $" Income_statement_3 = {Txt_Income_Pay3.Text} ,Income_refund_date3 ='{Dtp_Income_Pay3.Text}',"

        ElseIf Chk_Income_Pay3.Checked = False Then

            sql &= " Income_statement_3 = 0 ,Income_refund_date3 = NULL,"

        End If

        If Chk_Income_Pay4.Checked = True Then

            sql &= $" Income_statement_4 = {Txt_Income_Pay4.Text} ,Income_refund_date4 ='{Dtp_Income_Pay4.Text}',"

        ElseIf Chk_Income_Pay4.Checked = False Then

            sql &= " Income_statement_4 = 0 ,Income_refund_date4 = NULL,"

        End If


        If Chk_Income_Pay5.Checked = True Then

            sql &= $" Income_statement_5 = {Txt_Income_Pay5.Text} ,Income_refund_date5 ='{Dtp_Income_Pay5.Text}',"

        ElseIf Chk_Income_Pay5.Checked = False Then

            sql &= " Income_statement_5 = 0 ,Income_refund_date5 = NULL,"

        End If

        If Chk_Income_Pay6.Checked = True Then

            sql &= $" Income_statement_6 = {Txt_Income_Pay6.Text} ,Income_refund_date6 ='{Dtp_Income_Pay6.Text}',"

        ElseIf Chk_Income_Pay6.Checked = False Then

            sql &= " Income_statement_6 = 0 ,Income_refund_date6 = NULL,"

        End If

        If Chk_Income_Pay7.Checked = True Then

            sql &= $" Income_statement_7 = {Txt_Income_Pay7.Text} ,Income_refund_date7 ='{Dtp_Income_Pay7.Text}',"

        ElseIf Chk_Income_Pay7.Checked = False Then
            sql &= " Income_statement_7 = 0 ,Income_refund_date7 = NULL,"

        End If

        If Chk_Income_Pay8.Checked = True Then

            sql &= $" Income_statement_8 = {Txt_Income_Pay8.Text} ,Income_refund_date8 ='{Dtp_Income_Pay8.Text}',"

        ElseIf Chk_Income_Pay8.Checked = False Then

            sql &= " Income_statement_8 = 0 ,Income_refund_date8 = NULL,"

        End If

        If Chk_Income_Pay9.Checked = True Then

            sql &= $" Income_statement_9 = {Txt_Income_Pay9.Text} ,Income_refund_date9 ='{Dtp_Income_Pay9.Text}',"

        ElseIf Chk_Income_Pay9.Checked = False Then

            sql &= " Income_statement_9 = 0 ,Income_refund_date9 = NULL,"

        End If

        If Chk_Income_Pay10.Checked = True Then

            sql &= $" Income_statement_10 = {Txt_Income_Pay10.Text} ,Income_refund_date10 ='{Dtp_Income_Pay10.Text}',"

        ElseIf Chk_Income_Pay10.Checked = False Then

            sql &= " Income_statement_10 = 0 ,Income_refund_date10 = NULL,"

        End If

        If Chk_Income_Pay11.Checked = True Then

            sql &= $" Income_statement_11 = {Txt_Income_Pay11.Text} ,Income_refund_date11 ='{Dtp_Income_Pay11.Text}',"

        ElseIf Chk_Income_Pay11.Checked = False Then

            sql &= " Income_statement_11 = 0 ,Income_refund_date11 = NULL,"

        End If

        If Chk_Income_Pay12.Checked = True Then

            sql &= $" Income_statement_12 = {Txt_Income_Pay12.Text} ,Income_refund_date12 ='{Dtp_Income_Pay12.Text}',"

        ElseIf Chk_Income_Pay12.Checked = False Then

            sql &= " Income_statement_12 = 0 ,Income_refund_date12 = NULL,"

        End If


        If Chk_Income_Pay13.Checked = True Then

            sql &= $" Income_statement_13 = {Txt_Income_Pay13.Text} ,Income_refund_date13 ='{Dtp_Income_Pay13.Text}',"

        ElseIf Chk_Income_Pay13.Checked = False Then

            sql &= " Income_statement_13 = 0 ,Income_refund_date13 = NULL,"

        End If

        If Chk_Income_Pay14.Checked = True Then

            sql &= $" Income_statement_14 = {Txt_Income_Pay14.Text} ,Income_refund_date14 ='{Dtp_Income_Pay14.Text}',"

        ElseIf Chk_Income_Pay14.Checked = False Then

            sql &= " Income_statement_14 = 0 ,Income_refund_date14 = NULL,"

        End If

        If Chk_Income_Pay15.Checked = True Then

            sql &= $" Income_statement_15 = {Txt_Income_Pay15.Text} ,Income_refund_date15 ='{Dtp_Income_Pay15.Text}'"

        ElseIf Chk_Income_Pay15.Checked = False Then

            sql &= " Income_statement_15 = 0 ,Income_refund_date15 = NULL"

        End If

        sql &= $" WHERE Customer_id_card = '{Txt_Income_Idcus.Text}' AND Customer_Account = '{Txt_Income_Acc.Text}'"

        cmd = New SqlCommand(sql, cn)
        Dim QueryUpdateresult As Integer = cmd.ExecuteNonQuery

        If QueryUpdateresult > 0 Then

            Lbl_Income_Invalid.Visible = True
            Lbl_Income_Invalid.ForeColor = Color.Green
            Lbl_Income_Invalid.Text = $"อัพเดทข้อมูล {QueryUpdateresult} รายการ"

            Getlogdataexe($"อัพเดทข้อมูล เช็ค บัญชีรับ-จ่าย ธนาคาร {Cbo_Income_Owner.Text} ลูกค้าชื่อ{Txt_Income_Fullname.Text} ประเภท {Cbo_Income_Type.Text} จำนวนเงิน {Txt_Income_Total.Text}", $"'{Txt_Income_Idcus.Text}'", $"'{Txt_Income_Acc.Text}'")

        Else

            Lbl_Income_Invalid.Visible = True
            Lbl_Income_Invalid.ForeColor = Color.Red
            Lbl_Income_Invalid.Text = $"อัพเดทล้มเหลว {QueryUpdateresult} รายการ"

        End If

    End Sub
    Private Sub Linkdatebase_()


        Select Case Cbo_Income_Owner.SelectedItem

            Case "KBANK" : Connect_(cn_KBANK)
                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Income_Acc.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Income_Accno.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                    Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Income_Fullname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_income_result.Visible = True
                    Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_income_result.ForeColor = Color.Green

                Else
                    sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Income_Idcus.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Income_Accno.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                        Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Income_Fullname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Green

                    Else
                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_income_result.ForeColor = Color.Red

                End If

                End If

                cn_KBANK.Close()

            Case "KKB" : Connect_(cn_KKB)
                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Income_Acc.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_KKB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Income_Fullname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_income_result.Visible = True
                    Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_income_result.ForeColor = Color.Green


                Else
                    sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Income_Idcus.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_KKB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Income_Fullname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Green
                    Else
                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Red

                    End If
                End If

                    cn_KKB.Close()

            Case "SCB" : Connect_(cn_SCB)
                sqll = $"SELECT RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Income_Acc.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_SCB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then


                    Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                    Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_income_result.Visible = True
                    Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_income_result.ForeColor = Color.Green


                Else

                    sqll = $"SELECT RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Income_Idcus.Text}'"
                    cmd_Collec = New SqlCommand(sqll, cn_SCB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                        Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Green

                    Else
                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Red

                    End If
                End If

                    cn_SCB.Close()

            Case "TSS" : Connect_(cn_GE)

                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWSAN,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Income_Acc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_GE)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"

                        Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Green
                    Else


                        sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Income_Idcus.Text}'"

                        cmd_Collec = New SqlCommand(sqll, cn_GE)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                            Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                            Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                            Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                            Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                            Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                            Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                            Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                            Lbl_income_result.Visible = True
                            Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                            Lbl_income_result.ForeColor = Color.Green

                        Else
                            Lbl_income_result.Visible = True
                            Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                            Lbl_income_result.ForeColor = Color.Red

                        End If

                    End If

                cn_GE.Close()

            Case "TMB" : Connect_(cn_TMB)
                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Income_Acc.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TMB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then


                    Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                    Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_income_result.Visible = True
                    Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_income_result.ForeColor = Color.Green

                Else
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Income_Idcus.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                        Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Green

                    Else
                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Red

                    End If

                End If
                    cn_TMB.Close()

            Case "TMB SME" : Connect_(cn_TMBSME)
                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Income_Acc.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                    Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_income_result.Visible = True
                    Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_income_result.ForeColor = Color.Green

                Else
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Income_Idcus.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")


                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                        Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Green

                    Else
                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Red

                    End If

                End If

                    cn_TMBSME.Close()

            Case "TBANK" : Connect_(cn_TBANK)

                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Txt_Income_Acc.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                    Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_income_result.Visible = True
                    Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_income_result.ForeColor = Color.Green
                Else
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSIDC = '{Txt_Income_Idcus.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                        Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Green

                    Else
                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Red

                    End If
                End If
                    cn_TBANK.Close()

            Case "UOB" : Connect_(cn_UOB)

                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Txt_Income_Acc.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_UOB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                    Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_income_result.Visible = True
                    Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_income_result.ForeColor = Color.Green

                Else

                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Txt_Income_Acc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_UOB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Income_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Income_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Income_Idcus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Income_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Income_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Income_Fullname.Text = $"{Txt_Income_Firstname.Text} {Txt_Income_Lastname.Text}"
                        Txt_Income_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Income_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Else
                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Red

                    End If

                End If

                    cn_UOB.Close()

            Case Else : Connect_(cnLegal)

                sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{Txt_Income_Idcus.Text}'"
                cmdlegal = New SqlCommand(sqll, cnLegal)
                    DALegal = New SqlDataAdapter(cmdlegal)
                    DSLegal = New DataSet
                    DALegal.Fill(DSLegal, "linklegal")

                If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                    Txt_Income_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                    Txt_Income_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                    Txt_Income_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                    Txt_Income_Accno.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                    Txt_Income_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                    Txt_Income_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                    Txt_Income_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                    Txt_Income_Acc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                    Txt_Income_Idcus.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString

                    Lbl_income_result.Visible = True
                    Lbl_income_result.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                    Lbl_income_result.ForeColor = Color.Green

                Else

                    sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Txt_Income_Acc.Text}'"
                    cmdlegal = New SqlCommand(sqll, cnLegal)
                        DALegal = New SqlDataAdapter(cmdlegal)
                        DSLegal = New DataSet
                        DALegal.Fill(DSLegal, "linklegal")

                    If DSLegal.Tables("linklegal").Rows.Count > 0 Then


                        Txt_Income_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                        Txt_Income_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                        Txt_Income_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                        Txt_Income_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                        Txt_Income_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                        Txt_Income_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                        Txt_Income_Acc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                        Txt_Income_Accno.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                        Txt_Income_Idcus.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString

                        Lbl_income_result.Visible = True
                        Lbl_income_result.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                        Lbl_income_result.ForeColor = Color.Green

                    Else
                        Lbl_income_result.Visible = True
                            Lbl_income_result.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                            Lbl_income_result.ForeColor = Color.Red

                        End If

                    End If

                cnLegal.Close()

        End Select

        LinkIncomeResult()

    End Sub

    Private Sub QuerySelect_()

        Connect()

        Cleardatagrid(Dtgv_Income)

        If Cbo_Income_find.Text = "" Then
            Msg_error("กรุณาเลือกประเภทข้อมูลที่ต้องการค้นหา")
            Exit Sub
        End If

        If Txt_Income_find.Text = "" Then
            Msg_error("กรุณากรอกข้อมุลที่ต้องการค้นหา")
            Return
        End If

        sql = $"SELECT EI.*,EMP.EXEEMPLOYEES FROM Execution_income AS EI LEFT JOIN EXEEMPLOYEE AS EMP ON EMP.EMPLOYEES_KEY = EI.EMPLOYEES_KEY "

        Select Case Cbo_Income_find.SelectedItem

            Case "ธนาคาร" : sql &= $"WHERE EI.Customer_Owner"
            Case "เลขบัตรประชาชน" : sql &= $"WHERE EI.Customer_id_card"
            Case "เลขที่สัญญา" : sql &= $"WHERE EI.Customer_Account"
            Case "ขื่อ" : sql &= $"WHERE EI.Customer_firstname"
            Case "นามสกุล" : sql &= $"WHERE EI.Customer_lastname"
            Case "เลขที่คดีดำ" : sql &= $"WHERE EI.income_black"
            Case "เลขที่คดีแดง" : sql &= $"WHERE EI.income_red"

        End Select

        sql &= $" LIKE '%{Txt_Income_find.Text}%' ORDER BY EI.Income_date_work DESC"


        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "_search")

        If DS.Tables("_search").Rows.Count <= 0 Then

            Lbl_income_result.Text = "ไม่พบข้อมูลที่ค้นหา.."
            Lbl_income_result.ForeColor = Color.Red
            Dtgv_Income.Visible = False
            Return

        Else

            With Dtgv_Income
                .DataSource = DS.Tables("_search")

                For i = 0 To Dtgv_Income.ColumnCount - 1

                    .Columns(0).Visible = False
                    '    .Columns(4).Visible = False
                    '    .Columns(5).Visible = False
                    '    .Columns(6).Visible = False
                    '    .Columns(7).Visible = False

                    .Columns(12).Visible = False
                    .Columns(13).Visible = False
                    .Columns(14).Visible = False

                    .Columns(16).Visible = False

                    .Columns(18).Visible = False

                Next

                'For y = 18 To Dtgv_Income.ColumnCount - 1
                '    .Columns(y).Visible = False
                '    If y = 55 Then
                '        Continue For
                '    End If
                'Next

            End With

            Dtgv_Income.Visible = True

            Lbl_income_result.Text = $"พบข้อมูล {Dtgv_Income.RowCount} รายการ.."
            Lbl_income_result.ForeColor = Color.Green

        End If

        cn.Close()
    End Sub

    Private Sub Dtgv_Income_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgv_Income.CellClick


        Dim PrimaryEMP As Integer


        Dim Information_Customer() As Object = {Lbl_primarykey, Cbo_Income_Owner, Txt_Income_Idcus, Txt_Income_Acc, Txt_Income_Accno, cbo_income_prefix, Txt_Income_Firstname, Txt_Income_Lastname, Txt_Income_Fullname, Txt_Income_Court, Txt_Income_Black, Txt_Income_Red, PrimaryEMP, Cbo_Income_Type, Txt_Income_Detail, Dtp_Income_DateSheet, Dtp_Income_Datework, Txt_Income_Total, Cbo_Income_Employees}


        With Dtgv_Income

            For i As Integer = 0 To Information_Customer.Length

                Try
                    If .CurrentRow.Cells(i).Value.ToString <> "" Then

                        Information_Customer(i).text = .CurrentRow.Cells(i).Value.ToString

                    End If

                Catch

                End Try

            Next

            If .CurrentRow.Cells(16).Value.ToString <> "" Then

                Chk_Income_DateSheet.Checked = True

            Else

                Chk_Income_DateSheet.Checked = False

            End If

            If .CurrentRow.Cells(17).Value.ToString <> "" Then

                Chk_Income_Datework.Checked = True

            Else

                Chk_Income_Datework.Checked = False

            End If

            'เปลี่ยนค่าตัวเลขใน Textbox ให้เป็นจำนวน เงิน หรือ String ("##,##0.00")

            Convertdouble(Txt_Income_Total)

            'เปลี่ยนค่าใน Datetimepicker ให้เป็น ShortDate "dd-MMM-yy"

            Datetimeformatshort(Dtp_Income_DateSheet)
            Datetimeformatshort(Dtp_Income_Datework)

        End With

        LinkIncomeResult()

    End Sub
    Private Sub LinkIncomeResult()

        Dim Txt_Information() As TextBox = {Txt_Income_Refund, Txt_Income_Pay1, Txt_Income_Pay2, Txt_Income_Pay3, Txt_Income_Pay4, Txt_Income_Pay5, Txt_Income_Pay6, Txt_Income_Pay7, Txt_Income_Pay8, Txt_Income_Pay9, Txt_Income_Pay10, Txt_Income_Pay11, Txt_Income_Pay12, Txt_Income_Pay13, Txt_Income_Pay14, Txt_Income_Pay15, Txt_Income_GrandTotal}

        Dim dtp_information() As DateTimePicker = {Dtp_Income_Refund, Dtp_Income_Pay1, Dtp_Income_Pay2, Dtp_Income_Pay3, Dtp_Income_Pay4, Dtp_Income_Pay5, Dtp_Income_Pay6, Dtp_Income_Pay7, Dtp_Income_Pay8, Dtp_Income_Pay9, Dtp_Income_Pay10, Dtp_Income_Pay11, Dtp_Income_Pay12, Dtp_Income_Pay13, Dtp_Income_Pay14, Dtp_Income_Pay15}

        Dim check_datetime() As CheckBox = {Chk_Income_Refund, Chk_Income_Pay1, Chk_Income_Pay2, Chk_Income_Pay3, Chk_Income_Pay4, Chk_Income_Pay5, Chk_Income_Pay6, Chk_Income_Pay7, Chk_Income_Pay8, Chk_Income_Pay9, Chk_Income_Pay10, Chk_Income_Pay11, Chk_Income_Pay12, Chk_Income_Pay13, Chk_Income_Pay14, Chk_Income_Pay15}

        Connect()

        sql = $"SELECT Income_refund,Income_statement_1,Income_statement_2,Income_statement_3,Income_statement_4,Income_statement_5,Income_statement_6,Income_statement_7,Income_statement_8,Income_statement_9,Income_statement_10,Income_statement_11,Income_statement_12,Income_statement_13,Income_statement_14,Income_statement_15,Income_grandtotal,Income_refund_date,Income_refund_date1,Income_refund_date2,Income_refund_date3,Income_refund_date4,Income_refund_date5,Income_refund_date6,Income_refund_date7,Income_refund_date8,Income_refund_date9,Income_refund_date10,Income_refund_date11,Income_refund_date12,Income_refund_date13,Income_refund_date14,Income_refund_date15 FROM Execution_income_result "

        If Txt_Income_Acc.Text <> "" And Txt_Income_Idcus.Text <> "" Then

            sql &= $"WHERE Customer_Account = '{Txt_Income_Acc.Text}' AND Customer_Id_card = '{Txt_Income_Idcus.Text}' ;"

        ElseIf Txt_Income_Acc.Text = "" Then

            sql &= $"WHERE Customer_Id_card = '{Txt_Income_Idcus.Text}' ;"

        ElseIf Txt_Income_Idcus.Text = "" Then

            sql &= $"WHERE Customer_Account = '{Txt_Income_Acc.Text}' ;"

        ElseIf Txt_Income_Acc.Text = "" And Txt_Income_Idcus.Text = "" Then

            Lbl_income_result.Text = "ไม่พบข้อมูลบัญชีรับจ่าย ก่อนหน้า"
            sql &= $"WHERE Customer_Account = '{Txt_Income_Acc.Text}' AND WHERE Customer_id_card = '{Txt_Income_Idcus.Text}'"


        End If

        cmd = New SqlCommand(sql, cn)
            DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "income")

        If DS.Tables("income").Rows.Count = 0 Then

            Lbl_income_result.Text = "ไม่พบข้อมูลบัญชีรับจ่าย ก่อนหน้า"
            Exit Sub

        End If

        Try

            Dim i As Integer = 0

            Do

                With DS.Tables("income")

                    Txt_Information(i).Text = .Rows(0)(i).ToString
                    i += 1

                End With

            Loop Until i = 17

            Dim y As Integer = 0


            While (y < 15)

                dtp_information(y).Text = DS.Tables("income").Rows(0)(i).ToString
                y += 1
                i += 1

            End While

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

        Dim checkdate As Integer = 0
        Dim len As Integer = check_datetime.Length
        Dim columnslen As Integer = 17

        While (checkdate < len)

            If DS.Tables("income").Rows(0)(columnslen).ToString <> "" Then

                check_datetime(checkdate).Checked = True

            Else

                check_datetime(checkdate).Checked = False

            End If

            columnslen += 1
            checkdate += 1

        End While

        Dim Numlength As Integer = 0

        'เปลี่ยนค่าตัวเลขใน Textbox ให้เป็นจำนวน เงิน หรือ String ("##,##0.00")

        While (Numlength < Txt_Information.Length)

            Convertdouble(Txt_Information(Numlength))
            Numlength += 1

        End While

        Numlength = 0

        'เปลี่ยนค่าใน Datetimepicker ให้เป็น ShortDate "dd-MMM-yy"

        While (Numlength < dtp_information.Length)

            Datetimeformatshort(dtp_information(Numlength))
            Numlength += 1

        End While

    End Sub

    Private Sub Cmd_Income_Find_Click(sender As Object, e As EventArgs) Handles Cmd_Income_Find.Click

        Connect()
        QuerySelect_()

    End Sub

    Private Sub Txt_Income_Refund_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Refund.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay1.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Total.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay2.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay3.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay4.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay5.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay6.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay7.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay8.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay9.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay10.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay11.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay12.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay13.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay14.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_Income_Pay15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Income_Pay15.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub


    Private Sub Txt_Income_GrandTotal_DoubleClick(sender As Object, e As EventArgs) Handles Txt_Income_GrandTotal.DoubleClick

        Try

            Dim x As Double = Val(Txt_Income_Refund.Text) + Val(Txt_Income_Pay1.Text) + Val(Txt_Income_Pay2.Text) + Val(Txt_Income_Pay3.Text) + Val(Txt_Income_Pay4.Text) + Val(Txt_Income_Pay5.Text) + Val(Txt_Income_Pay6.Text) + Val(Txt_Income_Pay7.Text) + Val(Txt_Income_Pay8.Text) + Val(Txt_Income_Pay9.Text) + Val(Txt_Income_Pay10.Text) + Val(Txt_Income_Pay11.Text) + Val(Txt_Income_Pay12.Text) + Val(Txt_Income_Pay13.Text) + Val(Txt_Income_Pay14.Text) + Val(Txt_Income_Pay15.Text)

            Txt_Income_GrandTotal.Text = x

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub FrmIncome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

End Class