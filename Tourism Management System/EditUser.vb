Imports System.Data.OleDb
Imports System.IO

Public Class EditUser
    Dim con As New OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim MyFolder As String
    Dim TheDatabase As String
    Dim FullDataBasePath As String
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim Sql As String
    Dim rs As New Resizer
    Dim flag As Integer = 0
    Dim choice As String
    Dim Gender As Char
    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
        rs.ResizeAllControls(Me)
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        TheDatabase = "/UserInfo.accdb"
        MyFolder = Directory.GetCurrentDirectory
        FullDataBasePath = MyFolder & TheDatabase
        dbSource = "Data Source=" & FullDataBasePath
        con.ConnectionString = dbProvider & dbSource
    End Sub

    Private Sub ConnectionCheck_Click(sender As Object, e As EventArgs) Handles ConnectionCheck.Click
        'check the database connectivity
        con.Open()
        If con.State = ConnectionState.Open Then 'check if the database connection is active
            MessageBox.Show("Database is now active.We are now Closing it...", "Active", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()
        If con.State = ConnectionState.Closed Then
            MessageBox.Show("Database is now closed.", "Close", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DatabaseShow_Click(sender As Object, e As EventArgs) Handles DatabaseShow.Click
        Me.Hide()
        EditView.Show()
    End Sub

    Private Sub Upload_Click(sender As Object, e As EventArgs) Handles Upload.Click
        Dim ds As New DataSet
        Dim da As OleDbDataAdapter
        Try
            con.Open()                                      'Opening Connection
        Catch ex As Exception                               'Providing Error Message
            MessageBox.Show("Uable to Connect", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End                                             'Closing Application
        End Try
        Sql = "SELECT * FROM UserDetails"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "UserDetails")

        Dim cb As New OleDbCommandBuilder(da)

        Try
            Sql = "INSERT INTO UserDetails([FirstName],[Surname],[DOB],[Phone],[Password],[E-mail],[StreetName],[State],[City],[Zipcode],[Gender]) VALUES (?,?,?,?,?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(Sql, con)
            cmd.Parameters.Add(New OleDbParameter("FirstName", CType(FirstnameTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Surname", CType(SurnameTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("DOB", CType(DOBDateTimePicker.Text, Date)))
            cmd.Parameters.Add(New OleDbParameter("Phone", CLng(PhonenoTextBox.Text)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(PasswordTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("E-mail", CType(EmailTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("StreetName", CType(StreetTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("State", CType(StateComboBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("City", CType(CityTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Zipcode", CType(ZipcodeTextBox.Text, Integer)))

            If MRadioButton.Checked = True Then
                Gender = "M"
                FRadioButton.Checked = False
                ORadioButton.Checked = False
            ElseIf FRadioButton.Checked = True Then
                Gender = "F"
                FRadioButton.Checked = False
                MRadioButton.Checked = False
            Else
                Gender = "U"
                FRadioButton.Checked = False
                MRadioButton.Checked = False

            End If
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(Gender, Char)))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
            da.Update(ds, "UserDetails")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            FirstnameTextBox.Clear()
            SurnameTextBox.Clear()
            DOBDateTimePicker.ResetText()
            PhonenoTextBox.Clear()
            PasswordTextBox.Clear()
            EmailTextBox.Clear()
            StateComboBox.ResetText()
            StreetTextBox.Clear()
            CityTextBox.Clear()
            ZipcodeTextBox.Clear()
        End Try

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Try
            con.Open()                                      'Opening Connection
        Catch ex As Exception                               'Providing Error Message
            MessageBox.Show("Uable to Connect", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End                                             'Closing Application
        End Try
        Try


Label:
            choice = InputBox("Enter UserID to be deleted : ", "Input Number",,,)
            If MessageBox.Show("Do you really want to Delete this Record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                If MessageBox.Show("Deletion operation has been terminated suddenly...", "Aborted", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo Label
                Else
                    MsgBox("Thank You")
                    Exit Sub
                End If
            Else
                If String.IsNullOrEmpty(choice) Then Exit Sub
                Sql = "DELETE * FROM UserDetails WHERE ((UserDetails.ID)=" + choice + ");"
                Dim command As OleDbCommand = New OleDbCommand(Sql, con)
                Dim success As Integer = command.ExecuteNonQuery()
                If success <> 0 Then
                    MessageBox.Show("Deletion operation has been terminated with success...", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Else
                    MsgBox("PackageID Not Found !")
                End If

                MsgBox("Thank you")
        End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        FirstnameTextBox.Clear()
        SurnameTextBox.Clear()
        DOBDateTimePicker.ResetText()
        PhonenoTextBox.Clear()
        PasswordTextBox.Clear()
        EmailTextBox.Clear()
        StateComboBox.ResetText()
        StreetTextBox.Clear()
        CityTextBox.Clear()
        ZipcodeTextBox.Clear()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        If flag = 0 Then
            Show()
            flag = 1
        Else
            Try
                con.Open()

                If MRadioButton.Checked = True Then
                    Gender = "M"
                    FRadioButton.Checked = False
                    ORadioButton.Checked = False
                ElseIf FRadioButton.Checked = True Then
                    Gender = "F"
                    FRadioButton.Checked = False
                    MRadioButton.Checked = False
                Else
                    Gender = "U"
                    FRadioButton.Checked = False
                    MRadioButton.Checked = False

                End If
                Sql = "UPDATE UserDetails SET UserDetails.[FirstName] = """ + FirstnameTextBox.Text + """, UserDetails.[Surname] = """ + SurnameTextBox.Text + """, UserDetails.[DOB] = " + date_format(CType(DOBDateTimePicker.Text, Date)) + ",UserDetails.[Phone] = " + PhonenoTextBox.Text + ", UserDetails.Password = """ + PasswordTextBox.Text + """, UserDetails.[E-mail] = """ + EmailTextBox.Text + """, UserDetails.State = """ + StateComboBox.Text + """, UserDetails.StreetName = """ + StreetTextBox.Text + """, UserDetails.City = """ + CityTextBox.Text + """, UserDetails.Zipcode = """ + ZipcodeTextBox.Text + """, UserDetails.Gender = """ + Gender + """
                  WHERE ((UserDetails.ID)=" + choice + ");"
                Dim command As OleDbCommand = New OleDbCommand(Sql, con)
                Dim success As Integer = command.ExecuteNonQuery()
                If success <> 0 Then
                    MsgBox("Success")
                Else
                    MsgBox("PackageID Not Found !")
                End If
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Uable to Connect", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            con.Close()
                flag = 0
            End Try
        End If
    End Sub

    Private Function date_format(ByVal dte As Date) As String
        Dim format_date As String
        format_date = "#" + dte.Month.ToString + "/" + dte.Day.ToString + "/" + dte.Year.ToString + "#"
        Return format_date
    End Function

    Private Sub Show()
        Dim ds As New DataSet
        choice = InputBox("Enter UserID to be Updated : ", "Input Number",,,)
        If String.IsNullOrEmpty(choice) Then Exit Sub
        Try

            Sql = "SELECT * From UserDetails WHERE (((UserDetails.ID)=" + choice + "));"

            Dim da = New OleDbDataAdapter(Sql, con)
            Dim cb As New OleDbCommandBuilder(da)
            da.Fill(ds, "UserDetails")

            FirstnameTextBox.Text = ds.Tables("UserDetails").Rows(0).Item(1)
            SurnameTextBox.Text = ds.Tables("UserDetails").Rows(0).Item(2)
            DOBDateTimePicker.Text = ds.Tables("UserDetails").Rows(0).Item(8)
            PhonenoTextBox.Text = ds.Tables("UserDetails").Rows(0).Item(3)
            PasswordTextBox.Text = ds.Tables("UserDetails").Rows(0).Item(13)
            EmailTextBox.Text = ds.Tables("UserDetails").Rows(0).Item(10)
            StateComboBox.Text = ds.Tables("UserDetails").Rows(0).Item(5)
            StreetTextBox.Text = ds.Tables("UserDetails").Rows(0).Item(4)
            CityTextBox.Text = ds.Tables("UserDetails").Rows(0).Item(6)
            ZipcodeTextBox.Text = ds.Tables("UserDetails").Rows(0).Item(7)
        Catch ex As Exception
            MsgBox("The records cann't be Found")
        End Try

    End Sub

    Private Sub EditUser_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Admin_Dashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub EditUser_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class