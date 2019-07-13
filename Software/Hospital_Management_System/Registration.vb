Imports System.Data.OleDb
Public Class Registration
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DOBTxt.MaxDate = Date.Now()
    End Sub
    'Clears All the Textbox in the registration form
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        NameTxt.Clear()
        DOBTxt.Value = Format(Date.Now(), "dd-MM-yyyy")
        GenderTxt.SelectedIndex = -1
        MobileTxt.Clear()
        AddressTxt.Clear()
        SuccessMsg.Visible = False
    End Sub
    'Prevents Highlighting of Text selected from dropdown list in gender combobox
    Private Sub GenderTxt_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles GenderTxt.SelectionChangeCommitted
        MobileTxt.Focus()
    End Sub
    'Registers New Patient to the Patient Database
    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Dim myconnection As OleDbConnection = New OleDbConnection
        Dim cmd As OleDbCommand
        'Connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        If Not Validate_data() Then
            Exit Sub
        End If
        'Store the the DOB as datetime format
        Dim var_date As DateTime = Format(DOBTxt.Value, "dd-MM-yyyy")
        'MessageBox.Show(var_date)
        myconnection.Open()
        'MessageBox.Show("Connected")
        Dim query As String
        'Insert into database 
        query = "Insert Into [Patient] (Name,DOB,Gender,Mobile,Address) Values (?,?,?,?,?)"
        cmd = New OleDbCommand(query, myconnection)
        Try
            'Specify the parameters and corresponding values
            cmd.Parameters.Add(New OleDbParameter("Name", CType(NameTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("DOB", CType(var_date, String)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(GenderTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("Mobile", CType(MobileTxt.Text.ToString, String)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(AddressTxt.Text.ToString, String)))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Close the Connection
            myconnection.Close()
            'Display Success Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Patient Successfully Registered !!"
            SuccessMsg.BackColor = Color.Green
            'Start timer
            Timer1.Start()
        Catch ex As Exception
            'Close the connection
            myconnection.Close()
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Credentials"
            MessageBox.Show(ex.Message)
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
        End Try

    End Sub
    'Makes the Success/Failure Msg Unvisible on the clock tick and stops timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SuccessMsg.Visible = False
        Timer1.Stop()
    End Sub
    'Validates the data entered in the form
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
        If AddressTxt.Text = "" Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Enter Address"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        Return True
    End Function
End Class
