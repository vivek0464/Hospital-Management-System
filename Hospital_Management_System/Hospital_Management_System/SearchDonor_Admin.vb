Imports System.Data.OleDb
Public Class SearchDonor_Admin
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub SearchDonor_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        HideItemsOnForm()
    End Sub

    Private Function HideItemsOnForm() As Boolean
        'Hide Items On the form
        SearchResultGrid.Visible = False
        DonorInfoBox.Visible = False
        ClearBtn.Visible = False
        DeleteBtn.Visible = False
        UpdateBtn.Visible = False
        Return True
    End Function

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        'Check if name and mobile have valid data form
        If Not Form1.Name_Validation(NameSTxt.Text.ToLower) Or Not Form1.Mobile_Validator(MobileSTxt.Text.ToLower) Then
            'If data is invalid Show error message
            MessageBox.Show("No Results Found")
            Exit Sub
        End If
        'Hide ClearBtn, PrintBtn, SaveBtn SearchResultGrid , PaitentInfoBox and AdmitDetailsBox
        HideItemsOnForm()
        Dim cmd As New OleDbCommand
        Dim adapter As OleDbDataAdapter
        Dim dt As DataTable
        Dim query As String
        'query statement
        query = "Select * From [Donor] Where [Name] Like '%" & NameSTxt.Text.ToLower & "%' And [Mobile] Like '%" & MobileSTxt.Text & "%';"
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
            'Show the dataGrid
            SearchResultGrid.Visible = True
            'Close the connection
            myconnection.Close()
        Catch ex As Exception
            myconnection.Close()
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If NameTxt.Text = "" Or MobileTxt.Text = "" Or GenderTxt.Text = "" Or DOBTxt.Text = "" Or BloodGroupTxt.Text = "" Then
            MessageBox.Show("Fields Cannot be empty")
            Exit Sub
        End If
        If Not (Form1.Name_Validation(NameTxt.Text.ToLower) And Form1.Mobile_Validator(MobileTxt.Text) And Form1.age_validator(DOBTxt.Text)) Then
            MessageBox.Show("Invalid Credentitals")
            Exit Sub
        End If
        Dim cmd As New OleDbCommand
        Dim query As String
        query = "Update [Donor] Set [Name] = '" & NameTxt.Text & "', [Mobile] = '" & MobileTxt.Text & "', [Age] = " & DOBTxt.Text & ", [Gender] = '" & GenderTxt.Text & "', [Blood] = '" & BloodGroupTxt.Text & "' Where [DID] = " & IDTxt.Text & ";"
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            UpdateTable()
            MessageBox.Show("Successfully Updated Details")
            ClearDonorInfoBox()
        Catch ex As Exception
            myconnection.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        'Check if there is data to delete
        If IDTxt.Text = "" Then
            MessageBox.Show("Nothing To Delete")
            Exit Sub
        End If
        Dim cmd As New OleDbCommand
        Dim query As String
        'query statement for delete
        query = "Delete From [Donor] Where [DID] = " & IDTxt.Text & ";"
        'Open the connection
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Close the connection
            myconnection.Close()
            'Update DataGrid Table
            UpdateTable()
            'Clear the textBox containing donor info
            ClearDonorInfoBox()
            MessageBox.Show("Successfully Deleted Entry")
        Catch ex As Exception
            myconnection.Close()
        End Try
    End Sub

    Private Sub SearchResultGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SearchResultGrid.CellMouseClick
        Try
            'Fill the donor Info from the selected row to the Donor info fields
            IDTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(0).Value
            NameTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(1).Value
            GenderTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(2).Value
            DOBTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(3).Value
            BloodGroupTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(4).Value
            MobileTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(5).Value
            DateOfDonationTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(6).Value
            QuantityTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(7).Value
            DonorInfoBox.Visible = True
            DeleteBtn.Visible = True
            ClearBtn.Visible = True
            UpdateBtn.Visible = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'Call the clear textbox function
        ClearDonorInfoBox()
    End Sub

    Private Function ClearDonorInfoBox() As Boolean
        'Clear All the text box
        IDTxt.Clear()
        NameTxt.Clear()
        MobileTxt.Clear()
        DOBTxt.Clear()
        DateOfDonationTxt.Clear()
        GenderTxt.SelectedIndex = -1
        BloodGroupTxt.SelectedIndex = -1
        QuantityTxt.Clear()
        Return True
    End Function

    Private Function UpdateTable() As Boolean
        Dim cmd As New OleDbCommand
        Dim adapter As OleDbDataAdapter
        Dim dt As DataTable
        Dim query As String
        'query statement
        query = "Select * From [Donor] Where [Name] Like '%" & NameSTxt.Text.ToLower & "%' And [Mobile] Like '%" & MobileTxt.Text & "%';"
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
                myconnection.Close()
                Return False
            End If
            'Show the dataGrid
            SearchResultGrid.Visible = True
            'Close the connection
            myconnection.Close()
        Catch ex As Exception
            myconnection.Close()
        End Try
        Return True
    End Function
End Class
