Public Class FrmWDSRV
    Private Sub FrmWDSRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCANPDFDataSet.EXEWDS' table. You can move, or remove it, as needed.
        Me.EXEWDSTableAdapter.Fill(Me.SCANPDFDataSet.EXEWDS)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class