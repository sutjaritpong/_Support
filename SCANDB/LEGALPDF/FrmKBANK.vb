Option Explicit On
Imports System.IO
Imports System.Data.SqlClient

Public Class FrmKBANK

    Private Sub FrmKBANK_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql = "SELECT * FROM KBANKscdb"
        connect()
        Dim cmd As New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()
        While reader.Read()
            autocomp.Add(reader("AccKBank"))
        End While
        reader.Close()
        txt_searchkbank.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_searchkbank.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_searchkbank.AutoCompleteCustomSource = autocomp

    End Sub
    Private Sub FrmKBANK_FormClosing() Handles MyBase.FormClosing
        Me.Dispose()
        cn.Close()
    End Sub
    Private Sub Dtgvshow_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvshowkbank.CellClick
        Try
            txt_accselkbank.Text = dtgvshowkbank.CurrentRow.Cells(0).Value  '// ทำให้แสดงข้อมูลเวลา click cell ใน Datagridview
            AxAcroPDFkbank.src = dtgvshowkbank.CurrentRow.Cells(1).Value
            txt_Prodselkbank.Text = dtgvshowkbank.CurrentRow.Cells(2).Value
            txt_bankselkbank.Text = dtgvshowkbank.CurrentRow.Cells(3).Value
            txt_typeselkbank.Text = dtgvshowkbank.CurrentRow.Cells(4).Value
        Catch
        End Try
    End Sub
    Private Sub Cmd_select_Click(sender As Object, e As EventArgs) Handles cmd_selectkbank.Click
        Connect()
        If txt_searchkbank.Text = "" Then
            Msg_error("กรุณากรอก เลขที่สัญญาหรือเลขรหัสลูกหนี้")
        Else
            sql = ("SELECT AccKBANK AS 'เลขที่สัญญา',PDF AS PathFile,Product,BANK AS 'ธนาคาร',[Type] AS 'ประเภทเอกสาร' FROM KBANKscdb WHERE AccKBANK LIKE ")
            sql &= $"'{txt_searchkbank.Text}%'"
            cmd = New SqlCommand(sql, cn)                '// นำข้อมูลที่ค้นหามาแสดงใน datagridview
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "table")
            dtgvshowkbank.DataSource = DS.Tables("table")
            dtgvshowkbank.Columns(1).Visible = False

            If DS.Tables("table").Rows.Count <= 0 Then
                Msg_error("ไม่พบข้อมูลที่ค้นหา")
            End If

            Getlogdata($"ค้นหา เอกสาร KBANK {txt_searchkbank.Text}")

            For Each col As DataGridViewColumn In dtgvshowkbank.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        End If
    End Sub
    Private Sub Cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        Clearinformation()
    End Sub
    Private Sub Refreshdtgv_SHOW()               '// subFunction สำหรับ datagridview
        Dim header() As String = {"เลขที่สัญญา", "PathFile", "Product", "ธนาคาร", "ประเภท"}
        sql = "SELECT * FROM scanlaw"
        connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        For i = 0 To header.Length - 1
            dtgvshowkbank.DataSource = DS.Tables("table")      '// เนื่องจากข้อมูลเป็น อาเรย์(Array) จึงเริ่มนับ จาก 0 ไม่ใช่ นับจาก 1
            dtgvshowkbank.Columns(i).HeaderText = header(i)
        Next

    End Sub
    Private Sub Clearinformation() '// Function Clear ข้อมูล 

        txt_accselkbank.Text = ""                                '// ปุ่ม clear ข้อมูลในหน้า Select
        AxAcroPDFkbank.LoadFile("DONTEXISTS.pdf")
        txt_Prodselkbank.Text = ""
        txt_bankselkbank.Text = ""
        txt_typeselkbank.Text = ""
        txt_searchkbank.Text = ""
        dtgvshowkbank.DataSource.clear()

    End Sub


End Class