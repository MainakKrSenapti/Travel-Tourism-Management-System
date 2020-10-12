Imports System.Data.OleDb
Imports System.IO
Public Class Search_Form
    'Class Variable To Store Destination And Date For Search
    Public destination As String
    Public _date As Date

    'Screen Height And Screen Width Information
    Dim Form_Height As Integer
    Dim Form_Width As Integer

    'Information To Show Images At Every Clock Event
    Dim package_count As Integer = 0
    Dim ref_piclist As ArrayList = New ArrayList()
    Dim ref_picbox As ArrayList = New ArrayList()
    Dim select_image As ArrayList = New ArrayList()

    'Stores References Of All Objects To Dispose It In Future
    Dim ref_objects As ArrayList = New ArrayList()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True

        Form_Height = My.Computer.Screen.WorkingArea.Height
        Form_Width = My.Computer.Screen.WorkingArea.Width
        Me.Height = Form_Height
        Me.Width = Form_Width

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
        search_reasult_lbl.Hide()
        pkgs_nrst_dte_lbl.Hide()
        pkgs_sme_dte_lbl.Hide()
        our_recommendation_lbl.Hide()
    End Sub

    'Search In Database And Initilize A DataReader
    Public Sub search(Search_Type As String)
        Dim path As String = Directory.GetCurrentDirectory

        'Used To Set Location Of Different Search Reasults (Packages At Similar Date, Packages At Nearest Date, Recommended Packages)
        Dim next_loc_of_pkgs As Point = New Point(Form_Width / 1366 * 16, Form_Height / 728 * 235)

        'Information To Handle Database
        Dim connection As OleDbConnection = New OleDbConnection()
        Dim command As String
        Dim dr As OleDbDataReader
        Dim cmd As OleDbCommand
        connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\PackagesInfo.accdb" + ";Jet OLEDB:Database Password=0123456789"

        'When Destination And Date Both Are Given
        If Search_Type = "Both" Then
            'Cerates Search Reasult
            search_reasult_lbl.Height = Form_Height / 728 * 32
            search_reasult_lbl.Width = Form_Height / 728 * 237
            search_reasult_lbl.Location = New Point(Form_Width / 1366 * 12, Form_Height / 728 * 187)
            search_reasult_lbl.Font = New Font("Arial Rounded MT Bold", CType(Form_Height / 728 * 20, Single), FontStyle.Bold)
            search_reasult_lbl.Show()
            Try
                connection.Open()
                command = "SELECT PackagesInfo.PackageID, PackagesInfo.From, PackagesInfo.To, PackagesInfo.Price_Per_Person, PackagesInfo.Image_1, PackagesInfo.Image_2, PackagesInfo.Image_3, PackagesInfo.Image_4, PackagesInfo.Image_5, PackagesInfo.Image_6, PackagesInfo.Image_7, PackagesInfo.Image_8, PackagesInfo.Image_9, PackagesInfo.Image_10
From PackagesInfo
Where (((PackagesInfo.To) = """ + Me.destination.Trim() + """) And ((PackagesInfo.Date_Of_Journey) = " + date_format(Me._date) + "))
Order By PackagesInfo.[Total_Seat] - [Available_Seat] DESC;"
                cmd = New OleDbCommand(command, connection)
                dr = cmd.ExecuteReader
            Catch ex As Exception
                MessageBox.Show("PackagesInfo.accdb Not Found !", "Tourism")
                Me.Close()
                Exit Sub
            End Try
            next_loc_of_pkgs = create_pkgs(dr, next_loc_of_pkgs.X, next_loc_of_pkgs.Y)
            connection.Close()

            'Creates Packages At Similar Date
            pkgs_sme_dte_lbl.Height = Form_Height / 728 * 32
            pkgs_sme_dte_lbl.Width = Form_Height / 728 * 362
            pkgs_sme_dte_lbl.Location = next_loc_of_pkgs
            pkgs_sme_dte_lbl.Font = New Font("Arial Rounded MT Bold", CType(Form_Height / 728 * 20, Single), FontStyle.Bold)
            pkgs_sme_dte_lbl.Show()
            Try
                connection.Open()
                command = "SELECT PackagesInfo.PackageID, PackagesInfo.From, PackagesInfo.To, PackagesInfo.Price_Per_Person, PackagesInfo.Image_1, PackagesInfo.Image_2, PackagesInfo.Image_3, PackagesInfo.Image_4, PackagesInfo.Image_5, PackagesInfo.Image_6, PackagesInfo.Image_7, PackagesInfo.Image_8, PackagesInfo.Image_9, PackagesInfo.Image_10
