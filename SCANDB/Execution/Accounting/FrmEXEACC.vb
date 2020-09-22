Option Explicit On
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Public Class FrmEXEACC
    '## Array entity_ACC() นำไปใช้เพิ่ม Columns ใน Datagridview 
    Friend entity_ACC() As String = {"KEY", "PRODUCT", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "เลขที่คดีดำ", "เลขที่คดีแดง", "Status", "วันที่ใบเสร็จ", "จำนวนเงินในใบเสร็จ", "รายละเอียดใบเสร็จ", "จำนวนเงินใบเสร็จที่ 2", "รายละเอียดใบเสร็จที่ 2", "จำนวนเงินใบเสร็จที่ 3", "รายละเอียดใบเสร็จที่ 3", "เดือนที่ลงข้อมูล", "เลขที่สัญญา", "ธนาคาร", "BILLCODE", "Type", "CODE"}


    Private Sub FrmEXEACC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NotEdit_information()


        EXEACC_LoadForm()

        Repeat_LoadForm()

    End Sub

    Private Sub Countdata(_Columns As String, _Tables As String, _LableText As Label)

        Connect()
        sql = $"SELECT COUNT({_Columns}) AS count_exeacc FROM {_Tables}"
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "Countdata")
        _LableText.Text = DS.Tables("Countdata").Rows(0)("count_exeacc") & "" & "ราย"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim dt As DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat

        lbl_timer.Text = DateAndTime.TimeString             '//ตั้งเวลาโปรแกรม

        lbl_datetoday.Text = DateAndTime.Today.ToShortDateString        '//ตั้งเวลาวันที่ 

    End Sub

    Private Sub Txt_totalbill_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total_receipt.KeyPress
        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub


    Private Sub Cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        Datagrid()

    End Sub

    Sub Cleartext()

        cbo_owner.Text = ""
        txt_black.Text = ""
        txt_cusid.Text = ""
        txt_cusname.Text = ""
        txt_detail_receipt.Text = ""
        txt_red.Text = ""
        cbo_status.Text = ""
        txt_total_receipt.Text = ""
        txt_detail_receipt.Text = ""
        txt_total_receipt2.Text = ""
        txt_detail_receipt2.Text = ""
        txt_total_receipt3.Text = ""
        txt_detail_receipt3.Text = ""
        dtp_datework.Text = ""
        dtp_date_receipt.Text = ""
        cbo_owner.Text = ""

        'LINK Legal data
        Txt_account.Text = ""
        Txt_bank.Text = ""
        Txt_Billcode.Text = ""
        Txt_productcode.Text = ""
        Txt_type.Text = ""


        chk_date_work.Checked = False
        chk_date_receipt.Checked = False

        If chk_date_receipt.Checked = False Then
            dtp_date_receipt.Enabled = False
        End If
        If chk_date_work.Checked = False Then
            dtp_datework.Enabled = False
        End If
    End Sub
    Private Sub Readonly_obj()

        cbo_owner.Enabled = False  'enable = false if readonly = true
        cbo_status.Enabled = False

        txt_cusid.ReadOnly = True
        txt_cusname.ReadOnly = True
        txt_black.ReadOnly = True
        txt_red.ReadOnly = True


        txt_total_receipt.ReadOnly = True
        txt_total_receipt2.ReadOnly = True
        txt_total_receipt3.ReadOnly = True

        txt_detail_receipt.ReadOnly = True
        txt_detail_receipt2.ReadOnly = True
        txt_detail_receipt3.ReadOnly = True

        chk_date_receipt.Enabled = False
        chk_date_work.Enabled = False

        If chk_date_receipt.Enabled = False Then
            dtp_date_receipt.Enabled = False
        End If
        If chk_date_work.Enabled = False Then
            dtp_datework.Enabled = False
        End If

    End Sub
    Private Sub Write_obj()

        cbo_owner.Enabled = True  '#enable = true if readonly = false
        cbo_status.Enabled = True

        txt_cusid.ReadOnly = False
        txt_cusname.ReadOnly = False
        txt_black.ReadOnly = False
        txt_red.ReadOnly = False

        txt_total_receipt.ReadOnly = False
        txt_total_receipt2.ReadOnly = False
        txt_total_receipt3.ReadOnly = False

        txt_detail_receipt.ReadOnly = False
        txt_detail_receipt2.ReadOnly = False
        txt_detail_receipt3.ReadOnly = False

        chk_date_work.Enabled = True
        chk_date_receipt.Enabled = True

    End Sub
    Private Sub LinK_Legal()

        Select Case cbo_owner.SelectedItem
            Case "TMB SME" : LinkTMBSME()
            Case "KKB" : LinkKKB()
            Case Else : LinkLegal()
        End Select

    End Sub
    Private Sub LinkKKB()

        Connect_(cn_KKB)

        sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{txt_cusid.Text}' ;"
        cmd_Collec = New SqlCommand(sqll, cn_KKB)
        DA_Collec = New SqlDataAdapter(cmd_Collec)
        DS_Collec = New DataSet
        DA_Collec.Fill(DS_Collec, "LinkKKB")

        If DS_Collec.Tables("LinkKKB").Rows.Count <= 0 Then
            LinkLegal()
        Else
            txt_cusname.Text = $"{DS_Collec.Tables("LinkKKB").Rows(0)("CUSTFN")}"
            txt_red.Text = DS_Collec.Tables("LinKKKB").Rows(0)("LAWRED").ToString
            txt_black.Text = DS_Collec.Tables("LinkKKB").Rows(0)("LAWBLK").ToString
            Txt_account.Text = DS_Collec.Tables("LinkKKB").Rows(0)("CUSCNO").ToString

            Lbl_linklegal.Text = $"พบ {DS_Collec.Tables("LinkKKB").Rows.Count} รายการ"
            Lbl_linklegal.ForeColor = Color.Green
        End If
        cn_KKB.Close()
    End Sub

    Private Sub LinkTMBSME()

        Connect_(cn_TMBSME)

        sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{txt_cusid.Text}';"
        cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
        DA_Collec = New SqlDataAdapter(cmd_Collec)
        DS_Collec = New DataSet
        DA_Collec.Fill(DS_Collec, "Linktmbsme")


        If DS_Collec.Tables("Linktmbsme").Rows.Count <= 0 Then
            Lbl_linklegal.Text = $"พบ {DS_Collec.Tables("Linktmbsme").Rows.Count} รายการ"
            Lbl_linklegal.ForeColor = Color.Red
        Else
            txt_cusname.Text = $"{DS_Collec.Tables("Linktmbsme").Rows(0)("CUSTFN")} {DS_Collec.Tables("Linktmbsme").Rows(0)("CUSTLN")} "
            txt_red.Text = DS_Collec.Tables("Linktmbsme").Rows(0)("LAWRED").ToString
            txt_black.Text = DS_Collec.Tables("Linktmbsme").Rows(0)("LAWBLK").ToString
            Txt_account.Text = DS_Collec.Tables("Linktmbsme").Rows(0)("CUSCNO").ToString

            Lbl_linklegal.Text = $"พบ {DS_Collec.Tables("Linktmbsme").Rows.Count} รายการ"
            Lbl_linklegal.ForeColor = Color.Green
        End If

    End Sub
    Private Sub LinkLegal()

        Select Case cbo_owner.SelectedItem
            Case "TSS" : Connect_(cn_GE)
                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSTYP,RFCUS.CUSLNO,RFCUS.CUSPRO,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFCUS.CUSBLK,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_GE)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                    Txt_account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                    txt_black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Billcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                    Txt_productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString

                    Select Case Txt_productcode.Text
                        Case "CPL", "GPC", "TCP", "FC", "NFC", "TIN", "TIP", "PB", "HFC", "MHF" : Txt_bank.Text = "บริษัท อยุธยา แคปปิตอล เซอร์วิสเซส จำกัด"
                        Case "CCC", "CCM", "RBV", "HPR", "CCP" : Txt_bank.Text = "บริษัท เจเนอรัล คาร์ด เซอร์วิสเซส จำกัด"
                        Case "TES", "LTS", "TPL" : Txt_bank.Text = "บริษัท เทสโก้ คาร์ด เซอร์วิสเซส จำกัด"
                        Case "KCC", "KSM", "HPK", "HPR", "KHB", "KPL", "AYCC", "AYJC", "AYPL", "KJC", "HME", "TKCC", "TKJC" : Txt_bank.Text = "บริษัท บัตรกรุงศรีอยุธยา จำกัด"
                    End Select

                    Lbl_linklegal.Text = $"พบ CACC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_linklegal.ForeColor = Color.Green

                Else

                    sqll = $"Select RFCUS.CUSIDC,RFCUS.CUSTYP,RFCUS.CUSLNO,RFCUS.CUSPRO,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW On RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{txt_cusid.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_GE)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then


                        Txt_type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Txt_account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        txt_cusname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                        txt_black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Billcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                        Txt_productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString

                        Select Case Txt_productcode.Text
                            Case "CPL", "GPC", "TCP", "FC", "NFC", "TIN", "TIP", "PB", "HFC", "MHF" : Txt_bank.Text = "บริษัท อยุธยา แคปปิตอล เซอร์วิสเซส จำกัด"
                            Case "CCC", "CCM", "RBV", "HPR", "CCP" : Txt_bank.Text = "บริษัท เจเนอรัล คาร์ด เซอร์วิสเซส จำกัด"
                            Case "TES", "LTS", "TPL" : Txt_bank.Text = "บริษัท เทสโก้ คาร์ด เซอร์วิสเซส จำกัด"
                            Case "KCC", "KSM", "HPK", "HPR", "KHB", "KPL", "AYCC", "AYJC", "AYPL", "KJC", "HME", "TKCC", "TKJC" : Txt_bank.Text = "บริษัท บัตรกรุงศรีอยุธยา จำกัด"
                        End Select

                        Lbl_linklegal.Text = $"พบ CIDC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_linklegal.ForeColor = Color.Green

                    Else

                        Lbl_linklegal.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_linklegal.ForeColor = Color.Red

                    End If

                End If
            Case Else : Connect_legal()
                sqll = $"Select dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSOWN = '{cbo_owner.Text}' AND dbCUS.CUSIDC = '{txt_cusid.Text}'"
                cmdlegal = New SqlCommand(sqll, cnLegal)
                DALegal = New SqlDataAdapter(cmdlegal)
                DSLegal = New DataSet
                DALegal.Fill(DSLegal, "linklegal")

                If DSLegal.Tables("linklegal").Rows.Count <= 0 Then
                    Lbl_linklegal.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                    Lbl_linklegal.ForeColor = Color.Red
                Else
                    txt_cusname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                    txt_red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                    txt_black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                    Txt_account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                    Txt_bank.Text = DSLegal.Tables("linklegal").Rows(0)("CUSTOWN").ToString
                    Txt_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                    Txt_type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                    Txt_productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                    Lbl_linklegal.Text = $"พบ LIDC{DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                    Lbl_linklegal.ForeColor = Color.Green
                End If
                cnLegal.Close()
        End Select




    End Sub
    Private Sub Datagrid()

        Connect()

        Cleardatagrid(dtgv_exeacc)
        Cleartext()

        If txt_search.Text = "" Then
            Msg_error("กรุณากรอกข้อมุลที่ต้องการค้นหา")
            Return
        End If

        sql = $"SELECT * FROM EXEACC "

        Select Case cbo_search.SelectedItem

            Case "ธนาคาร" : sql &= $"WHERE ACCBANK"
            Case "เลขบัตรประชาชน" : sql &= $"WHERE ACCIDC"
            Case "ชื่อ-นามสกุล" : sql &= $"WHERE ACCCUSNAM"
            Case "เลขที่คดีดำ" : sql &= $"WHERE ACCBLACK"
            Case "เลขที่คดีแดง" : sql &= $"WHERE ACCRED"
            Case "Status" : sql &= $"WHERE ACCSTATUS"

        End Select

        sql &= $" LIKE '%{txt_search.Text}%' ORDER BY ACCMONTH"


        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "_search")

        If DS.Tables("_search").Rows.Count <= 0 Then

            lbl_count_find.Text = "ไม่พบข้อมูลที่ค้นหา.."
            lbl_count_find.ForeColor = Color.Red
            dtgv_exeacc.Visible = False
            Return

        Else

            With dtgv_exeacc
                .DataSource = DS.Tables("_search")

                For i = 0 To entity_ACC.Length - 1
                    .Columns(i).HeaderText = entity_ACC(i)
                    .Columns(0).Visible = False
                    .Columns(8).Visible = False
                    .Columns(9).Visible = False
                    .Columns(10).Visible = False
                    .Columns(11).Visible = False
                    .Columns(12).Visible = False
                    .Columns(13).Visible = False

                Next

            End With

            dtgv_exeacc.Visible = True
            Datagrid_format_dateshort(dtgv_exeacc, 7)
            Datagrid_format_dateshort(dtgv_exeacc, 14)
            lbl_count_find.Text = $"พบข้อมูล {dtgv_exeacc.RowCount} รายการ.."
            lbl_count_find.ForeColor = Color.Green

        End If

        cn.Close()

    End Sub

    Private Sub Cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click

        Write_obj()                '# แก้ไขข้อมูล !

    End Sub

    Private Sub Cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click
        Readonly_obj()                 '# ยกเลิกการแก้ไข !
    End Sub

    Private Sub Dtgv_exeacc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_exeacc.CellClick

        Cleartext()

        Try
            Txt_ACC_PK.Text = dtgv_exeacc.CurrentRow.Cells(0).Value.ToString
            cbo_owner.Text = dtgv_exeacc.CurrentRow.Cells(1).Value.ToString
            txt_cusid.Text = dtgv_exeacc.CurrentRow.Cells(2).Value.ToString
            txt_cusname.Text = dtgv_exeacc.CurrentRow.Cells(3).Value.ToString
            txt_black.Text = dtgv_exeacc.CurrentRow.Cells(4).Value.ToString
            txt_red.Text = dtgv_exeacc.CurrentRow.Cells(5).Value.ToString
            cbo_status.Text = dtgv_exeacc.CurrentRow.Cells(6).Value.ToString
            dtp_date_receipt.Text = dtgv_exeacc.CurrentRow.Cells(7).Value.ToString
            txt_total_receipt.Text = CInt(dtgv_exeacc.CurrentRow.Cells(8).Value)
            txt_detail_receipt.Text = dtgv_exeacc.CurrentRow.Cells(9).Value.ToString

            txt_total_receipt2.Text = CInt(dtgv_exeacc.CurrentRow.Cells(10).Value)
            txt_detail_receipt2.Text = dtgv_exeacc.CurrentRow.Cells(11).Value.ToString
            txt_total_receipt3.Text = CInt(dtgv_exeacc.CurrentRow.Cells(12).Value.ToString)
            txt_detail_receipt3.Text = dtgv_exeacc.CurrentRow.Cells(13).Value.ToString

            dtp_datework.Text = dtgv_exeacc.CurrentRow.Cells(14).Value.ToString

            LinK_Legal()

            Convertnum(txt_total_receipt)
            Convertnum(txt_total_receipt2)
            Convertnum(txt_total_receipt3)

            If dtgv_exeacc.CurrentRow.Cells(7).Value.ToString = "" Then
                chk_date_receipt.Checked = False
            Else
                chk_date_receipt.Checked = True
            End If
            If dtgv_exeacc.CurrentRow.Cells(14).Value.ToString = "" Then

                chk_date_work.Checked = False
            Else
                chk_date_work.Checked = True
            End If

        Catch ex As Exception

        Finally
            Readonly_obj()
        End Try


    End Sub

    Private Sub Cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click

        Dim _date As DateTime = dtp_date_receipt.Text

        Connect()

        Check_CitizenID(txt_cusid)


        If txt_cusid.Text = "" Then         '# เช็คข้อมูลเลขที่บัตรประชาชน ว่าเป็นค่าว่างหรือไม่

            Msg_error("กรุณากรอกเลขบัตรประชาชนลูกค้า")
            Return

        End If

        If txt_cusname.Text = "" Then '## เช็คข้อมูลชื่อลูกค้า ใน Textbox ว่ามีการกรอกหรือไม่

            Msg_error("กรุณากรอกชื่อ-นามสกุลของลูกค้า")
            Return

        End If

        sql = $"SELECT COUNT(*) AS verify FROM EXEACC WHERE ACCKEY = '{cbo_owner.Text}-{txt_cusid.Text}-{dtp_date_receipt.Text}'"

        cmd = New SqlCommand(sql, cn)
        Dim i As Integer = cmd.ExecuteScalar()

        If i < 0 Then '# เช็คข้อมูลในฐานข้อมูลถ้ามีข้อมูลอยู่แล้ว ให้ Update ถ้ายังไม่มี ให้ Insert

            Msg_error("ไม่พบข้อมูลในระบบไม่สามารถแก้ไขข้อมูลได้")
            Return

        End If

        If Msg_confirm("ต้องการอัพเดตข้อมูล ใช่ หรือ ไม่", "แจ้งเตือน") = vbYes Then


            sql = $"UPDATE EXEACC SET ACCKEY = '{cbo_owner.Text}-{txt_cusid.Text}-{_date}',ACCBANK = @bank,ACCIDC = @idc,ACCCUSNAM = @cusname,ACCBLACK = @black,ACCRED = @red,ACCSTATUS = @status,ACCDATE = @date_work,ACCRECEIPT = @total,ACCRECEIPT_DETAIL = @detail,ACCRECEIPT_OTHER_2 = @total2,ACCRECEIPT_OTHER_DETAIL2 = @detail2,ACCRECEIPT_OTHER_3 = @total3,ACCRECEIPT_OTHER_DETAIL3 = @detail3,ACCMONTH = @date_send ,ACCACC = @Acc ,ACCTOWN = @Town,ACCBILLCODE = @Billcode,ACCTYPE = @Type,ACCPRODUCTCODE = @Productcode WHERE ACCKEY = '{Txt_ACC_PK.Text}'"

            cmd.CommandText = sql
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("bank", cbo_owner.Text)
            cmd.Parameters.AddWithValue("idc", txt_cusid.Text)
            cmd.Parameters.AddWithValue("cusname", txt_cusname.Text)
            cmd.Parameters.AddWithValue("black", txt_black.Text)
            cmd.Parameters.AddWithValue("red", txt_red.Text)
            cmd.Parameters.AddWithValue("status", cbo_status.Text)
            cmd.Parameters.AddWithValue("total", txt_total_receipt.Text)
            cmd.Parameters.AddWithValue("detail", txt_detail_receipt.Text)
            cmd.Parameters.AddWithValue("date_work", dtp_date_receipt.Text)
            cmd.Parameters.AddWithValue("total2", txt_total_receipt2.Text)
            cmd.Parameters.AddWithValue("detail2", txt_detail_receipt2.Text)
            cmd.Parameters.AddWithValue("total3", txt_total_receipt3.Text)
            cmd.Parameters.AddWithValue("detail3", txt_detail_receipt3.Text)
            cmd.Parameters.AddWithValue("date_send", dtp_datework.Text)

            ' # ข้อมูลที่ใช้เบิก TSS !

            cmd.Parameters.AddWithValue("Acc", Txt_account.Text)
            cmd.Parameters.AddWithValue("Town", Txt_bank.Text)
            cmd.Parameters.AddWithValue("Billcode", Txt_Billcode.Text)
            cmd.Parameters.AddWithValue("Type", Txt_type.Text)
            cmd.Parameters.AddWithValue("Productcode", Txt_productcode.Text)


            Dim r As Integer = cmd.ExecuteNonQuery()
            If r = -1 Then

                Msg_error("เกิดข้อผิดพลาด ไม่สามารถแก้ไขข้อมูลได้")

            Else

                Msg_OK("แก้ไขข้อมูล สำเร็จ")
                Getlogdataexe($"แก้ไข ข้อมูลตั้งเรื่อง ธนาคาร {cbo_owner.Text} ID CARD {txt_cusid.Text} ชื่อ-นามสกุล {txt_cusname.Text}", $"'{txt_cusid.Text}'", $"'{Txt_account.Text}'")

            End If

            If dtgv_exeacc.Rows.Count <> 0 Then

                dtgv_exeacc.DataSource = Nothing

                Datagrid()
                Readonly_obj()
                cn.Close()
                Txt_ACC_PK.Text = ""
            End If


        End If

    End Sub

    Private Sub Cmd_send_Click(sender As Object, e As EventArgs) Handles cmd_send.Click
        Dim _date As DateTime = dtp_date_receipt.Text
        Dim acckey = $"{cbo_owner.Text}-{txt_cusid.Text}-{_date}"
        Connect()

        If txt_cusid.Text = "" Then

            Msg_error("กรุณากรอกเลขบัตรประชาชนลูกค้า")
            Return

        End If

        If txt_cusname.Text = "" Then

            Msg_error("กรุณากรอกชื่อ-นามสกุลของลูกค้า")
            Return

        End If

        If cbo_status.SelectedIndex = -1 Then

            Msg_error("กรุณากรอกข้อมูลให้ครบ")
            Return

        End If

        Check_CitizenID(txt_cusid)

        sql = $"SELECT COUNT(*) AS verify FROM EXEACC WHERE ACCKEY = '{acckey}'"

        cmd = New SqlCommand(sql, cn)
        Dim i As Integer = cmd.ExecuteScalar()
        If i > 0 Then '# เช็คข้อมูลในฐานข้อมูลถ้ามีข้อมูลอยู่แล้ว ให้ Update ถ้ายังไม่มี ให้ Insert

            Msg_error("มีข้อมูลนี้ในระบบแล้วกรุณาลองใหม่อีกครั้ง")
            Return

        End If

        If Msg_confirm("คุณต้องการเพิ่มข้อมูลใหม่หรือไม่", "แจ้งเตือน") = vbYes Then

            sql = "INSERT INTO EXEACC(ACCKEY,ACCBANK,ACCIDC,ACCCUSNAM,ACCBLACK,ACCRED,ACCSTATUS,ACCDATE,ACCRECEIPT,ACCRECEIPT_DETAIL,ACCRECEIPT_OTHER_2,ACCRECEIPT_OTHER_DETAIL2,ACCRECEIPT_OTHER_3,ACCRECEIPT_OTHER_DETAIL3,ACCMONTH,ACCACC,ACCTOWN,ACCBILLCODE,ACCTYPE,ACCPRODUCTCODE)VALUES(@KEY,@bank,@idc,@cusname,@black,@red,@status,@date_work,@total,@detail,@total2,@detail2,@total3,@detail3,@date_send,@Acc,@Town,@Billcode,@Types,@Productcode)"

            cmd.CommandText = sql
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("KEY", acckey)
            cmd.Parameters.AddWithValue("bank", cbo_owner.Text)
            cmd.Parameters.AddWithValue("idc", txt_cusid.Text)
            cmd.Parameters.AddWithValue("cusname", txt_cusname.Text)
            cmd.Parameters.AddWithValue("black", txt_black.Text)
            cmd.Parameters.AddWithValue("red", txt_red.Text)
            cmd.Parameters.AddWithValue("status", cbo_status.Text)
            cmd.Parameters.AddWithValue("date_work", dtp_date_receipt.Text)
            cmd.Parameters.AddWithValue("total", txt_total_receipt.Text)
            cmd.Parameters.AddWithValue("detail", txt_detail_receipt.Text)
            cmd.Parameters.AddWithValue("total2", txt_total_receipt2.Text)
            cmd.Parameters.AddWithValue("detail2", txt_detail_receipt2.Text)
            cmd.Parameters.AddWithValue("total3", txt_total_receipt3.Text)
            cmd.Parameters.AddWithValue("detail3", txt_detail_receipt3.Text)
            cmd.Parameters.AddWithValue("date_send", dtp_datework.Text)

            ' # ข้อมูลที่ใช้เบิก TSS !

            cmd.Parameters.AddWithValue("Acc", Txt_account.Text)
            cmd.Parameters.AddWithValue("Town", Txt_bank.Text)
            cmd.Parameters.AddWithValue("Billcode", Txt_Billcode.Text)
            cmd.Parameters.AddWithValue("Types", Txt_type.Text)
            cmd.Parameters.AddWithValue("Productcode", Txt_productcode.Text)

            Dim r As Integer = cmd.ExecuteNonQuery()
            If r = -1 Then

                Msg_error("เกิดข้อผิดพลาดไม่สามารถเพิ่มข้อมูลได้")
                cn.Close()
            Else

                Msg_OK("บันทึกข้อมูลสำเร็จ")
                Getlogdataexe($"เพิ่มข้อมูลตั้งเรื่อง {cbo_owner.Text}-{txt_cusid.Text}-{txt_cusname.Text}", $"'{txt_cusid.Text}'", $"'{Txt_account.Text}'")

                Cleartext()
                Countdata("ACCKEY", "EXEACC", lbl_count)
                Cleardatagrid(dtgv_exeacc)
                cn.Close()

            End If

        End If

    End Sub
    '## Event Closing ใช้สำหรับกดปิดหรือสั่งปิดฟอร์มให้ ปิดการเชื่อมต่อของฐานข้อมูลด้วย
    Private Sub FrmEXEACC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Repeat_ClearText()
        cnLegal.Close()
        cn.Close()
        Me.Dispose()

    End Sub
    '## Method Checked ใน Event CheckedChanged ไว้สำหรับเช็คค่าในปัจจุบัน ของ Checkbox ว่าเป็น True หรือ False 
    Private Sub Chk_date_work_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_work.CheckedChanged

        If chk_date_work.Checked = True Then

            dtp_datework.Enabled = True
        Else
            dtp_datework.Enabled = False

        End If

    End Sub
    '## Method Checked ใน Event CheckedChanged ไว้สำหรับเช็คค่าในปัจจุบัน ของ Checkbox ว่าเป็น True หรือ False 
    Private Sub Chk_date_receipt_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date_receipt.CheckedChanged

        If chk_date_receipt.Checked = True Then

            dtp_date_receipt.Enabled = True
        Else
            dtp_date_receipt.Enabled = False

        End If

    End Sub

    Private Sub Cmd_delete_Click(sender As Object, e As EventArgs) Handles cmd_delete.Click

        Cleartext()
        lbl_count_find.Text = "ผลการค้นหา..."
        lbl_count_find.ForeColor = Color.Blue
        dtgv_exeacc.DataSource = Nothing
        dtgv_exeacc.Visible = False
        txt_search.Text = ""

    End Sub

    Private Sub Txt_total_receipt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total_receipt2.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select

    End Sub

    Private Sub Txt_total_receipt3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_total_receipt3.KeyPress

        '## กำหนดให้กรอกได้เฉพาะ ตัวเลข ! คือคีร์ 48 ถึง 57 ส่วน 8 , 13 , 46 ถือ ปุ่ม Backspace Enter Delete ตามลำดับ

        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกเฉพาะตัวเลข")
        End Select


    End Sub

    Private Sub Cmd_Linkdata_Click(sender As Object, e As EventArgs) Handles Cmd_Linkdata.Click

        LinK_Legal()

    End Sub

    Private Sub EXEACC_LoadForm()

        Connect()
        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        Datetimeformatshort(dtp_datework)
        Datetimeformatshort(dtp_date_receipt)

        Cleardatagrid(dtgv_exeacc)

        cbo_status.Items.Clear()
        cbo_owner.Items.Clear()
        cbo_search.Items.Clear()

        Comboboxadd(cbo_status, "ACCSTATUS", "EXEACC")
        cbo_status.SelectedIndex = -1

        Dim header() As String = {"ธนาคาร", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "เลขที่คดีดำ", "เลขที่คดีแดง", "Status"}

        cbo_search.Items.AddRange(header)
        cbo_search.SelectedIndex = 0

        sql = "SELECT DISTINCT ACCBANK FROM EXEACC"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            cbo_owner.Items.Add($"{DR("ACCBANK")}")
        End While

        DR.Close()
        cbo_owner.SelectedIndex = -1

        Countdata("ACCKEY", "EXEACC", lbl_count)

        cn.Close()
        Readonly_obj()

        dtgv_exeacc.Visible = False



    End Sub

    '############################### RepeatFreeze อายัดซ้ำ ####################################'

    Private Sub Repeat_LoadForm()

        Repeat_ClearText()

        Connect()

        Comboboxadd(Cbo_Repeat_Status, "RepeatFreeze_types", "Execution_RepeatFreeze")
        Cbo_Repeat_Status.SelectedIndex = -1
        Comboboxadd(Cbo_Repeat_product, "Customer_Owner", "Execution_RepeatFreeze")
        Cbo_Repeat_product.SelectedIndex = -1

        sql = "SELECT DISTINCT EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '02-EXECUTION';"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            Cbo_Repeat_EmpExe.Items.Add($"{DR("EXEEMPLOYEES")}")
        End While

        DR.Close()
        Cbo_Repeat_EmpExe.SelectedIndex = -1


        Countdata("RepeatFreeze_PK", "Execution_RepeatFreeze", Lbl_Repeat_Count)

        Datetimeformatshort(Dtp_Repeat_DateSheet)

        Datetimeformatshort(Dtp_Repeat_DateWork)

        Dim Repeat_Combobox() As String = {"ธนาคาร", "เลขบัตรประชาชน", "ชื่อลูกค้า", "นามสกุล", "ชื่อ-นามสกุล", "เลขที่คดีแดง", "Status"}

        CboArray(Cbo_Repeat_find, Repeat_Combobox)


    End Sub

    Private Sub Repeat_ClearText()

        Dim TextArray() As TextBox = {Txt_Repeat_Acc, Txt_Repeat_Bank, Txt_Repeat_Billcode, Txt_Repeat_Black, Txt_Repeat_Court, Txt_Repeat_Detail, Txt_Repeat_find, Txt_Repeat_FN, Txt_Repeat_Idc, Txt_Repeat_LN, Txt_Repeat_Red, Txt_Repeat_Type, Txt_Repeat_Block}

        Dim CheckbokArray() As CheckBox = {Chk_Repeat_DateSheet, Chk_Repeat_DateWork}

        Dim ComboboxArray() As ComboBox = {Cbo_Repeat_EmpExe, Cbo_Repeat_find, Cbo_Repeat_product, Cbo_Repeat_Status}

        For _Combobox As Integer = 0 To ComboboxArray.Length - 1

            ComboboxArray(_Combobox).Text = ""
        Next

        For i = 0 To TextArray.Length - 1

            TextArray(i).Text = ""

        Next

        For i = 0 To CheckbokArray.Length - 1

            CheckbokArray(i).Checked = False

        Next

        Cleardatagrid(Dtgv_Repeat_find)

        Dtp_Repeat_DateSheet.Text = ""
        Dtp_Repeat_DateWork.Text = ""

    End Sub

    Private Sub Edit_information()


        Dim TextArray() As TextBox = {Txt_Repeat_Acc, Txt_Repeat_Bank, Txt_Repeat_Billcode, Txt_Repeat_Black, Txt_Repeat_Court, Txt_Repeat_Detail, Txt_Repeat_FN, Txt_Repeat_Idc, Txt_Repeat_LN, Txt_Repeat_Red, Txt_Repeat_Type, Txt_Repeat_Block}

        Dim CheckbokArray() As CheckBox = {Chk_Repeat_DateSheet, Chk_Repeat_DateWork}


        Dim ComboboxArray() As ComboBox = {Cbo_Repeat_EmpExe, Cbo_Repeat_find, Cbo_Repeat_product, Cbo_Repeat_Status}

        For ObjEnabled = 0 To ComboboxArray.Length - 1

            ComboboxArray(ObjEnabled).Enabled = True

        Next

        For ReadText = 0 To TextArray.Length - 1

            TextArray(ReadText).ReadOnly = False

        Next

        For ObjCheckBox = 0 To CheckbokArray.Length - 1

            CheckbokArray(ObjCheckBox).Enabled = True

        Next


    End Sub

    Private Sub NotEdit_information()

        Dim ComboboxArray() As ComboBox = {Cbo_Repeat_EmpExe, Cbo_Repeat_product, Cbo_Repeat_Status}


        Dim TextArray() As TextBox = {Txt_Repeat_Acc, Txt_Repeat_Bank, Txt_Repeat_Billcode, Txt_Repeat_Black, Txt_Repeat_Court, Txt_Repeat_Detail, Txt_Repeat_FN, Txt_Repeat_Idc, Txt_Repeat_LN, Txt_Repeat_Red, Txt_Repeat_Type, Txt_Repeat_Block}

        Dim CheckbokArray() As CheckBox = {Chk_Repeat_DateSheet, Chk_Repeat_DateWork}


        For ObjEnabled = 0 To ComboboxArray.Length - 1

            ComboboxArray(ObjEnabled).Enabled = False

        Next

        For ReadText = 0 To TextArray.Length - 1

            TextArray(ReadText).ReadOnly = True

        Next

        For ObjCheckBox = 0 To CheckbokArray.Length - 1

            CheckbokArray(ObjCheckBox).Enabled = False

        Next

        Dtp_Repeat_DateSheet.Enabled = False
        Dtp_Repeat_DateWork.Enabled = False

    End Sub

    Private Sub Find_RepeatFreeze()

        Connect()
        Dim Repeat_entity() As String = {"Product", "เลขบัตรประชาชน", "เลขที่สัญญา", "ชื่อ-นามสกุล", "เลขที่คดีแดง", "Status", "พนักงานบังคับคดี", "วันที่ในใบคำร้อง"}


        Cleardatagrid(Dtgv_Repeat_find)

        If Txt_Repeat_find.Text = "" Then
            Msg_error("กรุณากรอกข้อมุลที่ต้องการค้นหา")
            Return
        End If

        sql = $"SELECT ERF.Customer_Owner,ERF.Customer_id_card,ERF.Customer_Account,ERF.Customer_fullname,ERF.RepeatFreeze_Red,ERF.RepeatFreeze_types,EMP.EXEEMPLOYEES,ERF.RepeatFreeze_Date_Sheet FROM Execution_RepeatFreeze AS ERF LEFT JOIN EXEEMPLOYEE AS EMP ON ERF.EMPLOYEES_KEY = EMP.EMPLOYEES_KEY "

        Select Case Cbo_Repeat_find.SelectedItem

            Case "ธนาคาร" : sql &= $"WHERE ERF.Customer_Owner"
            Case "เลขที่สัญญา" : sql &= $"WHERE ERF.Cusromer_Account"
            Case "เลขบัตรประชาชน" : sql &= $"WHERE ERF.Customer_id_card"
            Case "ชื่อ-นามสกุล" : sql &= $"WHERE ERF.Customer_fullname"
            Case "ชื่อลูกค้า" : sql &= "WHERE ERF.Customer_firstname"
            Case "นามสกุล" : sql &= "WHERE ERF.Customer_lastname"
            Case "เลขที่คดีแดง" : sql &= $"WHERE ERF.RepeatFreeze_Red"
            Case "Status" : sql &= $"WHERE ERF.RepeatFreeze_types"

        End Select

        sql &= $" LIKE '%{Txt_Repeat_find.Text}%' ORDER BY RepeatFreeze_date_sheet"


        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "_search")

        If DS.Tables("_search").Rows.Count <= 0 Then

            Lbl_Repeat_Find.Text = "ไม่พบข้อมูลที่ค้นหา.."
            Lbl_Repeat_Find.ForeColor = Color.Red
            Dtgv_Repeat_find.Visible = False
            Return

        Else

            With Dtgv_Repeat_find
                .DataSource = DS.Tables("_search")

                For i = 0 To Repeat_entity.Length - 1

                    .Columns(i).HeaderText = Repeat_entity(i)

                Next

            End With

            Dtgv_Repeat_find.Visible = True
            Datagrid_format_dateshort(Dtgv_Repeat_find, 6)

            Lbl_Repeat_Find.Text = $"พบข้อมูล {Dtgv_Repeat_find.RowCount} รายการ.."
            Lbl_Repeat_Find.ForeColor = Color.Green

        End If

        cn.Close()

    End Sub

    Private Sub Dtgv_Repeat_find_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgv_Repeat_find.CellClick

        Connect()

        'Dim Fullname() As String = Dtgv_Repeat_find.CurrentRow.Cells(3).Value.ToString.Split(" ")

        'Txt_Repeat_FN.Text = Fullname(0)
        'Txt_Repeat_LN.Text = Fullname(1)

        With Dtgv_Repeat_find

            Cbo_Repeat_product.Text = .CurrentRow.Cells(0).Value.ToString
            Txt_Repeat_Idc.Text = .CurrentRow.Cells(1).Value.ToString
            Txt_Repeat_Acc.Text = .CurrentRow.Cells(2).Value.ToString
            Txt_Repeat_Red.Text = .CurrentRow.Cells(4).Value.ToString
            Cbo_Repeat_Status.Text = .CurrentRow.Cells(5).Value.ToString
            Cbo_Repeat_EmpExe.Text = .CurrentRow.Cells(6).Value.ToString
            Dtp_Repeat_DateSheet.Text = .CurrentRow.Cells(7).Value.ToString

        End With

        sql = $"SELECT RepeatFreeze_PK,Customer_firstname,Customer_lastname,RepeatFreeze_Court,RepeatFreeze_Detail,RepeatFreeze_Date_work FROM Execution_RepeatFreeze WHERE Customer_account = '{Dtgv_Repeat_find.CurrentRow.Cells(2).Value}' AND Customer_owner = '{Dtgv_Repeat_find.CurrentRow.Cells(0).Value}' "

        cmd = New SqlCommand(sql, cn)
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "Queryfind")

        With DS.Tables("Queryfind")

            Txt_Repeact_PK.Text = Int(.Rows(0)("RepeatFreeze_PK"))
            Txt_Repeat_FN.Text = .Rows(0)("Customer_firstname").ToString
            Txt_Repeat_LN.Text = .Rows(0)("Customer_lastname").ToString
            Txt_Repeat_Court.Text = .Rows(0)("RepeatFreeze_Court").ToString
            Txt_Repeat_Detail.Text = .Rows(0)("RepeatFreeze_Detail").ToString
            Dtp_Repeat_DateWork.Text = .Rows(0)("RepeatFreeze_Date_work").ToString


            If Dtgv_Repeat_find.CurrentRow.Cells(7).Value.ToString = "" Then

                Chk_Repeat_DateSheet.Checked = False
            Else
                Chk_Repeat_DateSheet.Checked = True

            End If

            If .Rows(0)("RepeatFreeze_Date_work").ToString = "" Then

                Chk_Repeat_DateWork.Checked = False
            Else
                Chk_Repeat_DateSheet.Checked = True

            End If

            cn.Close()

        End With

    End Sub

    Private Sub Queryinsertsql()

        If Msg_confirm("คุณต้องการเพิ่มข้อมูลอายัดซ้ำ ใช่ หรือ ไม่") = vbYes Then

            Connect()

            sql = $"SELECT EMPLOYEES_KEY FROM EXEEMPLOYEE WHERE EXEEMPLOYEES = '{Cbo_Repeat_EmpExe.Text}'"
            cmd = New SqlCommand(sql, cn)
            Dim queryemp As Integer = cmd.ExecuteScalar
            'DA = New SqlDataAdapter(cmd)
            'DS = New DataSet
            'DA.Fill(DS, "queryemp")
            'Dim queryemp As Integer = DS.Tables("queryemp").Rows(0)("EMPLOYEES_KEY")

            sql = $"INSERT INTO Execution_RepeatFreeze(Customer_Owner,Customer_id_card,Customer_Account,Customer_firstname,Customer_lastname,Customer_fullname,RepeatFreeze_court,RepeatFreeze_red,EMPLOYEES_KEY,RepeatFreeze_types,RepeatFreeze_Detail,RepeatFreeze_date_sheet,RepeatFreeze_date_work,RepeatFreeze_Status)VALUES('{Cbo_Repeat_product.Text}','{Txt_Repeat_Idc.Text}','{Txt_Repeat_Acc.Text}','{Txt_Repeat_FN.Text}','{Txt_Repeat_LN.Text}','{Txt_Repeat_FN.Text} {Txt_Repeat_LN.Text}','{Txt_Repeat_Court.Text}','{Txt_Repeat_Red.Text}',{queryemp},'{Cbo_Repeat_Status.Text}','{Txt_Repeat_Detail.Text}','{Dtp_Repeat_DateSheet.Text}','{Dtp_Repeat_DateWork.Text}','ไม่ได้ตั้งเรื่อง')"

            cmd = New SqlCommand(sql, cn)
            Dim Queryinsert As Integer = cmd.ExecuteNonQuery()

            If Queryinsert > 0 Then

                Lbl_Repeat_Link.Text = $"เพิ่มข้อมูล {Queryinsert} รายการ"
                Lbl_Repeat_Link.ForeColor = Color.Green
                Getlogdataexe($"เพิ่มข้อมูล อายัดซ้ำ Product{Cbo_Repeat_product.Text} ชื่อ-นามสกุล {Txt_Repeat_FN.Text} {Txt_Repeat_LN.Text} Status {Cbo_Repeat_Status.Text}", $"'{Txt_Repeat_Idc.Text}'", $"'{Txt_Repeat_Acc.Text}'")
                Repeat_ClearText()

            Else

                Lbl_Repeat_Link.Text = $"เพิ่มข้อมูล ล้มเหลว"
                Lbl_Repeat_Link.ForeColor = Color.Red

            End If
            cn.Close()

        End If

    End Sub

    Private Sub Cmd_Repeat_Clear_Click(sender As Object, e As EventArgs) Handles Cmd_Repeat_Clear.Click

        Repeat_ClearText()

    End Sub

    Private Sub Chk_Repeat_DateSheet_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Repeat_DateSheet.CheckedChanged

        Checkboxdatetime(Chk_Repeat_DateSheet, Dtp_Repeat_DateSheet)

    End Sub

    Private Sub Chk_Repeat_DateWork_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Repeat_DateWork.CheckedChanged

        Checkboxdatetime(Chk_Repeat_DateWork, Dtp_Repeat_DateWork)

    End Sub

    Private Sub Cmd_Repeat_Edit_Click(sender As Object, e As EventArgs) Handles Cmd_Repeat_Edit.Click

        Edit_information()

    End Sub

    Private Sub Cmd_Repeat_find_Click(sender As Object, e As EventArgs) Handles Cmd_Repeat_find.Click

        Find_RepeatFreeze()

    End Sub

    Private Sub Cmd_Repeat_Link_Click(sender As Object, e As EventArgs) Handles Cmd_Repeat_Link.Click

        Link_Data()

    End Sub


    Private Sub Cmd_Repeat_Update_Click(sender As Object, e As EventArgs) Handles Cmd_Repeat_Update.Click

        Check_CitizenID(Txt_Repeat_Idc)

        QueryUpdate_()


    End Sub


    Private Sub Cmd_Repeat_Add_Click(sender As Object, e As EventArgs) Handles Cmd_Repeat_Add.Click

        Check_CitizenID(Txt_Repeat_Idc)

        If Txt_Repeat_Acc.Text = "" OrElse Cbo_Repeat_product.Text = "" OrElse Cbo_Repeat_EmpExe.Text = "" OrElse Cbo_Repeat_Status.Text = "" Then

            Msg_error("กรุณากรอก เลขที่สัญญา โปรดัก ชื่อพนักงานบังคับคดี Status ให้ครบ " & vbNewLine & " แล้วลองอีกครั้ง")
            Return

        Else
            Connect()

            sql = $"SELECT COUNT(Customer_Account) FROM Execution_RepeatFreeze WHERE Customer_Account = '{Txt_Repeat_Acc.Text}' AND RepeatFreeze_date_sheet = '{Dtp_Repeat_DateSheet.Text}' "
            cmd = New SqlCommand(sql, cn)
            Dim RepeatQuery As Integer = cmd.ExecuteScalar()

            If RepeatQuery > 0 Then

                Msg_error("มีข้อมูลนี้อยู่แล้วในระบบกรุณาตรวจสอบอีกครั้ง")

                Exit Sub

            Else

                Queryinsertsql()


            End If

        End If

    End Sub

    Private Sub Cmd_Repeat_Cancel_Click(sender As Object, e As EventArgs) Handles Cmd_Repeat_Cancel.Click

        NotEdit_information()

    End Sub
    Private Sub QueryUpdate_()

        Connect()

        Dim Customer_Fullname As String = $"{Txt_Repeat_FN.Text} {Txt_Repeat_LN.Text}"

        sql = $"SELECT EMPLOYEES_KEY FROM EXEEMPLOYEE WHERE EXEEMPLOYEES = '{Cbo_Repeat_EmpExe.Text}'"
        cmd = New SqlCommand(sql, cn)
        Dim Query_empkey As Integer = cmd.ExecuteScalar()

        sql = $"UPDATE Execution_RepeatFreeze SET Customer_OWner = @owner,Customer_id_card = @idcard,Customer_account = @account,Customer_firstname = @firstname,Customer_lastname = @lastname,Customer_fullname = @fullname,RepeatFreeze_Court = @Court,RepeatFreeze_red = @red ,EMPLOYEES_KEY = @EmpPK ,RepeatFreeze_types = @status ,RepeatFreeze_Detail = @detail,RepeatFreeze_date_sheet = @datesheet , RepeatFreeze_date_work = @datework WHERE RepeatFreeze_PK = @RPK;"


        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("RPK", Txt_Repeact_PK.Text)
        cmd.Parameters.AddWithValue("owner", Cbo_Repeat_product.Text)
        cmd.Parameters.AddWithValue("idcard", Txt_Repeat_Idc.Text)
        cmd.Parameters.AddWithValue("account", Txt_Repeat_Acc.Text)
        cmd.Parameters.AddWithValue("firstname", Txt_Repeat_FN.Text)
        cmd.Parameters.AddWithValue("lastname", Txt_Repeat_LN.Text)
        cmd.Parameters.AddWithValue("fullname", Customer_Fullname)
        cmd.Parameters.AddWithValue("Court", Txt_Repeat_Court.Text)
        cmd.Parameters.AddWithValue("red", Txt_Repeat_Red.Text)
        cmd.Parameters.AddWithValue("EmpPK", Query_empkey)
        cmd.Parameters.AddWithValue("status", Cbo_Repeat_Status.Text)
        cmd.Parameters.AddWithValue("detail", Txt_Repeat_Detail.Text)
        cmd.Parameters.AddWithValue("datesheet", Dtp_Repeat_DateSheet.Text)
        cmd.Parameters.AddWithValue("datework", Dtp_Repeat_DateWork.Text)

        Dim Queryupdate As Integer = cmd.ExecuteNonQuery()

        If Queryupdate > 0 Then

            Lbl_Repeat_Link.Text = "แก้ไขข้อมูลสำเร็จ " & Queryupdate.ToString & "รายการ"
            Lbl_Repeat_Link.ForeColor = Color.Green

            Getlogdataexe($"แก้ไขข้อมูล อายัดซ้ำ {Cbo_Repeat_product.Text} {Txt_Repeat_FN.Text} {Txt_Repeat_LN.Text} สถานะ {cbo_status.Text}", $"'{Txt_Repeat_Idc.Text}'", $"'{Txt_Repeat_Acc.Text}'")

        Else
            Lbl_Repeat_Link.Text = "แก้ไขล้มเหลว"
            Lbl_Repeat_Link.ForeColor = Color.Red

        End If

        cn.Close()

    End Sub
    Private Sub Link_Data()

        Select Case Cbo_Repeat_product.SelectedItem

            Case "KBANK" : Connect_(cn_KBANK)
                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Repeat_Acc.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CACC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green

                Else
                    sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Repeat_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CIDC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green

                End If

                cn_KBANK.Close()

            Case "KKB " : Connect_(cn_KKB)
                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Repeat_Acc.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_KKB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CACC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green


                Else
                    sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Repeat_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_KKB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CIDC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green

                End If

                cn_KKB.Close()

            Case "SCB" : Connect_(cn_SCB)
                sqll = $"SELECT RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSBLK,RFCUS.CUSTLN,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Repeat_Acc.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_SCB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then


                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CACC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green


                Else

                    sqll = $"SELECT RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Repeat_Idc.Text}'"
                    cmd_Collec = New SqlCommand(sqll, cn_SCB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CIDC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green

                End If

                cn_SCB.Close()

            Case "TSS" : Connect_(cn_GE)
                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFCUS.CUSBLK,RFLAW.LAWRED,RFLAW.LAWSAN,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Repeat_Acc.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_GE)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then


                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CACC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green

                Else

                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Repeat_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_GE)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                        Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                        Lbl_Repeat_Link.Text = $"พบ CIDC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Green

                    Else

                        Lbl_Repeat_Link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Red

                    End If

                End If

                cn_GE.Close()

            Case "TMB" : Connect_(cn_TMB)
                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Repeat_Acc.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TMB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then


                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CACC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green

                Else
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Repeat_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                        Lbl_Repeat_Link.Text = $"พบ CIDC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Green

                    Else

                        Lbl_Repeat_Link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Red

                    End If

                End If
                    cn_TMB.Close()

            Case "TMB SME" : Connect_(cn_TMBSME)
                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Repeat_Acc.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TMB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CACC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green

                Else
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Repeat_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                        Lbl_Repeat_Link.Text = $"พบ CIDC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Green

                    Else

                        Lbl_Repeat_Link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Red

                    End If
                End If

                    cn_TMBSME.Close()

            Case "TBANK" : Connect_(cn_TBANK)

                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Txt_Repeat_Acc.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TMB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CACC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green
                Else
                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Repeat_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                        Lbl_Repeat_Link.Text = $"พบ CIDC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Green

                    Else

                        Lbl_Repeat_Link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Red

                End If
                End If
                cn_TBANK.Close()

            Case "UOB" : Connect_(cn_UOB)

                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Repeat_Acc.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TMB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                    Lbl_Repeat_Link.Text = $"พบ CACC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green

                Else

                    sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Repeat_Acc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Txt_Repeat_Acc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Repeat_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Repeat_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Repeat_FN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Repeat_LN.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Repeat_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Repeat_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Repeat_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString

                        Lbl_Repeat_Link.Text = $"พบ CIDC{DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Green

                    Else

                        Lbl_Repeat_Link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Red

                    End If

                End If

                    cn_UOB.Close()

            Case Else : Connect_(cnLegal)

                sqll = $"Select dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSIDC = '{Txt_Repeat_Idc.Text}'"
                cmdlegal = New SqlCommand(sqll, cnLegal)
                DALegal = New SqlDataAdapter(cmdlegal)
                DSLegal = New DataSet
                DALegal.Fill(DSLegal, "linklegal")

                If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                    Lbl_Repeat_Link.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Red

                    Txt_Repeat_FN.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                    Txt_Repeat_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                    Txt_Repeat_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                    Txt_Repeat_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                    Txt_Repeat_Acc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                    Txt_Repeat_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString

                    Lbl_Repeat_Link.Text = $"พบ LIDC{DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                    Lbl_Repeat_Link.ForeColor = Color.Green



                Else
                    sqll = $"Select dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Txt_Repeat_Acc.Text}'"
                    cmdlegal = New SqlCommand(sqll, cnLegal)
                    DALegal = New SqlDataAdapter(cmdlegal)
                    DSLegal = New DataSet
                    DALegal.Fill(DSLegal, "linklegal")

                    If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                        Txt_Repeat_FN.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                        Txt_Repeat_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                        Txt_Repeat_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                        Txt_Repeat_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                        Txt_Repeat_Acc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                        Txt_Repeat_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString

                        Lbl_Repeat_Link.Text = $"พบ LACC{DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Green
                    Else

                        Lbl_Repeat_Link.Text = $"พบ {DSLegal.Tables("Linklegal").Rows.Count} รายการ"
                        Lbl_Repeat_Link.ForeColor = Color.Red

                    End If
                End If

                    cnLegal.Close()

        End Select

    End Sub

End Class