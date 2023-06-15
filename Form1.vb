Imports System.IO



Public Class Form1
    Public dbName As String = "hmsoftware_database.db"
    Public dbPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & dbName
    Public model As New Model
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(dbPath) = False Then
            File.Create(dbPath)
            MsgBox("đã tạo database, vui lòng mở lại ứng dụng")
            Quit()
            Return
        End If
        model.CreateDataBase()

        SwitchForm(Login)
        pnlLeft.Visible = False

    End Sub

    Public Sub Quit()
        Login.Close()

        Me.Close()
    End Sub

    Private Sub lbQuit_Click(sender As Object, e As EventArgs) Handles lbQuit.Click
        Quit()
    End Sub

    Public Sub SwitchForm(form As Form)
        UnCheckButton()
        pnlMain.Controls.Clear()
        form.TopLevel = False
        pnlMain.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub UnCheckButton()
        btnCheckIn.Checked = False
        btnEmployee.Checked = False
        btnRoom.Checked = False
        btnCust.Checked = False
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        SwitchForm(CheckIn)
        btnCheckIn.Checked = True
    End Sub

    Private Sub btnCust_Click(sender As Object, e As EventArgs) Handles btnCust.Click
        SwitchForm(Cust)
        btnCust.Checked = True
    End Sub

    Private Sub btnRoom_Click(sender As Object, e As EventArgs) Handles btnRoom.Click
        SwitchForm(Room)
        btnRoom.Checked = True
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        SwitchForm(Employee)
        btnEmployee.Checked = True
    End Sub


    Function ChangeBoolToNum(value As Boolean) As Integer
        If value Then
            Return 1

        Else
            Return 0
        End If
    End Function

    Function ChangeNumToBool(value As Integer) As Boolean
        If value = 1 Then
            Return True
        ElseIf value = 0 Then
            Return False
        Else
            Return False
        End If
    End Function

    Public Function CheckNull(text As String) As Boolean
        If text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
