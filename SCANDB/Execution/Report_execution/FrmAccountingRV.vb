Public Class FrmAccountingRV
    Private Sub FrmAccounting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCANPDF.EXEACC' table. You can move, or remove it, as needed.
        Me.EXEACCTableAdapter.Fill(Me.SCANPDF.EXEACC)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class