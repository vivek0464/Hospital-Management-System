Imports System.Data.OleDb
Public Class EditProfile
    Dim myconnection As OleDbConnection = New OleDbConnection
    'Variable declaration
    Dim password As String  'Stores current password
    Dim primary_key As String  'stores SID for the staff member
    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        Dim query As String
        Dim reader As OleDbDataReader
        Dim cmd As New OleDbCommand
        'Select from database query statement
        query = "Select * From [Staff] Where [Username] = '" & Form1.username & "';"
        'Open Connection
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)
            reader = cmd.ExecuteReader()
            While reader.Read
                'Set the values in the textBox
                SIDTxt.Text = reader(0)
                NameTxt.Text = reader(1)
                DOBTxt.Text = reader(3)
                GenderTxt.Text = reader(4)
                MobileTxt.Text = reader(5)
                AddressTxt.Text = reader(6)
                'Store the primary key and password for the corresponding staff member
                primary_key = reader(0)
                password = reader(9)
            End While
            myconnection.Close()
        Catch ex As Exception
            myconnection.Close()
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        'Data Validity Check before updating
        If Not Form1.Mobile_Validator(MobileTxt.Text.ToLower) Or AddressTxt.Text = "" Then
            MessageBox.Show("Incorrect Credentials")
            Exit Sub
        End If
        Dim cmd As New OleDbCommand
        Dim query As String
        'Update query statement
        query = "Update [Staff] Set [Mobile] = '" & MobileTxt.Text & "', [Address] = '" & AddressTxt.Text & "' Where [SID] = " & primary_key & ";"
        'Open Connection
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            MessageBox.Show("Successfully Updated Details")
        Catch ex As Exception
            myconnection.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Change Password Button
    Private Sub ChangePasswdBtn_Click(sender As Object, e As EventArgs) Handles ChangePasswdBtn.Click
        'Check if old password is entered correctly
        If Not OldPasswdTxt.Text = password Then
            MessageBox.Show("Invalid Old Password")
            Exit Sub
        End If
        'Check if New password is not a empty string
        If NewPasswdTxt.Text = "" Then
            MessageBox.Show("Password cannot be empty field")
            Exit Sub
        End If
        Dim cmd As New OleDbCommand
        Dim query As String
        'Update query statement
        query = "Update [Staff] Set [Password] = '" & NewPasswdTxt.Text & "' Where [SID] = " & primary_key & ";"
        'Open Connection
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'close Connection
            myconnection.Close()
            'Update password string to new password
            password = NewPasswdTxt.Text
            OldPasswdTxt.Clear()
            NewPasswdTxt.Clear()
            MessageBox.Show("Successfully Updated Password")
        Catch ex As Exception
            'Close Connection
            myconnection.Close()
        End Try
    End Sub
    'Show Password Check box
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'If password is hidden , Show password
        If OldPasswdTxt.UseSystemPasswordChar = True Then
            OldPasswdTxt.UseSystemPasswordChar = False
            NewPasswdTxt.UseSystemPasswordChar = False
        Else 'else hide password
            OldPasswdTxt.UseSystemPasswordChar = True
            NewPasswdTxt.UseSystemPasswordChar = True
        End If
    End Sub
End Class
