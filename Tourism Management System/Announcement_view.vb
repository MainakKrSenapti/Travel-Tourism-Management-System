Imports System.IO
Imports System.Data.OleDb

Public Class Announcement_view
    Dim Del_choice As Integer
    Dim con As New OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim MyFolder As String
    Dim TheDatabase As String
    Dim FullDataBasePath As String
    Dim rs As New Resizer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Announcement_edit.Show()
    End Sub

    Private Sub Announcement_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        TheDatabase = "/Announcement.accdb"
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


    Private Sub DataGridshow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Try
            con.Open()
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter("Select * From Announcement", con)
            da.Fill(dt)

            DataGridView1.DataSource = dt.DefaultView

        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Announcement_view_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Announcement_edit.Show()
        Me.Dispose()
    End Sub

    Private Sub Announcement_view_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class