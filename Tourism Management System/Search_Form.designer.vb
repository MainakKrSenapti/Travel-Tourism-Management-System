<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_Form))
        Me.Home_btn = New System.Windows.Forms.Button()
        Me.destination_txtbox = New System.Windows.Forms.TextBox()
        Me.date_txtbox = New System.Windows.Forms.TextBox()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.heading_1 = New System.Windows.Forms.Label()
        Me.heading_2 = New System.Windows.Forms.Label()
        Me.btn_ctnr = New System.Windows.Forms.PictureBox()
        Me.login_pic = New System.Windows.Forms.PictureBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.search_reasult_lbl = New System.Windows.Forms.Label()
        Me.pkgs_sme_dte_lbl = New System.Windows.Forms.Label()
        Me.pkgs_nrst_dte_lbl = New System.Windows.Forms.Label()
        Me.our_recommendation_lbl = New System.Windows.Forms.Label()
        CType(Me.btn_ctnr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.login_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Home_btn
        '
        Me.Home_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Home_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Home_btn.FlatAppearance.BorderSize = 3
        Me.Home_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Home_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home_btn.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home_btn.ForeColor = System.Drawing.Color.White
        Me.Home_btn.Location = New System.Drawing.Point(29, 117)
        Me.Home_btn.Name = "Home_btn"
        Me.Home_btn.Size = New System.Drawing.Size(89, 36)
        Me.Home_btn.TabIndex = 1
        Me.Home_btn.Text = "Home"
        Me.Home_btn.UseVisualStyleBackColor = False
        '
        'destination_txtbox
        '
        Me.destination_txtbox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.destination_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.destination_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destination_txtbox.Location = New System.Drawing.Point(135, 117)
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
        Me.date_txtbox.Location = New System.Drawing.Point(381, 117)
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
        Me.search_btn.Location = New System.Drawing.Point(558, 117)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(40, 36)
        Me.search_btn.TabIndex = 4
        Me.search_btn.UseVisualStyleBackColor = False
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
        'search_reasult_lbl
        '
        Me.search_reasult_lbl.AutoSize = True
        Me.search_reasult_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_reasult_lbl.Location = New System.Drawing.Point(12, 187)
        Me.search_reasult_lbl.Name = "search_reasult_lbl"
        Me.search_reasult_lbl.Size = New System.Drawing.Size(237, 32)
        Me.search_reasult_lbl.TabIndex = 10
        Me.search_reasult_lbl.Text = "Search Reasult : "
        '
        'pkgs_sme_dte_lbl
        '
        Me.pkgs_sme_dte_lbl.AutoSize = True
        Me.pkgs_sme_dte_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pkgs_sme_dte_lbl.Location = New System.Drawing.Point(13, 246)
        Me.pkgs_sme_dte_lbl.Name = "pkgs_sme_dte_lbl"
        Me.pkgs_sme_dte_lbl.Size = New System.Drawing.Size(362, 32)
        Me.pkgs_sme_dte_lbl.TabIndex = 11
        Me.pkgs_sme_dte_lbl.Text = "Packages At Similar Date :"
        '
        'pkgs_nrst_dte_lbl
        '
        Me.pkgs_nrst_dte_lbl.AutoSize = True
        Me.pkgs_nrst_dte_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pkgs_nrst_dte_lbl.Location = New System.Drawing.Point(13, 298)
        Me.pkgs_nrst_dte_lbl.Name = "pkgs_nrst_dte_lbl"
        Me.pkgs_nrst_dte_lbl.Size = New System.Drawing.Size(377, 32)
        Me.pkgs_nrst_dte_lbl.TabIndex = 12
        Me.pkgs_nrst_dte_lbl.Text = "Packages At Nearest Date :"
        '
        'our_recommendation_lbl
        '
        Me.our_recommendation_lbl.AutoSize = True
        Me.our_recommendation_lbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.our_recommendation_lbl.Location = New System.Drawing.Point(12, 349)
        Me.our_recommendation_lbl.Name = "our_recommendation_lbl"
        Me.our_recommendation_lbl.Size = New System.Drawing.Size(322, 32)
        Me.our_recommendation_lbl.TabIndex = 13
        Me.our_recommendation_lbl.Text = "Our Recommendation : "
        '
        'Search_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1350, 602)
        Me.Controls.Add(Me.our_recommendation_lbl)
        Me.Controls.Add(Me.pkgs_nrst_dte_lbl)
        Me.Controls.Add(Me.pkgs_sme_dte_lbl)
        Me.Controls.Add(Me.search_reasult_lbl)
        Me.Controls.Add(Me.login_pic)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.Home_btn)
        Me.Controls.Add(Me.heading_2)
        Me.Controls.Add(Me.heading_1)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.date_txtbox)
        Me.Controls.Add(Me.destination_txtbox)
        Me.Controls.Add(Me.btn_ctnr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Search_Form"
        Me.Text = "Tourism"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.btn_ctnr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.login_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Home_btn As Button
    Friend WithEvents destination_txtbox As TextBox
    Friend WithEvents date_txtbox As TextBox
    Friend WithEvents search_btn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents heading_1 As Label
    Friend WithEvents heading_2 As Label
    Friend WithEvents btn_ctnr As PictureBox
    Friend WithEvents login_pic As PictureBox
    Friend WithEvents login_btn As Button
    Friend WithEvents search_reasult_lbl As Label
    Friend WithEvents pkgs_sme_dte_lbl As Label
    Friend WithEvents pkgs_nrst_dte_lbl As Label
    Friend WithEvents our_recommendation_lbl As Label
End Class
