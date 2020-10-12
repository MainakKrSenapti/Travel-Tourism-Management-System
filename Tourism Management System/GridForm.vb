Imports System.Data.OleDb
Imports System.IO
Public Class GridForm

    Dim myFolder As String
    Dim dbprovider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
    Dim conBook As New OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim rs As New Resizer
    Private Sub GridForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
        rs.ResizeAllControls(Me)
        'Create Connection
        myFolder = Directory.GetCurrentDirectory
        Dim myDBBook = myFolder & "/Book.accdb;"
        Dim src = "Data Source=" & myDBBook
        Try
            conBook.ConnectionString = dbprovider & src & "Jet OLEDB:Database Password=0123456789"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'open connection
        If conBook.State = ConnectionState.Closed Then
            conBook.Open()
        End If
        Dim sql = "select * from Book"
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter(sql, conBook)
        da.Fill(dt)
        Try
            DataGridView1.DataSource = dt.DefaultView
        Catch ex As Exception

        End Try
        conBook.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin_Dashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub GridForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Admin_Dashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub GridForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class