<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Package_manage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Package_manage))
        Me.ConnectionCheck = New System.Windows.Forms.Button()
        Me.DatabaseShow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FromTextBox = New System.Windows.Forms.TextBox()
        Me.ToTextBox = New System.Windows.Forms.TextBox()
        Me.TotalSeatTextBox = New System.Windows.Forms.TextBox()
        Me.Description1TextBox = New System.Windows.Forms.TextBox()
        Me.Description2TextBox = New System.Windows.Forms.TextBox()
        Me.Price_Per_PersonTextBox = New System.Windows.Forms.TextBox()
        Me.From = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Upload = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Date_Of_JourneyTextBox = New System.Windows.Forms.DateTimePicker()
        Me.Last_Date_Of_BookingTextBox = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnectionCheck
        '
        Me.ConnectionCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectionCheck.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectionCheck.Image = CType(resources.GetObject("ConnectionCheck.Image"), System.Drawing.Image)
        Me.ConnectionCheck.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConnectionCheck.Location = New System.Drawing.Point(28, 440)
        Me.ConnectionCheck.Name = "ConnectionCheck"
        Me.ConnectionCheck.Size = New System.Drawing.Size(157, 60)
        Me.ConnectionCheck.TabIndex = 0
        Me.ConnectionCheck.Text = "Check Conncectivity"
        Me.ConnectionCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ConnectionCheck.UseVisualStyleBackColor = True
        '
        'DatabaseShow
        '
        Me.DatabaseShow.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatabaseShow.Image = CType(resources.GetObject("DatabaseShow.Image"), System.Drawing.Image)
        Me.DatabaseShow.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DatabaseShow.Location = New System.Drawing.Point(765, 440)
        Me.DatabaseShow.Name = "DatabaseShow"
        Me.DatabaseShow.Size = New System.Drawing.Size(131, 60)
        Me.DatabaseShow.TabIndex = 1
        Me.DatabaseShow.Text = "Show Database"
        Me.DatabaseShow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DatabaseShow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(35, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(574, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "    Edit the package and its all details here :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FromTextBox
        '
        Me.FromTextBox.Location = New System.Drawing.Point(152, 66)
        Me.FromTextBox.Name = "FromTextBox"
        Me.FromTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FromTextBox.TabIndex = 3
        '
        'ToTextBox
        '
        Me.ToTextBox.Location = New System.Drawing.Point(152, 133)
        Me.ToTextBox.Name = "ToTextBox"
        Me.ToTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ToTextBox.TabIndex = 4
        '
        'TotalSeatTextBox
        '
        Me.TotalSeatTextBox.Location = New System.Drawing.Point(152, 257)
        Me.TotalSeatTextBox.Name = "TotalSeatTextBox"
        Me.TotalSeatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalSeatTextBox.TabIndex = 5
        '
        'Description1TextBox
        '
        Me.Description1TextBox.Location = New System.Drawing.Point(521, 57)
        Me.Description1TextBox.Multiline = True
        Me.Description1TextBox.Name = "Description1TextBox"
        Me.Description1TextBox.Size = New System.Drawing.Size(333, 136)
        Me.Description1TextBox.TabIndex = 7
        '
        'Description2TextBox
        '
        Me.Description2TextBox.Location = New System.Drawing.Point(521, 199)
        Me.Description2TextBox.Multiline = True
        Me.Description2TextBox.Name = "Description2TextBox"
        Me.Description2TextBox.Size = New System.Drawing.Size(333, 142)
        Me.Description2TextBox.TabIndex = 8
        '
        'Price_Per_PersonTextBox
        '
        Me.Price_Per_PersonTextBox.Location = New System.Drawing.Point(152, 199)
        Me.Price_Per_PersonTextBox.Name = "Price_Per_PersonTextBox"
        Me.Price_Per_PersonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Price_Per_PersonTextBox.TabIndex = 20
        '
        'From
        '
        Me.From.AutoSize = True
        Me.From.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.From.Location = New System.Drawing.Point(78, 70)
        Me.From.Name = "From"
        Me.From.Size = New System.Drawing.Size(46, 13)
        Me.From.TabIndex = 21
        Me.From.Text = "From :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "To :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Total Seat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Available Seat :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(402, 365)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 26)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Last Date Of Booking :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(DD-MM-YYYY)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 26)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Date Of Journey :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(DD-MM-YYYY)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Price Per Person :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(285, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 52)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Description 1 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Describe Date & Time Of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Journey And Return, Travel Media, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F" &
    "acilites (Hotels Details, etc.. )"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Felix Titling", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(310, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 26)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Description 2 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Describe Day Wise Itinerary)"
        '
        'Upload
        '
        Me.Upload.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Upload.Image = CType(resources.GetObject("Upload.Image"), System.Drawing.Image)
        Me.Upload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Upload.Location = New System.Drawing.Point(634, 451)
        Me.Upload.Name = "Upload"
        Me.Upload.Size = New System.Drawing.Size(88, 35)
        Me.Upload.TabIndex = 36
        Me.Upload.Text = "Upload"
        Me.Upload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Upload.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Update.Image = CType(resources.GetObject("Update.Image"), System.Drawing.Image)
        Me.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Update.Location = New System.Drawing.Point(226, 451)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(86, 35)
        Me.Update.TabIndex = 37
        Me.Update.Text = "Update"
        Me.Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Update.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Clear.Image = CType(resources.GetObject("Clear.Image"), System.Drawing.Image)
        Me.Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Clear.Location = New System.Drawing.Point(366, 451)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(78, 35)
        Me.Clear.TabIndex = 38
        Me.Clear.Text = "Clear"
        Me.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Delete.Location = New System.Drawing.Point(497, 451)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(89, 35)
        Me.Delete.TabIndex = 39
        Me.Delete.Text = "Delete"
        Me.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(149, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 40
        '
        'Date_Of_JourneyTextBox
        '
        Me.Date_Of_JourneyTextBox.Location = New System.Drawing.Point(152, 370)
        Me.Date_Of_JourneyTextBox.Name = "Date_Of_JourneyTextBox"
        Me.Date_Of_JourneyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Date_Of_JourneyTextBox.TabIndex = 43
        '
        'Last_Date_Of_BookingTextBox
        '
        Me.Last_Date_Of_BookingTextBox.Location = New System.Drawing.Point(569, 370)
        Me.Last_Date_Of_BookingTextBox.Name = "Last_Date_Of_BookingTextBox"
        Me.Last_Date_Of_BookingTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Last_Date_Of_BookingTextBox.TabIndex = 44
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(866, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 29)
        Me.Button4.TabIndex = 48
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Package_manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 512)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Last_Date_Of_BookingTextBox)
        Me.Controls.Add(Me.Date_Of_JourneyTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Upload)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.From)
        Me.Controls.Add(Me.Price_Per_PersonTextBox)
        Me.Controls.Add(Me.Description2TextBox)
        Me.Controls.Add(Me.Description1TextBox)
        Me.Controls.Add(Me.TotalSeatTextBox)
        Me.Controls.Add(Me.ToTextBox)
        Me.Controls.Add(Me.FromTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DatabaseShow)
        Me.Controls.Add(Me.ConnectionCheck)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Package_manage"
        Me.Text = "Package Edit Form"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConnectionCheck As Button
    Friend WithEvents DatabaseShow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FromTextBox As TextBox
    Friend WithEvents ToTextBox As TextBox
    Friend WithEvents TotalSeatTextBox As TextBox
    Friend WithEvents Description1TextBox As TextBox
    Friend WithEvents Description2TextBox As TextBox
    Friend WithEvents Price_Per_PersonTextBox As TextBox
    Friend WithEvents From As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Upload As Button
    Friend WithEvents Update As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Date_Of_JourneyTextBox As DateTimePicker
    Friend WithEvents Last_Date_Of_BookingTextBox As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
