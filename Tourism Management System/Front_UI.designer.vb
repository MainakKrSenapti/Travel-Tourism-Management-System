<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Front_UI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Front_UI))
        Me.tour_packages_btn = New System.Windows.Forms.Button()
        Me.about_btn = New System.Windows.Forms.Button()
        Me.destination_txtbox = New System.Windows.Forms.TextBox()
        Me.date_txtbox = New System.Windows.Forms.TextBox()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.login_pic = New System.Windows.Forms.PictureBox()
        Me.Announcement_Txt = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Announcement_Box = New System.Windows.Forms.PictureBox()
        Me.btn_ctnr = New System.Windows.Forms.PictureBox()
        Me.heading_1 = New System.Windows.Forms.Label()
        Me.heading_2 = New System.Windows.Forms.Label()
        CType(Me.login_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Announcement_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_ctnr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tour_packages_btn
        '
        Me.tour_packages_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tour_packages_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tour_packages_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.tour_packages_btn.FlatAppearance.BorderSize = 3
        Me.tour_packages_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tour_packages_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.tour_packages_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tour_packages_btn.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tour_packages_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tour_packages_btn.Location = New System.Drawing.Point(29, 117)
        Me.tour_packages_btn.Name = "tour_packages_btn"
        Me.tour_packages_btn.Size = New System.Drawing.Size(209, 36)
        Me.tour_packages_btn.TabIndex = 0
        Me.tour_packages_btn.Text = "Tour Packages"
        Me.tour_packages_btn.UseVisualStyleBackColor = False
        '
        'about_btn
        '
        Me.about_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.about_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.about_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.about_btn.FlatAppearance.BorderSize = 3
        Me.about_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.about_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.about_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.about_btn.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.about_btn.Location = New System.Drawing.Point(746, 117)
        Me.about_btn.Name = "about_btn"
        Me.about_btn.Size = New System.Drawing.Size(89, 36)
        Me.about_btn.TabIndex = 1
        Me.about_btn.Text = "About"
        Me.about_btn.UseVisualStyleBackColor = False
        '
        'destination_txtbox
        '
        Me.destination_txtbox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.destination_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.destination_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destination_txtbox.Location = New System.Drawing.Point(262, 117)
        Me.destination_txtbox.MaxLength = 30
        Me.destination_txtbox.Multiline = True
        Me.destination_txtbox.Name = "destination_txtbox"
        Me.destination_txtbox.Size = New System.Drawing.Size(240, 36)
        Me.destination_txtbox.TabIndex = 2
        Me.destination_txtbox.Text = " Destination"
        '
        'date_txtbox
        '
        Me.date_txtbox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.date_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.date_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_txtbox.Location = New System.Drawing.Point(508, 117)
        Me.date_txtbox.MaxLength = 10
        Me.date_txtbox.Multiline = True
        Me.date_txtbox.Name = "date_txtbox"
        Me.date_txtbox.Size = New System.Drawing.Size(174, 36)
        Me.date_txtbox.TabIndex = 3
        Me.date_txtbox.Text = "DD/MM/YYYY"
        Me.date_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'search_btn
        '
        Me.search_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.search_btn.BackgroundImage = CType(resources.GetObject("search_btn.BackgroundImage"), System.Drawing.Image)
        Me.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.search_btn.FlatAppearance.BorderSize = 0
        Me.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search_btn.Location = New System.Drawing.Point(685, 117)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(40, 36)
        Me.search_btn.TabIndex = 4
        Me.search_btn.UseVisualStyleBackColor = False
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
        Me.login_btn.TabIndex = 5
        Me.login_btn.Text = "Login"
        Me.login_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'login_pic
        '
        Me.login_pic.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.login_pic.Image = CType(resources.GetObject("login_pic.Image"), System.Drawing.Image)
        Me.login_pic.Location = New System.Drawing.Point(1225, 121)
        Me.login_pic.Name = "login_pic"
        Me.login_pic.Size = New System.Drawing.Size(38, 28)
        Me.login_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.login_pic.TabIndex = 6
        Me.login_pic.TabStop = False
        '
        'Announcement_Txt
        '
        Me.Announcement_Txt.AutoSize = True
        Me.Announcement_Txt.BackColor = System.Drawing.Color.Goldenrod
        Me.Announcement_Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Announcement_Txt.Location = New System.Drawing.Point(1160, 185)
        Me.Announcement_Txt.Name = "Announcement_Txt"
        Me.Announcement_Txt.Size = New System.Drawing.Size(183, 26)
        Me.Announcement_Txt.TabIndex = 48
        Me.Announcement_Txt.Text = "Announcements"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Announcement_Box
        '
        Me.Announcement_Box.BackColor = System.Drawing.Color.Goldenrod
        Me.Announcement_Box.Location = New System.Drawing.Point(1155, 182)
        Me.Announcement_Box.Name = "Announcement_Box"
        Me.Announcement_Box.Size = New System.Drawing.Size(191, 504)
        Me.Announcement_Box.TabIndex = 47
        Me.Announcement_Box.TabStop = False
        '
        'btn_ctnr
        '
        Me.btn_ctnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ctnr.Location = New System.Drawing.Point(0, 103)
        Me.btn_ctnr.Name = "btn_ctnr"
        Me.btn_ctnr.Size = New System.Drawing.Size(1350, 62)
        Me.btn_ctnr.TabIndex = 49
        Me.btn_ctnr.TabStop = False
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
        Me.heading_1.TabIndex = 50
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
        Me.heading_2.TabIndex = 51
        Me.heading_2.Text = "TO TOURISM"
        '
        'Front_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 689)
        Me.Controls.Add(Me.heading_2)
        Me.Controls.Add(Me.heading_1)
        Me.Controls.Add(Me.Announcement_Txt)
        Me.Controls.Add(Me.Announcement_Box)
        Me.Controls.Add(Me.login_pic)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.date_txtbox)
        Me.Controls.Add(Me.destination_txtbox)
        Me.Controls.Add(Me.about_btn)
        Me.Controls.Add(Me.tour_packages_btn)
        Me.Controls.Add(Me.btn_ctnr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Front_UI"
        Me.Text = "Tourism"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.login_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Announcement_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_ctnr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tour_packages_btn As Button
    Friend WithEvents about_btn As Button
    Friend WithEvents destination_txtbox As TextBox
    Friend WithEvents date_txtbox As TextBox
    Friend WithEvents search_btn As Button
    Friend WithEvents login_btn As Button
    Friend WithEvents login_pic As PictureBox
    Friend WithEvents Announcement_Txt As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Announcement_Box As PictureBox
    Friend WithEvents btn_ctnr As PictureBox
    Friend WithEvents heading_1 As Label
    Friend WithEvents heading_2 As Label
End Class
