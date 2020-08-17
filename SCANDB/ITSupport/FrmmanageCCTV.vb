Option Explicit On
Option Strict Off
Imports System.Data.SqlClient

Public Class FrmmanageCCTV

    Friend HeaderColumns() As String = {"HUBS", "สำนักงาน", "Username", "Password", "Serail.No", "ภูมิภาค", "Apps", "ยี่ห้อ", "Brand", "Solfware", "จำนวนกล้อง", "เพิ่มเติม", "ประเภท", "IP", "Port", "Remark"}

    Private Sub FrmmanageCCTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect()

        '# ใช้ Sub เพิ่ม ข้อมูลจาก Database ลงใน Combobox เป็นข้อมูล ภูมิภาค เพื่อนำไปใช้ในการกรองข้อมูลสำหรับค้นหา
        Comboboxadd(cbo_cctv_filter, "CCTV_Region", "tbl_fdscctv")

        cbo_cctv_filter.SelectedIndex = 0

        ReloadDatagird()

    End Sub

    Private Sub Dtgv_cctv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_cctv.CellClick

        With dtgv_cctv

            txt_cctv_location.Text = .CurrentRow.Cells(0).Value.ToString
            txt_cctv_hubs.Text = .CurrentRow.Cells(1).Value.ToString
            txt_cctv_user.Text = .CurrentRow.Cells(2).Value.ToString
            txt_cctv_password.Text = .CurrentRow.Cells(3).Value.ToString
            txt_cctv_serail.Text = .CurrentRow.Cells(4).Value.ToString
            txt_cctv_region.Text = .CurrentRow.Cells(5).Value.ToString
            txt_cctv_apps.Text = .CurrentRow.Cells(6).Value.ToString
            txt_cctv_brand.Text = .CurrentRow.Cells(7).Value.ToString
            txt_cctv_solfware.Text = .CurrentRow.Cells(8).Value.ToString
            txt_cctv_camera.Text = .CurrentRow.Cells(9).Value.ToString
            txt_cctv_other.Text = .CurrentRow.Cells(10).Value.ToString
            txt_cctv_type.Text = .CurrentRow.Cells(11).Value.ToString
            txt_cctv_ip.Text = .CurrentRow.Cells(12).Value.ToString
            txt_cctv_port.Text = .CurrentRow.Cells(13).Value.ToString
            txt_cctv_remark.Text = .CurrentRow.Cells(14).Value.ToString

        End With

    End Sub
    '# แก้ไขข้อมูล ใน Database โดย อ้างอิง Key จาก Location Hubs หลังจากแก้ไขให้ทำการ ReloadDatagridview 
    Private Sub Cmd_cctv_edit_Click(sender As Object, e As EventArgs) Handles cmd_cctv_edit.Click

        If txt_cctv_location.Text = "" Then
            Msg_error("ไม่พบข้อมูลที่ต้องการแก้ไขกรุณาลองใหม่อีกครั้ง")
        End If

        Connect()

        sql = "UPDATE tbl_fdscctv SET CCTV_location = @location,CCTV_hubs = @hubs,CCTV_User = @users,CCTV_Password = @password,CCTV_Serial = @Serial,CCTV_Region = @Region,CCTV_PhoneApp = @apps,CCTV_Brand = @Brand,CCTV_CMS = @solfware,CCTV_Camera = @Camera,CCTV_Other = @other , CCTV_Type = @types,CCTV_IP = @ip,CCTV_Port = @port,CCTV_Remark = @Remark WHERE CCTV_location = @location ;"

        With cmd
            .CommandText = sql
            .Parameters.Clear()
            .Parameters.AddWithValue("location", txt_cctv_location.Text)
            .Parameters.AddWithValue("hubs", txt_cctv_hubs.Text)
            .Parameters.AddWithValue("users", txt_cctv_user.Text)
            .Parameters.AddWithValue("password", txt_cctv_password.Text)
            .Parameters.AddWithValue("Serial", txt_cctv_serail.Text)
            .Parameters.AddWithValue("Region", txt_cctv_region.Text)
            .Parameters.AddWithValue("apps", txt_cctv_apps.Text)
            .Parameters.AddWithValue("brand", txt_cctv_brand.Text)
            .Parameters.AddWithValue("solfware", txt_cctv_solfware.Text)
            .Parameters.AddWithValue("Camera", txt_cctv_camera.Text)
            .Parameters.AddWithValue("other", txt_cctv_other.Text)
            .Parameters.AddWithValue("types", txt_cctv_type.Text)
            .Parameters.AddWithValue("ip", txt_cctv_ip.Text)
            .Parameters.AddWithValue("port", txt_cctv_port.Text)
            .Parameters.AddWithValue("remark", txt_cctv_remark.Text)

        End With

        Dim updates As Integer = cmd.ExecuteNonQuery()

        If updates > 0 Then
            Msg_OK("แก้ไขข้อมูลเรียบร้อย")
        Else
            Msg_error("แก้ไขข้อมูลล้มเหลว กรุณารองใหม่อีกครั้ง")
        End If

        cn.Close()
        ReloadDatagird()

    End Sub
    '# Private Sub ReloadDatagird เรียกดึงข้อมูลอีกครั้ง
    Private Sub ReloadDatagird()

        connect()

        sql = "SELECT * FROM tbl_fdscctv ORDER BY CCTV_Region "
        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "tables")

        With dtgv_cctv

            .DataSource = DS.Tables("tables")

            .Columns(3).Visible = False
            .Columns(4).Visible = False

            For i As Integer = 0 To .Columns.Count - 1

                .Columns(i).HeaderText = HeaderColumns(i)

            Next

        End With

        cn.Close()

    End Sub
    Private Sub Cleartext()
        Dim textalls() As TextBox = {}
    End Sub

    '# Filter ใช้สำหรับกรองข้อมูล โดยการเลือกข้อมูลเฉพาะภูมิภาคนั้น ๆ มาแสดงใน Datagridview
    Private Sub Cmd_cctv_filter_Click(sender As Object, e As EventArgs) Handles cmd_cctv_filter.Click

        Cleardatagrid(dtgv_cctv)
        Connect()

        sql = "SELECT * FROM tbl_fdscctv WHERE CCTV_Region = @Region ORDER BY CCTV_Region "
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("Region", cbo_cctv_filter.Text)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "filters")

        With dtgv_cctv

            .DataSource = DS.Tables("filters")

            .Columns(3).Visible = False
            .Columns(4).Visible = False

            For i As Integer = 0 To .Columns.Count - 1
                .Columns(i).HeaderText = HeaderColumns(i)
            Next

        End With

        cn.Close()

    End Sub

    Private Sub Cmd_cctv_reload_Click(sender As Object, e As EventArgs) Handles cmd_cctv_reload.Click

        ReloadDatagird()

    End Sub

    Private Sub Cmd_cctv_delete_Click(sender As Object, e As EventArgs) Handles cmd_cctv_delete.Click


        If Msg_confirm("ต้องการลบข้อมูลหรือไม่") = vbYes Then

            If txt_cctv_region.Text = "" Then

                Msg_error("ไม่พบข้อมูลที่ต้องการลบออก กรุณารองใหม่อีกครั้ง")
                Exit Sub

            End If

            Connect()

            sqll = "DELETE FROM tbl_fdscctv WHERE CCTV_location = @location"

            cmd = New SqlCommand(sqll, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("location", txt_cctv_location.Text)
            Dim results As Integer = cmd.ExecuteNonQuery()

            If results > 0 Then
                Msg_OK("ลบข้อมูลสำเร็จ")
            Else
                Msg_error("ลบข้อมูลล้มเหลว")
            End If

            cn.Close()
            ReloadDatagird()

        End If


    End Sub

    Private Sub Cmd_cctv_save_Click(sender As Object, e As EventArgs) Handles cmd_cctv_save.Click

        Connect()

        sql = "SELECT COUNT(CCTV_location) FROM tbl_fdscctv"
        cmd = New SqlCommand(sql, cn)
        Dim check As Integer = cmd.ExecuteScalar()
        If check > 0 Then
            Msg_error("พบรายชื่อ HUBS นี้ในระบบแล้วกรุณาลองใหม่อีกครั้ง")
            Exit Sub
        End If

        sql = "INSERT INTO tbl_fdscctv(CCTV_location,CCTV_Hubs,CCTV_User,CCTV_Password,CCTV_Serial,CCTV_Region,CCTV_PhoneApp,CCTV_Brand,CCTV_CMS,CCTV_Camera,CCTV_Other,CCTV_Type,CCTV_IP,CCTV_Port,CCTV_Remark)VALUES(@location,@hubs,@users,@password,@Serial,@Region,@apps,@brand,@solfware,@Camera,@other,@types,@ip,@port,@remark)"
        cmd = New SqlCommand(sql, cn)

        With cmd
            .CommandText = sql
            .Parameters.Clear()
            .Parameters.AddWithValue("location", txt_cctv_location.Text)
            .Parameters.AddWithValue("hubs", txt_cctv_hubs.Text)
            .Parameters.AddWithValue("users", txt_cctv_user.Text)
            .Parameters.AddWithValue("password", txt_cctv_password.Text)
            .Parameters.AddWithValue("Serial", txt_cctv_serail.Text)
            .Parameters.AddWithValue("Region", txt_cctv_region.Text)
            .Parameters.AddWithValue("apps", txt_cctv_apps.Text)
            .Parameters.AddWithValue("brand", txt_cctv_brand.Text)
            .Parameters.AddWithValue("solfware", txt_cctv_solfware.Text)
            .Parameters.AddWithValue("Camera", txt_cctv_camera.Text)
            .Parameters.AddWithValue("other", txt_cctv_other.Text)
            .Parameters.AddWithValue("types", txt_cctv_type.Text)
            .Parameters.AddWithValue("ip", txt_cctv_ip.Text)
            .Parameters.AddWithValue("port", txt_cctv_port.Text)
            .Parameters.AddWithValue("remark", txt_cctv_remark.Text)
            Dim results As Integer = .ExecuteNonQuery()
            If results > 0 Then
                MsgBox("เพิ่มข้อมูลสำเร็จ")
            Else
                Msg_error("เพิ่มข้อมูลล้มเหลว")
            End If

        End With

        cn.Close()
        ReloadDatagird()

    End Sub

    Private Sub FrmmanageCCTV_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub
End Class