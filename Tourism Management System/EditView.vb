Imports System.IO
Imports System.Data.OleDb
Public Class EditView
    Dim con As New OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim MyFolder As String
    Dim TheDatabase As String
    Dim FullDataBasePath As String
    Dim rs As New Resizer
    Private Sub EditView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        TheDatabase = "/UserInfo.accdb"
        MyFolder = Directory.GetCurrentDirectory
        FullDataBasePath = MyFolder & TheDatabase
        dbSource = "Data Source=" & FullDataBasePath
        con.ConnectionString = dbProvider & dbSource
        DataGridshow()
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub DataGridshow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            con.Open()
            ds.Tables.Add(dt)
            Dim da As OleDbDataAdapter
            da = New OleDbDataAdapter("Select * From UserDetails", con)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        EditUser.Show()
        Me.Dispose()
    End Sub

    Private Sub EditView_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub EditView_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        EditUser.Show()
        Me.Dispose()
    End Sub
End Class