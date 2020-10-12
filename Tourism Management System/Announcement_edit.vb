Imports System.IO
Imports System.Data.OleDb

Public Class Announcement_edit

    Dim con As New OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim MyFolder As String
    Dim TheDatabase As String
    Dim FullDataBasePath As String
    Dim rs As New Resizer
    Dim Choice As String
    Dim sql As String

    Private Sub Announcement_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        TheDatabase = "/Announcement.accdb"
        MyFolder = Directory.GetCurrentDirectory
        FullDataBasePath = MyFolder & TheDatabase
        dbSource = "Data Source=" & FullDataBasePath
        con.ConnectionString = dbProvider & dbSource & ";Jet OLEDB:Database Password=0123456789"
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub ADDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem.Click
        WriteText.Clear()
        DateTimeSelect.ResetText()
        MessageBox.Show("Enter the Announcement and set date and the click on the upload button.", "Add Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Upload.Enabled = True
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click

        delete()
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click
        WriteText.Clear()
        DateTimeSelect.ResetText()
        MessageBox.Show("Enter the ID of the Announcement you want to Edit, then edit the details and press Update button .", "Update Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Show()
        Update.Enabled = True

    End Sub

    Private Sub SingleRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SingleRecordToolStripMenuItem.Click
        MessageBox.Show("Enter the ID of the Announcement you want to View and press Enter.", "View Single Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Show()
    End Sub

    Private Sub WholeDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WholeDatabaseToolStripMenuItem.Click
        Me.Hide()
        Announcement_view.Show()
    End Sub

    Private Sub ConnectionCheck_Click(sender As Object, e As EventArgs) Handles ConnectionCheck.Click
        'check the database connectivity
        con.Open()
        If con.State = ConnectionState.Open Then 'check if the database connection is active
            MessageBox.Show("Database is now active.We are now Closing it...", "Active", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()
        If con.State = ConnectionState.Closed Then
            MessageBox.Show("Database is now closed.", "Close", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Admin_Dashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub Upload_Click(sender As Object, e As EventArgs) Handles Upload.Click
        Dim ds As New DataSet
        Dim Sql As String

        Try
                    con.Open()                                      'Opening Connection
                Catch ex As Exception                               'Providing Error Message
                    MessageBox.Show("Uable to Connect", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End                                             'Closing Application
                End Try
                Sql = "SELECT * FROM Announcement"
                Dim da = New OleDbDataAdapter(Sql, con)
                da.Fill(ds, "Announcement")
        Dim cb As New OleDbCommandBuilder(da)
        Try
            Sql = "INSERT INTO Announcement([AnnouncementDate],[Description]) VALUES (?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(Sql, con)
            cmd.Parameters.Add(New OleDbParameter("AnnouncementDate", CType(DateTimeSelect.Text, Date)))
            cmd.Parameters.Add(New OleDbParameter("Description", CType(WriteText.Text, String)))
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
            da.Update(ds, "Announcement")
            MessageBox.Show("The record has been added/updated successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Upload.Enabled = False
    End Sub
    Private Function date_format(ByVal dte As Date) As String
        Dim format_date As String
        format_date = "#" + dte.Month.ToString + "/" + dte.Day.ToString + "/" + dte.Year.ToString + "#"
        Return format_date
    End Function

    Private Sub delete()
        MessageBox.Show("Enter the ID of the Announcement you want to delete and press Enter.", "Delete Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Try
            con.Open()                                      'Opening Connection
        Catch ex As Exception                               'Providing Error Message
            MessageBox.Show("Uable to Connect", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End                                             'Closing Application
        End Try
        Try


Label:
            Choice = InputBox("Enter AnnouncementID to be deleted : ", "Input Number",,,)
            If MessageBox.Show("Do you really want to Delete this Record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                If MessageBox.Show("Deletion operation has been terminated suddenly...", "Aborted", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                    GoTo Label
                Else
                    MsgBox("Thank You")
                    Exit Sub
                End If
            Else
                If String.IsNullOrEmpty(Choice) Then Exit Sub
                sql = "DELETE * FROM Announcement WHERE ((Announcement.AnnouncementID)=" + Choice + ");"
                Dim command As OleDbCommand = New OleDbCommand(sql, con)
                Dim success As Integer = command.ExecuteNonQuery()
                If success <> 0 Then
                    MessageBox.Show("Deletion operation has been terminated with success...", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Else
                    MsgBox("AnnouncementID Not Found !")
                End If

                MsgBox("Thank you")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Show()

        Dim ds As New DataSet
        choice = InputBox("Enter AnnouncementID to be Shown", "Input Number",,,)
        If String.IsNullOrEmpty(choice) Then Exit Sub
        Try

            sql = "SELECT * From Announcement WHERE (((Announcement.AnnouncementID)=" + Choice + "));"

            Dim da = New OleDbDataAdapter(sql, con)
            Dim cb As New OleDbCommandBuilder(da)
            da.Fill(ds, "Announcement")

            WriteText.Text = ds.Tables("Announcement").Rows(0).Item(2)
            DateTimeSelect.Text = ds.Tables("Announcement").Rows(0).Item(1)
        Catch ex As Exception
            MsgBox("The records cann't be shown")
        End Try

    End Sub

    Private Sub DatabaseShow_Click(sender As Object, e As EventArgs) Handles DatabaseShow.Click
        Announcement_view.Show()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        If String.IsNullOrEmpty(Choice) Then Exit Sub
        Try
            con.Open()
            sql = "UPDATE Announcement SET  Announcement.AnnouncementDate = " + date_format(CType(DateTimeSelect.Text, Date)) + ", Announcement.[Description] = """ + WriteText.Text + """ WHERE ((Announcement.AnnouncementID)=" + Choice + ");"
            Dim command As OleDbCommand = New OleDbCommand(sql, con)
            Dim success As Integer = command.ExecuteNonQuery()
            If success <> 0 Then
                MessageBox.Show("Data has been updated Successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("ID Not Found !")
            End If
        Catch ex As Exception
            MessageBox.Show("Uable to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
        Update.Enabled = False
    End Sub
    Private Sub Announcement_edit_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Admin_Dashboard.Show()
        Me.Dispose()
    End Sub

    Private Sub Announcement_edit_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class