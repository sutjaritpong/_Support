Imports System.Data.SqlClient
Public Class FrmTracking

    Private Sub FrmTracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _cleardatagrid(dtgv_tracking)

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

        sql = $"SELECT DISTINCT EXEDETAIL FROM EXETRACKING"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()

            cbo_detail.Items.Add($"{DR("EXEDETAIL")}")

        End While

        DR.Close()

        _autocomplete(txt_cusid, "EXEID", "EXESM")

        _readonly()

        cn.Close()
    End Sub

    Private Sub chk_datetracking_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datetracking.CheckedChanged

        If chk_datetracking.Checked = True Then

            dtp_date_verify.Enabled = True
        Else
            dtp_date_verify.Enabled = False

        End If

    End Sub

    Private Sub chk_datesend_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datesend.CheckedChanged


        If chk_datesend.Checked = True Then

            dtp_date_send.Enabled = True
        Else
            dtp_date_send.Enabled = False

        End If


    End Sub

    Private Sub cmd_find_Click(sender As Object, e As EventArgs) Handles cmd_find.Click

        connect()

        _cleardatagrid(dtgv_tracking)

        sql = $"SELECT S.EXEBANK,S.EXECUSTOMER,S.EXECOURT,S.EXERED,S.EXEDATEWORK,TR.EXEDATE FROM EXESM as S LEFT JOIN EXETRACKING AS TR ON S.EXEID = TR.EXEIDC  WHERE EXEID = '{txt_cusid.Text}' ORDER BY S.EXEID "

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "tables")

        cbo_owner.Text = DS.Tables("tables").Rows(0)("EXEBANK").ToString
        txt_cusname.Text = DS.Tables("tables").Rows(0)("EXECUSTOMER").ToString
        txt_red.Text = DS.Tables("tables").Rows(0)("EXERED").ToString
        txt_court.Text = DS.Tables("tables").Rows(0)("EXECOURT").ToString
        dtp_date_send.Text = DS.Tables("tables").Rows(0)("EXEDATEWORK").ToString
        dtp_date_verify.Text = DS.Tables("tables").Rows(0)("EXEDATE").ToString

        If dtp_date_send.Text <> "" Then

            chk_datesend.Checked = True

        Else

            chk_datesend.Checked = False

        End If
        If chk_datesend.Checked = False Then

            txt_waning.Text = "ไม่ได้ส่งมาออกใบงาน"

        Else

            txt_waning.Text = "มีใบงานแถลงบัญชี"

        End If

        Dim _headers() As String = {"ธนาคาร", "ชื่อ-นามสกุล", "เลขคดีแดง", "ศาล", "วันที่ออกใบงานแถลงบัญชี", "วันที่ตรวจสำนวน"}

        With dtgv_tracking

            .DataSource = DS.Tables("tables")

            For i = 0 To _headers.Length - 1

                .Columns(i).HeaderText = _headers(i)

            Next

        End With

        cn.Close()



    End Sub

    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click



    End Sub

    Private Sub _readonly()

        txt_waning.ReadOnly = True
        txt_cusname.ReadOnly = True
        txt_red.ReadOnly = True
        txt_court.ReadOnly = True

        cbo_owner.Enabled = False
        cbo_empexe.Enabled = False
        cbo_detail.Enabled = False
        cbo_document.Enabled = False
        chk_datesend.Enabled = False
        chk_datetracking.Enabled = False
        dtp_date_verify.Enabled = False
        dtp_date_send.Enabled = False

    End Sub

    Private Sub _write()

        txt_waning.ReadOnly = False
        txt_cusname.ReadOnly = False
        txt_red.ReadOnly = False
        txt_court.ReadOnly = False

        cbo_owner.Enabled = True
        cbo_empexe.Enabled = True
        cbo_detail.Enabled = True
        cbo_document.Enabled = True
        chk_datesend.Enabled = True
        chk_datetracking.Enabled = True

        If dtp_date_send.Text = "" Then

            chk_datesend.Checked = False

        End If
        If dtp_date_verify.Text = "" Then

            chk_datetracking.Checked = False

        End If

    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click

        _write()

    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click

        _readonly()

    End Sub

End Class