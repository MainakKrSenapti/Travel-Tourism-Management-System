Imports System.Data.OleDb
Imports System.IO
Public Class Pkg_Details_View
    'To Receive Data From Another Form
    Public PackageId As Integer
    Public caller_form As Form

    'Screen Height And Screen Width Information
    Dim Form_Height As Integer
    Dim Form_Width As Integer

    'Information To Show Images
    Dim select_image As Integer = 0
    Dim PicList As ArrayList = New ArrayList()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True

        Form_Height = My.Computer.Screen.WorkingArea.Height
        Form_Width = My.Computer.Screen.WorkingArea.Width
        Me.Height = Form_Height
        Me.Width = Form_Width

        'Path Of The Executable File
        Dim path As String = Directory.GetCurrentDirectory

        'Information To Handle Database
        Dim command As String
        Dim dr As OleDbDataReader
        Dim cmd As OleDbCommand

        'Initilization Of Local Objects According To Screen Size
        heading_1.Height = Form_Height / 728 * 56
        heading_1.Width = Form_Height / 728 * 318
        heading_1.Location = New Point(Form_Width / 1366 * 331, Form_Height / 728 * 26)
        heading_1.Font = New Font("Elephant", CType(Form_Height / 728 * 33, Single), FontStyle.Bold)
        heading_2.Height = Form_Height / 728 * 56
        heading_2.Width = Form_Height / 728 * 376
        heading_2.Location = New Point(Form_Width / 1366 * 642, Form_Height / 728 * 26)
        heading_2.Font = New Font("Elephant", CType(Form_Height / 728 * 33, Single), FontStyle.Bold)
        btn_ctnr.Height = Form_Height / 728 * 62
        btn_ctnr.Width = Form_Width / 1366 * 1350
        btn_ctnr.Location = New Point(Form_Width / 1366 * 0, Form_Height / 728 * 103)
        Back_btn.Height = Form_Height / 728 * 36
        Back_btn.Width = Form_Width / 1366 * 89
        Back_btn.Location = New Point(Form_Width / 1366 * 29, Form_Height / 728 * 117)
        Back_btn.Font = New Font("Arial", CType(Form_Height / 728 * 15, Single), FontStyle.Bold)
        Back_btn.Font = New Font("Arial", CType(Form_Height / 728 * 15, Single), FontStyle.Bold)
        login_btn.Height = Form_Height / 728 * 36
        login_btn.Width = Form_Width / 1366 * 117
        login_btn.Location = New Point(Form_Width / 1366 * 1221, Form_Height / 728 * 117)
        login_btn.Font = New Font("Arial", CType(Form_Height / 728 * 15, Single), FontStyle.Bold)
        login_pic.Height = Form_Height / 728 * 28
        login_pic.Width = Form_Width / 1366 * 38
        login_pic.Location = New Point(Form_Width / 1366 * 1225, Form_Height / 728 * 121)
        PictureBox1.Height = Form_Height / 728 * 395
        PictureBox1.Width = Form_Width / 1366 * 719
        PictureBox1.Location = New Point(Form_Width / 1366 * 56, Form_Height / 728 * 265)
        D_Of_Journey.Height = Form_Height / 728 * 27
        D_Of_Journey.Width = Form_Height / 728 * 204
        D_Of_Journey.Location = New Point(Form_Width / 1366 * 796, Form_Height / 728 * 341)
        D_Of_Journey.Font = New Font("Britannic Bold", CType(Form_Height / 728 * 18, Single), FontStyle.Regular)
        L_Date_Of_B.Height = Form_Height / 728 * 27
        L_Date_Of_B.Width = Form_Height / 728 * 259
        L_Date_Of_B.Location = New Point(Form_Width / 1366 * 796, Form_Height / 728 * 414)
        L_Date_Of_B.Font = New Font("Britannic Bold", CType(Form_Height / 728 * 18, Single), FontStyle.Regular)
        P_P_Person.Height = Form_Height / 728 * 27
        P_P_Person.Width = Form_Height / 728 * 212
        P_P_Person.Location = New Point(Form_Width / 1366 * 796, Form_Height / 728 * 495)
        P_P_Person.Font = New Font("Britannic Bold", CType(Form_Height / 728 * 18, Single), FontStyle.Regular)
        A_Seat.Height = Form_Height / 728 * 27
        A_Seat.Width = Form_Height / 728 * 182
        A_Seat.Location = New Point(Form_Width / 1366 * 796, Form_Height / 728 * 571)
        A_Seat.Font = New Font("Britannic Bold", CType(Form_Height / 728 * 18, Single), FontStyle.Regular)
        Book_Btn.Height = Form_Height / 728 * 55
        Book_Btn.Width = Form_Width / 1366 * 205
        Book_Btn.Font = New Font("Microsoft Sans Serif", CType(Form_Height / 728 * 20, Single), FontStyle.Bold)

        'Database Connection To Retrive Packages Information
        Dim connection As OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\PackagesInfo.accdb" + ";Jet OLEDB:Database Password=0123456789"
        Try
            connection.Open()
            command = "SELECT PackagesInfo.PackageID, PackagesInfo.From, PackagesInfo.To, PackagesInfo.Date_Of_Journey, PackagesInfo.Last_Date_Of_Booking, PackagesInfo.Price_Per_Person, PackagesInfo.Image_1, PackagesInfo.Image_2, PackagesInfo.Image_3, PackagesInfo.Image_4, PackagesInfo.Image_5, PackagesInfo.Image_6, PackagesInfo.Image_7, PackagesInfo.Image_8, PackagesInfo.Image_9, PackagesInfo.Image_10, PackagesInfo.Total_Seat, PackagesInfo.Available_Seat, PackagesInfo.Description_1, PackagesInfo.Description_2
