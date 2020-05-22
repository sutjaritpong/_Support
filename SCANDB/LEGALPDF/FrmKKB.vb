Option Explicit On
Imports System.Data.SqlClient
Public Class FrmKKB
    Private Sub FrmKKB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM KKBscdb"
        connect()
        Dim cmd As New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()
        While reader.Read()
            autocomp.Add(reader("AccKKB"))
        End While
        reader.Close()
        txt_searchkkb.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_searchkkb.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_searchkkb.AutoCompleteCustomSource = autocomp
    End Sub
    Private Sub FrmKKB_FormClosing() Handles MyBase.FormClosing
        Me.Dispose()
        cn.Close()
    End Sub

    Private Sub cmd_selectkkb_Click(sender As Object, e As EventArgs) Handles cmd_selectkkb.Click
        connect()
        If txt_searchkkb.Text = "" Then
            Msg_error("กรุณากรอก เลขที่สัญญาหรือเลขรหัสลูกหนี้")
        Else
            sql = ("SELECT AccKKB AS 'เลขที่สัญญา',PDF AS PathFile,Product,BANK AS 'ธนาคาร',[Type] AS 'ประเภทเอกสาร' FROM KKBscdb WHERE AccKKB LIKE ")
            sql &= $"'{txt_searchkkb.Text}%'"
            cmd = New SqlCommand(sql, cn)
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "table")
            dtgvshowkkb.DataSource = DS.Tables("table")         '// นำข้อมูลที่ค้นหามาแสดงใน datagridview
            dtgvshowkkb.Columns(1).Visible = False

            If DS.Tables("table").Rows.Count <= 0 Then
                Msg_error("ไม่พบข้อมูลที่ค้นหา")
            End If

            _Getlogdata($"ค้นหา เอกสาร KKB {txt_searchkkb.Text}")

            For Each col As DataGridViewColumn In dtgvshowkkb.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        End If
    End Sub
    Private Sub cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        Clearinformation()
    End Sub
    Private Sub Clearinformation() '// Function Clear ข้อมูล 
        txt_accselkkb.Text = ""                                '// ปุ่ม clear ข้อมูลในหน้า Select
        AxAcroPDFkkb.LoadFile("DONTEXISTS.pdf")
        txt_Prodselkkb.Text = ""
        txt_bankselkkb.Text = ""
        txt_typeselkkb.Text = ""
        txt_searchkkb.Text = ""
        dtgvshowkkb.DataSource.clear()
    End Sub
    Private Sub refreshdtgv_SHOW()               '// subFunction สำหรับ datagridview
        Dim header() As String = {"เลขที่สัญญา", "PathFile", "Product", "ธนาคาร", "ประเภท"}
        sql = "SELECT * FROM scanlaw"
        connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        For i = 0 To header.Length - 1
            dtgvshowkkb.DataSource = DS.Tables("table")      '// เนื่องจากข้อมูลเป็น อาเรย์(Array) จึงเริ่มนับ จาก 0 ไม่ใช่ นับจาก 1
            dtgvshowkkb.Columns(i).HeaderText = header(i)
        Next

    End Sub

    Private Sub dtgvshowkkb_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvshowkkb.CellClick
        txt_accselkkb.Text = dtgvshowkkb.CurrentRow.Cells(0).Value  '// ทำให้แสดงข้อมูลเวลา click cell ใน Datagridview
        AxAcroPDFkkb.src = dtgvshowkkb.CurrentRow.Cells(1).Value
        txt_Prodselkkb.Text = dtgvshowkkb.CurrentRow.Cells(2).Value
        txt_bankselkkb.Text = dtgvshowkkb.CurrentRow.Cells(3).Value
        txt_typeselkkb.Text = dtgvshowkkb.CurrentRow.Cells(4).Value
    End Sub
End Class