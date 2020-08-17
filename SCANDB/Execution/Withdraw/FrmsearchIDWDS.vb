Imports System.Data
Imports System.Data.SqlClient
Public Class FrmsearchIDWDS

    Private Sub FrmsearchIDWDS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Autocompletecombo(txt_searchacc, "EXECUSACC", "EXEWDS")

    End Sub
    Private Sub Btn_searchid_Click(sender As Object, e As EventArgs) Handles btn_searchid.Click
        If txt_searchacc.Text = "" Then
            Msg_error("กรุณากรอกเลขบัตรประชาชนที่ต้องการค้นหา")
            Return
        End If
        sql = $"SELECT EXEWDS.*,EXECHECK.CHKTOTALEXERE,EXECHECK.CHKDATESEND,EXECHECK.CHKDETAIL1 FROM EXEWDS LEFT JOIN EXECHECK ON EXEWDS.EXECUSACC = EXECHECK.CHKACC 
            WHERE EXEWDS.EXECUSACC = '{txt_searchacc.Text}'"
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet()
        Dim i As Integer = DA.Fill(DS, "table")

        With FrmWDS

            .dtgv_data.DataSource = DS.Tables("table")
            .dtgv_data.Columns(0).Visible = False

            Datagrid_format_dateshort(FrmWDS.dtgv_data, 3)
            Datagrid_format_dateshort(FrmWDS.dtgv_data, 9)
            Datagrid_format_dateshort(FrmWDS.dtgv_data, 15)
            Datagrid_format_dateshort(FrmWDS.dtgv_data, 19)

            Me.Close()

        End With
        If i <= 0 Then
            Msg_error("ไม่พบข้อมูล")
            FrmWDS.Refrom_Obj()
        End If

        cn.Close()


    End Sub

End Class