From PackagesInfo
Where (((PackagesInfo.Date_Of_Journey) = " + date_format(Me._date) + "))
Order By PackagesInfo.[Total_Seat] - [Available_Seat] DESC;"
                cmd = New OleDbCommand(command, connection)
                dr = cmd.ExecuteReader
            Catch ex As Exception
                MessageBox.Show("PackagesInfo.accdb Not Found !", "Tourism")
                Me.Close()
                Exit Sub
            End Try
            next_loc_of_pkgs = create_pkgs(dr, next_loc_of_pkgs.X, next_loc_of_pkgs.Y + Form_Height / 728 * 48)
            connection.Close()

            'Creates Packages At Nearest Date
            pkgs_nrst_dte_lbl.Height = Form_Height / 728 * 32
            pkgs_nrst_dte_lbl.Width = Form_Height / 728 * 377
            pkgs_nrst_dte_lbl.Location = next_loc_of_pkgs
            pkgs_nrst_dte_lbl.Font = New Font("Arial Rounded MT Bold", CType(Form_Height / 728 * 20, Single), FontStyle.Bold)
            pkgs_nrst_dte_lbl.Show()
            Try
                connection.Open()
                command = "SELECT PackagesInfo.PackageID, PackagesInfo.From, PackagesInfo.To, PackagesInfo.Price_Per_Person, PackagesInfo.Image_1, PackagesInfo.Image_2, PackagesInfo.Image_3, PackagesInfo.Image_4, PackagesInfo.Image_5, PackagesInfo.Image_6, PackagesInfo.Image_7, PackagesInfo.Image_8, PackagesInfo.Image_9, PackagesInfo.Image_10
From PackagesInfo
Where (((PackagesInfo.Date_Of_Journey) = " + date_format(_date.AddDays(-2)) + ")) Or (((PackagesInfo.Date_Of_Journey) = " + date_format(_date.AddDays(-1)) + ")) Or (((PackagesInfo.Date_Of_Journey) = " + date_format(_date.AddDays(1)) + ")) Or (((PackagesInfo.Date_Of_Journey) = " + date_format(_date.AddDays(2)) + "))
Order By PackagesInfo.[Total_Seat] - [Available_Seat] DESC;"
                cmd = New OleDbCommand(command, connection)
                dr = cmd.ExecuteReader
            Catch ex As Exception
                MessageBox.Show("PackagesInfo.accdb Not Found !", "Tourism")
                Me.Close()
                Exit Sub
            End Try
            create_pkgs(dr, next_loc_of_pkgs.X, next_loc_of_pkgs.Y + Form_Height / 728 * 48)
            connection.Close()
        End If

        If Search_Type = "Date" Then
            'Creates Search Reasults
            search_reasult_lbl.Height = Form_Height / 728 * 32
            search_reasult_lbl.Width = Form_Height / 728 * 237
            search_reasult_lbl.Location = New Point(Form_Width / 1366 * 12, Form_Height / 728 * 187)
            search_reasult_lbl.Font = New Font("Arial Rounded MT Bold", CType(Form_Height / 728 * 20, Single), FontStyle.Bold)
            search_reasult_lbl.Show()
            Try
                connection.Open()
                command = "SELECT PackagesInfo.PackageID, PackagesInfo.From, PackagesInfo.To, PackagesInfo.Price_Per_Person, PackagesInfo.Image_1, PackagesInfo.Image_2, PackagesInfo.Image_3, PackagesInfo.Image_4, PackagesInfo.Image_5, PackagesInfo.Image_6, PackagesInfo.Image_7, PackagesInfo.Image_8, PackagesInfo.Image_9, PackagesInfo.Image_10
