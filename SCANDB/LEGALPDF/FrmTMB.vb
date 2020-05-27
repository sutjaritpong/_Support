Option Explicit On
Imports System.Data.SqlClient
Public Class FrmTMB
    Private Sub FrmTMB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM TMBscdb"
        connect()
        Dim cmd As New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()
        While reader.Read()
            autocomp.Add(reader("AccTMB"))
        End While
        reader.Close()
        With txt_searchtmb
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = autocomp
        End With
    End Sub
    Private Sub FrmTMB_FormClosing() Handles MyBase.FormClosing
        Me.Dispose()
        cn.Close()
    End Sub
    Private Sub cmd_selecttmb_Click(sender As Object, e As EventArgs) Handles cmd_selecttmb.Click
        connect()
        If txt_searchtmb.Text = "" Then
            Msg_error("กรุณากรอก เลขที่สัญญาหรือเลขรหัสลูกหนี้")
        Else
            sql = ("SELECT AccTMB AS 'เลขที่สัญญา',PDF AS PathFile,Product,BANK AS 'ธนาคาร',[Type] AS 'ประเภทเอกสาร' FROM TMBscdb WHERE AccTMB LIKE ")
            sql &= $"'{txt_searchtmb.Text}%'"
            cmd = New SqlCommand(sql, cn)
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "table")
            dtgvshowtmb.DataSource = DS.Tables("table")                '// นำข้อมูลที่ค้นหามาแสดงใน datagridview
            dtgvshowtmb.Columns(1).Visible = False

            If DS.Tables("table").Rows.Count <= 0 Then
                Msg_error("ไม่พบข้อมูลที่ค้นหา")
            End If

            _Getlogdata($"ค้นหา เอกสาร TMB {txt_searchtmb.Text}")

            For Each col As DataGridViewColumn In dtgvshowtmb.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

        End If
    End Sub

    Private Sub cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        Clearinformation()
    End Sub
    Private Sub Clearinformation() '// Function Clear ข้อมูล 
        txt_accseltmb.Text = ""                                '// ปุ่ม clear ข้อมูลในหน้า Select
        AxAcroPDFtmb.LoadFile("DONTEXISTS.pdf")
        txt_bankseltmb.Text = ""
        txt_typeseltmb.Text = ""
        txt_bankseltmb.Text = ""
        txt_searchtmb.Text = ""
        dtgvshowtmb.DataSource.clear()
    End Sub
    Private Sub refreshdtgv_SHOW()               '// subFunction สำหรับ datagridview
        Dim header() As String = {"เลขที่สัญญา", "PathFile", "Product", "ธนาคาร", "ประเภท"}
        sql = "SELECT * FROM scanlaw"
        connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        With dtgvshowtmb
            For i = 0 To header.Length - 1
                .DataSource = DS.Tables("table")      '// เนื่องจากข้อมูลเป็น อาเรย์(Array) จึงเริ่มนับ จาก 0 ไม่ใช่ นับจาก 1
                .Columns(i).HeaderText = header(i)
            Next
        End With
    End Sub

    Private Sub dtgvshowtmb_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvshowtmb.CellClick
        txt_accseltmb.Text = dtgvshowtmb.CurrentRow.Cells(0).Value  '// ทำให้แสดงข้อมูลเวลา click cell ใน Datagridview
        AxAcroPDFtmb.src = dtgvshowtmb.CurrentRow.Cells(1).Value
        txt_prodseltmb.Text = dtgvshowtmb.CurrentRow.Cells(2).Value
        txt_bankseltmb.Text = dtgvshowtmb.CurrentRow.Cells(3).Value
        txt_typeseltmb.Text = dtgvshowtmb.CurrentRow.Cells(4).Value
    End Sub

End Class