Imports System.Data.OleDb
Public Class CheckUp
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim mobile As String
    Private Sub CheckUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        HideItemsOnForm()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        'Hide ClearBtn, PrintBtn SearchResultGrid , PaitentInfoBox and PaymentInfoBox
        HideItemsOnForm()
        'Check if name and mobilehave valid data form
        If Not Form1.Name_Validation(NameSTxt.Text.ToLower) Or Not Form1.Mobile_Validator(MobileTxt.Text.ToLower) Then
            'If data is invalid Show error message
            MessageBox.Show("No Result Found")
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
            'Set Token Number, Room No. And Fees
            SetPaymentBoxFields()
            'Show the dataGrid
            SearchResultGrid.Visible = True
            'Close the connection
            myconnection.Close()
            mobile = MobileTxt.Text
        Catch ex As Exception
            myconnection.Close()
        End Try
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'Clears the searchbox and hides the datagrid and other forms
        NameTxt.Clear()
        GenderTxt.Clear()
        PIDTxt.Clear()
        DOBTxt.Clear()
        AddressTxt.Clear()
        TokenNoTxt.Clear()
        RoomNoTxt.Clear()
        FeesTxt.Clear()
    End Sub

    Private Sub SearchResultGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SearchResultGrid.CellMouseClick
        Try
            'Show the Patient Info in the Respective Fields
            PIDTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(0).Value
            NameTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(1).Value
            DOBTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(2).Value
            GenderTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(3).Value
            AddressTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(5).Value
            'Show Hideen items
            PaymentBox.Visible = True
            PatientInfoBox.Visible = True
            ClearBtn.Visible = True
            PrintBtn.Visible = True
            SetPaymentBoxFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function SetPaymentBoxFields() As Boolean
        TokenNoTxt.Text = Form1.Current_tokenNo
        RoomNoTxt.Text = Form1.Current_RoomNo + 100
        FeesTxt.Text = "500"
        Return True
    End Function

    Private Function HideItemsOnForm() As Boolean
        'Hide Items On the form
        SearchResultGrid.Visible = False
        PaymentBox.Visible = False
        PatientInfoBox.Visible = False
        ClearBtn.Visible = False
        PrintBtn.Visible = False
        Return True
    End Function

    'prints the document for Patient form
    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintBtn.Click
        'Check if Patient information is present
        If PIDTxt.Text = "" Then
            MessageBox.Show("No Patient to Print")
            Exit Sub
        End If
        Form1.Current_tokenNo = Form1.Current_tokenNo + 1
        Form1.Current_RoomNo = (Form1.Current_RoomNo + 1) Mod 8
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
        e.Graphics.DrawString("Check Up", ReportFont, Brushes.Chocolate, 250, 100)
        e.Graphics.DrawString("Name - " & NameTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 400)
        e.Graphics.DrawString("Mobile - " & mobile & "", ReportBodyFont, Brushes.Chocolate, 100, 800)
        e.Graphics.DrawString("Token No. - " & TokenNoTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 1000)
        e.Graphics.DrawString("Room No. - " & RoomNoTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 1200)
        e.Graphics.DrawString("Fees - " & FeesTxt.Text & "", ReportBodyFont, Brushes.Chocolate, 100, 1400)
    End Sub
End Class
