Public Class AdminLogin
    Dim AdminId As String = "Admin"
    Dim password As String = "0123456789"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp_name As String = TextBox1.Text
        Dim temp_pass As String = TextBox2.Text
        If temp_name = AdminId And password = temp_pass Then
            MessageBox.Show("Admin Login Successful !", "Tourism")
            Admin_Dashboard.Show()
            If Front_UI.Visible = True Then
                Front_UI.Hide()
            ElseIf All_Pkgs_Form.Visible = True Then
                All_Pkgs_Form.Dispose()
            End If
            Me.Dispose()
            Login_Select.Dispose()
        Else
            MessageBox.Show("Wrong AdminId Or Password !", "Tourism")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class