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
Imports System.Windows.Forms
Imports GemBox.Spreadsheet
Imports GemBox.Spreadsheet.WinFormsUtilities
Public Class Frmcollector


    Private Sub Frmcollector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Cmd_import_Click(sender As Object, e As EventArgs) Handles cmd_import.Click
        Dim FileName As String = OpenFileDialog1.FileName
        Dim OpenFileDialog As New OpenFileDialog
        Try

            Dim Pathfile As String = "\\192.168.1.5\Performance\Performance_SCB\Performance_SCB.xls"

            OpenFileDialog1.FileName = Pathfile
            OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"
            'If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            '    Dtgv_Exe.Columns.Clear()
            '    Pathfile = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)

            'End If
            Dim conn As OleDbConnection
            'Dim dtr As OleDbDataReader
            Dim dta As OleDbDataAdapter
            'Dim cmd As OleDbCommand
            Dim dts As DataSet
            Dim excel As String
            Dim fi As New FileInfo(OpenFileDialog1.FileName)

            excel = fi.FullName
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
            sql = "Select * From [Daily_Payment$]"
            dta = New OleDbDataAdapter("Select * From [Daily_Payment$C4:BG63]", conn)
            dts = New DataSet
            dta.Fill(dts, "[Daily_Payment$]")
            Dtgv_Exe.DataSource = dts
            Dtgv_Exe.DataMember = "[Daily_Payment$]"

            Dtgv_Exe.DefaultCellStyle.BackColor = Color.White
            conn.Close()

            For x As Integer = 0 To 63
                If dts.Tables("[Daily_Payment$]").Rows(x)("COLLECTOR") = "" Then
                    Dtgv_Exe.Rows(x).DataGridView.Visible = False
                End If
            Next
            For i = 0 To Dtgv_Exe.ColumnCount - 1
                '    If i > 1 Then
                '        'For y = 4 To Dtgv_Exe.RowCount
                '    '    Dtgv_Exe.Rows(y).Cells(i).Value = Parse(Dtgv_Exe.Rows(y).Cells(i).Value.ToString("##,##0.00"))
                'Next

                '    End If
                If i > 9 Then

                    Dtgv_Exe.Columns(i).Visible = False

                End If

                If i > 57 Then

                    Dtgv_Exe.Columns(i).Visible = True


                End If
            Next

        Catch ex As exception

        End Try
        'For Each col As DataGridViewColumn In Dtgv_Exe.Columns
        '    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'Next

    End Sub

End Class