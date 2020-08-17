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
        lbl_grandtotal.Visible = False
        lbl_countimport.Visible = False

        connect()

        Dim pds() As String = {"KBANK", "FILESCAN KBANK"}
        cbo_products.Items.AddRange(pds)
        cbo_products.SelectedIndex = 0

        Dim _cbotypes() As String = {"เบิกงวด 1", "เบิกงวด 2", "บังคับคดี", "FILE SCAN"}
        cbo_types_Accounting.Items.AddRange(_cbotypes)
        cbo_types_Accounting.SelectedIndex = 0

        dtgv_clear()

        For Each col As DataGridViewColumn In dtgv_view.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        With import_upload
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With
        '//
        Control.CheckForIllegalCrossThreadCalls = False

    End Sub

    Private Sub Cmd_import_Click(sender As Object, e As EventArgs) Handles cmd_import.Click
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

    Sub Dtgv_clear()

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

    Private Sub Cmd_openfile_Click(sender As Object, e As EventArgs) Handles cmd_openfile.Click

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

    Private Sub Cmd_toserver_Click(sender As Object, e As EventArgs) Handles cmd_toserver.Click

        lbl_statusprogress.Visible = True

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

        import_upload.RunWorkerAsync()


    End Sub

    Private Sub Cmd_cut_check_Click(sender As Object, e As EventArgs) Handles cmd_cut_check.Click

        Try

            connect()

            Dim Max As Integer = 100
            Dim i As Integer = dtgv_view.Rows.Count

            Select Case cbo_types_Accounting.SelectedItem

                Case "เบิกงวด 1" : sql = $"SELECT Accounting_PK FROM AccountingKBANK WHERE Accounting_type_legal = 'คำฟ้อง' OR Accounting_type_legal = 'คำฟ้อง(E)' ;"

                Case "เบิกงวด 2" : sql = $"SELECT Accounting_PK FROM AccountingKBANK WHERE Accounting_type_legal = 'พิพากษา' OR Accounting_type_legal ='ตามยอม' OR Accounting_type_legal = 'ตามยอม(พับ)' OR Accounting_type_legal = 'ถอนฟ้อง' OR Accounting_type_legal = 'ถอนฟ้อง(พับ)';"

                Case "บังคับคดี" : sql = $"SELECT Accounting_PK FROM AccountingKBANK WHERE Accounting_type_legal = 'ขอถอนอายัด' OR Accounting_type_legal = 'ถอนอายัด/วางเพิ่ม' OR Accounting_type_legal = 'ยึดทรัพย์' OR Accounting_type_legal = 'วางค่าใช้จ่ายเพิ่ม' OR Accounting_type_legal = 'อายัดเงินเดือน' OR Accounting_type_legal = 'วางค่าใช้จ่ายเพิ่ม/ยึดทรัพย์' OR Accounting_type_legal = 'วางค่าใช้จ่ายเพิ่ม/อายัด' OR Accounting_type_legal = 'ยึดทรัพย์+ส่งให้ศาลอื่นบังคับคดี';"

                Case "FILE SCAN" : sql = $"SELECT Accounting_path FROM ACCOUNTINGscdb;"

            End Select

            cmd = New SqlCommand(sql, cn)
            DR = cmd.ExecuteReader()

            While DR.Read()

                For y = 0 To dtgv_view.RowCount - 1

                    Select Case cbo_types_Accounting.SelectedItem
                        Case "เบิกงวด 1"
                            'Dim _pk As String = $"{dtgv_view.Rows(y).Cells(1).Value.ToString}-{dtgv_view.Rows(y).Cells(8).Value.ToString}-{dtgv_view.Rows(y).Cells(10).Value.ToString}"

                            If DR(0).ToString = $"{dtgv_view.Rows(y).Cells(1).Value}-{dtgv_view.Rows(y).Cells(8).Value}-{dtgv_view.Rows(y).Cells(10).Value}" Then

                                dtgv_view.Rows(y).DefaultCellStyle.BackColor = Color.Red

                            End If

                        Case "FILE SCAN"

                            'Dim _path As String = $"{dtgv_view.Rows(y).Cells(1).Value.ToString}"

                            If DR(0).ToString = $"{dtgv_view.Rows(y).Cells(1).Value}" Then

                                dtgv_view.Rows(y).DefaultCellStyle.BackColor = Color.Red

                            End If

                        Case "เบิกงวด 2"

                            'Dim _pk As String = $"{dtgv_view.Rows(y).Cells(1).Value.ToString}-{dtgv_view.Rows(y).Cells(8).Value.ToString}-{dtgv_view.Rows(y).Cells(10).Value.ToString}"

                            If DR(0).ToString = $"{dtgv_view.Rows(y).Cells(1).Value}-{dtgv_view.Rows(y).Cells(8).Value}-{dtgv_view.Rows(y).Cells(10).Value}" Then

                                dtgv_view.Rows(y).DefaultCellStyle.BackColor = Color.Red

                            End If

                        Case "บังคับคดี"

                            'Dim _pk As String = $"{dtgv_view.Rows(y).Cells(1).Value.ToString}-{dtgv_view.Rows(y).Cells(8).Value.ToString}-{dtgv_view.Rows(y).Cells(10).Value.ToString}"

                            If DR(0).ToString = $"{dtgv_view.Rows(y).Cells(1).Value}-{dtgv_view.Rows(y).Cells(8).Value}-{dtgv_view.Rows(y).Cells(10).Value}" Then

                                dtgv_view.Rows(y).DefaultCellStyle.BackColor = Color.Red

                            End If

                    End Select

                Next

            End While


            DR.Close()

            For u As Integer = dtgv_view.Rows.Count() - 1 To 0 Step -1
                Dim delete As Color
                delete = dtgv_view.Rows(u).DefaultCellStyle.BackColor
                If delete = Color.Red Then
                    Dim row As DataGridViewRow
                    row = dtgv_view.Rows(u)
                    dtgv_view.Rows.Remove(row)
                End If
            Next

        Catch ex As Exception

            lbl_countimport.Text = $"{Str(dtgv_view.RowCount.ToString)} รายการ"

            cn.Close()

        End Try

    End Sub
    Public Sub Loads()
        Dim y As Integer = dtgv_view.Rows.Count
        Dim Max As Integer = 100

        Try
            For i As Integer = 0 To dtgv_view.Rows.Count - 1 Step +1
                Dim p As Integer = ((i / y) * Max)

                connect()

                sql = "INSERT INTO "

                Select Case cbo_products.SelectedItem

                    Case "KBANK" : sql &= $"AccountingKBANK(Accounting_PK,Accounting_Number,Accounting_CUSCUS,Accounting_Name,Accounting_black_red,Accounting_date_legal,Accounting_court,Accounting_capital,Accounting_receipt,Accounting_invoice,Accounting_date_send,Accounting_type_legal,Accounting_type_master)VALUES('{dtgv_view.Rows(i).Cells(1).Value}-{dtgv_view.Rows(i).Cells(8).Value}-{dtgv_view.Rows(i).Cells(10).Value}','{dtgv_view.Rows(i).Cells(0).Value}','{dtgv_view.Rows(i).Cells(1).Value}','{dtgv_view.Rows(i).Cells(2).Value}','{dtgv_view.Rows(i).Cells(3).Value}','{dtgv_view.Rows(i).Cells(4).Value}','{dtgv_view.Rows(i).Cells(5).Value}','{dtgv_view.Rows(i).Cells(6).Value}','{dtgv_view.Rows(i).Cells(7).Value}','{dtgv_view.Rows(i).Cells(8).Value}','{dtgv_view.Rows(i).Cells(9).Value}','{dtgv_view.Rows(i).Cells(10).Value}','{dtgv_view.Rows(i).Cells(11).Value}')"

                    Case "FILESCAN KBANK" : sql &= $"ACCOUNTINGscdb(Accounting_invoice,Accounting_path,Accounting_date,Accounting_owner)VALUES('{dtgv_view.Rows(i).Cells(0).Value}','{dtgv_view.Rows(i).Cells(1).Value}','{dtgv_view.Rows(i).Cells(2).Value}','{dtgv_view.Rows(i).Cells(3).Value}')"

                End Select

                lbl_statusprogress.Text = i.ToString & "/" & dtgv_view.Rows.Count.ToString
                Main_progressbar.Value = (i / y) * Max
                Threading.Thread.Sleep(100)
                lbl_statusprogress.Text = i + 1.ToString & "/" & dtgv_view.Rows.Count.ToString

                '--------------------------UPLOAD KBANK ACCOUNTING------------------

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
        'Dim cmd As OleDbCommand
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

    Private Sub Import_upload_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles import_upload.DoWork
        Loads()
    End Sub

    Private Sub Import_upload_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles import_upload.ProgressChanged

        Main_progressbar.Value = e.ProgressPercentage

    End Sub

    Private Sub Import_upload_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles import_upload.RunWorkerCompleted

        connect()

        sql = " SELECT COUNT(*) AS TYPEs FROM "

        Select Case cbo_products.SelectedItem

            Case "KBANK" : sql &= "AccountingKBANK "
            Case "FILESCAN KBANK" : sql &= "ACCOUNTINGscdb"
        End Select

        Select Case cbo_types_Accounting.SelectedItem
            Case "เบิกงวด 1" : sql &= $"WHERE Accounting_type_legal = 'คำฟ้อง' OR Accounting_type_legal = 'คำฟ้อง(E)' ;"
            Case "เบิกงวด 2" : sql &= $"WHERE Accounting_type_legal = 'พิพากษา' OR Accounting_type_legal ='ตามยอม' OR Accounting_type_legal = 'ตามยอม(พับ)' OR Accounting_type_legal = 'ถอนฟ้อง' OR Accounting_type_legal = 'ถอนฟ้อง(พับ)';"
            Case "บังคับคดี" : sql &= $"WHERE Accounting_type_legal = 'ขอถอนอายัด' OR Accounting_type_legal = 'ถอนอายัด/วางเพิ่ม' OR Accounting_type_legal = 'ยึดทรัพย์' OR Accounting_type_legal = 'วางค่าใช้จ่ายเพิ่ม' OR Accounting_type_legal = 'อายัดเงินเดือน'
                   OR Accounting_type_legal = 'ยึดทรัพย์+ส่งให้ศาลอื่นบังคับคดี';"
            Case "FILE SCAN" : sql &= ";"
        End Select
        cmd.CommandText = sql
        DA.SelectCommand = cmd
        DA.Fill(DS, "CountRows")

        If cbo_types_Accounting.SelectedItem.ToString = "เบิกงวด 1" Then
            MessageBox.Show("โหลดข้อมูลเสร็จสิ้น ข้อมูล เบิกงวด 1 ทั้งหมด" & " " & DS.Tables("CountRows").Rows(0)("TYPEs") & " " & "แภว", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cbo_types_Accounting.SelectedItem.ToString = "เบิกงวด 2" Then
            MessageBox.Show("โหลดข้อมูลเสร็จสิ้น ข้อมูล เบิกงวด 2 ทั้งหมด" & " " & DS.Tables("CountRows").Rows(0)("TYPEs") & " " & "แภว", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cbo_types_Accounting.SelectedItem.ToString = "บังคับคดี" Then
            MessageBox.Show("โหลดข้อมูลเสร็จสิ้น ข้อมูล บังคับคดี ทั้งหมด" & " " & DS.Tables("CountRows").Rows(0)("TYPEs") & " " & "แภว", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cbo_types_Accounting.SelectedItem.ToString = "FILE SCAN" Then
            MessageBox.Show("โหลดข้อมูลเสร็จสิ้น ข้อมูล FILESCAN KBANK ทั้งหมด" & " " & DS.Tables("CountRows").Rows(0)("TYPEs") & " " & "แภว", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        lbl_statusprogress.Text = "0 %"
        Main_progressbar.Value = 0
        lbl_countimport.Text = dtgv_view.Rows.Count & " " & "รายการ"
        Main_progressbar.Visible = False
        lbl_statusprogress.Visible = False

        Getlogdata($"UPLOAD {cbo_products.Text} จำนวน {dtgv_view.Rows.Count}")
        dtgv_view.DataSource = Nothing

    End Sub
End Class