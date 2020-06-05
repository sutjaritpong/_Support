Option Explicit On
Imports System.Data.SqlClient

Public Class FrmInsolvent
    Private Sub FrmInsolvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        _comboboxadd(cbo_owner, "EXEBANK", "EXESM")


    End Sub

    Private Sub Chk_date_request_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_date_request.CheckedChanged

        If Chk_date_request.Checked = True Then

            dtp_date_request.Enabled = True
        Else
            dtp_date_request.Enabled = False
        End If

    End Sub

    Private Sub chk_verify_insolvent_CheckedChanged(sender As Object, e As EventArgs) Handles chk_verify_insolvent.CheckedChanged

        If chk_verify_insolvent.Checked = True Then

            dtp_verify_insolvent.Enabled = True
        Else
            dtp_verify_insolvent.Enabled = False
        End If

    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_send.CheckedChanged

        If chk_date_send.Checked = True Then

            dtp_date_send.Enabled = True
        Else
            dtp_date_send.Enabled = False
        End If


    End Sub

End Class