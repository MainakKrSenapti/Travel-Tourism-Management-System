Imports System.Data.OleDb
Imports System.IO
Public Class PackageDatabase
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim MyFolder As String
    Dim TheDatabase As String
    Dim FullDataBasePath As String
    Dim rs As New Resizer

    Private Sub PackageDatabase_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        TheDatabase = "/PackagesInfo.accdb"
        MyFolder = Directory.GetCurrentDirectory
        FullDataBasePath = MyFolder & TheDatabase
        dbSource = "Data Source=" & FullDataBasePath
        con.ConnectionString = dbProvider & dbSource & ";Jet OLEDB:Database Password=0123456789"
        DataGridshow()
        'Me.WindowState = FormWindowState.Maximized
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        Package_manage.Show()
        Me.Dispose()
    End Sub
    Private Sub DataGridshow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            con.Open()
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("Select * From PackagesInfo", con)
            da.Fill(dt)

            DataGridView1.DataSource = dt.DefaultView

        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub PackageDatabase_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub PackageDatabase_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Package_manage.Show()
        Me.Dispose()
    End Sub

End Class