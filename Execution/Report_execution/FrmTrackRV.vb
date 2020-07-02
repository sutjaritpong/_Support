Public Class FrmTrackRV
    Private Sub FrmTrackRV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SCANPDF.EXETRACKING' table. You can move, or remove it, as needed.
        Me.EXETRACKINGTableAdapter.Fill(Me.SCANPDF.EXETRACKING)
        'TODO: This line of code loads data into the 'SCANPDF.EXEEMPLOYEE' table. You can move, or remove it, as needed.
        Me.EXEEMPLOYEETableAdapter.Fill(Me.SCANPDF.EXEEMPLOYEE)
        'TODO: This line of code loads data into the 'SCANPDF.JOINTRACKEMP' table. You can move, or remove it, as needed.
        Me.JOINTRACKEMPTableAdapter.Filljointrackingemp(Me.SCANPDF.JOINTRACKEMP)


        Me.ReportViewer1.RefreshReport()
    End Sub

End Class