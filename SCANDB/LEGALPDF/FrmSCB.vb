Option Explicit On
Imports System.Data.SqlClient
Public Class FrmSCB
    Private Sub FrmSCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM SCBscdb"
        connect()
        Dim cmd As New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()
        While reader.Read()
            autocomp.Add(reader("AccSCB"))
        End While
        reader.Close()
        With txt_searchscb
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = autocomp
        End With
    End Sub
    Private Sub FrmSCB_FormClosing() Handles MyBase.FormClosing
        Me.Dispose()
        cn.Close()
    End Sub
    Private Sub cmd_selectkscb_Click(sender As Object, e As EventArgs) Handles cmd_selectscb.Click
        connect()
        If txt_searchscb.Text = "" Then
            Msg_error("กรุณากรอก เลขที่สัญญาหรือเลขรหัสลูกหนี้")
        Else
            sql = ("SELECT AccSCB AS 'เลขที่สัญญา',PDF AS PathFile,Product,BANK AS 'ธนาคาร',[Type] AS 'ประเภทเอกสาร' FROM SCBscdb WHERE AccSCB LIKE ")     '//AND Product = '" & cbobank.Text & "'" '// แสดงข้อมูลทั้งหมด 
            sql &= $"'{txt_searchscb.Text}%'"
            cmd = New SqlCommand(sql, cn)                '// นำข้อมูลที่ค้นหามาแสดงใน datagridview
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "table") '// นำข้อมูลที่ค้นหามาแสดงใน datagridview
            dtgvshowscb.DataSource = DS.Tables("table")                   '// นำข้อมูลที่ค้นหามาแสดงใน datagridview
            dtgvshowscb.Columns(1).Visible = False
            If DS.Tables("table").Rows.Count <= 0 Then
                Msg_error("ไม่พบข้อมูลที่ค้นหา")
            End If

            _Getlogdata($"ค้นหา เอกสาร SCB {txt_searchscb.Text}")

            For Each col As DataGridViewColumn In dtgvshowscb.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        End If
    End Sub
    Private Sub cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        Clearinformation()
    End Sub
    Private Sub Clearinformation() '// Function Clear ข้อมูล 
        txt_accselscb.Text = ""                                '// ปุ่ม clear ข้อมูลในหน้า Select
        AxAcroPDFscb.LoadFile("DONTEXISTS.pdf")
        txt_Prodselscb.Text = ""
        txt_bankselscb.Text = ""
        txt_typeselscb.Text = ""
        txt_searchscb.Text = ""
        dtgvshowscb.DataSource.clear()
    End Sub
    Private Sub refreshdtgv_SHOW()               '// subFunction สำหรับ datagridview
        Dim header() As String = {"เลขที่สัญญา", "PathFile", "Product", "ธนาคาร", "ประเภท"}
        sql = "SELECT * FROM scanlaw"
        connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        With dtgvshowscb
            For i = 0 To header.Length - 1
                .DataSource = DS.Tables("table")      '// เนื่องจากข้อมูลเป็น อาเรย์(Array) จึงเริ่มนับ จาก 0 ไม่ใช่ นับจาก 1
                .Columns(i).HeaderText = header(i)
            Next
        End With
    End Sub

    Private Sub dtgvshowscb_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvshowscb.CellClick
        txt_accselscb.Text = dtgvshowscb.CurrentRow.Cells(0).Value  '// ทำให้แสดงข้อมูลเวลา click cell ใน Datagridview
        AxAcroPDFscb.src = dtgvshowscb.CurrentRow.Cells(1).Value
        txt_Prodselscb.Text = dtgvshowscb.CurrentRow.Cells(2).Value
        txt_bankselscb.Text = dtgvshowscb.CurrentRow.Cells(3).Value
        txt_typeselscb.Text = dtgvshowscb.CurrentRow.Cells(4).Value
    End Sub
End Class