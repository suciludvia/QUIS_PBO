Public Class login

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        login_valid = oUser.Login(txtussername.Text, txtpassword.Text)
        If (login_valid = True) Then
            MessageBox.Show("selamat datang")
            home.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login Not Valid")
        End If
    End Sub

End Class
