﻿Imports System.Data
Imports System.Data.SqlClient
Public Class FrmCheck
    Private Sub FrmCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbo_cusowner.SelectedIndex = -1
        check_notedit()



    End Sub


    Private Sub dtgv_check_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgv_check.CellMouseUp
        Try
            If e.RowIndex = -1 Then Exit Sub

            With dtgv_check

                cbo_cusowner.Text = CStr(.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
                txt_checkbank.Text = CStr(.Rows.Item(e.RowIndex).Cells(2).Value.ToString)
                txt_hub.Text = CStr(.Rows.Item(e.RowIndex).Cells(3).Value.ToString)
                txt_numcheck.Text = CStr(.Rows.Item(e.RowIndex).Cells(4).Value.ToString)
                dtp_datecheck.Text = CStr(.Rows.Item(e.RowIndex).Cells(5).Value.ToString)
                txt_totalcheck.Text = CStr(.Rows.Item(e.RowIndex).Cells(6).Value.ToString)
                txt_cusid.Text = CStr(.Rows.Item(e.RowIndex).Cells(7).Value.ToString)
                txt_cusacc.Text = CStr(.Rows.Item(e.RowIndex).Cells(8).Value.ToString)
                txt_cusaccno.Text = CStr(.Rows.Item(e.RowIndex).Cells(9).Value.ToString)
                txt_cusname.Text = CStr(.Rows.Item(e.RowIndex).Cells(10).Value.ToString)
                dtp_checksend.Text = CStr(.Rows.Item(e.RowIndex).Cells(12).Value.ToString)
                txt_total.Text = CStr(.Rows.Item(e.RowIndex).Cells(13).Value.ToString)
                txt_refund.Text = CStr(.Rows.Item(e.RowIndex).Cells(14).Value.ToString)
                txt_note.Text = CStr(.Rows.Item(e.RowIndex).Cells(15).Value.ToString)

            End With


            If dtgv_check.Rows.Item(e.RowIndex).Cells(5).Value.ToString = "" Then

                chk_datecheck.Checked = False
            Else

                chk_datecheck.Checked = True

            End If

            If dtgv_check.Rows.Item(e.RowIndex).Cells(12).Value.ToString = "" Then

                chk_checksend.Checked = False

            Else

                chk_checksend.Checked = True

            End If



        Catch ex As Exception

        End Try

        check_notedit()

    End Sub
    Private Sub check_notedit()

        txt_checkbank.ReadOnly = True
        txt_hub.ReadOnly = True
        txt_numcheck.ReadOnly = True
        txt_totalcheck.ReadOnly = True
        txt_cusid.ReadOnly = True
        txt_cusacc.ReadOnly = True
        txt_cusaccno.ReadOnly = True
        txt_cusname.ReadOnly = True
        txt_total.ReadOnly = True
        txt_refund.ReadOnly = True
        txt_note.ReadOnly = True

        dtp_checksend.Enabled = False
        dtp_datecheck.Enabled = False
        chk_checksend.Enabled = False
        chk_datecheck.Enabled = False

    End Sub
    Private Sub check_edit()

        txt_checkbank.ReadOnly = False
        txt_hub.ReadOnly = False
        txt_numcheck.ReadOnly = False
        txt_totalcheck.ReadOnly = False
        txt_cusid.ReadOnly = False
        txt_cusacc.ReadOnly = False
        txt_cusaccno.ReadOnly = False
        txt_cusname.ReadOnly = False
        txt_total.ReadOnly = False
        txt_refund.ReadOnly = False
        txt_note.ReadOnly = False


        chk_checksend.Enabled = True
        chk_datecheck.Enabled = True
    End Sub

    Private Sub btn_editch_Click(sender As Object, e As EventArgs) Handles btn_editch.Click

        check_edit()

        If chk_checksend.Checked = True Then

            dtp_checksend.Enabled = True

        Else

            dtp_checksend.Enabled = False

        End If

        If chk_datecheck.Checked = True Then

            dtp_datecheck.Enabled = True

        Else

            dtp_datecheck.Enabled = False

        End If


    End Sub

    Private Sub btn_savech_Click(sender As Object, e As EventArgs) Handles btn_savech.Click

        updatecheck()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        cancel_edit()

    End Sub
    Public Sub cancel_edit()

        cbo_cusowner.SelectedIndex = -1
        cbo_cusowner.Text = ""
        txt_checkbank.Text = ""
        txt_hub.Text = ""
        txt_numcheck.Text = ""
        dtp_datecheck.Text = Nothing
        txt_totalcheck.Text = ""
        txt_cusid.Text = ""
        txt_cusacc.Text = ""
        txt_cusaccno.Text = ""
        txt_cusname.Text = ""
        dtp_checksend.Text = Nothing
        txt_total.Text = ""
        txt_refund.Text = ""
        txt_note.Text = ""


        chk_checksend.Checked = False
        chk_datecheck.Checked = False
        check_notedit()

    End Sub
    Private Sub updatecheck()
        connect()

        If txt_cusid.ReadOnly = False Then

            sql = $"UPDATE EXECHECK SET CHKOWN = '{cbo_cusowner.Text}',CHKBANK = '{txt_checkbank.Text}',CHKHUB = '{txt_hub.Text}',CHKNUM = '{txt_numcheck.Text}',CHKDATE = '{dtp_datecheck.Text}',CHKTOTAL = '{txt_totalcheck.Text}',CHKIDC = '{txt_cusid.Text}',CHKACC = '{txt_cusacc.Text}',CHKACCNO = '{txt_cusaccno.Text}',CHKNAME = '{txt_cusname.Text}',CHKDATESEND = '{dtp_checksend.Text}',CHKTOTALEXE = '{txt_total.Text}',CHKTOTALEXERE = '{txt_refund.Text}',CHKDETAIL1 = '{txt_note.Text}' WHERE (CHKACC = '{FrmWDS.txt_cusacc.Text}' AND CHKNAME = '{FrmWDS.txt_cusname.Text}') OR (CHKACCNO = '{txt_cusaccno.Text}' AND CHKNAME = '{txt_cusname.Text}')"

            cmd = New SqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            Msg_OK("แก้ไขข้อมูลสำเร็จ")
            cancel_edit()
        Else

            Msg_error("ไม่สามารถแก้ไขข้อมูลได้")

        End If
    End Sub
    Private Sub savecheck()

        If txt_cusname.Text = "" Then

            Msg_error("กรุณาใส่ข้อมูลให้ครบ")

        Else

            connect()

            sql = $"INSERT INTO EXECHECK(CHKKEY,CHKOWN,CHKBANK,CHKHUB,CHKNUM,CHKDATE,CHKTOTAL,CHKIDC,CHKACC,CHKACCNO,CHKDATESEND,CHKTOTALEXE,CHKTOTALEXERE,CHKDETAIL1)VALUES('{cbo_cusowner.Text}','{txt_checkbank.Text}','{txt_hub.Text}','{txt_numcheck.Text}','{dtp_datecheck.Text}','{txt_totalcheck.Text}','{txt_cusid.Text}','{txt_cusacc.Text}','{txt_cusaccno.Text}','{dtp_checksend.Text}','{txt_total.Text}','{txt_refund.Text}','{txt_note.Text}')"

            cmd = New SqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            Msg_OK("บันทึกข้อมูลสำเร็จ")
            cancel_edit()

            _Getlogdata($"เพิ่มข้อมูล เช็ค ถอนอายัด/ยึด {cbo_cusowner.Text}-{txt_cusacc.Text}-{FrmWDS.txt_cusname.Text} ")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        savecheck()

    End Sub
End Class