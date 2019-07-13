Imports System.Data.OleDb
Public Class Form4
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        If Not Form1.Decimal_Validator(TextBox1.Text) Then
            MessageBox.Show("Enter Valid Amount")
            Exit Sub
        End If
        Dim cmd As New OleDbCommand
        Dim query As String
        query = "Update [Blood_Available] Set Quantity = " & TextBox1.Text & " Where [ID] =" & Form1.blood_available_id & ";"
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            myconnection.Close()
            Form1.cur_blood_amount = TextBox1.Text
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error Updating database")
            myconnection.Close()
        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconnection.ConnectionString = Form1.provider + Form1.datafile
    End Sub
End Class