
Imports System.Data.SqlClient
Public Class Frmfind

    '## Sub _autocomplete เรียกใช้งาน จาก VBcode ในโฟลเดอร์ Classmodule เพื่อให้ง่ายต่อ การค้นหา

    Private Sub Frmfind_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        _autocomplete(txt_findid, "Customer_idc", "EXETRACKING")

        cn.Close()

    End Sub

    Private Sub cmd_find_Click(sender As Object, e As EventArgs) Handles cmd_find.Click

        _cleardatagrid(FrmTracking.dtgv_invalid)

        If txt_findid.Text = "" Then

            Msg_error("กรุณากรอกเลขที่บัตรประชาชนลูกค้า")

            Return

        End If

        connect()

        Dim _headertext() As String = {"PK", "Product", "เลขที่บัตรประชาชน", "ชื่อ-นามสกุล", "ศาล", "คดีแดง", "วันที่ในคำร้อง", "พนักงานบังคับคดี", "รายละเอียด", "ใบงานแถลงบัญชี", "Collectorส่งเรื่องออกใบงาน"}

        sql = $"SELECT * FROM EXETRACKING WHERE Customer_idc = '{txt_findid.Text}' "

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

            cn.Close()
            txt_findid.Clear()

        End With

        Me.Close()

    End Sub

    Private Sub _clear()

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


End Class