From PackagesInfo
Where (((PackagesInfo.Date_Of_Journey) = " + date_format(Me._date) + "))
Order By PackagesInfo.[Total_Seat] - [Available_Seat] DESC;"
                cmd = New OleDbCommand(command, connection)
                dr = cmd.ExecuteReader
            Catch ex As Exception
                MessageBox.Show("PackagesInfo.accdb Not Found !", "Tourism")
                Me.Close()
                Exit Sub
            End Try
            next_loc_of_pkgs = create_pkgs(dr, next_loc_of_pkgs.X, next_loc_of_pkgs.Y)
            connection.Close()

            'Creates Packages At Nearest Date
            pkgs_nrst_dte_lbl.Height = Form_Height / 728 * 32
            pkgs_nrst_dte_lbl.Width = Form_Height / 728 * 377
            pkgs_nrst_dte_lbl.Location = next_loc_of_pkgs
            pkgs_nrst_dte_lbl.Font = New Font("Arial Rounded MT Bold", CType(Form_Height / 728 * 20, Single), FontStyle.Bold)
            pkgs_nrst_dte_lbl.Show()
            Try
                connection.Open()
                command = "SELECT PackagesInfo.PackageID, PackagesInfo.From, PackagesInfo.To, PackagesInfo.Price_Per_Person, PackagesInfo.Image_1, PackagesInfo.Image_2, PackagesInfo.Image_3, PackagesInfo.Image_4, PackagesInfo.Image_5, PackagesInfo.Image_6, PackagesInfo.Image_7, PackagesInfo.Image_8, PackagesInfo.Image_9, PackagesInfo.Image_10
From PackagesInfo
Where (((PackagesInfo.Date_Of_Journey) = " + date_format(_date.AddDays(-2)) + ")) Or (((PackagesInfo.Date_Of_Journey) = " + date_format(_date.AddDays(-1)) + ")) Or (((PackagesInfo.Date_Of_Journey) = " + date_format(_date.AddDays(1)) + ")) Or (((PackagesInfo.Date_Of_Journey) = " + date_format(_date.AddDays(2)) + "))
Order By PackagesInfo.[Total_Seat] - [Available_Seat] DESC;"
                cmd = New OleDbCommand(command, connection)
                dr = cmd.ExecuteReader
            Catch ex As Exception
                MessageBox.Show("PackagesInfo.accdb Not Found !", "Tourism")
                Me.Close()
                Exit Sub
            End Try
            create_pkgs(dr, next_loc_of_pkgs.X, next_loc_of_pkgs.Y + Form_Height / 728 * 48)
            connection.Close()
        End If

        If Search_Type = "Destination" Then
            'Creates Search Reasult
            search_reasult_lbl.Height = Form_Height / 728 * 32
            search_reasult_lbl.Width = Form_Height / 728 * 237
            search_reasult_lbl.Location = New Point(Form_Width / 1366 * 12, Form_Height / 728 * 187)
            search_reasult_lbl.Font = New Font("Arial Rounded MT Bold", CType(Form_Height / 728 * 20, Single), FontStyle.Bold)
            search_reasult_lbl.Show()
            Try
                connection.Open()
                command = "SELECT PackagesInfo.PackageID, PackagesInfo.From, PackagesInfo.To, PackagesInfo.Price_Per_Person, PackagesInfo.Image_1, PackagesInfo.Image_2, PackagesInfo.Image_3, PackagesInfo.Image_4, PackagesInfo.Image_5, PackagesInfo.Image_6, PackagesInfo.Image_7, PackagesInfo.Image_8, PackagesInfo.Image_9, PackagesInfo.Image_10
From PackagesInfo
Where (((PackagesInfo.To) = """ + Me.destination.Trim() + """))
Order By PackagesInfo.[Total_Seat] - [Available_Seat] DESC;"
                cmd = New OleDbCommand(command, connection)
                dr = cmd.ExecuteReader
            Catch ex As Exception
                MessageBox.Show("PackagesInfo.accdb Not Found !", "Tourism")
                Me.Close()
                Exit Sub
            End Try
            next_loc_of_pkgs = create_pkgs(dr, next_loc_of_pkgs.X, next_loc_of_pkgs.Y)
            connection.Close()

            'Creates Recommendation
            our_recommendation_lbl.Height = Form_Height / 728 * 32
            our_recommendation_lbl.Width = Form_Height / 728 * 322
            our_recommendation_lbl.Location = next_loc_of_pkgs
            our_recommendation_lbl.Font = New Font("Arial Rounded MT Bold", CType(Form_Height / 728 * 20, Single), FontStyle.Bold)
            our_recommendation_lbl.Show()
            Try
                connection.Open()
                command = "SELECT PackagesInfo.PackageID, PackagesInfo.From, PackagesInfo.To, PackagesInfo.Price_Per_Person, PackagesInfo.Image_1, PackagesInfo.Image_2, PackagesInfo.Image_3, PackagesInfo.Image_4, PackagesInfo.Image_5, PackagesInfo.Image_6, PackagesInfo.Image_7, PackagesInfo.Image_8, PackagesInfo.Image_9, PackagesInfo.Image_10
