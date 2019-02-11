Imports System.Data.OleDb
Public Class Admit
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Admit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        HideItemsOnForm()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        'Check if name and mobile have valid data form
        If Not Form1.Name_Validation(NameSTxt.Text.ToLower) Or Not Form1.Mobile_Validator(MobileTxt.Text.ToLower) Then
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
        query = "Select * From [Patient] Where [Name] Like '%" & NameSTxt.Text.ToLower & "%' And [Mobile] Like '%" & MobileTxt.Text & "%';"
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

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        'Check if name and mobile have valid data form
        If RoomNoTxt.Text = "" Or RoomTypeTxt.Text = "" Or StatusTxt.Text = "" Then
            'If data is invalid Show error message
            MessageBox.Show("Invalid Credentials")
            Exit Sub
        End If

        If StatusTxt.Text = "" Or StatusTxt.Text = "Not Paid" Then
            MessageBox.Show("Cannot Discharge without Fees Payment")
        End If

        Dim cmd As New OleDbCommand
        Dim query As String
        'query statement for update
        query = SetQueryStatement()
        'Open the connection
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Close the connection
            myconnection.Close()
            MessageBox.Show("Successfully Updated Details")
            'ClearAdmitDetails()
            'ClearPatientInfo()
            UpdateTable()
        Catch ex As Exception
            myconnection.Close()
        End Try
    End Sub

    Private Function HideItemsOnForm() As Boolean
        'Hide Items On the form
        SearchResultGrid.Visible = False
        AdmitDetailsBox.Visible = False
        PatientInfoBox.Visible = False
        ClearBtn.Visible = False
        PrintBtn.Visible = False
        SaveBtn.Visible = False
        Return True
    End Function

    Private Function SetQueryStatement() As String
        Dim query As String
        query = "Update [Patient] Set [Mobile] = '" & MobileTxt.Text & "',[Date In] = '" & DateTimePicker1.Value & "',[Date Out] = '" & DateTimePicker2.Value & "',[Room No] = '" & RoomNoTxt.Text & "', [Room Type] = '" & RoomTypeTxt.Text & "', [Fee Status] = '" & StatusTxt.Text & "' Where [PID] = " & PIDTxt.Text & ";"
        Return query
    End Function

    Private Sub SearchResultGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SearchResultGrid.CellMouseClick
        Try
            'Show the Patient Info in the Respective Fields
            PIDTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(0).Value
            NameTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(1).Value
            AgeTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(2).Value
            GenderTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(3).Value
            MobileSTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(4).Value
            AddressTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(5).Value

            Try
                DateTimePicker1.Value = SearchResultGrid.Rows(e.RowIndex).Cells(6).Value
                DateTimePicker2.Value = SearchResultGrid.Rows(e.RowIndex).Cells(7).Value
            Catch ex As Exception
            End Try

            'Show Hidden items
            AdmitDetailsBox.Visible = True
            PatientInfoBox.Visible = True
            ClearBtn.Visible = True
            PrintBtn.Visible = True
            SaveBtn.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Update the data table after updating user information
    Private Function UpdateTable() As Boolean
        Dim cmd As New OleDbCommand
        Dim adapter As OleDbDataAdapter
        Dim dt As DataTable
        Dim query As String
        'query statement
        query = "Select * From [Patient] Where [Name] Like '%" & NameSTxt.Text.ToLower & "%' And [Mobile] Like '%" & MobileTxt.Text & "%';"
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
    'Clear the patient details and admit details
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ClearPatientInfo()
        ClearAdmitDetails()
    End Sub
    'Clears PatientInfoBox
    Private Function ClearPatientInfo() As Boolean
        'Clear All the text box
        PIDTxt.Clear()
        NameTxt.Clear()
        MobileTxt.Clear()
        AgeTxt.Clear()
        AddressTxt.Clear()
        GenderTxt.Clear()
        Return True
    End Function
    'Clears AdmitDetailsBox
    Private Function ClearAdmitDetails() As Boolean
        'Clear All the text Box
        RoomNoTxt.Clear()
        RoomTypeTxt.Clear()
        StatusTxt.SelectedIndex = -1
        Return True
    End Function

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim ReportFont As Font = New Drawing.Font("Times New Roman", 20)
        Dim ReportBodyFont As Font = New Drawing.Font("Times New Roman", 12)
        e.Graphics.DrawString("Admit/Discharge", ReportFont, Brushes.Chocolate, 250, 100)
        e.Graphics.DrawString("Name - " & NameTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 400)
        e.Graphics.DrawString("Mobile - " & MobileTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 800)
        e.Graphics.DrawString("Token No. - " & RoomTypeTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 1000)
        e.Graphics.DrawString("Room No. - " & RoomNoTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 1200)
        e.Graphics.DrawString("Fees - " & FeesTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 1400)
    End Sub

    Private Sub DateOutTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.MouseLeave

        Dim dateIn As DateTime = Convert.ToDateTime(DateTimePicker1.Text)
        Dim dateOut As DateTime = Convert.ToDateTime(DateTimePicker2.Text)
        Dim countDays As TimeSpan = dateOut.Subtract(dateIn)
        Dim days As Integer = CInt(countDays.Days)
        Dim fee As Integer = days * 500
        If (days >= 0) Then
            FeesTxt.Text = CStr(fee)
        Else
            MessageBox.Show("dateIn should be before dateOut")
        End If

    End Sub

End Class
