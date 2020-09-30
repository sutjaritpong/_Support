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
Imports System.Net

Public Class Frmimportexe

    Private Sub Frmimportexe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_flow.Visible = False
        lbl_countimport.Visible = False
        Dtgv_Exe.Visible = False
        Main_progressbar.Visible = False
        Main_progressbar.Value = 0
        lbl_statusprogress.Visible = False

        Connect()

        Dim type() As String = {"ใบงานแถลงบัญชี(Statement)", "บังคับคดีตั้งเรื่อง(Accounting)", "ผลคัดประกันสังคม(SOC)", "ตรวจสำนวนตามใบงาน(Tracking)", "ตรวจสำนวนจากบังคับดคี(Tracking-Verify)", "ถอนอายัด/ยึด(Withdraw)", "ส่งเช็คถอนอายัด/ยึด(Withdraw-Check)", "ส่งคัดประกันสังคมฟ้องเอง(Port)", "ผลสืบกรรมสิทธิ์/ที่ดิน(OwnerShip-Result)", "ส่งสืบกรรมสิทธิ์ฟ้องเอง(OwnerShip)", "อายัดซ้ำ(RepeatFreeze)", "เงินส่วนได้/ค่าใช้จ่ายคืน(Income)", "รับเช็ค/บัญชีรับ-จ่าย(Income-Result)"}

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

    Private Sub Cmd_openfile_Click(sender As Object, e As EventArgs) Handles cmd_openfile.Click
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

    Private Sub Cmd_import_Click(sender As Object, e As EventArgs) Handles cmd_import.Click

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

    Private Sub Cmd_toserver_Click(sender As Object, e As EventArgs) Handles cmd_toserver.Click

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

                Select Case cbo_products.SelectedItem
                Case "ใบงานแถลงบัญชี(Statement)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(0).Value} FULLNAME {Dtgv_Exe.Rows(i).Cells(2).Value} จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(1).Value}'", $"'{Dtgv_Exe.Rows(i).Cells(3).Value}'")

                Case "บังคับคดีตั้งเรื่อง(Accounting)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(0).Value} FULLNAME {Dtgv_Exe.Rows(i).Cells(2).Value} Status{Dtgv_Exe.Rows(i).Cells(5).Value} จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(1).Value}'", $"NULL")

                Case "ผลคัดประกันสังคม(SOC)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(0).Value}  จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(1).Value}'", $"NULL")

                Case "ตรวจสำนวนตามใบงาน(Tracking)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(0).Value}  จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(1).Value}'", $"NULL")

                Case "ถอนอายัด/ยึด(Withdraw)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(0).Value} FULLNAME {Dtgv_Exe.Rows(i).Cells(6).Value} Status  {Dtgv_Exe.Rows(i).Cells(12).Value} จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(3).Value}'", $"'{Dtgv_Exe.Rows(i).Cells(5).Value}'")

                Case "ตรวจสำนวนจากบังคับดคี(Tracking-Verify)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(0).Value} FULLNAME {Dtgv_Exe.Rows(i).Cells(3).Value} Status {Dtgv_Exe.Rows(i).Cells(6).Value} จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(1).Value}'", $"'{Dtgv_Exe.Rows(i).Cells(2).Value}'")

                Case "ส่งเช็คถอนอายัด/ยึด(Withdraw-Check)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(0).Value} FULLNAME {Dtgv_Exe.Rows(i).Cells(9).Value} Status {Dtgv_Exe.Rows(i).Cells(14).Value} จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(6).Value}'", $"'{Dtgv_Exe.Rows(i).Cells(7).Value}'")

                Case "ส่งคัดประกันสังคมฟ้องเอง(Port)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(0).Value} FULLNAME {Dtgv_Exe.Rows(i).Cells(4).Value} Status {Dtgv_Exe.Rows(i).Cells(8).Value} จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(1).Value}'", $"'{Dtgv_Exe.Rows(i).Cells(3).Value}'")

                Case "ส่งสืบกรรมสิทธิ์ฟ้องเอง(OwnerShip)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(3).Value} FULLNAME {Dtgv_Exe.Rows(i).Cells(1).Value} Status {Dtgv_Exe.Rows(i).Cells(4).Value} จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(0).Value}'", $"NULL")

                Case "ผลสืบกรรมสิทธิ์/ที่ดิน(OwnerShip-Result)" : Getlogdataexe($" Types {cbo_products.Text} จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(0).Value}'", $"NULL")

                Case "อายัดซ้ำ(RepeatFreeze)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(0).Value} FULLNAME {Dtgv_Exe.Rows(i).Cells(5).Value} จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(1).Value}'", $"'{Dtgv_Exe.Rows(i).Cells(2).Value}'")

                Case "เงินส่วนได้/ค่าใช้จ่ายคืน(Income)" : Getlogdataexe($" Types {cbo_products.Text} Owner {Dtgv_Exe.Rows(i).Cells(0).Value} FULLNAME {Dtgv_Exe.Rows(i).Cells(7).Value} Status {Dtgv_Exe.Rows(i).Cells(12).Value} จากการ UPLOAD ", $"'{Dtgv_Exe.Rows(i).Cells(1).Value}'", $"'{Dtgv_Exe.Rows(i).Cells(2).Value}'")

                Case "รับเช็ค/บัญชีรับ-จ่าย(Income-Result)" : Getlogdataexe($"Types {cbo_products.Text} จำนวน {Dtgv_Exe.Rows(i).Cells(4).Value}", $"'{Dtgv_Exe.Rows(i).Cells(0).Value}'", $"'{Dtgv_Exe.Rows(i).Cells(1).Value}'")

            End Select

        Next


        sql = " SELECT COUNT(*) As TYPEs FROM "

        Select Case cbo_products.SelectedItem

            Case "ใบงานแถลงบัญชี(Statement)" : sql &= $"EXESM"
            Case "บังคับคดีตั้งเรื่อง(Accounting)" : sql &= $"EXEACC"
            Case "ผลคัดประกันสังคม(SOC)" : sql &= $"EXESOC"
            Case "ตรวจสำนวนตามใบงาน(Tracking)" : sql &= $"EXETRACKING"
            Case "ถอนอายัด/ยึด(Withdraw)" : sql &= $"EXEWDS"
            Case "ตรวจสำนวนจากบังคับดคี(Tracking-Verify)" : sql &= $"Execution_verify"
            Case "ส่งเช็คถอนอายัด/ยึด(Withdraw-Check)" : sql &= $"EXECHECK"
            Case "ส่งคัดประกันสังคมฟ้องเอง(Port)" : sql &= $"Execution_Port"
            Case "ส่งสืบกรรมสิทธิ์ฟ้องเอง(OwnerShip)" : sql &= $"Execution_ownership"
            Case "ผลสืบกรรมสิทธิ์/ที่ดิน(OwnerShip-Result)" : sql &= $"Execution_ownership_result"
            Case "อายัดซ้ำ(RepeatFreeze)" : sql &= $"Execution_RepeatFreeze"
            Case "เงินส่วนได้/ค่าใช้จ่ายคืน(Income)" : sql &= $"Execution_income"
            Case "รับเช็ค/บัญชีรับ-จ่าย(Income-Result)" : sql &= $"Execution_income_Result"

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

                    Case "ใบงานแถลงบัญชี(Statement)" : sql &= $"COUNT(*) As verify FROM EXESM WHERE EXEKEY = '{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}-{Dtgv_Exe.Rows(i).Cells(15).Value}-{Dtgv_Exe.Rows(i).Cells(20).Value}'"

                    Case "บังคับคดีตั้งเรื่อง(Accounting)" : sql &= $"COUNT(*) AS verify FROM EXEACC WHERE ACCKEY = '{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}-{Dtgv_Exe.Rows(i).Cells(6).Value}'"

                    Case "ส่งเช็คถอนอายัด/ยึด(Withdraw-Check)" : sql &= $"COUNT(*) AS verify FROM EXECHECK WHERE CHKNUM = {Dtgv_Exe.Rows(i).Cells(3).Value}"

                    Case "ส่งคัดประกันสังคมฟ้องเอง(Port)" : sql &= $"COUNT(*) AS verify FROM Execution_Port WHERE Serial_Account = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    Case "ตรวจสำนวนตามใบงาน(Tracking)" : sql &= $"COUNT(*) AS verify FROM EXETRACKING WHERE Tracking_pk = '{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}-{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                    Case "ตรวจสำนวนจากบังคับดคี(Tracking-Verify)" : sql &= $"COUNT(*) AS verify FROM dbo.Execution_verify WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(1).Value}'"

                    Case "ผลคัดประกันสังคม(SOC)" : sql &= $"COUNT(*) AS verify FROM EXESOC WHERE EXEKEY = '{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}'"

                    Case "ส่งสืบกรรมสิทธิ์ฟ้องเอง(OwnerShip)" : sql &= $"COUNT(*) AS verify FROM Execution_ownership WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(0).Value}'"

                    Case "ผลสืบกรรมสิทธิ์/ที่ดิน(OwnerShip-Result)" : sql &= $"COUNT(*) AS verify FROM Execution_ownership_result WHERE Ownership_deed = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    Case "อายัดซ้ำ(RepeatFreeze)" : sql &= $"COUNT(*) AS verify From Execution_Repeatfreeze WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(1).Value}'"

                    Case "เงินส่วนได้/ค่าใช้จ่ายคืน(Income)" : sql &= $"COUNT(*) AS verify From Execution_income WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(1).Value}'"

                    Case "รับเช็ค/บัญชีรับ-จ่าย(Income-Result)" : sql &= $"COUNT(*) AS verify FROM Execution_Income_Result WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(0).Value}' "

                End Select

                If Cmd_excuteScalar() > 0 Then

                    Dtgv_Exe.Rows(i).DefaultCellStyle.BackColor = Color.Red

                    If chk_senddata.Checked = True Then

                        Continue For

                    End If

                End If

                sql = $"INSERT INTO "

                Select Case cbo_products.SelectedItem

                    Case "ใบงานแถลงบัญชี(Statement)" : sql &= $"EXESM(EXEKEY, EXEBANK, EXEID, EXECUSTOMER, EXEACC1, EXEACC2, EXEACC3, EXECOURT, EXEBLACK, EXERED, EXENUMBER, EXEDEPARTMENT, EXETOTAL, EXEEMPLOYEE, EXEPHONE, EXEHUB, EXEDATEWORK, EXEFULLNAME, EXEDETAIL,EXEPERFORMANCE,EXEDATERESULT,EXEHUBS,EXERESULT)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}-{Dtgv_Exe.Rows(i).Cells(15).Value}-{Dtgv_Exe.Rows(i).Cells(20).Value}','{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}','{Dtgv_Exe.Rows(i).Cells(8).Value}','{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value}','{Dtgv_Exe.Rows(i).Cells(13).Value}','{Dtgv_Exe.Rows(i).Cells(14).Value}','{Dtgv_Exe.Rows(i).Cells(15).Value}','{Dtgv_Exe.Rows(i).Cells(16).Value}','{Dtgv_Exe.Rows(i).Cells(17).Value}','{Dtgv_Exe.Rows(i).Cells(18).Value}','{Dtgv_Exe.Rows(i).Cells(19).Value}','{Dtgv_Exe.Rows(i).Cells(20).Value}','{Dtgv_Exe.Rows(i).Cells(21).Value}')"


                    '--------------------------- UPLOAD แถลงบัญชี --------------------------'

                    Case "บังคับคดีตั้งเรื่อง(Accounting)" : sql &= $"EXEACC(ACCKEY,ACCBANK,ACCIDC,ACCCUSNAM,ACCBLACK,ACCRED,ACCSTATUS,ACCDATE,ACCRECEIPT,ACCRECEIPT_DETAIL,ACCRECEIPT_OTHER_2,ACCRECEIPT_OTHER_DETAIL2,ACCRECEIPT_OTHER_3,ACCRECEIPT_OTHER_DETAIL3,ACCMONTH)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}-{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}','{Dtgv_Exe.Rows(i).Cells(8).Value}','{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value}','{Dtgv_Exe.Rows(i).Cells(13).Value}')"


                    '---------------------- UPLOAD เบิกบังคับคดีที่ไปตั้งเรื่อง -----------------------------------'

                    Case "ตรวจสำนวนตามใบงาน(Tracking)" : sql &= $"EXETRACKING(Tracking_pk,Customer_owner,Customer_idc,Customer_fullname,Tracking_court,Tracking_red,Tracking_date_sheet,EMPLOYEES_KEY,Tracking_detail,Tracking_nosheet,Tracking_Collector_nosend,Tracking_other,Tracking_date_work,Tracking_total)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}-{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}','{Dtgv_Exe.Rows(i).Cells(8).Value}','{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value}')"


                    '----------------------- UPLOAD TRACKING ------------------'

                    Case "ถอนอายัด/ยึด(Withdraw)" : sql &= $"EXEWDS(EXEKEY,EXECUSOWN,EXEHUBS,EXEDATECOLLEC,EXECUSIDC,EXECUSCUS,EXECUSACC,EXECUSNAM,EXECUSBLACK,EXECUSRED,EXEDATEPAY,EXETOTAL,EXECUSPHONE,EXESTATUS,EXEADMIN,EXEEMPLOYEE,EXEDATEWDS,EXEDETAILWDS)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}','{Dtgv_Exe.Rows(i).Cells(8).Value}','{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value}','{Dtgv_Exe.Rows(i).Cells(13).Value}','{Dtgv_Exe.Rows(i).Cells(14).Value}','{Dtgv_Exe.Rows(i).Cells(15).Value}','{Dtgv_Exe.Rows(i).Cells(16).Value}')"


                    '------------------------------ UPLOAD WITHDRAWSEIZE ---------------------'

                    Case "ตรวจสำนวนจากบังคับดคี(Tracking-Verify)" : sql &= $"Execution_verify(Customer_owner,Customer_id_card,Customer_account,Customer_fullname,EMPLOYEES_KEY,Execution_verify_date,Execution_verify_result,Execution_verify_comment)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}')"

                                            '--------------------- UPLOAD EXEVERIFY ---------------------------'

                    Case "ส่งเช็คถอนอายัด/ยึด(Withdraw-Check)" : sql &= $"EXECHECK(CHKOWN,CHKBANK,CHKHUB,CHKNUM,CHKDATE,CHKTOTAL,CHKIDC,CHKACC,CHKACCNO,CHKNAME,CHKRED,CHKDATESEND,CHKTOTALEXE,CHKTOTALEXERE,CHKDETAIL1)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}','{Dtgv_Exe.Rows(i).Cells(8).Value}','{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value}','{Dtgv_Exe.Rows(i).Cells(13).Value}','{Dtgv_Exe.Rows(i).Cells(14).Value}')"


                    '-------------------- UPLOAD EXECHECK -------------------------'

                    Case "ส่งคัดประกันสังคมฟ้องเอง(Port)" : sql &= $"Execution_Port(Customer_Owner,Customer_Id_Card,Customer_Number,Serial_Account,Customer_Name,OA,Legal_Status,Date_send,Review_Result,Review_Result_Description,Employees_User)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}','{Dtgv_Exe.Rows(i).Cells(8).Value}','{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value}') "


                        '----------- UPLOAD EXEPORT ------------'

                    Case "ผลคัดประกันสังคม(SOC)" : sql &= $"EXESOC(EXEKEY,Customer_Owner,Customer_Id_Card,Customer_OFFICE,Customer_date_SOC,Customer_Address)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}')"


                        '------------- UPLOAD EXESOC-------------'

                    Case "ส่งสืบกรรมสิทธิ์ฟ้องเอง(OwnerShip)" : sql &= $"Execution_Ownership(Customer_id_card,Customer_name,Date_send,Customer_owner,Result,Detail)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}')"

                                            '------------ UPLOAD Execution_Ownership ------------'

                    Case "ผลสืบกรรมสิทธิ์/ที่ดิน(OwnerShip-Result)" : sql &= $"Execution_Ownership_Result(Customer_Id_Card,Date_review,Ownership_deed,Ownership_surveypage,Ownership_district,Ownership_location,Ownership_land_office,Ownership_address)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}')"


                        '-----------------UPLOAD Execution_Ownership_Result ------------------'

                    Case "อายัดซ้ำ(RepeatFreeze)" : sql &= $"Execution_Repeatfreeze(Customer_owner,Customer_id_card,Customer_account,Customer_firstname,Customer_lastname,Customer_fullname,RepeatFreeze_court,RepeatFreeze_red,EMPLOYEES_KEY,RepeatFreeze_types,RepeatFreeze_Detail,RepeatFreeze_date_sheet,RepeatFreeze_date_work,RepeatFreeze_Status)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}',{Dtgv_Exe.Rows(i).Cells(8).Value},'{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value}','{Dtgv_Exe.Rows(i).Cells(13).Value}')"



                        '-----------------UPLOAD Execution_RepeatFreeze ---------------------'

                    Case "เงินส่วนได้/ค่าใช้จ่ายคืน(Income)" : sql &= $"Execution_income(Customer_owner,Customer_id_card,Customer_account,Customer_account_no,Customer_Prefix,Customer_firstname,Customer_lastname,Customer_fullname,income_court,Income_black,income_red,EMPLOYEES_KEY,income_type,income_detail,income_date_sheet,income_date_work,income_total_check)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}','{Dtgv_Exe.Rows(i).Cells(2).Value}','{Dtgv_Exe.Rows(i).Cells(3).Value}','{Dtgv_Exe.Rows(i).Cells(4).Value}','{Dtgv_Exe.Rows(i).Cells(5).Value}','{Dtgv_Exe.Rows(i).Cells(6).Value}','{Dtgv_Exe.Rows(i).Cells(7).Value}','{Dtgv_Exe.Rows(i).Cells(8).Value}','{Dtgv_Exe.Rows(i).Cells(9).Value}','{Dtgv_Exe.Rows(i).Cells(10).Value}','{Dtgv_Exe.Rows(i).Cells(11).Value}','{Dtgv_Exe.Rows(i).Cells(12).Value}','{Dtgv_Exe.Rows(i).Cells(13).Value}','{Dtgv_Exe.Rows(i).Cells(14).Value}','{Dtgv_Exe.Rows(i).Cells(15).Value}','{Dtgv_Exe.Rows(i).Cells(16).Value}')"


                        '-----------------UPLOAD Execution_income ---------------------'

                    Case "รับเช็ค/บัญชีรับ-จ่าย(Income-Result)" : sql &= $"Execution_income_result(Customer_Id_Card,Customer_Account,Income_refund,Income_refund_date,Income_grandtotal,Income_statement_1,Income_refund_date1,Income_statement_2,Income_refund_date2,Income_statement_3,Income_refund_date3,income_statement_4,Income_refund_date4,Income_statement_5,Income_refund_date5,Income_statement_6,Income_refund_date6,Income_statement_7,Income_refund_date7,Income_statement_8,Income_refund_date8,Income_statement_9,Income_refund_date9,Income_statement_10,Income_refund_date10,Income_statement_11,Income_refund_date11,Income_statement_12,Income_refund_date12,Income_statement_13,Income_refund_date13,Income_statement_14,Income_refund_date14,Income_statement_15,Income_refund_date15)VALUES('{Dtgv_Exe.Rows(i).Cells(0).Value}','{Dtgv_Exe.Rows(i).Cells(1).Value}',{Dtgv_Exe.Rows(i).Cells(2).Value},'{Dtgv_Exe.Rows(i).Cells(3).Value}',{Dtgv_Exe.Rows(i).Cells(4).Value},{Dtgv_Exe.Rows(i).Cells(5).Value},'{Dtgv_Exe.Rows(i).Cells(6).Value}',{Dtgv_Exe.Rows(i).Cells(7).Value},'{Dtgv_Exe.Rows(i).Cells(8).Value}',{Dtgv_Exe.Rows(i).Cells(9).Value},'{Dtgv_Exe.Rows(i).Cells(10).Value}',{Dtgv_Exe.Rows(i).Cells(11).Value},'{Dtgv_Exe.Rows(i).Cells(12).Value}',{Dtgv_Exe.Rows(i).Cells(13).Value},'{Dtgv_Exe.Rows(i).Cells(14).Value}',{Dtgv_Exe.Rows(i).Cells(15).Value},'{Dtgv_Exe.Rows(i).Cells(16).Value}',{Dtgv_Exe.Rows(i).Cells(17).Value},'{Dtgv_Exe.Rows(i).Cells(18).Value}',{Dtgv_Exe.Rows(i).Cells(19).Value},'{Dtgv_Exe.Rows(i).Cells(20).Value}',{Dtgv_Exe.Rows(i).Cells(21).Value},'{Dtgv_Exe.Rows(i).Cells(22).Value}',{Dtgv_Exe.Rows(i).Cells(23).Value},'{Dtgv_Exe.Rows(i).Cells(24).Value}',{Dtgv_Exe.Rows(i).Cells(25).Value},'{Dtgv_Exe.Rows(i).Cells(26).Value}',{Dtgv_Exe.Rows(i).Cells(27).Value},'{Dtgv_Exe.Rows(i).Cells(28).Value}',{Dtgv_Exe.Rows(i).Cells(29).Value},'{Dtgv_Exe.Rows(i).Cells(30).Value}',{Dtgv_Exe.Rows(i).Cells(31).Value},'{Dtgv_Exe.Rows(i).Cells(32).Value}',{Dtgv_Exe.Rows(i).Cells(33).Value},'{Dtgv_Exe.Rows(i).Cells(34).Value}')"

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

    Private Sub Frmimportexe_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

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

                    Case "ใบงานแถลงบัญชี(Statement)" : sql &= $"COUNT(*) As verify FROM EXESM WHERE EXEKEY = '{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}-{Dtgv_Exe.Rows(i).Cells(15).Value}-{Dtgv_Exe.Rows(i).Cells(20).Value}'"

                    Case "บังคับคดีตั้งเรื่อง(Accounting)" : sql &= $"COUNT(*) AS verify FROM EXEACC WHERE ACCKEY = '{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}-{Dtgv_Exe.Rows(i).Cells(6).Value}'"

                    Case "ส่งเช็คถอนอายัด/ยึด(Withdraw-Check)" : sql &= $"COUNT(*) AS verify FROM EXECHECK WHERE CHKNUM = {Dtgv_Exe.Rows(i).Cells(3).Value}"

                    Case "ส่งคัดประกันสังคมฟ้องเอง(Port)" : sql &= $"COUNT(*) AS verify FROM Execution_Port WHERE Serial_Account = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    Case "ตรวจสำนวนตามใบงาน(Tracking)" : sql &= $"COUNT(*) AS verify FROM EXETRACKING WHERE Tracking_pk = '{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}-{Dtgv_Exe.Rows(i).Cells(5).Value}'"

                    Case "ตรวจสำนวนจากบังคับดคี(Tracking-Verify)" : sql &= $"COUNT(*) AS verify FROM dbo.Execution_verify WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(1).Value}'"

                    Case "ผลคัดประกันสังคม(SOC)" : sql &= $"COUNT(*) AS verify FROM EXESOC WHERE EXEKEY = '{Dtgv_Exe.Rows(i).Cells(0).Value}-{Dtgv_Exe.Rows(i).Cells(1).Value}'"

                    Case "ส่งสืบกรรมสิทธิ์ฟ้องเอง(OwnerShip)" : sql &= $"COUNT(*) AS verify FROM Execution_ownership WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(0).Value}'"

                    Case "ผลสืบกรรมสิทธิ์/ที่ดิน(OwnerShip-Result)" : sql &= $"COUNT(*) AS verify FROM Execution_ownership_result WHERE Ownership_deed = '{Dtgv_Exe.Rows(i).Cells(3).Value}'"

                    Case "อายัดซ้ำ(RepeatFreeze)" : sql &= $"COUNT(*) AS verify From Execution_Repeatfreeze WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(1).Value}'"

                    Case "เงินส่วนได้/ค่าใช้จ่ายคืน(Income)" : sql &= $"COUNT(*) AS verify From Execution_income WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(1).Value}'"

                    Case "รับเช็ค/บัญชีรับ-จ่าย(Income-Result)" : sql &= $"COUNT(*) AS verify FROM Execution_Income_Result WHERE Customer_id_card = '{Dtgv_Exe.Rows(i).Cells(0).Value}' "

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
End Class
