Option Explicit On
Imports System.Data.SqlClient
Public Class FrmUOB
    Private Sub FrmUOB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM UOBscdb"
        connect()
        Dim cmd As New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()
        While reader.Read()
            autocomp.Add(reader("AccUOB"))
        End While
        reader.Close()
        With txt_searchuob
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = autocomp
        End With
    End Sub
    Private Sub FrmUOB_FormClosing() Handles MyBase.FormClosing
        Me.Dispose()
        cn.Close()
    End Sub
    Private Sub cmd_selectuob_Click(sender As Object, e As EventArgs) Handles cmd_selectuob.Click
        connect()
        If txt_searchuob.Text = "" Then
            Msg_error("กรุณากรอก เลขที่สัญญาหรือเลขรหัสลูกหนี้")
        Else
            sql = ("SELECT AccUOB AS 'เลขที่สัญญา',PDF AS PathFile,Product,BANK AS 'ธนาคาร',[Type] AS 'ประเภทเอกสาร' FROM UOBscdb WHERE AccUOB LIKE ")
            sql &= $"'{txt_searchuob.Text}%'"
            cmd = New SqlCommand(sql, cn)
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "table")
            dtgvshowuob.DataSource = DS.Tables("table")
            dtgvshowuob.Columns(1).Visible = False
            If DS.Tables("table").Rows.Count <= 0 Then
                Msg_error("ไม่พบข้อมูลที่ค้นหา")
            End If

            _Getlogdata($"ค้นหา เอกสาร UOB {txt_searchuob.Text}")

            For Each col As DataGridViewColumn In dtgvshowuob.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

        End If
    End Sub
    Private Sub Clearinformation() '// Function Clear ข้อมูล 
        txt_accseluob.Text = ""                                '// ปุ่ม clear ข้อมูลในหน้า Select
        AxAcroPDFuob.LoadFile("DONTEXISTS.pdf")
        txt_Prodseluob.Text = ""
        txt_typeseluob.Text = ""
        txt_bankseluob.Text = ""
        txt_searchuob.Text = ""
        dtgvshowuob.DataSource.clear()
    End Sub
    Private Sub refreshdtgv_SHOW()               '// subFunction สำหรับ datagridview
        Dim header() As String = {"เลขที่สัญญา", "PathFile", "Product", "ธนาคาร", "ประเภท"}
        sql = "SELECT * FROM scanlaw"
        connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        With dtgvshowuob
            For i = 0 To header.Length - 1
                .DataSource = DS.Tables("table")      '// เนื่องจากข้อมูลเป็น อาเรย์(Array) จึงเริ่มนับ จาก 0 ไม่ใช่ นับจาก 1
                .Columns(i).HeaderText = header(i)
            Next
        End With
    End Sub

    Private Sub dtgvshowuob_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvshowuob.CellClick
        txt_accseluob.Text = dtgvshowuob.CurrentRow.Cells(0).Value  '// ทำให้แสดงข้อมูลเวลา click cell ใน Datagridview
        AxAcroPDFuob.src = dtgvshowuob.CurrentRow.Cells(1).Value
        txt_Prodseluob.Text = dtgvshowuob.CurrentRow.Cells(2).Value
        txt_bankseluob.Text = dtgvshowuob.CurrentRow.Cells(3).Value
        txt_typeseluob.Text = dtgvshowuob.CurrentRow.Cells(4).Value
    End Sub
    Private Sub cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        Clearinformation()
    End Sub
End Class