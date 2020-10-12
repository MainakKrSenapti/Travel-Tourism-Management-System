Imports System.Data.OleDb
Imports System.IO

Public Class Package_manage
    Dim con As New OleDbConnection
    Dim MaxRows As Integer
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

    Private Sub Package_manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
        rs.ResizeAllControls(Me)
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        TheDatabase = "/PackagesInfo.accdb"
        MyFolder = Directory.GetCurrentDirectory
        FullDataBasePath = MyFolder & TheDatabase
        dbSource = "Data Source=" & FullDataBasePath
        con.ConnectionString = dbProvider & dbSource & ";Jet OLEDB:Database Password=0123456789"
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
        PackageDatabase.Show()
    End Sub

    Private Sub Package_manage_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub Upload_Click(sender As Object, e As EventArgs) Handles Upload.Click
        Try
            con.Open()                                      'Opening Connection
        Catch ex As Exception                               'Providing Error Message
            MessageBox.Show("Uable to Connect", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End                                             'Closing Application
        End Try
        Sql = "SELECT * FROM PackagesInfo"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "PackagesInfo")
        MaxRows = ds.Tables("PackagesInfo").Rows.Count
        Dim cb As New OleDbCommandBuilder(da)
        ' Dim dsNewRow As DataRow
        Try
            Sql = "INSERT INTO PackagesInfo([From],[To],[Date_Of_Journey],[Last_Date_Of_Booking],[Price_Per_Person],[Total_Seat],[Available_Seat],[Description_1],[Description_2]) VALUES (?,?,?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(Sql, con)
            cmd.Parameters.Add(New OleDbParameter("From", CType(FromTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("To", CType(ToTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Date_Of_Journey", CType(Date_Of_JourneyTextBox.Text, Date)))
            cmd.Parameters.Add(New OleDbParameter("Last_Date_Of_Booking", CType(Last_Date_Of_BookingTextBox.Text, Date)))
            cmd.Parameters.Add(New OleDbParameter("Price_Per_Person", CType(Price_Per_PersonTextBox.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("Total_Seat", CType(TotalSeatTextBox.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("Available_Seat", CType(TotalSeatTextBox.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("Description_1", CType(Description1TextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Description_2", CType(Description2TextBox.Text, String)))
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
            da.Update(ds, "PackagesInfo")
            Refreshed()
            If MessageBox.Show("The record has been added successfully.Do you want to upload Image file ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Me.Hide()
                ImageUpload.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Sub Refreshed()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        FromTextBox.Clear()
        ToTextBox.Clear()
        Description1TextBox.Clear()
        Description2TextBox.Clear()
        Price_Per_PersonTextBox.Clear()
        TotalSeatTextBox.Clear()
        Date_Of_JourneyTextBox.ResetText()
        Last_Date_Of_BookingTextBox.ResetText()
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
            choice = InputBox("Enter packageID to be deleted : ", "Input Number",,,)
            If MessageBox.Show("Do you really want to Delete this Record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                If MessageBox.Show("Deletion operation has been terminated suddenly...", "Aborted", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo Label
                Else
                    MsgBox("Thank You")
                    Exit Sub
                End If
            Else
                If String.IsNullOrEmpty(choice) Then Exit Sub
                Sql = "DELETE * FROM PackagesInfo WHERE ((PackagesInfo.PackageID)=" + choice + ");"
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

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        If flag = 0 Then
            Show()
            If String.IsNullOrEmpty(choice) Then Exit Sub
            flag = 1
        Else
            Try
                con.Open()
                Sql = "UPDATE PackagesInfo SET PackagesInfo.[From] = """ + FromTextBox.Text + """, PackagesInfo.[To] = """ + ToTextBox.Text + """, PackagesInfo.Date_Of_Journey = " + date_format(CType(Date_Of_JourneyTextBox.Text, Date)) + ", PackagesInfo.Last_Date_Of_Booking = " + date_format(CType(Last_Date_Of_BookingTextBox.Text, Date)) + ", PackagesInfo.Price_Per_Person = " + Price_Per_PersonTextBox.Text + ", PackagesInfo.Total_Seat = " + TotalSeatTextBox.Text + ", PackagesInfo.Available_Seat = " + TotalSeatTextBox.Text + ", PackagesInfo.Description_1 = """ + Description1TextBox.Text + """, PackagesInfo.Description_2 = """ + Description2TextBox.Text + """
WHERE (((PackagesInfo.PackageID)=" + choice + "));"
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

    Private Sub TotalSeatTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalSeatTextBox.TextChanged
        Label7.Text = TotalSeatTextBox.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Admin_Dashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub Package_manage_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Admin_Dashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub Show()
        Dim ds As New DataSet
        choice = InputBox("Enter AnnouncementID to be Shown", "Input Number",,,)
        If String.IsNullOrEmpty(choice) Then Exit Sub
        Try

            Sql = "SELECT * From PackagesInfo WHERE (((PackagesInfo.PackageID)=" + choice + "));"

            Dim da = New OleDbDataAdapter(Sql, con)
            Dim cb As New OleDbCommandBuilder(da)
            da.Fill(ds, "PackagesInfo")

            FromTextBox.Text = ds.Tables("PackagesInfo").Rows(0).Item(1)
            ToTextBox.Text = ds.Tables("PackagesInfo").Rows(0).Item(2)
            Date_Of_JourneyTextBox.Text = ds.Tables("PackagesInfo").Rows(0).Item(3)
            Last_Date_Of_BookingTextBox.Text = ds.Tables("PackagesInfo").Rows(0).Item(4)
            Price_Per_PersonTextBox.Text = ds.Tables("PackagesInfo").Rows(0).Item(5)
            TotalSeatTextBox.Text = ds.Tables("PackagesInfo").Rows(0).Item(16)
            Description1TextBox.Text = ds.Tables("PackagesInfo").Rows(0).Item(18)
            Description2TextBox.Text = ds.Tables("PackagesInfo").Rows(0).Item(19)
        Catch ex As Exception
            MsgBox("The records cann't be shown")
        End Try

    End Sub

End Class

Friend Class Resizer
    Private Structure ControlInfo
        Public name As String
        Public parentName As String
        Public leftOffsetPercent As Double
        Public topOffsetPercent As Double
        Public heightPercent As Double
        Public originalHeight As Integer
        Public originalWidth As Integer
        Public widthPercent As Double
        Public originalFontSize As Single
    End Structure
    Private ctrlDict As Dictionary(Of String, ControlInfo) = New Dictionary(Of String, ControlInfo)

    Public Sub FindAllControls(thisCtrl As Control)

        For Each ctl As Control In thisCtrl.Controls
            Try
                If Not IsNothing(ctl.Parent) Then
                    Dim parentHeight = ctl.Parent.Height
                    Dim parentWidth = ctl.Parent.Width

                    Dim c As New ControlInfo
                    c.name = ctl.Name
                    c.parentName = ctl.Parent.Name
                    c.topOffsetPercent = Convert.ToDouble(ctl.Top) / Convert.ToDouble(parentHeight)
                    c.leftOffsetPercent = Convert.ToDouble(ctl.Left) / Convert.ToDouble(parentWidth)
                    c.heightPercent = Convert.ToDouble(ctl.Height) / Convert.ToDouble(parentHeight)
                    c.widthPercent = Convert.ToDouble(ctl.Width) / Convert.ToDouble(parentWidth)
                    c.originalFontSize = ctl.Font.Size
                    c.originalHeight = ctl.Height
                    c.originalWidth = ctl.Width
                    ctrlDict.Add(c.name, c)
                End If

            Catch ex As Exception
                Debug.Print(ex.Message)
            End Try

            If ctl.Controls.Count > 0 Then
                FindAllControls(ctl)
            End If

        Next '-- For Each

    End Sub

    Public Sub ResizeAllControls(thisCtrl As Control)

        Dim fontRatioW As Single
        Dim fontRatioH As Single
        Dim fontRatio As Single
        Dim f As Font

        '-- Resize and reposition all controls in the passed control
        For Each ctl As Control In thisCtrl.Controls
            Try
                If Not IsNothing(ctl.Parent) Then
                    Dim parentHeight = ctl.Parent.Height
                    Dim parentWidth = ctl.Parent.Width

                    Dim c As New ControlInfo

                    Dim ret As Boolean = False
                    Try
                        '-- Get the current control's info from the control info dictionary
                        ret = ctrlDict.TryGetValue(ctl.Name, c)

                        '-- If found, adjust the current control based on control relative
                        '-- size and position information stored in the dictionary
                        If (ret) Then
                            '-- Size
                            ctl.Width = Int(parentWidth * c.widthPercent)
                            ctl.Height = Int(parentHeight * c.heightPercent)

                            '-- Position
                            ctl.Top = Int(parentHeight * c.topOffsetPercent)
                            ctl.Left = Int(parentWidth * c.leftOffsetPercent)

                            '-- Font
                            f = ctl.Font
                            fontRatioW = ctl.Width / c.originalWidth
                            fontRatioH = ctl.Height / c.originalHeight
                            fontRatio = (fontRatioW +
                            fontRatioH) / 2 '-- average change in control Height and Width
                            ctl.Font = New Font(f.FontFamily,
                            c.originalFontSize * fontRatio, f.Style)

                        End If
                    Catch
                    End Try
                End If
            Catch ex As Exception
            End Try

            '-- Recursive call for controls contained in the current control
            If ctl.Controls.Count > 0 Then
                ResizeAllControls(ctl)
            End If

        Next '-- For Each
    End Sub

End Class
