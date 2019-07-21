Imports System.Data.OleDb
Public Class Admit
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim id As String
    Private Sub Admit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        HideItemsOnForm()
        DateInTxt.Items.Add(Format(Today(), "dd-MM-yyyy"))
        DateOutTxt.Items.Add(Today)
        RoomNoTxt.Items.Clear()
        Add_Rooms()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        'Hide ClearBtn, PrintBtn, SaveBtn SearchResultGrid , PaitentInfoBox and AdmitDetailsBox
        HideItemsOnForm()
        'Check if name and mobile have valid data form
        If Not Form1.Name_Validation(NameSTxt.Text.ToLower) Or Not Form1.Mobile_Validator(MobileTxt.Text.ToLower) Then
            'If data is invalid Show error message
            MessageBox.Show("No Results Found")
            Exit Sub
        End If
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
        'Check form correctness
        If Not Validate_Print_Data() Then
            Exit Sub
        End If
        Dim cmd As New OleDbCommand
        'perform query as required
        performQueryStatement()

    End Sub

    Private Function HideItemsOnForm() As Boolean
        'Hide Items On the form
        SearchResultGrid.Visible = False
        AdmitDetailsBox.Visible = False
        PatientInfoBox.Visible = False
        ClearBtn.Visible = False
        PrintBtn.Visible = False
        SaveBtn.Visible = False
        HistoryBtn.Visible = False
        AdmitDischargeBtn.Visible = False
        Return True
    End Function
    'Performs query according to the patient's current database
    Private Function performQueryStatement() As String
        Dim query As String
        Dim cmd As New OleDbCommand
        Dim var_date As DateTime = Format(Date.Now(), "dd-MM-yyyy")
        'MessageBox.Show(var_date)
        If DateIn1Txt.Text = "" Then
            query = "Insert Into [Admit-Discharge] ([DateIn],[PID],[Fee Status],[Room No],[Room type]) Values (?,?,?,?,?);"
            myconnection.Open()
            Try
                cmd = New OleDbCommand(query, myconnection)
                'Specify the parameters and corresponding values
                cmd.Parameters.Add(New OleDbParameter("DateIn", CType(var_date, String)))
                cmd.Parameters.Add(New OleDbParameter("PID", CType(PIDTxt.Text, Integer)))
                cmd.Parameters.Add(New OleDbParameter("Fee Status", CType(StatusTxt.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("Room No", CType(RoomNoTxt.Text, Integer)))
                cmd.Parameters.Add(New OleDbParameter("Room Type", CType(RoomTypeTxt.Text.ToString, String)))

                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'Close the connection
                myconnection.Close()
                MessageBox.Show("Successfully Updated Details")
                Update_Rooms(RoomNoTxt.Text, "No")
                UpdateTable()
            Catch ex As Exception
                myconnection.Close()
                'MessageBox.Show(ex.Message)
                MessageBox.Show("Cannot proceed with the request!", "INVALID REQUEST")
            End Try
        ElseIf Not DateIn1Txt.Text = "" And DateOut1Txt.Text = "" Then
            var_date = Format(Date.Today(), "MM-dd-yyyy")
            'MessageBox.Show(var_date)
            query = "Update [Admit-Discharge] Set [DateOut] = #" & var_date & "#, [Fee Status] = '" & StatusTxt.Text & "' Where [ID] = " & id & " ;"
            'Open the connection
            myconnection.Open()
            Try
                cmd = New OleDbCommand(query, myconnection)

                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'Close the connection
                myconnection.Close()
                MessageBox.Show("Successfully Updated Details")
                'MessageBox.Show(query)
                'ClearAdmitDetails()
                'ClearPatientInfo()
                Update_Rooms(RoomNo1Txt.Text, "Yes")
                UpdateTable()
            Catch ex As Exception
                myconnection.Close()
                'MessageBox.Show(ex.Message)
                MessageBox.Show("Cannot proceed with the request!", "INVALID REQUEST")
            End Try
        Else
            query = "Update [Admit-Discharge] Set [Room No] = " & RoomNoTxt.Text & ", [Room Type] = '" & RoomTypeTxt.Text & "', [Fee Status] = '" & StatusTxt.Text & "' Where [PID] = " & PIDTxt.Text & ";"
            'Open the connection
            myconnection.Open()
            Try
                cmd = New OleDbCommand(query, myconnection)

                cmd.ExecuteNonQuery()
                cmd.Dispose()
                'Close the connection
                myconnection.Close()
                MessageBox.Show("Successfully Updated Details")
                'MessageBox.Show(query)
                'ClearAdmitDetails()
                'ClearPatientInfo()
                UpdateTable()
            Catch ex As Exception
                myconnection.Close()
                'MessageBox.Show(ex.Message)
                MessageBox.Show("Cannot proceed with the request!", "INVALID REQUEST")
            End Try
        End If
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

            'Show Hidden items
            HistoryBtn.Visible = True
            AdmitDischargeBtn.Visible = True
            AdmitDetailsBox.Visible = False
            PatientInfoBox.Visible = True
            ClearBtn.Visible = False
            PrintBtn.Visible = False
            SaveBtn.Visible = False
            RoomNoTxt.SelectedIndex = -1
            RoomTypeTxt.SelectedIndex = -1
            FeesTxt.Clear()
            DateIn1Txt.Clear()
            DateOut1Txt.Clear()
            StatusTxt.SelectedIndex = -1
            DateInTxt.SelectedIndex = -1
            DateOutTxt.SelectedIndex = -1
        Catch ex As Exception

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
        RoomNoTxt.Items.Clear()
        Add_Rooms()
    End Sub
    'Clears PatientInfoBox
    Private Function ClearPatientInfo() As Boolean
        'Clear All the text box
        PIDTxt.Clear()
        NameTxt.Clear()
        MobileSTxt.Clear()
        AgeTxt.Clear()
        AddressTxt.Clear()
        GenderTxt.Clear()
        Return True
    End Function
    'Clears AdmitDetailsBox
    Private Function ClearAdmitDetails() As Boolean
        'Clear All the text Box
        RoomNoTxt.SelectedIndex = -1
        RoomTypeTxt.SelectedIndex = -1
        RoomNo1Txt.Clear()
        RoomType1Txt.Clear()
        DateIn1Txt.Clear()
        DateOut1Txt.Clear()
        DateInTxt.SelectedIndex = -1
        DateOutTxt.SelectedIndex = -1
        StatusTxt.SelectedIndex = -1
        FeesTxt.Clear()
        Return True
    End Function
    'prints the document
    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        'Check if Patient information is present
        If PIDTxt.Text = "" Then
            MessageBox.Show("No Patient to Print")
            Exit Sub
        End If
        'validate function
        If Not Validate_Print_Data() Then
            'Exit
            Exit Sub
        End If
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub
    'Creates the document to be printed
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim room_no As String
        Dim room_type As String
        If RoomNo1Txt.Visible Then
            room_no = RoomNo1Txt.Text
        Else
            room_no = RoomNoTxt.Text
        End If
        If RoomType1Txt.Visible Then
            room_type = RoomType1Txt.Text
        Else
            room_type = RoomTypeTxt.Text
        End If
        Dim ReportFont As Font = New Drawing.Font("Times New Roman", 20)
        Dim ReportBodyFont As Font = New Drawing.Font("Times New Roman", 12)
        e.Graphics.DrawString("Admit/Discharge", ReportFont, Brushes.Chocolate, 250, 100)
        e.Graphics.DrawString("Name - " & NameTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 150)
        e.Graphics.DrawString("Mobile - " & MobileTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 200)
        e.Graphics.DrawString("Room No - " & room_no & "", ReportBodyFont, Brushes.Chocolate, 100, 250)
        e.Graphics.DrawString("Room Type - " & room_type & "", ReportBodyFont, Brushes.Chocolate, 100, 300)
        e.Graphics.DrawString("Fees - " & FeesTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 350)
    End Sub
    'Shows the previous History Of Patient 
    Private Sub HistoryBtn_Click(sender As Object, e As EventArgs) Handles HistoryBtn.Click
        'Check if name and mobile have valid data form
        If PIDTxt.Text = "" Then
            'If data is invalid Show error message
            MessageBox.Show("No Patient Selected")
            Exit Sub
        End If
        'pass the PID to Form 5 And Show the form
        Form2.PID_Value = PIDTxt.Text
        Form5.Show()
    End Sub
    'open the details for admit or discharge of patient
    Private Sub AdmitDischargeBtn_Click(sender As Object, e As EventArgs) Handles AdmitDischargeBtn.Click
        If PIDTxt.Text = "" Then
            'If data is invalid Show error message
            MessageBox.Show("No Patient Selected")
            Exit Sub
        End If
        
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim query As String
        'query statement
        query = "Select * From [Admit-Discharge] Where [PID] = " & PIDTxt.Text & ";"
        'Open the connection
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)
            reader = cmd.ExecuteReader()
            Dim flag = 0
            'Show the buttons and text box accordingly
            While reader.Read
                If Not reader(2).ToString = "" And reader(3).ToString = "" Then
                    flag = 1
                    DateOut1Txt.Visible = False
                    DateOutTxt.Visible = True
                    id = reader(0).ToString
                    DateIn1Txt.Text = reader(2)
                    RoomNo1Txt.Text = reader(4).ToString
                    RoomNoTxt.Visible = False
                    RoomNo1Txt.Visible = True
                    RoomType1Txt.Text = reader(5).ToString
                    RoomTypeTxt.Visible = False
                    RoomType1Txt.Visible = True
                    StatusTxt.Text = reader(6).ToString
                    DateIn1Txt.Visible = True
                    DateInTxt.Visible = False
                    Exit While
                End If
            End While
            'Close the connection
            myconnection.Close()
            AdmitDischargeBtn.Visible = False
            AdmitDetailsBox.Visible = True
            ClearBtn.Visible = True
            PrintBtn.Visible = True
            SaveBtn.Visible = True
            If flag = 0 Then
                DateOut1Txt.Visible = True
                DateOutTxt.Visible = False
                DateIn1Txt.Visible = False
                DateInTxt.Visible = True
                RoomNo1Txt.Visible = False
                RoomType1Txt.Visible = False
                RoomNoTxt.Visible = True
                RoomTypeTxt.Visible = True
            End If
        Catch ex As Exception
            myconnection.Close()
            AdmitDetailsBox.Visible = True
            DateOut1Txt.Visible = True
            DateOutTxt.Visible = False
            DateIn1Txt.Visible = False
            DateInTxt.Visible = True
            RoomNo1Txt.Visible = False
            RoomType1Txt.Visible = False
            RoomNoTxt.Visible = True
            RoomTypeTxt.Visible = True
            MessageBox.Show(ex.Message)
            MessageBox.Show(query)

        End Try
    End Sub
    'Add Available Rooms to the list
    Private Function Add_Rooms() As Boolean
        Dim query As String
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader
        query = "Select * From [Room] Where [Availability] = 'Yes';"
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)
            reader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read
                    RoomNoTxt.Items.Add(reader(0).ToString)
                End While
            End If
            myconnection.Close()
        Catch ex As Exception
            myconnection.Close()
        End Try
        Return True
    End Function
    'Change Availability of Alloted Room
    Private Function Update_Rooms(ByVal roomNo As String, ByVal status As String) As Boolean
        Dim query As String
        Dim cmd As New OleDbCommand
        query = "Update [Room] Set [Availability] = '" & status & "' Where [Room No] = " & roomNo & ";"
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            myconnection.Close()
            'MessageBox.Show(ex.Message)
        End Try
        Return True
    End Function
    'Validates the data in various scenarios
    Private Function Validate_Print_Data() As Boolean
        If RoomNoTxt.SelectedIndex = -1 And RoomNo1Txt.Text = "" Then
            MessageBox.Show("Missing Room No")
            Return False
        End If
        If RoomTypeTxt.SelectedIndex = -1 And RoomType1Txt.Text = "" Then
            MessageBox.Show("Missing Room type")
            Return False
        End If
        If Not DateIn1Txt.Visible Then
            If DateInTxt.SelectedIndex = -1 Then
                MessageBox.Show("Missing Date In")
                Return False
            End If
            If StatusTxt.Text = "Paid" And Not Form1.Number_Validator(FeesTxt.Text) Then
                MessageBox.Show("Missing fees")
                Return False
            End If
            If StatusTxt.Text = "Not Paid" And Not FeesTxt.Text = "" Then
                MessageBox.Show("Cannot Display Fees when Not Paid")
                Return False
            End If
        End If
        If Not DateOut1Txt.Visible Then
            If DateOutTxt.SelectedIndex = -1 Then
                MessageBox.Show("Missing Date out")
                Return False
            End If
            If Not Form1.Number_Validator(FeesTxt.Text) Then
                MessageBox.Show("Incorrect fees Value")
                Return False
            End If
            If StatusTxt.Text = "" Or StatusTxt.Text = "Not Paid" Then
                MessageBox.Show("Cannot discharge Without Paying fees")
                Return False
            End If
        End If
        Return True
    End Function
End Class
