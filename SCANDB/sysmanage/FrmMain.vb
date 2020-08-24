Option Explicit On
Imports System.IO
Imports System.Data.SqlClient
Imports System.Net

Public Class FrmMastermain
    Friend ip As IPAddress()

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()
        Getlogdata("LOGIN")
        Me.WindowState = FormWindowState.Maximized              '// ทำให้ Form หลักมีขนาดเต็มจอ

    End Sub
    Private Sub ออกจากระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menu_tap_logout.Click

        If Msg_confirm("คุณต้องการปิดโปรแกรมใช่หรือไม่") = vbYes Then

            cn.Close()
            Me.Close()
        End If    '// ปุ่มออกจากระบบเมื่อกดจะมีข้อความแจ้งเตือน


    End Sub
    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menu_accms.Click
        With FrmAccount
            .MdiParent = Me                             '// แสดง Form ตั้งค่า USER & PASSWORD
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub
    Private Sub KBANKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KBANKscanpdf.Click
        With FrmKBANK
            .MdiParent = Me                             '// แสดง Form ค้นหา PDF KBANK
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub TBANKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Tbankscanpdf.Click
        With FrmTBANK
            .MdiParent = Me                             '// แสดง Form ค้นหา PDF TBANK     
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub SCBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SCBscanpdf.Click
        With FrmSCB
            .MdiParent = Me                              '// แสดง Form ค้นหา PDF SCB             
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub KKBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KKBscanpdf.Click
        With FrmKKB
            .MdiParent = Me                              '// แสดง Form ค้นหา PDF KKB
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub TSSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TSSscanpdf.Click
        With FrmTSS
            .MdiParent = Me                              '// แสดง Form ค้นหา PDF TSS
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub
    Private Sub TMBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TMBscanpdf.Click
        With FrmTMB
            .MdiParent = Me                              '// แสดง Form ค้นหา PDF TMB
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub
    Private Sub UOBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UOBscanpdf.Click
        With FrmUOB
            .MdiParent = Me                              '// แสดง Form ค้นหา PDF UOB
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        txt_timer.Text = DateAndTime.TimeString                     '//ตั้งเวลาโปรแกรม

        txt_datetoday.Text = DateAndTime.Today.ToShortDateString        '//ตั้งเวลาวันที่ 
    End Sub

    Private Sub Settingms_Click(sender As Object, e As EventArgs) Handles menu_settingms.Click

        If Application.OpenForms.OfType(Of FrmSetting).Any Then

            FrmSetting.Focus()
        Else
            With FrmSetting
                .ShowDialog()
            End With

        End If

    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

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

    Private Sub Menu_Historyms_Click(sender As Object, e As EventArgs) Handles menu_Historyms.Click
        With Frmlogfile
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub


    Private Sub Hangespassword_Click(sender As Object, e As EventArgs) Handles menu_changespassword.Click

        If Application.OpenForms().OfType(Of FrmPasssetting).Any Then

            FrmPasssetting.Focus()
        Else
            With FrmPasssetting
                .MdiParent = Me
                .Show()
            End With
        End If
    End Sub

    Private Sub Uploads_Click(sender As Object, e As EventArgs) Handles MENU_Uploads_SCANPDF.Click
        With Frmimport
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub EXEStatement_Click(sender As Object, e As EventArgs) Handles Menu_EXEStatement.Click
        With FrmExecution
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub
    Private Sub EXEWDS_Click(sender As Object, e As EventArgs) Handles Menu_EXEWDS.Click
        With FrmWDS
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Tab_report_Click(sender As Object, e As EventArgs) Handles menu_tab_report.Click
        With Frmreportexe
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub บงคบคดตงเรองToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_EXEACC.Click
        With FrmEXEACC
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub งานฟองเองสงคดปกสToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Menu_exeport.Click
        With FrmPort
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

    Private Sub Menu_insolvent_Click(sender As Object, e As EventArgs) Handles Menu_insolvent.Click

        With FrmInsolvent
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

    Private Sub Menu_Upload_Execution_Click(sender As Object, e As EventArgs) Handles Menu_Upload_Execution.Click

        With Frmimportexe
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_list_Accounting_Click(sender As Object, e As EventArgs) Handles Menu_list_Accounting.Click

        With FrmimportAccounting
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub KBANKToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles menu_accounting_search.Click
        With FrmAccountingKBANK
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Menu_ReportWDS_Click(sender As Object, e As EventArgs) Handles Menu_ReportWDS.Click
        With FrmWDSRV
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Menu_Reportracking_Click(sender As Object, e As EventArgs) Handles Menu_Reporttracking.Click
        With FrmTrackRV
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Menu_ReportAccounting_Click(sender As Object, e As EventArgs) Handles Menu_ReportAccounting.Click
        With FrmAccountingRV
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Menu_Reportstatement_Click(sender As Object, e As EventArgs) Handles Menu_Reportstatement.Click
        With FrmStatementRV
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Menu_logexe_Click(sender As Object, e As EventArgs) Handles Menu_logexe.Click
        With frmlogfileexe
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Main_menu_it_Click(sender As Object, e As EventArgs) Handles Main_menu_it.Click

        With FrmITSupport
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub Menu_Tab_ScbLegal_Click(sender As Object, e As EventArgs) Handles Menu_Tab_ScbLegal.Click
        With FrmLegalSCB
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Menu_tab_ScbCollector_Click(sender As Object, e As EventArgs) Handles Menu_tab_ScbCollector.Click
        With FrmCollectorSCB
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub

    Private Sub Menu_tab_ScbReport_Click(sender As Object, e As EventArgs) Handles Menu_tab_ScbReport.Click
        With FrmReportSCB
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub
End Class
