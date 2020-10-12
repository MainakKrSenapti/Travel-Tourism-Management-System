<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Select
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Select))
        Me.User_login = New System.Windows.Forms.Button()
        Me.Admin_login = New System.Windows.Forms.Button()
        Me.Create_acc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'User_login
        '
        Me.User_login.BackColor = System.Drawing.Color.Navy
        Me.User_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_login.ForeColor = System.Drawing.Color.White
        Me.User_login.Location = New System.Drawing.Point(193, 103)
        Me.User_login.Name = "User_login"
        Me.User_login.Size = New System.Drawing.Size(360, 73)
        Me.User_login.TabIndex = 0
        Me.User_login.Text = "User Login"
        Me.User_login.UseVisualStyleBackColor = False
        '
        'Admin_login
        '
        Me.Admin_login.BackColor = System.Drawing.Color.Maroon
        Me.Admin_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin_login.ForeColor = System.Drawing.Color.White
        Me.Admin_login.Location = New System.Drawing.Point(193, 220)
        Me.Admin_login.Name = "Admin_login"
        Me.Admin_login.Size = New System.Drawing.Size(360, 75)
        Me.Admin_login.TabIndex = 1
        Me.Admin_login.Text = "Admin Login"
        Me.Admin_login.UseVisualStyleBackColor = False
        '
        'Create_acc
        '
        Me.Create_acc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Create_acc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create_acc.ForeColor = System.Drawing.Color.White
        Me.Create_acc.Location = New System.Drawing.Point(193, 346)
        Me.Create_acc.Name = "Create_acc"
        Me.Create_acc.Size = New System.Drawing.Size(360, 68)
        Me.Create_acc.TabIndex = 2
        Me.Create_acc.Text = "Create New Account"
        Me.Create_acc.UseVisualStyleBackColor = False
        '
        'Login_Select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(771, 498)
        Me.Controls.Add(Me.Create_acc)
        Me.Controls.Add(Me.Admin_login)
        Me.Controls.Add(Me.User_login)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(787, 537)
        Me.MinimumSize = New System.Drawing.Size(787, 537)
        Me.Name = "Login_Select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tourism"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User_login As Button
    Friend WithEvents Admin_login As Button
    Friend WithEvents Create_acc As Button
End Class
