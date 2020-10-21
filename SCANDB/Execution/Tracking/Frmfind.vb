
Imports System.Data.SqlClient
Public Class Frmfind

    '## Sub _autocomplete เรียกใช้งาน จาก VBcode ในโฟลเดอร์ Classmodule เพื่อให้ง่ายต่อ การค้นหา

    Private Sub Frmfind_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        sql = "SELECT DISTINCT Customer_idc,Customer_fullname FROM EXETRACKING"

        cmd = New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()

        While reader.Read()

            autocomp.Add(reader("Customer_idc"))
            autocomp.Add(reader("Customer_fullname"))

        End While

        reader.Close()

        txt_find.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_find.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_find.AutoCompleteCustomSource = autocomp


        cn.Close()

    End Sub

    Private Sub Cmd_find_Click(sender As Object, e As EventArgs) Handles cmd_find.Click

        Cleardatagrid(FrmTracking.Dtgv_Tracking)

        If txt_find.Text = "" Then

            Msg_error("กรุณากรอกเลขที่บัตรประชาชนลูกค้า")

            Return

        End If

        Connect()


        sql = $" SELECT ETR.Tracking_Primary,ETR.Customer_Owner,ETR.Customer_idc,ETR.Customer_Account,ETR.Customer_Fullname,ETR.Tracking_court,ETR.Tracking_red,ETR.Tracking_date_sheet,ETR.Tracking_date_work,ETR.Tracking_total,EMP.EXEEMPLOYEES,ETR.Tracking_detail,ETR.Tracking_nosheet,ETR.Tracking_Collector_nosend,ETR.Tracking_other  FROM EXETRACKING AS ETR LEFT JOIN EXEEMPLOYEE AS EMP ON ETR.EMPLOYEES_KEY = EMP.EMPLOYEES_KEY WHERE Customer_idc = '{txt_find.Text}' OR Customer_fullname = '{txt_find.Text}' "

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "findtk")

        With FrmTracking

            .Dtgv_Tracking.DataSource = DS.Tables("findtk")

            For visiblecolumns = 11 To .Dtgv_Tracking.Columns.Count - 1


                .Dtgv_Tracking.Columns(visiblecolumns).Visible = False


            Next

            .Dtgv_Tracking.Columns(0).Visible = False


            For i = 0 To FrmTracking.header.Length - 1

                .Dtgv_Tracking.Columns(i).HeaderText = FrmTracking.header(i)

            Next

            If .Dtgv_Tracking.Rows.Count <= 0 Then

                .Lbl_Tracking.Text = "ไม่พบข้อมูลที่ค้นหา"
                .Lbl_Tracking.ForeColor = Color.Red
            Else
                .Lbl_Tracking.Text = $"จำนวนผลลัพธ์ที่พบ = { Str(.Dtgv_Tracking.RowCount.ToString)} แถว"
                .Lbl_Tracking.ForeColor = Color.DarkGreen
                Datagrid_format_dateshort(FrmTracking.Dtgv_Tracking, 8)
                Datagrid_format_dateshort(FrmTracking.Dtgv_Tracking, 14)
            End If

        End With

        Cleardatagrid(FrmTracking.Dtgv_Accounting)

        Dim _headers() As String = {"ธนาคาร", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "ศาล", "เลขคดีแดง", "วันที่ออกใบงานแถลงบัญชี"}

        _sql = $"SELECT S.EXEBANK,S.EXEID,S.EXECUSTOMER,S.EXECOURT,S.EXERED,S.EXEDATEWORK FROM EXESM AS S WHERE S.EXEID LIKE '%{txt_find.Text}%' OR  S.EXECUSTOMER LIKE '%{txt_find.Text}%'"

        cmd = New SqlCommand(_sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "findsm")

        With FrmTracking

            If .Dtgv_Accounting.RowCount = 0 Or .Dtgv_Accounting.ColumnCount = 0 Then

                .Dtgv_Accounting.DataSource = DS.Tables("findsm")

                For x = 0 To _headers.Length - 1

                    .Dtgv_Accounting.Columns(x).HeaderText = _headers(x)

                Next

            End If


            If (.Dtgv_Accounting.RowCount = 0) Or (.Dtgv_Accounting.ColumnCount = 0) Then

                .Lbl_Accounting.Text = "ไม่พบข้อมูลที่ค้นหา"
                .Lbl_Accounting.ForeColor = Color.Red
            Else
                .Lbl_Accounting.Text = $"จำนวนผลลัพธ์ที่พบ = { Str(.Dtgv_Accounting.RowCount.ToString)} แถว"
                .Lbl_Accounting.ForeColor = Color.DarkGreen
                Datagrid_format_dateshort(FrmTracking.Dtgv_Accounting, 5)
            End If


        End With

        txt_find.Clear()
        cn.Close()
        Me.Close()

    End Sub

    Private Sub Clear_obj()

        With FrmTracking

            .txt_court.Text = ""
            .txt_cusid.Text = ""
            .txt_cusname.Text = ""
            .txt_detail.Text = ""
            .txt_red.Text = ""
            .cbo_detail.Text = ""
            .cbo_document.Text = ""
            .cbo_empexe.Text = ""
            .cbo_owner.Text = ""
            .cbo_waning.Text = ""
            .dtp_date_send.Text = ""
            .dtp_date_verify.Text = ""
            .chk_datesend.Checked = False
            .chk_datetracking.Checked = False

            .Lbl_Tracking.Text = "ผลลัพธ์การค้นหา"

        End With

    End Sub

    Private Sub Cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click

        Me.Close()

    End Sub
End Class