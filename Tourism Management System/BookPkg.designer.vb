<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookPkg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookPkg))
        Me.AdultSeat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChildSeat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Last_date = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Journey = New System.Windows.Forms.TextBox()
        Me.Greeting = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CurrentTime = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Price_Person = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AdultSeat
        '
        Me.AdultSeat.ForeColor = System.Drawing.SystemColors.InfoText
        Me.AdultSeat.Location = New System.Drawing.Point(144, 160)
        Me.AdultSeat.Name = "AdultSeat"
        Me.AdultSeat.Size = New System.Drawing.Size(47, 20)
        Me.AdultSeat.TabIndex = 1
        Me.AdultSeat.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImageKey = "(none)"
        Me.Label1.Location = New System.Drawing.Point(47, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Adult Seat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Child Seat"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChildSeat
        '
        Me.ChildSeat.Location = New System.Drawing.Point(144, 206)
        Me.ChildSeat.Name = "ChildSeat"
        Me.ChildSeat.Size = New System.Drawing.Size(47, 20)
        Me.ChildSeat.TabIndex = 4
        Me.ChildSeat.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Price"
        '
        'TotalPrice
        '
        Me.TotalPrice.Enabled = False
        Me.TotalPrice.Location = New System.Drawing.Point(189, 291)
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        Me.TotalPrice.Size = New System.Drawing.Size(80, 20)
        Me.TotalPrice.TabIndex = 11
        Me.TotalPrice.Text = "0"
        Me.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Last Date of Booking"
        '
        'Last_date
        '
        Me.Last_date.Location = New System.Drawing.Point(176, 340)
        Me.Last_date.Name = "Last_date"
        Me.Last_date.ReadOnly = True
        Me.Last_date.Size = New System.Drawing.Size(128, 20)
        Me.Last_date.TabIndex = 13
        Me.Last_date.Text = "- - /- - / - - - -"
        Me.Last_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Your Journey"
        '
        'Journey
        '
        Me.Journey.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Journey.Location = New System.Drawing.Point(176, 103)
        Me.Journey.Name = "Journey"
        Me.Journey.ReadOnly = True
        Me.Journey.Size = New System.Drawing.Size(198, 22)
        Me.Journey.TabIndex = 15
        Me.Journey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Greeting
        '
        Me.Greeting.AutoSize = True
        Me.Greeting.Font = New System.Drawing.Font("Lucida Handwriting", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Greeting.Location = New System.Drawing.Point(141, 59)
        Me.Greeting.Name = "Greeting"
        Me.Greeting.Size = New System.Drawing.Size(92, 15)
        Me.Greeting.TabIndex = 16
        Me.Greeting.Text = "Hello Biplob"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Current Time"
        '
        'CurrentTime
        '
        Me.CurrentTime.Location = New System.Drawing.Point(176, 381)
        Me.CurrentTime.Name = "CurrentTime"
        Me.CurrentTime.ReadOnly = True
        Me.CurrentTime.Size = New System.Drawing.Size(128, 20)
        Me.CurrentTime.TabIndex = 24
        Me.CurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Price Per Seat"
        '
        'Price_Person
        '
        Me.Price_Person.Location = New System.Drawing.Point(189, 252)
        Me.Price_Person.Name = "Price_Person"
        Me.Price_Person.ReadOnly = True
        Me.Price_Person.Size = New System.Drawing.Size(80, 20)
        Me.Price_Person.TabIndex = 27
        Me.Price_Person.Text = "0"
        Me.Price_Person.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Accept T/C"
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Location = New System.Drawing.Point(331, 207)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(25, 20)
        Me.Button10.TabIndex = 32
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Location = New System.Drawing.Point(331, 159)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(25, 20)
        Me.Button9.TabIndex = 31
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(300, 207)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(25, 20)
        Me.Button8.TabIndex = 30
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(300, 159)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 20)
        Me.Button7.TabIndex = 29
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel.Image = CType(resources.GetObject("Cancel.Image"), System.Drawing.Image)
        Me.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel.Location = New System.Drawing.Point(144, 471)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(64, 32)
        Me.Cancel.TabIndex = 25
        Me.Cancel.Text = "Cancel"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(243, 207)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(18, 17)
        Me.Button6.TabIndex = 22
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(243, 160)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(18, 17)
        Me.Button5.TabIndex = 21
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(267, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(18, 17)
        Me.Button4.TabIndex = 20
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(219, 161)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(18, 17)
        Me.Button3.TabIndex = 19
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(219, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(18, 17)
        Me.Button2.TabIndex = 18
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(267, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(18, 17)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.AutoEllipsis = True
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BackButton.Location = New System.Drawing.Point(26, 471)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(65, 32)
        Me.BackButton.TabIndex = 10
        Me.BackButton.Text = "Back"
        Me.BackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CheckBox1.Image = CType(resources.GetObject("CheckBox1.Image"), System.Drawing.Image)
        Me.CheckBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(176, 418)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.CheckBox1.Size = New System.Drawing.Size(38, 20)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "    "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Enabled = False
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NextButton.Image = CType(resources.GetObject("NextButton.Image"), System.Drawing.Image)
        Me.NextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NextButton.Location = New System.Drawing.Point(243, 471)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(68, 32)
        Me.NextButton.TabIndex = 8
        Me.NextButton.Text = "Next"
        Me.NextButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'BookPkg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(840, 537)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Price_Person)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.CurrentTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Greeting)
        Me.Controls.Add(Me.Journey)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Last_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TotalPrice)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChildSeat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AdultSeat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BookPkg"
        Me.Padding = New System.Windows.Forms.Padding(10, 20, 30, 30)
        Me.Text = "Tourism"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdultSeat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ChildSeat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NextButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BackButton As Button
    Friend WithEvents TotalPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Last_date As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Journey As TextBox
    Friend WithEvents Greeting As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CurrentTime As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Price_Person As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
