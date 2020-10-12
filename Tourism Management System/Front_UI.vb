Imports System.Data.OleDb
Imports System.IO
Public Class Front_UI
    'Screen Height And Screen Width Information
    Dim Form_Height As Integer
    Dim Form_Width As Integer

    'Information To Show Images At Every Clock Event
    Dim package_count As Integer = 0
    Dim ref_piclist(10) As ImageList
    Dim ref_picbox(10) As PictureBox
    Dim select_image(10) As Integer

    'Information To Show Announcements At Every Clock Event
    Dim ref_label(23) As Label
    Dim list As ArrayList = New ArrayList()
    Dim start_ind_list As Integer = 0

    'Information To Marge Clock Event To Show Images And Announcements Using A Single Clock
    Dim time_div As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        tour_packages_btn.Height = Form_Height / 728 * 36
        tour_packages_btn.Width = Form_Width / 1366 * 209
        tour_packages_btn.Location = New Point(Form_Width / 1366 * 29, Form_Height / 728 * 117)
        tour_packages_btn.Font = New Font("Arial", CType(Form_Height / 728 * 15, Single), FontStyle.Bold)
        destination_txtbox.Height = Form_Height / 728 * 36
        destination_txtbox.Width = Form_Width / 1366 * 240
        destination_txtbox.Location = New Point(Form_Width / 1366 * 262, Form_Height / 728 * 117)
        destination_txtbox.Font = New Font("Microsoft Sans Serif", CType(Form_Height / 728 * 15, Single), FontStyle.Regular)
        date_txtbox.Height = Form_Height / 728 * 36
        date_txtbox.Width = Form_Width / 1366 * 174
        date_txtbox.Location = New Point(Form_Width / 1366 * 508, Form_Height / 728 * 117)
        date_txtbox.Font = New Font("Microsoft Sans Serif", CType(Form_Height / 728 * 15, Single), FontStyle.Regular)
        search_btn.Height = Form_Height / 728 * 36
        search_btn.Width = Form_Width / 1366 * 40
        search_btn.Location = New Point(Form_Width / 1366 * 685, Form_Height / 728 * 117)
        about_btn.Height = Form_Height / 728 * 36
        about_btn.Width = Form_Width / 1366 * 89
        about_btn.Location = New Point(Form_Width / 1366 * 746, Form_Height / 728 * 117)
        about_btn.Font = New Font("Arial", CType(Form_Height / 728 * 15, Single), FontStyle.Bold)
        login_btn.Height = Form_Height / 728 * 36
        login_btn.Width = Form_Width / 1366 * 117
        login_btn.Location = New Point(Form_Width / 1366 * 1221, Form_Height / 728 * 117)
        login_btn.Font = New Font("Arial", CType(Form_Height / 728 * 15, Single), FontStyle.Bold)
        login_pic.Height = Form_Height / 728 * 28
        login_pic.Width = Form_Width / 1366 * 38
        login_pic.Location = New Point(Form_Width / 1366 * 1225, Form_Height / 728 * 121)
        Announcement_Box.Height = Form_Height / 728 * 504
        Announcement_Box.Width = Form_Width / 1366 * 191
        Announcement_Box.Location = New Point(Form_Width / 1366 * 1155, Form_Height / 728 * 182)
        Announcement_Txt.Location = New Point(Form_Width / 1366 * 1160, Form_Height / 728 * 185)
        Announcement_Txt.Font = New Font("Microsoft Sans Serif", CType(Form_Height / 728 * 16, Single), FontStyle.Bold Or FontStyle.Underline)

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
        Dim package_x_coord As Integer = Form_Width / 1366 * 17
        Dim package_y_coord As Integer = Form_Height / 728 * 182
        While dr.Read()
            If package_count > 9 Then
                Exit While
            End If
            Dim pack As Package = New Package()
            If package_count = 0 Then
                pack.SetPosition(package_x_coord, package_y_coord)
            ElseIf package_count Mod 5 = 0 Then
                package_x_coord = Form_Width / 1366 * 17
                package_y_coord = package_y_coord + Form_Height / 728 * 258
                pack.SetPosition(package_x_coord, package_y_coord)
            Else
                package_x_coord = package_x_coord + Form_Width / 1366 * 227
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
            ref_picbox(package_count) = pack.picbox
            ref_piclist(package_count) = pack.piclist
            package_count += 1
        End While
        connection.Close()

        'Updates Information About Total Number Of Images Present In Every Packages
        Dim pkg_count As Integer
        For pkg_count = 0 To package_count - 1 Step 1
            select_image(pkg_count) = ref_piclist(pkg_count).Images.Count
        Next

        'Creates Dynamic Label To Show Annoumncements And Initilizes Them
        Dim label_count As Integer
        Dim label_y_coord As Integer = Form_Height / 728 * 219
        Dim label_x_coord As Integer = Form_Width / 1366 * 1164
        For label_count = 0 To 22 Step 1
            Dim lbl As Label = New Label()
            lbl.BackColor = Color.Goldenrod
            lbl.Font = New Font("Microsoft Sans Serif", CType(Form_Height / 728 * 12.7, Single), FontStyle.Underline)
            lbl.ForeColor = Color.Red
            lbl.Location = New Point(label_x_coord, label_y_coord)
            label_y_coord = label_y_coord + (Form_Height / 728 * 20)
            lbl.Height = Form_Height / 728 * 20
            lbl.Width = Form_Width / 1366 * 173
            Controls.Add(lbl)
            lbl.BringToFront()
            ref_label(label_count) = lbl
        Next

        'Database Connection To Retrive Data To Show Announcements
        Dim conn_for_announcement As OleDbConnection = New OleDbConnection()
        Try
            conn_for_announcement.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\Announcement.accdb" + ";Jet OLEDB:Database Password=0123456789"
            conn_for_announcement.Open()
            command = "SELECT Announcement.[Description]
