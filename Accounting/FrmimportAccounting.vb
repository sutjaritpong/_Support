Option Explicit On
Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml
Public Class FrmimportAccounting
    Private Sub FrmimportAccounting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgv_view.Visible = False
        Main_progressbar.Visible = False
        Main_progressbar.Value = 0
        lbl_statusprogress.Visible = False
        connect()
        Dim pds() As String = {"KBANK", "TBANK", "SCB", "KKB", "TMB", "UOB", "TSS"}
        cbo_products.Items.AddRange(pds)
        cbo_products.SelectedIndex = 0

        Dim _cbotypes() As String = {"เบิกงวด 1", "เบิกงวด 2", "บังคับคดี", "FILE SCAN"}
        cbo_types_Accounting.Items.AddRange(_cbotypes)
        cbo_types_Accounting.SelectedIndex = 0

        dtgv_clear()
        For Each col As DataGridViewColumn In dtgv_view.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
        With BackgroundWorker1
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With
        '//
        Control.CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub cmd_import_Click(sender As Object, e As EventArgs) Handles cmd_import.Click
        If lbl_statusprogress.Text <> "0 %" Then
            Msg_error("มีข้อมูลที่กำลังทำงานอยู่ในขณะนี้")
            Return
        End If
        If txt_import.Text = "" Then
            Msg_error("กรุณาเลือกข้อมูลที่ต้องการ UPLOAD ก่อน")
            Return
        End If
        dtgv_view.Visible = True
        dtgv_view.Columns.Clear()
        dtgv_view.DataSource = Nothing
        Excelimport()

        'dtgv_view.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        'dtgv_view.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        'dtgv_view.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
    End Sub

    Sub dtgv_clear()

        dtgv_view.Columns.Clear()
        If dtgv_view.Columns.Count = 0 Then
            With dtgv_view

                .Columns.Clear()
                .Columns.Add("เลขที่สัญญา", "เลขที่สัญญา")
                .Columns.Add("Pathfile", "file")
                .Columns.Add("Product", "Product")
                .Columns.Add("Bank", "Bank")
                .Columns.Add("type", "type")

            End With
        End If
        For Each col As DataGridViewColumn In dtgv_view.Columns

            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Next

        dtgv_view.DataSource = Nothing

    End Sub

    Private Sub cmd_openfile_Click(sender As Object, e As EventArgs) Handles cmd_openfile.Click

        Dim FileName As String = OpenFileDialog1.FileName
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            dtgv_view.Columns.Clear()
            txt_import.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub cmd_toserver_Click(sender As Object, e As EventArgs) Handles cmd_toserver.Click

        lbl_countimport.Visible = True
        lbl_statusprogress.Visible = True
        lbl_grandtotal.Visible = True
        Main_progressbar.Visible = True

        If lbl_statusprogress.Text <> "0 %" Then

            Msg_error("มีข้อมูลที่กำลังทำงานอยู่ในขณะนี้")
            Exit Sub
        End If
        If txt_import.Text = "" Then
            Msg_error("กรุณาเลือกไฟล์ที่ต้องการ UPLOAD")
            Exit Sub
        End If

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        lbl_statusprogress.Visible = True

        loads()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        Main_progressbar.Value = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        sql = " SELECT COUNT(*) AS TYPEs FROM "

        Select Case cbo_products.SelectedItem

            Case "KBANK" : sql &= "AccountingKBANK"

        End Select

        cmd.CommandText = sql
        DA.SelectCommand = cmd
        DA.Fill(DS, "CountRows")

        MessageBox.Show("โหลดข้อมูลเสร็จสิ้น ข้อมูลทั้งหมด" & " " & DS.Tables("CountRows").Rows(0)("TYPEs") & " " & "แภว", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lbl_statusprogress.Text = "0 %"
        Main_progressbar.Value = 0
        lbl_countimport.Text = dtgv_view.Rows.Count & " " & "รายการ"
        Main_progressbar.Visible = False
        lbl_statusprogress.Visible = False

        _Getlogdata($"UPLOAD {cbo_products.Text} จำนวน {dtgv_view.Rows.Count}")
        dtgv_view.DataSource = Nothing

    End Sub

    Private Sub cmd_cut_check_Click(sender As Object, e As EventArgs) Handles cmd_cut_check.Click

        _checkdata()

    End Sub
    Public Sub loads()
        Dim y As Integer = dtgv_view.Rows.Count
        Dim Max As Integer = 100


        Try
            For i As Integer = 0 To dtgv_view.Rows.Count - 1 Step +1
                Dim p As Integer = ((i / y) * Max)

                connect()

                sql = "INSERT INTO "

                Select Case cbo_products.SelectedItem

                    Case "KBANK" : sql &= $"AccountingKBANK(Accounting_PK,Accounting_Number,Accounting_CUSCUS,Accounting_Name,Accounting_black_red,Accounting_date_legal,Accounting_court,Accounting_capital,Accounting_receipt,Accounting_invoice,Accounting_date_send,Accounting_type_legal,Accounting_type_master)VALUES('{dtgv_view.Rows(i).Cells(1).Value.ToString}-{dtgv_view.Rows(i).Cells(8).Value.ToString}-{dtgv_view.Rows(i).Cells(10).Value.ToString}','{dtgv_view.Rows(i).Cells(0).Value.ToString}','{dtgv_view.Rows(i).Cells(1).Value.ToString}','{dtgv_view.Rows(i).Cells(2).Value.ToString}','{dtgv_view.Rows(i).Cells(3).Value.ToString}','{dtgv_view.Rows(i).Cells(4).Value.ToString}','{dtgv_view.Rows(i).Cells(5).Value.ToString}','{dtgv_view.Rows(i).Cells(6).Value.ToString}','{dtgv_view.Rows(i).Cells(7).Value.ToString}','{dtgv_view.Rows(i).Cells(8).Value.ToString}','{dtgv_view.Rows(i).Cells(9).Value.ToString}','{dtgv_view.Rows(i).Cells(10).Value.ToString}','{dtgv_view.Rows(i).Cells(11).Value.ToString}')"

                        lbl_statusprogress.Text = i.ToString & "/" & dtgv_view.Rows.Count.ToString
                        Main_progressbar.Value = (i / y) * Max
                        Threading.Thread.Sleep(100)
                        lbl_statusprogress.Text = i + 1.ToString & "/" & dtgv_view.Rows.Count.ToString

                        '--------------------------UPLOAD KBANK ACCOUNTING------------------

                End Select

                cmd = New SqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

            Next

        Catch ex As Exception

            MsgBox(ex.ToString)
        Finally
            cn.Close()

        End Try

    End Sub
    Public Sub Excelimport()

        Dim conn As OleDbConnection
        'Dim dtr As OleDbDataReader
        Dim dta As OleDbDataAdapter
        Dim cmd As OleDbCommand
        Dim dts As DataSet
        Dim excel As String
        Dim fi As New FileInfo(OpenFileDialog1.FileName)

        excel = fi.FullName
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
        Dim exceloledb As String = "SELECT * FROM "

        Select Case cbo_types_Accounting.SelectedItem
            Case "เบิกงวด 1" : exceloledb &= "[งวด 1$]"
            Case "เบิกงวด 2" : exceloledb &= "[งวด 2$]"
            Case "บังคับคดี" : exceloledb &= "[บังคับคดี$]"
            Case "FILE SCAN" : exceloledb &= "[Sheet1$]"
        End Select

        dta = New OleDbDataAdapter(exceloledb, conn)
        dts = New DataSet
        dta.Fill(dts, "tables")
        dtgv_view.DataSource = dts
        dtgv_view.DataMember = "tables"
        conn.Close()
        lbl_countimport.Text = dtgv_view.Rows.Count & " " & "รายการ"
        For Each col As DataGridViewColumn In dtgv_view.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
        dtgv_view.Visible = True
    End Sub
    Private Sub FrmimportAccounting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.Dispose()
        cn.Close()

    End Sub

    '    Private Sub _checkdata()

    '        connect()
    '        sql = $"SELECT * FROM AccountingKBANK"
    '        cmd = New SqlCommand(sql, cn)
    '        DA = New SqlDataAdapter(cmd)
    '        DS = New DataSet
    '        DA.Fill(DS, "checkdata")

    '        For i = 0 To DS.Tables("checkdata").Rows.Count - 1
    '            For y = 0 To dtgv_view.RowCount - 1
    '                If (DS.Tables("checkdata").Rows(i)("Accounting_PK").ToString) = ($"{dtgv_view.Rows(y).Cells(1).Value.ToString}-{dtgv_view.Rows(y).Cells(9).Value.ToString}-{dtgv_view.Rows(y).Cells(11).Value.ToString}") Then
    '                    dtgv_view.Rows(y).DefaultCellStyle.BackColor = Color.Red
    '                End If
    '            Next
    '        Next

    '    End Sub
    Private Sub _checkdata()

        connect()
        sql = $"SELECT Accounting_PK FROM AccountingKBANK"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            For y = 0 To dtgv_view.RowCount - 1
                If DR(0).ToString = ($"{dtgv_view.Rows(y).Cells(1).Value.ToString}-{dtgv_view.Rows(y).Cells(8).Value.ToString}-{dtgv_view.Rows(y).Cells(10).Value.ToString}") Then
                    dtgv_view.Rows(y).DefaultCellStyle.BackColor = Color.Red
                End If
            Next
        End While
        DR.Close()


    End Sub

    Private Sub cmd_test_Click(sender As Object, e As EventArgs) Handles cmd_test.Click

        For u As Integer = dtgv_view.Rows.Count() - 1 To 0 Step -1
            Dim delete As Color
            delete = dtgv_view.Rows(u).DefaultCellStyle.BackColor
            If delete = Color.Red Then
                Dim row As DataGridViewRow
                row = dtgv_view.Rows(u)
                dtgv_view.Rows.Remove(row)
            End If

        Next
    End Sub
End Class