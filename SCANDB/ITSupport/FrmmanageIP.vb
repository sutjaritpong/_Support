Option Explicit On
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmmanageIP
    Private Sub FrmmanageIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _Datetimeformatshort(dtp_edit)

        dtgvip.DefaultCellStyle.BackColor = Color.Black
        dtgvip.DefaultCellStyle.ForeColor = Color.White
        dtgvip.RowHeadersDefaultCellStyle.BackColor = Color.Black

        refreshIP()

        Dim type() As String = {"IP", "ชื่อเล่น", "ชื่อพนักงาน", "ตำแหน่ง", "Product", "ตึก", "Server", "DomainName", "รายละเอียด"}
        cbo_type.Items.AddRange(type)
        cbo_type.SelectedIndex = 0

        cbo_filter.Enabled = False
    End Sub
    'Buttom Refresh 
    Private Sub cmd_refresh_Click(sender As Object, e As EventArgs) Handles cmd_refresh.Click

        refreshIP()

    End Sub
    'Sub Refresh information and cancel Sort or Filter

    Sub refreshIP()

        Dim Header() As String = {"IP", "ชื่อเล่น", "ชื่อพนักงาน", "ตำแหน่ง", "Product", "ตึก", "Server", "DomainName", "รายละเอียด", "เวลาที่แก้ไข"}
        sql = "SELECT * FROM tbl_fdspc ORDER BY CAST(PARSENAME(REPLACE(FDSIP, ':', '.'), 4) as int),
    CAST(PARSENAME(Replace(FDSIP, ':', '.'), 3) as int),
    CAST(PARSENAME(Replace(FDSIP, ':', '.'), 2) as int),
    CAST(PARSENAME(Replace(FDSIP, ':', '.'), 1) as int)"  '// สำหรับเรียง IP

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "ip")

        For i = 0 To Header.Length - 1

            dtgvip.DataSource = DS.Tables("ip")
            dtgvip.Columns(i).HeaderText = Header(i)

        Next
    End Sub

    Private Sub cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click

        connect()

        Dim search() As String = {"IP", "ชื่อเล่น", "ชื่อพนักงาน", "ตำแหน่ง", "Product", "ตึก", "Server", "DomainName", "รายละเอียด", "เวลาที่แก้ไข"}
        Dim sqll As String = "SELECT * FROM tbl_fdspc WHERE "

        Select Case cbo_type.SelectedItem
            Case "IP" : sqll &= "FDSIP "
            Case "ชื่อเล่น" : sqll &= "FDSNAME "
            Case "ชื่อพนักงาน" : sqll &= "FDSFULLNAME "
            Case "ตำแหน่ง" : sqll &= "FDSPOSITION "
            Case "Product" : sqll &= "FDSPRODUCT "
            Case "ตึก" : sqll &= "FDSFLOOR "
            Case "Server" : sqll &= "FDSSERVER "
            Case "DomainName" : sqll &= "FDSDOMAIN "
            Case "รายละเอียด" : sqll &= "FDSDETAIL "
        End Select

        sqll &= $"LIKE '{txt_find.Text}%' ORDER BY CAST(PARSENAME(REPLACE(FDSIP, ':', '.'), 4) as int),
    CAST(PARSENAME(Replace(FDSIP, ':', '.'), 3) as int),
    CAST(PARSENAME(Replace(FDSIP, ':', '.'), 2) as int),
    CAST(PARSENAME(Replace(FDSIP, ':', '.'), 1) as int)"            '// แสดงข้อมูลแบบเรียง IP จาก 192.168.1.1-192.168.1.255

        Dim cmd As New SqlCommand(sqll, cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim DS As New DataSet()
        DA.Fill(DS, "find")

        For i = 0 To search.Length - 1

            dtgvip.DataSource = DS.Tables("find")
            dtgvip.Columns(i).HeaderText = search(i)

        Next

        cn.Close()

    End Sub

    Private Sub dtgvip_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvip.CellClick
        txt_ip.Text = dtgvip.CurrentRow.Cells(0).Value
        txt_name.Text = dtgvip.CurrentRow.Cells(1).Value
        txt_fullname.Text = dtgvip.CurrentRow.Cells(2).Value
        txt_position.Text = dtgvip.CurrentRow.Cells(3).Value
        txt_product.Text = dtgvip.CurrentRow.Cells(4).Value                         '// คลิกที่ Cell ไหนให้นำข้อมูลทั้งแถวมาแสดงบน Text
        txt_floor.Text = dtgvip.CurrentRow.Cells(5).Value
        txt_server.Text = dtgvip.CurrentRow.Cells(6).Value
        txt_domain.Text = dtgvip.CurrentRow.Cells(7).Value
        txt_detail.Text = dtgvip.CurrentRow.Cells(8).Value
        dtp_edit.Text = dtgvip.CurrentRow.Cells(9).Value

    End Sub

    Private Sub cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click
        connect()
        If txt_ip.Text = "" Then
            Msg_error("กรุณาเลือกข้อมูลจากตาราง หรือ กรอกข้อมูลช่อง IP ด้วยครับ")
            Return
        End If
        sql = $"update tbl_fdspc SET FDSNAME = '{txt_name.Text}',FDSFULLNAME = '{txt_fullname.Text}',FDSPOSITION = '{txt_position.Text}',FDSPRODUCT = '{txt_product.Text}',FDSFLOOR = '{txt_floor.Text}',FDSSERVER  = '{txt_server.Text}',FDSDOMAIN = '{txt_domain.Text}',FDSDETAIL = '{txt_detail.Text}',FDSEDIT = GETDATE() WHERE FDSIP = '{txt_ip.Text}'"
        connect()
        cmd = New SqlCommand(sql, cn)
        Dim cq As Integer = cmd.ExecuteNonQuery()
        If cq > 0 Then
            Msg_OK("คุณอัพเดท ข้อมูลสำเร็จ !")
            _Getlogdata($"แก้ไขข้อมูล IP {txt_ip.Text} ชื่อ {txt_fullname.Text} ตำแหน่ง {txt_position.Text} Product {txt_product.Text}")
            refreshIP()
            Return

        Else

            Msg_error("อัพเดท ข้อมูลล้มเหลว !")
            Return

        End If

        cn.Close()

    End Sub

    Private Sub txt_ip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ip.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 '// key code ของตัวเลขจะอยู่ระหว่าง 48 ถึง 57 ซึ่ง 48 คือเลข 0 57 คือเลข 9 ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 '// ปุ่ม backspace = 8,ปุ่ม enter = 13,ปุ่ม delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Msg_error("กรุณากรอกตัวเลข")
        End Select
    End Sub

    Private Sub FrmmanageIP_closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        cn.Close()
        Me.Dispose()
    End Sub
    'Delete Data Rows 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_delete.Click

        If Msg_confirm("คุณต้องการลบข้อมูลใช่หรือไม่") = vbYes Then

            _Getlogdata($"ลบข้อมูล IP {txt_ip.Text} ชื่อ {txt_name.Text} Product {txt_product.Text} รายละเอียด {txt_detail.Text} ")

            _cleartext()

            connect()

            sql = $"update tbl_fdspc SET FDSNAME = '{txt_name.Text}',FDSFULLNAME = '{txt_fullname.Text}',FDSPOSITION = '{txt_position.Text}',FDSPRODUCT = '{txt_product.Text}',FDSFLOOR = '{txt_floor.Text}',FDSSERVER  = '{txt_server.Text}',FDSDOMAIN = '{txt_domain.Text}',FDSDETAIL = '{txt_detail.Text}',FDSEDIT = GETDATE() WHERE FDSIP = '{txt_ip.Text}'"

            cmd = New SqlCommand(sql, cn)
            Dim cq As Integer = cmd.ExecuteNonQuery()
            If cq > 0 Then

                Msg_OK("คุณอัพเดท ข้อมูลสำเร็จ !")
                refreshIP()
                Return
            End If
        End If

        cn.Close()

    End Sub
    'Preview information 
    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click

        connect()

        Dim search() As String = {"IP", "ชื่อเล่น", "ชื่อพนักงาน", "ตำแหน่ง", "Product", "ตึก", "Server", "DomainName", "รายละเอียด", "เวลาที่แก้ไข"}

        sql = $"SELECT * FROM tbl_fdspc WHERE "

        Select Case cbo_type.SelectedItem
            Case "ตำแหน่ง" : sql &= "FDSPOSITION "
            Case "Product" : sql &= "FDSPRODUCT "
            Case "ตึก" : sql &= "FDSFLOOR "
        End Select

        sql &= $"= '{cbo_filter.Text}' ORDER BY CAST(PARSENAME(REPLACE(FDSIP, ':', '.'), 4) as int),
    CAST(PARSENAME(Replace(FDSIP, ':', '.'), 3) as int),
    CAST(PARSENAME(Replace(FDSIP, ':', '.'), 2) as int),
    CAST(PARSENAME(Replace(FDSIP, ':', '.'), 1) as int)"            '// แสดงข้อมูลแบบเรียง IP จาก 192.168.1.1-192.168.1.255

        Dim cmd As New SqlCommand(sql, cn)
        Dim DA As New SqlDataAdapter(cmd)
        Dim DS As New DataSet()
        DA.Fill(DS, "find")

        For i = 0 To search.Length - 1
            dtgvip.DataSource = DS.Tables("find")
            dtgvip.Columns(i).HeaderText = search(i)
        Next

        cn.Close()

    End Sub
    'Filter information and Sort Rows
    Private Sub chk_filter_CheckedChanged(sender As Object, e As EventArgs) Handles chk_filter.CheckedChanged

        Dim states() As String = {"T1/1", "T1/2", "T1/3", "T1/4", "T2/1", "T2/2", "T3/1", "T3/2"}
        Dim Products() As String = {"TMB", "TBANK", "Execution", "UOB", "AYCAL", "KKB", "TSS", "Legal", "SCB", "MIS", "KBANK"}
        Dim Ranks() As String = {"NetworkDrive", "Printer", "ROUTER", "Manager", "Support", "COLLECTOR"}

        If chk_filter.Checked = True Then
            cbo_filter.Enabled = True
            cbo_type.Enabled = False

            If cbo_type.SelectedItem = "ตึก" Then
                cbo_filter.SelectedItem = Nothing
                cbo_filter.Items.Clear()
                cbo_filter.Items.AddRange(states)
                cbo_filter.SelectedItem = 0
                Return
            End If

            If cbo_type.SelectedItem = "ตำแหน่ง" Then
                cbo_filter.SelectedItem = Nothing
                cbo_filter.Items.Clear()
                cbo_filter.Items.AddRange(Ranks)
                cbo_filter.SelectedItem = 0
                Return
            End If

            If cbo_type.SelectedItem = "Product" Then
                cbo_filter.SelectedItem = Nothing
                cbo_filter.Items.Clear()
                cbo_filter.Items.AddRange(Products)
                cbo_filter.SelectedItem = 0
                Return
            End If

            Msg_error("กรุณาเลือกประเภทข้อมูลต่อไปนี้ ตึก,ตำแหน่ง,โปรดักส์")
            chk_filter.Checked = False
            cbo_type.Enabled = True
            Return
        Else
            cbo_type.Enabled = True
            cbo_filter.Enabled = False
        End If
    End Sub
    ' button  migrate IP 
    Private Sub cmd_migrate_ip_Click(sender As Object, e As EventArgs) Handles cmd_migrate_ip.Click

        connect()

        If Msg_confirm("คุณต้องการเปลี่ยน ย้ายข้อมูล IP Address นี้ใช่หรือไม่") = vbYes Then

            If txt_migrate_ip.Text = "" Then

                Msg_error("กรุณากรอก IP ที่ต้องการย้ายข้อมูล")

            Else
                sql = $"SELECT * FROM tbl_fdspc WHERE FDSIP = '{txt_migrate_ip.Text}'"
                cmd.CommandText = sql
                DA.SelectCommand = cmd
                DA.Fill(DS, "tables")

                If DS.Tables("tables").Rows.Count = 0 Then

                    Msg_confirm("ไม่พบ IP นี้ในระบบกรุณากรอกข้อมูล ให้ถูกต้อง")
                    Exit Sub

                End If

                Dim check_ip As String = DS.Tables("tables").Rows(0)("FDSNAME").ToString

                    If check_ip <> "" Then

                        MsgBox("IP นี้มีผู้ใช้อยู่แล้ว กรุณารองอีกครั้ง")
                        Exit Sub

                    Else

                        sql = $"UPDATE tbl_fdspc SET FDSNAME = '{txt_name.Text}',FDSFULLNAME = '{txt_fullname.Text}',FDSPOSITION = '{txt_position.Text}',FDSPRODUCT = '{txt_product.Text}',FDSFLOOR = '{txt_floor.Text}',FDSSERVER ='{txt_server.Text}',FDSDOMAIN ='{txt_domain.Text}',FDSDETAIL = '{txt_detail.Text}',FDSEDIT = GETDATE() WHERE FDSIP = '{txt_migrate_ip.Text}';"
                        sql &= $"Update tbl_fdspc SET FDSNAME = '',FDSFULLNAME = '',FDSPOSITION = '',FDSPRODUCT = '',FDSFLOOR = '',FDSSERVER ='',FDSDOMAIN ='',FDSDETAIL = '',FDSEDIT = GETDATE() WHERE FDSIP = '{txt_ip.Text}'"
                        cmd = New SqlCommand(sql, cn)
                        Dim _execute As Integer = cmd.ExecuteNonQuery()

                        If _execute > 0 Then

                            Msg_OK("แก้ไขข้อมูลสำเร็จ")
                            _Getlogdata($"ย้ายข้อมูล IP {txt_ip.Text} ไปยัง IP {txt_migrate_ip.Text} ชื่อ {txt_name.Text}")
                            cn.Close()
                            refreshIP()
                            _cleartext()
                        Else

                            Msg_error("เกิดข้อผิดพลาด กรุณาลองใหม่อีกครั้ง")
                            _cleartext()
                            cn.Close()
                            refreshIP()
                        End If

                    End If

                End If

            End If

    End Sub

    Private Sub _cleartext()
        txt_name.Text = ""
        txt_fullname.Text = ""
        txt_position.Text = ""
        txt_product.Text = ""
        txt_floor.Text = ""
        txt_server.Text = ""
        txt_domain.Text = ""
        txt_detail.Text = ""

    End Sub

End Class
