Public Class FrmWDSRV
    Private Sub FrmWDSRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCANPDFDataSet.EXEWDS' table. You can move, or remove it, as needed.
        Me.EXEWDSTableAdapter.Fill(Me.SCANPDFDataSet.EXEWDS)

        Me.ReportViewer1.RefreshReport()

        EXEWDSBindingSource.Sort = "EXECUSOWN, EXEDATEWDS DESC"
    End Sub

    Private Sub EXEWDSBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles EXEWDSBindingSource.CurrentChanged

    End Sub
End Class