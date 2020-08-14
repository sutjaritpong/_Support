Public Class FrmlogexeRV
    Private Sub FrmlogexeRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'logexe_dataset.Execution_logfiles' table. You can move, or remove it, as needed.
        Me.Execution_logfilesTableAdapter.Fill(Me.logexe_dataset.Execution_logfiles)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class