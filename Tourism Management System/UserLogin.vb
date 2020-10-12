Imports System.Data.OleDb
Imports System.IO

Public Class UserLogin
    Dim connection As OleDbConnection = New OleDbConnection

    Dim dr As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim t As Integer = 0

    Dim name As String
    Dim password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            connection.Open()
        Catch ex As Exception
            MessageBox.Show("Unable To Open Database !")
            Me.Dispose()
        End Try

        name = TextBox1.Text
        password = TextBox2.Text
        sql = "SELECT UserDetails.FirstName, UserDetails.Password
FROM UserDetails
WHERE (((UserDetails.FirstName)=""" + name + """) AND ((UserDetails.Password)=""" + password + """));"
        Dim command As New OleDbCommand(sql, connection)
        Dim dr As OleDbDataReader

        dr = command.ExecuteReader()
        If dr.Read() = True Then
            MessageBox.Show("Login Successful !", "Tourism")

            Dim conn As OleDbConnection = New OleDbConnection
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory + "\UserInfo.accdb" + ";Jet OLEDB:Database Password=0123456789"
            Try
                conn.Open()
                Dim sql As String = "UPDATE UserDetails SET UserDetails.[LoginStatus] = No
WHERE (((UserDetails.[LoginStatus])=Yes));"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, connection)
                cmd.ExecuteNonQuery()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("UserInfo Database Not Found !")
            End Try

            sql = "UPDATE UserDetails SET UserDetails.LoginStatus = Yes
WHERE (((UserDetails.FirstName)=""" + name + """) AND ((UserDetails.Password)=""" + password + """));"
            Dim com As New OleDbCommand(sql, connection)
            com.ExecuteNonQuery()
            Me.Dispose()
            Login_Select.Dispose()
        Else
            MsgBox("Please enter valid name and password.")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
        connection.Close()
        t = t + 1
        If t = 3 Then
            MessageBox.Show("you have entered wrong values for 3 times....please create a new account !", "Tourism")
            CreateAccount.Show()
            Login_Select.Dispose()
            Me.Dispose()
        End If
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = Directory.GetCurrentDirectory
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\UserInfo.accdb" + ";Jet OLEDB:Database Password=0123456789"
    End Sub
End Class