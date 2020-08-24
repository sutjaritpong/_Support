Option Explicit On
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
    Private Sub Cmd_import_Click(sender As Object, e As EventArgs) Handles cmd_import.Click
        Dim FileName As String = OpenFileDialog1.FileName
        Dim OpenFileDialog As New OpenFileDialog

        Dim Pathfile As String = "\\192.168.1.5\Performance\Performance_SCB\Performance_SCB.xls"

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"
        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dtgv_Exe.Columns.Clear()
            Pathfile = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)

        End If
        Dim conn As OleDbConnection
        'Dim dtr As OleDbDataReader
        Dim dta As OleDbDataAdapter
        'Dim cmd As OleDbCommand
        Dim dts As DataSet
        Dim excel As String
        Dim fi As New FileInfo(OpenFileDialog1.FileName)

        excel = fi.FullName
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
        dta = New OleDbDataAdapter("Select * From [Daily_Payment$]", conn)
        dts = New DataSet
        dta.Fill(dts, "[Daily_Payment$]")
        Dtgv_Exe.DataSource = dts
        Dtgv_Exe.DataMember = "[Daily_Payment$]"

        Dtgv_Exe.DefaultCellStyle.BackColor = Color.White
        conn.Close()


        'For Each col As DataGridViewColumn In Dtgv_Exe.Columns
        '    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'Next

    End Sub

    Private Sub Frmcollector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class