From Announcement;"
            cmd = New OleDbCommand(command, conn_for_announcement)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            Timer1.Start()
            MessageBox.Show("Announcement.accdb Not Found!", "Tourism")
            Exit Sub
        End Try

        'Retrives And Adjustes Every Announcements Strings And Stores Them Into A List
        While dr.Read()
            Dim data As String = dr(0).ToString
            If data.Length <= 17 Then
                list.Add(data)
                list.Add("")
            Else
                Dim div As Double = data.Length / 17.0
                Dim count As Integer = 1
                Dim start_ind As Integer = 0
                While count <= div
                    list.Add(data.Substring(start_ind, 17))
                    count += 1
                    start_ind += 17
                End While
                div = div - (count - 1)
                If div = 0.0 Then
                    list.Add("")
                Else
                    div = div * 17.0
                    list.Add(data.Substring(start_ind, div))
                    list.Add("")
                End If
            End If
        End While
        conn_for_announcement.Close()

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
        If time_div = 0 Then
            For pkg_count = 0 To package_count - 1 Step 1
                If ref_piclist(pkg_count).Images.Count <> 0 Then
                    select_image(pkg_count) = (select_image(pkg_count) + 1) Mod ref_piclist(pkg_count).Images.Count
                    ref_picbox(pkg_count).Image = ref_piclist(pkg_count).Images.Item(select_image(pkg_count))
                End If
            Next
        End If

        'Changes Announcements
        If list.Count <> 0 Then
            For count = 0 To 22 Step 1
                ref_label(count).Text = list.Item((start_ind_list + count) Mod list.Count)
            Next
            start_ind_list = (start_ind_list + 1) Mod list.Count
        End If

        'Marges 5 Clock Events
        time_div = (time_div + 1) Mod 5
    End Sub

    Private Sub tour_packages_btn_Click(sender As Object, e As EventArgs) Handles tour_packages_btn.Click
        Me.Hide()
        All_Pkgs_Form.Show()
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
            Me.Hide()
            New_Search_Form.Show()
            New_Search_Form.search("Both")
        ElseIf valid_date = True And valid_destinatin = False Then
            Me.Hide()
            New_Search_Form.Show()
            New_Search_Form.search("Date")
        ElseIf valid_destinatin = True And valid_date = False Then
            Me.Hide()
            New_Search_Form.Show()
            New_Search_Form.search("Destination")
        End If

        Me.destination_txtbox.Text = " Destination"
        Me.date_txtbox.Text = "DD/MM/YYYY"
    End Sub

    Private Sub DynamicButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim New_Pkg_Details_View As Pkg_Details_View = New Pkg_Details_View
        New_Pkg_Details_View.PackageId = sender.AccessibleDescription
        New_Pkg_Details_View.caller_form = Me
        Me.Hide()
        New_Pkg_Details_View.Show()
    End Sub

    Private Sub about_btn_Click(sender As Object, e As EventArgs) Handles about_btn.Click
        About_Form.Show()
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Login_Select.Show()
    End Sub

    Private Sub Front_UI_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim connection As OleDbConnection = New OleDbConnection
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory + "\UserInfo.accdb" + ";Jet OLEDB:Database Password=0123456789"
        Try
            connection.Open()
            Dim sql As String = "UPDATE UserDetails SET UserDetails.[LoginStatus] = No
WHERE (((UserDetails.[LoginStatus])=Yes));"
            Dim command As OleDbCommand = New OleDbCommand(sql, connection)
            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("UserInfo Database Not Found !")
        End Try
    End Sub
End Class