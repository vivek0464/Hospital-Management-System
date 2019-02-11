Imports System.Data.OleDb
Public Class Form1
    'Global Variables
    Public provider As String
    Public datafile As String
    Public username As String
    Public Current_tokenNo As Integer
    Public Current_RoomNo As Integer
    'Local Variables
    Dim login_type As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\projects\Hospital_Management_System\Database.accdb"
        myconnection.ConnectionString = provider & datafile
        login_type = ""
        username = ""
    End Sub
    'Login button
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim query As String
        myconnection.Open()
        'MessageBox.Show("Connected")
        Try
            query = "Select * From [Login] Where [Username] = '" & UsernameTxt.Text & "'"
            Dim cmd As New OleDbCommand
            Dim reader As OleDbDataReader
            cmd = New OleDbCommand(query, myconnection)
            reader = cmd.ExecuteReader()
            If reader.HasRows And Not login_type = "" Then
                Dim check_user As Integer = 0
                While reader.Read
                    If PasswordTxt.Text() = reader(1).ToString And login_type = reader(3).ToString Then
                        check_user = 1
                        Exit While
                    End If
                End While
                If check_user = 1 Then
                    username = UsernameTxt.Text().ToString
                    UsernameTxt.Clear()
                    PasswordTxt.Clear()
                    AdminRadioBtn.Checked = False
                    StaffRadioBtn.Checked = False
                    Me.Hide()
                    If ShowPasswd.Checked Then
                        ShowPasswd.Checked = False
                        PasswordTxt.UseSystemPasswordChar = True
                    End If
                    If login_type = "Admin" Then
                        Form3.Show()
                    Else
                        Form2.Show()
                    End If
                Else
                    MessageBox.Show("Incorrect Credentials")
                End If
            Else
                MessageBox.Show("Incorrect Credentials")
            End If
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            myconnection.Close()
            MessageBox.Show("Incorrect Credentials")
        End Try
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
    'Show Password checkbox
    Private Sub ShowPasswd_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswd.CheckedChanged
        If PasswordTxt.UseSystemPasswordChar = True Then
            PasswordTxt.UseSystemPasswordChar = False
        Else
            PasswordTxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub AdminRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles AdminRadioBtn.CheckedChanged
        login_type = "Admin"
    End Sub

    Private Sub StaffRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles StaffRadioBtn.CheckedChanged
        login_type = "Staff"
    End Sub
    'Validates if the name is a valid name or not
    Public Function Name_Validation(ByVal name As String) As Boolean
        Try
            If name.ToUpper = name.ToLower Then
                Return False
            End If
            Dim flag As Integer = 0
            Dim i As Integer = 0
            For i = 0 To name.Length - 1
                If flag = 0 Then
                    If Not (name(i) >= "a"c And name(i) <= "z"c) And Not (name(i) = "."c Or name(i) = " "c) Then
                        Return False
                    ElseIf name(i) = "."c Then
                        flag = 1
                    ElseIf name(i) = " "c Then
                        flag = 2
                    End If
                ElseIf flag = 1 Then
                    If Not (name(i) >= "a"c And name(i) <= "z"c) And Not name(i) = " "c Then
                        Return False
                    ElseIf name(i) >= "a"c And name(i) <= "z"c Then
                        flag = 0
                    ElseIf name(i) = " "c Then
                        flag = 2
                    End If
                Else
                    If Not (name(i) >= "a" And name(i) <= "z"c) Then
                        Return False
                    Else
                        flag = 0
                    End If
                End If
            Next

            Return True
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    'Validates the age (max age limit is kept 150)
    Public Function age_validator(ByVal age As String) As Boolean
        Try
            Dim i As Integer = 0
            If age.Length > 3 Or age.Length = 0 Then
                Return False
            End If
            If Not age.ToUpper = age.ToLower Then
                Return False
            End If
            For i = 0 To age.Length - 1
                If Not (age(i) >= "0"c And age(i) <= "9"c) Then
                    Return False
                End If
            Next

            Dim age_int As Integer = Convert.ToInt16(age)
            If age_int > 150 Then
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    'Validates the gender field 
    Public Function Gender_Validator(ByVal gender As String) As Boolean
        If gender = "male" Or gender = "female" Or gender = "others" Then
            Return True
        End If
        Return False
    End Function
    'Validates the mobile number field (the mobile number must conatin 10 numeric digits)
    Public Function Mobile_Validator(ByVal mobile As String) As Boolean
        Try
            Dim i As Integer = 0
            If Not mobile.Length = 10 Then
                Return False
            End If
            For i = 0 To 9
                If Not (mobile(i) >= "0"c And mobile(i) <= "9"c) Then
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
End Class
