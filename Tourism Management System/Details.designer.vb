<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Details
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        Me.User_Details = New System.Windows.Forms.Label()
        Me.Pament_Method = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Name_Field = New System.Windows.Forms.TextBox()
        Me.Phone_No = New System.Windows.Forms.TextBox()
        Me.Full_address = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.TextBox()
        Me.Journey = New System.Windows.Forms.TextBox()
        Me.Journey_Date = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Booking_Date = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Last_Date = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Seat = New System.Windows.Forms.TextBox()
        Me.Total_Paid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Cash = New System.Windows.Forms.RadioButton()
        Me.UPI = New System.Windows.Forms.RadioButton()
        Me.Cards = New System.Windows.Forms.RadioButton()
        Me.Net_Banking = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bank_Details = New System.Windows.Forms.TextBox()
        Me.Draft = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'User_Details
        '
        Me.User_Details.AutoSize = True
        Me.User_Details.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_Details.ForeColor = System.Drawing.Color.Black
        Me.User_Details.Location = New System.Drawing.Point(83, 43)
        Me.User_Details.Name = "User_Details"
        Me.User_Details.Size = New System.Drawing.Size(93, 18)
        Me.User_Details.TabIndex = 0
        Me.User_Details.Text = "User Details"
        '
        'Pament_Method
        '
        Me.Pament_Method.AutoSize = True
        Me.Pament_Method.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pament_Method.Location = New System.Drawing.Point(664, 43)
        Me.Pament_Method.Name = "Pament_Method"
        Me.Pament_Method.Size = New System.Drawing.Size(120, 18)
        Me.Pament_Method.TabIndex = 1
        Me.Pament_Method.Text = "Payment Method"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(404, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Package"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(30, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'Name_Field
        '
        Me.Name_Field.Location = New System.Drawing.Point(128, 83)
        Me.Name_Field.Name = "Name_Field"
        Me.Name_Field.ReadOnly = True
        Me.Name_Field.Size = New System.Drawing.Size(100, 20)
        Me.Name_Field.TabIndex = 4
        Me.Name_Field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Phone_No
        '
        Me.Phone_No.Location = New System.Drawing.Point(128, 122)
        Me.Phone_No.Name = "Phone_No"
        Me.Phone_No.ReadOnly = True
        Me.Phone_No.Size = New System.Drawing.Size(100, 20)
        Me.Phone_No.TabIndex = 5
        Me.Phone_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Full_address
        '
        Me.Full_address.Location = New System.Drawing.Point(128, 206)
        Me.Full_address.MaxLength = 1000000
        Me.Full_address.Multiline = True
        Me.Full_address.Name = "Full_address"
        Me.Full_address.ReadOnly = True
        Me.Full_address.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Full_address.Size = New System.Drawing.Size(100, 101)
        Me.Full_address.TabIndex = 6
        '
        'Gender
        '
        Me.Gender.Location = New System.Drawing.Point(128, 364)
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        Me.Gender.Size = New System.Drawing.Size(100, 20)
        Me.Gender.TabIndex = 7
        Me.Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Journey
        '
        Me.Journey.Location = New System.Drawing.Point(407, 83)
        Me.Journey.Name = "Journey"
        Me.Journey.ReadOnly = True
        Me.Journey.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.Journey.Size = New System.Drawing.Size(148, 20)
        Me.Journey.TabIndex = 8
        '
        'Journey_Date
        '
        Me.Journey_Date.Location = New System.Drawing.Point(407, 125)
        Me.Journey_Date.Name = "Journey_Date"
        Me.Journey_Date.ReadOnly = True
        Me.Journey_Date.Size = New System.Drawing.Size(148, 20)
        Me.Journey_Date.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(30, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Full Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(30, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Phone No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(30, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(316, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Journey"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(316, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Journey Date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(316, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Booking Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(316, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Last Date of Booking"
        '
        'Booking_Date
        '
        Me.Booking_Date.Location = New System.Drawing.Point(407, 163)
        Me.Booking_Date.Name = "Booking_Date"
        Me.Booking_Date.ReadOnly = True
        Me.Booking_Date.Size = New System.Drawing.Size(148, 20)
        Me.Booking_Date.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(324, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Seat Details"
        '
        'Last_Date
        '
        Me.Last_Date.Location = New System.Drawing.Point(445, 206)
        Me.Last_Date.Name = "Last_Date"
        Me.Last_Date.ReadOnly = True
        Me.Last_Date.Size = New System.Drawing.Size(110, 20)
        Me.Last_Date.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(617, 371)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Total Price to Paid"
        '
        'Seat
        '
        Me.Seat.Location = New System.Drawing.Point(407, 248)
        Me.Seat.Name = "Seat"
        Me.Seat.ReadOnly = True
        Me.Seat.Size = New System.Drawing.Size(148, 20)
        Me.Seat.TabIndex = 22
        '
        'Total_Paid
        '
        Me.Total_Paid.Location = New System.Drawing.Point(741, 368)
        Me.Total_Paid.Name = "Total_Paid"
        Me.Total_Paid.ReadOnly = True
        Me.Total_Paid.Size = New System.Drawing.Size(110, 20)
        Me.Total_Paid.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(324, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Description"
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(407, 288)
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Description.Size = New System.Drawing.Size(148, 96)
        Me.Description.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(619, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Payment Methods"
        '
        'Cash
        '
        Me.Cash.AutoSize = True
        Me.Cash.Location = New System.Drawing.Point(17, 13)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(49, 17)
        Me.Cash.TabIndex = 28
        Me.Cash.TabStop = True
        Me.Cash.Text = "Cash"
        Me.Cash.UseVisualStyleBackColor = True
        '
        'UPI
        '
        Me.UPI.AutoSize = True
        Me.UPI.Location = New System.Drawing.Point(17, 135)
        Me.UPI.Name = "UPI"
        Me.UPI.Size = New System.Drawing.Size(43, 17)
        Me.UPI.TabIndex = 29
        Me.UPI.TabStop = True
        Me.UPI.Text = "UPI"
        Me.UPI.UseVisualStyleBackColor = True
        '
        'Cards
        '
        Me.Cards.AutoSize = True
        Me.Cards.Location = New System.Drawing.Point(17, 163)
        Me.Cards.Name = "Cards"
        Me.Cards.Size = New System.Drawing.Size(107, 17)
        Me.Cards.TabIndex = 30
        Me.Cards.TabStop = True
        Me.Cards.Text = "Debit/Credit Card"
        Me.Cards.UseVisualStyleBackColor = True
        '
        'Net_Banking
        '
        Me.Net_Banking.AutoSize = True
        Me.Net_Banking.Location = New System.Drawing.Point(17, 196)
        Me.Net_Banking.Name = "Net_Banking"
        Me.Net_Banking.Size = New System.Drawing.Size(84, 17)
        Me.Net_Banking.TabIndex = 31
        Me.Net_Banking.TabStop = True
        Me.Net_Banking.Text = "Net Banking"
        Me.Net_Banking.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.Bank_Details)
        Me.GroupBox1.Controls.Add(Me.Draft)
        Me.GroupBox1.Controls.Add(Me.Net_Banking)
        Me.GroupBox1.Controls.Add(Me.Cards)
        Me.GroupBox1.Controls.Add(Me.UPI)
        Me.GroupBox1.Controls.Add(Me.Cash)
        Me.GroupBox1.Location = New System.Drawing.Point(629, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 226)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'Bank_Details
        '
        Me.Bank_Details.Enabled = False
        Me.Bank_Details.Location = New System.Drawing.Point(47, 59)
        Me.Bank_Details.Multiline = True
        Me.Bank_Details.Name = "Bank_Details"
        Me.Bank_Details.ReadOnly = True
        Me.Bank_Details.Size = New System.Drawing.Size(152, 60)
        Me.Bank_Details.TabIndex = 33
        Me.Bank_Details.Text = "Account no:- 917044974262" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "IFSC no:- PAYTM0123456" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paytm Payments Bank Limited" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N" &
    "aida-110214"
        '
        'Draft
        '
        Me.Draft.AutoSize = True
        Me.Draft.Location = New System.Drawing.Point(17, 36)
        Me.Draft.Name = "Draft"
        Me.Draft.Size = New System.Drawing.Size(48, 17)
        Me.Draft.TabIndex = 32
        Me.Draft.TabStop = True
        Me.Draft.Text = "Draft"
        Me.Draft.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(30, 326)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Date of Birth"
        '
        'DOB
        '
        Me.DOB.Location = New System.Drawing.Point(128, 326)
        Me.DOB.Name = "DOB"
        Me.DOB.ReadOnly = True
        Me.DOB.Size = New System.Drawing.Size(100, 20)
        Me.DOB.TabIndex = 36
        Me.DOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(33, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Email"
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(128, 163)
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Size = New System.Drawing.Size(100, 20)
        Me.Email.TabIndex = 38
        Me.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cancel
        '
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel.Image = CType(resources.GetObject("Cancel.Image"), System.Drawing.Image)
        Me.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel.Location = New System.Drawing.Point(407, 414)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(73, 31)
        Me.Cancel.TabIndex = 39
        Me.Cancel.Text = " Cancel"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(26, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 31)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Back"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(732, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 31)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Proceed To Pay"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(889, 507)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Total_Paid)
        Me.Controls.Add(Me.Seat)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Last_Date)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Booking_Date)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Journey_Date)
        Me.Controls.Add(Me.Journey)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Full_address)
        Me.Controls.Add(Me.Phone_No)
        Me.Controls.Add(Me.Name_Field)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pament_Method)
        Me.Controls.Add(Me.User_Details)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents User_Details As Label
    Friend WithEvents Pament_Method As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Name_Field As TextBox
    Friend WithEvents Phone_No As TextBox
    Friend WithEvents Full_address As TextBox
    Friend WithEvents Gender As TextBox
    Friend WithEvents Journey As TextBox
    Friend WithEvents Journey_Date As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Booking_Date As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Last_Date As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Seat As TextBox
    Friend WithEvents Total_Paid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Description As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Cash As RadioButton
    Friend WithEvents UPI As RadioButton
    Friend WithEvents Cards As RadioButton
    Friend WithEvents Net_Banking As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bank_Details As TextBox
    Friend WithEvents Draft As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents DOB As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Cancel As Button
End Class
