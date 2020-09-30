Public Class FrmLegalScbRV
    Private Sub FrmLegalScbRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCBZERO.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.SCBZERO.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class