<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.MRadioButton = New System.Windows.Forms.RadioButton()
        Me.FRadioButton = New System.Windows.Forms.RadioButton()
        Me.ORadioButton = New System.Windows.Forms.RadioButton()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.PhonenoTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.ZipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.ShowPassword = New System.Windows.Forms.Button()
        Me.Upload = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProviderphone = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderzip = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderPhone2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderzip2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderDOB = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderphone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderzip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderPhone2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderzip2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderDOB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "D.O.B :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gender :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Password :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(315, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Street Name :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(357, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "State :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(365, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "City :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(340, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Zipcode :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(70, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Email :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(609, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("SimSun-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(37, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(430, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "   Please Enter Your Details here :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(53, 413)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(185, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "I agree all the terms and condition"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(123, 196)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 15
        '
        'StateComboBox
        '
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Items.AddRange(New Object() {"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu and Kashmir", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal", "Other"})
        Me.StateComboBox.Location = New System.Drawing.Point(410, 153)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StateComboBox.TabIndex = 16
        '
        'MRadioButton
        '
        Me.MRadioButton.AutoSize = True
        Me.MRadioButton.Location = New System.Drawing.Point(123, 252)
        Me.MRadioButton.Name = "MRadioButton"
        Me.MRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.MRadioButton.TabIndex = 18
        Me.MRadioButton.TabStop = True
        Me.MRadioButton.Text = "Male"
        Me.MRadioButton.UseVisualStyleBackColor = True
        '
        'FRadioButton
        '
        Me.FRadioButton.AutoSize = True
        Me.FRadioButton.Location = New System.Drawing.Point(177, 252)
        Me.FRadioButton.Name = "FRadioButton"
        Me.FRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.FRadioButton.TabIndex = 19
        Me.FRadioButton.TabStop = True
        Me.FRadioButton.Text = "Female"
        Me.FRadioButton.UseVisualStyleBackColor = True
        '
        'ORadioButton
        '
        Me.ORadioButton.AutoSize = True
        Me.ORadioButton.Location = New System.Drawing.Point(242, 252)
        Me.ORadioButton.Name = "ORadioButton"
        Me.ORadioButton.Size = New System.Drawing.Size(51, 17)
        Me.ORadioButton.TabIndex = 20
        Me.ORadioButton.TabStop = True
        Me.ORadioButton.Text = "Other"
        Me.ORadioButton.UseVisualStyleBackColor = True
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Location = New System.Drawing.Point(136, 68)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(157, 20)
        Me.FirstnameTextBox.TabIndex = 21
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.Location = New System.Drawing.Point(136, 116)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(157, 20)
        Me.SurnameTextBox.TabIndex = 22
        '
        'PhonenoTextBox
        '
        Me.PhonenoTextBox.Location = New System.Drawing.Point(136, 155)
        Me.PhonenoTextBox.Name = "PhonenoTextBox"
        Me.PhonenoTextBox.Size = New System.Drawing.Size(157, 20)
        Me.PhonenoTextBox.TabIndex = 23
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(136, 306)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(157, 20)
        Me.PasswordTextBox.TabIndex = 24
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(136, 363)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(331, 20)
        Me.EmailTextBox.TabIndex = 25
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(410, 106)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StreetTextBox.TabIndex = 26
        '
        'ZipcodeTextBox
        '
        Me.ZipcodeTextBox.Location = New System.Drawing.Point(410, 264)
        Me.ZipcodeTextBox.Name = "ZipcodeTextBox"
        Me.ZipcodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipcodeTextBox.TabIndex = 27
        '
        'ShowPassword
        '
        Me.ShowPassword.Image = CType(resources.GetObject("ShowPassword.Image"), System.Drawing.Image)
        Me.ShowPassword.Location = New System.Drawing.Point(308, 304)
        Me.ShowPassword.Name = "ShowPassword"
        Me.ShowPassword.Size = New System.Drawing.Size(44, 23)
        Me.ShowPassword.TabIndex = 28
        Me.ShowPassword.UseVisualStyleBackColor = True
        '
        'Upload
        '
        Me.Upload.Enabled = False
        Me.Upload.Image = CType(resources.GetObject("Upload.Image"), System.Drawing.Image)
        Me.Upload.Location = New System.Drawing.Point(655, 318)
        Me.Upload.Name = "Upload"
        Me.Upload.Size = New System.Drawing.Size(95, 62)
        Me.Upload.TabIndex = 29
        Me.Upload.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(628, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Upload Your Image here"
        Me.Label13.Visible = False
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(410, 213)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 31
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorProviderphone
        '
        Me.ErrorProviderphone.ContainerControl = Me
        '
        'ErrorProviderzip
        '
        Me.ErrorProviderzip.ContainerControl = Me
        '
        'ErrorProviderPhone2
        '
        Me.ErrorProviderPhone2.ContainerControl = Me
        '
        'ErrorProviderzip2
        '
        Me.ErrorProviderzip2.ContainerControl = Me
        '
        'ErrorProviderDOB
        '
        Me.ErrorProviderDOB.ContainerControl = Me
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Upload)
        Me.Controls.Add(Me.ShowPassword)
        Me.Controls.Add(Me.ZipcodeTextBox)
        Me.Controls.Add(Me.StreetTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PhonenoTextBox)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(Me.ORadioButton)
        Me.Controls.Add(Me.FRadioButton)
        Me.Controls.Add(Me.MRadioButton)
        Me.Controls.Add(Me.StateComboBox)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateAccount"
        Me.Text = "CreateAccount"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderphone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderzip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderPhone2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderzip2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderDOB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
    Friend WithEvents StateComboBox As ComboBox
    Friend WithEvents MRadioButton As RadioButton
    Friend WithEvents FRadioButton As RadioButton
    Friend WithEvents ORadioButton As RadioButton
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents PhonenoTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents ZipcodeTextBox As TextBox
    Friend WithEvents ShowPassword As Button
    Friend WithEvents Upload As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ErrorProviderphone As ErrorProvider
    Friend WithEvents ErrorProviderzip As ErrorProvider
    Friend WithEvents ErrorProviderPhone2 As ErrorProvider
    Friend WithEvents ErrorProviderzip2 As ErrorProvider
    Friend WithEvents ErrorProviderDOB As ErrorProvider
End Class
