Option Explicit on
Imports System.Data.SqlClient
Public Class FrmMainExecution
    Private Sub FrmMainExecution_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connect()



        sql = "SELECT DISTINCT Customer_Owner FROM Execution_Customer ORDER BY Customer_Owner DESC"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            Cbo_Customer_Owner.Items.Add($"{DR("Customer_Owner")}")
        End While

        DR.Close()
        Cbo_Customer_Owner.SelectedIndex = -1

        sql = "SELECT DISTINCT EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '02-EXECUTION';"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            Cbo_Action_Employee.Items.Add($"{DR("EXEEMPLOYEES")}")
        End While

        DR.Close()
        Cbo_Action_Employee.SelectedIndex = -1

        Dim Response_Combobox() As String = {"เลขบัตรประชาชน", "เลขที่สัญญา", "ชื่อลูกค้า", "นามสกุล", "เลขที่คดีดำ", "เลขที่คดีแดง", "พนักงานบังคับคดี"}

        CboArray(Cbo_Main_find, Response_Combobox)


        'Actions Accounting/RepeatFreeze

        sql = "SELECT DISTINCT EXEEMPLOYEES FROM EXEEMPLOYEE WHERE EXEJOB = '02-EXECUTION';"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            Cbo_Account_Employee.Items.Add($"{DR("EXEEMPLOYEES")}")
        End While

        DR.Close()
        Cbo_Account_Employee.SelectedIndex = -1

        ' Add data to inside combobox

        sql = "SELECT DISTINCT ACCSTATUS FROM EXEACC ;"
        cmd = New SqlCommand(sql, cn)
        DR = cmd.ExecuteReader()

        While DR.Read()
            Cbo_Account_Status.Items.Add($"{DR("ACCSTATUS")}")
        End While

        DR.Close()

        Cbo_Account_Status.SelectedIndex = -1


        ReadOnlyText()



    End Sub

    Private Sub Cmd_LinkDatabase_Click(sender As Object, e As EventArgs) Handles Cmd_LinkDatabase.Click

        LinkDatabase()

        Select Case Cbo_Customer_Owner.SelectedItem

            Case "KBANK" : Txt_Customer_Bank.Text = "ธนาคารกสิกรไทย จำกัด (มหาชน)"
            Case "TMB" : Txt_Customer_Bank.Text = "ธนาคารทหารไทย จำกัด (มหาชน)"
            Case "SCB" : Txt_Customer_Bank.Text = "ธนาคารไทยพาณิชย์ จํากัด (มหาชน)"
            Case "TBANK" : Txt_Customer_Bank.Text = "ธนาคารธนชาต จํากัด (มหาชน)"
            Case "UOB" : Txt_Customer_Bank.Text = "ธนาคารยูโอบี จำกัด (มหาชน)"
            Case "TMB SME" : Txt_Customer_Bank.Text = "ธนาคารทหารไทย จำกัด (มหาชน)"

        End Select

    End Sub

    Private Sub Cmd_Income_Find_Click(sender As Object, e As EventArgs) Handles Cmd_Main_Find.Click

        FindExecution()

    End Sub

    Public Sub LinkDatabase()

        Select Case Cbo_Customer_Owner.SelectedItem

            Case "TSS" : Connect_(cn_GE)

                sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSTYP,RFCUS.CUSLNO,RFCUS.CUSPRO,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Customer_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_GE)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                    Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Customer_Fullname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                    Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Customer_Billcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                    Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                    Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                    Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                    Select Case Txt_Customer_Productcode.Text
                        Case "CPL", "GPC", "TCP", "FC", "NFC", "TIN", "TIP", "PB", "HFC", "MHF" : Txt_Customer_Bank.Text = "บริษัท อยุธยา แคปปิตอล เซอร์วิสเซส จำกัด"
                        Case "CCC", "CCM", "RBV", "HPR", "CCP" : Txt_Customer_Bank.Text = "บริษัท เจเนอรัล คาร์ด เซอร์วิสเซส จำกัด"
                        Case "TES", "LTS", "TPL" : Txt_Customer_Bank.Text = "บริษัท เทสโก้ คาร์ด เซอร์วิสเซส จำกัด"
                        Case "KCC", "KSM", "HPK", "HPR", "KHB", "KPL", "AYCC", "AYJC", "AYPL", "KJC", "HME", "TKCC", "TKJC" : Txt_Customer_Bank.Text = "บริษัท บัตรกรุงศรีอยุธยา จำกัด"
                    End Select


                Else

                    sqll = $"Select RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSTYP,RFCUS.CUSLNO,RFCUS.CUSPRO,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN.RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW On RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_GE)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                        Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Customer_Fullname.Text = $"{DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN")} {DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN")}"
                        Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Customer_Billcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                        Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                        Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                        Select Case Txt_Customer_Productcode.Text
                            Case "CPL", "GPC", "TCP", "FC", "NFC", "TIN", "TIP", "PB", "HFC", "MHF" : Txt_Customer_Bank.Text = "บริษัท อยุธยา แคปปิตอล เซอร์วิสเซส จำกัด"
                            Case "CCC", "CCM", "RBV", "HPR", "CCP" : Txt_Customer_Bank.Text = "บริษัท เจเนอรัล คาร์ด เซอร์วิสเซส จำกัด"
                            Case "TES", "LTS", "TPL" : Txt_Customer_Bank.Text = "บริษัท เทสโก้ คาร์ด เซอร์วิสเซส จำกัด"
                            Case "KCC", "KSM", "HPK", "HPR", "KHB", "KPL", "AYCC", "AYJC", "AYPL", "KJC", "HME", "TKCC", "TKJC" : Txt_Customer_Bank.Text = "บริษัท บัตรกรุงศรีอยุธยา จำกัด"
                        End Select

                    Else

                        Connect_(cnLegal)

                        sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"
                        cmdlegal = New SqlCommand(sqll, cnLegal)
                        DALegal = New SqlDataAdapter(cmdlegal)
                        DSLegal = New DataSet
                        DALegal.Fill(DSLegal, "linklegal")

                        If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                            Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                            Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                            Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                            Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                            Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                            Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                            Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                            Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                            Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                            Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                            Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                            Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString


                        Else

                            sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Txt_Customer_Account.Text}'"
                            cmdlegal = New SqlCommand(sqll, cnLegal)
                            DALegal = New SqlDataAdapter(cmdlegal)
                            DSLegal = New DataSet
                            DALegal.Fill(DSLegal, "linklegal")

                            If DSLegal.Tables("linklegal").Rows.Count > 0 Then


                                Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                                Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                                Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                                Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                                Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                                Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                                Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                                Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                                Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                                Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                                Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                                Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                            End If
                        End If
                        cnLegal.Close()

                    End If

                End If

            Case "KBANK" : Connect_(cn_KBANK)

                sqll = $"SELECT RFCUS.CUSUSG, RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Customer_Account.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                    Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Customer_No.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                    Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Customer_Fullname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                    Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                Else
                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSACC = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_KBANK)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                        Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Customer_No.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSACC").ToString
                        Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Customer_Fullname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                        Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                    Else


                        Connect_(cnLegal)

                        sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"
                        cmdlegal = New SqlCommand(sqll, cnLegal)
                        DALegal = New SqlDataAdapter(cmdlegal)
                        DSLegal = New DataSet
                        DALegal.Fill(DSLegal, "linklegal")

                        If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                            Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                            Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                            Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                            Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                            Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                            Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                            Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                            Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                            Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                            Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                            Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                            Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                        Else

                            sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Txt_Customer_Account.Text}'"
                            cmdlegal = New SqlCommand(sqll, cnLegal)
                            DALegal = New SqlDataAdapter(cmdlegal)
                            DSLegal = New DataSet
                            DALegal.Fill(DSLegal, "linklegal")

                            If DSLegal.Tables("linklegal").Rows.Count > 0 Then


                                Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                                Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                                Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                                Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                                Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                                Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                                Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                                Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                                Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                                Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                                Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                                Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                            End If
                        End If
                        cnLegal.Close()

                    End If

                End If

                cn_KBANK.Close()

            Case "KKB" : Connect_(cn_KKB)

                sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Customer_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_KKB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                    Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Customer_Fullname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Customer_Billcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                    Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                    Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                    Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                Else

                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_KKB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                        Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Customer_Fullname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Customer_Billcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                        Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                        Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                    Else


                        Connect_(cnLegal)

                        sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"
                        cmdlegal = New SqlCommand(sqll, cnLegal)
                        DALegal = New SqlDataAdapter(cmdlegal)
                        DSLegal = New DataSet
                        DALegal.Fill(DSLegal, "linklegal")

                        If DSLegal.Tables("linklegal").Rows.Count > 0 Then


                            Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                            Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                            Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                            Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                            Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                            Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                            Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                            Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                            Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                            Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                            Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                            Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                        Else

                            sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Txt_Customer_Account.Text}'"
                            cmdlegal = New SqlCommand(sqll, cnLegal)
                            DALegal = New SqlDataAdapter(cmdlegal)
                            DSLegal = New DataSet
                            DALegal.Fill(DSLegal, "linklegal")

                            If DSLegal.Tables("linklegal").Rows.Count > 0 Then


                                Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                                Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                                Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                                Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                                Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                                Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                                Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                                Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                                Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                                Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                                Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                                Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                            End If
                        End If
                        cnLegal.Close()

                    End If
                End If

                cn_KKB.Close()

            Case "SCB" : Connect_(cn_SCB)

                sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Customer_Account.Text}'"
                cmd_Collec = New SqlCommand(sqll, cn_SCB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                    Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Customer_Fullname.Text = $"{Txt_Customer_Firstname.Text} {Txt_Customer_Lastname.Text}"
                    Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                    Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                    Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                Else

                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSCNO,RFCUS.CUSIDC,RFCUS.CUSACC,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"
                    cmd_Collec = New SqlCommand(sqll, cn_SCB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                        Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Customer_Fullname.Text = $"{Txt_Customer_Firstname.Text} {Txt_Customer_Lastname.Text}"
                        Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                        Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                    Else


                        Connect_(cnLegal)

                        sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"
                        cmdlegal = New SqlCommand(sqll, cnLegal)
                        DALegal = New SqlDataAdapter(cmdlegal)
                        DSLegal = New DataSet
                        DALegal.Fill(DSLegal, "linklegal")

                        If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                            Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                            Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                            Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                            Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                            Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                            Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                            Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                            Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                            Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                            Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                            Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                            Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString


                        Else

                            sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Txt_Customer_Account.Text}'"
                            cmdlegal = New SqlCommand(sqll, cnLegal)
                            DALegal = New SqlDataAdapter(cmdlegal)
                            DSLegal = New DataSet
                            DALegal.Fill(DSLegal, "linklegal")

                            If DSLegal.Tables("linklegal").Rows.Count > 0 Then


                                Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                                Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                                Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                                Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                                Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                                Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                                Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                                Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                                Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                                Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                                Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                                Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                            End If
                        End If
                        cnLegal.Close()


                    End If
                End If

                cn_SCB.Close()

            Case "TMB" : Connect_(cn_TMB)
                sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Customer_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TMB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                    Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Customer_Fullname.Text = $"{Txt_Customer_Firstname.Text} {Txt_Customer_Lastname.Text}"
                    Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Customer_Billcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                    Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                    Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                    Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                Else
                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                        Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Customer_Fullname.Text = $"{Txt_Customer_Firstname.Text} {Txt_Customer_Lastname.Text}"
                        Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Customer_Billcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                        Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                        Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                    Else


                        Connect_(cnLegal)

                        sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"
                        cmdlegal = New SqlCommand(sqll, cnLegal)
                        DALegal = New SqlDataAdapter(cmdlegal)
                        DSLegal = New DataSet
                        DALegal.Fill(DSLegal, "linklegal")

                        If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                            Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                            Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                            Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                            Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                            Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                            Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                            Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                            Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                            Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                            Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                            Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                            Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString


                        Else

                            sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Txt_Customer_Account.Text}'"
                            cmdlegal = New SqlCommand(sqll, cnLegal)
                            DALegal = New SqlDataAdapter(cmdlegal)
                            DSLegal = New DataSet
                            DALegal.Fill(DSLegal, "linklegal")

                            If DSLegal.Tables("linklegal").Rows.Count > 0 Then


                                Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                                Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                                Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                                Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                                Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                                Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                                Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                                Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                                Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                                Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                                Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                                Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                            End If
                        End If

                        cnLegal.Close()

                    End If
                    cn_TMB.Close()

                End If

            Case "TMB SME" : Connect_(cn_TMBSME)
                sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Customer_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                    Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Customer_Fullname.Text = $"{Txt_Customer_Firstname.Text} {Txt_Customer_Lastname.Text}"
                    Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Customer_Billcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                    Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                    Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                    Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                Else
                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSLNO,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO = RFLAW.LAWCNO WHERE RFCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TMBSME)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")


                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                        Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Customer_Fullname.Text = $"{Txt_Customer_Firstname.Text} {Txt_Customer_Lastname.Text}"
                        Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Customer_Billcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSLNO").ToString
                        Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                        Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                    End If

                End If

                cn_TMBSME.Close()

            Case "TBANK" : Connect_(cn_TBANK)

                sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSACC,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Txt_Customer_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                    Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Customer_Fullname.Text = $"{Txt_Customer_Firstname.Text} {Txt_Customer_Lastname.Text}"
                    Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                    Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                    Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString

                Else
                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFLAW.LAWSAN,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_TBANK)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                        Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Customer_Fullname.Text = $"{Txt_Customer_Firstname.Text} {Txt_Customer_Lastname.Text}"
                        Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                        Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                    Else


                        Connect_(cnLegal)

                        sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"
                        cmdlegal = New SqlCommand(sqll, cnLegal)
                        DALegal = New SqlDataAdapter(cmdlegal)
                        DSLegal = New DataSet
                        DALegal.Fill(DSLegal, "linklegal")

                        If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                            Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                            Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                            Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                            Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                            Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                            Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                            Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                            Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                            Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                            Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                            Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                            Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString


                        Else

                            sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Txt_Customer_Account.Text}'"
                            cmdlegal = New SqlCommand(sqll, cnLegal)
                            DALegal = New SqlDataAdapter(cmdlegal)
                            DSLegal = New DataSet
                            DALegal.Fill(DSLegal, "linklegal")

                            If DSLegal.Tables("linklegal").Rows.Count > 0 Then


                                Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                                Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                                Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                                Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                                Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                                Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                                Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                                Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                                Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                                Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                                Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                                Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                            End If
                        End If

                        cnLegal.Close()

                    End If

                End If
                cn_TBANK.Close()

            Case "UOB" : Connect_(cn_UOB)

                sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE RFCUS.CUSCNO = '{Txt_Customer_Account.Text}'"

                cmd_Collec = New SqlCommand(sqll, cn_UOB)
                DA_Collec = New SqlDataAdapter(cmd_Collec)
                DS_Collec = New DataSet
                DA_Collec.Fill(DS_Collec, "LINKdB")

                If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                    Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                    Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                    Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                    Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                    Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                    Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                    Txt_Customer_Fullname.Text = $"{Txt_Customer_Firstname.Text} {Txt_Customer_Lastname.Text}"
                    Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                    Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                    Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                    Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                    Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                    Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                Else


                    sqll = $"SELECT RFCUS.CUSUSG,RFCUS.CUSIDC,RFCUS.CUSCNO,RFCUS.CUSTFN,RFLAW.LAWSAN,RFCUS.CUSTLN,RFCUS.CUSTYP,RFCUS.CUSPRO,RFCUS.CUSBLK,RFLAW.LAWSAN,RFLAW.LAWRED,RFLAW.LAWBLK,RFCUS.CUSUSA FROM RFCUS LEFT JOIN RFLAW ON RFCUS.CUSCNO =RFLAW.LAWCNO WHERE  RFCUS.CUSCNO = '{Txt_Customer_Account.Text}'"

                    cmd_Collec = New SqlCommand(sqll, cn_UOB)
                    DA_Collec = New SqlDataAdapter(cmd_Collec)
                    DS_Collec = New DataSet
                    DA_Collec.Fill(DS_Collec, "LINKdB")

                    If DS_Collec.Tables("LINKdB").Rows.Count > 0 Then

                        Cbo_Customer_Hub.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSG").ToString
                        Txt_Customer_Account.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSCNO").ToString
                        Txt_Customer_Court.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWSAN").ToString
                        Txt_Customer_Idc.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSIDC").ToString
                        Txt_Customer_Firstname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTFN").ToString
                        Txt_Customer_Lastname.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTLN").ToString
                        Txt_Customer_Fullname.Text = $"{Txt_Customer_Firstname.Text} {Txt_Customer_Lastname.Text}"
                        Txt_Customer_Black.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWBLK").ToString
                        Txt_Customer_Red.Text = DS_Collec.Tables("LINKdB").Rows(0)("LAWRED").ToString
                        Txt_Customer_Type.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSTYP").ToString
                        Txt_Customer_Productcode.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSPRO").ToString
                        Txt_Customer_Block.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSBLK").ToString
                        Txt_Collector_User.Text = DS_Collec.Tables("LINKdB").Rows(0)("CUSUSA").ToString
                    Else

                        Connect_(cnLegal)

                        sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSCUS,dbCUS.CUSACC,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE dbCUS.CUSIDC = '{Txt_Customer_Idc.Text}'"
                        cmdlegal = New SqlCommand(sqll, cnLegal)
                        DALegal = New SqlDataAdapter(cmdlegal)
                        DSLegal = New DataSet
                        DALegal.Fill(DSLegal, "linklegal")

                        If DSLegal.Tables("linklegal").Rows.Count > 0 Then

                            Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                            Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                            Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                            Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                            Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                            Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                            Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                            Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                            Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                            Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                            Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                            Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString


                        Else

                            sqll = $"Select dbCUS.CUSFNAM,dbCUS.CUSLNAM,dbCUS.CUSNAM,dbCUS.CUSACC,dbCUS.CUSCUS,dbCUS.CUSIDC,dbCUS.CUSTOWN,dbCUS.CUSCLS,dbCUS.CUSBUC,dbCUS.CUSPRO,dbLAW.LAWCOU,dbLAW.LAWBLK,dbLAW.LAWRED FROM dbCUS LEFT JOIN dbLAW On dbCUS.CUSACC = dbLAW.LAWACC WHERE  dbCUS.CUSACC = '{Txt_Customer_Account.Text}'"
                            cmdlegal = New SqlCommand(sqll, cnLegal)
                            DALegal = New SqlDataAdapter(cmdlegal)
                            DSLegal = New DataSet
                            DALegal.Fill(DSLegal, "linklegal")

                            If DSLegal.Tables("linklegal").Rows.Count > 0 Then


                                Txt_Customer_Firstname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSFNAM").ToString
                                Txt_Customer_Lastname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSLNAM").ToString
                                Txt_Customer_Fullname.Text = DSLegal.Tables("linklegal").Rows(0)("CUSNAM").ToString
                                Txt_Customer_Red.Text = DSLegal.Tables("linklegal").Rows(0)("LAWRED").ToString
                                Txt_Customer_Court.Text = DSLegal.Tables("linklegal").Rows(0)("LAWCOU").ToString
                                Txt_Customer_Black.Text = DSLegal.Tables("linklegal").Rows(0)("LAWBLK").ToString
                                Txt_Customer_Account.Text = DSLegal.Tables("linklegal").Rows(0)("CUSACC").ToString
                                Txt_Customer_No.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCUS").ToString
                                Txt_Customer_Idc.Text = DSLegal.Tables("linklegal").Rows(0)("CUSIDC").ToString
                                Txt_Customer_Billcode.Text = DSLegal.Tables("linkLegal").Rows(0)("CUSCLS").ToString
                                Txt_Customer_Type.Text = DSLegal.Tables("linklegal").Rows(0)("CUSBUC").ToString
                                Txt_Customer_Productcode.Text = DSLegal.Tables("linklegal").Rows(0)("CUSPRO").ToString

                            End If

                            cnLegal.Close()


                        End If

                    End If
                End If
                cn_UOB.Close()


        End Select

    End Sub

    Private Sub FindExecution()

        Dim Response_Entity() As String = {"Primary", "Product", "เลขที่บัตรประชาชน", "เลขที่สัญญา", "ชื่อ-นามสกุล", "เลขที่คดีดำ", "เลขที่คดีแดง", "Status", "พนักงานบังคับคดี", "วันที่ดำเนินการ"}

        Connect()

        Cleardatagrid(Dtgv_Main_find)

        If Txt_Main_find.Text = "" Then

            Msg_error("กรุณากรอกข้อมุลที่ต้องการค้นหา")
            Return

        End If

        sql = $"SELECT EC.Customer_Primary,EC.Customer_Owner,EC.Customer_idc,EC.Customer_Account,EC.Customer_Fullname,EC.Customer_Black,EC.Customer_Red,EA.Execution_Status,Emp.EXEEMPLOYEES,EA.Execution_Actions_Date FROM Execution_Customer AS EC LEFT JOIN Execution_Actions AS EA On EC.Customer_Account = EA.Customer_Account LEFT JOIN EXEEMPLOYEE AS EMP ON EA.EMPLOYEES_KEY = EMP.EMPLOYEES_KEY "

        Select Case Cbo_Main_find.SelectedItem

            Case "เลขที่สัญญา" : sql &= $"WHERE EC.Customer_Account"
            Case "เลขบัตรประชาชน" : sql &= "WHERE EC.Customer_idc"
            Case "ชื่อลูกค้า" : sql &= "WHERE EC.Customer_firstname"
            Case "นามสกุล" : sql &= "WHERE EC.Customer_lastname"
            Case "เลขที่คดีดำ" : sql &= "WHERE EC.Customer_Black"
            Case "เลขที่คดีแดง" : sql &= "WHERE EC.Customer_Red"
            Case "พนักงานบังคับคดี" : sql &= "WHERE EMP.EXEEMPLOYEES"

        End Select

        sql &= $" LIKE '%{Txt_Main_find.Text}%' ORDER BY Customer_Owner"


        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "_search")

        If DS.Tables("_search").Rows.Count <= 0 Then

            Msg_error("ไม่พบข้อมูลที่ค้นหา..")
            Lbl_Customer_Response.ForeColor = Color.Red
            Lbl_Customer_Response.Visible = False

            Return

        Else

            With Dtgv_Main_find

                .DataSource = DS.Tables("_search")

                For i = 0 To Response_entity.Length - 1

                    .Columns(i).HeaderText = Response_entity(i)

                Next

                .Columns(0).Visible = False


            End With

            Lbl_Customer_Response.Text = $"พบข้อมูล {Dtgv_Main_find.RowCount} รายการ.."
            Lbl_Customer_Response.ForeColor = Color.Green


        End If

        cn.Close()

    End Sub

    Private Sub Dtgv_Main_find_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dtgv_Main_find.CellClick

        MainQuery()

    End Sub

    Private Sub ReadOnlyText()

        'Customer Object

        Txt_Customer_Bank.ReadOnly = True
        Txt_Customer_No.ReadOnly = True
        Txt_Customer_Account.ReadOnly = True
        Txt_Customer_Idc.ReadOnly = True
        Txt_Customer_Firstname.ReadOnly = True
        Txt_Customer_Lastname.ReadOnly = True
        Txt_Customer_Fullname.ReadOnly = True
        Txt_Customer_Court.ReadOnly = True
        Txt_Customer_Black.ReadOnly = True
        Txt_Customer_Red.ReadOnly = True
        Txt_Customer_Billcode.ReadOnly = True
        Txt_Customer_Type.ReadOnly = True
        Txt_Customer_Productcode.ReadOnly = True
        Txt_Customer_Block.ReadOnly = True
        Txt_Collector_User.ReadOnly = True

        Cbo_Customer_Prefix.Enabled = False
        Cbo_Customer_Hub.Enabled = False
        Cbo_Customer_Owner.Enabled = False

        Dtp_Customer_Date_Add.Enabled = False

        'Account Object

        Txt_Account_Receipt1.ReadOnly = True
        Txt_Receipt_Detail1.ReadOnly = True
        Txt_Account_Receipt2.ReadOnly = True
        Txt_Receipt_Detail2.ReadOnly = True
        Txt_Account_Receipt3.ReadOnly = True
        Txt_Receipt_Detail3.ReadOnly = True
        Txt_Account_Repeat_Detail.ReadOnly = True

        Cbo_Account_Employee.Enabled = False
        Cbo_Account_Status.Enabled = False
        Cbo_Account_Result.Enabled = False
        Cbo_Account_Action.Enabled = False

        Dtp_Account_Date.Enabled = False
        Dtp_Account_Month.Enabled = False




    End Sub

    Private Sub EditText()

        'Customer Object

        Txt_Customer_Bank.ReadOnly = False
        Txt_Customer_No.ReadOnly = False
        Txt_Customer_Account.ReadOnly = False
        Txt_Customer_Idc.ReadOnly = False
        Txt_Customer_Firstname.ReadOnly = False
        Txt_Customer_Lastname.ReadOnly = False
        Txt_Customer_Fullname.ReadOnly = False
        Txt_Customer_Court.ReadOnly = False
        Txt_Customer_Black.ReadOnly = False
        Txt_Customer_Red.ReadOnly = False
        Txt_Customer_Billcode.ReadOnly = False
        Txt_Customer_Type.ReadOnly = False
        Txt_Customer_Productcode.ReadOnly = False
        Txt_Customer_Block.ReadOnly = False
        Txt_Collector_User.ReadOnly = False

        Cbo_Customer_Prefix.Enabled = True
        Cbo_Customer_Hub.Enabled = True
        Cbo_Customer_Owner.Enabled = True

        Dtp_Customer_Date_Add.Enabled = True

        'Account Object

        Txt_Account_Receipt1.ReadOnly = False
        Txt_Receipt_Detail1.ReadOnly = False
        Txt_Account_Receipt2.ReadOnly = False
        Txt_Receipt_Detail2.ReadOnly = False
        Txt_Account_Receipt3.ReadOnly = False
        Txt_Receipt_Detail3.ReadOnly = False
        Txt_Account_Repeat_Detail.ReadOnly = False

        Cbo_Account_Employee.Enabled = True
        Cbo_Account_Status.Enabled = True
        Cbo_Account_Result.Enabled = True
        Cbo_Account_Action.Enabled = True

        Dtp_Account_Date.Enabled = True
        Dtp_Account_Month.Enabled = True


    End Sub


    Private Sub MainQuery()

        Connect()

        sql = $"SELECT EC.Customer_Owner,EC.Customer_Bank,EC.Customer_Hub,EC.Customer_Account,EC.Customer_No,EC.Customer_Idc,EC.Customer_Prefix,EC.Customer_Firstname,EC.Customer_Lastname,EC.Customer_Fullname,EC.Customer_Court,EC.Customer_Black,EC.Customer_Red,EC.Customer_Date_Add,EC.Customer_Billcode,EC.Customer_Type,EC.Customer_Productcode,EC.Customer_Block,EC.Collector_User,EA.ACCSTATUS,EA.ACCDATE,EA.ACCRECEIPT,EA.ACCRECEIPT_DETAIL,EA.ACCRECEIPT_OTHER_2,EA.ACCRECEIPT_OTHER_DETAIL2,EA.ACCRECEIPT_OTHER_3,EA.ACCRECEIPT_OTHER_DETAIL3,EA.ACCMONTH,EA.ACCRESULT,EA.ACCACTION,EMP.EXEEMPLOYEES
            FROM Execution_Customer AS EC 
            LEFT JOIN EXEACC AS EA ON EC.Customer_Account = EA.ACCACC
            LEFT JOIN EXEEMPLOYEE AS EMP ON EA.EMPLOYEES_KEY = EMP.EMPLOYEES_KEY

            WHERE EC.Customer_Account = '{Dtgv_Main_find.CurrentRow.Cells(3).Value}' ORDER BY ACCDATE DESC "

        cmd = New SqlCommand(sql, cn)
        DA = New SqlDataAdapter(cmd)
        DS = New DataSet
        DA.Fill(DS, "Customer")

        'Customer Information 

        Cbo_Customer_Owner.Text = DS.Tables("Customer").Rows(0)("Customer_Owner").ToString
        Txt_Customer_Bank.Text = DS.Tables("Customer").Rows(0)("Customer_Bank").ToString
        Cbo_Customer_Hub.Text = DS.Tables("Customer").Rows(0)("Customer_Hub").ToString
        Txt_Customer_Account.Text = DS.Tables("Customer").Rows(0)("Customer_Account").ToString
        Txt_Customer_No.Text = DS.Tables("Customer").Rows(0)("Customer_No").ToString
        Txt_Customer_Idc.Text = DS.Tables("Customer").Rows(0)("Customer_Idc").ToString
        Cbo_Customer_Prefix.Text = DS.Tables("Customer").Rows(0)("Customer_Prefix").ToString
        Txt_Customer_Firstname.Text = DS.Tables("Customer").Rows(0)("Customer_Firstname").ToString
        Txt_Customer_Lastname.Text = DS.Tables("Customer").Rows(0)("Customer_Lastname").ToString
        Txt_Customer_Fullname.Text = DS.Tables("Customer").Rows(0)("Customer_Fullname").ToString
        Txt_Customer_Court.Text = DS.Tables("Customer").Rows(0)("Customer_Court").ToString
        Txt_Customer_Black.Text = DS.Tables("Customer").Rows(0)("Customer_black").ToString
        Txt_Customer_Red.Text = DS.Tables("Customer").Rows(0)("Customer_Red").ToString


        If DS.Tables("Customer").Rows(0)("Customer_Date_Add").ToString = "" Then

            Chk_Customer_Date_Add.Checked = False

        Else

            Chk_Customer_Date_Add.Checked = True
            Dtp_Customer_Date_Add.Text = DS.Tables("Customer").Rows(0)("Customer_Date_add").ToString

        End If

        Txt_Customer_Billcode.Text = DS.Tables("Customer").Rows(0)("Customer_billcode").ToString
        Txt_Customer_Type.Text = DS.Tables("Customer").Rows(0)("Customer_type").ToString
        Txt_Customer_Productcode.Text = DS.Tables("Customer").Rows(0)("Customer_Productcode").ToString
        Txt_Customer_Block.Text = DS.Tables("Customer").Rows(0)("Customer_block").ToString
        Txt_Collector_User.Text = DS.Tables("Customer").Rows(0)("Collector_User").ToString


        'Accounting

        Cbo_Account_Status.Text = DS.Tables("Customer").Rows(0)("ACCSTATUS").ToString
        Dtp_Account_Date.Text = DS.Tables("Customer").Rows(0)("ACCDATE").ToString
        Txt_Account_Receipt1.Text = DS.Tables("Customer").Rows(0)("ACCRECEIPT").ToString
        Txt_Receipt_Detail1.Text = DS.Tables("Customer").Rows(0)("ACCRECEIPT_DETAIL").ToString
        Txt_Account_Receipt2.Text = DS.Tables("Customer").Rows(0)("ACCRECEIPT_OTHER_2").ToString
        Txt_Receipt_Detail2.Text = DS.Tables("Customer").Rows(0)("ACCRECEIPT_OTHER_DETAIL2").ToString
        Txt_Account_Receipt3.Text = DS.Tables("Customer").Rows(0)("ACCRECEIPT_OTHER_3").ToString
        Txt_Receipt_Detail3.Text = DS.Tables("Customer").Rows(0)("ACCRECEIPT_OTHER_DETAIL3").ToString
        Dtp_Account_Month.Text = DS.Tables("Customer").Rows(0)("ACCMONTH").ToString
        Cbo_Account_Result.Text = DS.Tables("Customer").Rows(0)("ACCRESULT").ToString
        Cbo_Account_Action.Text = DS.Tables("Customer").Rows(0)("ACCACTION").ToString
        Cbo_Account_Employee.Text = DS.Tables("Customer").Rows(0)("EXEEMPLOYEES").ToString

        If DS.Tables("Customer").Rows(0)("ACCDATE").ToString <> "" Then

            Chk_Account_Date.Checked = True
        Else
            Chk_Account_Date.Checked = False

        End If

        If DS.Tables("Customer").Rows(0)("ACCMONTH").ToString <> "" Then

            Chk_Account_Month.Checked = True
        Else
            Chk_Account_Month.Checked = False

        End If


    End Sub

    Private Sub FrmMainExecution_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing



    End Sub

    Private Sub Chk_Account_Date_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Account_Date.CheckedChanged

        If Chk_Account_Date.Checked = True Then

            Dtp_Account_Date.Enabled = True

        Else

            Dtp_Account_Date.Enabled = False

        End If

    End Sub

    Private Sub Chk_Account_Month_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Account_Month.CheckedChanged

        If Chk_Account_Month.Checked = True Then

            Dtp_Account_Month.Enabled = True

        Else

            Dtp_Account_Month.Enabled = False

        End If

    End Sub

    Private Sub Cmd_cancel_Click(sender As Object, e As EventArgs) Handles cmd_cancel.Click

        ReadOnlyText()

    End Sub

    Private Sub Cmd_edit_Click(sender As Object, e As EventArgs) Handles cmd_edit.Click

        EditText()

    End Sub

End Class