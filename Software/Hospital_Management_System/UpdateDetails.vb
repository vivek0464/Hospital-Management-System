Imports System.Data.OleDb
Public Class UpdateDetails
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim selectrow As Integer
    Dim mobile As String
    Dim name_search As String
    Private Sub UpdateDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        Hidedata()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Hidedata()
        If Not Form1.Name_Validation(NameSTxt.Text.ToLower) Or Not Form1.Mobile_Validator(MobileSTxt.Text.ToLower) Then
            MessageBox.Show("No Results Found")
            Exit Sub
        End If
        Try
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            myconnection.Open()
            da = New OleDbDataAdapter("Select * from Patient where Name like '%" & NameSTxt.Text & "%'  And   Mobile like '%" & MobileSTxt.Text & "%' ", myconnection)
            da.Fill(dt)
            SearchResultGrid.DataSource = dt.DefaultView
            If SearchResultGrid.RowCount = 1 Then
                MessageBox.Show("Not Found.", "Result")
                myconnection.Close()
                Exit Sub
            End If
            SearchResultGrid.Show()
            myconnection.Close()
            mobile = MobileSTxt.Text
            name_search = NameSTxt.Text
        Catch ex As Exception
            myconnection.Close()
            MessageBox.Show("Incorrect Credentials")
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim str As String
        str = "Update [Patient] set [Mobile]='" & MobileTxt.Text & "',[Address]='" & AddressTxt.Text & "'where [PID] = " & PIDTxt.Text & " "
        If Not (Form1.Mobile_Validator(MobileTxt.Text.ToLower) And Not AddressTxt.Text = "") Then
            MessageBox.Show("Enter Valid Phone number")
            Exit Sub
        End If
        myconnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            updatedatagrid()
            MessageBox.Show("Updated Sucessfully")
            myconnection.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            myconnection.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SearchResultGrid.CellMouseClick
        If e.RowIndex + 1 = SearchResultGrid.RowCount Or e.RowIndex = -1 Then
            Exit Sub
        End If
        selectrow = e.RowIndex
        Try
            PatientInfoBox.Visible = True
            UpdateBtn.Show()
            ClearBtn.Show()
            selectrow = e.RowIndex
            Dim row As New DataGridViewRow()
            row = SearchResultGrid.Rows(selectrow)
            PIDTxt.Text = row.Cells(0).Value.ToString
            NameTxt.Text = row.Cells(1).Value.ToString
            DOBTxt.Text = row.Cells(2).Value
            MobileTxt.Text = row.Cells(4).Value.ToString
            GenderTxt.Text = row.Cells(3).Value.ToString
            AddressTxt.Text = row.Cells(5).Value.ToString
        Catch ex As Exception
            'MessageBox.Show("click valid row")
        End Try
    End Sub

    Private Sub Hidedata()
        PatientInfoBox.Visible = False
        SearchResultGrid.Hide()
        UpdateBtn.Hide()
        ClearBtn.Hide()
    End Sub
    Private Sub updatedatagrid()
        Dim row As New DataGridViewRow()
        row = SearchResultGrid.Rows(selectrow)
        row.Cells(2).Value = DOBTxt.Text
        row.Cells(4).Value = MobileTxt.Text
        row.Cells(5).Value = AddressTxt.Text
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        PIDTxt.Clear()
        NameTxt.Clear()
        DOBTxt.Clear()
        MobileTxt.Clear()
        GenderTxt.Clear()
        AddressTxt.Clear()

    End Sub
End Class
