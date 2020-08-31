Imports System.Data
Imports System.Data.SqlClient
Public Class FrmsaveWDS

    Private Sub FrmsaveWDS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        Datetimeformatshort(dtp_datecollector)
        Datetimeformatshort(dtp_datewds)
        Datetimeformatshort(dtp_payment)

        cbo_owner.Items.Clear()
        Dim Owner() As String = {"KBANK", "TMB", "SCB", "TSS", "TBANK", "KKB", "UOB"}
        cbo_owner.Items.AddRange(Owner)
        cbo_owner.SelectedItem = 0

        cbo_empadmin.Items.Clear()
        sql = "SELECT EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '01-SUPPORT'"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()
        While DR.Read()
            cbo_empadmin.Items.Add($"{DR("EXEEMPLOYEES")}")
        End While
        DR.Close()
        cbo_empadmin.SelectedItem = 0


        cbo_empexe.Items.Clear()
        sql = "SELECT EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '02-EXECUTION'"
        cmd.CommandText = sql
        DR = cmd.ExecuteReader()
        While DR.Read()
            cbo_empexe.Items.Add($"{DR("EXEEMPLOYEES")}")
        End While
        DR.Close()
        cbo_empexe.SelectedItem = 0


        cbo_hub.Items.Clear()
        sql = "SELECT HUBS FROM HUBS"
        cmd.CommandText = sql
        DR = cmd.ExecuteReader()
        While DR.Read()
            cbo_hub.Items.Add($"{DR("HUBS")}")
        End While
        DR.Close()
        cbo_hub.SelectedItem = 0

        dtp_datecollector.Enabled = False
        dtp_datewds.Enabled = False
        dtp_payment.Enabled = False

        cn.Close()

    End Sub
    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Connect()

        If txt_cusid.Text = "" Or txt_cusname.Text = "" Or txt_red.Text = "" Or txt_cusacc.Text = "" Then
            Msg_error("กรุณาใส่ข้อมูลให้ครบ")

        Else

            If Msg_confirm("คุณต้องการเพิ่มข้อมูลใช่หรือไม่", "แจ้งเตือน") = vbYes Then

                sql = $"SELECT EXECUSACC,EXECUSIDC FROM EXEWDS WHERE EXECUSACC = '{txt_cusacc.Text}' AND EXECUSIDC = '{txt_cusid.Text}' "

                cmd = New SqlCommand(sql, cn)
                DA = New SqlDataAdapter(cmd)
                DS = New DataSet

                DA.Fill(DS, "table")
                If DS.Tables("table").Rows.Count > 0 Then

                    Msg_error("มีข้อมูลนี้ในระบบแล้ว")
                    Return

                End If

                sql = $"INSERT INTO EXEWDS(EXEKEY,EXECUSOWN,EXEHUBS,EXEDATECOLLEC,EXECUSIDC,EXECUSCUS,EXECUSACC,EXECUSNAM,EXECUSBLACK,EXECUSRED,EXEDATEPAY,EXETOTAL,EXECUSPHONE,EXESTATUS,EXEADMIN,EXEEMPLOYEE,EXEDATEWDS,EXEDETAILWDS)VALUES('{cbo_owner.Text}-{txt_cusacc.Text}','{cbo_owner.Text}','{cbo_hub.Text}'"
                If chk_datecollector.Checked = True Then
                    sql &= $",'{dtp_datecollector.Text}'"
                Else
                    sql &= $",NULL"
                End If
                sql &= $",'{txt_cusid.Text}','{txt_cuscus.Text}','{txt_cusacc.Text}','{txt_cusname.Text}','{txt_black.Text}','{txt_red.Text}'"
                If chk_datepayment.Checked = True Then
                    sql &= $",'{dtp_payment.Text}'"
                Else
                    sql &= $",NULL"
                End If
                sql &= $",'{txt_payment.Text}','{txt_cusphone.Text}','{txt_status.Text}','{cbo_empadmin.Text}','{cbo_empexe.Text}',"
                If chk_datewds.Checked = True Then
                    sql &= $"'{dtp_datewds.Text}','{txt_detail.Text}')"
                Else
                    sql &= $"NULL,'{txt_detail.Text}')"
                End If

                cmd = New SqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

                Getlogdataexe($"เพิ่มข้อมูล ถอนอายัดยึด IDCARD {txt_cusid.Text} ชื่อลูกค้า {txt_cusname.Text} ธนาคาร {cbo_owner.Text}", $"'{txt_cusid.Text}'", $"'{txt_cusacc.Text}'")

                FrmWDS.Refrom_Obj()

                Msg_OK("บันทึกข้อมูลสำเร็จ")

                cn.Close()

                If Msg_confirm("คุณต้องการเพิ่มข้อมูลต่อไปหรือไม่", "แจ้งเตือน") = vbYes Then

                    refroms()

                Else

                    refroms()
                    Me.Close()

                End If

            End If

        End If


    End Sub
    Private Sub Btn_savecancel_Click(sender As Object, e As EventArgs) Handles btn_savecancel.Click

        Me.Close()
        FrmWDS.Refrom_Obj()

    End Sub

    Private Sub Txt_payment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_payment.KeyPress
        Select Case Asc(e.KeyChar)

            Case 48 To 57 '// key code ของตัวเลขจะอยู่ระหว่าง 48 ถึง 57 ซึ่ง 48 คือเลข 0 57 คือเลข 9 ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 '// ปุ่ม backspace = 8,ปุ่ม enter = 13,ปุ่ม delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกตัวเลข")

        End Select

    End Sub

    Private Sub Txt_refund_KeyPress(sender As Object, e As KeyPressEventArgs)

        Select Case Asc(e.KeyChar)
            Case 48 To 57 '// key code ของตัวเลขจะอยู่ระหว่าง 48 ถึง 57 ซึ่ง 48 คือเลข 0 57 คือเลข 9 ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 '// ปุ่ม backspace = 8,ปุ่ม enter = 13,ปุ่ม delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกตัวเลข")
        End Select
    End Sub

    Private Sub Chk_datecollector_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datecollector.CheckedChanged

        If chk_datecollector.Checked = True Then

            dtp_datecollector.Enabled = True

        Else

            dtp_datecollector.Enabled = False

        End If

    End Sub

    Private Sub Chk_datewds_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datewds.CheckedChanged


        If chk_datewds.Checked = True Then

            dtp_datewds.Enabled = True

        Else

            dtp_datewds.Enabled = False

        End If

    End Sub

    Private Sub Chk_datepayment_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datepayment.CheckedChanged


        If chk_datepayment.Checked = True Then

            dtp_payment.Enabled = True

        Else

            dtp_payment.Enabled = False

        End If

    End Sub

    Private Sub Cmd_Link_Collector_Click(sender As Object, e As EventArgs) Handles Cmd_Link_Collector.Click


        If txt_cusacc.Text = "" Or cbo_owner.SelectedIndex = -1 Then

            Msg_error("กรุณากรอก โปรดัก และ เลขที่สัญญาเพื่อดึงข้อมูล")
            Exit Sub
        Else
            Link_Data()

        End If



    End Sub
    Private Sub Link_Data()

        Select Case cbo_owner.SelectedItem

            Case "KKB" : Connect_(cn_KKB)
                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{txt_cusacc.Text}' "
                cmd_Collec = New SqlCommand(sqll, cn_KKB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count <= 0 Then

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Red
                Else

                    txt_cusacc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_cuscus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    txt_black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString


                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Green
                End If

                cn_KKB.Close()

            Case "SCB" : Connect_(cn_SCB)
                sqll = $"SELECT RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{txt_cusacc.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_SCB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count <= 0 Then

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Red
                Else

                    txt_cusacc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_cuscus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString & " " & DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    txt_black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Green
                End If
                cn_SCB.Close()

            Case "TSS" : Connect_(cn_GE)

                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{txt_cusacc.Text}' "

                cmd_Collec = New SqlCommand(sqll, cn_GE)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count <= 0 Then

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Red
                Else

                    txt_cusacc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString

                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString & " " & DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    txt_black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString


                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Green
                End If
                cn_GE.Close()

            Case "TMB" : Connect_(cn_TMB)
                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{txt_cusacc.Text}' "

                cmd_Collec = New SqlCommand(sqll, cn_TMB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count <= 0 Then

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Red
                Else
                    txt_cusacc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString

                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString & " " & DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    txt_black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString


                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Green
                End If
                cn_TMB.Close()

            Case "TMBSME" : Connect_(cn_TMBSME)
                sqll = $"SELECT RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{txt_cusacc.Text}' "
                cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count <= 0 Then

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Red
                Else

                    txt_cusacc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString

                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString & " " & DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    txt_black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Green
                End If
                cn_TMBSME.Close()

            Case "TBANK" : Connect_(cn_TBANK)
                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{txt_cusacc.Text}' "
                cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count <= 0 Then

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Red
                Else
                    txt_cusacc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_cuscus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString & " " & DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    txt_black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Green
                End If
                cn_TBANK.Close()

            Case "UOB" : Connect_(cn_UOB)
                sqll = $"SELECT RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFLAW.LAWRED,RFLAW.LAWBLK FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{txt_cusacc.Text}' "

                cmd_Collec = New SqlCommand(sqll, cn_UOB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count <= 0 Then

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LINKdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Red
                Else

                    txt_cusacc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    txt_cuscus.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                    txt_cusid.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    txt_cusname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString & " " & DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    txt_black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    txt_red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString

                    lbl_link.Text = $"พบ {DS_Collec.Tables("LinkdB").Rows.Count} รายการ"
                    lbl_link.ForeColor = Color.Green

                End If
                cn_UOB.Close()

        End Select

    End Sub
    Public Sub Refroms()

        txt_payment.Text = ""
        txt_black.Text = ""
        cbo_empadmin.Text = ""
        cbo_empexe.Text = ""
        cbo_hub.Text = ""
        txt_cusphone.Text = ""
        cbo_owner.Text = ""
        txt_cusid.Text = ""
        txt_cusacc.Text = ""
        txt_cuscus.Text = ""
        txt_cusname.Text = ""
        txt_red.Text = ""
        txt_status.Text = ""
        dtp_datewds.Text = ""
        txt_detail.Text = ""
        dtp_datecollector.Text = ""
        chk_datecollector.Checked = False
        chk_datewds.Checked = False
        chk_datepayment.Checked = False

        If chk_datewds.Checked = False Then

            dtp_datewds.Enabled = False

        End If

        If chk_datecollector.Checked = False Then

            dtp_datecollector.Enabled = False

        End If

        If chk_datepayment.Checked = False Then

            dtp_payment.Enabled = False

        End If

    End Sub

End Class