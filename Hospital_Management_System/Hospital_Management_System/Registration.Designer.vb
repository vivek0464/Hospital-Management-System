<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DOBTxt = New System.Windows.Forms.DateTimePicker()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.GenderTxt = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.SuccessMsg = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Registration"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DOBTxt)
        Me.GroupBox2.Controls.Add(Me.AddressTxt)
        Me.GroupBox2.Controls.Add(Me.MobileTxt)
        Me.GroupBox2.Controls.Add(Me.GenderTxt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.NameTxt)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(261, 235)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 394)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient's Information"
        '
        'DOBTxt
        '
        Me.DOBTxt.CustomFormat = ""
        Me.DOBTxt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBTxt.Location = New System.Drawing.Point(108, 110)
        Me.DOBTxt.MaxDate = New Date(2019, 2, 11, 0, 0, 0, 0)
        Me.DOBTxt.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.Size = New System.Drawing.Size(178, 29)
        Me.DOBTxt.TabIndex = 14
        Me.DOBTxt.Value = New Date(2019, 2, 11, 0, 0, 0, 0)
        '
        'AddressTxt
        '
        Me.AddressTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTxt.Location = New System.Drawing.Point(110, 256)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(316, 91)
        Me.AddressTxt.TabIndex = 13
        '
        'MobileTxt
        '
        Me.MobileTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileTxt.Location = New System.Drawing.Point(108, 203)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(201, 26)
        Me.MobileTxt.TabIndex = 12
        '
        'GenderTxt
        '
        Me.GenderTxt.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "Others"})
        Me.GenderTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.GenderTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTxt.FormattingEnabled = True
        Me.GenderTxt.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.GenderTxt.Location = New System.Drawing.Point(108, 151)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.Size = New System.Drawing.Size(112, 27)
        Me.GenderTxt.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mobile :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DOB :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gender :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.Location = New System.Drawing.Point(108, 55)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(318, 26)
        Me.NameTxt.TabIndex = 0
        '
        'RegisterBtn
        '
        Me.RegisterBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.RegisterBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterBtn.ForeColor = System.Drawing.Color.White
        Me.RegisterBtn.Location = New System.Drawing.Point(600, 661)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(147, 47)
        Me.RegisterBtn.TabIndex = 4
        Me.RegisterBtn.Text = "Register"
        Me.RegisterBtn.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(261, 661)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(146, 47)
        Me.ClearBtn.TabIndex = 5
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'SuccessMsg
        '
        Me.SuccessMsg.BackColor = System.Drawing.Color.Olive
        Me.SuccessMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuccessMsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SuccessMsg.Location = New System.Drawing.Point(305, 156)
        Me.SuccessMsg.Name = "SuccessMsg"
        Me.SuccessMsg.Size = New System.Drawing.Size(401, 44)
        Me.SuccessMsg.TabIndex = 6
        Me.SuccessMsg.Text = "Patient Successfully registered"
        Me.SuccessMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SuccessMsg.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.patient_pic
        Me.PictureBox1.Location = New System.Drawing.Point(281, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SuccessMsg)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.RegisterBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registration"
        Me.Size = New System.Drawing.Size(977, 804)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents RegisterBtn As System.Windows.Forms.Button
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents GenderTxt As System.Windows.Forms.ComboBox
    Friend WithEvents SuccessMsg As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DOBTxt As System.Windows.Forms.DateTimePicker

End Class
