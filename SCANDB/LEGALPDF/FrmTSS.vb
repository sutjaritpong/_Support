Option Explicit On
Imports System.Data.SqlClient
Public Class FrmTSS
    Private Sub FrmTSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM TSSscdb"
        connect()
        Dim cmd As New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()
        While reader.Read()
            autocomp.Add(reader("AccTSS"))
        End While
        reader.Close()
        With txt_searchtss
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = autocomp
        End With
    End Sub
    Private Sub FrmTSS_FormClosing() Handles MyBase.FormClosing
        Me.Dispose()
        cn.Close()
    End Sub
    Private Sub Cmd_selecttss_Click(sender As Object, e As EventArgs) Handles cmd_selecttss.Click
        Connect()
        If txt_searchtss.Text = "" Then
            Msg_error("กรุณากรอก เลขที่สัญญาหรือเลขรหัสลูกหนี้")
        Else
            sql = ("SELECT AccTSS AS 'เลขที่สัญญา',PDF AS PathFile,Product,BANK AS 'ธนาคาร',[Type] AS 'ประเภทเอกสาร' FROM TSSscdb WHERE AccTSS LIKE ")
            sql &= $"'{txt_searchtss.Text}%'"
            cmd = New SqlCommand(sql, cn)
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "table")
            dtgvshowtss.DataSource = DS.Tables("table")
            dtgvshowtss.Columns(1).Visible = False

            If DS.Tables("table").Rows.Count <= 0 Then
                Msg_error("ไม่พบข้อมูลที่ค้นหา")
            End If

            Getlogdata($"ค้นหา เอกสาร TSS {txt_searchtss.Text}")

            For Each col As DataGridViewColumn In dtgvshowtss.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        End If

    End Sub

    Private Sub Cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        Clearinformation()
    End Sub
    Private Sub Clearinformation() '// Function Clear ข้อมูล 
        txt_accseltss.Text = ""                                '// ปุ่ม clear ข้อมูลในหน้า Select
        AxAcroPDFtss.LoadFile("DONTEXISTS.pdf")
        txt_Prodseltss.Text = ""
        txt_typeseltss.Text = ""
        txt_searchtss.Text = ""
        dtgvshowtss.DataSource.clear()
    End Sub
    Private Sub Refreshdtgv_Show()               '// subFunction สำหรับ datagridview
        Dim header() As String = {"เลขที่สัญญา", "PathFile", "Product", "ธนาคาร", "ประเภท"}
        sql = "SELECT * FROM TSSscdb"
        Connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        With dtgvshowtss
            For i = 0 To header.Length - 1
                .DataSource = DS.Tables("table")      '// เนื่องจากข้อมูลเป็น อาเรย์(Array) จึงเริ่มนับ จาก 0 ไม่ใช่ นับจาก 1
                .Columns(i).HeaderText = header(i)
            Next
        End With
    End Sub

    Private Sub Dtgvshowtss_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvshowtss.CellClick
        txt_accseltss.Text = dtgvshowtss.CurrentRow.Cells(0).Value  '// ทำให้แสดงข้อมูลเวลา click cell ใน Datagridview
        AxAcroPDFtss.src = dtgvshowtss.CurrentRow.Cells(1).Value
        txt_Prodseltss.Text = dtgvshowtss.CurrentRow.Cells(2).Value
        txt_bankseltss.Text = dtgvshowtss.CurrentRow.Cells(3).Value
        txt_typeseltss.Text = dtgvshowtss.CurrentRow.Cells(4).Value
    End Sub
End Class