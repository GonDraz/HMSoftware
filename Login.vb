Imports System.Data.SQLite
Imports System.Web.UI.WebControls

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Form1.CheckNull(tbUser.Text) Or Form1.CheckNull(tbPassword.Text) Then
            MsgBox("vui lòng điền đầy đủ thông tin!")
            Return
        End If
        Form1.model.connection.Open()
        Form1.model.command.Connection = Form1.model.connection

        Form1.model.command.CommandText = "SELECT * FROM employee WHERE (user = @user) AND (password = @password)"

        Form1.model.command.Parameters.AddWithValue("@user", tbUser.Text)
        Form1.model.command.Parameters.AddWithValue("@password", tbPassword.Text)

        Dim rdr As SQLiteDataReader = Form1.model.command.ExecuteReader()

        If rdr.HasRows Then
            rdr.Read()
            Dim adminRights As Integer = rdr("admin_rights")
            If Form1.ChangeNumToBool(adminRights) Then
                Form1.btnEmployee.Enabled = True
            Else
                Form1.btnEmployee.Enabled = False
            End If
            Form1.lbNameUser.Text = rdr("user").ToString
            rdr.Close()
            Form1.model.connection.Close()
            Form1.pnlLeft.Visible = True
            Form1.SwitchForm(CheckIn)
        Else
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác")
            Form1.model.connection.Close()
        End If

        tbPassword.Clear()
        tbUser.Clear()

    End Sub

    Private Sub lbQuit_Click(sender As Object, e As EventArgs) Handles lbQuit.Click
        Form1.Quit()
    End Sub
End Class