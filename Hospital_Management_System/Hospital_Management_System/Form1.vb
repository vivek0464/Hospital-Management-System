Imports System.Data.OleDb
Public Class Form1
    'Global Variables
    Public provider As String
    Public datafile As String
    Public username As String
    Public Current_tokenNo As Integer = 1
    Public Current_RoomNo As Integer = 0
    Public login_type As String
    Public cur_blood_amount As Decimal
    Public blood_available_id As Integer
    'Local Variables
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSize = True
        Me.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        PreVentFlicker()
        'AutoLayout(AutoSuitableScreen())
        Dim strPath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        strPath = strPath.Substring(6, strPath.Length - 6)
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = strPath + "\Database.accdb"
        myconnection.ConnectionString = provider & datafile
        login_type = ""
        username = ""
    End Sub
    'Login button
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim query As String
        myconnection.Open()
        'MessageBox.Show("Connected")
        Try
            query = "Select [Designation] From [Staff] Where [Username] = '" & UsernameTxt.Text & "' And [Password] = '" & PasswordTxt.Text & "';"
            Dim cmd As New OleDbCommand
            Dim reader As OleDbDataReader
            cmd = New OleDbCommand(query, myconnection)
            reader = cmd.ExecuteReader()
            'Check if any results were found
            If reader.HasRows And Not login_type = "" Then
                Dim check_user As Integer = 0
                'Select the user from multiple enteries
                'MessageBox.Show(reader(0))
                While reader.Read
                    If login_type = Calculate_Login_Type(reader(0).ToString) Then
                        check_user = 1
                        Exit While
                    End If
                End While
                If check_user = 1 Then
                    username = UsernameTxt.Text().ToString
                    UsernameTxt.Clear()
                    PasswordTxt.Clear()
                    AdminRadioBtn.Checked = False
                    StaffRadioBtn.Checked = False
                    Me.Hide()
                    If ShowPasswd.Checked Then
                        ShowPasswd.Checked = False
                        PasswordTxt.UseSystemPasswordChar = True
                    End If
                    If login_type = "Admin" Then
                        Form3.Show()
                    Else
                        Form2.Show()
                    End If
                Else
                    MessageBox.Show("Incorrect Credentials")
                End If
            Else
                MessageBox.Show("Incorrect Credentials")
            End If
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            myconnection.Close()
            'MessageBox.Show(ex.Message)
            MessageBox.Show("Incorrect Credentials")
        End Try
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
    'Show Password checkbox
    Private Sub ShowPasswd_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswd.CheckedChanged
        If PasswordTxt.UseSystemPasswordChar = True Then
            PasswordTxt.UseSystemPasswordChar = False
        Else
            PasswordTxt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Function Calculate_Login_Type(ByVal designation As String) As String
        If designation.ToLower = "admin" Then
            Return "Admin"
        End If
        Return "Staff"
    End Function

    Private Sub AdminRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles AdminRadioBtn.CheckedChanged
        login_type = "Admin"
    End Sub

    Private Sub StaffRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles StaffRadioBtn.CheckedChanged
        login_type = "Staff"
    End Sub

    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With

    End Sub
    'Validates if the name is a valid name or not
    Public Function Name_Validation(ByVal name As String) As Boolean
        Try
            If name.ToUpper = name.ToLower Then
                Return False
            End If
            Dim flag As Integer = 0
            Dim i As Integer = 0
            For i = 0 To name.Length - 1
                If flag = 0 Then
                    If Not (name(i) >= "a"c And name(i) <= "z"c) And Not (name(i) = "."c Or name(i) = " "c) Then
                        Return False
                    ElseIf name(i) = "."c Then
                        flag = 1
                    ElseIf name(i) = " "c Then
                        flag = 2
                    End If
                ElseIf flag = 1 Then
                    If Not (name(i) >= "a"c And name(i) <= "z"c) And Not name(i) = " "c Then
                        Return False
                    ElseIf name(i) >= "a"c And name(i) <= "z"c Then
                        flag = 0
                    ElseIf name(i) = " "c Then
                        flag = 2
                    End If
                Else
                    If Not (name(i) >= "a" And name(i) <= "z"c) Then
                        Return False
                    Else
                        flag = 0
                    End If
                End If
            Next

            Return True
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    'Validates the age (max age limit is kept 150)
    Public Function age_validator(ByVal age As String) As Boolean
        Try
            Dim i As Integer = 0
            If age.Length > 3 Or age.Length = 0 Then
                Return False
            End If
            If Not age.ToUpper = age.ToLower Then
                Return False
            End If
            For i = 0 To age.Length - 1
                If Not (age(i) >= "0"c And age(i) <= "9"c) Then
                    Return False
                End If
            Next

            Dim age_int As Integer = Convert.ToInt16(age)
            If age_int > 150 Then
                Return False
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
    'Validates the gender field 
    Public Function Gender_Validator(ByVal gender As String) As Boolean
        If gender = "male" Or gender = "female" Or gender = "others" Then
            Return True
        End If
        Return False
    End Function
    'Validates the mobile number field (the mobile number must conatin 10 numeric digits)
    Public Function Mobile_Validator(ByVal mobile As String) As Boolean
        Try
            'mobile = mobile.TrimStart("0"c)
            Dim i As Integer = 0
            If Not mobile.Length = 10 Then
                Return False
            End If
            For i = 0 To 9
                If Not (mobile(i) >= "0"c And mobile(i) <= "9"c) Then
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function
    'Validates if a number is valid decimal number
    Public Function Decimal_Validator(ByVal deci As String) As Boolean
        Try
            Dim i As Integer
            Dim count_deci As Integer = 0
            If Not deci.ToLower = deci.ToUpper Or deci.Length = 0 Then
                Return False
            End If
            For i = 0 To deci.Length - 1
                If Not (deci(i) >= "0"c And deci(i) <= "9"c) And Not deci(i) = "."c Then
                    Return False
                End If
                If deci(i) = "."c Then
                    count_deci = count_deci + 1
                    If count_deci >= 2 Then
                        Return False
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    'Validates If a number is valid numeric
    Public Function Number_Validator(ByVal num As String) As Boolean
        Try
            If num.ToLower <> num.ToUpper Or num.Length = 0 Then
                Return False
            End If
            Dim i As Integer
            For i = 0 To num.Length - 1
                If num(i) >= "0"c And num(i) < "9"c Then
                Else
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
        End Try
        Return False
    End Function

    Dim smallSize As Size = New Size(800, 600)
    Dim middleSize As Size = New Size(1440, 900)
    Dim largeSize As Size = New Size(1900, 1200)

    Private Function AutoSuitableScreen() As ScreenSize
        Dim enumSize As ScreenSize = New ScreenSize()
        Dim Primary As Size = Screen.PrimaryScreen.WorkingArea.Size
        If Primary.Width * Primary.Height <= smallSize.Width * smallSize.Height Then
            enumSize = ScreenSize.Small
        ElseIf smallSize.Width * smallSize.Height < Primary.Width * Primary.Height AndAlso
            Primary.Width * Primary.Height <= middleSize.Width * middleSize.Height Then
            enumSize = ScreenSize.Middle
        ElseIf (middleSize.Width * middleSize.Height < Primary.Width * Primary.Height AndAlso
                Primary.Width * Primary.Height <= largeSize.Width * largeSize.Height) Then
            enumSize = ScreenSize.Large
        Else
            enumSize = ScreenSize.Extra
        End If
        Return enumSize
    End Function


    Private Sub AutoLayout(size As ScreenSize)

        Select Case size
            Case ScreenSize.Small
                AutoSizeForm(smallSize)
                'Me.FontHeight = 10
            Case ScreenSize.Middle
                AutoSizeForm(middleSize)
                'Me.FontHeight = 14
            Case ScreenSize.Large
                AutoSizeForm(largeSize)
                'Me.FontHeight = 20

            Case ScreenSize.Extra
                AutoSizeForm(Screen.PrimaryScreen.WorkingArea.Size)
                'Me.FontHeight = 24
        End Select

    End Sub

    'model
    Private Sub AutoSizeForm(size As Size)
        Dim Width As Int32 = size.Width
        Dim Height As Int32 = size.Height

        Me.Size = New Size(Width / 4, Height / 2)
        'setting control's location, size...
        Me.GroupBox1.Location = New Point(Width / 2, Height / 5) 'modify To your setting
        'Me.GroupBox1.Size = New Size(Width / 10, Height / 8) 'modify To your setting
        'Me.GroupBox1.Font = Me.Font
        '...
    End Sub
    Public Enum ScreenSize
        Small
        Middle
        Large
        Extra
    End Enum
End Class
