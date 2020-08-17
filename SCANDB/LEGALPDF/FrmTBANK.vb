Option Explicit On
Imports System.Data.SqlClient
Public Class FrmTBANK
    Private Sub FrmTBANK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM TBANKscdb"
        connect()
        Dim cmd As New SqlCommand(sql, cn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim autocomp As New AutoCompleteStringCollection()
        While reader.Read()
            autocomp.Add(reader("AccTBANK"))
        End While
        reader.Close()
        With txt_searchtbank
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = autocomp
        End With
    End Sub
    Private Sub FrmTBANK_FormClosing() Handles MyBase.FormClosing
        Me.Dispose()
        cn.Close()
    End Sub
    Private Sub Dtgvshowtbank_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvshowtbank.CellClick
        txt_accseltbank.Text = dtgvshowtbank.CurrentRow.Cells(0).Value  '// ทำให้แสดงข้อมูลเวลา click cell ใน Datagridview
        AxAcroPDFtbank.src = dtgvshowtbank.CurrentRow.Cells(1).Value
        txt_Prodseltbank.Text = dtgvshowtbank.CurrentRow.Cells(2).Value
        txt_bankseltbank.Text = dtgvshowtbank.CurrentRow.Cells(3).Value
        txt_typeseltbank.Text = dtgvshowtbank.CurrentRow.Cells(4).Value
    End Sub

    Private Sub Cmd_selecttbank_Click(sender As Object, e As EventArgs) Handles cmd_selectkbank.Click
        Connect()
        If txt_searchtbank.Text = "" Then
            Msg_error("กรุณากรอก เลขที่สัญญาหรือเลขรหัสลูกหนี้")
        Else
            sql = ("SELECT AccTBANK AS 'เลขที่สัญญา',PDF AS PathFile,Product,BANK AS 'ธนาคาร',[Type] AS 'ประเภทเอกสาร' FROM TBANKscdb WHERE AccTBANK LIKE ")
            sql &= $"'{txt_searchtbank.Text}%'"
            cmd = New SqlCommand(sql, cn)
            DA = New SqlDataAdapter(cmd)
            DS = New DataSet
            DA.Fill(DS, "table")

            dtgvshowtbank.DataSource = DS.Tables("table")           '// นำข้อมูลที่ค้นหามาแสดงใน datagridview
            dtgvshowtbank.Columns(1).Visible = False

            If DS.Tables("table").Rows.Count <= 0 Then
                Msg_error("ไม่พบข้อมูลที่ค้นหา")
            End If

            Getlogdata($"ค้นหา เอกสาร TBANK {txt_searchtbank.Text}")

            For Each col As DataGridViewColumn In dtgvshowtbank.Columns
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        End If
    End Sub

    Private Sub Cmd_clear_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        Clearinformation()
    End Sub
    Private Sub Clearinformation() '// Function Clear ข้อมูล 
        txt_accseltbank.Text = ""                                '// ปุ่ม clear ข้อมูลในหน้า Select
        AxAcroPDFtbank.LoadFile("DONTEXISTS.pdf")
        txt_Prodseltbank.Text = ""
        txt_bankseltbank.Text = ""
        txt_typeseltbank.Text = ""
        txt_searchtbank.Text = ""
        dtgvshowtbank.DataSource.clear()
    End Sub
    Private Sub Refreshdtgv_Show()               '// subFunction สำหรับ datagridview
        Dim header() As String = {"เลขที่สัญญา", "PathFile", "ธนาคาร", "ประเภท"}
        sql = "SELECT * FROM TBANKscdb"
        Connect()
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        With dtgvshowtbank
            For i = 0 To header.Length - 1
                .DataSource = DS.Tables("table")      '// เนื่องจากข้อมูลเป็น อาเรย์(Array) จึงเริ่มนับ จาก 0 ไม่ใช่ นับจาก 1
                .Columns(i).HeaderText = header(i)
            Next
        End With
    End Sub
End Class