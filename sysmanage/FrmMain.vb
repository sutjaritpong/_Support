Option Explicit On
Imports System.IO
Imports System.Data.SqlClient
Imports System.Net
Imports System.ComponentModel
Imports Microsoft.Win32
Imports System.Linq
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Public Class FrmMain
    Dim ip As IPAddress()

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()
        _Getlogdata("LOGIN")
        Me.WindowState = FormWindowState.Maximized              '// ทำให้ Form หลักมีขนาดเต็มจอ

    End Sub
    Private Sub ออกจากระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ออกจากระบบToolStripMenuItem.Click
        If Msg_confirm("คุณต้องการปิดโปรแกรมใช่หรือไม่") = vbYes Then
            cn.Close()
        End If    '// ปุ่มออกจากระบบเมื่อกดจะมีข้อความแจ้งเตือน

        Me.Close()
    End Sub
    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles accms.Click
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

    Private Sub settingms_Click(sender As Object, e As EventArgs) Handles settingms.Click

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
            .txt_passlog.Text = ""
            .txt_passlog.Select()
        End With
        '// Event ปิดโปรแกรมเมื่อปิดฟอร์ม Main
    End Sub

    Private Sub ประวตการเขาใชโปรแกรมLogFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Historyms.Click
        With Frmlogfile
            .MdiParent = Me
            .Show()
            .WindowState = FormWindowState.Maximized
        End With
    End Sub


    Private Sub changespassword_Click(sender As Object, e As EventArgs) Handles changespassword.Click

        If Application.OpenForms().OfType(Of FrmPasssetting).Any Then

            FrmPasssetting.Focus()
        Else
            With FrmPasssetting
                .MdiParent = Me
                .Show()
            End With
        End If
    End Sub

    Private Sub Uploads_Click(sender As Object, e As EventArgs) Handles Uploads.Click
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

    Private Sub Upload_exe_Click(sender As Object, e As EventArgs) Handles Upload_exe.Click
        With Frmimportexe
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

    Private Sub tab_report_Click(sender As Object, e As EventArgs) Handles tab_report.Click
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
End Class
