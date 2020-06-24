Option Explicit On
Imports System.Data.SqlClient
Imports System.IO


Public Class FrmAccountingKBANK

    Dim _header() As String = {"key", "ลำดับ", "เลขที่ลูกหนี้", "ชื่อนามสกุล", "เลขที่คดี", "วันที่ฟ้อง", "ศาล", "ทุนทรัพย์", "ค่าธรรมเนียม", "เลขที่ชุดเบิก", "วันที่ส่งเบิก", "ประเภทเอกสาร", "Type"}
    Private Sub FrmAccountingKBANK_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim _comadd() As String = {"เลขที่ลูกหนี้", "ชื่อ-นามสกุล", "เลขที่คดี", "เลขที่ชุด"}
        _cboArray(cbo_search, _comadd)


        connect()

        sql = "SELECT DISTINCT Accounting_CUSCUS,Accounting_invoice,Accounting_Name,Accounting_black_red  FROM AccountingKBANK"

        cmd = New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()

        While reader.Read()

            autocomp.Add(reader("Accounting_CUSCUS"))
            autocomp.Add(reader("Accounting_invoice"))
            autocomp.Add(reader("Accounting_Name"))
            autocomp.Add(reader("Accounting_black_red"))

        End While

        reader.Close()

        txt_search.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_search.AutoCompleteCustomSource = autocomp


        cn.Close()

    End Sub
    Private Sub _search()

        connect()
        dtgv_invoice_list.Visible = True
        Grb_detail.Visible = True

        If (dtgv_invoice_list.RowCount <> Nothing) Or (dtgv_invoice_list.ColumnCount <> Nothing) Then
            _cleardatagrid(dtgv_invoice_list)
        End If

        If txt_search.Text = "" Then
            Msg_error("กรุณากรอกข้อมูลที่ต้องการค้นหา")
            Return
        End If

        sql = $"SELECT * FROM AccountingKBANK WHERE "
        Select Case cbo_search.SelectedItem
            Case "เลขที่ลูกหนี้" : sql &= "Accounting_CUSCUS LIKE "
            Case "ชื่อ-นามสกุล" : sql &= "Accounting_Name LIKE "
            Case "เลขที่คดี" : sql &= "Accounting_black_red LIKE "
            Case "เลขที่ชุด" : sql &= "Accounting_invoice LIKE "
        End Select

        sql &= " '%' + @finds + '%' ORDER BY Accounting_invoice;"

        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@finds", txt_search.Text)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "tables")

        If DS.Tables("tables").Rows.Count = 0 Then

            lbl_search.Text = "ไม่พบข้อมูลที่ค้นหา"

        Else

            With dtgv_invoice_list

                lbl_search.Text = $"พบข้อมูล {DS.Tables("tables").Rows.Count} ราย"
                .DataSource = DS.Tables("tables")

                .Columns(0).HeaderText = "KEY"
                .Columns(1).HeaderText = "ลำดับ"
                .Columns(2).HeaderText = "เลขที่ลูกหนี้"
                .Columns(3).HeaderText = "ชื่อ-นามสกุล"
                .Columns(4).HeaderText = "เลขที่คดี"
                .Columns(5).HeaderText = "วันฟ้อง"
                .Columns(9).HeaderText = "เลขที่ชุดเบิก"
                .Columns(11).HeaderText = "ประเภทเอกสาร"

                .Columns(0).Visible = False
                .Columns(1).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(10).Visible = False
                .Columns(12).Visible = False

            End With

        End If

        cn.Close()

    End Sub

    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        _search()

    End Sub

    Private Sub dtgv_invoice_list_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_invoice_list.CellClick

        _cleartext()

        If (dtgv_find_scan.RowCount <> Nothing) Or (dtgv_find_scan.ColumnCount <> Nothing) Then
            _cleardatagrid(dtgv_find_scan)
        End If

        With dtgv_invoice_list

            txt_order.Text = .CurrentRow.Cells(1).Value.ToString
            txt_cuscus.Text = .CurrentRow.Cells(2).Value.ToString
            txt_namecus.Text = .CurrentRow.Cells(3).Value.ToString
            txt_blackred.Text = .CurrentRow.Cells(4).Value.ToString
            dtp_date_legal.Text = .CurrentRow.Cells(5).Value.ToString
            txt_court.Text = .CurrentRow.Cells(6).Value.ToString
            txt_capital.Text = .CurrentRow.Cells(7).Value.ToString
            txt_receipt.Text = .CurrentRow.Cells(8).Value.ToString
            txt_invoice.Text = .CurrentRow.Cells(9).Value.ToString
            dtp_send_invoice.Text = .CurrentRow.Cells(10).Value.ToString
            txt_type_legal.Text = .CurrentRow.Cells(11).Value.ToString
            txt_type_master.Text = .CurrentRow.Cells(12).Value.ToString

        End With

        If dtgv_invoice_list.CurrentRow.Cells(5).Value.ToString <> "" Then

            Chk_date_legal.Checked = True

        End If

        If dtgv_invoice_list.CurrentRow.Cells(10).Value.ToString <> "" Then

            chk_send_invoice.Checked = True

        End If

        If dtgv_invoice_list.CurrentRow.Cells(11).Value.ToString = "คำฟ้อง" Then

            Dim str As String = txt_invoice.Text

            txt_invoice2.Text = "KBANK_" & str.Substring(10, 3)

        End If

        Dim _text As String = txt_invoice.Text

        txt_invoice.Text = Mid(_text, 1, 9)

        dtgv_find_scan.Visible = True

        connect()

        sql = $"SELECT * FROM ACCOUNTINGscdb WHERE Accounting_invoice LIKE '%{txt_invoice.Text}%' "
        If dtgv_invoice_list.CurrentRow.Cells(11).Value.ToString = "คำฟ้อง" Then
            sql &= $" OR Accounting_invoice LIKE '%{txt_invoice2.Text}%' "
        End If
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "scans")

        With dtgv_find_scan
            .DataSource = DS.Tables("scans")
            .Columns(1).Visible = False
            .Columns(2).Visible = False
            .Columns(3).Visible = False

            .Columns(0).HeaderText = "เลขที่ชุด"
            .Columns(1).HeaderText = "Path"
            .Columns(2).HeaderText = "เดือนที่เบิก"
            .Columns(3).HeaderText = "Product"

        End With

        cn.Close()

    End Sub

    Private Sub dtgv_find_scan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_find_scan.CellClick

        Ax_pdf_invoice.src = dtgv_find_scan.CurrentRow.Cells(1).Value.ToString

    End Sub

    Sub _cleartext()

        txt_blackred.Text = ""
        txt_capital.Text = ""
        txt_court.Text = ""
        txt_cuscus.Text = ""
        txt_invoice.Text = ""
        txt_invoice2.Text = ""
        txt_namecus.Text = ""
        txt_order.Text = ""
        txt_receipt.Text = ""
        txt_type_legal.Text = ""
        txt_type_master.Text = ""

        dtp_date_legal.Text = ""
        dtp_send_invoice.Text = ""

        Chk_date_legal.Checked = False
        chk_send_invoice.Checked = False

    End Sub

    Private Sub cmd_clears_Click(sender As Object, e As EventArgs) Handles cmd_clears.Click

        _cleartext()

    End Sub

    Private Sub FrmAccountingKBANK_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub

    'Private Sub cmd_clipboard_Click(sender As Object, e As EventArgs)


    '    Dim _csv() As String = {$"{txt_namecus.Text}", $"{txt_cuscus.Text}", $"{txt_invoice.Text}"}

    '    Clipboard.SetDataObject(_csv(1) & "," & _csv(2), True)

    '    'Dim o As IDataObject = Clipboard.GetDataObject()
    '    'If Not o Is Nothing Then
    '    '    If (o.GetDataPresent(DataFormats.CommaSeparatedValue)) Then
    '    '        Dim sr As New StreamReader(CType(o.GetData(DataFormats.CommaSeparatedValue), Stream))
    '    '        Dim s As String = sr.ReadToEnd()
    '    '        sr.Close()
    '    '        Console.WriteLine(s)
    '    '    End If
    '    'End If

    'End Sub

    'Private Sub cmd_test_Click(sender As Object, e As EventArgs)

    '    Dim csv As String = $"{txt_cuscus.Text},{txt_namecus.Text.ToString},{txt_blackred.Text.ToString},{txt_court.Text.ToString},{txt_invoice.Text.ToString}"

    '    Dim blob As Byte() = System.Text.Encoding.UTF8.GetBytes(csv)

    '    Dim s As New MemoryStream
    '    Dim data As New DataObject()

    '    data.SetData(DataFormats.CommaSeparatedValue, s)
    '    Clipboard.SetDataObject(data, True)

    'End Sub

End Class
