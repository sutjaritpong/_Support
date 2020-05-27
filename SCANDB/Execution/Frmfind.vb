Option Explicit On
Imports System.Data.SqlClient
Public Class Frmfind

    Private Sub Frmfind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If txt_findid.Text = "" Then
            Msg_error("กรุณากรอกเลขบัตรประชาชนที่ต้องการค้นหา")
            Return
        End If
        sql = $"SELECT EXESM.*,ET.EXEDATE,EV.EXEPERFOR,EV.EXERESDT,EV.EXEDET1,EV.EXEDET2,EV.EXEEMP,EV.EXERESULT AS ERE FROM EXESM LEFT JOIN EXETRACKING AS ET ON EXESM.EXEID= ET.EXEIDC LEFT JOIN EXEVERIFY AS EV ON EXESM.EXEID= EV.EXEIDC WHERE EXESM.EXEID = '{txt_findid.Text}' "
        Dim cmd As New SqlCommand(sql, cn)
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
                .cbo_acc.Items.AddRange(y)
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
                .dtp_tracking.Text = DS.Tables("table").Rows(0)("EXEDATE")
                .txt_EmployeeExE.Text = DS.Tables("table").Rows(0)("EXEEMP")
                .dtp_dateexework.Text = DS.Tables("table").Rows(0)("EXERESDT")
                .txt_detail2.Text = DS.Tables("table").Rows(0)("EXEDET1")
                .txt_detail3.Text = DS.Tables("table").Rows(0)("EXEDET2")
                .txt_verifyResult.Text = DS.Tables("table").Rows(0)("ERE")
                .txt_perfor.Text = DS.Tables("table").Rows(0)("EXEPERFOR")

                .Reader()
                .txt_total.Text = CDbl(FrmExecution.txt_total.Text).ToString("##,##0.00")
            End With

            Me.Close()

        End If

        cn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click
        Me.Close()
    End Sub
End Class