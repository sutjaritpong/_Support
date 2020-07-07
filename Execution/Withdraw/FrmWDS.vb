Option Explicit On
Imports System.Data.SqlClient
Imports System.Data
Imports System.DBNull
Public Class FrmWDS


    Private Sub FrmWDS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        _Datetimeformatshort(dtp_datecollector)
        _Datetimeformatshort(dtp_daterefund)
        _Datetimeformatshort(dtp_datewds)
        _Datetimeformatshort(dtp_payment)
        _Datetimeformatshort(datetimestart)
        _Datetimeformatshort(datetimefinish)


        Dim types() As String = {"ALL PRODUCT", "KBANK", "TMB", "SCB", "TSS", "TBANK", "KKB", "UOB"}
        cbo_product.Items.AddRange(types)
        cbo_product.SelectedIndex = 0

        Dim Owner() As String = {"KBANK", "TMB", "SCB", "TSS", "TBANK", "KKB", "UOB"}
        cbo_owner.Items.AddRange(Owner)
        cbo_owner.SelectedItem = 0

        sql = "SELECT DISTINCT EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '01-SUPPORT'"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            cbo_empadmin.Items.Add($"{DR("EXEEMPLOYEES")}")
        End While

        DR.Close()
        cbo_empadmin.SelectedItem = 0

        sql = "SELECT EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '02-EXECUTION'"
        cmd.CommandText = sql
        DR = cmd.ExecuteReader()

        While DR.Read()
            cbo_empexe.Items.Add($"{DR("EXEEMPLOYEES")}")
        End While

        DR.Close()

        cbo_empexe.SelectedItem = 0

        sql = "SELECT HUBS FROM HUBS"
        cmd.CommandText = sql
        DR = cmd.ExecuteReader()

        While DR.Read()
            cbo_hub.Items.Add($"{DR("HUBS")}")
        End While

        DR.Close()
        cbo_hub.SelectedItem = 0



        If chk_datewds.Checked = False Then

            dtp_datewds.Enabled = False

        End If

        If chk_datecollector.Checked = False Then

            dtp_datecollector.Enabled = False

        End If

        If chk_datecheck.Checked = False Then

            dtp_daterefund.Enabled = False

        End If

        If chk_datepayment.Checked = False Then

            dtp_payment.Enabled = False

        End If
        loaddata()
        cn.Close()
    End Sub
    Private Sub loaddata()

        _cleardatagrid(dtgv_data)

        connect()


        Dim headers() As String = {"KEY", "ธนาคาร", "ศูนย์ประสานงาน", "Collecแจ้งถอนอายัด", "เลขบัตรประชาชน", "เลขที่ลูกหนี้", "เลขที่สัญญา", "ชื่อ-นามสกุล", "คดีดำ", "เลขคดีแดง", "วันที่ชำระ", "ยอดชำระ", "เบอร์ติดต่อลูกค้า", "สถานะ", "Admin-รับงาน", "พนักงานภาคสนาม", "วันที่ถอนอายัด/ยึด", "รายละเอียดการถอน", "จำนวนเงินคืน", "วันที่ส่งเช็ค", "รายละเอียดเช็ค"}

        sql = $"SELECT EXEWDS.*,EXECHECK.CHKTOTALEXERE,EXECHECK.CHKDATESEND,EXECHECK.CHKDETAIL1 FROM EXEWDS LEFT JOIN EXECHECK ON EXEWDS.EXECUSACC = EXECHECK.CHKACC "

        Select Case cbo_product.SelectedItem
            Case "ALL PRODUCT" : sql &= $"ORDER BY EXEDATECOLLEC;"
            Case "KBANK" : sql &= $"WHERE EXEWDS.EXECUSOWN = 'KBANK' ORDER BY EXEDATECOLLEC;"
            Case "SCB" : sql &= $"WHERE EXEWDS.EXECUSOWN =  'SCB' ORDER BY EXEDATECOLLEC;"
            Case "TMB" : sql &= $"WHERE EXEWDS.EXECUSOWN =  'TMB' ORDER BY EXEDATECOLLEC;"
            Case "TSS" : sql &= $"WHERE EXEWDS.EXECUSOWN =  'TSS' ORDER BY EXEDATECOLLEC;"
            Case "TBANK" : sql &= $"WHERE EXEWDS.EXECUSOWN =  'TBANK' ORDER BY EXEDATECOLLEC;"
            Case "KKB" : sql &= $"WHERE EXEWDS.EXECUSOWN =  'KKB' ORDER BY EXEDATECOLLEC;"
            Case "UOB" : sql &= $"WHERE EXEWDS.EXECUSOWN =  'UOB' ORDER BY EXEDATECOLLEC;"
        End Select

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet()
        DA.Fill(DS, "tablewds")


        dtgv_data.DataSource = DS.Tables("tablewds")

        For i = 0 To headers.Length - 1

            dtgv_data.Columns(i).HeaderText = headers(i)
            dtgv_data.Columns(0).Visible = False

        Next

        cn.Close()

    End Sub
    Private Sub notedit()

        cbo_owner.Enabled = False
        txt_cusid.ReadOnly = True
        txt_cusacc.ReadOnly = True
        txt_cuscus.ReadOnly = True
        txt_cusname.ReadOnly = True
        txt_red.ReadOnly = True
        txt_status.ReadOnly = True
        txt_refund.ReadOnly = True
        txt_detail1.ReadOnly = True
        txt_black.ReadOnly = True
        txt_payment.ReadOnly = True
        txt_cusphone.ReadOnly = True
        cbo_empadmin.Enabled = False
        cbo_empexe.Enabled = False
        cbo_hub.Enabled = False
        chk_datecheck.Enabled = False
        chk_datecollector.Enabled = False
        chk_datepayment.Enabled = False
        chk_datewds.Enabled = False

        If chk_datewds.Enabled = False Then
            dtp_datewds.Enabled = False

        End If
        If chk_datecollector.Enabled = False Then
            dtp_datecollector.Enabled = False

        End If
        If chk_datecheck.Enabled = False Then
            dtp_daterefund.Enabled = False

        End If
        If chk_datepayment.Enabled = False Then
            dtp_payment.Enabled = False

        End If

    End Sub
    Private Sub edit()

        cbo_owner.Enabled = True
        txt_cusid.ReadOnly = False
        txt_cusacc.ReadOnly = False
        txt_cuscus.ReadOnly = False
        txt_cusname.ReadOnly = False
        txt_red.ReadOnly = False
        txt_status.ReadOnly = False
        txt_refund.ReadOnly = False
        txt_detail1.ReadOnly = False
        txt_black.ReadOnly = False
        txt_payment.ReadOnly = False
        txt_cusphone.ReadOnly = False
        cbo_empadmin.Enabled = True
        cbo_empexe.Enabled = True
        cbo_hub.Enabled = True
        chk_datecheck.Enabled = True
        chk_datecollector.Enabled = True
        chk_datepayment.Enabled = True
        chk_datewds.Enabled = True

    End Sub
    Public Sub refrom()

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
        txt_refund.Text = ""
        dtp_daterefund.Text = ""
        txt_detail1.Text = ""
        dtp_datecollector.Text = ""

        chk_datecheck.Checked = False
        chk_datecollector.Checked = False
        chk_datewds.Checked = False
        chk_datepayment.Checked = False

        If chk_datewds.Checked = False Then
            dtp_datewds.Enabled = False

        End If
        If chk_datecollector.Checked = False Then
            dtp_datecollector.Enabled = False

        End If
        If chk_datecheck.Checked = False Then
            dtp_daterefund.Enabled = False

        End If
        If chk_datepayment.Checked = False Then
            dtp_payment.Enabled = False

        End If

        loaddata()
        notedit()

    End Sub

    Private Sub dtgv_data_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgv_data.CellMouseUp

        If e.RowIndex = -1 Then Exit Sub
        Try
            With dtgv_data

                cbo_owner.Text = CStr(.Rows.Item(e.RowIndex).Cells(1).Value.ToString)
                cbo_hub.Text = CStr(.Rows.Item(e.RowIndex).Cells(2).Value.ToString)
                dtp_datecollector.Text = CStr(.Rows.Item(e.RowIndex).Cells(3).Value.ToString)
                txt_cusid.Text = CStr(.Rows.Item(e.RowIndex).Cells(4).Value.ToString)
                txt_cusacc.Text = CStr(.Rows.Item(e.RowIndex).Cells(6).Value.ToString)
                txt_cuscus.Text = CStr(.Rows.Item(e.RowIndex).Cells(5).Value.ToString)
                txt_cusname.Text = CStr(.Rows.Item(e.RowIndex).Cells(7).Value.ToString)
                txt_black.Text = CStr(.Rows.Item(e.RowIndex).Cells(8).Value.ToString)
                txt_red.Text = CStr(.Rows.Item(e.RowIndex).Cells(9).Value.ToString)
                dtp_payment.Text = CStr(.Rows.Item(e.RowIndex).Cells(10).Value.ToString)
                txt_payment.Text = Int(.Rows.Item(e.RowIndex).Cells(11).Value)
                txt_cusphone.Text = CStr(.Rows.Item(e.RowIndex).Cells(12).Value.ToString)
                txt_status.Text = CStr(.Rows.Item(e.RowIndex).Cells(13).Value.ToString)
                cbo_empadmin.Text = CStr(.Rows.Item(e.RowIndex).Cells(14).Value.ToString)
                cbo_empexe.Text = CStr(.Rows.Item(e.RowIndex).Cells(15).Value.ToString)
                dtp_datewds.Text = CStr(.Rows.Item(e.RowIndex).Cells(16).Value.ToString)
                txt_detail1.Text = CStr(.Rows.Item(e.RowIndex).Cells(17).Value.ToString)
                txt_refund.Text = CStr(.Rows.Item(e.RowIndex).Cells(18).Value.ToString)
                dtp_daterefund.Text = CStr(.Rows.Item(e.RowIndex).Cells(19).Value.ToString)

            End With

            If dtgv_data.Rows.Item(e.RowIndex).Cells(3).Value.ToString = "" Then

                chk_datecollector.Checked = False
            Else

                chk_datecollector.Checked = True

            End If

            If dtgv_data.Rows.Item(e.RowIndex).Cells(16).Value.ToString = "" Then

                chk_datewds.Checked = False
            Else

                chk_datewds.Checked = True

            End If
            If dtgv_data.Rows.Item(e.RowIndex).Cells(10).Value.ToString = "" Then

                chk_datepayment.Checked = False
            Else

                chk_datepayment.Checked = True

            End If

            If dtgv_data.Rows.Item(e.RowIndex).Cells(19).Value.ToString = "" Then

                chk_datecheck.Checked = False
            Else

                chk_datecheck.Checked = True

            End If


            _convertnum(txt_refund)

            _convertnum(txt_payment)


            notedit()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_find_Click(sender As Object, e As EventArgs) Handles cmd_find.Click

        If Application.OpenForms().OfType(Of FrmsearchIDWDS).Any Then

            FrmsearchIDWDS.Focus()
        Else
            FrmsearchIDWDS.ShowDialog()
            FrmsearchIDWDS.StartPosition = FormStartPosition.CenterScreen

        End If


    End Sub

    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        loaddata()

    End Sub

    Private Sub cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click

        refrom()

    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click

        edit()

        If chk_datecollector.Checked = True Then

            dtp_datecollector.Enabled = True

        Else

            dtp_datecollector.Enabled = False

        End If

        If chk_datewds.Checked = True Then

            dtp_datewds.Enabled = True

        Else

            dtp_datewds.Enabled = False

        End If

        If chk_datepayment.Checked = True Then

            dtp_payment.Enabled = True

        Else

            dtp_payment.Enabled = False

        End If

        If chk_datecheck.Checked = True Then

            dtp_daterefund.Enabled = True

        Else

            dtp_daterefund.Enabled = False

        End If

    End Sub

    Private Sub cmd_save_Click(sender As Object, e As EventArgs) Handles cmd_save.Click

        _cleardatagrid(dtgv_data)
        connect()


        If txt_cusid.ReadOnly = False Then
            sql = $"UPDATE EXEWDS SET EXEKEY = '{cbo_owner.Text}-{txt_cusacc.Text}',EXECUSOWN = '{cbo_owner.Text}',EXEHUBS = '{cbo_hub.Text}',EXECUSIDC = '{txt_cusid.Text}',EXECUSCUS = '{txt_cuscus.Text}',EXECUSACC = '{txt_cusacc.Text}',EXECUSNAM = '{txt_cusname.Text}',EXECUSBLACK = '{txt_black.Text}',EXECUSRED = '{txt_red.Text}',EXETOTAL = '{txt_payment.Text}',EXECUSPHONE = '{txt_cusphone.Text}',EXESTATUS = '{txt_status.Text}',EXEADMIN = '{cbo_empadmin.Text}',EXEEMPLOYEE = '{cbo_empexe.Text}',EXEDETAILWDS = '{txt_detail1.Text}'"

            If chk_datecollector.Checked = True Then
                sql &= $",EXEDATECOLLEC = '{dtp_datecollector.Text}'"
            Else
                sql &= $",EXEDATECOLLEC = NULL"
            End If
            If chk_datewds.Checked = True Then
                sql &= $",EXEDATEWDS = '{dtp_datewds.Text}'"
            Else
                sql &= $",EXEDATEWDS = NULL"
            End If
            If chk_datepayment.Checked = True Then
                sql &= $",EXEDATEPAY = '{dtp_payment.Text}'"
            Else
                sql &= $",EXEDATEPAY = NULL"
            End If

            sql &= $" WHERE EXEKEY = '{cbo_owner.Text}-{txt_cusacc.Text}';"

            cmd = New SqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            Msg_OK("แก้ไขข้อมูลสำเร็จ")
            loaddata()
            notedit()

            _Getlogdata($"เพิ่มข้อมูลลูกค้า ธนาคาร {cbo_owner.Text} ชื่อ {txt_cusname.Text} สถานะ {txt_status.Text}")

        Else
            Msg_error("ไม่สามารถแก้ไขข้อมูลได้")
        End If

        cn.Close()

    End Sub

    Private Sub cmd_addnew_Click(sender As Object, e As EventArgs) Handles cmd_addnew.Click

        If Application.OpenForms().OfType(Of FrmsaveWDS).Any Then

            FrmsaveWDS.Focus()
        Else
            FrmsaveWDS.ShowDialog()
            FrmsaveWDS.StartPosition = FormStartPosition.CenterScreen

        End If

    End Sub

    Private Sub cmd_detele_Click(sender As Object, e As EventArgs) Handles cmd_detele.Click

        connect()

        If Msg_confirm("คุณต้องการลบข้อมูลใช่หรือไม่", "แจ้งเตือน") = vbYes Then

            sql = $"DELETE FROM EXEWDS WHERE EXECUSACC = '{txt_cusacc.Text}' AND EXECUSOWN = '{cbo_owner.Text}'"
            cmd = New SqlCommand(sql, cn)
            cmd.ExecuteScalar()
            cn.Close()
            Msg_OK("ลบข้อมูลสำเร็จ")
        End If

    End Sub

    Private Sub cmd_searchdate_Click(sender As Object, e As EventArgs) Handles cmd_searchdate.Click

        _cleardatagrid(dtgv_data)

        connect()

        If cbo_product.SelectedItem = "ALL PRODUCT" Then
            sql = $"SELECT * FROM EXEWDS WHERE EXEDATEWDS BETWEEN  '{datetimestart.Text}' and '{datetimefinish.Text}'"
        Else
            sql = $"SELECT * FROM EXEWDS WHERE EXEDATEWDS BETWEEN  '{datetimestart.Text}' and '{datetimefinish.Text}' AND EXECUSOWN = "
            Select Case cbo_product.SelectedItem
                Case "KBANK" : sql &= $"'KBANK';"
                Case "SCB" : sql &= $"'SCB';"
                Case "TMB" : sql &= $"'TMB';"
                Case "TSS" : sql &= $"'TSS';"
                Case "TBANK" : sql &= $"'TBANK';"
                Case "KKB" : sql &= $"'KKB';"
                Case "UOB" : sql &= $"'UOB';"
            End Select
        End If

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet()
        DA.Fill(DS, "table")

        dtgv_data.DataSource = DS.Tables("table")
        dtgv_data.Columns(0).Visible = False

        cn.Close()

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

    Private Sub chk_datecheck_CheckedChanged(sender As Object, e As EventArgs) Handles chk_datecheck.CheckedChanged

        If chk_datecheck.Checked = True Then

            dtp_daterefund.Enabled = True

        Else

            dtp_daterefund.Enabled = False

        End If

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

    Private Sub txt_refund_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_refund.KeyPress

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

    Private Sub cmd_checkview_Click(sender As Object, e As EventArgs) Handles cmd_checkview.Click

        _cleardatagrid(FrmCheck.dtgv_check)

        _sql = $"SELECT * FROM EXECHECK WHERE CHKACC = '{txt_cusacc.Text}'"
        cmd = New SqlCommand(_sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet()
        DA.Fill(DS, "check")

        Dim c As Integer = DS.Tables("check").Rows.Count
        FrmCheck.dtgv_check.DataSource = DS.Tables("check")

        Dim headers() As String = {"KEY", "ธนาคาร", "เช็คธนาคาร", "สาขา", "เลขที่เช็ค", "ลงวันที่ในเช็ค", "จำนวนเงินตามหน้าเช็ค", "เลขที่บัตรประชาชน", "เลขที่สัญญา", "เลขที่ลูกหนี้", "ชื่อ-นามสกุล", "คดีแดง", "วันที่ส่งเช็คเข้าแบงค์", "จำนวนเงินอายัด", "ค่าใช้จ่ายคืน", "หมายเหตุ"}
        For i = 0 To headers.Length - 1
            FrmCheck.dtgv_check.Columns(i).HeaderText = headers(i)
            FrmCheck.dtgv_check.Columns(0).Visible = False
        Next
        If c <= 0 Then
            If Msg_confirm("ไม่พบข้อมูลเช็ค คุณต้องการเพิ่มข้อมูลหรือไม่", "แจ้งเตือน") = vbYes Then
                With FrmCheck
                    .Show()
                    .cbo_cusowner.Text = Me.cbo_owner.SelectedItem.ToString
                    .txt_cusname.Text = Me.txt_cusname.Text
                    .txt_cusacc.Text = Me.txt_cusacc.Text
                    .txt_cusid.Text = Me.txt_cusid.Text
                    .txt_cusaccno.Text = Me.txt_cuscus.Text
                End With
            End If
        Else
            _showgrid()
            _convertnum(FrmCheck.txt_total)
            _convertnum(FrmCheck.txt_refund)

            If Application.OpenForms().OfType(Of FrmCheck).Any Then

                FrmCheck.Focus()
            Else
                FrmCheck.ShowDialog()
                FrmCheck.StartPosition = FormStartPosition.CenterScreen

            End If
        End If
    End Sub

    Private Sub cmd_datediff_Click(sender As Object, e As EventArgs) Handles cmd_datediff.Click

        _cleardatagrid(dtgv_data)

        connect()

        sql = $"SELECT EXEWDS.*,EXECHECK.CHKTOTALEXERE,EXECHECK.CHKDATESEND,DATEDIFF(DAY,EXEDATEWDS,GETDATE()) AS SEND_LATE,EXECHECK.CHKDETAIL1 FROM EXEWDS LEFT JOIN EXECHECK ON EXEWDS.EXECUSACC = EXECHECK.CHKACC WHERE EXEDATEWDS IS NOT NULL AND EXECHECK.CHKDATESEND IS NULL ORDER BY EXEDATEWDS;"
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "datelate")

        Dim headers() As String = {"KEY", "ธนาคาร", "ศูนย์ประสานงาน", "Collecแจ้งถอนอายัด", "เลขบัตรประชาชน", "เลขที่ลูกหนี้", "เลขที่สัญญา", "ชื่อ-นามสกุล", "คดีดำ", "เลขคดีแดง", "วันที่ชำระ", "ยอดชำระ", "เบอร์ติดต่อลูกค้า", "สถานะ", "Admin-รับงาน", "พนักงานภาคสนาม", "วันที่ถอนอายัด/ยึด", "รายละเอียดการถอน", "จำนวนเงินคืน", "วันที่ส่งเช็ค", "ระยะเวลาล่าช้า", "รายละเอียดเช็ค"}

        dtgv_data.DataSource = DS.Tables("datelate")

        For i = 0 To headers.Length - 1
            dtgv_data.Columns(i).HeaderText = headers(i)
            dtgv_data.Columns(0).Visible = False
        Next
        cn.Close()
    End Sub
    Private Sub _showgrid()

        With FrmCheck

            .cbo_cusowner.Text = .dtgv_check.Rows(0).Cells(1).Value.ToString
            .txt_checkbank.Text = .dtgv_check.Rows(0).Cells(2).Value.ToString
            .txt_hub.Text = .dtgv_check.Rows(0).Cells(3).Value.ToString
            .txt_numcheck.Text = .dtgv_check.Rows(0).Cells(4).Value.ToString

            If .dtgv_check.Rows(0).Cells(5).Value.ToString <> "" Then
                .chk_datecheck.Checked = True
            Else
                .chk_datecheck.Checked = False
            End If

            .dtp_datecheck.Text = CStr(.dtgv_check.Rows(0).Cells(5).Value.ToString)
            .txt_totalcheck.Text = .dtgv_check.Rows(0).Cells(6).Value.ToString
            .txt_cusid.Text = .dtgv_check.Rows(0).Cells(7).Value.ToString
            .txt_cusacc.Text = .dtgv_check.Rows(0).Cells(8).Value.ToString
            .txt_cusaccno.Text = .dtgv_check.Rows(0).Cells(9).Value.ToString
            .txt_cusname.Text = .dtgv_check.Rows(0).Cells(10).Value.ToString

            If .dtgv_check.Rows(0).Cells(12).Value.ToString <> "" Then
                .chk_checksend.Checked = True
            Else
                .chk_checksend.Checked = False
            End If

            .dtp_checksend.Text = CStr(.dtgv_check.Rows(0).Cells(12).Value.ToString)
            .txt_total.Text = .dtgv_check.Rows(0).Cells(13).Value.ToString
            .txt_refund.Text = .dtgv_check.Rows(0).Cells(14).Value.ToString
            .txt_note.Text = .dtgv_check.Rows(0).Cells(15).Value.ToString

        End With

    End Sub
    Private Sub dtgv_data_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dtgv_data.DataBindingComplete
        Try

            For Each gridRow As DataGridViewRow In dtgv_data.Rows



                Dim WDS As String = (gridRow.Cells(16).Value.ToString())
                Dim check As String = (gridRow.Cells(19).Value.ToString())

                If WDS <> "" And check <> "" Then

                    gridRow.DefaultCellStyle.BackColor = Color.GreenYellow



                ElseIf WDS = "" And check = "" Then

                    gridRow.DefaultCellStyle.BackColor = Color.Orange

                End If

            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmWDS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub


End Class