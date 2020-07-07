Option Explicit On
Imports System.Data.SqlClient
Public Class FrmPort


    Private Sub FrmPort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        _Datetimeformatshort(dtp_datesend)
        _Datetimeformatshort(dtp_date_review)
        _Datetimeformatshort(dtp_date_soc)

        _comboboxadd(cbo_owner, "Customer_Owner", "Execution_Port")

        _comboboxadd(cbo_status, "Legal_status", "Execution_Port")

        _comboboxadd(cbo_type_result, "Review_Result", "Execution_Port")

        cbo_type_result.SelectedIndex = -1
        cbo_status.SelectedIndex = -1
        cbo_owner.SelectedIndex = -1


        Dim _type() As String = {"ธนาคาร", "เลขที่บัตรประชาชน", "เลขที่ลูกหนี้", "เลขที่สัญญา", "ชื่อ-นามสกุล"}

        _cboArray(cbo_type_find, _type)

    End Sub
    Private Sub _find()

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
        sql &= $"LIKE '%'+ @find +'%' ORDER BY EP.Customer_Id_Card"

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

            _datagrid_format_dateshort(dtgv_exeport, 7)
            _datagrid_format_dateshort(dtgv_exeport, 12)

            dtgv_exeport.Visible = True
            lbl_search.Text = $"พบข้อมูล {dtgv_exeport.RowCount.ToString} รายการ.."
            lbl_search.ForeColor = Color.Green

        End If

        cn.Close()

    End Sub

    Private Sub _write()

        txt_address.ReadOnly = False
        txt_cuscus.ReadOnly = False
        txt_cusid.ReadOnly = False
        txt_countacc.ReadOnly = False
        txt_cusname.ReadOnly = False
        txt_oa.ReadOnly = False
        txt_office.ReadOnly = False
        txt_review_description.ReadOnly = False
        txt_user.ReadOnly = False

        chk_date_send.Enabled = True
        chk_date_soc.Enabled = True
        chk_review.Enabled = True

        cbo_acc.Enabled = True
        cbo_owner.Enabled = True
        cbo_status.Enabled = True
        cbo_type_result.Enabled = True

    End Sub

    Private Sub _Readonly()

        txt_address.ReadOnly = True
        txt_cuscus.ReadOnly = True
        txt_cusid.ReadOnly = True
        txt_countacc.ReadOnly = True
        txt_cusname.ReadOnly = True
        txt_oa.ReadOnly = True
        txt_office.ReadOnly = True
        txt_review_description.ReadOnly = True
        txt_user.ReadOnly = True

        chk_date_send.Enabled = False
        chk_date_soc.Enabled = False
        chk_review.Enabled = False

        cbo_acc.Enabled = False
        cbo_owner.Enabled = False
        cbo_status.Enabled = False
        cbo_type_result.Enabled = False

        If chk_date_send.Enabled = False Then
            dtp_datesend.Enabled = False
        End If
        If chk_date_soc.Enabled = False Then
            dtp_date_soc.Enabled = False
        End If
        If chk_review.Enabled = False Then
            dtp_date_review.Enabled = False
        End If


    End Sub
    Private Sub _cleartext()

        txt_countacc.Text = ""
        txt_cuscus.Text = ""
        txt_cusid.Text = ""
        txt_cusname.Text = ""
        txt_oa.Text = ""
        txt_review_description.Text = ""
        txt_user.Text = ""
        txt_office.Text = ""
        txt_address.Text = ""

        dtp_datesend.Text = ""
        dtp_date_review.Text = ""
        dtp_date_soc.Text = ""

        cbo_type_result.Text = ""
        cbo_status.Text = ""
        cbo_owner.Text = ""
        cbo_acc.Text = ""

        chk_date_send.Checked = False
        chk_date_soc.Checked = False
        chk_review.Checked = False

        If chk_date_send.Checked = False Then
            dtp_datesend.Enabled = False
        End If
        If chk_date_soc.Checked = False Then
            dtp_date_soc.Enabled = False
        End If
        If chk_review.Checked = False Then
            dtp_date_review.Enabled = False
        End If
    End Sub

    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        _find()
        _Readonly()

    End Sub

    Private Sub dtgv_exeport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_exeport.CellClick

        _cleartext()

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

                cbo_acc.Items.Clear()

                For i = 0 To .Rows.Count - 1

                    If .Rows(i).Cells(4).Value.ToString = .CurrentRow.Cells(4).Value.ToString Then


                        cbo_acc.Items.Add(.Rows(i).Cells(3).Value.ToString)
                        cbo_acc.SelectedIndex = 0
                        txt_countacc.Text = cbo_acc.Items.Count.ToString

                    End If

                Next

                If .CurrentRow.Cells(7).Value.ToString = "" Then
                    chk_date_send.Checked = False
                Else
                    chk_date_send.Checked = True
                End If
                If .CurrentRow.Cells(12).Value.ToString = "" Then
                    chk_date_soc.Checked = False
                Else
                    chk_date_soc.Checked = True
                End If

                _Readonly()
            End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FrmPort_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click

        _Readonly()
        _cleartext()

    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click

        _write()

        If chk_date_send.Checked = True Then

            dtp_datesend.Enabled = True
        Else
            dtp_datesend.Enabled = False

        End If

        If chk_date_soc.Checked = True Then

            dtp_date_soc.Enabled = True
        Else
            dtp_date_soc.Enabled = False

        End If

    End Sub

    Private Sub cmd_update_Click(sender As Object, e As EventArgs) Handles cmd_update.Click
        connect()
        Dim Primarykeys As String = $"{cbo_owner.Text}-{txt_cusid.Text}"

        sql = $"UPDATE Execution_port SET Customer_Owner = @owner,Customer_Id_Card = @Id,Customer_number = @number,Customer_Name = @name,OA = @OA,Legal_Status = @status,Date_send = @send,Review_Result = @result,Review_Result_Description = @Description,Employees_User = @Employees WHERE Customer_Owner = '{cbo_owner.Text}' AND Customer_Id_Card = '{txt_cusid.Text}';
               UPDATE EXESOC SET EXEKEY = @key,Customer_Owner = @owner,Customer_Id_Card = @Id,Customer_OFFICE = @office,Customer_date_SOC = @datesoc,Customer_Address = @address WHERE Customer_Owner = '{cbo_owner.Text}' AND Customer_Id_Card = '{txt_cusid.Text}';"

        cmd = New SqlCommand(sql, cn)
        With cmd.Parameters
            .Clear()
            .AddWithValue("Owner", cbo_owner.Text)
            .AddWithValue("Id", txt_cusid.Text)
            .AddWithValue("number", txt_cuscus.Text)
            .AddWithValue("name", txt_cusname.Text)
            .AddWithValue("OA", txt_oa.Text)
            .AddWithValue("status", cbo_status.Text)
            .AddWithValue("send", dtp_datesend.Text)
            .AddWithValue("result", cbo_type_result.Text)
            .AddWithValue("Description", txt_review_description.Text)
            .AddWithValue("Employees", txt_user.Text)
            .AddWithValue("key", Primarykeys)
            .AddWithValue("office", txt_office.Text)
            .AddWithValue("datesoc", dtp_date_soc.Text)
            .AddWithValue("address", txt_address.Text)
        End With

        If Msg_confirm("คุณต้องการแก้ไข หรือ อัพเดต ข้อมูลใช่หรือไม่") = vbYes Then
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then

                Msg_OK("อัพเดตข้อมูลสำเร็จ")
                _Getlogdata($" อัพเดต ข้อมูลคัดประกันสังคม {vbNewLine} ลูกค้า {txt_cusname.Text} {vbNewLine} เลขที่บัตรประชาชน {txt_cusid.Text} ")
                cn.Close()
            Else
                Msg_error("อัพเดตข้อมูลล้มเหลว")
                cn.Close()
            End If

        End If

    End Sub

    Private Sub cmd_delete_Click(sender As Object, e As EventArgs) Handles cmd_delete.Click

        connect()
        sql = $"DELETE FROM Execution_port WHERE Customer_Owner = '{cbo_owner.Text}' AND Customer_Id_Card = '{txt_cusid.Text}';
                DELETE FROM EXESOC WHERE Customer_Owner = '{cbo_owner.Text}' AND Customer_Id_Card = '{txt_cusid.Text}'; "
        cmd = New SqlCommand(sql, cn)

        If Msg_confirm("คุณต้องการ ลบ ข้อมูลนี้ใช่หรือไม่") = vbYes Then
            Dim x As Integer = cmd.ExecuteNonQuery()
            If x > 0 Then
                Msg_OK("ลบข้อมูลสำเร็จ")
                _Getlogdata($" ลบ ข้อมูลคัดประกันสังคม {vbNewLine} ลูกค้า {txt_cusname.Text} {vbNewLine} เลขที่บัตรประชาชน {txt_cusid.Text}  ")
                cn.Close()
            Else
                Msg_error("ลบข้อมูลล้มเหลว")
                cn.Close()
            End If
        End If
    End Sub

    Private Sub chk_date_soc_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_soc.CheckedChanged

        If chk_date_soc.Checked = True Then

            dtp_date_soc.Enabled = True
        Else
            dtp_date_soc.Enabled = False

        End If
    End Sub

    Private Sub chk_date_send_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_send.CheckedChanged

        If chk_date_send.Checked = True Then

            dtp_datesend.Enabled = True
        Else
            dtp_datesend.Enabled = False

        End If
    End Sub

    Private Sub chk_review_CheckedChanged(sender As Object, e As EventArgs) Handles chk_review.CheckedChanged

        If chk_review.Checked = True Then

            dtp_date_review.Enabled = True
        Else
            dtp_date_review.Enabled = False

        End If

    End Sub

End Class