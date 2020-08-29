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

    Friend conn As OleDbConnection
    Friend dtr As OleDbDataReader
    Friend dta As OleDbDataAdapter
    Friend Olecmd As OleDbCommand
    Friend dts As DataSet
    Friend excel As String = ""


    Private Sub Frmcollector_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub Cmd_import_Click(sender As Object, e As EventArgs) Handles Cmd_ImportPerformance.Click

        Dim OpenFileDialog As New OpenFileDialog
        Dim Pathfile As String = "\\192.168.1.5\Performance\Performance_SCB\Performance_SCB.xls"
        Dim fi As New FileInfo(OpenFileDialog1.FileName)
        Dim FileName As String = OpenFileDialog1.FileName
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.FileName = Pathfile

        excel = fi.FullName
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
        dta = New OleDbDataAdapter("Select * From [HUB$C4:L29]", conn)
        dts = New DataSet
        dta.Fill(dts, "[HUB$]")

        Dtgv_Zero_collector.DataSource = dts
        Dtgv_Zero_collector.DataMember = "[HUB$]"
        conn.Close()

        For i = 0 To Dtgv_Zero_collector.RowCount - 1
            If Dtgv_Zero_collector.Rows(i).Cells(0).Value.ToString = "" Then

                Dtgv_Zero_collector.Rows(i).Visible = False

            End If
        Next

    End Sub

    Private Sub Cmd_ImportHub_Click(sender As Object, e As EventArgs) Handles Cmd_ImportHub.Click




    End Sub

    Private Sub Cmd_Daily_Payment_Click(sender As Object, e As EventArgs) Handles Cmd_Daily_Payment.Click

        Dim OpenFileDialog As New OpenFileDialog
        Dim Pathfile As String = "\\192.168.1.5\Performance\Performance_SCB\Performance_SCB.xls"
        Dim fi As New FileInfo(OpenFileDialog1.FileName)
        Dim FileName As String = OpenFileDialog1.FileName

        Try
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            OpenFileDialog1.FileName = Pathfile

            excel = fi.FullName
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")

            dta = New OleDbDataAdapter("Select * From [Daily_Payment$C4:BG63]", conn)
            dts = New DataSet
            dta.Fill(dts, "[Daily_Payment$]")
            Dtgv_Zero_collector.DataSource = dts
            Dtgv_Zero_collector.DataMember = "[Daily_Payment$]"

            Dtgv_Zero_collector.DefaultCellStyle.BackColor = Color.White
            conn.Close()



        Catch ex As Exception

        End Try

    End Sub

    'For i = 0 To Dtgv_Zero_collector.ColumnCount - 1
    '    If i > 1 Then
    '        For y = 4 To Dtgv_Zero_collector.RowCount
    '            Dtgv_Zero_collector.Rows(y).Cells(i).Value = Convert.ToDouble(Dtgv_Zero_collector.Rows(y).Cells(i).Value)
    '        Next

    '    End If
    '    For x = 0 To Dtgv_Zero_collector.RowCount - 1
    '        If Dtgv_Zero_collector.Rows(x).Cells(0).Value.ToString = "" Then

    '            Dtgv_Zero_collector.Rows(i).Visible = False

    '        End If
    '    Next
    '    If i > 57 Then

    '        Dtgv_Zero_collector.Columns(i).Visible = True

    '    End If
    'Next

    'For Each col As DataGridViewColumn In Dtgv_Exe.Columns
    '    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    'Next
    'If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '    Dtgv_Exe.Columns.Clear()
    '    Pathfile = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
    'end if

    'OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"
End Class