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
        Dim ResultUpdate As Integer = 0
        Dim ResultInsert As Integer = 0


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


                Select Case cbo_products.SelectedItem

                    Case "ข้อมูลลูกค้า(Execution-Customer)" : sql = $"SELECT COUNT(Customer_Account) FROM Execution_Customer WHERE Customer_Account = '{Dtgv_Exe.Rows(i).Cells(3).Value}' "

                        cmd = New SqlCommand(sql, cn)
                        Dim VerifyQueryAcc As Integer = cmd.ExecuteScalar()

                        If VerifyQueryAcc > 0 Then

                            sql = $"UPDATE Execution_Customer SET Customer_Owner ='{Dtgv_Exe.Rows(i).Cells(0).Value}' ,Customer_Bank = '{Dtgv_Exe.Rows(i).Cells(1).Value}',Customer_Hub = '{Dtgv_Exe.Rows(i).Cells(2).Value}' ,Customer_Account = '{Dtgv_Exe.Rows(i).Cells(3).Value}',Customer_No = '{Dtgv_Exe.Rows(i).Cells(4).Value}',Customer_Idc = '{Dtgv_Exe.Rows(i).Cells(5).Value}',Customer_Prefix = '{Dtgv_Exe.Rows(i).Cells(6).Value}',Customer_Firstname = '{Dtgv_Exe.Rows(i).Cells(7).Value}',Customer_Lastname = '{Dtgv_Exe.Rows(i).Cells(8).Value}',Customer_Fullname ='{Dtgv_Exe.Rows(i).Cells(9).Value}',Customer_Court ='{Dtgv_Exe.Rows(i).Cells(10).Value}',Customer_Black = '{Dtgv_Exe.Rows(i).Cells(11).Value}',Customer_Red = '{Dtgv_Exe.Rows(i).Cells(12).Value}',Customer_Date_Add = '{Dtgv_Exe.Rows(i).Cells(13).Value}',Customer_Billcode = '{Dtgv_Exe.Rows(i).Cells(14).Value}',Customer_Type = '{Dtgv_Exe.Rows(i).Cells(15).Value}',Customer_Productcode = '{Dtgv_Exe.Rows(i).Cells(16).Value}',Customer_Block = '{Dtgv_Exe.Rows(i).Cells(17).Value}',Collector_User = '{Dtgv_Exe.Rows(i).Cells(18).Value}' WHERE Customer_Owner = '{Dtgv_Exe.Rows(i).Cells(0).Value}' AND Customer_Account = '{Dtgv_Exe.Rows(i).Cells(18).Value}'"

                            cmd = New SqlCommand(sql, cn)
                            Dim VerifyUpdate As Integer = cmd.ExecuteScalar()

                            If VerifyUpdate = 1 Then

                                ResultUpdate += 1

                            End If

                        ElseIf VerifyQueryAcc = 0 Then

                            sql = $"SELECT COUNT(Customer_idc) FROM Execution_Customer WHERE Customer_idc = '{Dtgv_Exe.Rows(i).Cells(5).Value}' "

                            cmd = New SqlCommand(sql, cn)
                            Dim VerifyQueryIdc As Integer = cmd.ExecuteScalar()

                            If VerifyQueryIdc > 0 Then

                                sql = $"UPDATE Execution_Customer SET Customer_Owner ='{Dtgv_Exe.Rows(i).Cells(0).Value}' ,Customer_Bank = '{Dtgv_Exe.Rows(i).Cells(1).Value}',Customer_Hub = '{Dtgv_Exe.Rows(i).Cells(2).Value}',Customer_Account = '{Dtgv_Exe.Rows(i).Cells(3).Value}',Customer_No = '{Dtgv_Exe.Rows(i).Cells(4).Value}',Customer_Idc = '{Dtgv_Exe.Rows(i).Cells(5).Value}',Customer_Prefix = '{Dtgv_Exe.Rows(i).Cells(6).Value}',Customer_Firstname = '{Dtgv_Exe.Rows(i).Cells(7).Value}',Customer_Lastname = '{Dtgv_Exe.Rows(i).Cells(8).Value}',Customer_Fullname ='{Dtgv_Exe.Rows(i).Cells(9).Value}',Customer_Court = '{Dtgv_Exe.Rows(i).Cells(10).Value}',Customer_Black = '{Dtgv_Exe.Rows(i).Cells(11).Value}',Customer_Red = '{Dtgv_Exe.Rows(i).Cells(12).Value}',Customer_Date_Add = '{Dtgv_Exe.Rows(i).Cells(13).Value}',Customer_Billcode = '{Dtgv_Exe.Rows(i).Cells(14).Value}',Customer_Type = '{Dtgv_Exe.Rows(i).Cells(15).Value}',Customer_Productcode = '{Dtgv_Exe.Rows(i).Cells(16).Value}',Customer_Block = '{Dtgv_Exe.Rows(i).Cells(17).Value}',Collector_User = '{Dtgv_Exe.Rows(i).Cells(18).Value}' WHERE Customer_Owner = '{Dtgv_Exe.Rows(i).Cells(0).Value}' AND Customer_idc = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                                cmd = New SqlCommand(sql, cn)
                                Dim VerifyUpdate As Integer = cmd.ExecuteScalar()

                                If VerifyUpdate = 1 Then

                                    ResultUpdate += 1
                                End If



                            ElseIf VerifyQueryIdc = 0 Then

                                sqll = $"INSERT INTO Execution_Customer(Customer_Owner,Customer_Bank,Customer_Hub,Customer_Account,Customer_No,Customer_Idc,Customer_Prefix,Customer_Firstname,Customer_Lastname,Customer_Fullname,Customer_Court,Customer_Black,Customer_Red,Customer_Date_Add,Customer_Billcode,Customer_Type,Customer_Productcode,Customer_Block,Collector_User)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}','{Dtgv_Exe.Rows(i).Cells(8).Value}','{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value}','{Dtgv_Exe.Rows(i).Cells(13).Value}','{Dtgv_Exe.Rows(i).Cells(14).Value}','{Dtgv_Exe.Rows(i).Cells(15).Value}','{Dtgv_Exe.Rows(i).Cells(16).Value}','{Dtgv_Exe.Rows(i).Cells(17).Value}','{Dtgv_Exe.Rows(i).Cells(18).Value}')"


                                cmd = New SqlCommand(sqll, cn)
                                Dim VerifyInsert As Integer = cmd.ExecuteNonQuery()

                                If VerifyInsert = 0 Then

                                    ResultInsert += 1

                                End If

                            End If

                        End If
                        '--------------------------- UPLOAD ข้อมูลลูกค้า --------------------------'

                End Select

                lbl_statusprogress.Text = i.ToString & "/" & Dtgv_Exe.Rows.Count.ToString
                Main_progressbar.Value = (i / y) * Max
                Threading.Thread.Sleep(100)
                lbl_statusprogress.Text = i + 1.ToString & "/" & Dtgv_Exe.Rows.Count.ToString


            Next

        Catch ex As Exception

            MsgBox(ex.ToString)

        Finally

            Msg_OK($"ข้อมูลที่ทำการ แก้ไข {ResultUpdate} รายการ และ ข้อมูลใหม่ที่เพิ่มเข้ามา {ResultInsert} ")

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

        lbl_flow.Text = "กำลังเช็คข้อมูลซ้ำ"
        Connect()

        Dim y As Integer = Dtgv_Exe.Rows.Count


        Dim timenow As String = (DateAndTime.TimeString)
        Dim datenow As String = DateAndTime.Today.ToShortDateString

        lbl_flow.Visible = True
        lbl_flow.ForeColor = Color.Red

        Try

            For A As Integer = 0 To Dtgv_Exe.Rows.Count - 1
                For B As Integer = A + 1 To Dtgv_Exe.Rows.Count - 2

                    If Dtgv_Exe.Rows(A).Cells(3).Value.ToString = "" Then

                        Continue For


                    ElseIf Dtgv_Exe.Rows(A).Cells(3).Value.ToString = Dtgv_Exe.Rows(B).Cells(3).Value.ToString Then

                        Dtgv_Exe.Rows.RemoveAt(B)
                        A -= 1

                    End If

                Next

            Next


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

        Catch ex As Exception

        Finally
            lbl_flow.Text = "ลบข้อมูลเสร็จสิ้น"
            lbl_countimport.Text = Dtgv_Exe.Rows.Count & " " & "รายการ"
        End Try

    End Sub

    Private Sub Cmd_Link_Click(sender As Object, e As EventArgs) Handles Cmd_Link.Click

        Connect()
        For i = 0 To Dtgv_Exe.Rows.Count - 1

            Select Case Dtgv_Exe.Rows(i).Cells(0).Value.ToString

                Case "TSS" : Connect_(cn_GE)

                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSTYP,RFCUS.CUSLNO,RFCUS.CUSPRO,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    cmd_Collec = New SqlCommand(sqll, cn_GE)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                        Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                        Select Case Dtgv_Exe.Rows(i).Cells(16).Value
                            Case "CPL", "GPC", "TCP", "FC", "NFC", "TIN", "TIP", "PB", "HFC", "MHF" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท อยุธยา แคปปิตอล เซอร์วิสเซส จำกัด"
                            Case "CCC", "CCM", "RBV", "HPR", "CCP" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท เจเนอรัล คาร์ด เซอร์วิสเซส จำกัด"
                            Case "TES", "LTS", "TPL" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท เทสโก้ คาร์ด เซอร์วิสเซส จำกัด"
                            Case "KCC", "KSM", "HPK", "HPR", "KHB", "KPL", "AYCC", "AYJC", "AYPL", "KJC", "HME", "TKCC", "TKJC" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท บัตรกรุงศรีอยุธยา จำกัด"
                        End Select


                    Else

                        sqll = $"Select RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSTYP,RFCUS.CUSLNO,RFCUS.CUSPRO,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW On RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_GE)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                            Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString


                            Select Case Dtgv_Exe.Rows(i).Cells(16).Value
                                Case "CPL", "GPC", "TCP", "FC", "NFC", "TIN", "TIP", "PB", "HFC", "MHF" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท อยุธยา แคปปิตอล เซอร์วิสเซส จำกัด"
                                Case "CCC", "CCM", "RBV", "HPR", "CCP" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท เจเนอรัล คาร์ด เซอร์วิสเซส จำกัด"
                                Case "TES", "LTS", "TPL" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท เทสโก้ คาร์ด เซอร์วิสเซส จำกัด"
                                Case "KCC", "KSM", "HPK", "HPR", "KHB", "KPL", "AYCC", "AYJC", "AYPL", "KJC", "HME", "TKCC", "TKJC" : Dtgv_Exe.Rows(i).Cells(1).Value = "บริษัท บัตรกรุงศรีอยุธยา จำกัด"
                            End Select

                        Else


                            Connect_(cnLegal)

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

                        End If

                    End If

                Case "KBANK" : Connect_(cn_KBANK)


                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"
                    cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                        Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Dtgv_Exe.Rows(i).Cells(4).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                        Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Dtgv_Exe.Rows(i).Cells(9).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                        Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                    Else
                        sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                            Dtgv_Exe.Rows(i).Cells(3).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                            Dtgv_Exe.Rows(i).Cells(10).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                            Dtgv_Exe.Rows(i).Cells(4).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                            Dtgv_Exe.Rows(i).Cells(5).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                            Dtgv_Exe.Rows(i).Cells(9).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                            Dtgv_Exe.Rows(i).Cells(11).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(12).Value = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                            Dtgv_Exe.Rows(i).Cells(16).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                            Dtgv_Exe.Rows(i).Cells(17).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                            Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                        Else


                            Connect_(cnLegal)

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

                        End If

                    End If

                    cn_KBANK.Close()

                Case "KKB" : Connect_(cn_KKB)
                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"
                    cmd_Collec = New SqlCommand(sqll, cn_KKB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                        Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString

                    Else
                        sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_KKB)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                            Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString

                        Else


                            Connect_(cnLegal)

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

                        End If
                    End If

                    cn_KKB.Close()

                Case "SCB" : Connect_(cn_SCB)
                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"
                    cmd_Collec = New SqlCommand(sqll, cn_SCB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                        Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                    Else

                        sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"
                        cmd_Collec = New SqlCommand(sqll, cn_SCB)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                            Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                        Else


                            Connect_(cnLegal)

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


                        End If
                    End If

                    cn_SCB.Close()

                Case "TMB" : Connect_(cn_TMB)
                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                        Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                    Else
                        sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_TMB)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                            Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                        Else


                            Connect_(cnLegal)

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

                        End If
                        cn_TMB.Close()

                    End If

                Case "TMB SME" : Connect_(cn_TMBSME)
                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                        Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                    Else
                        sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                            DA_Collec = New SqlDataAdapter(cmd_Collec)
                            DS_Collec = New DataSet
                            DA_Collec.Fill(DS_Collec, "LINKdB")


                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                            Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString


                        End If

                    End If

                        cn_TMBSME.Close()

                        Case "TBANK" : Connect_(cn_TBANK)

                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                        Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                    Else
                        sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                            DA_Collec = New SqlDataAdapter(cmd_Collec)
                            DS_Collec = New DataSet
                            DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                            Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                            Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                        Else


                            Connect_(cnLegal)

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

                        End If

                    End If
                        cn_TBANK.Close()

                        Case "UOB" : Connect_(cn_UOB)

                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    cmd_Collec = New SqlCommand(sqll, cn_UOB)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then
                        Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                        Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                    Else


                        sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                        cmd_Collec = New SqlCommand(sqll, cn_UOB)
                        DA_Collec = New SqlDataAdapter(cmd_Collec)
                        DS_Collec = New DataSet
                        DA_Collec.Fill(DS_Collec, "LINKdB")

                        If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then
                            Dtgv_Exe.Rows(i).Cells(2).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
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
                            Dtgv_Exe.Rows(i).Cells(18).Value = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                        Else

                            Connect_(cnLegal)

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

                                cnLegal.Close()


                            End If

                        End If
                    End If
                    cn_UOB.Close()


            End Select

        Next


    End Sub

    'Private Sub LegaldBLink()

    '    Connect_(cnLegal)

    '    sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{Dtgv_Exe.Rows(i).Cells(5).Value}'"
    '    cmdlegal = New SqlCommand(sqll, cnLegal)
    '    DALegal = New SqlDataAdapter(cmdlegal)
    '    DSLegal = New DataSet
    '    DALegal.Fill(DSLegal, "linklegal")

    '    If DSLegal.Tables("linklegal").Rows.Count > 0 Then

    '        Dtgv_Exe.Rows(i).Cells(7).Value = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
    '        Dtgv_Exe.Rows(i).Cells(8).Value = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
    '        Dtgv_Exe.Rows(i).Cells(9).Value = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
    '        Dtgv_Exe.Rows(i).Cells(4).Value = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
    '        Dtgv_Exe.Rows(i).Cells(12).Value = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
    '        Dtgv_Exe.Rows(i).Cells(10).Value = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
    '        Dtgv_Exe.Rows(i).Cells(11).Value = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
    '        Dtgv_Exe.Rows(i).Cells(3).Value = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
    '        Dtgv_Exe.Rows(i).Cells(5).Value = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
    '        Dtgv_Exe.Rows(i).Cells(14).Value = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
    '        Dtgv_Exe.Rows(i).Cells(15).Value = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
    '        Dtgv_Exe.Rows(i).Cells(16).Value = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString


    '    Else

    '        sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"
    '        cmdlegal = New SqlCommand(sqll, cnLegal)
    '        DALegal = New SqlDataAdapter(cmdlegal)
    '        DSLegal = New DataSet
    '        DALegal.Fill(DSLegal, "linklegal")

    '        If DSLegal.Tables("linklegal").Rows.Count > 0 Then


    '            Dtgv_Exe.Rows(i).Cells(7).Value = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
    '            Dtgv_Exe.Rows(i).Cells(8).Value = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
    '            Dtgv_Exe.Rows(i).Cells(9).Value = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
    '            Dtgv_Exe.Rows(i).Cells(12).Value = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
    '            Dtgv_Exe.Rows(i).Cells(10).Value = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
    '            Dtgv_Exe.Rows(i).Cells(11).Value = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
    '            Dtgv_Exe.Rows(i).Cells(3).Value = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
    '            Dtgv_Exe.Rows(i).Cells(4).Value = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
    '            Dtgv_Exe.Rows(i).Cells(5).Value = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
    '            Dtgv_Exe.Rows(i).Cells(14).Value = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
    '            Dtgv_Exe.Rows(i).Cells(15).Value = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
    '            Dtgv_Exe.Rows(i).Cells(16).Value = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

    '        End If
    '    End If
    '    cnLegal.Close()
    'End Sub

End Class