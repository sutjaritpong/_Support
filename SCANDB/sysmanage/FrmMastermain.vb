Option Explicit On
Imports System.IO
Imports System.Data.SqlClient
Imports System.Net
Public Class FrmMastermain
    Friend ip As IPAddress()
    Private Sub FrmMastermain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connect()
        Getlogdata("LOGIN")
        Me.WindowState = FormWindowState.Maximized              '// ทำให้ Form หลักมีขนาดเต็มจอ

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        txt_timer.Text = DateAndTime.TimeString                     '//ตั้งเวลาโปรแกรม
        txt_datetoday.Text = DateAndTime.Today.ToShortDateString        '//ตั้งเวลาวันที่ 

    End Sub

    Private Sub Menu_tap_logout_Click(sender As Object, e As EventArgs) Handles Menu_tap_logout.Click

        If Msg_confirm("คุณต้องการปิดโปรแกรมใช่หรือไม่") = vbYes Then

            cn.Close()
            cnLegal.Close()
            cn_GE.Close()
            cn_TMB.Close()
            cn_TMBSME.Close()
            cn_KBANK.Close()
            cn_TBANK.Close()
            cn_UOB.Close()
            cn_SCB.Close()

            Me.Close()
        End If    '// ปุ่มออกจากระบบเมื่อกดจะมีข้อความแจ้งเตือน

    End Sub

    'Execution Menu
    Private Sub Menu_exeport_Click(sender As Object, e As EventArgs) Handles Menu_exeport.Click

        With FrmPort
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Menu_ownership_Click(sender As Object, e As EventArgs) Handles Menu_ownership.Click

        With Frmownership
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_EXEACC_Click(sender As Object, e As EventArgs) Handles Menu_EXEACC.Click

        With FrmEXEACC
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_EXEStatement_Click(sender As Object, e As EventArgs) Handles Menu_EXEStatement.Click

        With FrmExecution
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_EXEverify_Click(sender As Object, e As EventArgs) Handles Menu_EXEverify.Click

        With FrmTracking
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_income_Click(sender As Object, e As EventArgs) Handles Menu_income.Click

        With FrmIncome
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_EXEWDS_Click(sender As Object, e As EventArgs) Handles Menu_EXEWDS.Click

        With FrmWDS
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_insolvent_Click(sender As Object, e As EventArgs) Handles Menu_insolvent.Click

        With FrmInsolvent
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub
    '------ End Execution Menu------

    'SCANPDF Menu
    Private Sub KBANKscanpdf_Click(sender As Object, e As EventArgs) Handles KBANKscanpdf.Click

        With FrmKBANK
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub TSSscanpdf_Click(sender As Object, e As EventArgs) Handles TSSscanpdf.Click

        With FrmTSS
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub TMBscanpdf_Click(sender As Object, e As EventArgs) Handles TMBscanpdf.Click

        With FrmTMB
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub SCBscanpdf_Click(sender As Object, e As EventArgs) Handles SCBscanpdf.Click

        With FrmSCB
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub UOBscanpdf_Click(sender As Object, e As EventArgs) Handles UOBscanpdf.Click

        With FrmUOB
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Tbankscanpdf_Click(sender As Object, e As EventArgs) Handles Tbankscanpdf.Click

        With FrmTBANK
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub KKBscanpdf_Click(sender As Object, e As EventArgs) Handles KKBscanpdf.Click

        With FrmKKB
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    '--------------- End SCANPDF

    'SCB ZERO Menu

    Private Sub Menu_Tab_ScbLegal_Click(sender As Object, e As EventArgs) Handles Menu_Tab_ScbLegal.Click

        With FrmLegalSCB
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_tab_ScbCollector_Click(sender As Object, e As EventArgs) Handles Menu_tab_ScbCollector.Click

        With Frmcollector
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    'End SCB ZERO

    'Manage Menu
    Private Sub Menu_accms_Click(sender As Object, e As EventArgs) Handles menu_accms.Click

        With FrmAccount
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_settingms_Click(sender As Object, e As EventArgs) Handles menu_settingms.Click

        With FrmSetting
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_Historyms_Click(sender As Object, e As EventArgs) Handles menu_Historyms.Click


        If Application.OpenForms.OfType(Of FrmSetting).Any Then

            FrmSetting.Focus()
        Else
            With FrmSetting
                .ShowDialog()
            End With

        End If

    End Sub

    Private Sub Menu_changespassword_Click(sender As Object, e As EventArgs) Handles menu_changespassword.Click

        If Application.OpenForms().OfType(Of FrmPasssetting).Any Then

            FrmPasssetting.Focus()
        Else
            With FrmPasssetting
                .MdiParent = Me
                .Show()
            End With
        End If

    End Sub

    Private Sub Menu_logexe_Click(sender As Object, e As EventArgs) Handles Menu_logexe.Click

        With frmlogfileexe
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub
    'Menu UPLOAD 

    Private Sub MENU_Uploads_SCANPDF_Click(sender As Object, e As EventArgs) Handles MENU_Uploads_SCANPDF.Click

        With Frmimport
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_Upload_Execution_Click(sender As Object, e As EventArgs) Handles Menu_Upload_Execution.Click

        With Frmimportexe
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    'UPLOAD Report Execution 

    'Private Sub Menu_ReportAccounting_Click(sender As Object, e As EventArgs) Handles Menu_ReportAccounting.Click

    '    With FrmAccountingRV
    '        .MdiParent = Me
    '        .Show()
    '        .WindowState = FormWindowState.Maximized
    '    End With

    'End Sub

    'Private Sub Menu_Reportstatement_Click(sender As Object, e As EventArgs) Handles Menu_Reportstatement.Click

    '    With FrmStatementRV
    '        .MdiParent = Me
    '        .Show()
    '        .WindowState = FormWindowState.Maximized
    '    End With

    'End Sub

    'Private Sub Menu_Reporttracking_Click(sender As Object, e As EventArgs) Handles Menu_Reporttracking.Click

    '    With FrmTrackRV
    '        .MdiParent = Me
    '        .Show()
    '        .WindowState = FormWindowState.Maximized
    '    End With


    'End Sub

    'Private Sub Menu_ReportWDS_Click(sender As Object, e As EventArgs) Handles Menu_ReportWDS.Click

    '    With FrmWDSRV
    '        .MdiParent = Me
    '        .Show()
    '        .WindowState = FormWindowState.Maximized
    '    End With

    'End Sub

    'Private Sub Menu_tab_report_Click(sender As Object, e As EventArgs) Handles menu_tab_report.Click

    '    With Frmreportexe
    '        .MdiParent = Me
    '        .Show()
    '        .WindowState = FormWindowState.Maximized
    '    End With

    'End Sub

    ' IT MENU

    Private Sub Main_menu_it_Click(sender As Object, e As EventArgs) Handles Main_menu_it.Click

        With FrmITSupport
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub FrmMastermain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.Dispose()

        With FrmLogin
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
            FrmLogin.txt_idlog.Enabled = True
            FrmLogin.txt_passlog.Enabled = True
            .txt_passlog.Text = ""
            .txt_passlog.Select()
        End With
        '// Event ปิดโปรแกรมเมื่อปิดฟอร์ม Main

    End Sub


End Class