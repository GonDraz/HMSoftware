Imports System.Collections.ObjectModel
Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Data.SQLite
Imports System.Web.UI.WebControls

Public Class Cust
    Dim table As New DataTable
    Dim adBool As Boolean
    Dim selectRow As DataGridViewRow
    Dim indexSelect As Integer = 0

    Private Sub Cust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Private Sub LoadTable()
        Form1.model.connection.Open()
        Form1.model.command.Connection = Form1.model.connection

        Form1.model.command.CommandText = "select * from customer"
        Dim rdr As SQLiteDataReader = Form1.model.command.ExecuteReader

        table.Load(rdr)
        dataViewCustomer.DataSource = table
        Form1.model.connection.Close()
    End Sub
    Private Sub Empty()

        txtId_Cus.Text = ""
        txtName_Cus.Clear()
        txtPhone_Cus.Clear()
        txtGender_Cus.Clear()

    End Sub
    Private Sub btnAdd_Cus_Click(sender As Object, e As EventArgs) Handles btnAdd_Cus.Click
        'If Form1.CheckNull(tbPassword.Text) Or Form1.CheckNull(tbUser.Text) Then
        '    MsgBox("Vui lòng điền đầy đủ thông tin!")
        '    Return
        'End If


        Form1.model.connection.Open()
        Form1.model.command.Connection = Form1.model.connection
        Form1.model.command.CommandText = "insert into customer(name,phone,gender) values (@name,@phone,@gender)"
        Form1.model.command.Parameters.AddWithValue("@name", txtName_Cus.Text)
        Form1.model.command.Parameters.AddWithValue("@phone", txtPhone_Cus.Text)
        Form1.model.command.Parameters.AddWithValue("@gender", txtGender_Cus.Text)



        Form1.model.command.ExecuteNonQuery()
        Form1.model.connection.Close()
        Empty()
        LoadTable()
    End Sub

    Private Sub dataViewCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataViewCustomer.CellContentClick
        indexSelect = e.RowIndex
        Debug.Print("indexSelect: " & indexSelect.ToString)
        If indexSelect < 0 Then
            Return
        End If

        selectRow = dataViewCustomer.Rows(indexSelect)
        txtId_Cus.Text = selectRow.Cells(0).Value.ToString()
        txtName_Cus.Text = selectRow.Cells(1).Value.ToString()
        txtPhone_Cus.Text = selectRow.Cells(2).Value.ToString()
        txtGender_Cus.Text = selectRow.Cells(3).Value.ToString()
    End Sub

    Private Sub btnReset_Cus_Click(sender As Object, e As EventArgs) Handles btnReset_Cus.Click
        Empty()
    End Sub
End Class