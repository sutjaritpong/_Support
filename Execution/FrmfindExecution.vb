'## Name Spaces Sqlclient ใช้ติดต่อฐานข้อมูล 
Option Explicit On
Imports System.Data.SqlClient

Public Class FrmfindExecution
    Private Sub Frmfindtracking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "SELECT * FROM EXESM"
        connect()
        Dim cmd As New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()
        While reader.Read()
            autocomp.Add(reader("EXEID"))
        End While
        reader.Close()
        txt_findid.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_findid.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_findid.AutoCompleteCustomSource = autocomp

    End Sub
    Private Sub cmd_find_Click(sender As Object, e As EventArgs) Handles cmd_find.Click

        connect()

        _cleartext()

        If txt_findid.Text = "" Then
            Msg_error("กรุณากรอกเลขบัตรประชาชนที่ต้องการค้นหา")
            Return
        End If

        Dim sqll As String = $"SELECT ES.EXEBANK, ES.EXEID,ES.EXECUSTOMER,ES.EXEACC1,ES.EXEACC2,ES.EXEACC3,ES.EXECOURT,ES.EXEBLACK,ES.EXERED,ES.EXENUMBER,ES.EXEDEPARTMENT,ES.EXETOTAL,ES.EXEEMPLOYEE,ES.EXEPHONE,ES.EXEHUB,ES.EXEDATEWORK,ES.EXEFULLNAME,ES.EXEDETAIL,ES.EXEPERFORMANCE,ES.EXEHUBS,ES.EXERESULT,Emp.EXEEMPLOYEES,ET.Tracking_date_sheet,ET.Tracking_nosheet,ET.Tracking_Collector_nosend,ET.Tracking_detail,EV.Execution_verify_date,Ev.Execution_verify_result,Ev.Execution_verify_comment
    FROM EXESM As ES LEFT JOIN Execution_verify AS EV On EV.Customer_id_card = ES.EXEID LEFT JOIN EXEEMPLOYEE AS Emp ON EV.Execution_id_employees = EMPLOYEES_KEY LEFT JOIN EXETRACKING AS ET ON ES.EXEID = ET.Customer_idc WHERE ES.EXEID = {txt_findid.Text} "

        Dim cmd As New SqlCommand(sqll, cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim DS As New DataSet
        DA.Fill(DS, "table")

        Dim idepart() As String = {DS.Tables("table").Rows(0)("EXEDEPARTMENT")}
        Dim ic() As String = {DS.Tables("table").Rows(0)("EXECOURT")}
        Dim y() = {DS.Tables("table").Rows(0)("EXEACC1"), DS.Tables("table").Rows(0)("EXEACC2"), DS.Tables("table").Rows(0)("EXEACC3")}
        Dim i As Integer = DA.Fill(DS, "table")

        If i <= 0 Then

            Msg_error("ไม่มีเลขที่สัญญานี้ในระบบ")

            Return

        Else

            With FrmExecution

                .txt_product.Text = DS.Tables("table").Rows(0)("EXEBANK")
                .txt_idcus.Text = DS.Tables("table").Rows(0)("EXEID")
                .txt_namecus.Text = DS.Tables("table").Rows(0)("EXECUSTOMER")
                .cbo_acc.Items.Clear()
                If DS.Tables("table").Rows(0)("EXEACC1").ToString <> "" Then
                    .cbo_acc.Items.Add(y(0))
                End If
                If DS.Tables("table").Rows(0)("EXEACC2").ToString <> "" Then
                    .cbo_acc.Items.Add(y(1))
                End If
                If DS.Tables("table").Rows(0)("EXEACC3").ToString <> "" Then
                    .cbo_acc.Items.Add(y(2))
                End If
                .txt_count_acc.Text = FrmExecution.cbo_acc.Items.Count.ToString
                .cbo_acc.SelectedIndex = 0
                .txt_black.Text = DS.Tables("table").Rows(0)("EXEBLACK")
                .txt_red.Text = DS.Tables("table").Rows(0)("EXERED")
                .txt_number.Text = DS.Tables("table").Rows(0)("EXENUMBER")
                .cbo_court.Items.Clear()
                .cbo_court.Items.AddRange(ic)
                .cbo_court.SelectedIndex = 0
                .cbo_department.Items.Clear()
                .cbo_department.Items.AddRange(idepart)
                .cbo_department.SelectedIndex = 0
                .txt_total.Text = DS.Tables("table").Rows(0)("EXETOTAL")
                .txt_nameem.Text = DS.Tables("table").Rows(0)("EXEEMPLOYEE")
                .txt_phone.Text = DS.Tables("table").Rows(0)("EXEPHONE")
                .txt_hub.Text = DS.Tables("table").Rows(0)("EXEHUB")
                .dtp_datesheet.Text = DS.Tables("table").Rows(0)("EXEDATEWORK")
                .txt_employee.Text = DS.Tables("table").Rows(0)("EXEFULLNAME")
                .txt_detail1.Text = DS.Tables("table").Rows(0)("EXEDETAIL")
                .txt_performance.Text = DS.Tables("table").Rows(0)("EXEPERFORMANCE")
                .txt_hubs.Text = DS.Tables("table").Rows(0)("EXEHUBS")
                .txt_result.Text = DS.Tables("table").Rows(0)("EXERESULT")

                .txt_collec_nosend.Text = CStr(DS.Tables("table").Rows(0)("Tracking_Collector_nosend").ToString)
                .txt_tracking_nosheet.Text = CStr(DS.Tables("table").Rows(0)("Tracking_nosheet").ToString)
                .txt_tracking_detail.Text = CStr(DS.Tables("table").Rows(0)("Tracking_detail").ToString)
                .dtp_tracking_date.Text = CStr(DS.Tables("table").Rows(0)("Tracking_date_sheet").ToString)
                .cbo_employees_exe.Text = CStr(DS.Tables("table").Rows(0)("EXEEMPLOYEES").ToString)

                .dtp_verify_date.Text = CStr(DS.Tables("table").Rows(0)("Execution_verify_date").ToString)
                .txt_verify_comment.Text = CStr(DS.Tables("table").Rows(0)("Execution_verify_comment").ToString)
                .txt_verify_result.Text = CStr(DS.Tables("table").Rows(0)("Execution_verify_result").ToString)

                .Reader()
                .txt_total.Text = CDbl(FrmExecution.txt_total.Text).ToString("##,##0.00")

                If DS.Tables("table").Rows(0)("EXEDATEWORK").ToString <> "" Then

                    .chk_datesheet.Checked = True
                Else

                    .chk_datesheet.Checked = False

                End If

                If DS.Tables("table").Rows(0)("Tracking_date_sheet").ToString <> "" Then

                    .chk_tracking_date.Checked = True

                Else

                    .chk_tracking_date.Checked = False

                End If

                If DS.Tables("table").Rows(0)("Execution_verify_date").ToString <> "" Then

                    .chk_verify_date.Checked = True

                Else

                    .chk_verify_date.Checked = False

                End If

                If (.txt_total.Text <> "") AndAlso (Not IsNumeric(.txt_total.Text)) Then


                Else

                    .txt_total.Text = CDbl(.txt_total.Text).ToString("##,##0.00")

                End If


            End With

            Me.Close()

        End If

        cn.Close()


    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub

    Public Sub _cleartext()

        With FrmExecution

            .txt_black.Text = ""
            .txt_detail1.Text = ""
            .txt_count_acc.Text = ""
            .txt_employee.Text = ""
            .cbo_employees_exe.Text = ""
            .txt_hub.Text = ""
            .txt_hubs.Text = ""
            .txt_idcus.Text = ""
            .txt_namecus.Text = ""
            .txt_nameem.Text = ""
            .txt_number.Text = ""
            .txt_verify_result.Text = ""
            .txt_performance.Text = ""
            .txt_phone.Text = ""
            .txt_product.Text = ""
            .txt_red.Text = ""
            .txt_result.Text = ""
            .txt_verify_comment.Text = ""
            .txt_total.Text = ""
            .dtp_verify_date.Text = ""
            .dtp_datesheet.Text = ""
            .dtp_tracking_date.Text = ""
            .cbo_acc.Text = ""
            .cbo_court.Text = ""
            .cbo_department.Text = ""

            .chk_tracking_date.Checked = False
            .chk_datesheet.Checked = False
            .chk_verify_date.Checked = False

            If .chk_verify_date.Checked = False Then

                .dtp_verify_date.Enabled = False

            End If


            If .chk_datesheet.Checked = False Then

                .dtp_datesheet.Enabled = False

            End If


            If .chk_tracking_date.Checked = False Then

                .dtp_tracking_date.Enabled = False

            End If

        End With

    End Sub

End Class