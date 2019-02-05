Imports System.Data.OleDb
Public Class Form1

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\user\Documents\Staff.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


            myConnection.Open()

            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter

            da = New OleDbDataAdapter("Select * from Staff where Mobile like '%" & TextBoxSearch.Text & "%'", myConnection)
            da.Fill(dt)

            DataGridViewA.DataSource = dt.DefaultView

            If DataGridViewA.RowCount = 1 Then
                MessageBox.Show("Not Found.", "Result")
            Else
                TextBoxSID.Text = DataGridViewA.Rows(0).Cells(0).Value
                TextBoxName.Text = DataGridViewA.Rows(0).Cells(1).Value
                TextBoxDesignation.Text = DataGridViewA.Rows(0).Cells(2).Value
                TextBoxDOB.Text = DataGridViewA.Rows(0).Cells(3).Value
                TextBoxGender.Text = DataGridViewA.Rows(0).Cells(4).Value
                TextBoxMobile.Text = DataGridViewA.Rows(0).Cells(5).Value
                TextBoxAddress.Text = DataGridViewA.Rows(0).Cells(6).Value.ToString()
                TextBoxPassword.Text = DataGridViewA.Rows(0).Cells(7).Value.ToString()
            End If

            myConnection.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConnection.Open()
        Dim str As String
        str = "Update [Staff] set [Mobile]='" & TextBoxMobile.Text & "',[Address]='" & TextBoxAddress.Text & "',[Password]='" & TextBoxPassword.Text & "'where [SID] = " & TextBoxSID.Text & " "
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Button3_Click(sender, e)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSID.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '   For Each row As DataGridViewRow In DataGridViewA.Rows
        ' DataGridViewA.Rows.Item(row.Index).Visible = True

        'Next
        TextBoxName.Clear()
        TextBoxDesignation.Clear()
        TextBoxDOB.Clear()
        TextBoxPassword.Clear()
        TextBoxGender.Clear()
        TextBoxMobile.Clear()
        TextBoxAddress.Clear()
        TextBoxSearch.Clear()
        TextBoxSID.Clear()
    End Sub
End Class
