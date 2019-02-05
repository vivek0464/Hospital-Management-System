Imports System.Data.OleDb

Public Class Form1
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\RHYTHM\Documents\Staff.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Insert into Staff([Name],[Designation],[Date of Birth],[Gender],[Mobile],[Address],[Password]) Values(?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Name", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Designation", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date of Birth", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Mobile", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(TextBox7.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub
End Class
