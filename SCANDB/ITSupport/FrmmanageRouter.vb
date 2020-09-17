Option Explicit On
Imports System.Data.SqlClient
Public Class FrmmanageRouter
    Friend headercolumns() As String = {"IP", "ยี่ห้อ", "ชื่อผู้ใช้", "รหัสผ่าน", "WIFI", "WIFIPASS", "DHCPSTART", "DHCPEND", "STATUS", "รายละเอียด", "วันที่แก้ไขล่าสุด"}

    Private Sub FrmmanageRouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadDatagird()
    End Sub
    Private Sub ReloadDatagird()

        connect()

        sql = "SELECT * FROM tbl_fdsrouter ORDER BY CAST(PARSENAME(REPLACE(Router_IP, ':', '.'), 4) as int),
    CAST(PARSENAME(Replace(Router_IP, ':', '.'), 3) as int),
    CAST(PARSENAME(Replace(Router_IP, ':', '.'), 2) as int),
    CAST(PARSENAME(Replace(Router_IP, ':', '.'), 1) as int)"

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "tables")

        With dtgv_router

            .DataSource = DS.Tables("tables")

            .Columns(3).Visible = False
            .Columns(5).Visible = False

            For i As Integer = 0 To .Columns.Count - 1

                .Columns(i).HeaderText = headercolumns(i)

            Next

        End With

        cn.Close()
    End Sub

    Private Sub Dtgv_router_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_router.CellClick

        With dtgv_router
            txt_router_ip.Text = .CurrentRow.Cells(0).Value.ToString
            txt_router_Brand.Text = .CurrentRow.Cells(1).Value.ToString
            txt_router_user.Text = .CurrentRow.Cells(2).Value.ToString
            txt_router_password.Text = .CurrentRow.Cells(3).Value.ToString
            txt_router_wifiuser.Text = .CurrentRow.Cells(4).Value.ToString
            txt_router_wifipass.Text = .CurrentRow.Cells(5).Value.ToString
            txt_router_dhcpstart.Text = .CurrentRow.Cells(6).Value.ToString
            txt_router_dhcpend.Text = .CurrentRow.Cells(7).Value.ToString
            txt_router_status.Text = .CurrentRow.Cells(8).Value.ToString
            txt_router_detail.Text = .CurrentRow.Cells(9).Value.ToString
            Dtp_router_lastup.Text = .CurrentRow.Cells(10).Value.ToString
        End With

    End Sub

    Private Sub Cmd_router_save_Click(sender As Object, e As EventArgs) Handles cmd_router_save.Click

        Connect()

        Dim txtbox As String = txt_router_ip.Text
        If txtbox = "" Then
            Msg_error("กรุณากรอก IP ที่ต้องการเพิ่มข้อมูล")
            Exit Sub
        End If

        sql = "INSERT INTO tbl_fdsrouter(router_ip,router_brand,router_user,router_password,router_wifiname,router_wifipassword,router_DHCPstart,router_dhcpend,router_status,router_detail,router_date_setup)VALUES(@routerip,@brand,@user,@password,@wifi,@wifipass,@dhcps,@dhcpe,@status,@detail,GETDATE())"
        cmd = New SqlCommand(sql, cn)
        With cmd
            .Parameters.Clear()
            .Parameters.AddWithValue("routerip", txt_router_ip.Text)
            .Parameters.AddWithValue("brand", txt_router_Brand.Text)
            .Parameters.AddWithValue("user", txt_router_user.Text)
            .Parameters.AddWithValue("password", txt_router_password.Text)
            .Parameters.AddWithValue("wifi", txt_router_wifiuser.Text)
            .Parameters.AddWithValue("wifipass", txt_router_wifipass.Text)
            .Parameters.AddWithValue("dhcps", txt_router_dhcpstart.Text)
            .Parameters.AddWithValue("dhcpe", txt_router_dhcpend.Text)
            .Parameters.AddWithValue("status", txt_router_status.Text)
            .Parameters.AddWithValue("detail", txt_router_detail.Text)

        End With

        Dim checkquery As Integer = cmd.ExecuteNonQuery
        If checkquery > 0 Then
            Msg_OK("แก้ไขข้อมูลสำเร็จ")

        Else
            Msg_error("แก้ไขข้อมูลล้มเหลว")

        End If

        cn.Close()
        ReloadDatagird()
    End Sub

    Private Sub Cmd_router_edit_Click(sender As Object, e As EventArgs) Handles cmd_router_edit.Click

        connect()

        Dim txtbox As String = txt_router_ip.Text
        If txtbox = "" Then
            Msg_error("กรุณาเลือกรายการที่ต้องการอัพเดต")
            Exit Sub
        End If

        sql = "UPDATE tbl_fdsrouter SET router_ip = @routerip,router_brand = @brand,router_user = @user,router_password = @password,router_wifiname = @wifi,router_wifipassword = @wifipass,router_DHCPstart = @dhcps,router_DHCPend = @dhcpe,Router_status = @status,router_detail = @detail,router_date_setup = @date WHERE router_ip = @routerip"
        cmd = New SqlCommand(sql, cn)
        With cmd
            .Parameters.Clear()
            .Parameters.AddWithValue("routerip", txt_router_ip.Text)
            .Parameters.AddWithValue("brand", txt_router_Brand.Text)
            .Parameters.AddWithValue("user", txt_router_user.Text)
            .Parameters.AddWithValue("password", txt_router_password.Text)
            .Parameters.AddWithValue("wifi", txt_router_wifiuser.Text)
            .Parameters.AddWithValue("wifipass", txt_router_wifipass.Text)
            .Parameters.AddWithValue("dhcps", txt_router_dhcpstart.Text)
            .Parameters.AddWithValue("dhcpe", txt_router_dhcpend.Text)
            .Parameters.AddWithValue("status", txt_router_status.Text)
            .Parameters.AddWithValue("detail", txt_router_detail.Text)
            .Parameters.AddWithValue("date", Dtp_router_lastup.Text)
        End With
        Dim checkquery As Integer = cmd.ExecuteNonQuery
        If checkquery > 0 Then
            Msg_OK("แก้ไขข้อมูลสำเร็จ")

        Else
            Msg_error("แก้ไขข้อมูลล้มเหลว")

        End If

        cn.Close()
        ReloadDatagird()

    End Sub

    Private Sub Cmd_router_delete_Click(sender As Object, e As EventArgs) Handles cmd_router_delete.Click

        If Msg_confirm("คุณต้องการลบรายการนี้หรือไม่") = vbYes Then

            Connect()

            Dim txtbox As String = txt_router_ip.Text
            If txtbox = "" Then
                Msg_error("กรุณาเลือกข้อมูลที่ต้องการทำรายการ")
                Exit Sub
            End If

            sql = "DELETE FROM tbl_fdsrouter WHERE Router_ip = @routerip"
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("routerip", txt_router_ip.Text)
            Dim deletequery As Integer = cmd.ExecuteNonQuery()

            If deletequery > 0 Then
                Msg_OK("ลบรายการสำเร็จ")
            Else
                Msg_error("ลบรายการล้มเหลวกรุณาลองอีกครั้ง")
            End If
            cn.Close()
            ReloadDatagird()

        End If

    End Sub

    Private Sub Cmd_router_reload_Click(sender As Object, e As EventArgs) Handles cmd_router_reload.Click
        ReloadDatagird()
    End Sub
End Class