Imports System.Data.OleDb
Imports System.IO
Public Class All_Pkgs_Form
    'Screen Height And Screen Width Information
    Dim Form_Height As Integer
    Dim Form_Width As Integer

    'Information To Show Images At Every Clock Event
    Dim package_count As Integer = 0
    Dim ref_piclist As ArrayList = New ArrayList()
    Dim ref_picbox As ArrayList = New ArrayList()
    Dim select_image As ArrayList = New ArrayList()

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
        destination_txtbox.Height = Form_Height / 728 * 36
        destination_txtbox.Width = Form_Width / 1366 * 240
        destination_txtbox.Location = New Point(Form_Width / 1366 * 135, Form_Height / 728 * 117)
        destination_txtbox.Font = New Font("Microsoft Sans Serif", CType(Form_Height / 728 * 15, Single), FontStyle.Regular)
        date_txtbox.Height = Form_Height / 728 * 36
        date_txtbox.Width = Form_Width / 1366 * 174
        date_txtbox.Location = New Point(Form_Width / 1366 * 381, Form_Height / 728 * 117)
        date_txtbox.Font = New Font("Microsoft Sans Serif", CType(Form_Height / 728 * 15, Single), FontStyle.Regular)
        search_btn.Height = Form_Height / 728 * 36
        search_btn.Width = Form_Width / 1366 * 40
        search_btn.Location = New Point(Form_Width / 1366 * 558, Form_Height / 728 * 117)
        Home_btn.Height = Form_Height / 728 * 36
        Home_btn.Width = Form_Width / 1366 * 89
        Home_btn.Location = New Point(Form_Width / 1366 * 29, Form_Height / 728 * 117)
        Home_btn.Font = New Font("Arial", CType(Form_Height / 728 * 15, Single), FontStyle.Bold)
        Home_btn.Font = New Font("Arial", CType(Form_Height / 728 * 15, Single), FontStyle.Bold)
        login_btn.Height = Form_Height / 728 * 36
        login_btn.Width = Form_Width / 1366 * 117
        login_btn.Location = New Point(Form_Width / 1366 * 1221, Form_Height / 728 * 117)
        login_btn.Font = New Font("Arial", CType(Form_Height / 728 * 15, Single), FontStyle.Bold)
        login_pic.Height = Form_Height / 728 * 28
        login_pic.Width = Form_Width / 1366 * 38
        login_pic.Location = New Point(Form_Width / 1366 * 1225, Form_Height / 728 * 121)

        'Database Connection To Retrive Packages Information
        Dim connection As OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\PackagesInfo.accdb" + ";Jet OLEDB:Database Password=0123456789"
        Try
            connection.Open()
            command = "SELECT PackagesInfo.[PackageID], PackagesInfo.[From], PackagesInfo.[To], PackagesInfo.[Price_Per_Person], PackagesInfo.[Image_1], PackagesInfo.[Image_2], PackagesInfo.[Image_3], PackagesInfo.[Image_4], PackagesInfo.[Image_5], PackagesInfo.[Image_6], PackagesInfo.[Image_7], PackagesInfo.[Image_8], PackagesInfo.[Image_9], PackagesInfo.[Image_10]
