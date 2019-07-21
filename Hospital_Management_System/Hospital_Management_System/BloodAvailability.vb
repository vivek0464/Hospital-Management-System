Imports System.Data.OleDb
Public Class BloodAvailability
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim blood_group As String
    Private Sub BloodAvailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        'Select Default Options from DropDown box
        BloodGrpTxt.SelectedIndex = 0
        AmountLbl.Text = "Amount :"
        AmountLbl.Visible = False
        ValueLbl.Visible = False
        DonorListBtn.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        SearchResultGrid.Visible = False
        AmountLbl.Visible = False
        ValueLbl.Visible = False
        DonorListBtn.Visible = False
        UpdateBtn.Visible = False
        If BloodGrpTxt.SelectedIndex = 0 Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Select Blood Group"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()

        Else
            Dim cmd As New OleDbCommand
            Dim reader As OleDbDataReader
            Dim dt As DataTable
            Dim query As String
            'query statement
            query = "Select * From [Blood_available] Where [Blood Group] Like '%" & BloodGrpTxt.Text & "%';"
            'Create New DataTable
            dt = New DataTable()
            'Open the connection
            myconnection.Open()
            Try
                cmd = New OleDbCommand(query, myconnection)
                reader = cmd.ExecuteReader()
                While reader.Read
                    Form1.blood_available_id = reader(0)
                    ValueLbl.Text = reader(2) + " litres"
                End While
                'Close the connection
                myconnection.Close()
                'Color the label according to availability
                Dim Amount As Decimal = Convert.ToDecimal(ValueLbl.Text.Split(" "c)(0))
                Form1.cur_blood_amount = Amount
                If Amount = 0 Then
                    ValueLbl.BackColor = Color.Red
                Else
                    ValueLbl.BackColor = Color.Green
                End If
                AmountLbl.Visible = True
                ValueLbl.Visible = True
                DonorListBtn.Visible = True
                If Form1.login_type.ToLower = "admin" Then
                    UpdateBtn.Visible = True
                End If
                blood_group = BloodGrpTxt.Text
            Catch ex As Exception
                myconnection.Close()
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DonorListBtn.Click
        If BloodGrpTxt.SelectedIndex = 0 Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Select Blood Group"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
        Else
            Dim cmd As New OleDbCommand
            Dim adapter As OleDbDataAdapter
            Dim dt As DataTable
            Dim query As String
            'query statement
            query = "Select * From [Donor] Where [Blood] Like '%" & blood_group & "%';"
            'Create New DataTable
            dt = New DataTable()
            'Open the connection
            myconnection.Open()
            Try
                adapter = New OleDbDataAdapter(query, myconnection)
                adapter.Fill(dt)
                SearchResultGrid.DataSource = dt
                'If SearchResultGrid Contains only header column, No data entry was found
                If SearchResultGrid.RowCount = 1 Then
                    MessageBox.Show("No Result Found")
                    myconnection.Close()
                    Exit Sub
                End If
                'Hide irrelevant coulumns from the datagrid
                HideUnusedColumns()
                'Show the dataGrid
                SearchResultGrid.Visible = True
                'Close the connection
                myconnection.Close()
            Catch ex As Exception
                myconnection.Close()
            End Try
        End If
    End Sub

    Private Function HideUnusedColumns() As Boolean
        'hide Unused columns on the datagrid
        Dim i As Integer
        For i = 3 To 8
            SearchResultGrid.Columns(i).Visible = False
        Next
        SearchResultGrid.Columns(5).Visible = True
        Return True
    End Function

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Form4.Show()
        AmountLbl.Visible = False
        ValueLbl.Visible = False
        UpdateBtn.Visible = False
        SearchResultGrid.Visible = False
        DonorListBtn.Visible = False
    End Sub
End Class


