Public Class Form1
    Public model As New Model

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Model.ConnectDataBase()

        SwitchForm(Login)
    End Sub

    Public Sub Quit()


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
End Class
