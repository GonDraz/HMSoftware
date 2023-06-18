
Imports System.Data.SQLite

Public Class CheckIn

    Dim table As New DataTable
    Dim adBool As Boolean
    Dim selectRow As DataGridViewRow
    Dim indexSelect As Integer = 0
    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub
    Private Sub LoadTable()
        Form1.model.connection.Open()
        Form1.model.command.Connection = Form1.model.connection
        Form1.model.command.CommandText = "select * from check_HM"
        Dim rdr As SQLiteDataReader = Form1.model.command.ExecuteReader

        table.Load(rdr)
        dataviewCheckIn.DataSource = table
        Form1.model.connection.Close()

    End Sub
    Private Sub textReset_Click(sender As Object, e As EventArgs) Handles textReset.Click
        Empty()
    End Sub

    Private Sub Empty()
        tbId.Clear()
        nmrCust.Value = 0
        nmrRoom.Value = 0

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Form1.model.connection.Open()
        Form1.model.command.Connection = Form1.model.connection

        Form1.model.command.CommandText = "insert into check_HM(customer_id,room_id) values (@customer_id,@room_id)"
        Form1.model.command.Parameters.AddWithValue("@customer_id", nmrCust.Value.ToString())
        Form1.model.command.Parameters.AddWithValue("@room_id", nmrRoom.Value.ToString())
        Form1.model.command.ExecuteNonQuery()
        Form1.model.connection.Close()

        Empty()
        LoadTable()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If indexSelect < 0 Then
            MsgBox("hãy lựa chọn Nhân Sự!")
            Return
        End If

        If Form1.CheckNull(tbId.Text) Then
            MsgBox("Hiện không có ID !!!")
            Return
        End If

        Dim answer As Integer
        answer = MsgBox("Bạn có muốn sửa 'Nhân Sự' này không?", vbYesNo, "Xác nhận")

        If answer = vbYes Then
            Form1.model.connection.Open()
            Form1.model.command.Connection = Form1.model.connection

            Form1.model.command.CommandText = "UPDATE check_HM SET customer_id = @customer_id, room_id = @room_id WHERE id = @id"

            Form1.model.command.Parameters.AddWithValue("@id", tbId.Text)
            Form1.model.command.Parameters.AddWithValue("@customer_id", nmrCust.Value.ToString())
            Form1.model.command.Parameters.AddWithValue("@room_id", nmrRoom.Value.ToString())
            Form1.model.command.ExecuteNonQuery()
            Form1.model.connection.Close()

            Empty()
            LoadTable()
        End If
    End Sub

    Private Sub dataviewCheckIn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataviewCheckIn.CellClick
        indexSelect = e.RowIndex
        Debug.Print("indexSelect: " & indexSelect.ToString)
        If indexSelect < 0 Then
            Return
        End If

        selectRow = dataviewCheckIn.Rows(indexSelect)
        tbId.Text = selectRow.Cells(0).Value.ToString()
        nmrCust.Value = selectRow.Cells(1).Value
        nmrRoom.Value = selectRow.Cells(2).Value
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
            Form1.model.command.CommandText = "DELETE FROM check_HM WHERE id = @id "
            Form1.model.command.Parameters.AddWithValue("@id", tbId.Text)

            Form1.model.command.ExecuteNonQuery()
            Form1.model.connection.Close()
            Empty()
            dataviewCheckIn.Rows.RemoveAt(indexSelect)
        End If
    End Sub
End Class