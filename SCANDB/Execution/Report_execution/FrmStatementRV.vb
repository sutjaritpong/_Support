Public Class FrmStatementRV
    Private Sub FrmStatementRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StatementDataSet.EXESM' table. You can move, or remove it, as needed.
        Me.EXESMTableAdapter.Fill(Me.StatementDataSet.EXESM)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class