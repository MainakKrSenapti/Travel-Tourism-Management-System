Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Controls

Public Class CreateAccount

    Dim con As New OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim MyFolder As String
    Dim TheDatabase As String
    Dim FullDataBasePath As String
    Dim Sql As String
    Dim rs As New Resizer
    Dim dbImg As String
    Dim Dest As String
    Dim Source As String
    Dim Row, last_row_index As Integer
    Dim flag As Integer = 0

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Upload.Click
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

        Dim cb As New OleDb.OleDbCommandBuilder(da)

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
            Dim Gender As Char
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

            MessageBox.Show("The record has been added successfully.Upload your Image file by clicking on the box.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PictureBox1.Visible = True
            Label13.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Function Get_Last_id() As Integer
        Dim query As String
        Dim row, last_row_index As Integer
        Dim last_id As Integer
        query = "SELECT ID FROM UserDetails"            'Only ID coloumn of PackagesInfo selected
        Dim da As New OleDbDataAdapter(query, con) 'dataadapter for fetching database with selected query
        Dim ds As New DataSet

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception                               'Providing Error Message
            MessageBox.Show("Uable to Connect", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End                                             'Closing Application
        End Try
        da.Fill(ds)                   'Dataset filled with database PackagesInfo by dataadapter, refrenced as PackageID 
        con.Close()
        row = ds.Tables(0).Rows.Count              ' No. of rows in the loaded table
        last_row_index = row - 1                   'Index of the last row
        last_id = Convert.ToInt32(ds.Tables(0).Rows(last_row_index).Item(0)) 'fetching last inserted PackageID
        Return last_id
    End Function

    Private Function Rename() As Integer
        Dim last_id As Integer
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"  'png +
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            'Getting Source & Destination and NewImgName
            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source = Path.GetFullPath(OpenFileDialog1.FileName)
            'SourceFileName = System.IO.Path.GetFileName(Source1)            'Don't erase this command cz of future need
            'MessageBox.Show(SourceFileName)                                 'Don't erase this command cz of future need
            last_id = Get_Last_id()
            dbImg = last_id.ToString() & ".jpg"                 'last_id as string
            Dest = CurrentDirectory + "\User_Image\" + dbImg      'destination for 1st Image with new name assign
        Else
            Return -1
        End If
        Return last_id
    End Function

    Private Sub StoreNameToDB()
        '//Store ImgName To Database Accurate Position
        Dim last_id = Rename()

        If last_id <> -1 Then
            Dim query As String
            query = "SELECT * FROM UserDetails" 'Whole PackagesInfo selected
            Dim da As New OleDbDataAdapter(query, con) 'DataAdapter for fetching database with selected query
            Dim ds As New DataSet
            con.Open()
            da.Fill(ds, "UserInfo")              'Dataset filled with database PackagesInfo by dataadapter reference as DBPackagesInfo

            Row = ds.Tables(0).Rows.Count        ' No. of rows in the loaded table
            last_row_index = Row - 1


            CopyImageToDestination()

            Sql = "UPDATE UserDetails SET UserDetails.[Picture] = """ + dbImg.ToString() + """ WHERE (((UserDetails.ID)=" + last_id.ToString() + "));"
            Dim command As OleDbCommand = New OleDbCommand(Sql, con)
           
            Dim success As Integer = command.ExecuteNonQuery()
            If success <> 0 Then
                MsgBox("Success")
            Else
                MsgBox("ID Not Found !")
            End If
            con.Close()
            MessageBox.Show("Images Uploaded Successfully", "Success", MessageBoxButtons.OK)
            Me.Dispose()
        End If
    End Sub

    Private Sub CopyImageToDestination()
        If Source IsNot Nothing Then
            My.Computer.FileSystem.CopyFile(
            Source, Dest, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
             Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If

    End Sub

    Private Sub PhonenoTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhonenoTextBox.TextChanged
        If IsNumeric(Me.PhonenoTextBox.Text) Then
            Me.ErrorProviderphone.SetError(Me.PhonenoTextBox, "")
            If Len(Me.PhonenoTextBox.Text) < 11 Then
                Me.ErrorProviderPhone2.SetError(Me.PhonenoTextBox, "")
                Return
            Else
                Me.ErrorProviderPhone2.SetError(Me.PhonenoTextBox, "  Please Enter a Valid Mobile Number")
                Return
            End If
            Return
        Else
            Me.ErrorProviderphone.SetError(Me.PhonenoTextBox, "Please Enter a Valid Number")
            Return
        End If

    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.V OrElse e.KeyCode = Keys.C) Then e.SuppressKeyPress = True
        'Disallows the copy paste event
    End Sub

    Private Sub ZipcodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ZipcodeTextBox.TextChanged
        If IsNumeric(Me.ZipcodeTextBox.Text) Then
            Me.ErrorProviderzip.SetError(Me.ZipcodeTextBox, "")
            If Len(Me.ZipcodeTextBox.Text) < 11 Then
                Me.ErrorProviderzip2.SetError(Me.ZipcodeTextBox, "")
                Return
            Else
                Me.ErrorProviderzip2.SetError(Me.ZipcodeTextBox, "  Please Enter a Valid Mobile Number")
                Return
            End If
            Return
        Else
            Me.ErrorProviderzip.SetError(Me.ZipcodeTextBox, "Please Enter a Valid Number")
            Return
        End If
    End Sub

    Private Sub ShowPassword_Click(sender As Object, e As EventArgs) Handles ShowPassword.Click

        If flag = 0 Then
            PasswordTextBox.PasswordChar = ""
            flag = 1
        Else
            PasswordTextBox.PasswordChar = "*"
            flag = 0
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Upload.Enabled = True
    End Sub

    Private Sub DOBDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DOBDateTimePicker.ValueChanged
        If Me.DOBDateTimePicker.Text > Date.Today.AddYears(-18) Then
            Me.ErrorProviderDOB.SetError(Me.DOBDateTimePicker, "You will be eligible to create account after being 18+")
            Return
        Else
            Me.ErrorProviderDOB.SetError(Me.DOBDateTimePicker, "")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        StoreNameToDB()
    End Sub

    Private Sub CreateAccount_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class