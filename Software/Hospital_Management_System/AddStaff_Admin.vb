Imports System.Data.OleDb
Imports System.Net.Mail
Public Class AddStaff_Admin
    Dim username As String
    Dim password As String
    Private Sub AddStaff_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DOBTxt.MaxDate = Format(Date.Now(), "dd-MM-yyyy")
    End Sub
    ' clear button to clear everthything
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        NameTxt.Clear()
        DOBTxt.Value = Format(Today(), "dd-MM-yyyy")
        GenderTxt.SelectedIndex = -1
        WorkShiftTxt.SelectedIndex = -1
        DesignationTxt.SelectedIndex = -1
        MobileTxt.Clear()
        EmailTxt.Clear()
        AddressTxt.Clear()
        SuccessMsg.Visible = False
    End Sub

    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Dim myconnection As OleDbConnection = New OleDbConnection
        Dim cmd As OleDbCommand
        'Connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        If Not Validate_data() Then
            Exit Sub
        End If
        username = NameTxt.Text.Split("."c)(0)
        username = username.Split(" "c)(0)
        password = Random_Password_Generator()
        Dim var_date As DateTime = Format(DOBTxt.Value, "dd-MM-yyyy")
        myconnection.Open()
        'MessageBox.Show("Connected")
        Dim query As String
        'Insert into database 
        query = "Insert Into [Staff] ([Name],[Designation],[Date Of Birth],[Gender],[Mobile],[Address],[Work Shift],[Username],[Password]) Values (?,?,?,?,?,?,?,?,?)"
        cmd = New OleDbCommand(query, myconnection)
        Try
            'Specify the parameters and corresponding values
            cmd.Parameters.Add(New OleDbParameter("Name", CType(NameTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("Designation", CType(DesignationTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("Date Of Birth", CType(var_date, String)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(GenderTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("Mobile", CType(MobileTxt.Text.ToString, String)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(AddressTxt.Text.ToString, String)))
            cmd.Parameters.Add(New OleDbParameter("Work Shift", CType(WorkShiftTxt.Text.ToString, String)))
            cmd.Parameters.Add(New OleDbParameter("Username", CType(username, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(password, String)))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Close the Connection
            myconnection.Close()
            Send_Mail()
            'Display Success Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Staff Successfully Registered !!"
            SuccessMsg.BackColor = Color.Green

            'Start timer
            Timer1.Start()
            ClearBtn_Click(sender, e)
            SuccessMsg.Visible = True

        Catch ex As Exception
            'Close the connection
            myconnection.Close()
            'MessageBox.Show(query)
            ' 'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Credentialsl"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
        End Try

    End Sub
    'Function Sends Email to staff member regarding his username and password
    Private Function Send_Mail() As Boolean
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("tyagianubhav619@gmail.com", "tyagi09101999")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("tyagianubhav619@gmail.com")
            e_mail.To.Add(EmailTxt.Text)
            e_mail.Subject = "Login Credential Details"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Your Username is : " & username & " and Password is : " & password & ". Remember your login credentials for future use"
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox("Cannot Send Mail. Network Not available")
        End Try
        Return True
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SuccessMsg.Visible = False
        Timer1.Stop()
    End Sub
    Private Function Validate_data() As Boolean
        If Not Form1.Name_Validation(NameTxt.Text.ToLower) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Name"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If GenderTxt.SelectedIndex = -1 Then
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Gender"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If Not Form1.Gender_Validator(GenderTxt.Text.ToLower) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Gender"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If Not Form1.Mobile_Validator(MobileTxt.Text) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Mobile Number"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If WorkShiftTxt.SelectedIndex = -1 Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Workshift Number"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If DesignationTxt.SelectedIndex = -1 Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Designation"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If AddressTxt.Text = "" Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Adress required "
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If EmailTxt.Text = "" Then
            'Display failiure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Email field is required"
            SuccessMsg.BackColor = Color.Red
            'Start Timer
            Timer1.Start()
        End If

        Return True
    End Function

    Private Function Random_Password_Generator() As String
        Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        Dim sb As String = ""
        Dim rand As New Random()
        For i As Integer = 1 To 10
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb += randomChar
        Next i
        Return sb
    End Function
End Class
