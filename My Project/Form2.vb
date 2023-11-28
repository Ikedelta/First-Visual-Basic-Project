Public Class frmLogin


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim password As String
        Dim username As String

        username = "ISAAC ASANTE"
        password = "ISAACASANTE"




        If txtPassword.Text = password AndAlso txtUsername.Text = username Then
            Me.Hide()
            frmHome.Show()

        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub


End Class