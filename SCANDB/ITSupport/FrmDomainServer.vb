Option Explicit On

Imports System.Data.SqlClient
Public Class FrmDomainServer
    Friend headercolumns() As String = {"IP", "Hostname", "Domain", "USERNAME", "Password", "SQL", "ผู้ผลิต", "Model", "Antivirus", "VesionOS", "Type", "CPU", "HardDisk", "RAM", "Detail", "DATESETUP"}
    Private Sub FrmDomainServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReloadDatagird()

    End Sub
    Private Sub ReloadDatagird()

        connect()

        sql = "SELECT * FROM tbl_fdsserver ORDER BY CAST(PARSENAME(REPLACE(SERVER_IP, ':', '.'), 4) as int),
    CAST(PARSENAME(Replace(SERVER_IP, ':', '.'), 3) as int),
    CAST(PARSENAME(Replace(SERVER_IP, ':', '.'), 2) as int),
    CAST(PARSENAME(Replace(SERVER_IP, ':', '.'), 1) as int)"

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "tables")

        With dtgv_Server

            .DataSource = DS.Tables("tables")

            .Columns(3).Visible = False
            .Columns(4).Visible = False

            For i As Integer = 0 To .Columns.Count - 1

                .Columns(i).HeaderText = headercolumns(i)

            Next

        End With

        cn.Close()

    End Sub

    Private Sub Dtgv_Server_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_Server.CellClick

        With dtgv_Server

            txt_server_IP.Text = .CurrentRow.Cells(0).Value.ToString
            txt_server_hostname.Text = .CurrentRow.Cells(1).Value.ToString
            txt_server_domain.Text = .CurrentRow.Cells(2).Value.ToString
            txt_server_user.Text = .CurrentRow.Cells(3).Value.ToString
            txt_server_pass.Text = .CurrentRow.Cells(4).Value.ToString
            txt_server_sql.Text = .CurrentRow.Cells(5).Value.ToString
            txt_server_manufacturer.Text = .CurrentRow.Cells(6).Value.ToString
            txt_server_model.Text = .CurrentRow.Cells(7).Value.ToString
            txt_server_antivirus.Text = .CurrentRow.Cells(8).Value.ToString
            txt_server_veros.Text = .CurrentRow.Cells(9).Value.ToString
            txt_server_type.Text = .CurrentRow.Cells(10).Value.ToString
            txt_server_cpu.Text = .CurrentRow.Cells(11).Value.ToString
            txt_server_harddisk.Text = .CurrentRow.Cells(12).Value.ToString
            txt_server_ram.Text = .CurrentRow.Cells(13).Value.ToString
            txt_server_detail.Text = .CurrentRow.Cells(14).Value.ToString
            Dtp_server_setos.Text = .CurrentRow.Cells(15).Value.ToString


        End With

    End Sub

    Private Sub Cmd_server_save_Click(sender As Object, e As EventArgs) Handles cmd_server_save.Click

        Connect()

        Dim txtbox As String = txt_server_IP.Text
        If txtbox = "" Then
            Msg_error("กรุณากรอก IP ที่ต้องการเพิ่มข้อมูล")
            Exit Sub
        End If

        sql = "INSERT INTO tbl_fdsserver(SERVER_IP,SERVER_HOSTNAME,SERVER_DOMAIN,SERVER_USER,SERVER_PASSWORD,SERVER_SQL,SERVER_MANUFACTURER,SERVER_MODEL,SERVER_ANTIVIRUS,SERVER_VSOS,SERVER_SYSTYPE,SERVER_CPU,SERVER_HARDDISK,SERVER_RAM,SERVER_DETAIL,SERVER_DATE_SETUP)VALUES(@serverip,@hostname,@domain,@user,@password,@sql,@manufacturer,@model,@antivirus,@versionos,@type,@cpu,@harddisk,@ram,@detail,@dateset);"
        cmd = New SqlCommand(sql, cn)
        With cmd
            .Parameters.Clear()
            .Parameters.AddWithValue("serverip", txt_server_IP.Text)
            .Parameters.AddWithValue("hostname", txt_server_hostname.Text)
            .Parameters.AddWithValue("domain", txt_server_domain.Text)
            .Parameters.AddWithValue("user", txt_server_user.Text)
            .Parameters.AddWithValue("password", txt_server_pass.Text)
            .Parameters.AddWithValue("sql", txt_server_sql.Text)
            .Parameters.AddWithValue("manufacturer", txt_server_manufacturer.Text)
            .Parameters.AddWithValue("model", txt_server_model.Text)
            .Parameters.AddWithValue("antivirus", txt_server_antivirus.Text)
            .Parameters.AddWithValue("versionos", txt_server_veros.Text)
            .Parameters.AddWithValue("type", txt_server_type.Text)
            .Parameters.AddWithValue("cpu", txt_server_cpu.Text)
            .Parameters.AddWithValue("harddisk", txt_server_harddisk.Text)
            .Parameters.AddWithValue("ram", txt_server_ram.Text)
            .Parameters.AddWithValue("detail", txt_server_detail.Text)
            .Parameters.AddWithValue("dateset", Dtp_server_setos.Text)
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

    Private Sub Cmd_server_delete_Click(sender As Object, e As EventArgs) Handles cmd_server_delete.Click

        If Msg_confirm("คุณต้องการลบรายการนี้หรือไม่") = vbYes Then

            Connect()

            Dim txtbox As String = txt_server_IP.Text
            If txtbox = "" Then
                Msg_error("กรุณาเลือกข้อมูลที่ต้องการทำรายการ")
                Exit Sub
            End If

            sql = "DELETE FROM tbl_fdsserver WHERE server_ip = @serverip;"
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("serverip", txt_server_IP.Text)
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

    Private Sub Cmd_server_edit_Click(sender As Object, e As EventArgs) Handles cmd_server_edit.Click
        Connect()

        Dim txtbox As String = txt_server_IP.Text
        If txtbox = "" Then
            Msg_error("กรุณาเลือกรายการที่ต้องการอัพเดต")
            Exit Sub
        End If

        sql = "UPDATE tbl_fdsserver SET SERVER_IP = @serverip,SERVER_HOSTNAME = @hostname,SERVER_DOMAIN = @domain,SERVER_USER = @user,SERVER_PASSWORD = @password,SERVER_sql = @sql,SERVER_Manufacturer = @manufacturer,SERVER_MODEL = @model,SERVER_Antivirus = @antivirus,SERVER_VSOS = @versionos,SERVER_SYSTYPE = @type,SERVER_CPU = @cpu,SERVER_Harddisk = @harddisk,SERVER_RAM = @ram,SERVER_detail = @detail,SERVER_DATE_SETUP =@dateset WHERE SERVER_IP = @serverip;"
        cmd = New SqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("serverip", txt_server_IP.Text)
            .Parameters.AddWithValue("hostname", txt_server_hostname.Text)
            .Parameters.AddWithValue("domain", txt_server_domain.Text)
            .Parameters.AddWithValue("user", txt_server_user.Text)
            .Parameters.AddWithValue("password", txt_server_pass.Text)
            .Parameters.AddWithValue("sql", txt_server_sql.Text)
            .Parameters.AddWithValue("manufacturer", txt_server_manufacturer.Text)
            .Parameters.AddWithValue("model", txt_server_model.Text)
            .Parameters.AddWithValue("antivirus", txt_server_antivirus.Text)
            .Parameters.AddWithValue("versionos", txt_server_veros.Text)
            .Parameters.AddWithValue("type", txt_server_type.Text)
            .Parameters.AddWithValue("cpu", txt_server_cpu.Text)
            .Parameters.AddWithValue("harddisk", txt_server_harddisk.Text)
            .Parameters.AddWithValue("ram", txt_server_ram.Text)
            .Parameters.AddWithValue("detail", txt_server_detail.Text)
            .Parameters.AddWithValue("dateset", Dtp_server_setos.Text)
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

    Private Sub Cmd_server_reload_Click(sender As Object, e As EventArgs) Handles cmd_server_reload.Click
        ReloadDatagird()
    End Sub
End Class