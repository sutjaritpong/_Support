Imports System.Data.SqlClient
Public Class FrmWDSRV
    Private Sub FrmWDSRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCANPDF.EXECHECK' table. You can move, or remove it, as needed.
        Me.EXECHECKTableAdapter.Fill(Me.SCANPDF.EXECHECK)
        'TODO: This line of code loads data into the 'SCANPDFDataSet.EXEWDS' table. You can move, or remove it, as needed.
        Me.EXEWDSTableAdapter.Fill(Me.SCANPDF.EXEWDS)

        Me.ReportViewer1.RefreshReport()

        EXEWDSBindingSource.Sort = "EXECUSOWN, EXEDATEWDS DESC"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub EXEWDSBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ReportViewer1_ReportExport(sender As Object, e As Microsoft.Reporting.WinForms.ReportExportEventArgs) Handles ReportViewer1.ReportExport

        Connect()
        Getlogdata("Report Export ข้อมูล ถอนอายัด/ยึด")

    End Sub
End Class