Option Explicit On
Imports System.Data.SqlClient
Public Class FrmPort
    Private Sub FrmPort_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _comboboxadd(cbo_owner, "Customer_Owner", "Execution_Port")

        _comboboxadd(cbo_status, "Legal_status", "Execution_Port")

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

        sql = $"SELECT * FROM Execution_Port"

        Select Case cbo_type_find.SelectedItem
            Case "ธนาคาร" : sql &= $" WHERE Customer_Owner = @find ORDER BY Customer_Id_Card"
            Case "เลขที่บัตรประชาชน" : sql &= $" WHERE Customer_Id_Card = @find ORDER BY Customer_Id_Card"
            Case "เลขที่ลูกหนี้" : sql &= $" WHERE Customer_Number = @find ORDER BY Customer_Id_Card"
            Case "เลขที่สัญญา" : sql &= $" WHERE Serial_Account = @find ORDER BY Customer_Id_Card"
            Case "ชื่อ-นามสกุล" : sql &= $" WHERE Customer_Name = @find ORDER BY Customer_Id_Card"
        End Select

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("find", txt_find.Text)
        DA.SelectCommand = cmd
        DS = New DataSet
        DA.Fill(DS, "tables")

        If DS.Tables("tables").Rows.Count <= 0 Then
            Msg_error("ไม่พบข้อมูลที่ค้นหา")
            Exit Sub
        End If

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

        End With

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