From PackagesInfo
Where (((PackagesInfo.PackageID) = " + PackageId.ToString + "));"
            cmd = New OleDbCommand(command, connection)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("PackagesInfo.accdb Not Found !", "Tourism")
            Me.Close()
            Exit Sub
        End Try

        'Retrives Information
        If dr.Read() Then
            Heading.Text = dr(1) + " To " + dr(2)
            Heading.Location = New Point(CType(PictureBox1.Location.X + (PictureBox1.Width - Heading.Width) / 2, Integer), Form_Height / 728 * 189)
            If Heading.Location.X < PictureBox1.Location.X Then
                Heading.Location = New Point(PictureBox1.Location.X, Heading.Location.Y)
            End If
            D_Of_Journey.Text = D_Of_Journey.Text + dr(3).ToString
            L_Date_Of_B.Text = L_Date_Of_B.Text + dr(4).ToString
            P_P_Person.Text = P_P_Person.Text + dr(5).ToString
            A_Seat.Text = A_Seat.Text + dr(17).ToString
            Description_1.Text = dr(18).ToString
            Description_1.Location = New Point(Form_Width / 1366 * 51, Form_Height / 728 * 682)
            Description_2.Text = dr(19).ToString
            Description_2.Location = New Point(Form_Width / 1366 * 51, Form_Height / 728 * (Description_1.Location.Y + Description_1.Height + Form_Height / 728 * 23))
            Book_Btn.Location = New Point(Form_Width / 1366 * 550, Description_2.Location.Y + Description_2.Height + Form_Height / 728 * 67)
            Book_Btn.AccessibleDescription = PackageId
            Contact_Info.Height = Form_Height / 728 * 90
            Contact_Info.Width = Form_Height / 728 * 740
            Contact_Info.Location = New Point(Form_Width / 1366 * 298, Book_Btn.Location.Y + Book_Btn.Height + Form_Height / 728 * 30)
            Contact_Info.Font = New Font("Britannic Bold", CType(Form_Height / 728 * 20, Single), FontStyle.Regular)
            Dim img_index As Integer
            For img_index = 0 To 9 Step 1
                If dr(img_index + 6).ToString = "None" Then
                    Exit For
                End If
                Try
                    Dim img As Image = Image.FromFile(path + "\Images\" + dr(img_index + 6).ToString)
                    PicList.Add(img)
                Catch ex As Exception
                    Continue For
                End Try
            Next
        End If
        connection.Close()

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Changes Image Of Every Packages
        If PicList.Count <> 0 Then
            PictureBox1.BackgroundImage = CType(PicList.Item(select_image), Image)
            select_image = (select_image + 1) Mod PicList.Count
        End If
    End Sub

    Private Sub Back_btn_Click(sender As Object, e As EventArgs) Handles Back_btn.Click
        Me.Dispose()
        caller_form.Show()
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Login_Select.Show()
    End Sub

    Private Sub All_Pkgs_Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Front_UI.Dispose()
    End Sub

    Private Sub Book_Btn_Click(sender As Object, e As EventArgs) Handles Book_Btn.Click
        Dim BookPkgForm As BookPkg = New BookPkg()
        Try
            BookPkgForm.packID = sender.AccessibleDescription()
            BookPkgForm.prevForm = Me
            BookPkgForm.Show()
            Me.Hide()
        Catch ex As Exception
            BookPkgForm.Dispose()
        End Try
    End Sub
End Class
