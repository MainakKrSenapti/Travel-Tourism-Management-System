<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Announcement_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Announcement_edit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimeSelect = New System.Windows.Forms.DateTimePicker()
        Me.WriteText = New System.Windows.Forms.TextBox()
        Me.Upload = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ADDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SingleRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WholeDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionCheck = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DatabaseShow = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun-ExtB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(11, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "   Manage all the Announcements Here :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label3.Location = New System.Drawing.Point(12, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 76)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Write Your Text Here :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DATE OF THE POST :"
        '
        'DateTimeSelect
        '
        Me.DateTimeSelect.Location = New System.Drawing.Point(277, 343)
        Me.DateTimeSelect.Name = "DateTimeSelect"
        Me.DateTimeSelect.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeSelect.TabIndex = 7
        '
        'WriteText
        '
        Me.WriteText.Location = New System.Drawing.Point(186, 95)
        Me.WriteText.Multiline = True
        Me.WriteText.Name = "WriteText"
        Me.WriteText.Size = New System.Drawing.Size(589, 215)
        Me.WriteText.TabIndex = 9
        '
        'Upload
        '
        Me.Upload.Enabled = False
        Me.Upload.Image = CType(resources.GetObject("Upload.Image"), System.Drawing.Image)
        Me.Upload.Location = New System.Drawing.Point(803, 410)
        Me.Upload.Name = "Upload"
        Me.Upload.Size = New System.Drawing.Size(72, 57)
        Me.Upload.TabIndex = 10
        Me.Upload.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.VIEWToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(967, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ADDToolStripMenuItem
        '
        Me.ADDToolStripMenuItem.Name = "ADDToolStripMenuItem"
        Me.ADDToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.ADDToolStripMenuItem.Text = "ADD"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'UPDATEToolStripMenuItem
        '
        Me.UPDATEToolStripMenuItem.Name = "UPDATEToolStripMenuItem"
        Me.UPDATEToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.UPDATEToolStripMenuItem.Text = "UPDATE"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SingleRecordToolStripMenuItem, Me.WholeDatabaseToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'SingleRecordToolStripMenuItem
        '
        Me.SingleRecordToolStripMenuItem.Name = "SingleRecordToolStripMenuItem"
        Me.SingleRecordToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SingleRecordToolStripMenuItem.Text = "Single Record"
        '
        'WholeDatabaseToolStripMenuItem
        '
        Me.WholeDatabaseToolStripMenuItem.Name = "WholeDatabaseToolStripMenuItem"
        Me.WholeDatabaseToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.WholeDatabaseToolStripMenuItem.Text = "Whole Database"
        '
        'ConnectionCheck
        '
        Me.ConnectionCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConnectionCheck.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectionCheck.Image = CType(resources.GetObject("ConnectionCheck.Image"), System.Drawing.Image)
        Me.ConnectionCheck.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConnectionCheck.Location = New System.Drawing.Point(16, 419)
        Me.ConnectionCheck.Name = "ConnectionCheck"
        Me.ConnectionCheck.Size = New System.Drawing.Size(157, 60)
        Me.ConnectionCheck.TabIndex = 12
        Me.ConnectionCheck.Text = "Check Conncectivity"
        Me.ConnectionCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ConnectionCheck.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(901, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 29)
        Me.Button4.TabIndex = 49
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DatabaseShow
        '
        Me.DatabaseShow.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatabaseShow.Image = CType(resources.GetObject("DatabaseShow.Image"), System.Drawing.Image)
        Me.DatabaseShow.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DatabaseShow.Location = New System.Drawing.Point(208, 419)
        Me.DatabaseShow.Name = "DatabaseShow"
        Me.DatabaseShow.Size = New System.Drawing.Size(131, 60)
        Me.DatabaseShow.TabIndex = 50
        Me.DatabaseShow.Text = "Show Database"
        Me.DatabaseShow.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DatabaseShow.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Enabled = False
        Me.Update.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Update.Image = CType(resources.GetObject("Update.Image"), System.Drawing.Image)
        Me.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Update.Location = New System.Drawing.Point(661, 421)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(86, 35)
        Me.Update.TabIndex = 51
        Me.Update.Text = "Update"
        Me.Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Update.UseVisualStyleBackColor = True
        '
        'Announcement_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 491)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.DatabaseShow)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ConnectionCheck)
        Me.Controls.Add(Me.Upload)
        Me.Controls.Add(Me.WriteText)
        Me.Controls.Add(Me.DateTimeSelect)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Announcement_edit"
        Me.Text = "Announcement_Edit"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimeSelect As DateTimePicker
    Friend WithEvents WriteText As TextBox
    Friend WithEvents Upload As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ADDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SingleRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WholeDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectionCheck As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DatabaseShow As Button
    Friend WithEvents Update As Button
End Class
