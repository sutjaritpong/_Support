Option Explicit On
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmIncome
    Private Sub FrmIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connect()

        Comboboxadd(Cbo_Income_Employees, "EXEEMPLOYEES", "EXEEMPLOYEE")

        Comboboxadd(Cbo_Income_Owner, "Customer_Owner", "Execution_Income")



    End Sub

    Private Sub Query_Insert_Income()

        Connect()


    End Sub

    Private Sub Cmd_Income_Insert_Click(sender As Object, e As EventArgs) Handles Cmd_Income_Insert.Click

        Query_Insert_Income()

    End Sub

End Class