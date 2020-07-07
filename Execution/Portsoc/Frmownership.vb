Option Explicit On
Imports System.Data.SqlClient

Public Class Frmownership

    Dim _text() As String = {"ธนาคาร", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "Result"}

    Private Sub Frmownership_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        _Datetimeformatshort(dtp_datework)
        _Datetimeformatshort(dtp_date_review)

        _cleardatagrid(dtgv_search)



        cbo_deed.Items.Clear()
        cbo_Land_office.Items.Clear()
        cbo_owner.Items.Clear()
        cbo_type_find.Items.Clear()

        _cboArray(cbo_type_find, _text)

        _comboboxadd(cbo_Land_office, "Ownership_land_office", "Execution_Ownership_Result")
        cbo_Land_office.SelectedIndex = -1

        _comboboxadd(cbo_owner, "Customer_owner", "Execution_Ownership")
        cbo_owner.SelectedIndex = -1

        dtgv_search.Visible = False

        cn.Close()

    End Sub

    Private Sub chk_date_work_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_work.CheckedChanged

        If chk_date_work.Checked = True Then

            dtp_datework.Enabled = True
        Else
            dtp_datework.Enabled = False

        End If

    End Sub

    Private Sub chk_date_review_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_review.CheckedChanged

        If chk_date_review.Checked = True Then

            dtp_date_review.Enabled = True
        Else
            dtp_date_review.Enabled = False

        End If

    End Sub

    Private Sub dtgv_search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_search.CellClick

        _cleartext()
        connect()

        Try
            cbo_owner.Text = dtgv_search.CurrentRow.Cells(0).Value.ToString
            txt_cusid.Text = dtgv_search.CurrentRow.Cells(1).Value.ToString
            txt_cusname.Text = dtgv_search.CurrentRow.Cells(2).Value.ToString
            dtp_datework.Text = dtgv_search.CurrentRow.Cells(3).Value.ToString
            txt_result.Text = dtgv_search.CurrentRow.Cells(4).Value.ToString
            cbo_deed.Text = dtgv_search.CurrentRow.Cells(5).Value.ToString

            sql = $"SELECT DISTINCT Ownership_deed FROM Execution_Ownership_Result WHERE Customer_id_card = {dtgv_search.CurrentRow.Cells(1).Value.ToString}"
            cmd = New SqlCommand(sql, cn)
            DR = cmd.ExecuteReader()

            While DR.Read()
                cbo_deed.Items.Add($"{DR("Ownership_deed")}")
            End While

            DR.Close()

            cbo_surveypage.Text = dtgv_search.CurrentRow.Cells(6).Value.ToString

            sql = $"SELECT DISTINCT Ownership_surveypage FROM Execution_Ownership_Result WHERE Customer_id_card = {dtgv_search.CurrentRow.Cells(1).Value.ToString}"
            cmd = New SqlCommand(sql, cn)
            DR = cmd.ExecuteReader()

            While DR.Read()
                cbo_surveypage.Items.Add($"{DR("Ownership_surveypage")}")
            End While

            DR.Close()

            txt_district.Text = dtgv_search.CurrentRow.Cells(7).Value.ToString
            txt_location.Text = dtgv_search.CurrentRow.Cells(8).Value.ToString
            cbo_Land_office.Text = dtgv_search.CurrentRow.Cells(9).Value.ToString
            txt_address.Text = dtgv_search.CurrentRow.Cells(10).Value.ToString
            dtp_date_review.Text = dtgv_search.CurrentRow.Cells(11).Value.ToString

            If dtgv_search.CurrentRow.Cells(3).Value.ToString <> "" Then
                chk_date_work.Checked = True
            Else
                chk_date_work.Checked = False
            End If

            If dtgv_search.CurrentRow.Cells(11).Value.ToString <> "" Then
                chk_date_review.Checked = True
            Else
                chk_date_review.Checked = False
            End If

        Catch ex As Exception

        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        _finds()

    End Sub
    Private Sub _cleartext()

        cbo_owner.Text = ""
        cbo_deed.Text = ""
        cbo_Land_office.Text = ""
        cbo_surveypage.Text = ""

        cbo_surveypage.Items.Clear()
        cbo_deed.Items.Clear()


        txt_district.Text = ""
        txt_location.Text = ""
        txt_address.Text = ""
        txt_cusid.Text = ""
        txt_cusname.Text = ""
        txt_result.Text = ""

        dtp_date_review.Text = ""
        dtp_datework.Text = ""

        chk_date_review.Checked = False
        chk_date_work.Checked = False

    End Sub
    Private Sub _finds()

        Dim _headertext() As String = {"ธนาคาร", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "วันที่ส่งไปสืบ", "Result", "เลขโฉนด", "หน้าสำรวจ", "ตำบล/อำเภอ", "สถานที่", "สำนักงานที่ดิน", "ที่อยู่", "วันที่ส่งผลสืบ"}

        connect()

        _cleardatagrid(dtgv_search)

        sql = "SELECT EO.Customer_owner, EO.Customer_id_card, EO.Customer_name, EO.Date_send, EO.Result, EOR.Ownership_deed, EOR.Ownership_surveypage, EOR.Ownership_district, EOR.Ownership_location, EOR.Ownership_land_office, EOR.Ownership_address, EOR.Date_review FROM Execution_Ownership AS EO LEFT JOIN Execution_Ownership_Result AS EOR ON EO.Customer_id_card = EOR.Customer_id_card WHERE "

        Select Case cbo_type_find.SelectedItem
            Case "ธนาคาร" : sql &= $"EO.Customer_owner "
            Case "เลขบัตรประชาชน" : sql &= $"EO.Customer_id_card "
            Case "ชื่อ-นามสกุล" : sql &= $"EO.Customer_name "
            Case "Result" : sql &= $"EO.Result "
        End Select

        sql &= "Like '%' + @find + '%' ORDER BY EO.Customer_id_card"

            cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("find", txt_find.Text)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "ownerships")

        If DS.Tables("ownerships").Rows.Count <= 0 Then

            lbl_count_find.Text = "ไม่พบข้อมูลที่ค้นหา.."
            lbl_count_find.ForeColor = Color.Red
            dtgv_search.Visible = False
            Exit Sub

        Else

            With dtgv_search

                .Visible = True
                .DataSource = DS.Tables("ownerships")
                For i = 0 To _headertext.Length - 1
                    .Columns(i).HeaderText = _headertext(i)
                    .Columns(4).Visible = False
                    .Columns(7).Visible = False
                    .Columns(8).Visible = False
                    .Columns(10).Visible = False
                Next

            End With

            _datagrid_format_dateshort(dtgv_search, 3)
            _datagrid_format_dateshort(dtgv_search, 11)

            lbl_count_find.Text = $"พบข้อมูล {dtgv_search.RowCount.ToString} รายการ.."
            lbl_count_find.ForeColor = Color.Green

        End If
        cn.Close()
    End Sub


End Class