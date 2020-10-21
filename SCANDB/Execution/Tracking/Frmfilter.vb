Option Explicit On
Imports System.Data
Imports System.Data.SqlClient
Public Class Frmfilter
    '## เพิ่ม ข้อมูล ตาราง EXEEMOPLOYEES ใน Combox โดยนำข้อมูลจาก Columns EXEEMPLOYEES มาเพิ่ม โดยใช้ SUB _comboboxadd() มี Parameter 3 ตัว
    'คือ(ชื่อCombobox,ชื่อColumns,ชื่อTable)
    Private Sub Frmfillter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtgv_filter.Visible = False
        cbo_empexe.Enabled = False

        connect()

        '## Datetimepicker เปลี่ยน Format Custom เป็น "dd-MMM-yy"
        Datetimeformatshort(dtp_date_end)
        Datetimeformatshort(dtp_date_start)

        sql = $"SELECT DISTINCT EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '02-EXECUTION'"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()
        While DR.Read()

            cbo_empexe.Items.Add($"{DR("EXEEMPLOYEES")}")

        End While

        DR.Close()

    End Sub
    '## สร้าง condition ให้ Checkbox 
    Private Sub Chk_empexe_CheckedChanged(sender As Object, e As EventArgs) Handles chk_empexe.CheckedChanged

        If chk_empexe.Checked = True Then

            cbo_empexe.Enabled = True
        Else
            cbo_empexe.Enabled = False
        End If

    End Sub

    Private Sub Cmd_search_Click(sender As Object, e As EventArgs) Handles cmd_search.Click
        '## เช็ค สถานะการเชื่อมต่อฐานข้อมูล ถ้าถูกปิดอยู่ให้เปิดใช้งาน
        Connect()

        Cleardatagrid(dtgv_filter)

        '## Array เพิ่ม columnsHeadertext
        Dim _headertext() As String = {"ธนาคาร", "เลขบัตรประชาชน", "ชื่อ-นามสกุล", "ศาล", "คดีแดง", "วันที่ในใบคำร้อง", "รายละเอียด", "ใบงาน", "ตรวจสอบการส่ง", "เพิ่มเติม", "ตรวจพบเงิน", "ชื่อพนักงานบังคับคดี"}

        '## Query ข้อมูล โดย WHERE วันที่ในใบคำร้อง แล้วใช้ Between And กำหนด ขอบเขตข้อมูล

        sql = $"SELECT ET.Customer_owner,ET.Customer_idc,ET.Customer_fullname,ET.Tracking_court,ET.Tracking_red,ET.Tracking_date_sheet,ET.Tracking_detail,ET.Tracking_nosheet,ET.Tracking_Collector_nosend,ET.Tracking_other,Tracking_Total,EMP.EXEEMPLOYEES
          FROM EXETRACKING AS ET 
          LEFT JOIN EXEEMPLOYEE AS EMP 
          ON ET.EMPLOYEES_KEY = EMP.EMPLOYEES_KEY 
          WHERE ET.Tracking_date_sheet BETWEEN @datestart AND @dateend"

        '## ใช้ Checkbox กำหนด เงื่อนไขข้อมูล ถ้าถูกติ๊กให้ เพิ่ม ขอบเขตของ พนักงานบังคับคดี ในการค้นหาด้วย
        If chk_empexe.Checked = True Then

            sql &= $" AND EMP.EXEEMPLOYEES = @employee ORDER BY Tracking_primary"
        Else
            sql &= "ORDER BY Tracking_primary ;"

        End If


        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("datestart", dtp_date_start.Text)
        cmd.Parameters.AddWithValue("dateend", dtp_date_end.Text)
        cmd.Parameters.AddWithValue("employee", cbo_empexe.Text)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "filter")

        '## นับจำนวนทั้งหมดใน Dataset "filter" แล้วนำมาแสดงใน Lable

        lbl_result.Text = "พบ" & DS.Tables("filter").Rows.Count.ToString & "รายการ"

        With dtgv_filter
            '## วางข้อมูลใน Datagridview โดยใช้ Method DataSource
            .DataSource = DS.Tables("filter")

            '## ใช้ Loop For เพิ่มข้อมูลในส่วนหัวของตาราง หรือ ชื่อคอลัมน์ โดยนับขอบเขต Loop จากจำนวนคอลัมน์ แล้วใช้ Method .Columns().HeaderText ในการเพิ่มข้อมูลชื่อคอลัมน์

            For i = 0 To dtgv_filter.ColumnCount - 1
                .Columns(i).HeaderText = _headertext(i)
            Next

        End With
        Datagrid_format_dateshort(dtgv_filter, 5)
        '## Method visible สั่งให้แสดง Datagird โดย ผลลัพย์ในการกำหนดเป็น Boolean
        dtgv_filter.Visible = True

        '## สั่งปิดการเชื่อมต่อฐานข้อมูล
        cn.Close()
    End Sub

    '## สั่งปิดฟอร์ม ให้ปิดฐานข้อมูล ทั้งหมด 
    Private Sub Frmfilter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        cn.Close()
        Me.Dispose()

    End Sub
End Class