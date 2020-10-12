Imports System.IO
Imports System.Data
Imports System.Data.OleDb

Public Class ImageUpload
    ReadOnly dbImg(9) As String
    Dim last_id As Integer
    ReadOnly Dest(9) As String
    ReadOnly Source(9) As String
    Private ReadOnly con As New OleDbConnection
    Dim rs As New Resizer
    Dim dbProvider As String
    Dim dbSource As String
    Dim MyFolder As String
    Dim TheDatabase As String
    Dim FullDataBasePath As String


    Private Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click

        'Copy file from Source to Destination
        CopyImageToDestination()

        'Store ImgName To Database Accurate Position
        StoreNameToDB()

    End Sub

    Private Sub CopyImageToDestination()
        For i = 0 To 9
            If Source(i) IsNot Nothing Then
                My.Computer.FileSystem.CopyFile(
            Source(i), Dest(i), Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
             Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

            End If
        Next
    End Sub
    Private Sub StoreNameToDB()
        '//Store ImgName To Database Accurate Position
        Dim query As String
        Dim Row, last_row_index As Integer
        query = "SELECT * FROM PackagesInfo" 'Whole PackagesInfo selected
        Dim da As New OleDbDataAdapter(query, con) 'DataAdapter for fetching database with selected query
        Dim ds As New DataSet
        con.Open()
        da.Fill(ds, "PackagesInfo")              'Dataset filled with database PackagesInfo by dataadapter reference as DBPackagesInfo
        con.Close()
        Row = ds.Tables(0).Rows.Count        ' No. of rows in the loaded table
        last_row_index = Row - 1

        'Column wise new name store to dataset's table
        For i = 0 To 9
            ds.Tables(0).Rows(last_row_index)(i + 6) = dbImg(i)
        Next
        da.UpdateCommand = New OleDbCommandBuilder(da).GetUpdateCommand()   'Auto Generates sql query as per needs
        da.Update(ds, "PackagesInfo")
        MessageBox.Show("Images Uploaded Successfully", "Success", MessageBoxButtons.OK)
        Me.Close()
        Package_manage.Show()
    End Sub

    Private Function GetLastID() As Integer
        Dim query As String
        Dim row, last_row_index As Integer

        query = "SELECT PackageID FROM PackagesInfo"            'Only ID coloumn of PackagesInfo selected
        Dim da As New OleDbDataAdapter(query, con) 'dataadapter for fetching database with selected query
        Dim ds As New DataSet
        ConOpen()
        da.Fill(ds, "PackageID")                   'Dataset filled with database PackagesInfo by dataadapter, refrenced as PackageID 
        con.Close()
        row = ds.Tables(0).Rows.Count              ' No. of rows in the loaded table
        last_row_index = row - 1                   'Index of the last row
        last_id = Convert.ToInt32(ds.Tables(0).Rows(last_row_index)(0).ToString()) 'fetching last inserted PackageID
        Return last_id

    End Function

    Private Sub ConOpen()

        'Make it path independent

        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        TheDatabase = "/PackagesInfo.accdb"
        MyFolder = Directory.GetCurrentDirectory
        FullDataBasePath = MyFolder & TheDatabase
        dbSource = "Data Source=" & FullDataBasePath
        con.ConnectionString = dbProvider & dbSource & ";Jet OLEDB:Database Password=0123456789"

    End Sub

    Private Sub ImageUpload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub

    Private Sub BtnImg1_Click(sender As Object, e As EventArgs) Handles btnImg1.Click
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"  'png +

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

            'Getting Source & Destination and NewImgName
            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source(0) = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
            'SourceFileName = System.IO.Path.GetFileName(Source1)            'Don't erase this command cz of future need
            'MessageBox.Show(SourceFileName)                                 'Don't erase this command cz of future need
            GetLastID()
            'MsgBox(last_id)
            dbImg(0) = last_id.ToString() & ".1.jpg"                 'last_id as string
            Dest(0) = CurrentDirectory + "\Images\" + dbImg(0)      'destination for 1st Image with new name assign
        End If

    End Sub

    Private Sub BtnImg2_Click(sender As Object, e As EventArgs) Handles btnImg2.Click

        OpenFileDialog2.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"
        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog2.FileName)

            'Getting Source & Destination and NewImgName
            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source(1) = System.IO.Path.GetFullPath(OpenFileDialog2.FileName)
            GetLastID()
            dbImg(1) = last_id.ToString() & ".2.jpg"                 'last_id as string
            Dest(1) = CurrentDirectory + "\Images\" + dbImg(1)      'destination for 2nd Image with new name assign
        End If

    End Sub

    Private Sub BtnImg3_Click(sender As Object, e As EventArgs) Handles btnImg3.Click
        OpenFileDialog3.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog3.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox3.Image = Image.FromFile(OpenFileDialog3.FileName)

            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source(2) = System.IO.Path.GetFullPath(OpenFileDialog3.FileName)
            GetLastID()
            dbImg(2) = last_id.ToString() & ".3.jpg"                 'last_id as string
            Dest(2) = CurrentDirectory + "\Images\" + dbImg(2)

        End If
    End Sub

    Private Sub BtnImg4_Click(sender As Object, e As EventArgs) Handles btnImg4.Click
        OpenFileDialog2.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog4.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox4.Image = Image.FromFile(OpenFileDialog4.FileName)

            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source(3) = System.IO.Path.GetFullPath(OpenFileDialog4.FileName)
            GetLastID()
            dbImg(3) = last_id.ToString() & ".4.jpg"                 'last_id as string
            Dest(3) = CurrentDirectory + "\Images\" + dbImg(3)
        End If
    End Sub

    Private Sub BtnImg5_Click(sender As Object, e As EventArgs) Handles btnImg5.Click
        OpenFileDialog5.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog5.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox5.Image = Image.FromFile(OpenFileDialog5.FileName)

            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source(4) = System.IO.Path.GetFullPath(OpenFileDialog5.FileName)
            GetLastID()
            dbImg(4) = last_id.ToString() & ".5.jpg"                 'last_id as string
            Dest(4) = CurrentDirectory + "\Images\" + dbImg(4)
        End If
    End Sub

    Private Sub BtnImg6_Click(sender As Object, e As EventArgs) Handles btnImg6.Click
        OpenFileDialog6.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog6.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox6.Image = Image.FromFile(OpenFileDialog6.FileName)

            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source(5) = System.IO.Path.GetFullPath(OpenFileDialog6.FileName)
            GetLastID()
            dbImg(5) = last_id.ToString() & ".6.jpg"                 'last_id as string
            Dest(5) = CurrentDirectory + "\Images\" + dbImg(5)

        End If
    End Sub

    Private Sub BtnImg7_Click(sender As Object, e As EventArgs) Handles btnImg7.Click
        OpenFileDialog7.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog7.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox7.Image = Image.FromFile(OpenFileDialog7.FileName)

            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source(6) = System.IO.Path.GetFullPath(OpenFileDialog7.FileName)
            GetLastID()
            dbImg(6) = last_id.ToString() & ".7.jpg"                 'last_id as string
            Dest(6) = CurrentDirectory + "\Images\" + dbImg(6)

        End If
    End Sub

    Private Sub BtnImg8_Click(sender As Object, e As EventArgs) Handles btnImg8.Click
        OpenFileDialog8.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog8.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox8.Image = Image.FromFile(OpenFileDialog8.FileName)

            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source(7) = System.IO.Path.GetFullPath(OpenFileDialog8.FileName)
            GetLastID()
            dbImg(7) = last_id.ToString() & ".8.jpg"                 'last_id as string
            Dest(7) = CurrentDirectory + "\Images\" + dbImg(7)

        End If
    End Sub

    Private Sub BtnImg9_Click(sender As Object, e As EventArgs) Handles btnImg9.Click
        OpenFileDialog9.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog9.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox9.Image = Image.FromFile(OpenFileDialog9.FileName)

            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source(8) = System.IO.Path.GetFullPath(OpenFileDialog9.FileName)
            GetLastID()
            dbImg(8) = last_id.ToString() & ".9.jpg"                 'last_id as string
            Dest(8) = CurrentDirectory + "\Images\" + dbImg(8)
        End If
    End Sub

    Private Sub BtnImg10_Click(sender As Object, e As EventArgs) Handles btnImg10.Click
        OpenFileDialog10.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog10.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox10.Image = Image.FromFile(OpenFileDialog10.FileName)

            Dim CurrentDirectory As String
            CurrentDirectory = Directory.GetCurrentDirectory
            Source(9) = System.IO.Path.GetFullPath(OpenFileDialog10.FileName)
            GetLastID()
            dbImg(9) = last_id.ToString() & ".10.jpg"                 'last_id as string
            Dest(9) = CurrentDirectory + "\Images\" + dbImg(9)
        End If
    End Sub

    Private Sub ImageUpload_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub ImageUpload_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Package_manage.Show()
        Me.Dispose()
    End Sub

End Class