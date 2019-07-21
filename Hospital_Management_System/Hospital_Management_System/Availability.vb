Imports System.Data.OleDb
Public Class Availability
    Dim Designation As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim day As Integer = DateTime.Now.ToString("HH")
    Private Sub Availability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        Designation = ""
        close()
    End Sub
    'searches the entire database for particular staff
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        close()
            If Designation = "" Then
                MessageBox.Show("click designation")
                Exit Sub
            End If
            Try
                Dim dt As New DataTable
                Dim da As New OleDbDataAdapter
                myconnection.Open()
                da = New OleDbDataAdapter("Select * from Staff where Name like '%" & NameSTxt.Text & "%'  And   Designation = '" & Designation & "'", myconnection)
                da.Fill(dt)
                SearchResultGrid.DataSource = dt.DefaultView
                If SearchResultGrid.RowCount = 1 Then
                    MessageBox.Show("Not Found.", "Result")
                    myconnection.Close()
                    Exit Sub
                End If
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
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles DoctorBtn.CheckedChanged
        Designation = "Doctor"
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles NurseBtn.CheckedChanged
        Designation = "Nurse"
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles ReceptionistBtn.CheckedChanged
        Designation = "Receptionist"
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SearchResultGrid.CellMouseClick
        If e.RowIndex + 1 = SearchResultGrid.RowCount Or e.RowIndex = -1 Then
            Exit Sub
        End If
        Dim selectrow As Integer
        selectrow = e.RowIndex
        Detailsbox.Visible = True
        Try
            Dim row As New DataGridViewRow()
            row = SearchResultGrid.Rows(selectrow)
            SIDTxt.Text = row.Cells(0).Value.ToString
            NameTxt.Text = row.Cells(1).Value.ToString
            MobileTxt.Text = row.Cells(5).Value.ToString
            AddressTxt.Text = row.Cells(6).Value.ToString
            DesignationTxt.Text = row.Cells(2).Value.ToString
            DOBTxt.Text = row.Cells(3).Value
            GenderTxt.Text = row.Cells(4).Value.ToString
            'checking aviability
            If Shift() = row.Cells(8).Value Then
                colourgreen()
            Else
                colourred()
            End If
        Catch ex As Exception
            'MessageBox.Show("Click Valid Row")
        End Try

    End Sub
    Private Sub close()
        DetailsBox.Visible = False
        SearchResultGrid.Hide()
    End Sub
    'Clears The Input
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        NameSTxt.Clear()
        SearchResultGrid.Hide()
        DoctorBtn.Checked = False
        NurseBtn.Checked = False
        ReceptionistBtn.Checked = False
        Detailsbox.Visible = False
        Designation = ""
    End Sub
    ' function to return shift
    Private Function Shift() As String
        If day >= 7 And day <= 19 Then
            Return "Day"
        Else
            Return "Night"
        End If

    End Function
    ' colour label green
    Private Sub colourgreen()
        ShowAvailability.BackColor = Color.Green
        ShowAvailability.Text = "Available"
    End Sub
    ' colour label red
    Private Sub colourred()
        ShowAvailability.BackColor = Color.Red
        ShowAvailability.Text = "Unavailable"
    End Sub

End Class
