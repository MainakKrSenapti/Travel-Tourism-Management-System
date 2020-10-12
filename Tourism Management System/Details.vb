Imports System.IO
Imports System.Data.OleDb
Imports System.DateTimeOffset
Imports System.Drawing.Printing
'Imports System.Drawing.Bitmap
Public Class Details
    Dim WithEvents mPrintDocument As New PrintDocument
    Dim mprintBitmap As Bitmap

    Dim myFolder As String
    Dim conPack As New OleDbConnection
    Dim conUser As New OleDbConnection
    Dim conBook As New OleDbConnection
    Dim dbprovider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
    Dim ds1, ds, ds2 As New DataSet
    Dim da, da1, da2 As OleDbDataAdapter
    Dim payMethod As String
    Public Property adlt As Integer
    Public Property chld As Integer
    Public Property price As Double
    Public prevForm As Form
    Public packID As Integer
    Dim userID As Integer
    Dim rs As New Resizer

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Cash.CheckedChanged

        If Cash.Checked Then
            MsgBox("You have to pay 10% extra of package price if your pay by cash")
            MsgBox("We have to penalty price upto 200% of orginal price if you confirm but don't pay according to our t&c")
            Total_Paid.Text = ((price * 11) / 10)
            payMethod = "Cash"
        Else
            Total_Paid.Text = ""
            payMethod = ""
        End If

        Button1.Enabled = Cash.Checked
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles Draft.CheckedChanged

        If Draft.Checked Then
            MsgBox("We have to penalty price upto 1 lakh of orginal price if you confirm but don't pay according to our t&c")
            Total_Paid.Text = ((price * 12) / 10)
            payMethod = "Draft"
        Else
            Total_Paid.Text = ""
            payMethod = ""
        End If
        Button1.Enabled = Draft.Checked
        Bank_Details.Enabled = Draft.Checked
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles UPI.CheckedChanged
        If UPI.Checked Then
            MsgBox("Sorry!!!We are working with this & you will notified soon..please choose other payment method")
            payMethod = "UPI"
        Else
            payMethod = ""
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Cards.CheckedChanged
        If Cards.Checked Then
            MsgBox("Sorry!!!We are working with this & you will notified soon..please choose other payment method")
            payMethod = "Cards"
        Else
            payMethod = ""
        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles Net_Banking.CheckedChanged
        If Net_Banking.Checked Then
            MsgBox("Sorry!!!We are working with this & you will notified soon..please choose other payment method")
            payMethod = "Net Banking"
        Else
            payMethod = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = MessageBox.Show("Confirm Booking?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = DialogResult.Yes Then
            Dim sql2 = "INSERT INTO Book([UserID],[PackageID],[Adult],[Child],[Payment_Method],[Pack_Price],[Payable_Price],[Date_Of_Booking]) VALUES (?,?,?,?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(sql2, conBook)
            Dim sql3 = "Select ID from Book"
            da2 = New OleDbDataAdapter(sql3, conBook)

            da2.Fill(ds2, "Book")
            Dim val As Integer = ds2.Tables(0).Rows.Count + 1

            Try
                cmd.Parameters.Add(New OleDbParameter("UserID", userID))
                cmd.Parameters.Add(New OleDbParameter("PackageID", packID))
                cmd.Parameters.Add(New OleDbParameter("Adult", adlt))
                cmd.Parameters.Add(New OleDbParameter("Child", chld))
                cmd.Parameters.Add(New OleDbParameter("Payment_Method", payMethod))
                cmd.Parameters.Add(New OleDbParameter("Pack_Price", price))
                cmd.Parameters.Add(New OleDbParameter("Payable_Price", CType(Total_Paid.Text, Double)))
                cmd.Parameters.Add(New OleDbParameter("Date_Of_Booking", CType(Booking_Date.Text, DateTime)))
                Dim rest = MessageBox.Show("Booking is successfull...Do you want to take printout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If rest = DialogResult.Yes Then
                    Button1.Visible = False
                    Button2.Visible = False
                    Cancel.Visible = False
                    Dim preview As New PrintPreviewDialog
                    Dim pd As New Printing.PrintDocument
                    pd.DefaultPageSettings.Landscape = True
                    AddHandler pd.PrintPage, AddressOf OnPrintPage
                    preview.Document = pd
                    preview.ShowDialog()

                End If

                Try
                    If conBook.State = ConnectionState.Closed Then
                        conBook.Open()
                    End If


                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            conBook.Close()
            conUser.Close()
            conPack.Close()
            prevForm.Dispose()
            Me.Dispose()
            Front_UI.Show()
        End If
    End Sub
    Private Sub OnPrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Using bnp As Bitmap = New Bitmap(Me.Width, Me.Height)
            Me.DrawToBitmap(bnp, New Rectangle(0, 0, Me.Width, Me.Height))

            Dim ratio As Single = CSng(bnp.Width / bnp.Height)

            If ratio > e.MarginBounds.Width / e.MarginBounds.Height Then
                e.Graphics.DrawImage(bnp, e.MarginBounds.Left, CInt(e.MarginBounds.Top + (e.MarginBounds.Height / 2) - (e.MarginBounds.Width / ratio / 2)), e.MarginBounds.Width, CInt(e.MarginBounds.Width / ratio))
            Else
                e.Graphics.DrawImage(bnp, CInt(e.MarginBounds.Left + (e.MarginBounds.Width / 2) - (e.MarginBounds.Height * ratio / 2)), e.MarginBounds.Top, CInt(e.MarginBounds.Height * ratio), e.MarginBounds.Height)

            End If
        End Using
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim a As Integer = MessageBox.Show("Do you want to cancel?", "Exit Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = DialogResult.Yes Then
            prevForm.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub m_PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'dram the image centered
        Dim lWidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mprintBitmap.Width)
        Dim lHeight As Integer = e.MarginBounds.Y + (e.MarginBounds.Height - mprintBitmap.Height)
        e.Graphics.DrawImage(mprintBitmap, lWidth, lHeight)
        e.HasMorePages = False
    End Sub
    Private Sub Details_Load(sender As Object, e As EventArgs) Handles Me.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
        rs.ResizeAllControls(Me)

        myFolder = Directory.GetCurrentDirectory
        Dim myDBPack = myFolder & "/PackagesInfo.accdb;"
        Dim myDBUser = myFolder & "/UserInfo.accdb;"
        Dim myDBBook = myFolder & "/Book.accdb;"
        Dim src = "Data Source=" & myDBPack
        Dim src1 = "Data Source=" & myDBUser
        Dim src2 = "Data Source=" & myDBBook
        Try
            conPack.ConnectionString = dbprovider & src & "Jet OLEDB:Database Password=0123456789"
            conUser.ConnectionString = dbprovider & src1
            conBook.ConnectionString = dbprovider & src2 & "Jet OLEDB:Database Password=0123456789"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'open connection
        If conPack.State = ConnectionState.Closed Then
            conPack.Open()
        End If

        'open connection
        If conUser.State = ConnectionState.Closed Then
            conUser.Open()
        End If

        'sql statements

        Dim sql = "SELECT * FROM UserDetails where LoginStatus=yes"
        Dim sql1 = "SELECT PackagesInfo.[From], PackagesInfo.[To], PackagesInfo.[Date_Of_Journey], PackagesInfo.[Last_Date_Of_Booking], PackagesInfo.[Price_Per_Person], PackagesInfo.[Available_Seat], PackagesInfo.[Description_1], PackagesInfo.[Description_2]
FROM PackagesInfo
WHERE (((PackagesInfo.[PackageID])=" + packID.ToString() + "));"

        'Data adapters
        da = New OleDbDataAdapter(sql, conUser)
        da1 = New OleDbDataAdapter(sql1, conPack)

        da.Fill(ds, "UserDetails")
        da1.Fill(ds1, "PackagesInfo")

        'Filling PresonalDetails
        userID = ds.Tables(0).Rows(0).Item(0)
        Name_Field.Text = ds.Tables(0).Rows(0).Item(1) + " " + ds.Tables(0).Rows(0).Item(2)
        Phone_No.Text = ds.Tables(0).Rows(0).Item(3)
        Email.Text = ds.Tables(0).Rows(0).Item(10)
        Full_address.Text = ds.Tables(0).Rows(0).Item(4) + ControlChars.NewLine + ds.Tables(0).Rows(0).Item(6) + ds.Tables(0).Rows(0).Item(7).ToString + ControlChars.NewLine + ds.Tables(0).Rows(0).Item(5)
        DOB.Text = ds.Tables(0).Rows(0).Item(8)
        Dim gen As New String(ds.Tables(0).Rows(0).Item(9))
        If gen.Equals("F") Or gen.Equals("f") Then
            gen = "Female"
        ElseIf gen.Equals("M") Or gen.Equals("m") Then
            gen = "Male"
        End If
        Gender.Text = gen

        'Package Details
        Journey.Text = "From: " + ds1.Tables(0).Rows(0).Item(0) + " To: " + ds1.Tables(0).Rows(0).Item(1)
        Journey_Date.Text = ds1.Tables(0).Rows(0).Item(2)
        Last_Date.Text = ds1.Tables(0).Rows(0).Item(3)
        Booking_Date.Text = DateAndTime.Now
        Seat.Text = "Adult: " + adlt.ToString + " Child: " + chld.ToString
        Description.Text = ds1.Tables(0).Rows(0).Item(6) + " " + ds1.Tables(0).Rows(0).Item(7)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        prevForm.Show()
        Me.Dispose()
    End Sub
    Private Sub Details_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub Details_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        prevForm.Show()
        Me.Dispose()
    End Sub
End Class