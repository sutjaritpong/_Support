Imports System.Data
Imports System.Data.SqlClient
Public Class FrmsaveWDS

    Private Sub FrmsaveWDS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        _Datetimeformatshort(dtp_datecollector)
        _Datetimeformatshort(dtp_datewds)
        _Datetimeformatshort(dtp_payment)

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
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        connect()

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

                _sql = $"Select * FROM tbl_login WHERE USERID = '{FrmLogin.txt_idlog.Text}'"
                cmd = New SqlCommand(_sql, cn)
                DA = New SqlDataAdapter(cmd)
                DA.Fill(DS, "Fullname")

                sql = ($"INSERT INTO tbl_logfiles(LOGDATE,LOGUSER,LOGNAME,LOGIP,LOGPCNAME,LOGDETAIL)VALUES(GETDATE(),'{FrmLogin.txt_idlog.Text}','{DS.Tables("Fullname").Rows(0)("USRNAME")}','{FrmLogin.aws.LocalIP}','{pc}','เพิ่มข้อมูลลูกค้า ธนาคาร {cbo_owner.Text} เลขที่สัญญา {txt_cusacc.Text} ชื่อ {txt_cusname.Text} สถานะ {txt_status.Text}')")

                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

                FrmWDS.refrom()

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
    Private Sub btn_savecancel_Click(sender As Object, e As EventArgs) Handles btn_savecancel.Click

        Me.Close()
        FrmWDS.refrom()

    End Sub

    Private Sub txt_payment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_payment.KeyPress
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

    Private Sub txt_refund_KeyPress(sender As Object, e As KeyPressEventArgs)

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

    Private Sub chk_datecollector_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datecollector.CheckedChanged

        If chk_datecollector.Checked = True Then

            dtp_datecollector.Enabled = True

        Else

            dtp_datecollector.Enabled = False

        End If

    End Sub

    Private Sub chk_datewds_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datewds.CheckedChanged


        If chk_datewds.Checked = True Then

            dtp_datewds.Enabled = True

        Else

            dtp_datewds.Enabled = False

        End If

    End Sub

    Private Sub chk_datepayment_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datepayment.CheckedChanged


        If chk_datepayment.Checked = True Then

            dtp_payment.Enabled = True

        Else

            dtp_payment.Enabled = False

        End If

    End Sub
    Public Sub refroms()

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