Imports System.Data.OleDb
Public Class UpdateStaff_Admin
    Dim Designation As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim day As Integer = DateTime.Now.ToString("HH")
    Dim selectrow As Integer
    Private Sub UpdateStaff_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' connecting while loading
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        Designation = ""
        DOBTxt.MaxDate = Format(Date.Now(), "dd-MM-yyyy")
        Hidedata()
    End Sub

    ' Search button
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Hidedata()
        'checking validation
        If Not Form1.Name_Validation(NameSTxt.Text.ToLower) Then
            MessageBox.Show("Enter Valid Name")
            Exit Sub
        ElseIf Designation = "" Then
            MessageBox.Show("click designation")
            Exit Sub
        End If
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            myconnection.Open()
            'searching into databse
            da = New OleDbDataAdapter("Select * from Staff where Name like '%" & NameSTxt.Text & "%'  And   Designation = '" & Designation & "'", myconnection)
            da.Fill(dt)
            SearchResultGrid.DataSource = dt.DefaultView

            ' If no result found
            If SearchResultGrid.RowCount = 1 Then
                MessageBox.Show("Not Found.", "Result")
                myconnection.Close()
                Exit Sub
            End If
            ' showing result in gridveiw
            SearchResultGrid.Show()
            myconnection.Close()
            HideunusedColumns()
        Catch ex As Exception
            myconnection.Close()
            MessageBox.Show("Incorrect Credentials")
        End Try
    End Sub

    Private Function HideunusedColumns() As Boolean
        SearchResultGrid.Columns(7).Visible = False
        SearchResultGrid.Columns(9).Visible = False
        Return False
    End Function
    ' Designation store Designation
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles DoctorBtn.CheckedChanged
        Designation = "Doctor"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles NurseBtn.CheckedChanged
        Designation = "Nurse"
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles ReceptionistBtn.CheckedChanged
        Designation = "Receptionist"
    End Sub
    'cell Mouse Clicker when It is clicked
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SearchResultGrid.CellMouseClick
        If e.RowIndex + 1 = SearchResultGrid.RowCount Or e.RowIndex = -1 Then
            Exit Sub
        End If
        selectrow = e.RowIndex
        DetailsBox.Visible = True
        UpdateBtn.Show()
        DeleteBtn.Show()
        Try
            Dim row As New DataGridViewRow()
            row = SearchResultGrid.Rows(selectrow)
            SIDTxt.Text = row.Cells(0).Value.ToString
            NameTxt.Text = row.Cells(1).Value.ToString
            DesignationTxt.Text = row.Cells(2).Value.ToString
            DOBTxt.Text = row.Cells(3).Value
            GenderTxt.Text = row.Cells(4).Value.ToString
            MobileTxt.Text = row.Cells(5).Value.ToString
            AddressTxt.Text = row.Cells(6).Value.ToString
            WorkShiftTxt.Text = row.Cells(8).Value.ToString
            putcolor(row.Cells(8).Value)
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub
    ' hide data hide details Box and SearchResult
    Private Sub Hidedata()
        DetailsBox.Visible = False
        SearchResultGrid.Hide()
        UpdateBtn.Hide()
        DeleteBtn.Hide()
    End Sub
    ' clear Button to clear everrything
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        NameSTxt.Clear()
        SearchResultGrid.Hide()
        DoctorBtn.Checked = False
        NurseBtn.Checked = False
        ReceptionistBtn.Checked = False
        DetailsBox.Visible = False
        Designation = ""
        UpdateBtn.Hide()
        DeleteBtn.Hide()
    End Sub


    ' to enabale colur to available label
    Private Sub putcolor(ByVal WorkShift As String)
        If Shift() = WorkShift Then
            colourgreen()
        Else
            colourred()
        End If
    End Sub


    ' calculating current time is day orr Night
    Private Function Shift() As String
        If day >= 7 And day <= 19 Then
            Return "Day"
        Else
            Return "Night"
        End If

    End Function

    ' colouring label as green
    Private Sub colourgreen()
        ShowAvailability.BackColor = Color.Green
        ShowAvailability.Text = "Available"
    End Sub

    ' colouring label as Red
    Private Sub colourred()
        ShowAvailability.BackColor = Color.Red
        ShowAvailability.Text = "Unavilable"
    End Sub

    ' update Button
    Private Sub UpadateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If NameTxt.Text = "" Or MobileTxt.Text = "" Or GenderTxt.Text = "" Or DOBTxt.Text = "" Or DesignationTxt.Text = "" Or AddressTxt.Text = "" Or WorkShiftTxt.Text = "" Then
            MessageBox.Show("Fields Cannot be empty")
            Exit Sub
        End If
        'updating database
        Dim str As String
        Dim var_date As DateTime = Format(DOBTxt.Value, "dd-MM-yyyy")
        str = "Update [Staff] set [Date Of Birth] = #" & var_date & "#, [Mobile]='" & MobileTxt.Text & "',[Work Shift]='" & WorkShiftTxt.Text & "',[Address]='" & AddressTxt.Text & "'where [SID] = " & SIDTxt.Text & " "
        ' mobile validation
        If Not (Form1.Mobile_Validator(MobileTxt.Text.ToLower) And Form1.Name_Validation(NameTxt.Text.ToLower) And Form1.Gender_Validator(GenderTxt.Text.ToLower)) Then
            MessageBox.Show("Invalid Credentials")
            Exit Sub
        End If

        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            ClearDetailsBox()
            MessageBox.Show("Updated Sucessfully")
            myconnection.Close()
            UpdateTable()
        Catch ex As Exception
            MsgBox("Invalid Credentials")
            myconnection.Close()
            Exit Sub
        End Try
    End Sub
    ' delete Button 
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim row As New DataGridViewRow()
        row = SearchResultGrid.Rows(selectrow)
        If SIDTxt.Text = "" Then
            MessageBox.Show("No Data To Delete")
            Exit Sub
        End If
        ' deleting database
        Dim str As String
        str = "Delete from [Staff] where [SID] = " & SIDTxt.Text & " "
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
            MessageBox.Show("Deleted  Sucessfully")
            UpdateTable()
            ClearDetailsBox()
        Catch ex As Exception
            'MsgBox(ex.Message)
            myconnection.Close()
            Exit Sub
        End Try
    End Sub

    Private Function UpdateTable() As Boolean
        Dim cmd As New OleDbCommand
        Dim adapter As OleDbDataAdapter
        Dim dt As DataTable
        Dim query As String
        'query statement
        query = "Select * From [Staff] Where [Name] Like '%" & NameSTxt.Text.ToLower & "%' And [Designation] Like '%" & Designation & "%';"
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
            HideunusedColumns()
        Catch ex As Exception
            MessageBox.Show("Error updating table")
            myconnection.Close()
        End Try
        Return True
    End Function

    Private Function ClearDetailsBox() As Boolean
        'Clear All the text box
        SIDTxt.Clear()
        NameTxt.Clear()
        MobileTxt.Clear()
        DOBTxt.Value = Format(Date.Now(), "dd-MM-yyyy")
        AddressTxt.Clear()
        GenderTxt.SelectedIndex = -1
        EmailTxt.Clear()
        DesignationTxt.SelectedIndex = -1
        WorkShiftTxt.SelectedIndex = -1
        Return True
    End Function
End Class
