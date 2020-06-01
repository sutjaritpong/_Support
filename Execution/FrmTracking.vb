Imports System.Data.SqlClient
Public Class FrmTracking
    '## Sub Load นำข้อมูลจาก Array เพิ่มไปใน Sub _cboArray ใช้เพิ่มข้อมูล ใน Combobox' 
    Private Sub FrmTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '## เพิ่มข้อมูลลงใน Combobox โดยใช้ Array และ Method .items.addrange() นำมาสร้างเป็น Sub _cboArray และ ใช้การเพิ่มข้อมูลจาก Columns โดยดึงข้อมูลจาก Database มาแล้วใช้ Method command.ExecuteReader() อ่านข้อมูลใน คอลัมน์ ที่ Query มา แล้วนำมาแสดงโดยการใช้ While Loop ##'

        _cleardatagrid(dtgv_tracking)
        Dim _nosend() As String = {"ไม่ได้ส่งมาออกใบงานแถลงบัญชี", "ส่งมาออกใบงาน"}

        _cboArray(cbo_waning, _nosend)
        cbo_waning.SelectedIndex = -1

        Dim _tracking() As String = {"ไม่มีใบงานแถลงบัญชี", "มีใบงานแถลงบัญชี"}

        _cboArray(cbo_document, _tracking)
        cbo_document.SelectedIndex = -1


        _comboboxadd(cbo_owner, "EXEBANK", "EXESM")
        cbo_owner.SelectedIndex = -1

        connect()

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

        _autocomplete(txt_cusid, "EXEID", "EXESM")

        _readonly()
        clear()
        cn.Close()




    End Sub

    '## Event CheckedChanged ใช้ในการเช็คค่าของ Checkbox ##'
    Private Sub chk_datetracking_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datetracking.CheckedChanged

        If chk_datetracking.Checked = True Then

            dtp_date_verify.Enabled = True
        Else
            dtp_date_verify.Enabled = False

        End If

    End Sub

    '## Event CheckedChanged ใช้ในการเช็คค่าของ Checkbox ##'
    Private Sub chk_datesend_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datesend.CheckedChanged

        If chk_datesend.Checked = True Then

            dtp_date_send.Enabled = True
        Else
            dtp_date_send.Enabled = False

        End If


    End Sub

    ' ## Event Button Click เมื่อกดปุ่มจะทำงาน ในที่นี้ให้แสดง ข้อมูลที่ลิ้งจาก txt_cusid มาแสดงใน Datagridview และ นำไปแสดงใน Textbox ด้วย อื่น ๆ ##'
    Private Sub cmd_links_Click(sender As Object, e As EventArgs) Handles cmd_links.Click
        Try
            connect()

            _cleardatagrid(dtgv_tracking)

            sql = $"SELECT S.EXEBANK,S.EXECUSTOMER,S.EXECOURT,S.EXERED,S.EXEDATEWORK,TR.Tracking_date_sheet,TR.Tracking_other FROM EXESM AS S LEFT JOIN EXETRACKING AS TR ON S.EXEID = TR.Customer_IDC  WHERE S.EXEID = '{txt_cusid.Text}' ORDER BY S.EXEID "

            cmd = New SqlCommand(sql, cn)
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "tables")

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

            Dim _headers() As String = {"ธนาคาร", "ชื่อ-นามสกุล", "ศาล", "เลขคดีแดง", "วันที่ออกใบงานแถลงบัญชี", "วันที่ตรวจสำนวน"}

            With dtgv_tracking

                .DataSource = DS.Tables("tables")

                For i = 0 To _headers.Length - 1

                    .Columns(i).HeaderText = _headers(i)

                Next

                If dtgv_tracking.RowCount = 0 Then
                    lbl_invalid.Text = "ไม่พบข้อมูลที่ค้นหา"
                Else
                    lbl_invalid.Text = $"จำนวนผลลัพธ์ที่พบ = {dtgv_invalid.RowCount.ToString} "
                End If

            End With

        Catch ex As Exception
            _readonly()
        Finally
            cn.Close()
        End Try

    End Sub

    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click

        Dim _headertext() As String = {"PK", "Product", "เลขที่บัตรประชาชน", "ชื่อ-นามสกุล", "ศาล", "คดีแดง", "วันที่ในคำร้อง", "พนักงานบังคับคดี", "รายละเอียด", "ใบงานแถลงบัญชี", "Collectorส่งเรื่องออกใบงาน", "อื่นๆ"}

        Dim _datetime As DateTime = dtp_date_verify.Text
        Dim acckey As String = $"{cbo_owner.Text}-{txt_cusid.Text}-{_datetime}"

        sql = $"SELECT EMPLOYEES_KEY FROM EXEEMPLOYEE WHERE EXEEMPLOYEES = @emp"
        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("emp", cbo_empexe.Text)
        DA.SelectCommand = cmd
        DS = New DataSet
        DA.Fill(DS, "_emp")

        connect()
        sql = "INSERT INTO EXETRACKING(Tracking_pk,Customer_owner,Customer_idc,Customer_fullname,Tracking_court,Tracking_red,Tracking_date_sheet,EMPLOYEES_KEY,Tracking_detail,Tracking_nosheet,Tracking_Collector_nosend,Tracking_other)VALUES(@key,@bank,@id,@cusname,@court,@red,@datewds,@employee,@detail,@nodoc,@nosend,@other)"

        With cmd
            .CommandText = sql
            .Parameters.Clear()
            .Parameters.AddWithValue("key", acckey)
            .Parameters.AddWithValue("bank", cbo_owner.Text)
            .Parameters.AddWithValue("id", txt_cusid.Text)
            .Parameters.AddWithValue("cusname", txt_cusname.Text)
            .Parameters.AddWithValue("court", txt_court.Text)
            .Parameters.AddWithValue("red", txt_red.Text)
            .Parameters.AddWithValue("datewds", dtp_date_verify.Text)
            .Parameters.AddWithValue("employee", CInt(DS.Tables("_emp").Rows(0)("EMPLOYEES_KEY")))
            .Parameters.AddWithValue("detail", cbo_detail.Text)
            .Parameters.AddWithValue("nodoc", cbo_document.Text)
            .Parameters.AddWithValue("nosend", cbo_waning.Text)
            .Parameters.AddWithValue("other", txt_detail.Text)

            Dim _query As Integer = .ExecuteNonQuery()

            If _query = -1 Then

                Msg_error("เกิดข้อผิดพลาดไม่สามารถเพิ่มข้อมูลได้")

            Else

                _cleardatagrid(dtgv_invalid)

                sql = $"SELECT * FROM EXETRACKING WHERE Customer_idc = '{txt_cusid.Text}'"
                cmd.CommandText = sql
                DA.SelectCommand = cmd
                DA.Fill(DS, "_views")

                dtgv_invalid.DataSource = DS.Tables("_views")
                dtgv_invalid.Columns(0).Visible = False

                For i = 0 To _headertext.Length - 1

                    dtgv_invalid.Columns(i).HeaderText = _headertext(i)
                Next

                _Getlogdata($"เพิ่มข้อมูลลูกค้า {txt_cusid.Text} ตรวจสำนวน ทำบัญชี-รับจ่าย ตามใบงาน")
                Msg_OK("เพิ่มข้อมูลสำเร็จ")
                clear()
                _readonly()

            End If

        End With


    End Sub

    Private Sub _readonly()

        txt_cusname.ReadOnly = True
        txt_red.ReadOnly = True
        txt_court.ReadOnly = True
        txt_detail.ReadOnly = True
        cbo_waning.Enabled = False
        cbo_owner.Enabled = False
        cbo_empexe.Enabled = False
        cbo_detail.Enabled = False
        cbo_document.Enabled = False

        If chk_datesend.Enabled = False Then

            dtp_date_send.Enabled = False

        End If

        If chk_datetracking.Enabled = False Then

            dtp_date_verify.Enabled = False

        End If

    End Sub

    Private Sub _write()



        txt_detail.ReadOnly = False
        txt_cusname.ReadOnly = False
        txt_red.ReadOnly = False
        txt_court.ReadOnly = False

        cbo_waning.Enabled = True
        cbo_owner.Enabled = True
        cbo_empexe.Enabled = True
        cbo_detail.Enabled = True
        cbo_document.Enabled = True

        chk_datesend.Enabled = True
        chk_datetracking.Enabled = True

    End Sub
    Private Sub clear()

        txt_detail.Text = ""
        txt_court.Text = ""
        txt_cusid.Text = ""
        txt_cusname.Text = ""
        txt_detail.Text = ""
        txt_red.Text = ""
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

    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click

        _write()

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

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click

        _readonly()

    End Sub

    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        Frmfind.Show()

    End Sub

    Private Sub cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click

        clear()
        _cleardatagrid(dtgv_invalid)

    End Sub

End Class