Imports System.Data.OleDb
Public Class Form1

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\ANUBHAV TYAGI\Desktop\Hospital-Management-System\Database\Staff.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myConnection.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter()
        da = New OleDbDataAdapter()
        Dim str As String
        str = "Select * from [Staff] where  [Mobile]  ='" & TextBox8.Text & "'"
        Dim reader As OleDbDataReader
        Dim cmd As OleDbCommand
        'da = New OleDbDataAdapter("Select * from Table1 where Mobile like '%" & txtASMobile.Text & "%'", myconnection)

        cmd = New OleDbCommand(str, myConnection)
        reader = cmd.ExecuteReader()

        While reader.Read
            TextBox9.Text = reader(0)
            TextBox1.Text = reader(1)
            TextBox2.Text = reader(2)
            TextBox3.Text = reader(3)
            TextBox4.Text = reader(4)
            TextBox5.Text = reader(5)
            TextBox6.Text = reader(6)
            TextBox7.Text = reader(7)

        End While
        myConnection.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConnection.Open()
        Dim str As String
        'str = "Update [Staff] set [Name]= ' " & TextBox1.Text & " 'where [SID] = " & TextBox9.Text & " "
        str = "Update [Staff] set [Name]= ' " & TextBox1.Text & " ',[Designation]= ' " & TextBox2.Text & " ',[Date Of Birth]= ' " & TextBox3.Text & " ',[Gender]= ' " & TextBox4.Text & " ',[Mobile]= ' " & TextBox5.Text & " ',[Address]= ' " & TextBox6.Text & " ',[Password]= ' " & TextBox7.Text & " 'where [SID] = " & TextBox9.Text & " "
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        myConnection.Close()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
End Class
