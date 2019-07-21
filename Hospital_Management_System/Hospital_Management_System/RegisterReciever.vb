Imports System.Data.OleDb
Public Class RegisterReciever
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub RegisterReciever_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        'Set the Recieptant Date As present date
        DateTxt.Text = Date.Today.ToShortDateString
        'Select default option from dropdown box
        BloodGrpCombo.SelectedIndex = 0
    End Sub
    Private Sub AddReceiptantBtn_Click(sender As Object, e As EventArgs) Handles AddReceiptantBtn.Click
        If Not Validate_data() Then
            Exit Sub
        End If
        Dim cmd As OleDbCommand
        Dim query As String
        'Insert into database query string
        query = "Insert Into [Recievers] ([Name],[Age],[Gender],[Blood Group],[Contact Number],[Blood Recieved],[Date of Recieve]) Values (?,?,?,?,?,?,?)"

        myconnection.Open()
        'MessageBox.Show("Connected")
        Try
            cmd = New OleDbCommand(query, myconnection)
            'Specify the parameters and corresponding values
            cmd.Parameters.Add(New OleDbParameter("Name", CType(NameTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("Age", CType(Convert.ToInt16(AgeTxt.Text), Integer)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(GenderTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("Blood Group", CType(BloodGrpCombo.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Contact Number", CType(MobileTxt.Text.ToString, String)))
            cmd.Parameters.Add(New OleDbParameter("Blood Recieved", CType(QuantityTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Date of Recieve", CType(DateTxt.Text, String)))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Close the Connection
            myconnection.Close()
            'Display Success Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Reciever Successfully Registered !!"
            SuccessMsg.BackColor = Color.Green
            'Start timer
            Timer1.Start()

        Catch ex As Exception
            'Close the connection
            myconnection.Close()
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Credentials"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
        End Try
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
        If Not Form1.age_validator(AgeTxt.Text) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Age"
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
        If BloodGrpCombo.SelectedIndex = 0 Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Select Proper Blood Group"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If Not Form1.Decimal_Validator(QuantityTxt.Text) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Quantity"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        Return True
    End Function

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'Clear All textbox
        NameTxt.Clear()
        AgeTxt.Clear()
        DateTxt.Text = Format(Date.Now(), "dd-MM-yyyy")
        QuantityTxt.Clear()
        MobileTxt.Clear()
        'Set all dropdown combobox to default options
        GenderTxt.SelectedIndex = -1
        BloodGrpCombo.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SuccessMsg.Visible = False
        Timer1.Stop()
    End Sub
End Class
