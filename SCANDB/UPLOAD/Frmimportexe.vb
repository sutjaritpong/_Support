﻿Option Explicit On
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

Public Class Frmimportexe

    Private Sub Frmimportexe_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dtgv_Exe.Visible = False
        Main_progressbar.Visible = False
        Main_progressbar.Value = 0
        lbl_statusprogress.Visible = False
        connect()
        Dim type() As String = {"ใบงานแถลงบัญชี", "บังคับคดีตั้งเรื่อง", "ผลคัดประกันสังคม", "ตรวจสำนวนตามใบงาน", "ถอนอายัด/ยึด", "ตรวจสำนวนจากบังคับดคี", "ส่งเช็คถอนอายัด/ยึด", "ส่งคัดประกันสังคมฟ้องเอง", "ผลสืบกรรมสิทธิ์/ที่ดิน", "ส่งสืบกรรมสิทธิ์ฟ้องเอง"}
        cbo_products.Items.AddRange(type)
        cbo_products.SelectedIndex = 0
        dtgv_clear()
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
    Sub dtgv_clear()
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

        loadsexe()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        connect()

        sql = " SELECT COUNT(*) AS TYPEs FROM "

        Select Case cbo_products.SelectedItem
            Case "ใบงานแถลงบัญชี" : sql &= $"EXESM"
            Case "บังคับคดีตั้งเรื่อง" : sql &= $"EXEACC"
            Case "ผลคัดประกันสังคม" : sql &= $"EXESOC"
            Case "ตรวจสำนวนตามใบงาน" : sql &= $"EXETRACKING"
            Case "ถอนอายัด/ยึด" : sql &= $"EXEWDS"
            Case "ตรวจสำนวนจากบังคับดคี" : sql &= $"Execution_verify"
            Case "ส่งเช็คถอนอายัด/ยึด" : sql &= $"EXECHECK"
            Case "ส่งคัดประกันสังคมฟ้องเอง" : sql &= $"Execution_Port"
            Case "ส่งสืบกรรมสิทธิ์ฟ้องเอง" : sql &= $"Execution_ownership"
            Case "ผลสืบกรรมสิทธิ์/ที่ดิน" : sql &= $"Execution_ownership_result"
        End Select

        cmd.CommandText = sql
        DA.SelectCommand = cmd
        DA.Fill(DS, "CountRows")

        MessageBox.Show("โหลดข้อมูลเสร็จสิ้น ข้อมูลทั้งหมด" & " " & DS.Tables("CountRows").Rows(0)("TYPEs") & " " & "แภว", "Import Status", MessageBoxButtons.OK, MessageBoxIcon.Information)

        lbl_statusprogress.Text = "0/0"

        Main_progressbar.Value = 0
        lbl_countimport.Text = Dtgv_Exe.Rows.Count & " " & "รายการ"
        lbl_statusprogress.Visible = False
        Main_progressbar.Visible = False

        _Getlogdata($"UPLOAD {cbo_products.Text} จำนวน {Dtgv_Exe.Rows.Count}")
    End Sub
    Friend Sub loadsexe()

        connect()
        Dim y As Integer = Dtgv_Exe.Rows.Count
        Dim Max As Integer = 100

        Dim timenow As String = (DateAndTime.TimeString)
        Dim datenow As String = DateAndTime.Today.ToShortDateString
        Try
            For i As Integer = 0 To Dtgv_Exe.Rows.Count - 1 Step +1
                Dim p As Integer = (((i + 1) / y) * Max)

                sql = $"SELECT "

                Select Case cbo_products.SelectedItem

                    Case "ใบงานแถลงบัญชี" : sql &= $"COUNT(*) As verify FROM EXESM WHERE EXEKEY = '{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(15).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(20).Value.ToString}'"
                    Case "บังคับคดีตั้งเรื่อง" : sql &= $"COUNT(*) AS verify FROM EXEACC WHERE ACCKEY = '{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(6).Value.ToString}'"
                    Case "ส่งเช็คถอนอายัด/ยึด" : sql &= $"COUNT(*) AS verify FROM EXECHECK WHERE CHKKEY = '{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(7).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(11).Value.ToString}'"
                    Case "ส่งคัดประกันสังคมฟ้องเอง" : sql &= $"COUNT(*) AS verify FROM Execution_Port WHERE Serial_Account = '{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}'"
                    Case "ตรวจสำนวนตามใบงาน" : sql &= $"COUNT(*) AS verify FROM EXETRACKING WHERE Tracking_pk = '{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}'"
                    Case "ตรวจสำนวนจากบังคับดคี" : sql &= $"COUNT(*) AS verify FROM dbo.Execution_verify WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}'"
                    Case "ผลคัดประกันสังคม" : sql &= $"COUNT(*) AS verify FROM EXESOC WHERE EXEKEY = '{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}'"
                    Case "ส่งสืบกรรมสิทธิ์ฟ้องเอง" : sql &= $"COUNT(*) AS verify FROM Execution_ownership WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}'"
                    Case "ผลสืบกรรมสิทธิ์/ที่ดิน" : sql &= $"COUNT(*) AS verify FROM Execution_ownership_result WHERE Ownership_deed = '{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}'"

                End Select

                If cmd_excuteScalar() > 0 Then

                    Dtgv_Exe.Rows(i).DefaultCellStyle.BackColor = Color.Red

                    If chk_senddata.Checked = True Then

                        Continue For
                    End If

                End If

                sql = $"INSERT INTO "

                Select Case cbo_products.SelectedItem

                    Case "ใบงานแถลงบัญชี" : sql &= $"EXESM(EXEKEY, EXEBANK, EXEID, EXECUSTOMER, EXEACC1, EXEACC2, EXEACC3, EXECOURT, EXEBLACK, EXERED, EXENUMBER, EXEDEPARTMENT, EXETOTAL, EXEEMPLOYEE, EXEPHONE, EXEHUB, EXEDATEWORK, EXEFULLNAME, EXEDETAIL,EXEPERFORMANCE,EXEDATERESULT,EXEHUBS,EXERESULT)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(15).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(20).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(2).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}','{ Dtgv_Exe.Rows(i).Cells(4).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(6).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(7).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(8).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(9).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(10).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(13).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(14).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(15).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(16).Value}','{Dtgv_Exe.Rows(i).Cells(17).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(18).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(19).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(20).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(21).Value.ToString}')"

                    '--------------------------- UPLOAD แถลงบัญชี --------------------------'

                    Case "บังคับคดีตั้งเรื่อง" : sql &= $"EXEACC(ACCKEY,ACCBANK,ACCIDC,ACCCUSNAM,ACCBLACK,ACCRED,ACCSTATUS,ACCDATE,ACCRECEIPT,ACCRECEIPT_DETAIL,ACCRECEIPT_OTHER_2,ACCRECEIPT_OTHER_DETAIL2,ACCRECEIPT_OTHER_3,ACCRECEIPT_OTHER_DETAIL3,ACCMONTH)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(6).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(2).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(4).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(6).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(7).Value}','{Dtgv_Exe.Rows(i).Cells(8).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(13).Value.ToString}')"

                    '---------------------- UPLOAD เบิกบังคับคดีที่ไปตั้งเรื่อง -----------------------------------'

                    Case "ตรวจสำนวนตามใบงาน" : sql &= $"EXETRACKING(Tracking_pk,Customer_owner,Customer_idc,Customer_fullname,Tracking_court,Tracking_red,Tracking_date_sheet,EMPLOYEES_KEY,Tracking_detail,Tracking_nosheet,Tracking_Collector_nosend,Tracking_other,Tracking_date_work)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(2).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(4).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(6).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(7).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(8).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(9).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(10).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(11).Value.ToString}')"

                    '----------------------- UPLOAD TRACKING ------------------'

                    Case "ถอนอายัด/ยึด" : sql &= $"EXEWDS(EXEKEY,EXECUSOWN,EXEHUBS,EXEDATECOLLEC,EXECUSIDC,EXECUSCUS,EXECUSACC,EXECUSNAM,EXECUSBLACK,EXECUSRED,EXEDATEPAY,EXETOTAL,EXECUSPHONE,EXESTATUS,EXEADMIN,EXEEMPLOYEE,EXEDATEWDS,EXEDETAILWDS)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(2).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}','{ Dtgv_Exe.Rows(i).Cells(4).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(6).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(7).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(8).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(9).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(10).Value}','{Dtgv_Exe.Rows(i).Cells(11).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(12).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(13).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(14).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(15).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(16).Value.ToString}')"

                    '------------------------------ UPLOAD WITHDRAWSEIZE ---------------------'

                    Case "ตรวจสำนวนจากบังคับดคี" : sql &= $"Execution_verify(Customer_owner,Customer_id_card,Customer_account,Customer_fullname,EMPLOYEES_KEY,Execution_verify_date,Execution_verify_result,Execution_verify_comment)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(2).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(4).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(6).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(7).Value.ToString}')"

                    '--------------------- UPLOAD EXEVERIFY ---------------------------'

                    Case "ส่งเช็คถอนอายัด/ยึด" : sql &= $"EXECHECK(CHKKEY,CHKOWN,CHKBANK,CHKHUB,CHKNUM,CHKDATE,CHKTOTAL,CHKIDC,CHKACC,CHKACCNO,CHKNAME,CHKRED,CHKDATESEND,CHKTOTALEXE,CHKTOTALEXERE,CHKDETAIL1)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(7).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(11).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(2).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(4).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(6).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(7).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(8).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(9).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(10).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(11).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(12).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(13).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(14).Value.ToString}')"

                    '-------------------- UPLOAD EXECHECK -------------------------'

                    Case "ส่งคัดประกันสังคมฟ้องเอง" : sql &= $"Execution_Port(Customer_Owner,Customer_Id_Card,Customer_Number,Serial_Account,Customer_Name,OA,Legal_Status,Date_send,Review_Result,Review_Result_Description,Employees_User)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(2).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(4).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(6).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(7).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(8).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(9).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(10).Value.ToString}') "

                        '----------- UPLOAD EXEPORT ------------'

                    Case "ผลคัดประกันสังคม" : sql &= $"EXESOC(EXEKEY,Customer_Owner,Customer_Id_Card,Customer_OFFICE,Customer_date_SOC,Customer_Address)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}-{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(2).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(4).Value.ToString}')"

                        '------------- UPLOAD SOC-------------'

                    Case "ส่งสืบกรรมสิทธิ์ฟ้องเอง" : sql &= $"Execution_Ownership(Customer_id_card,Customer_name,Date_send,Customer_owner,Result)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(2).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(4).Value.ToString}')"

                        '------------ UPLOAD Execution_Ownership ------------'
                    Case "ผลสืบกรรมสิทธิ์/ที่ดิน" : sql &= $"Execution_Ownership_Result(Customer_Id_Card,Date_review,Ownership_deed,Ownership_surveypage,Ownership_district,Ownership_location,Ownership_land_office,Ownership_address)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(1).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(2).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(3).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(4).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(5).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(6).Value.ToString}','{Dtgv_Exe.Rows(i).Cells(7).Value.ToString}')"
                        '-----------------UPLOAD Execution_Ownership_Result ------------------'
                End Select

                cmd = New SqlCommand(sql, cn)
                cmd_excuteNonquery()

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

    Private Sub Frmimportexe_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub
End Class