From PackagesInfo
Where (((PackagesInfo.Available_Seat) < [Total_Seat] / 1.5))
Order By PackagesInfo.Available_Seat;"
                cmd = New OleDbCommand(command, connection)
                dr = cmd.ExecuteReader
            Catch ex As Exception
                MessageBox.Show("PackagesInfo.accdb Not Found !", "Tourism")
                Me.Close()
                Exit Sub
            End Try
            create_pkgs(dr, next_loc_of_pkgs.X, next_loc_of_pkgs.Y + Form_Height / 728 * 48)
            connection.Close()
        End If

        Timer1.Start()
    End Sub

    'Converts Date To A Formatted String
    Private Function date_format(ByVal dte As Date) As String
        Dim format_date As String
        format_date = "#" + dte.Month.ToString + "/" + dte.Day.ToString + "/" + dte.Year.ToString + "#"
        Return format_date
    End Function

    'Creates Dynamic Packages Based On A Datareader
    Private Function create_pkgs(ByVal dr As OleDbDataReader, ByVal x As Integer, ByVal y As Integer) As Point
        Dim path As String = Directory.GetCurrentDirectory
        Dim temp_pkg_count As Integer = 0

        'Creates Dyanmic Packages And Initilizes Them
        Dim package_x_coord As Integer = Form_Width / 1366 * x
        Dim package_y_coord As Integer = Form_Height / 728 * y
        While dr.Read()
            Dim pack As Package = New Package()
            ref_objects.Add(pack)
            If temp_pkg_count = 0 Then
                pack.SetPosition(package_x_coord, package_y_coord)
            ElseIf temp_pkg_count Mod 6 = 0 Then
                package_x_coord = Form_Width / 1366 * x
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
            temp_pkg_count += 1
        End While

        'Updates Information About Total Number Of Images Present In Every Packages
        Dim pkg_count As Integer
        For pkg_count = package_count - temp_pkg_count To package_count - 1 Step 1
            select_image.Add(ref_piclist.Item(pkg_count).Images.Count)
        Next

        Return New Point(x, package_y_coord + Form_Height / 728 * 280)
    End Function

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
        Public Sub dispose()
            Me.picbox.Dispose()
            Me.btn.Dispose()
            Me.price.Dispose()
            Me.clickhere.Dispose()
            Me.piclist.Dispose()
        End Sub
    End Class

    'Dipose Prevoius Search Reasult
    Private Sub clear_screen()
        Dim total_object As Integer = ref_objects.Count
        For total_object = total_object - 1 To 0 Step -1
            ref_objects.Item(total_object).dispose()
        Next
        ref_objects.Clear()
        package_count = 0
        ref_picbox.Clear()
        ref_piclist.Clear()
        select_image.Clear()
        search_reasult_lbl.Hide()
        pkgs_sme_dte_lbl.Hide()
        pkgs_nrst_dte_lbl.Hide()
        our_recommendation_lbl.Hide()
        destination_txtbox.Text = " Destination"
        date_txtbox.Text = "DD/MM/YYYY"
    End Sub

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
        Dim valid_destinatin As Boolean = False
        Dim valid_date As Boolean = False

        If destination_txtbox.Text <> " Destination" Then
            Me.destination = destination_txtbox.Text
            valid_destinatin = True
        End If
        If IsDate(date_txtbox.Text) = True Then
            Me._date = CType(date_txtbox.Text, Date)
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
            clear_screen()
            search("Both")
        ElseIf valid_date = True And valid_destinatin = False Then
            clear_screen()
            search("Date")
        ElseIf valid_destinatin = True And valid_date = False Then
            clear_screen()
            search("Destination")
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

    Private Sub Search_Form_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Front_UI.Dispose()
    End Sub
End Class