From PackagesInfo
Order By PackagesInfo.[Total_Seat] - [Available_Seat] DESC;"
            cmd = New OleDbCommand(command, connection)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("PackagesInfo.accdb Not Found!", "Tourism")
            Me.Close()
            Exit Sub
        End Try

        'Creates Dyanmic Packages And Initilizes Them
        Dim package_x_coord As Integer = Form_Width / 1366 * 16
        Dim package_y_coord As Integer = Form_Height / 728 * 182
        While dr.Read()
            Dim pack As Package = New Package()
            If package_count = 0 Then
                pack.SetPosition(package_x_coord, package_y_coord)
            ElseIf package_count Mod 6 = 0 Then
                package_x_coord = Form_Width / 1366 * 16
                package_y_coord = package_y_coord + Form_Height / 728 * 258
                pack.SetPosition(package_x_coord, package_y_coord)
            Else
                package_x_coord = package_x_coord + Form_Width / 1366 * 224
                pack.SetPosition(package_x_coord, package_y_coord)
            End If
            pack.btn.AccessibleDescription = dr(0).ToString
            pack.btn.Text = dr(1).ToString + "-" + dr(2).ToString
            pack.price.Text = "Only Rs " + dr(3).ToString
            Dim img_index As Integer
            For img_index = 0 To 4 Step 1
                If dr(img_index + 4).ToString = "None" Then
                    Exit For
                End If
                Try
                    Dim img As Image = Image.FromFile(path + "\Images\" + dr(img_index + 4).ToString)
                    pack.piclist.Images.Add(img_index.ToString, img)
                Catch ex As Exception
                    Continue For
                End Try
            Next
            Controls.Add(pack.btn)
            Controls.Add(pack.clickhere)
            pack.clickhere.BringToFront()
            Controls.Add(pack.picbox)
            Controls.Add(pack.price)
            pack.price.BringToFront()
            AddHandler pack.btn.Click, AddressOf DynamicButton_Click
            ref_picbox.Add(pack.picbox)
            ref_piclist.Add(pack.piclist)
            package_count += 1
        End While
        connection.Close()

        'Updates Information About Total Number Of Images Present In Every Packages
        Dim pkg_count As Integer
        For pkg_count = 0 To package_count - 1 Step 1
            select_image.Add(ref_piclist.Item(pkg_count).Images.Count)
        Next

        Timer1.Start()
    End Sub

    'Packages Class To Store Data About Packages
    Class Package
        Public picbox As PictureBox = New PictureBox()
        Public btn As Button = New Button()
        Public price As Label = New Label()
        Public clickhere As Label = New Label()
        Public piclist As ImageList = New ImageList()
        Dim Form_Height As Integer
        Dim Form_Width As Integer
        Public Sub New()
            Form_Height = My.Computer.Screen.WorkingArea.Height
            Form_Width = My.Computer.Screen.WorkingArea.Width
            picbox.BackgroundImageLayout = ImageLayout.Stretch
            picbox.BorderStyle = BorderStyle.None
            picbox.Height = Form_Height / 728 * 129
            picbox.Width = Form_Width / 1366 * 209
            btn.BackColor = Color.Maroon
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderColor = Color.White
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseDownBackColor = Color.Brown
            btn.FlatAppearance.MouseOverBackColor = Color.Maroon
            btn.Font = New Font("Microsoft Sans Serif", CType(Form_Height / 728 * 20, Single), FontStyle.Bold)
            btn.ForeColor = Color.White
            btn.TextAlign = ContentAlignment.TopCenter
            btn.Height = Form_Height / 728 * 120
            btn.Width = Form_Width / 1366 * 209
            price.BackColor = Color.Maroon
            price.BorderStyle = BorderStyle.None
            price.Font = New Font("Microsoft Sans Serif", CType(Form_Height / 728 * 15, Single), FontStyle.Bold)
            price.ForeColor = Color.White
            price.Width = Form_Width / 1366 * 154
            price.Height = Form_Height / 728 * 25
            clickhere.BackColor = Color.Maroon
            clickhere.BorderStyle = BorderStyle.None
            clickhere.Font = New Font("Microsoft Sans Serif", CType(Form_Height / 728 * 10, Single), FontStyle.Regular)
            clickhere.ForeColor = Color.White
            clickhere.Text = "Click Here For More Details"
            clickhere.Width = Form_Width / 1366 * 180
            clickhere.Height = Form_Height / 728 * 17
            piclist.ImageSize = New Size(picbox.Width, picbox.Height)
        End Sub
        Public Sub SetPosition(ByVal x As Integer, ByVal y As Integer)
            picbox.Location = New Point(x, y)
            btn.Location = New Point(x, y + (Form_Height / 728 * 126))
            price.Location = New Point(x + (Form_Width / 1366 * 29), y + (Form_Height / 728 * 196))
            clickhere.Location = New Point(x + (Form_Width / 1366 * 16), y + (Form_Height / 728 * 223))
        End Sub
    End Class

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Changes Image Of Every Packages
        Dim pkg_count As Integer
        For pkg_count = 0 To package_count - 1 Step 1
            If ref_piclist.Item(pkg_count).Images.Count <> 0 Then
                select_image.Item(pkg_count) = (select_image.Item(pkg_count) + 1) Mod ref_piclist.Item(pkg_count).Images.Count
                ref_picbox.Item(pkg_count).Image = ref_piclist.Item(pkg_count).Images.Item(select_image.Item(pkg_count))
            End If
        Next
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Dim New_Search_Form As Search_Form = New Search_Form()

        Dim valid_destinatin As Boolean = False
        Dim valid_date As Boolean = False

        If destination_txtbox.Text <> " Destination" Then
            New_Search_Form.destination = destination_txtbox.Text
            valid_destinatin = True
        End If
        If IsDate(date_txtbox.Text) = True Then
            New_Search_Form._date = CType(date_txtbox.Text, Date)
            valid_date = True
        Else
            If date_txtbox.Text <> "DD/MM/YYYY" Then
                MessageBox.Show("Invalid Date !", "Tourism")
                date_txtbox.Text = "DD/MM/YYYY"
            End If
        End If

        If valid_destinatin = False And valid_date = False Then
            Exit Sub
        ElseIf valid_date = True And valid_destinatin = True Then
            Me.Dispose()
            New_Search_Form.Show()
            New_Search_Form.search("Both")
        ElseIf valid_date = True And valid_destinatin = False Then
            Me.Dispose()
            New_Search_Form.Show()
            New_Search_Form.search("Date")
        ElseIf valid_destinatin = True And valid_date = False Then
            Me.Dispose()
            New_Search_Form.Show()
            New_Search_Form.search("Destination")
        End If
    End Sub

    Private Sub Home_btn_Click(sender As Object, e As EventArgs) Handles Home_btn.Click
        Front_UI.Show()
        Me.Dispose()
    End Sub

    Private Sub DynamicButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim New_Pkg_Details_View As Pkg_Details_View = New Pkg_Details_View
        New_Pkg_Details_View.PackageId = sender.AccessibleDescription
        New_Pkg_Details_View.caller_form = Me
        Me.Hide()
        New_Pkg_Details_View.Show()
    End Sub

    Private Sub login_btn_Click_1(sender As Object, e As EventArgs) Handles login_btn.Click
        Login_Select.Show()
    End Sub

    Private Sub All_Pkgs_Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Front_UI.Dispose()
    End Sub
End Class
