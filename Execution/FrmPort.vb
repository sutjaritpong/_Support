Option Explicit On
Imports System.Data.SqlClient
Public Class FrmPort
    Private Sub FrmPort_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _comboboxadd(cbo_owner, "Customer_Owner", "Execution_Port")

        _comboboxadd(cbo_status, "Legal_status", "Execution_Port")

        _comboboxadd(cbo_type_result, "Review_Result", "Execution_Port")

        cbo_type_result.SelectedIndex = -1
        cbo_status.SelectedIndex = -1
        cbo_owner.SelectedIndex = -1


        Dim _type() As String = {"ธนาคาร", "เลขที่บัตรประชาชน", "เลขที่ลูกหนี้", "เลขที่สัญญา", "ชื่อ-นามสกุล"}

        _cboArray(cbo_type_find, _type)

    End Sub

    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        _cleardatagrid(dtgv_exeport)

        connect()

        If txt_find.Text = "" Then

            Msg_error("กรุณากรอกข้อมูลที่ต้องการค้นหา")
            Exit Sub

        End If

        sql = $"SELECT EP.*,ES.Customer_OFFICE,ES.Customer_date_SOC,Customer_Address FROM Execution_Port AS EP LEFT JOIN EXESOC AS ES ON EP.Customer_Id_Card = ES.Customer_Id_Card "

        Select Case cbo_type_find.SelectedItem
            Case "ธนาคาร" : sql &= $" WHERE EP.Customer_Owner "
            Case "เลขที่บัตรประชาชน" : sql &= $" WHERE EP.Customer_Id_Card "
            Case "เลขที่ลูกหนี้" : sql &= $" WHERE EP.Customer_Number "
            Case "เลขที่สัญญา" : sql &= $" WHERE EP.Serial_Account "
            Case "ชื่อ-นามสกุล" : sql &= $" WHERE EP.Customer_Name "
        End Select
        sql &= $"= '%' + @find + '%' ORDER BY EP.Customer_Id_Card"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("find", txt_find.Text)
        DA.SelectCommand = cmd
        DS = New DataSet
        DA.Fill(DS, "tables")

        If DS.Tables("tables").Rows.Count <= 0 Then
            lbl_search.Text = "ไม่พบข้อมูลที่ค้นหา.."
            lbl_search.ForeColor = Color.Red
            dtgv_exeport.Visible = False
            Exit Sub
        Else

            With dtgv_exeport

                .DataSource = DS.Tables("tables")
                .Columns(0).HeaderText = "ธนาคาร"
                .Columns(1).HeaderText = "เลขบัตรประชาชน"
                .Columns(2).HeaderText = "เลขที่ลูกหนี้"
                .Columns(3).HeaderText = "เลขที่สัญญา"
                .Columns(4).HeaderText = "ชื่อ-นามสกุล"
                .Columns(5).HeaderText = "OA"
                .Columns(6).HeaderText = "ประเภท"
                .Columns(7).HeaderText = "วันที่ส่งคัด ปกส."
                .Columns(8).HeaderText = "ผลอนุมัติ/ไม่อนุมัติ"
                .Columns(9).HeaderText = "เหตุผลที่ไม่อนุมัติ"
                .Columns(10).HeaderText = "USER"
                .Columns(11).HeaderText = "บริษัท/ที่ทำงาน"
                .Columns(12).HeaderText = "วันที่ส่งผลคัด"
                .Columns(13).HeaderText = "ที่ตั้ง"

            End With

            dtgv_exeport.Visible = True
            lbl_search.Text = $"พบข้อมูล {dtgv_exeport.RowCount.ToString} รายการ.."
            lbl_search.ForeColor = Color.Green

        End If

        cn.Close()

    End Sub

    Private Sub dtgv_exeport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_exeport.CellClick

        cleartext()

        Try
            With dtgv_exeport

                cbo_owner.Text = .CurrentRow.Cells(0).Value.ToString
                txt_cusid.Text = .CurrentRow.Cells(1).Value.ToString
                txt_cuscus.Text = .CurrentRow.Cells(2).Value.ToString
                txt_cusname.Text = .CurrentRow.Cells(4).Value.ToString
                txt_oa.Text = .CurrentRow.Cells(5).Value.ToString
                cbo_status.Text = .CurrentRow.Cells(6).Value.ToString
                dtp_datesend.Text = .CurrentRow.Cells(7).Value.ToString
                cbo_type_result.Text = .CurrentRow.Cells(8).Value.ToString
                txt_review_description.Text = .CurrentRow.Cells(9).Value.ToString
                txt_user.Text = .CurrentRow.Cells(10).Value.ToString
                txt_office.Text = .CurrentRow.Cells(11).Value.ToString
                dtp_date_soc.Text = .CurrentRow.Cells(12).Value.ToString
                txt_address.Text = .CurrentRow.Cells(13).Value.ToString

                For i = 0 To .Rows.Count - 1
                    If .Rows(i).Cells(4).Value.ToString = .CurrentRow.Cells(4).Value.ToString Then

                        cbo_acc.Items.Add(.Rows(i).Cells(3).Value.ToString)
                        cbo_acc.SelectedIndex = 0
                        txt_countacc.Text = cbo_acc.Items.Count.ToString

                    End If

                Next

            End With
        Catch ex As Exception

        End Try
    End Sub
    Sub cleartext()

        txt_countacc.Text = ""
        txt_cuscus.Text = ""
        txt_cusid.Text = ""
        txt_cusname.Text = ""
        txt_oa.Text = ""
        cbo_acc.Items.Clear()

    End Sub

    Private Sub FrmPort_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub

End Class