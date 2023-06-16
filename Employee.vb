Imports System.Collections.ObjectModel
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.Data.SQLite
Imports System.Web.UI.WebControls

Public Class Employee
    Dim table As New DataTable
    Dim adBool As Boolean
    Dim selectRow As DataGridViewRow
    Dim indexSelect As Integer = 0

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub
    Private Sub LoadTable()

        Form1.model.connection.Open()
        Form1.model.command.Connection = Form1.model.connection
        Form1.model.command.CommandText = "select * from employee"
        Dim rdr As SQLiteDataReader = Form1.model.command.ExecuteReader

        table.Load(rdr)
        dataViewEmployee.DataSource = table
        Form1.model.connection.Close()
    End Sub


    Private Sub Empty()
        cbGender.SelectedIndex = 2
        tbId.Text = ""
        tbPassword.Clear()
        tbPhone.Clear()
        tbUser.Clear()
        checkAD.Checked = False
    End Sub



    Private Sub textReset_Click(sender As Object, e As EventArgs) Handles textReset.Click
        Empty()
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Form1.CheckNull(tbPassword.Text) Or Form1.CheckNull(tbUser.Text) Then
            MsgBox("Vui lòng điền đầy đủ thông tin!")
            Return
        End If
        Form1.model.connection.Open()
        Form1.model.command.Connection = Form1.model.connection

        Form1.model.command.CommandText = "insert into employee(user,password,phone,gender,admin_rights) values (@user,@password,@phone,@gender,@admin_rights)"
        Form1.model.command.Parameters.AddWithValue("@user", tbUser.Text)
        Form1.model.command.Parameters.AddWithValue("@password", tbPassword.Text)
        Form1.model.command.Parameters.AddWithValue("@phone", tbPhone.Text)
        Form1.model.command.Parameters.AddWithValue("@gender", cbGender.Text)
        Form1.model.command.Parameters.AddWithValue("@admin_rights", Form1.ChangeBoolToNum(checkAD.Checked))

        Form1.model.command.ExecuteNonQuery()
        Form1.model.connection.Close()

        Empty()
        loadTable()
    End Sub

    Private Sub dataViewEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataViewEmployee.CellClick
        indexSelect = e.RowIndex
        Debug.Print("indexSelect: " & indexSelect.ToString)
        If indexSelect < 0 Then
            Return
        End If

        selectRow = dataViewEmployee.Rows(indexSelect)
        tbId.Text = selectRow.Cells(0).Value.ToString()
        tbUser.Text = selectRow.Cells(1).Value.ToString()
        tbPassword.Text = selectRow.Cells(2).Value.ToString()
        tbPhone.Text = selectRow.Cells(3).Value.ToString()


        cbGender.Text = selectRow.Cells(4).Value.ToString()
        checkAD.Checked = Form1.ChangeNumToBool(selectRow.Cells(5).Value)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If indexSelect < 0 Then
            MsgBox("hãy lựa chọn Nhân Sự!")
            Return
        End If
        If Form1.CheckNull(tbId.Text) Then
            MsgBox("Hiện không có ID !!!")
            Return
        End If

        Dim answer As Integer


        answer = MsgBox("Bạn có muốn xóa 'Nhân Sự' này không?", vbYesNo, "Xác nhận")

        If answer = vbYes Then
            Form1.model.connection.Open()
            Form1.model.command.Connection = Form1.model.connection


            Form1.model.command.CommandText = "DELETE FROM employee WHERE id = @id "
            Form1.model.command.Parameters.AddWithValue("@id", tbId.Text)

            Form1.model.command.ExecuteNonQuery()
            Form1.model.connection.Close()
            Empty()
            dataViewEmployee.Rows.RemoveAt(indexSelect)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        '"UPDATE COMPANY SET ADDRESS = @address, SALARY = @salary WHERE ID = @id"

        If indexSelect < 0 Then
            MsgBox("hãy lựa chọn Nhân Sự!")
            Return
        End If

        If Form1.CheckNull(tbId.Text) Then
            MsgBox("Hiện không có ID !!!")
            Return
        End If

        If Form1.CheckNull(tbPassword.Text) Or Form1.CheckNull(tbUser.Text) Then
            MsgBox("Vui lòng điền đầy đủ thông tin!")
            Return
        End If

        Dim answer As Integer
        answer = MsgBox("Bạn có muốn sửa 'Nhân Sự' này không?", vbYesNo, "Xác nhận")

        If answer = vbYes Then
            Form1.model.connection.Open()
            Form1.model.command.Connection = Form1.model.connection

            Form1.model.command.CommandText = "UPDATE employee SET user = @user, password = @password, phone = @phone , gender = @gender , admin_rights = @admin_rights WHERE id = @id"

            Form1.model.command.Parameters.AddWithValue("@id", tbId.Text)
            Form1.model.command.Parameters.AddWithValue("@user", tbUser.Text)
            Form1.model.command.Parameters.AddWithValue("@password", tbPassword.Text)
            Form1.model.command.Parameters.AddWithValue("@phone", tbPhone.Text)
            Form1.model.command.Parameters.AddWithValue("@gender", cbGender.Text)
            Form1.model.command.Parameters.AddWithValue("@admin_rights", Form1.ChangeBoolToNum(checkAD.Checked))

            Form1.model.command.ExecuteNonQuery()
            Form1.model.connection.Close()

            Empty()
            LoadTable()
        End If
    End Sub
End Class