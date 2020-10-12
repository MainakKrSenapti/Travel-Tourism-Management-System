Imports System.IO
Imports System.Data.OleDb
Imports System.DateTimeOffset
Public Class BookPkg
    Dim myFolder As String
    Dim conPack As New OleDbConnection
    Dim conUser As New OleDbConnection
    Dim dbprovider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
    Dim ds1, ds As New DataSet
    Dim da, da1 As OleDbDataAdapter
    Public packID As Integer
    Public prevForm As Form
    Dim rs As New Resizer
    Private Sub BookPkg_Load(sender As Object, e As EventArgs) Handles Me.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
        rs.ResizeAllControls(Me)
        'Create Connection
        myFolder = Directory.GetCurrentDirectory
        Dim myDBPack = myFolder & "/PackagesInfo.accdb;"
        Dim myDBUser = myFolder & "/UserInfo.accdb;"
        Dim src = "Data Source=" & myDBPack
        Dim src1 = "Data Source=" & myDBUser
        Try
            conPack.ConnectionString = dbprovider & src & "Jet OLEDB:Database Password=0123456789"
            conUser.ConnectionString = dbprovider & src1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'open connection
        If conPack.State = ConnectionState.Closed Then
            conPack.Open()
        End If
        If conPack.State = ConnectionState.Closed Then
            conUser.Open()
        End If

        Dim sql = "SELECT * FROM UserDetails where LoginStatus=yes"
        Dim sql1 = "Select PackagesInfo.From,PackagesInfo.To,PackagesInfo.Date_Of_Journey,PackagesInfo.Last_Date_Of_Booking, PackagesInfo.Price_Per_Person,PackagesInfo.Available_Seat from PackagesInfo"
        sql1 = sql1 + " where PackagesInfo.PackageID= " + packID.ToString

        'Data adapters
        da = New OleDbDataAdapter(sql, conUser)
        da1 = New OleDbDataAdapter(sql1, conPack)

        da.Fill(ds, "UserDetails")
        da1.Fill(ds1, "PackagesInfo")

        Journey.Text = "From: " + ds1.Tables("PackAgesInfo").Rows(0).Item(0) + " To: " + ds1.Tables("PackAgesInfo").Rows(0).Item(1)
        CurrentTime.Text = DateAndTime.Now

        Last_date.Text = ds1.Tables("PackagesInfo").Rows(0).Item(3)
        Price_Person.Text = ds1.Tables("PackagesInfo").Rows(0).Item(4)

        'Login Status check
        Try
            If ds1.Tables("PackagesInfo").Rows(0).Item(3) >= DateTime.Now Then

                If ds.Tables("UserDetails").Rows.Count = 0 Then
                    MessageBox.Show("You have not logged in!!Go to Login Page", "Login problem", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    prevForm.Show()
                    Login_Select.Show()
                    Login_Select.BringToFront()
                    Me.Dispose()
                    Exit Sub
                ElseIf ds.Tables("UserDetails").Rows.Count > 1 Then
                    Throw New Exception("Error!!Multiple Login")
                ElseIf ds.Tables("UserDetails").Rows.Count = 1 Then

                    Greeting.Text = "Hello " + ds.Tables(0).Rows(0).Item(1)
                End If
            Else
                Throw New Exception("Login Period has already expired")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If ex.Message.Equals("Error!!Multiple Login") Then
                prevForm.Show()
                Me.Dispose()
            End If

            If ex.Message.Equals("Login Period has already expired") Then
                prevForm.Show()
                Me.Dispose()
            End If
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNumeric(AdultSeat.Text) Then
            AdultSeat.Text = (Integer.Parse(AdultSeat.Text) + 1).ToString
        Else
            MessageBox.Show("Error!!!Please enter valid seat no", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(AdultSeat.Text) Then
            AdultSeat.Text = (Integer.Parse(AdultSeat.Text) + 5).ToString
        Else
            MessageBox.Show("Error!!!Please enter valid seat no", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNumeric(ChildSeat.Text) Then
            ChildSeat.Text = (Integer.Parse(ChildSeat.Text) + 1).ToString
        Else
            MessageBox.Show("Error!!!Please enter valid seat no", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNumeric(ChildSeat.Text) Then
            ChildSeat.Text = (Integer.Parse(ChildSeat.Text) + 5).ToString
        Else
            MessageBox.Show("Error!!!Please enter valid seat no", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If IsNumeric(AdultSeat.Text) Then
            AdultSeat.Text = (Integer.Parse(AdultSeat.Text) + 2).ToString
        Else
            MessageBox.Show("Error!!!Please enter valid seat no", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If IsNumeric(ChildSeat.Text) Then
            ChildSeat.Text = (Integer.Parse(ChildSeat.Text) + 2).ToString
        Else
            MessageBox.Show("Error!!!Please enter valid seat no", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim a As Integer = MessageBox.Show("Do you want to cancel?", "Exit Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = DialogResult.Yes Then
            prevForm.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If IsNumeric(AdultSeat.Text) Then
            AdultSeat.Text = (Integer.Parse(AdultSeat.Text) - 1).ToString
        Else
            MessageBox.Show("Error!!!Please enter valid seat no", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AdultSeat.Text = "0"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ChildSeat.Text = "0"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If IsNumeric(AdultSeat.Text) Then
            ChildSeat.Text = (Integer.Parse(ChildSeat.Text) - 1).ToString
        Else
            MessageBox.Show("Error!!!Please enter valid seat no", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        Dim adltST = AdultSeat.Text
        Dim chldST = ChildSeat.Text

        If CheckBox1.Checked = True Then
            TotalPrice.Enabled = True
            If IsNumeric(adltST) And IsNumeric(chldST) And adltST >= 0 And chldST >= 0 AndAlso (adltST - CType(adltST, Integer) = 0) AndAlso (adltST - CType(adltST, Integer) = 0) Then
                Dim adult = Integer.Parse(adltST)
                Dim child = Integer.Parse(chldST)

                If (adult + child) > ds1.Tables("PackagesInfo").Rows(0).Item(5) Then
                    MsgBox("Selected seat cannot be greater than avalaible seat")
                    CheckBox1.Checked = False
                ElseIf (adult + child) = 0 Then
                    MsgBox("Please select a seat")
                    CheckBox1.Checked = False

                Else
                    AdultSeat.ReadOnly = True
                    ChildSeat.ReadOnly = True
                    NextButton.Enabled = True

                    Dim price = ds1.Tables("PackagesInfo").Rows(0).Item(4)
                    price = (price * adult) + (price / 2 * child)
                    TotalPrice.Text = price
                End If
            Else
                Try

                    Throw New Exception("Please enter valid number")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CheckBox1.Checked = False
                    AdultSeat.Text = "0"
                    ChildSeat.Text = "0"
                End Try
            End If
        ElseIf CheckBox1.Checked = False Then
            AdultSeat.ReadOnly = False
            ChildSeat.ReadOnly = False
            NextButton.Enabled = False
            TotalPrice.Text = 0
            TotalPrice.Enabled = False
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        conUser.Close()
        conPack.Close()
        Dim obj As New Details
        obj.adlt = Integer.Parse(AdultSeat.Text)
        obj.chld = Integer.Parse(ChildSeat.Text)
        obj.price = Double.Parse(TotalPrice.Text)
        obj.packID = Me.packID
        obj.prevForm = Me
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        prevForm.Show()
        Me.Dispose()
    End Sub

    Private Sub BookPkg_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub BookPkg_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        prevForm.Show()
        Me.Dispose()
    End Sub
End Class
