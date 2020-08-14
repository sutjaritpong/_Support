Option Explicit On
Option Strict On
Public Class FrmITSupport
    Private Sub FrmIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_ipmanage_Click(sender As Object, e As EventArgs) Handles cmd_ipmanage.Click

        If Application.OpenForms.OfType(Of FrmmanageIP).Any Then

            FrmmanageIP.Focus()
        Else
            With FrmmanageIP
                .MdiParent = FrmMastermain
                .Show()
                .WindowState = FormWindowState.Maximized
            End With

        End If

    End Sub

    Private Sub cmd_CCTVmanage_Click(sender As Object, e As EventArgs) Handles cmd_CCTVmanage.Click

        If Application.OpenForms.OfType(Of FrmmanageCCTV).Any Then

            FrmmanageCCTV.Focus()
        Else
            With FrmmanageCCTV
                .MdiParent = FrmMastermain
                .Show()
                .WindowState = FormWindowState.Maximized
            End With
        End If

    End Sub

    Private Sub cmd_Pcmanage_Click(sender As Object, e As EventArgs) Handles cmd_Pcmanage.Click

        If Application.OpenForms.OfType(Of FrmmanagePC).Any Then

            FrmmanagePC.Focus()
        Else
            With FrmmanagePC
                .MdiParent = FrmMastermain
                .Show()
                .WindowState = FormWindowState.Maximized
            End With
        End If

    End Sub

    Private Sub cmd_wifimanage_Click(sender As Object, e As EventArgs) Handles cmd_wifimanage.Click

        If Application.OpenForms.OfType(Of FrmmanageRouter).Any Then

            FrmmanageRouter.Focus()
        Else
            With FrmmanageRouter
                .MdiParent = FrmMastermain
                .Show()
                .WindowState = FormWindowState.Maximized
            End With

        End If

    End Sub

    Private Sub cmd_servermanage_Click(sender As Object, e As EventArgs) Handles cmd_servermanage.Click

        If Application.OpenForms.OfType(Of FrmDomainServer).Any Then

            FrmDomainServer.Focus()
        Else
            With FrmDomainServer
                .MdiParent = FrmMastermain
                .Show()
                .WindowState = FormWindowState.Maximized
            End With
        End If

    End Sub

    Private Sub cmd_logIT_Click(sender As Object, e As EventArgs) Handles cmd_logIT.Click

        If Application.OpenForms.OfType(Of Frmhistorylog).Any Then

            Frmhistorylog.Focus()
        Else
            With Frmhistorylog
                .MdiParent = FrmMastermain
                .Show()
                .WindowState = FormWindowState.Maximized
            End With
        End If

    End Sub

End Class