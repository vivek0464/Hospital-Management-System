Imports System.Data.OleDb
Public Class BloodAvailability
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub BloodAvailability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        'Select Default Options from DropDown box
        BloodGrpTxt.SelectedIndex = 0
        AmountLbl.Text = "litres"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        SearchResultGrid.Visible = False
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
            query = "Select [Quantity] From [Blood_available] Where [Blood Group] Like '%" & BloodGrpTxt.Text & "%';"
            'Create New DataTable
            dt = New DataTable()
            'Open the connection
            myconnection.Open()
            Try
                cmd = New OleDbCommand(query, myconnection)
                reader = cmd.ExecuteReader()
                While reader.Read
                    AmountLbl.Text = reader(0) + " litres"
                End While
                'Close the connection
                myconnection.Close()
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
            query = "Select * From [Donor] Where [Blood] Like '%" & BloodGrpTxt.Text & "%';"
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
End Class


