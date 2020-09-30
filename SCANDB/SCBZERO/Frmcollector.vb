Option Explicit On
Imports System.Data.SqlClient
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Imports System.Globalization
Imports System.Data.OleDb
Imports System.Linq
Imports System.Net

Public Class Frmcollector
    Private Sub Frmcollector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '# Tab Main Performance

        '# Tab UPLOAD Performance

        With BackgroundWorker1
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With
        '//
        Control.CheckForIllegalCrossThreadCalls = False


    End Sub

    '# Tab UPLOAD Performance

    Private Sub OledbImport()

        Dim conn As OleDbConnection
        'Dim dtr As OleDbDataReader
        Dim dta As OleDbDataAdapter
        'Dim cmd As OleDbCommand
        Dim dts As DataSet
        Dim excel As String
        Dim fi As New FileInfo(OpenFileDialog1.FileName)

        excel = fi.FullName
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
        dta = New OleDbDataAdapter("Select * From [Payment$]", conn)
        dts = New DataSet
        dta.Fill(dts, "[Payment$]")
        Dtgv_Zero_collector.DataSource = dts
        Dtgv_Zero_collector.DataMember = "[Payment$]"

        Dtgv_Zero_collector.DefaultCellStyle.BackColor = Color.White
        conn.Close()


    End Sub
    Private Sub InsertQuery()

        If Dtgv_Zero_collector.Rows.Count = Nothing Then

            Msg_error("กรุณาเลือกข้อมูลที่ต้องการอัพโหลดแล้วลองใหม่อีกครั้ง")

            Exit Sub

        End If

        Connect()

        Dim y As Integer = Dtgv_Zero_collector.Rows.Count
        Dim Max As Integer = 100

        For i As Integer = 0 To Dtgv_Zero_collector.RowCount

            If Dtgv_Zero_collector.Rows(i).Cells(0).Value.ToString = "" Then

                Exit For

            End If

            sql = $"INSERT INTO Zero_SCB_Performance(Performance_CARD,Performance_Accounting,Performance_Date,Performance_Amount,Performance_UserAccount,Performance_Product,Performance_User,Performance_Hub)VALUES(@card,@account,@date,@Amount,@User,@Product,@UserPer,@Hub)"

            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("card", Dtgv_Zero_collector.Rows(i).Cells(0).Value.ToString)
            cmd.Parameters.AddWithValue("account", Dtgv_Zero_collector.Rows(i).Cells(1).Value.ToString)
            cmd.Parameters.AddWithValue("date", Dtgv_Zero_collector.Rows(i).Cells(2).Value.ToString)
            cmd.Parameters.AddWithValue("Amount", Dtgv_Zero_collector.Rows(i).Cells(3).Value)
            cmd.Parameters.AddWithValue("User", Dtgv_Zero_collector.Rows(i).Cells(4).Value.ToString)
            cmd.Parameters.AddWithValue("Product", Dtgv_Zero_collector.Rows(i).Cells(5).Value.ToString)
            cmd.Parameters.AddWithValue("Userper", Dtgv_Zero_collector.Rows(i).Cells(6).Value.ToString)
            cmd.Parameters.AddWithValue("Hub", Dtgv_Zero_collector.Rows(i).Cells(7).Value.ToString)
            cmd.ExecuteNonQuery()


            lbl_Performance_Upload.Text = i.ToString & "/" & Dtgv_Zero_collector.Rows.Count.ToString
            ProgressBar_Performance_Upload.Value = (i / y) * Max
            Threading.Thread.Sleep(100)

        Next


    End Sub

    Private Sub Cmd_Performance_Findexcel_Click(sender As Object, e As EventArgs) Handles Cmd_Performance_Findexcel.Click

        Dim FileName As String = OpenFileDialog1.FileName
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

            Dtgv_Zero_collector.Columns.Clear()
            Txt_Performance_path.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)

        End If

    End Sub
    Private Sub Cmd_Performance_Import_Click(sender As Object, e As EventArgs) Handles Cmd_Performance_ImportPerformance.Click

        BackgroundWorker1.RunWorkerAsync()

    End Sub


    Private Sub Cmd_performance_ImportPayment_Click(sender As Object, e As EventArgs) Handles Cmd_Performance_ImportPayment.Click

        If Txt_Performance_path.Text = "" Then

            Msg_error("ไม่พบข้อมูลที่ต้องการ UPLOAD กรุณาเลือกไฟล์ที่ต้องการอีกครั้ง")
            Exit Sub

        Else

            OledbImport()

        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        InsertQuery()

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        ProgressBar_Performance_Upload.Value = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted


        Msg_OK("UPLOAD เสร็จสิ้น")
        lbl_Performance_Upload.Text = "0/0"
        ProgressBar_Performance_Upload.Value = 0

    End Sub
End Class