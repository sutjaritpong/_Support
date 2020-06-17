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
Public Class Frmimport

    Private Sub Frmimport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgv_view.Visible = False
        Main_progressbar.Visible = False
        Main_progressbar.Value = 0
        lbl_statusprogress.Visible = False
        connect()
        Dim pds() As String = {"KBANK", "TBANK", "SCB", "KKB", "TMB", "UOB", "TSS"}
        cbo_products.Items.AddRange(pds)
        cbo_products.SelectedIndex = 0
        dtgv_clear()
        For Each col As DataGridViewColumn In dtgv_view.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
        With BackgroundWorker1
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With

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
        If lbl_statusprogress.Text <> "0 %" Then

            Msg_error("มีข้อมูลที่กำลังทำงานอยู่ในขณะนี้")
            Exit Sub
        End If
        If txt_import.Text = "" Then
            Msg_error("กรุณาเลือกไฟล์ที่ต้องการ UPLOAD")
            Exit Sub
        End If
        If dtgv_view.Rows(0).Cells(2).Value.ToString <> cbo_products.Text Then

            Msg_error("กรุณาเลือกโปรดักให้ตรงกับข้อมูลที่ต้องการโหลด")
            Exit Sub

        End If
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        sql = " SELECT COUNT(*) AS TYPEs FROM "

        Select Case cbo_products.SelectedItem
            Case "KBANK" : sql &= "KBANKscdb"
            Case "SCB" : sql &= "SCBscdb"
            Case "TBANK" : sql &= "TBANKscdb"
            Case "UOB" : sql &= "UOBscdb"
            Case "TMB" : sql &= "TMBscdb"
            Case "TSS" : sql &= "TSSscdb"
            Case "KKB" : sql &= "KKBscdb"

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

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        lbl_statusprogress.Visible = True

        loads()

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        Main_progressbar.Value = e.ProgressPercentage

    End Sub
    Public Sub loads()
        Dim y As Integer = dtgv_view.Rows.Count
        Dim Max As Integer = 100
        Dim timenow As String = DateAndTime.TimeString
        Dim datenow As String = DateAndTime.Today.ToShortDateString

        Try
            For i As Integer = 0 To dtgv_view.Rows.Count - 1 Step +1
                Dim p As Integer = ((i / y) * Max)



                connect()


                sql = "INSERT INTO "

                Select Case cbo_products.SelectedItem

                    Case "KBANK" : sql &= $"KBANKscdb(ACCKEY,ACCKBANK,PDF,PRODUCT,BANK,[TYPE],MONTH_LOAD)VALUES('{dtgv_view.Rows(i).Cells(0).Value.ToString}-{dtgv_view.Rows(i).Cells(4).Value.ToString}-{datenow}-{timenow}','{dtgv_view.Rows(i).Cells(0).Value.ToString}','{dtgv_view.Rows(i).Cells(1).Value.ToString}','{dtgv_view.Rows(i).Cells(2).Value.ToString}','{dtgv_view.Rows(i).Cells(3).Value.ToString}','{dtgv_view.Rows(i).Cells(4).Value.ToString}','{dtgv_view.Rows(i).Cells(5).Value.ToString}')"

                        timenow = DateAndTime.TimeOfDay.AddSeconds(+1)
                        Main_progressbar.Visible = True
                        lbl_statusprogress.Text = p.ToString & "%"
                        Main_progressbar.Value = (i / y) * Max
                        Threading.Thread.Sleep(100)
                    '--------------------------UPLOAD KBANK------------------
                    Case "SCB" : sql &= $"SCBscdb(ACCKEY,ACCSCB,PDF,PRODUCT,BANK,[TYPE],MONTH_LOAD)VALUES('{dtgv_view.Rows(i).Cells(0).Value.ToString}-{dtgv_view.Rows(i).Cells(4).Value.ToString}-{datenow}-{timenow}','{dtgv_view.Rows(i).Cells(0).Value.ToString}','{dtgv_view.Rows(i).Cells(1).Value.ToString}','{dtgv_view.Rows(i).Cells(2).Value.ToString}','{dtgv_view.Rows(i).Cells(3).Value.ToString}','{dtgv_view.Rows(i).Cells(4).Value.ToString}','{dtgv_view.Rows(i).Cells(5).Value.ToString}')"

                        timenow = DateAndTime.TimeOfDay.AddSeconds(+1)
                        Main_progressbar.Visible = True
                        lbl_statusprogress.Text = p.ToString & "%"
                        Main_progressbar.Value = (i / y) * Max
                        Threading.Thread.Sleep(100)
                    '--------------------------UPLOAD SCB------------------
                    Case "TBANK" : sql &= $"TBANKscdb(ACCKEY,ACCTBANK,PDF,PRODUCT,BANK,[TYPE],MONTH_LOAD)VALUES('{dtgv_view.Rows(i).Cells(0).Value.ToString}-{dtgv_view.Rows(i).Cells(4).Value.ToString}-{datenow}-{timenow}','{dtgv_view.Rows(i).Cells(0).Value.ToString}','{dtgv_view.Rows(i).Cells(1).Value.ToString}','{dtgv_view.Rows(i).Cells(2).Value.ToString}','{dtgv_view.Rows(i).Cells(3).Value.ToString}','{dtgv_view.Rows(i).Cells(4).Value.ToString}','{dtgv_view.Rows(i).Cells(5).Value.ToString}')"

                        timenow = DateAndTime.TimeOfDay.AddSeconds(+1)
                        Main_progressbar.Visible = True
                        lbl_statusprogress.Text = p.ToString & "%"
                        Main_progressbar.Value = (i / y) * Max
                        Threading.Thread.Sleep(100)
                    '--------------------------UPLOAD TBANK------------------
                    Case "UOB" : sql &= $"UOBscdb(ACCKEY,ACCUOB,PDF,PRODUCT,BANK,[TYPE],MONTH_LOAD)VALUES('{dtgv_view.Rows(i).Cells(0).Value.ToString}-{dtgv_view.Rows(i).Cells(4).Value.ToString}-{datenow}-{timenow}','{dtgv_view.Rows(i).Cells(0).Value.ToString}','{dtgv_view.Rows(i).Cells(1).Value.ToString}','{dtgv_view.Rows(i).Cells(2).Value.ToString}','{dtgv_view.Rows(i).Cells(3).Value.ToString}','{dtgv_view.Rows(i).Cells(4).Value.ToString}','{dtgv_view.Rows(i).Cells(5).Value.ToString}')"

                        timenow = DateAndTime.TimeOfDay.AddSeconds(+1)
                        Main_progressbar.Visible = True
                        lbl_statusprogress.Text = p.ToString & "%"
                        Main_progressbar.Value = (i / y) * Max
                        Threading.Thread.Sleep(100)
                    '--------------------------UPLOAD UOB------------------
                    Case "TMB" : sql &= $"TMBscdb(ACCKEY,ACCTMB,PDF,PRODUCT,BANK,[TYPE],MONTH_LOAD)VALUES('{dtgv_view.Rows(i).Cells(0).Value.ToString}-{dtgv_view.Rows(i).Cells(4).Value.ToString}-{datenow}-{timenow}','{dtgv_view.Rows(i).Cells(0).Value.ToString}','{dtgv_view.Rows(i).Cells(1).Value.ToString}','{dtgv_view.Rows(i).Cells(2).Value.ToString}','{dtgv_view.Rows(i).Cells(3).Value.ToString}','{dtgv_view.Rows(i).Cells(4).Value.ToString}','{dtgv_view.Rows(i).Cells(5).Value.ToString}')"

                        timenow = DateAndTime.TimeOfDay.AddSeconds(+1)
                        Main_progressbar.Visible = True
                        lbl_statusprogress.Text = p.ToString & "%"
                        Main_progressbar.Value = (i / y) * Max
                        Threading.Thread.Sleep(100)
                    '--------------------------UPLOAD TMB------------------
                    Case "TSS" : sql &= $"TSSscdb(ACCKEY,ACCTSS,PDF,PRODUCT,BANK,[TYPE],MONTH_LOAD)VALUES('{dtgv_view.Rows(i).Cells(0).Value.ToString}-{dtgv_view.Rows(i).Cells(4).Value.ToString}-{datenow}-{timenow}','{dtgv_view.Rows(i).Cells(0).Value.ToString}','{dtgv_view.Rows(i).Cells(1).Value.ToString}','{dtgv_view.Rows(i).Cells(2).Value.ToString}','{dtgv_view.Rows(i).Cells(3).Value.ToString}','{dtgv_view.Rows(i).Cells(4).Value.ToString}','{dtgv_view.Rows(i).Cells(5).Value.ToString}')"

                        timenow = DateAndTime.TimeOfDay.AddSeconds(+1)
                        Main_progressbar.Visible = True
                        lbl_statusprogress.Text = p.ToString & "%"
                        Main_progressbar.Value = (i / y) * Max
                        Threading.Thread.Sleep(100)
                    '--------------------------UPLOAD TSS------------------
                    Case "KKB" : sql &= $"KKBscdb(ACCKEY,ACCKKB,PDF,PRODUCT,BANK,[TYPE],MONTH_LOAD)VALUES('{dtgv_view.Rows(i).Cells(0).Value.ToString}-{dtgv_view.Rows(i).Cells(4).Value.ToString}-{datenow}-{timenow}','{dtgv_view.Rows(i).Cells(0).Value.ToString}','{dtgv_view.Rows(i).Cells(1).Value.ToString}','{dtgv_view.Rows(i).Cells(2).Value.ToString}','{dtgv_view.Rows(i).Cells(3).Value.ToString}','{dtgv_view.Rows(i).Cells(4).Value.ToString}','{dtgv_view.Rows(i).Cells(5).Value.ToString}')"

                        timenow = DateAndTime.TimeOfDay.AddSeconds(+1)
                        Main_progressbar.Visible = True
                        lbl_statusprogress.Text = p.ToString & "%"
                        Main_progressbar.Value = (i / y) * Max
                        Threading.Thread.Sleep(100)
                        '--------------------------UPLOAD KKB------------------

                End Select

                cmd = New SqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

            Next

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

    End Sub
    Public Sub Excelimport()
        Dim conn As OleDbConnection
        'Dim dtr As OleDbDataReader
        Dim dta As OleDbDataAdapter
        'Dim cmd As OleDbCommand
        Dim dts As DataSet
        Dim excel As String
        Dim fi As New FileInfo(OpenFileDialog1.FileName)

        excel = fi.FullName
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
        dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn)
        dts = New DataSet
        dta.Fill(dts, "[Sheet1$]")
        dtgv_view.DataSource = dts
        dtgv_view.DataMember = "[Sheet1$]"
        conn.Close()
        lbl_countimport.Text = dtgv_view.Rows.Count & " " & "รายการ"
        For Each col As DataGridViewColumn In dtgv_view.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub Frmimport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
        cn.Close()
    End Sub
End Class
