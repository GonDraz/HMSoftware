Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        If (tbUser.Text = "admin" And tbPassword.Text = "admin") Then
            Form1.pnlLeft.Visible = True

            Form1.SwitchForm(CheckIn)

        End If
        Form1.pnlLeft.Visible = True
        Form1.SwitchForm(CheckIn)


    End Sub

    Private Sub lbQuit_Click(sender As Object, e As EventArgs) Handles lbQuit.Click
        Form1.Quit()
    End Sub
End Class