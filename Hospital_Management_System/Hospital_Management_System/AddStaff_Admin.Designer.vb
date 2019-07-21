<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaff_Admin
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuccessMsg = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DOBTxt = New System.Windows.Forms.DateTimePicker()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DesignationTxt = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.WorkShiftTxt = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.doc_Pic
        Me.PictureBox1.Location = New System.Drawing.Point(245, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 47)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Add Staff"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SuccessMsg
        '
        Me.SuccessMsg.BackColor = System.Drawing.Color.Olive
        Me.SuccessMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuccessMsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SuccessMsg.Location = New System.Drawing.Point(305, 156)
        Me.SuccessMsg.Name = "SuccessMsg"
        Me.SuccessMsg.Size = New System.Drawing.Size(401, 44)
        Me.SuccessMsg.TabIndex = 12
        Me.SuccessMsg.Text = "Patient Successfully registered"
        Me.SuccessMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SuccessMsg.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DOBTxt)
        Me.GroupBox2.Controls.Add(Me.EmailTxt)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.DesignationTxt)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.WorkShiftTxt)
        Me.GroupBox2.Controls.Add(Me.Label7)
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
        Me.GroupBox2.Size = New System.Drawing.Size(486, 446)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient's Information"
        '
        'DOBTxt
        '
        Me.DOBTxt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBTxt.Location = New System.Drawing.Point(137, 102)
        Me.DOBTxt.MaxDate = New Date(2019, 2, 11, 0, 0, 0, 0)
        Me.DOBTxt.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.Size = New System.Drawing.Size(208, 29)
        Me.DOBTxt.TabIndex = 20
        Me.DOBTxt.Value = New Date(2019, 2, 11, 0, 0, 0, 0)
        '
        'EmailTxt
        '
        Me.EmailTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTxt.Location = New System.Drawing.Point(137, 307)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(324, 26)
        Me.EmailTxt.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 26)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Email :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesignationTxt
        '
        Me.DesignationTxt.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "Others"})
        Me.DesignationTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.DesignationTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesignationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DesignationTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesignationTxt.FormattingEnabled = True
        Me.DesignationTxt.Items.AddRange(New Object() {"Doctor", "Nurse", "Receptionist", "Admin"})
        Me.DesignationTxt.Location = New System.Drawing.Point(137, 262)
        Me.DesignationTxt.Name = "DesignationTxt"
        Me.DesignationTxt.Size = New System.Drawing.Size(147, 27)
        Me.DesignationTxt.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 26)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Designation :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WorkShiftTxt
        '
        Me.WorkShiftTxt.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female", "Others"})
        Me.WorkShiftTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.WorkShiftTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.WorkShiftTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WorkShiftTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkShiftTxt.FormattingEnabled = True
        Me.WorkShiftTxt.Items.AddRange(New Object() {"Day", "Night"})
        Me.WorkShiftTxt.Location = New System.Drawing.Point(137, 221)
        Me.WorkShiftTxt.Name = "WorkShiftTxt"
        Me.WorkShiftTxt.Size = New System.Drawing.Size(147, 27)
        Me.WorkShiftTxt.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 26)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Work Shift :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddressTxt
        '
        Me.AddressTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTxt.Location = New System.Drawing.Point(137, 349)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(324, 91)
        Me.AddressTxt.TabIndex = 13
        '
        'MobileTxt
        '
        Me.MobileTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileTxt.Location = New System.Drawing.Point(137, 147)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(208, 26)
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
        Me.GenderTxt.Location = New System.Drawing.Point(137, 182)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.Size = New System.Drawing.Size(130, 27)
        Me.GenderTxt.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mobile :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "D.O.B :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 182)
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
        Me.Label2.Size = New System.Drawing.Size(92, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.Location = New System.Drawing.Point(137, 55)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(324, 26)
        Me.NameTxt.TabIndex = 0
        '
        'RegisterBtn
        '
        Me.RegisterBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.RegisterBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterBtn.ForeColor = System.Drawing.Color.White
        Me.RegisterBtn.Location = New System.Drawing.Point(608, 703)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(139, 43)
        Me.RegisterBtn.TabIndex = 14
        Me.RegisterBtn.Text = "Register"
        Me.RegisterBtn.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(261, 703)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(143, 43)
        Me.ClearBtn.TabIndex = 15
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'AddStaff_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.RegisterBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SuccessMsg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AddStaff_Admin"
        Me.Size = New System.Drawing.Size(977, 804)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SuccessMsg As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents GenderTxt As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents WorkShiftTxt As System.Windows.Forms.ComboBox
    Friend WithEvents DesignationTxt As System.Windows.Forms.ComboBox
    Friend WithEvents RegisterBtn As System.Windows.Forms.Button
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EmailTxt As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DOBTxt As System.Windows.Forms.DateTimePicker

End Class
