Imports System.Data.OleDb
Class RegisterDonor


    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub RegisterDonor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        'Select Default Options from DropDown box
        BloodGrpTxt.SelectedIndex = 0
        GenderTxt.SelectedIndex = -1
        DateTxt.Text = Date.Today.ToShortDateString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If Not Validate_data() Then
            Exit Sub
        End If
        'Variable Declarations
        Dim cmd As OleDbCommand
        Dim query As String
        'Insert into database query string
        query = "Insert Into [Donor] (Name,Gender,Age,Blood,Mobile,[Blood Amount],[Donation Date]) Values (?,?,?,?,?,?,?)"
        'Open Connection
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)
            'Specify the parameters and corresponding values
            cmd.Parameters.Add(New OleDbParameter("Name", CType(NameTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(GenderTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("Age", CType(Convert.ToInt16(AgeTxt.Text), Integer)))
            cmd.Parameters.Add(New OleDbParameter("Blood", CType(BloodGrpTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Mobile", CType(MobileTxt.Text.ToString, String)))
            cmd.Parameters.Add(New OleDbParameter("Blood Amount", CType(QuantityTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Donation Date", CType(DateTxt.Text.ToString, String)))


            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Close the Connection
            myconnection.Close()
            'Display Success Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Donor Successfully Registered !!"
            SuccessMsg.BackColor = Color.Green
            'Start timer
            Timer1.Start()
        Catch ex As Exception
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
        Dim temp As Integer
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

        ElseIf Integer.TryParse(AgeTxt.Text, temp) And (temp < 18 Or temp > 55) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Donor Not Eligible"
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
        If BloodGrpTxt.SelectedIndex = 0 Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Select Proper Blood Group"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If Not CheckBox1.Checked Or Not CheckBox2.Checked Or Not CheckBox3.Checked Or Not CheckBox4.Checked Or Not CheckBox5.Checked Or Not CheckBox6.Checked Or Not CheckBox7.Checked Or Not CheckBox8.Checked Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Donor Not Eligible."
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
            'Start Timer
            Timer1.Start()
            Return False
        End If
        Return True
    End Function

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        NameTxt.Clear()
        AgeTxt.Clear()
        GenderTxt.SelectedIndex = -1
        MobileTxt.Clear()
        BloodGrpTxt.SelectedIndex = 0

        'Clear All checkboxes
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SuccessMsg.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub GenderTxt_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles GenderTxt.SelectionChangeCommitted
        BloodGrpTxt.Focus()
    End Sub
End Class
