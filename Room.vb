Imports System.Collections.ObjectModel
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.Data.SQLite
Imports System.Web.UI.WebControls


Public Class Room
    Dim table As New DataTable
    Dim adBool As Boolean
    Dim selectRow As DataGridViewRow
    Dim indexSelect As Integer = 0
    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Private Sub LoadTable()
        Form1.model.connection.Open()
        Form1.model.command.Connection = Form1.model.connection
        Form1.model.command.CommandText = "select * from room"
        Dim rdr As SQLiteDataReader = Form1.model.command.ExecuteReader

        Table.Load(rdr)
        dataViewRoom.DataSource = table
        Form1.model.connection.Close()
    End Sub
    Private Sub Empty_room()

        tbId_room.Text = ""
        tbType.Clear()
        tbRate.Clear()
        nmrEmpty.Text = "1"

    End Sub
    Private Sub textResetroom_Click(sender As Object, e As EventArgs)
        Empty_room()
    End Sub

    Private Sub btnAddroom_Click(sender As Object, e As EventArgs) Handles btnAdd_room.Click
        If Form1.CheckNull(tbType.Text) Or Form1.CheckNull(tbType.Text) Then
            MsgBox("Vui lòng điền đầy đủ thông tin!")

        End If
        Form1.model.connection.Open()
        Form1.model.command.Connection = Form1.model.connection

        Form1.model.command.CommandText = "insert into room(type,rate,empty) values (@type,@rate,@empty)"
        Form1.model.command.Parameters.AddWithValue("@type", tbType.Text)
        Form1.model.command.Parameters.AddWithValue("@rate", tbRate.Text)
        Form1.model.command.Parameters.AddWithValue("@empty", nmrEmpty.Text)
        Form1.model.command.ExecuteNonQuery()
        Form1.model.connection.Close()
        Empty_room()
        LoadTable()
    End Sub

    Private Sub dataViewroom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataViewRoom.CellClick
        indexSelect = e.RowIndex
        Debug.Print("indexSelect: " & indexSelect.ToString)
        If indexSelect < 0 Then
            Return
        End If

        selectRow = dataViewRoom.Rows(indexSelect)
        tbId_room.Text = selectRow.Cells(0).Value.ToString()
        tbType.Text = selectRow.Cells(1).Value.ToString()
        nmrEmpty.Text = selectRow.Cells(2).Value.ToString()
        tbRate.Text = selectRow.Cells(3).Value.ToString()


    End Sub
    Private Sub btnDelete_room_Click(sender As Object, e As EventArgs) Handles btnDelete_room.Click
        If indexSelect < 0 Then
            MsgBox("Hãy lựa chọn phòng!")
            Return
        End If
        If Form1.CheckNull(tbId_room.Text) Then
            MsgBox("Hiện không có ID !!!")
            Return
        End If

        Dim answer As Integer


        answer = MsgBox("Bạn có muốn xóa 'Phòng' này không?", vbYesNo, "Xác nhận")

        If answer = vbYes Then

            Form1.model.connection.Open()
            Form1.model.command.Connection = Form1.model.connection
            Form1.model.command.CommandText = "DELETE FROM room WHERE id = @id "
            Form1.model.command.Parameters.AddWithValue("@id", tbId_room.Text)

            Form1.model.command.ExecuteNonQuery()
            Form1.model.connection.Close()
            Empty_room()
            dataViewRoom.Rows.RemoveAt(indexSelect)
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit_room.Click
        '"UPDATE COMPANY SET ADDRESS = @address, SALARY = @salary WHERE ID = @id"

        If indexSelect < 0 Then
            MsgBox("hãy lựa chọn Phòng!")
            Return
        End If

        If Form1.CheckNull(tbId_room.Text) Then
            MsgBox("Hiện không có ID !!!")
            Return
        End If

        If Form1.CheckNull(tbType.Text) Or Form1.CheckNull(tbRate.Text) Then
            MsgBox("Vui lòng điền đầy đủ thông tin!")
            Return
        End If

        Dim answer As Integer
        answer = MsgBox("Bạn có muốn sửa 'Phòng' này không?", vbYesNo, "Xác nhận")

        If answer = vbYes Then
            Form1.model.connection.Open()
            Form1.model.command.Connection = Form1.model.connection

            Form1.model.command.CommandText = "UPDATE room SET type = @type,empty = @empty ,rate = @rate  WHERE id = @id"

            Form1.model.command.Parameters.AddWithValue("@id", tbId_room.Text)
            Form1.model.command.Parameters.AddWithValue("@type", tbType.Text)
            Form1.model.command.Parameters.AddWithValue("@empty", nmrEmpty.Text)
            Form1.model.command.Parameters.AddWithValue("@rate", tbRate.Text)
            Form1.model.command.ExecuteNonQuery()

            Empty_room()
            Form1.model.connection.Close()
            LoadTable()
        End If
    End Sub

End Class