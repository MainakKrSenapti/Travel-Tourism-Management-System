Public Class Login_Select
    Private Sub User_login_Click(sender As Object, e As EventArgs) Handles User_login.Click
        If UserLogin.Visible = False And AdminLogin.Visible = False Then
            UserLogin.Show()
        Else
            If UserLogin.Visible = True Then
                UserLogin.BringToFront()
            Else
                AdminLogin.BringToFront()
            End If
        End If
    End Sub

    Private Sub Admin_login_Click(sender As Object, e As EventArgs) Handles Admin_login.Click
        If UserLogin.Visible = False And AdminLogin.Visible = False Then
            AdminLogin.Show()
        Else
            If UserLogin.Visible = True Then
                UserLogin.BringToFront()
            Else
                AdminLogin.BringToFront()
            End If
        End If
    End Sub

    Private Sub Create_acc_Click(sender As Object, e As EventArgs) Handles Create_acc.Click
        CreateAccount.Show()
        Me.Dispose()
    End Sub
End Class