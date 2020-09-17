Public Class FrmSCBZeroRV
    Private Sub FrmSCBZeroRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'SCBZERO.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.SCBZERO.DataTable1)

    End Sub

End Class