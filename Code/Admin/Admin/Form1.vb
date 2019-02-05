Imports System.Data.OleDb

Public Class Form1

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Connection String to connect to Database
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C:\Users\ANUBHAV TYAGI\Desktop\Hospital-Management-System\Code\Admin\Patient.accdb"
        myConnection.ConnectionString = provider & dataFile
        txtRGender.Items.Add("Male")
        txtRGender.Items.Add("Female")
        txtRGender.Items.Add("Male")
    End Sub

    Private Sub btnRCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCLEAR.Click
        'Clears all the textbox on screen
        txtRName.Clear()
        txtRAge.Clear()
        txtRGender.Items.Clear()
        txtRMobile.Clear()
        txtRAddress.Clear()
    End Sub

    Private Sub btnRADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRADD.Click

        Dim ok As Integer = 1
        Dim temp As Integer
        'If any TextBox is empty, Print error message
        If txtRName.Text = "" Or txtRAge.Text = "" Or txtRGender.Text = "" Or txtRMobile.Text = "" Or txtRAddress.Text = "" Then
            ok = 0
            MessageBox.Show("All details are required to be filled.", "INVALID ENTRY.")
        Else
            If Integer.TryParse(txtRAge.Text, temp) And temp >= 0 Then
                ok *= 1
                For i = 0 To txtRMobile.Text.Length - 1
                    If Integer.TryParse(txtRMobile.Text(i), temp) And temp >= 0 Then
                        ok *= 1
                    Else
                        ok *= 0
                    End If
                Next
                If Len(txtRMobile.Text) = 10 And ok = 1 Then
                    ok *= 1
                Else
                    ok *= 0
                    MessageBox.Show("Entry for Mobile is invalid.", "INVALID ENTRY.")
                End If
            Else
                ok *= 0
                MessageBox.Show("Entry for Age is invalid.", "INVALID ENTRY.")
            End If
        End If

        If ok = 1 Then
            myConnection.Open()
            Dim str As String
            str = "Insert into Table1([Name],[Age],[Gender],[Mobile],[Address]) Values (?,?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

            cmd.Parameters.Add(New OleDbParameter("Name", CType(txtRName.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Age", CType(txtRAge.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(txtRGender.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Mobile", CType(txtRMobile.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(txtRAddress.Text, String)))

            Try

                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()

                btnRCLEAR_Click(sender, e)

                MessageBox.Show("Patient registered successfully.", "Patient Registration")

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        End If

    End Sub

    Private Sub btnCSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCSEARCH.Click

        Dim ok As Integer = 1
        Dim temp As Integer

        For i = 0 To txtCSMobile.Text.Length - 1
            If Integer.TryParse(txtCSMobile.Text(i), temp) And temp >= 0 Then
                ok *= 1
            Else
                ok *= 0
            End If
        Next
        If Len(txtCSMobile.Text) = 10 And ok = 1 Then
            ok *= 1
        Else
            ok *= 0
            MessageBox.Show("Mobile Number to be searched is invalid.", "INVALID ENTRY.")
        End If

        If ok = 1 Then

            myConnection.Open()

            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter

            da = New OleDbDataAdapter("Select * from Table1 where Mobile like '%" & txtCSMobile.Text & "%'", myConnection)
            da.Fill(dt)

            DataGridViewC.DataSource = dt.DefaultView

            If DataGridViewC.RowCount = 1 Then
                MessageBox.Show("Not Found.", "Result")
                btnCCLEAR_Click(sender, e)
            Else
                txtCPID.Text = DataGridViewC.Rows(0).Cells(0).Value
                txtCName.Text = DataGridViewC.Rows(0).Cells(1).Value
                txtCAge.Text = DataGridViewC.Rows(0).Cells(2).Value
                txtCGender.Text = DataGridViewC.Rows(0).Cells(3).Value
                txtCMobile.Text = DataGridViewC.Rows(0).Cells(4).Value
                txtCAddress.Text = DataGridViewC.Rows(0).Cells(5).Value
                txtCRoomNo.Clear()
                txtCTokenNo.Clear()
                txtCFee.Text = "Rs. 500"
            End If

            myConnection.Close()

        End If

    End Sub

    Private Sub btnCCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCCLEAR.Click

        txtCSMobile.Clear()
        txtCPID.Clear()
        txtCName.Clear()
        txtCAge.Clear()
        txtCGender.Clear()
        txtCMobile.Clear()
        txtCAddress.Clear()
        txtCRoomNo.Clear()
        txtCTokenNo.Clear()
        txtCFee.Clear()

    End Sub

    Private Sub btnCPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCPRINT.Click

        'This button generates a Reciept in PDF format. 

    End Sub

    Private Sub btnASEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnASEARCH.Click

        Dim ok As Integer = 1
        Dim temp As Integer

        For i = 0 To txtASMobile.Text.Length - 1
            If Integer.TryParse(txtASMobile.Text(i), temp) And temp >= 0 Then
                ok *= 1
            Else
                ok *= 0
            End If
        Next
        If Len(txtASMobile.Text) = 10 And ok = 1 Then
            ok *= 1
        Else
            ok *= 0
            MessageBox.Show("Mobile Number to be searched is invalid.", "INVALID ENTRY.")
        End If

        If ok = 1 Then

            myConnection.Open()

            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter

            da = New OleDbDataAdapter("Select * from Table1 where Mobile like '%" & txtASMobile.Text & "%'", myConnection)
            da.Fill(dt)

            DataGridViewA.DataSource = dt.DefaultView

            If DataGridViewA.RowCount = 1 Then
                MessageBox.Show("Not Found.", "Result")
                btnACLEAR_Click(sender, e)
            Else
                txtAPID.Text = DataGridViewA.Rows(0).Cells(0).Value
                txtAName.Text = DataGridViewA.Rows(0).Cells(1).Value
                txtAAge.Text = DataGridViewA.Rows(0).Cells(2).Value
                txtAGender.Text = DataGridViewA.Rows(0).Cells(3).Value
                txtAMobile.Text = DataGridViewA.Rows(0).Cells(4).Value
                txtAAddress.Text = DataGridViewA.Rows(0).Cells(5).Value
                txtADateIn.Text = DataGridViewA.Rows(0).Cells(6).Value.ToString()
                txtADateOut.Text = DataGridViewA.Rows(0).Cells(7).Value.ToString()
                txtADisease.Text = DataGridViewA.Rows(0).Cells(8).Value.ToString()
                txtAStatus.Text = DataGridViewA.Rows(0).Cells(9).Value.ToString()
                txtARoomNo.Text = DataGridViewA.Rows(0).Cells(10).Value.ToString()
                txtARoomType.Text = DataGridViewA.Rows(0).Cells(11).Value.ToString()
                txtAFee.Text = ""
            End If

            myConnection.Close()

        End If

    End Sub

    Private Sub btnACLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnACLEAR.Click

        txtASMobile.Clear()
        txtAPID.Clear()
        txtAName.Clear()
        txtAAge.Clear()
        txtAGender.Clear()
        txtAMobile.Clear()
        txtAAddress.Clear()
        txtADisease.Clear()
        txtAStatus.Clear()
        txtARoomNo.Clear()
        txtARoomType.Clear()
        txtADateIn.Clear()
        txtADateOut.Clear()
        txtAFee.Clear()

    End Sub

    Private Sub btnAPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAPRINT.Click

        'This button generates a Reciept in PDF format.

    End Sub

    Private Sub btnAFEE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAFEE.Click

        'This button generates the fee.

    End Sub

    Private Sub btnAUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAUPDATE.Click

        If txtAPID.Text = "" Then

        Else

            Dim ok As Integer = 1
            Dim temp As Integer

            If txtAName.Text = "" Or txtAAge.Text = "" Or txtAGender.Text = "" Or txtAMobile.Text = "" Or txtAAddress.Text = "" Then
                ok = 0
                MessageBox.Show("Basic details are required to be filled.", "INVALID ENTRY.")
            Else
                If Integer.TryParse(txtAAge.Text, temp) And temp >= 0 Then
                    ok *= 1
                    For i = 0 To txtAMobile.Text.Length - 1
                        If Integer.TryParse(txtAMobile.Text(i), temp) And temp >= 0 Then
                            ok *= 1
                        Else
                            ok *= 0
                        End If
                    Next
                    If Len(txtAMobile.Text) = 10 And ok = 1 Then
                        ok *= 1
                    Else
                        ok *= 0
                        MessageBox.Show("Entry for Mobile is invalid.", "INVALID ENTRY.")
                    End If
                Else
                    ok *= 0
                    MessageBox.Show("Entry for Age is invalid.", "INVALID ENTRY.")
                End If
            End If

            If ok = 1 Then
                myConnection.Open()
                Dim str As String
                str = "Update [Table1] set [Name] = '" & txtAName.Text & "',  [Age] = '" & txtAAge.Text & "', [Gender] = '" & txtAGender.Text & "', [Mobile] = '" & txtAMobile.Text & "', [Address] = '" & txtAAddress.Text & "', [Date In] = '" & txtADateIn.Text & "', [Date Out] = '" & txtADateOut.Text & "', [Disease] = '" & txtADisease.Text & "', [Status] = '" & txtAStatus.Text & "', [Room No] = '" & txtARoomNo.Text & "', [Room Type] = '" & txtARoomType.Text & "' where [PID] = " & txtAPID.Text & " "
                Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

                Try

                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    myConnection.Close()

                    btnACLEAR_Click(sender, e)

                    MessageBox.Show("Patient details updated.", "Admin")

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try
            End If

        End If

    End Sub

    Private Sub DataGridViewA_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewA.CellMouseClick
        Try
            txtAPID.Text = DataGridViewA.Rows(e.RowIndex).Cells(0).Value
            txtAName.Text = DataGridViewA.Rows(e.RowIndex).Cells(1).Value
            txtAAge.Text = DataGridViewA.Rows(e.RowIndex).Cells(2).Value
            txtAGender.Text = DataGridViewA.Rows(e.RowIndex).Cells(3).Value
            txtAMobile.Text = DataGridViewA.Rows(e.RowIndex).Cells(4).Value
            txtAAddress.Text = DataGridViewA.Rows(e.RowIndex).Cells(5).Value
            txtADateIn.Text = DataGridViewA.Rows(e.RowIndex).Cells(6).Value.ToString()
            txtADateOut.Text = DataGridViewA.Rows(e.RowIndex).Cells(7).Value.ToString()
            txtADisease.Text = DataGridViewA.Rows(e.RowIndex).Cells(8).Value.ToString()
            txtAStatus.Text = DataGridViewA.Rows(e.RowIndex).Cells(9).Value.ToString()
            txtARoomNo.Text = DataGridViewA.Rows(e.RowIndex).Cells(10).Value.ToString()
            txtARoomType.Text = DataGridViewA.Rows(e.RowIndex).Cells(11).Value.ToString()
            txtAFee.Text = ""
        Catch ex As Exception

        End Try
        
    End Sub
End Class
