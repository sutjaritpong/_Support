Imports System.Data.SqlClient
Public Class FrmTracking

    Friend header() As String = {"PK", "ธนาคาร", "เลขประจำตัวประชาชน", "เลขที่สัญญา", "ชื่อลูกค้า", "ศาล", "คดีแดง", "วันที่ในใบคำร้อง", "วันที่ลงข้อมูลในระบบ", "จำนวนเงินที่พบ", "ชื่อพนักงานบังคับคดี", "", "", "", ""}

    '## Sub Load นำข้อมูลจาก Array เพิ่มไปใน Sub _cboArray ใช้เพิ่มข้อมูล ใน Combobox' 
    Private Sub FrmTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        Datetimeformatshort(dtp_date_send)
        Datetimeformatshort(dtp_date_verify)
        Datetimeformatshort(dtp_date_work)


        Dim Typefind() As String = {"เลขที่สัญญา", "เลขประจำตัวประชาชน", "ชื่อ-นามสกุล", "เลขที่คดีแดง", "พนักงานบังคับคดี"}

        CboArray(cbo_type_find, Typefind)
        cbo_type_find.SelectedIndex = 0

        '## เพิ่มข้อมูลลงใน Combobox โดยใช้ Array และ Method .items.addrange() นำมาสร้างเป็น Sub _cboArray และ ใช้การเพิ่มข้อมูลจาก Columns โดยดึงข้อมูลจาก Database มาแล้วใช้ Method command.ExecuteReader() อ่านข้อมูลใน คอลัมน์ ที่ Query มา แล้วนำมาแสดงโดยการใช้ While Loop ##'

        Cleardatagrid(Dtgv_Accounting)

        Dim _nosend() As String = {"ไม่ได้ส่งมาออกใบงานแถลงบัญชี", "ส่งมาออกใบงาน"}
        CboArray(cbo_waning, _nosend)
        cbo_waning.SelectedIndex = -1

        Dim _tracking() As String = {"ไม่มีใบงานแถลงบัญชี", "มีใบงานแถลงบัญชี"}
        CboArray(cbo_document, _tracking)
        cbo_document.SelectedIndex = -1


        Comboboxadd(cbo_owner, "EXEBANK", "EXESM")
        cbo_owner.SelectedIndex = -1

        Connect()

        sql = $"SELECT DISTINCT EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '02-EXECUTION'"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()
        While DR.Read()

            cbo_empexe.Items.Add($"{DR("EXEEMPLOYEES")}")

        End While

        DR.Close()

        sql = $"SELECT DISTINCT Tracking_detail FROM EXETRACKING"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()

            cbo_detail.Items.Add($"{DR("Tracking_detail")}")

        End While

        DR.Close()

        '## สร้าง Autocomplete ให้กับ txt_cusid โดยดึงข้อมูล ของ Column EXEID ใน Table EXESM ##'

        Autocompletecombo(txt_cusname, "EXECUSTOMER", "EXESM")
        Autocompletecombo(txt_cusid, "EXEID", "EXESM")

        Readonly_Obj()
        Clear_Obj()
        cn.Close()

    End Sub

    Private Sub Loaddatagridviews()

        Connect()


        Dim p As Integer = header.Length

        If txt_find.Text = "" Then

            Msg_error("กรุณากรอกข้อมูลในช่องค้นหา")
            Return

        End If

        Dim sqll As String = "SELECT ETR.Tracking_Primary,ETR.Customer_Owner,ETR.Customer_idc,ETR.Customer_Account,ETR.Customer_Fullname,ETR.Tracking_court,ETR.Tracking_red,ETR.Tracking_date_sheet,ETR.Tracking_date_work,ETR.Tracking_total,EMP.EXEEMPLOYEES,ETR.Tracking_detail,ETR.Tracking_nosheet,ETR.Tracking_Collector_nosend,ETR.Tracking_other  FROM EXETRACKING AS ETR LEFT JOIN EXEEMPLOYEE AS EMP ON ETR.EMPLOYEES_KEY = EMP.EMPLOYEES_KEY WHERE "

        Select Case cbo_type_find.SelectedItem


            Case "เลขประจำตัวประชาชน" : sqll &= "ETR.Customer_idc "
            Case "เลขที่สัญญา" : sqll &= $"ETR.Customer_account "
            Case "ชื่อ-นามสกุล" : sqll &= "ETR.Customer_fullname "
            Case "เลขที่คดีแดง" : sqll &= "ETR.Tracking_red "
            Case "พนักงานบังคับคดี" : sqll &= "EMP.EXEEMPLOYEES "


        End Select

        sqll &= $"Like '%{txt_find.Text}%' ORDER BY ETR.Tracking_date_sheet "

        cmd = New SqlCommand(sqll, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "find")

        If DS.Tables("find").Rows.Count <= 0 Then

            Msg_error("ไม่พบข้อมูลที่ค้นหา")

            Return

        End If

        For i = 0 To header.Length - 1

            Dtgv_Tracking.DataSource = DS.Tables("find")
            Dtgv_Tracking.Columns(i).HeaderText = header(i)

        Next

        For i = 11 To Dtgv_Tracking.Columns.Count - 1


            Dtgv_Tracking.Columns(i).Visible = False


        Next

        Dtgv_Tracking.Columns(0).Visible = False

        Datagrid_format_dateshort(Dtgv_Tracking, 7)
        Datagrid_format_dateshort(Dtgv_Tracking, 8)

        cn.Close()


        Lbl_Accounting.Text = $"พบ {Dtgv_Tracking.Rows.Count} รายการ "

    End Sub

    '## Event CheckedChanged ใช้ในการเช็คค่าของ Checkbox ##'
    Private Sub Chk_datetracking_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datetracking.CheckedChanged

        If chk_datetracking.Checked = True Then

            dtp_date_verify.Enabled = True
        Else
            dtp_date_verify.Enabled = False

        End If

    End Sub

    '## Event CheckedChanged ใช้ในการเช็คค่าของ Checkbox ##'
    Private Sub Chk_datesend_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datesend.CheckedChanged

        If chk_datesend.Checked = True Then

            dtp_date_send.Enabled = True
        Else
            dtp_date_send.Enabled = False

        End If


    End Sub

    ' ## Event Button Click เมื่อกดปุ่มจะทำงาน ในที่นี้ให้แสดง ข้อมูลที่ลิ้งจาก txt_cusid มาแสดงใน Datagridview และ นำไปแสดงใน Textbox ด้วย อื่น ๆ ##'
    Private Sub Cmd_links_Click(sender As Object, e As EventArgs) Handles cmd_links.Click

        If Dtgv_Tracking.RowCount = 0 Or Dtgv_Tracking.ColumnCount = 0 Then

            Dtgv_Tracking.DataSource = Nothing

        End If
        If Dtgv_Accounting.RowCount = 0 Or Dtgv_Accounting.ColumnCount = 0 Then
            Dtgv_Accounting.DataSource = Nothing
        End If

        Connect()

        sql = $"SELECT S.EXEBANK,S.EXEID,S.EXEACC1,S.EXECUSTOMER,S.EXECOURT,S.EXERED,S.EXEDATEWORK,TR.Tracking_date_sheet,TR.Tracking_other FROM EXESM AS S LEFT JOIN EXETRACKING AS TR ON S.EXEID = TR.Customer_IDC  WHERE S.EXEID = '{txt_cusid.Text}'"

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "tables")

        If DS.Tables("tables").Rows.Count = 0 Then
            Lbl_Accounting.Text = "ไม่พบข้อมูล"
            Exit Sub
        End If

        txt_cusid.Text = DS.Tables("tables").Rows(0)("EXEID").ToString
        Txt_Account.Text = DS.Tables("tables").Rows(0)("EXEACC1").ToString
        cbo_owner.Text = DS.Tables("tables").Rows(0)("EXEBANK").ToString
        txt_cusname.Text = DS.Tables("tables").Rows(0)("EXECUSTOMER").ToString
        txt_red.Text = DS.Tables("tables").Rows(0)("EXERED").ToString
        txt_court.Text = DS.Tables("tables").Rows(0)("EXECOURT").ToString
        dtp_date_send.Text = DS.Tables("tables").Rows(0)("EXEDATEWORK").ToString
        dtp_date_verify.Text = DS.Tables("tables").Rows(0)("Tracking_date_sheet").ToString
        txt_detail.Text = DS.Tables("tables").Rows(0)("Tracking_other").ToString

        If DS.Tables("tables").Rows(0)("EXEDATEWORK").ToString = "" Then

            chk_datesend.Checked = False

        Else

            chk_datesend.Checked = True

        End If

        If DS.Tables("tables").Rows(0)("Tracking_date_sheet").ToString = "" Then

            chk_datetracking.Checked = False

        Else

            chk_datetracking.Checked = True

        End If


        If chk_datesend.Checked = False Then

            cbo_waning.Text = "ไม่ได้ส่งมาออกใบงานแถลงบัญชี"

        Else

            cbo_waning.Text = "ส่งมาออกใบงาน"

        End If

        Dim _headers() As String = {"ธนาคาร", "เลขบัตรประชาชน", "เลขที่สัญญา", "ชื่อ-นามสกุล", "ศาล", "เลขคดีแดง", "วันที่ออกใบงานแถลงบัญชี", "วันที่ตรวจสำนวน", "เพิ่มเติม"}

        With Dtgv_Accounting

            .DataSource = DS.Tables("tables")

            For i = 0 To _headers.Length - 1

                .Columns(i).HeaderText = _headers(i)

            Next

        End With

        If (Dtgv_Accounting.RowCount = 0) Or (Dtgv_Accounting.ColumnCount = 0) Then

            Lbl_Accounting.Text = "ไม่พบข้อมูลที่ค้นหา"
            Lbl_Accounting.ForeColor = Color.Red
        Else
            Datagrid_format_dateshort(Dtgv_Accounting, 6)
            Datagrid_format_dateshort(Dtgv_Accounting, 7)

            Lbl_Accounting.Text = $"จำนวนผลลัพธ์ที่พบ = {Str(Dtgv_Accounting.RowCount.ToString)} แถว"
            Lbl_Accounting.ForeColor = Color.DarkGreen

        End If



        cn.Close()

    End Sub

    Private Sub Cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click

        If Msg_confirm("คุณต้องการเพิ่มข้อมูลลูกค้า ใช่ หรือ ไม่") = vbYes Then

            Insertdata()

        End If

    End Sub

    Private Sub Insertdata()

        Connect()


        Dim _datetime As DateTime = dtp_date_verify.Text
        Dim acckey As String = $"{cbo_owner.Text}-{txt_cusid.Text}-{_datetime}"

        sql = $"SELECT COUNT(Tracking_pk) FROM EXETRACKING WHERE Tracking_pk = '{acckey}'"

        cmd = New SqlCommand(sql, cn)
        Dim _counts As Integer = cmd.ExecuteScalar()

        If _counts > 0 Then
            Msg_error("มีข้อมูลนี้ในระบบแล้ว !")
            Exit Sub
        End If

        sql = $"SELECT EMPLOYEES_KEY FROM EXEEMPLOYEE WHERE EXEEMPLOYEES = @emp"
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("emp", cbo_empexe.Text)
        DA.SelectCommand = cmd
        DS = New DataSet
        DA.Fill(DS, "_emp")


        sql = "INSERT INTO EXETRACKING(Tracking_pk,Customer_owner,Customer_idc,Customer_account,Customer_fullname,Tracking_court,Tracking_red,Tracking_date_sheet,EMPLOYEES_KEY,Tracking_detail,Tracking_nosheet,Tracking_Collector_nosend,Tracking_other,Tracking_date_work,Tracking_total)VALUES(@key,@bank,@id,@acc,@cusname,@court,@red,@datewds,@employee,@detail,@nodoc,@nosend,@other,@datework,@money)"

        With cmd
            .CommandText = sql
            .Parameters.Clear()
            .Parameters.AddWithValue("key", acckey)
            .Parameters.AddWithValue("bank", cbo_owner.Text)
            .Parameters.AddWithValue("id", txt_cusid.Text)
            .Parameters.AddWithValue("acc", Txt_Account.Text)
            .Parameters.AddWithValue("cusname", txt_cusname.Text)
            .Parameters.AddWithValue("court", txt_court.Text)
            .Parameters.AddWithValue("red", txt_red.Text)
            .Parameters.AddWithValue("datewds", dtp_date_verify.Text)
            .Parameters.AddWithValue("employee", CInt(DS.Tables("_emp").Rows(0)("EMPLOYEES_KEY")))
            .Parameters.AddWithValue("detail", cbo_detail.Text)
            .Parameters.AddWithValue("nodoc", cbo_document.Text)
            .Parameters.AddWithValue("nosend", cbo_waning.Text)
            .Parameters.AddWithValue("other", txt_detail.Text)
            .Parameters.AddWithValue("datework", dtp_date_work.Text)
            .Parameters.AddWithValue("money", Txt_tkmoney.Text)
            Dim _query As Integer = .ExecuteNonQuery()

            If _query = -1 Then

                Msg_error("เกิดข้อผิดพลาดไม่สามารถเพิ่มข้อมูลได้")

            Else

                Cleardatagrid(Dtgv_Tracking)

                sql = $"SELECT ETR.Tracking_Primary,ETR.Customer_Owner,ETR.Customer_idc,ETR.Customer_Account,ETR.Customer_Fullname,ETR.Tracking_court,ETR.Tracking_red,ETR.Tracking_date_sheet,ETR.Tracking_date_work,ETR.Tracking_total,EMP.EXEEMPLOYEES,ETR.Tracking_detail,ETR.Tracking_nosheet,ETR.Tracking_Collector_nosend,ETR.Tracking_other  FROM EXETRACKING AS ETR LEFT JOIN EXEEMPLOYEE AS EMP ON ETR.EMPLOYEES_KEY = EMP.EMPLOYEES_KEY WHERE   Customer_idc = '{txt_cusid.Text}'"

                cmd.CommandText = sql
                DA.SelectCommand = cmd
                DA.Fill(DS, "_views")

                Dtgv_Tracking.DataSource = DS.Tables("_views")
                Dtgv_Tracking.Columns(0).Visible = False

                For i = 0 To header.Length - 1

                    Dtgv_Tracking.Columns(i).HeaderText = header(i)

                Next

                For visiblecolumns = 11 To Dtgv_Tracking.Columns.Count - 1


                    Dtgv_Tracking.Columns(visiblecolumns).Visible = False


                Next


                Datagrid_format_dateshort(Dtgv_Tracking, 6)
                Datagrid_format_dateshort(Dtgv_Tracking, 12)

                Getlogdataexe($"เพิ่ม ข้อมูลลูกค้า {txt_cusid.Text} {vbNewLine} ชื่อ {txt_cusname.Text} {vbNewLine} พนักงานบังคับคดี {vbNewLine} {cbo_empexe.Text} {vbNewLine} ตรวจสำนวน-ทำบัญชี-รับจ่าย ตามใบงาน ตรวจพบเงิน {Txt_tkmoney.Text}", $"'{txt_cusid.Text}'", $"'{Txt_Account.Text}'")
                Msg_OK("เพิ่มข้อมูลสำเร็จ")


                Clear_Obj()
                Readonly_Obj()
                cn.Close()

                cbo_owner.Enabled = True

            End If

        End With



    End Sub

    Private Sub Readonly_Obj()

        txt_cusname.ReadOnly = True
        txt_red.ReadOnly = True
        txt_court.ReadOnly = True
        txt_detail.ReadOnly = True
        Txt_tkmoney.ReadOnly = True
        cbo_waning.Enabled = False
        cbo_owner.Enabled = False
        cbo_empexe.Enabled = False
        cbo_detail.Enabled = False
        cbo_document.Enabled = False

        chk_datesend.Enabled = False
        chk_datetracking.Enabled = False


        If chk_datesend.Enabled = False Then

            dtp_date_send.Enabled = False

        End If

        If chk_datetracking.Enabled = False Then

            dtp_date_verify.Enabled = False

        End If

    End Sub

    Private Sub Write_obj()

        txt_detail.ReadOnly = False
        txt_cusname.ReadOnly = False
        txt_red.ReadOnly = False
        txt_court.ReadOnly = False
        Txt_tkmoney.ReadOnly = False

        cbo_waning.Enabled = True
        cbo_owner.Enabled = True
        cbo_empexe.Enabled = True
        cbo_detail.Enabled = True
        cbo_document.Enabled = True

        chk_datesend.Enabled = True
        chk_datetracking.Enabled = True



    End Sub
    Private Sub Clear_Obj()

        Txt_Account.Text = ""
        txt_detail.Text = ""
        txt_court.Text = ""
        txt_cusid.Text = ""
        txt_cusname.Text = ""
        txt_detail.Text = ""
        txt_red.Text = ""
        Txt_tkmoney.Text = ""

        cbo_detail.Text = ""
        cbo_document.Text = ""
        cbo_empexe.Text = ""
        cbo_owner.Text = ""
        cbo_waning.Text = ""
        dtp_date_send.Text = ""
        dtp_date_verify.Text = ""

        chk_datesend.Checked = False
        chk_datetracking.Checked = False

        If chk_datesend.Checked = False Then

            dtp_date_send.Enabled = False

        End If
        If chk_datetracking.Checked = False Then

            dtp_date_verify.Enabled = False

        End If

        Lbl_Tracking.Text = "ผลลัพธ์การค้นหา"

    End Sub

    Private Sub Cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click

        Write_obj()

        If chk_datesend.Checked = True Then

            dtp_date_send.Enabled = True
        Else
            dtp_date_send.Enabled = False

        End If

        If chk_datetracking.Checked = True Then

            dtp_date_verify.Enabled = True
        Else
            dtp_date_verify.Enabled = False

        End If

    End Sub

    Private Sub Cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click

        Readonly_Obj()

    End Sub

    Private Sub Cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        If Application.OpenForms().OfType(Of Frmfind).Any Then


            Frmfind.Focus()

        Else
            With Frmfind
                .ShowDialog()
                .StartPosition = FormStartPosition.CenterScreen
            End With
        End If


    End Sub

    Private Sub Cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click

        Clear_Obj()
        Cleardatagrid(Dtgv_Tracking)

    End Sub


    Private Sub FrmTracking_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub

    Private Sub Cmd_filter_Click(sender As Object, e As EventArgs) Handles cmd_filter.Click

        If Application.OpenForms().OfType(Of Frmfilter).Any Then

            Frmfilter.Focus()
        Else
            Frmfilter.ShowDialog()
            Frmfilter.StartPosition = FormStartPosition.CenterScreen

        End If
    End Sub

    Private Sub Linkdatabase()


        Select Case cbo_owner.SelectedItem

            Case "KBANK" : Connect_(cn_KBANK)
                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Account.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_Tracking.Visible = True
                    Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Tracking.ForeColor = Color.Green

                Else
                    sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{txt_cusid.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Green

                    Else
                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Red

                    End If

                End If

                cn_KBANK.Close()

            Case "KKB" : Connect_(cn_KKB)
                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Account.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_KKB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_Tracking.Visible = True
                    Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Tracking.ForeColor = Color.Green


                Else
                    sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{txt_cusid.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_KKB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Green
                    Else
                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Red

                    End If
                End If

                cn_KKB.Close()

            Case "SCB" : Connect_(cn_SCB)
                sqll = $"SELECT RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Account.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_SCB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then


                    Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_Tracking.Visible = True
                    Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Tracking.ForeColor = Color.Green


                Else

                    sqll = $"SELECT RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{txt_cusid.Text}'"
                    cmd_Collec = New SqlCommand(sqll, cn_SCB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                        txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Green

                    Else
                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Red

                    End If
                End If

                cn_SCB.Close()

            Case "TSS" : Connect_(cn_GE)

                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWSAN,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_GE)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_Tracking.Visible = True
                    Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Tracking.ForeColor = Color.Green
                Else


                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{txt_cusid.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_GE)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                        txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Green

                    Else
                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Red

                    End If

                End If

                cn_GE.Close()

            Case "TMB" : Connect_(cn_TMB)
                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TMB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then


                    Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_Tracking.Visible = True
                    Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Tracking.ForeColor = Color.Green

                Else
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{txt_cusid.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString


                        txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"

                        txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Green

                    Else
                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Red

                    End If

                End If
                cn_TMB.Close()

            Case "TMB SME" : Connect_(cn_TMBSME)
                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_Tracking.Visible = True
                    Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Tracking.ForeColor = Color.Green

                Else
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{txt_cusid.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")


                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                        txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Green

                    Else
                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Red

                    End If

                End If

                cn_TMBSME.Close()

            Case "TBANK" : Connect_(cn_TBANK)

                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Txt_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_Tracking.Visible = True
                    Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Tracking.ForeColor = Color.Green
                Else
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSIDC = '{txt_cusid.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                        txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Green

                    Else
                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Red

                    End If
                End If
                cn_TBANK.Close()

            Case "UOB" : Connect_(cn_UOB)

                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Txt_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_UOB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Lbl_Tracking.Visible = True
                    Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Tracking.ForeColor = Color.Green

                Else

                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Txt_Account.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_UOB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        txt_court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                        txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    Else
                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Red

                    End If

                End If

                cn_UOB.Close()

            Case Else : Connect_(cnLegal)

                sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{txt_cusid.Text}'"
                cmdlegal = New SqlCommand(sqll, cnLegal)
                DALegal = New SqlDataAdapter(cmdlegal)
                DSLegal = New DataSet
                DALegal.Fill(DSLegal, "linklegal")

                If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                    txt_cusname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                    txt_red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                    txt_court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                    Txt_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                    txt_cusid.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString

                    Lbl_Tracking.Visible = True
                    Lbl_Tracking.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                    Lbl_Tracking.ForeColor = Color.Green

                Else

                    sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Txt_Account.Text}'"
                    cmdlegal = New SqlCommand(sqll, cnLegal)
                    DALegal = New SqlDataAdapter(cmdlegal)
                    DSLegal = New DataSet
                    DALegal.Fill(DSLegal, "linklegal")

                    If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                        txt_cusname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                        txt_red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                        txt_court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                        Txt_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                        txt_cusid.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString

                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Green

                    Else
                        Lbl_Tracking.Visible = True
                        Lbl_Tracking.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                        Lbl_Tracking.ForeColor = Color.Red

                    End If

                End If

                cnLegal.Close()

        End Select


    End Sub

    Private Sub Cmd_LinkDatabase_Click(sender As Object, e As EventArgs) Handles Cmd_LinkDatabase.Click

        Linkdatabase()

    End Sub



    Private Sub Cmd_find_Click(sender As Object, e As EventArgs) Handles Cmd_find.Click

        Loaddatagridviews()

    End Sub

    Private Sub Cbo_type_find_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_type_find.SelectedIndexChanged

        Connect()

        Select Case sender.SelectedItem

            Case "เลขที่สัญญา" : Autocompletecombo(txt_find, "Customer_account", "EXETRACKING")
            Case "เลขประจำตัวประชาชน" : Autocompletecombo(txt_find, "Customer_idc", "EXETRACKING")
            Case "ชื่อ-นามสกุล" : Autocompletecombo(txt_find, "Customer_fullname", "EXETRACKING")
            Case "เลขที่คดีแดง" : Autocompletecombo(txt_find, "Tracking_red", "EXETRACKING")
            Case "พนักงานบังคับคดี" : Autocompletecombo(txt_find, "EXEEMPLOYEES", "EXEEMPLOYEE")

        End Select

    End Sub

    Private Sub Cmd_update_Click(sender As Object, e As EventArgs) Handles Cmd_update.Click

        If Lbl_Primary.Text = "PK?" Then

            Msg_error("ไม่พบข้อมูลที่ต้องการแก้ไขกรุณาตรวจสอบอีกครั้ง")
            Exit Sub

        End If


        If Msg_confirm("ต้องการอัพเดตข้อมูล ใช่ หรือ ไม่") = vbYes Then

            UpdateData()

        End If

    End Sub
    Private Sub UpdateData()

        Connect()

        Dim EMP As Integer = GetEmployeekey(cbo_empexe)
        Console.WriteLine(EMP.ToString)


        sql = $"UPDATE EXETRACKING SET Customer_owner = '{cbo_owner.Text}',Customer_idc = '{txt_cusid.Text}' ,Customer_account = '{Txt_Account.Text}',Customer_fullname = '{txt_cusname.Text}' ,Tracking_court = '{txt_court.Text}' ,Tracking_red = '{txt_red.Text}' ,Tracking_date_sheet ='{dtp_date_verify.Text}' ,EMPLOYEES_KEY = {EMP} ,Tracking_detail = '{cbo_detail.Text}',Tracking_nosheet = '{cbo_document.Text}' ,Tracking_Collector_nosend = '{cbo_waning.Text}' ,Tracking_other = '{txt_detail.Text}' ,Tracking_date_work = '{dtp_date_work.Text}' ,Tracking_total = '{Txt_tkmoney.Text}' WHERE Tracking_primary = '{Lbl_Primary.Text}' ; "

        cmd = New SqlCommand(sql, cn)
        Dim CheckTransection As Integer = cmd.ExecuteNonQuery()

        If CheckTransection > 0 Then

            Lbl_Tracking.Text = $"แก้ไขข้อมูล {CheckTransection} รายการ"

        End If

    End Sub


    Private Sub Dtgv_Tracking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgv_Tracking.CellClick

        With Dtgv_Tracking

            Lbl_Primary.Text = .CurrentRow.Cells(0).Value.ToString
            cbo_owner.Text = .CurrentRow.Cells(1).Value.ToString
            txt_cusid.Text = .CurrentRow.Cells(2).Value.ToString
            Txt_Account.Text = .CurrentRow.Cells(3).Value.ToString
            txt_cusname.Text = .CurrentRow.Cells(4).Value.ToString
            txt_court.Text = .CurrentRow.Cells(5).Value.ToString
            txt_red.Text = .CurrentRow.Cells(6).Value.ToString
            dtp_date_verify.Text = .CurrentRow.Cells(7).Value.ToString
            dtp_date_work.Text = .CurrentRow.Cells(8).Value.ToString
            Txt_tkmoney.Text = .CurrentRow.Cells(9).Value.ToString
            cbo_empexe.Text = .CurrentRow.Cells(10).Value.ToString
            cbo_detail.Text = .CurrentRow.Cells(11).Value.ToString
            cbo_document.Text = .CurrentRow.Cells(12).Value.ToString
            cbo_waning.Text = .CurrentRow.Cells(13).Value.ToString
            txt_detail.Text = .CurrentRow.Cells(14).Value.ToString


            If .CurrentRow.Cells(6).Value.ToString = "" Then

                chk_datetracking.Checked = False

            Else
                chk_datetracking.Checked = True

            End If

        End With

    End Sub

    Private Sub DeleteData()

        Connect()

        sql = $"DELETE FROM EXETRACKING WHERE Tracking_Primary = {Lbl_Primary.Text}"
        cmd = New SqlCommand(sql, cn)
        Dim Verifydata As Integer = cmd.ExecuteNonQuery()

        If Verifydata > 0 Then

            Lbl_Tracking.Text = $"ลบข้อมูล {Verifydata} รายการ"

        Else

            Lbl_Tracking.Text = $"ลบข้อมูลล้มเหลว"

        End If

    End Sub

    Private Sub Cmd_delete_Click(sender As Object, e As EventArgs) Handles Cmd_delete.Click


        If Lbl_Primary.Text = "PK?" Then

            Msg_error("ไม่พบข้อมูลที่ต้องการลบกรุณาตรวจสอบอีกครั้ง")
            Exit Sub

        End If

        If Msg_confirm("คุณต้องการลบข้อมูลนี้ใช่หรือไม่") = vbYes Then

            DeleteData()

        End If

    End Sub

End Class