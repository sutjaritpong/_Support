
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

        Cleardatagrid(FrmTracking.dtgv_invalid)

        If txt_find.Text = "" Then

            Msg_error("กรุณากรอกเลขที่บัตรประชาชนลูกค้า")

            Return

        End If

        Connect()

        Dim _headertext() As String = {"PK", "Product", "เลขที่บัตรประชาชน", "ชื่อ-นามสกุล", "ศาล", "คดีแดง", "วันที่ในคำร้อง", "พนักงานบังคับคดี", "รายละเอียด", "ใบงานแถลงบัญชี", "Collectorส่งเรื่องออกใบงาน"}

        sql = $"SELECT * FROM EXETRACKING WHERE Customer_idc = '{txt_find.Text}' OR Customer_fullname = '{txt_find.Text}' "

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "findtk")

        With FrmTracking

            .dtgv_invalid.DataSource = DS.Tables("findtk")

            .dtgv_invalid.Columns(0).Visible = False

            For i = 0 To _headertext.Length - 1

                .dtgv_invalid.Columns(i).HeaderText = _headertext(i)

            Next

            If .dtgv_invalid.Rows.Count <= 0 Then

                .lbl_invalid.Text = "ไม่พบข้อมูลที่ค้นหา"
                .lbl_invalid.ForeColor = Color.Red
            Else
                .lbl_invalid.Text = $"จำนวนผลลัพธ์ที่พบ = { Str(.dtgv_invalid.RowCount.ToString)} แถว"
                .lbl_invalid.ForeColor = Color.DarkGreen
                Datagrid_format_dateshort(FrmTracking.dtgv_invalid, 6)
                Datagrid_format_dateshort(FrmTracking.dtgv_invalid, 12)
            End If

        End With

        Cleardatagrid(FrmTracking.dtgv_tracking)

        Dim _headers() As String = {"ธนาคาร", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "ศาล", "เลขคดีแดง", "วันที่ออกใบงานแถลงบัญชี"}

        _sql = $"SELECT S.EXEBANK,S.EXEID,S.EXECUSTOMER,S.EXECOURT,S.EXERED,S.EXEDATEWORK FROM EXESM AS S WHERE S.EXEID LIKE '%{txt_find.Text}%' OR  S.EXECUSTOMER LIKE '%{txt_find.Text}%'"

        cmd = New SqlCommand(_sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "findsm")

        With FrmTracking

            If .dtgv_tracking.RowCount = 0 Or .dtgv_tracking.ColumnCount = 0 Then

                .dtgv_tracking.DataSource = DS.Tables("findsm")

                For x = 0 To _headers.Length - 1

                    .dtgv_tracking.Columns(x).HeaderText = _headers(x)

                Next

            End If


            If (.dtgv_tracking.RowCount = 0) Or (.dtgv_tracking.ColumnCount = 0) Then

                .lbl_tracking.Text = "ไม่พบข้อมูลที่ค้นหา"
                .lbl_tracking.ForeColor = Color.Red
            Else
                .lbl_tracking.Text = $"จำนวนผลลัพธ์ที่พบ = { Str(.dtgv_tracking.RowCount.ToString)} แถว"
                .lbl_tracking.ForeColor = Color.DarkGreen
                Datagrid_format_dateshort(FrmTracking.dtgv_tracking, 5)
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

        End With

    End Sub

    Private Sub Cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click

        Me.Close()

    End Sub
End Class