Public Class Admin_Dashboard
    Dim rs As New Resizer
    Private Sub Admin_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub Edit_Pkgs_Click(sender As Object, e As EventArgs) Handles Edit_Pkgs.Click
        Package_manage.Show()
        Me.Hide()
    End Sub

    Private Sub Edit_Anno_Click(sender As Object, e As EventArgs) Handles Edit_Anno.Click
        Announcement_edit.Show()
        Me.Hide()
    End Sub

    Private Sub Package_Booked_Click(sender As Object, e As EventArgs) Handles Package_Booked.Click
        GridForm.Show()
        Me.Hide()
    End Sub

    Private Sub Edit_User_Click(sender As Object, e As EventArgs) Handles Edit_User.Click
        EditUser.Show()
        Me.Hide()
    End Sub

    Private Sub Admin_Dashboard_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Front_UI.Show()
        Me.Hide()
    End Sub

    Private Sub Admin_Dashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class