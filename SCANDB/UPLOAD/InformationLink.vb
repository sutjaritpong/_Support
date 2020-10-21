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

Public Class InformationLink
    Private Sub InformationLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_flow.Visible = False
        lbl_countimport.Visible = False
        Dtgv_Exe.Visible = False
        Main_progressbar.Visible = False
        Main_progressbar.Value = 0
        lbl_statusprogress.Visible = False

        Connect()

        Dim type() As String = {"ข้อมูลลูกค้า(Execution-Customer)"}

        cbo_products.Items.AddRange(type)
        cbo_products.SelectedIndex = 0
        Dtgv_clear()

        For Each col As DataGridViewColumn In Dtgv_Exe.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        With BackgroundWorker1
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With
        '//
        Control.CheckForIllegalCrossThreadCalls = False

        cn.Close()

    End Sub

    Sub Dtgv_clear()

        Dtgv_Exe.Columns.Clear()

        If Dtgv_Exe.Columns.Count = 0 Then

            Dtgv_Exe.Columns.Clear()

        End If
        Dtgv_Exe.DataSource = Nothing

    End Sub

    Private Sub cmd_openfile_Click(sender As Object, e As EventArgs) Handles cmd_openfile.Click

        Dim FileName As String = OpenFileDialog1.FileName
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

            Dtgv_Exe.Columns.Clear()
            txt_Importfile.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)

        End If

    End Sub

    Private Sub cmd_import_Click(sender As Object, e As EventArgs) Handles cmd_import.Click

        If lbl_statusprogress.Visible <> False Then
            Msg_error("มีข้อมูลที่กำลังทำงานอยู่ในขณะนี้")
            Return
        End If

        If txt_Importfile.Text = "" Then
            Msg_error("กรุณาเลือกไฟล์ที่ต้องการ UPLOAD")
            Return
        End If
        Dtgv_Exe.Visible = True
        Excelimport()

        lbl_countimport.Visible = True

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
        Dtgv_Exe.DataSource = dts
        Dtgv_Exe.DataMember = "[Sheet1$]"

        Dtgv_Exe.DefaultCellStyle.BackColor = Color.White
        conn.Close()

        lbl_countimport.Text = Dtgv_Exe.Rows.Count & " " & "รายการ"
        lbl_flow.Visible = True
        lbl_flow.Text = "นำเข้าข้อมูล..."

        'For Each col As DataGridViewColumn In Dtgv_Exe.Columns
        '    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'Next

    End Sub

    Private Sub cmd_toserver_Click(sender As Object, e As EventArgs) Handles cmd_toserver.Click


        If Main_progressbar.Visible = False Then

            Main_progressbar.Visible = True
            Main_progressbar.Enabled = True

        End If

        If lbl_statusprogress.Visible = False Then

            lbl_statusprogress.Visible = True
            lbl_statusprogress.Enabled = True

        End If

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        lbl_flow.Visible = True
        Loadsexe()
        lbl_flow.Text = "กำลังโหลดข้อมูลเข้าระบบ...."

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Connect()

        lbl_flow.Visible = True
        lbl_flow.Text = "กำลังประมวลผลข้อมูล"

        For i As Integer = 0 To Dtgv_Exe.Rows.Count - 1

            If chk_senddata.Checked = True Then

                Dim Checkrowcolor As Color
                Checkrowcolor = Dtgv_Exe.Rows(i).DefaultCellStyle.BackColor

                If Checkrowcolor = Color.Red Then
                    Continue For
                End If

            End If

        Next


        sql = " SELECT COUNT(*) As TYPEs FROM "

        Select Case cbo_products.SelectedItem

            Case "ข้อมูลลูกค้า(Execution-Customer)" : sql &= $"Execution_Customer"


        End Select

        cmd.CommandText = sql
        DA.SelectCommand = cmd
        DA.Fill(DS, "CountRows")

        MessageBox.Show("โหลดข้อมูลเสร็จสิ้น ข้อมูลทั้งหมด" & " " & DS.Tables("CountRows").Rows(0)("TYPEs") & " " & "แภว", "Import Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

        lbl_statusprogress.Text = "0/0"

        lbl_flow.Text = "ไม่มีข้อมูลทำงานอยู่"
        Main_progressbar.Value = 0
        lbl_countimport.Text = Dtgv_Exe.Rows.Count & " " & "รายการ"
        lbl_statusprogress.Visible = False
        Main_progressbar.Visible = False

        Getlogdata($"UPLOAD {cbo_products.Text} จำนวน {Dtgv_Exe.Rows.Count}")

        lbl_countimport.Visible = False
        lbl_flow.Visible = False

    End Sub

    Private Sub Loadsexe()

        Connect()
        Dim y As Integer = Dtgv_Exe.Rows.Count
        Dim Max As Integer = 100

        Dim timenow As String = (DateAndTime.TimeString)
        Dim datenow As String = DateAndTime.Today.ToShortDateString

        Try
            For i As Integer = 0 To Dtgv_Exe.Rows.Count - 1 Step +1

                Dim p As Integer = (((i + 1) / y) * Max)

                sql = $"SELECT "

                Select Case cbo_products.SelectedItem

                    Case "ข้อมูลลูกค้า(Execution-Customer)" : sql &= $"COUNT(Customer_Account) As verify FROM Execution_Customer WHERE Customer_Account = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                End Select

                If Cmd_excuteScalar() > 0 Then

                    Dtgv_Exe.Rows(i).DefaultCellStyle.BackColor = Color.Red

                    If chk_senddata.Checked = True Then

                        Continue For

                    End If

                End If

                sql = $"INSERT INTO "

                Select Case cbo_products.SelectedItem

                    Case "ข้อมูลลูกค้า(Execution-Customer)" : sql &= $"Execution_Customer(Customer_Owner,Customer_Bank,Customer_Hub,Customer_Account,Customer_No,Customer_Idc,Customer_Prefix,Customer_Firstname,Customer_Lastname,Customer_Fullname,Customer_Court,Customer_Black,Customer_Red,Customer_Date_Add,Customer_Billcode,Customer_Type,Customer_Productcode,Customer_Block)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}','{Dtgv_Exe.Rows(i).Cells(8).Value}','{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value}','{Dtgv_Exe.Rows(i).Cells(13).Value}','{Dtgv_Exe.Rows(i).Cells(14).Value}','{Dtgv_Exe.Rows(i).Cells(15).Value}','{Dtgv_Exe.Rows(i).Cells(16).Value}','{Dtgv_Exe.Rows(i).Cells(17).Value}')"

                        '--------------------------- UPLOAD ข้อมูลลูกค้า --------------------------'


                End Select

                cmd = New SqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

                lbl_statusprogress.Text = i.ToString & "/" & Dtgv_Exe.Rows.Count.ToString
                Main_progressbar.Value = (i / y) * Max
                Threading.Thread.Sleep(100)
                lbl_statusprogress.Text = i + 1.ToString & "/" & Dtgv_Exe.Rows.Count.ToString

            Next

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

        cn.Close()

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

        Main_progressbar.Value = e.ProgressPercentage

    End Sub

    Private Sub InformationLink_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


        cn.Close()
        Me.Dispose()


    End Sub

    Private Sub Cmd_Delete_Click(sender As Object, e As EventArgs) Handles Cmd_Delete.Click


        Connect()

        Dim y As Integer = Dtgv_Exe.Rows.Count


        Dim timenow As String = (DateAndTime.TimeString)
        Dim datenow As String = DateAndTime.Today.ToShortDateString

        lbl_flow.Visible = True
        lbl_flow.ForeColor = Color.Red

        Try

            For i As Integer = 0 To y - 1 Step +1
                'Dim p As Integer = (((i + 1) / y) * Max)

                lbl_flow.Text = "กำลังเช็คข้อมูลซ้ำ"

                sql = $"SELECT "

                Select Case cbo_products.SelectedItem

                    Case "ข้อมูลลูกค้า(Execution-Customer)" : sql &= $"COUNT(*) As verify FROM Execution_Customer WHERE Customer_Account = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"


                End Select

                If Cmd_excuteScalar() > 0 Then

                    Dtgv_Exe.Rows(i).DefaultCellStyle.BackColor = Color.Red

                End If

            Next

            For u As Integer = y - 1 To 0 Step -1

                Dim delete As Color

                delete = Dtgv_Exe.Rows(u).DefaultCellStyle.BackColor

                If delete = Color.Red Then

                    Dim row As DataGridViewRow
                    row = Dtgv_Exe.Rows(u)
                    Dtgv_Exe.Rows.Remove(row)
                    lbl_flow.Text = "กำลังลบข้อมูลออก"

                End If

            Next

            lbl_flow.Text = "ลบข้อมูลเสร็จสิ้น"
            lbl_countimport.Text = Dtgv_Exe.Rows.Count & " " & "รายการ"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Cmd_Link_Click(sender As Object, e As EventArgs) Handles Cmd_Link.Click

        Connect()
        For i = 0 To Dtgv_Exe.Rows.Count - 1

            Select Case Dtgv_Exe.Rows(i).Cells(0).Value.ToString

                Case "TSS" : Connect_(cn_GE)

                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSTYP,RFCUS.CUSLNO,RFCUS.CUSPRO,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    cmd_Collec = New SqlCommand(sqll, cn_GE)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Dtgv_Exe.Rows(i).Cells(9).Value = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                        Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Dtgv_Exe.Rows(i).Cells(14).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                        Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString


                        Select Case Dtgv_Exe.Rows(i).Cells(15).Value
                            Case "CPL", "GPC", "TCP", "FC", "NFC", "TIN", "TIP", "PB", "HFC", "MHF" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท อยุธยา แคปปิตอล เซอร์วิสเซส จำกัด"
                            Case "CCC", "CCM", "RBV", "HPR", "CCP" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท เจเนอรัล คาร์ด เซอร์วิสเซส จำกัด"
                            Case "TES", "LTS", "TPL" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท เทสโก้ คาร์ด เซอร์วิสเซส จำกัด"
                            Case "KCC", "KSM", "HPK", "HPR", "KHB", "KPL", "AYCC", "AYJC", "AYPL", "KJC", "HME", "TKCC", "TKJC" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท บัตรกรุงศรีอยุธยา จำกัด"
                        End Select


                    Else

                        sqll = $"Select RFCUS.CUSIDC,RFCUS.CUSTYP,RFCUS.CUSLNO,RFCUS.CUSPRO,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN FROM RFCUS LEFT JOIN RFLAW On RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_GE)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                            Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                            Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                            Dtgv_Exe.Rows(i).Cells(9).Value = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                            Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                            Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                            Dtgv_Exe.Rows(i).Cells(14).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                            Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                            Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                            Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString


                            Select Case Dtgv_Exe.Rows(i).Cells(15).Value
                                Case "CPL", "GPC", "TCP", "FC", "NFC", "TIN", "TIP", "PB", "HFC", "MHF" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท อยุธยา แคปปิตอล เซอร์วิสเซส จำกัด"
                                Case "CCC", "CCM", "RBV", "HPR", "CCP" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท เจเนอรัล คาร์ด เซอร์วิสเซส จำกัด"
                                Case "TES", "LTS", "TPL" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท เทสโก้ คาร์ด เซอร์วิสเซส จำกัด"
                                Case "KCC", "KSM", "HPK", "HPR", "KHB", "KPL", "AYCC", "AYJC", "AYPL", "KJC", "HME", "TKCC", "TKJC" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท บัตรกรุงศรีอยุธยา จำกัด"
                            End Select

                        End If

                    End If

                Case "KBANK" : Connect_(cn_KBANK)
                    sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"
                    cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Dtgv_Exe.Rows(i).Cells(4).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                        Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Dtgv_Exe.Rows(i).Cells(9).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Else
                        sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                            Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                            Dtgv_Exe.Rows(i).Cells(4).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                            Dtgv_Exe.Rows(i).Cells(9).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                            Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                            Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                            Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                        End If

                    End If

                    cn_KBANK.Close()

                Case "KKB" : Connect_(cn_KKB)
                    sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"
                    cmd_Collec = New SqlCommand(sqll, cn_KKB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Dtgv_Exe.Rows(i).Cells(9).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Dtgv_Exe.Rows(i).Cells(14).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                        Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString


                    Else
                        sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_KKB)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                            Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                            Dtgv_Exe.Rows(i).Cells(9).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                            Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                            Dtgv_Exe.Rows(i).Cells(14).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                            Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                            Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                            Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                        End If
                    End If

                    cn_KKB.Close()

                Case "SCB" : Connect_(cn_SCB)
                    sqll = $"SELECT RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"
                    cmd_Collec = New SqlCommand(sqll, cn_SCB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then


                        Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Dtgv_Exe.Rows(i).Cells(9).Value = $"{Dtgv_Exe.Rows(i).Cells(7).Value} {Dtgv_Exe.Rows(i).Cells(8).Value}"
                        Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Else

                        sqll = $"SELECT RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"
                        cmd_Collec = New SqlCommand(sqll, cn_SCB)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                            Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                            Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                            Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                            Dtgv_Exe.Rows(i).Cells(9).Value = $"{Dtgv_Exe.Rows(i).Cells(7).Value} {Dtgv_Exe.Rows(i).Cells(8).Value}"
                            Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                            Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                            Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                            Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString


                        End If
                    End If

                    cn_SCB.Close()

                Case "TMB" : Connect_(cn_TMB)
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then


                        Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Dtgv_Exe.Rows(i).Cells(9).Value = $"{Dtgv_Exe.Rows(i).Cells(7).Value} {Dtgv_Exe.Rows(i).Cells(8).Value}"
                        Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Dtgv_Exe.Rows(i).Cells(14).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                        Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString


                    Else
                        sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_TMB)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                            Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                            Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                            Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                            Dtgv_Exe.Rows(i).Cells(9).Value = $"{Dtgv_Exe.Rows(i).Cells(7).Value} {Dtgv_Exe.Rows(i).Cells(8).Value}"
                            Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                            Dtgv_Exe.Rows(i).Cells(14).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                            Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                            Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                            Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString


                        End If
                        cn_TMB.Close()

                    End If

                Case "TMB SME" : Connect_(cn_TMBSME)
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                            Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                            Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                            Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                            Dtgv_Exe.Rows(i).Cells(9).Value = $"{Dtgv_Exe.Rows(i).Cells(7).Value} {Dtgv_Exe.Rows(i).Cells(8).Value}"
                            Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Dtgv_Exe.Rows(i).Cells(14).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                        Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Else
                        sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                            DA_Collec = New SqlDataAdapter(cmd_Collec)
                            DS_Collec = New DataSet
                            DA_Collec.Fill(DS_Collec, "LINKdB")


                            If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                                Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                                Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                                Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                                Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                                Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                                Dtgv_Exe.Rows(i).Cells(9).Value = $"{Dtgv_Exe.Rows(i).Cells(7).Value} {Dtgv_Exe.Rows(i).Cells(8).Value}"
                                Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                                Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                            Dtgv_Exe.Rows(i).Cells(14).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                            Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                            Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                            Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                        End If

                        End If

                        cn_TMBSME.Close()

                        Case "TBANK" : Connect_(cn_TBANK)

                    sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                            Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                            Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                            Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                            Dtgv_Exe.Rows(i).Cells(9).Value = $"{Dtgv_Exe.Rows(i).Cells(7).Value} {Dtgv_Exe.Rows(i).Cells(8).Value}"
                            Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Else
                        sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                            DA_Collec = New SqlDataAdapter(cmd_Collec)
                            DS_Collec = New DataSet
                            DA_Collec.Fill(DS_Collec, "LINKdB")

                            If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                                Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                                Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                                Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                                Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                                Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                                Dtgv_Exe.Rows(i).Cells(9).Value = $"{Dtgv_Exe.Rows(i).Cells(7).Value} {Dtgv_Exe.Rows(i).Cells(8).Value}"
                                Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                            Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                            Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                            Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString


                        End If
                        End If
                        cn_TBANK.Close()

                        Case "UOB" : Connect_(cn_UOB)

                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    cmd_Collec = New SqlCommand(sqll, cn_UOB)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                            Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                            Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                            Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                            Dtgv_Exe.Rows(i).Cells(9).Value = $"{Dtgv_Exe.Rows(i).Cells(7).Value} {Dtgv_Exe.Rows(i).Cells(8).Value}"
                            Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString



                    Else

                        sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_UOB)
                            DA_Collec = New SqlDataAdapter(cmd_Collec)
                            DS_Collec = New DataSet
                            DA_Collec.Fill(DS_Collec, "LINKdB")

                            If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                                Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                                Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                                Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                                Dtgv_Exe.Rows(i).Cells(7).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                                Dtgv_Exe.Rows(i).Cells(8).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                                Dtgv_Exe.Rows(i).Cells(9).Value = $"{Dtgv_Exe.Rows(i).Cells(7).Value} {Dtgv_Exe.Rows(i).Cells(8).Value}"
                                Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                            Dtgv_Exe.Rows(i).Cells(15).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                            Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                            Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString


                        End If

                        End If

                        cn_UOB.Close()

                        Case Else : Connect_(cnLegal)

                        sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"
                        cmdlegal = New SqlCommand(sqll, cnLegal)
                        DALegal = New SqlDataAdapter(cmdlegal)
                        DSLegal = New DataSet
                        DALegal.Fill(DSLegal, "linklegal")

                        If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(7).Value = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                            Dtgv_Exe.Rows(i).Cells(8).Value = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                            Dtgv_Exe.Rows(i).Cells(9).Value = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                            Dtgv_Exe.Rows(i).Cells(4).Value = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                            Dtgv_Exe.Rows(i).Cells(10).Value = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                            Dtgv_Exe.Rows(i).Cells(11).Value = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(3).Value = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                        Dtgv_Exe.Rows(i).Cells(14).Value = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                        Dtgv_Exe.Rows(i).Cells(15).Value = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                        Dtgv_Exe.Rows(i).Cells(16).Value = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString


                    Else

                            sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"
                            cmdlegal = New SqlCommand(sqll, cnLegal)
                            DALegal = New SqlDataAdapter(cmdlegal)
                            DSLegal = New DataSet
                            DALegal.Fill(DSLegal, "linklegal")

                            If DSLegal.Tables("linklegal").Rows.Count > 0 Then


                                Dtgv_Exe.Rows(i).Cells(7).Value = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                                Dtgv_Exe.Rows(i).Cells(8).Value = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                                Dtgv_Exe.Rows(i).Cells(9).Value = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                            Dtgv_Exe.Rows(i).Cells(10).Value = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                            Dtgv_Exe.Rows(i).Cells(11).Value = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(3).Value = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                            Dtgv_Exe.Rows(i).Cells(4).Value = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                            Dtgv_Exe.Rows(i).Cells(14).Value = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                            Dtgv_Exe.Rows(i).Cells(15).Value = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                            Dtgv_Exe.Rows(i).Cells(16).Value = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                        End If

                    End If

                    cnLegal.Close()

            End Select

            'Case Else : Connect_legal()
            '    sqll = $"Select dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSOWN = '{Dtgv_Exe.Rows}' AND dbCUS.CUSIDC = '{txt_cusid.Text}'"
            '    cmdlegal = New SqlCommand(sqll, cnLegal)
            '    DALegal = New SqlDataAdapter(cmdlegal)
            '    DSLegal = New DataSet
            '    DALegal.Fill(DSLegal, "linklegal")

            '    If DSLegal.Tables("linklegal").Rows.Count <= 0 Then
            '        Lbl_linklegal.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
            '        Lbl_linklegal.ForeColor = Color.Red
            '    Else
            '        txt_cusname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
            '        txt_red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
            '        txt_black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
            '        Txt_account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
            '        Txt_bank.Text = DSLegal.Tables("linklegal").Rows(0)("CUSTOWN").ToString
            '        Txt_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
            '        Txt_type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
            '        Txt_productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

            '        Lbl_linklegal.Text = $"พบ LIDC{DSLegal.Tables("Linklegal").Rows.Count} รายการ"
            '        Lbl_linklegal.ForeColor = Color.Green
            '    End If
            '    cnLegal.Close()


        Next





    End Sub


End Class