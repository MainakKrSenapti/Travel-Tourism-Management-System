<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pkg_Details_View
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pkg_Details_View))
        Me.Back_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.heading_1 = New System.Windows.Forms.Label()
        Me.heading_2 = New System.Windows.Forms.Label()
        Me.btn_ctnr = New System.Windows.Forms.PictureBox()
        Me.login_pic = New System.Windows.Forms.PictureBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.L_Date_Of_B = New System.Windows.Forms.Label()
        Me.P_P_Person = New System.Windows.Forms.Label()
        Me.A_Seat = New System.Windows.Forms.Label()
        Me.Heading = New System.Windows.Forms.Label()
        Me.Contact_Info = New System.Windows.Forms.Label()
        Me.Description_1 = New System.Windows.Forms.Label()
        Me.Description_2 = New System.Windows.Forms.Label()
        Me.D_Of_Journey = New System.Windows.Forms.Label()
        Me.Book_Btn = New System.Windows.Forms.Button()
        CType(Me.btn_ctnr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.login_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back_btn
        '
        Me.Back_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Back_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Back_btn.FlatAppearance.BorderSize = 3
        Me.Back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back_btn.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_btn.ForeColor = System.Drawing.Color.White
        Me.Back_btn.Location = New System.Drawing.Point(29, 117)
        Me.Back_btn.Name = "Back_btn"
        Me.Back_btn.Size = New System.Drawing.Size(89, 36)
        Me.Back_btn.TabIndex = 1
        Me.Back_btn.Text = "Back"
        Me.Back_btn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'heading_1
        '
        Me.heading_1.AutoSize = True
        Me.heading_1.BackColor = System.Drawing.Color.Transparent
        Me.heading_1.Font = New System.Drawing.Font("Elephant", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heading_1.ForeColor = System.Drawing.Color.Teal
        Me.heading_1.Location = New System.Drawing.Point(331, 26)
        Me.heading_1.Name = "heading_1"
        Me.heading_1.Size = New System.Drawing.Size(318, 56)
        Me.heading_1.TabIndex = 5
        Me.heading_1.Text = "WELCOME"
        '
        'heading_2
        '
        Me.heading_2.AutoSize = True
        Me.heading_2.BackColor = System.Drawing.Color.Transparent
        Me.heading_2.Font = New System.Drawing.Font("Elephant", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heading_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.heading_2.Location = New System.Drawing.Point(642, 26)
        Me.heading_2.Name = "heading_2"
        Me.heading_2.Size = New System.Drawing.Size(376, 56)
        Me.heading_2.TabIndex = 6
        Me.heading_2.Text = "TO TOURISM"
        '
        'btn_ctnr
        '
        Me.btn_ctnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ctnr.Location = New System.Drawing.Point(0, 103)
        Me.btn_ctnr.Name = "btn_ctnr"
        Me.btn_ctnr.Size = New System.Drawing.Size(1350, 62)
        Me.btn_ctnr.TabIndex = 7
        Me.btn_ctnr.TabStop = False
        '
        'login_pic
        '
        Me.login_pic.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.login_pic.Image = CType(resources.GetObject("login_pic.Image"), System.Drawing.Image)
        Me.login_pic.Location = New System.Drawing.Point(1225, 121)
        Me.login_pic.Name = "login_pic"
        Me.login_pic.Size = New System.Drawing.Size(38, 28)
        Me.login_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.login_pic.TabIndex = 9
        Me.login_pic.TabStop = False
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.login_btn.FlatAppearance.BorderSize = 3
        Me.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_btn.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.login_btn.Location = New System.Drawing.Point(1221, 117)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(117, 36)
        Me.login_btn.TabIndex = 8
        Me.login_btn.Text = "Login"
        Me.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(56, 265)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(719, 395)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'L_Date_Of_B
        '
        Me.L_Date_Of_B.AutoSize = True
        Me.L_Date_Of_B.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Date_Of_B.ForeColor = System.Drawing.Color.Maroon
        Me.L_Date_Of_B.Location = New System.Drawing.Point(796, 414)
        Me.L_Date_Of_B.Name = "L_Date_Of_B"
        Me.L_Date_Of_B.Size = New System.Drawing.Size(259, 27)
        Me.L_Date_Of_B.TabIndex = 14
        Me.L_Date_Of_B.Text = "Last Date Of Booking : "
        '
        'P_P_Person
        '
        Me.P_P_Person.AutoSize = True
        Me.P_P_Person.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_P_Person.ForeColor = System.Drawing.Color.Maroon
        Me.P_P_Person.Location = New System.Drawing.Point(796, 495)
        Me.P_P_Person.Name = "P_P_Person"
        Me.P_P_Person.Size = New System.Drawing.Size(212, 27)
        Me.P_P_Person.TabIndex = 15
        Me.P_P_Person.Text = "Price Per Person : "
        '
        'A_Seat
        '
        Me.A_Seat.AutoSize = True
        Me.A_Seat.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A_Seat.ForeColor = System.Drawing.Color.Maroon
        Me.A_Seat.Location = New System.Drawing.Point(796, 571)
        Me.A_Seat.Name = "A_Seat"
        Me.A_Seat.Size = New System.Drawing.Size(182, 27)
        Me.A_Seat.TabIndex = 16
        Me.A_Seat.Text = "Available Seat : "
        '
        'Heading
        '
        Me.Heading.AutoSize = True
        Me.Heading.BackColor = System.Drawing.Color.Transparent
        Me.Heading.Font = New System.Drawing.Font("Britannic Bold", 40.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heading.ForeColor = System.Drawing.Color.Maroon
        Me.Heading.Location = New System.Drawing.Point(216, 189)
        Me.Heading.Name = "Heading"
        Me.Heading.Size = New System.Drawing.Size(394, 59)
        Me.Heading.TabIndex = 17
        Me.Heading.Text = "Mumbai To Goa"
        '
        'Contact_Info
        '
        Me.Contact_Info.AutoSize = True
        Me.Contact_Info.Font = New System.Drawing.Font("Britannic Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_Info.ForeColor = System.Drawing.Color.Maroon
        Me.Contact_Info.Location = New System.Drawing.Point(301, 1380)
        Me.Contact_Info.Name = "Contact_Info"
        Me.Contact_Info.Size = New System.Drawing.Size(740, 90)
        Me.Contact_Info.TabIndex = 18
        Me.Contact_Info.Text = "                 For Further Information Contact To Us" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mobile No : 9568741253  E" &
    "mail : tourism_2019@gmail.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Description_1
        '
        Me.Description_1.AutoSize = True
        Me.Description_1.Font = New System.Drawing.Font("Britannic Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description_1.ForeColor = System.Drawing.Color.Black
        Me.Description_1.Location = New System.Drawing.Point(51, 682)
        Me.Description_1.Name = "Description_1"
        Me.Description_1.Size = New System.Drawing.Size(187, 240)
        Me.Description_1.TabIndex = 20
        Me.Description_1.Text = "Departure : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Travel Media : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hotels : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Food :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Return : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Travel Media : "
        '
        'Description_2
        '
        Me.Description_2.AutoSize = True
        Me.Description_2.Font = New System.Drawing.Font("Britannic Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description_2.ForeColor = System.Drawing.Color.Black
        Me.Description_2.Location = New System.Drawing.Point(51, 945)
        Me.Description_2.Name = "Description_2"
        Me.Description_2.Size = New System.Drawing.Size(140, 240)
        Me.Description_2.TabIndex = 21
        Me.Description_2.Text = "Itinerary : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Day 1 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Day 2 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Day 3 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Day 4 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Day 5 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Day 6 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Day 7 :"
        '
        'D_Of_Journey
        '
        Me.D_Of_Journey.AutoSize = True
        Me.D_Of_Journey.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Of_Journey.ForeColor = System.Drawing.Color.Maroon
        Me.D_Of_Journey.Location = New System.Drawing.Point(796, 341)
        Me.D_Of_Journey.Name = "D_Of_Journey"
        Me.D_Of_Journey.Size = New System.Drawing.Size(204, 27)
        Me.D_Of_Journey.TabIndex = 22
        Me.D_Of_Journey.Text = "Date Of Journey : "
        '
        'Book_Btn
        '
        Me.Book_Btn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Book_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Book_Btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Book_Btn.FlatAppearance.BorderSize = 0
        Me.Book_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Book_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Book_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Book_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book_Btn.ForeColor = System.Drawing.Color.Transparent
        Me.Book_Btn.Location = New System.Drawing.Point(544, 1304)
        Me.Book_Btn.Name = "Book_Btn"
        Me.Book_Btn.Size = New System.Drawing.Size(244, 60)
        Me.Book_Btn.TabIndex = 23
        Me.Book_Btn.Text = "Book Now"
        Me.Book_Btn.UseVisualStyleBackColor = False
        '
        'Pkg_Details_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1351, 689)
        Me.Controls.Add(Me.Book_Btn)
        Me.Controls.Add(Me.D_Of_Journey)
        Me.Controls.Add(Me.Description_2)
        Me.Controls.Add(Me.Description_1)
        Me.Controls.Add(Me.Contact_Info)
        Me.Controls.Add(Me.Heading)
        Me.Controls.Add(Me.A_Seat)
        Me.Controls.Add(Me.P_P_Person)
        Me.Controls.Add(Me.L_Date_Of_B)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.login_pic)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.Back_btn)
        Me.Controls.Add(Me.heading_2)
        Me.Controls.Add(Me.heading_1)
        Me.Controls.Add(Me.btn_ctnr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pkg_Details_View"
        Me.Text = "Tourism"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.btn_ctnr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.login_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back_btn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents heading_1 As Label
    Friend WithEvents heading_2 As Label
    Friend WithEvents btn_ctnr As PictureBox
    Friend WithEvents login_pic As PictureBox
    Friend WithEvents login_btn As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvent As Label
    Friend WithEvents L_Date_Of_B As Label
    Friend WithEvents P_P_Person As Label
    Friend WithEvents A_Seat As Label
    Friend WithEvents Heading As Label
    Friend WithEvents Contact_Info As Label
    Friend WithEvents Description_1 As Label
    Friend WithEvents Description_2 As Label
    Friend WithEvents D_Of_Journey As Label
    Friend WithEvents Book_Btn As Button
End Class
