<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStaff_Admin
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Receptionistbtn = New System.Windows.Forms.RadioButton()
        Me.NurseBtn = New System.Windows.Forms.RadioButton()
        Me.DoctorBtn = New System.Windows.Forms.RadioButton()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.NameSTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchResultGrid = New System.Windows.Forms.DataGridView()
        Me.DetailsBox = New System.Windows.Forms.GroupBox()
        Me.DOBTxt = New System.Windows.Forms.DateTimePicker()
        Me.WorkShiftTxt = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SIDTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ShowAvailability = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EmailTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.DesignationTxt = New System.Windows.Forms.ComboBox()
        Me.GenderTxt = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.useful_pic
        Me.PictureBox1.Location = New System.Drawing.Point(242, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 47)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Update Staff"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ClearBtn)
        Me.GroupBox1.Controls.Add(Me.Receptionistbtn)
        Me.GroupBox1.Controls.Add(Me.NurseBtn)
        Me.GroupBox1.Controls.Add(Me.DoctorBtn)
        Me.GroupBox1.Controls.Add(Me.SearchBtn)
        Me.GroupBox1.Controls.Add(Me.NameSTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(155, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 127)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Staff Member"
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(467, 30)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(133, 37)
        Me.ClearBtn.TabIndex = 8
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'Receptionistbtn
        '
        Me.Receptionistbtn.AutoSize = True
        Me.Receptionistbtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receptionistbtn.Location = New System.Drawing.Point(280, 84)
        Me.Receptionistbtn.Name = "Receptionistbtn"
        Me.Receptionistbtn.Size = New System.Drawing.Size(132, 23)
        Me.Receptionistbtn.TabIndex = 7
        Me.Receptionistbtn.TabStop = True
        Me.Receptionistbtn.Text = "Receptionist"
        Me.Receptionistbtn.UseVisualStyleBackColor = True
        '
        'NurseBtn
        '
        Me.NurseBtn.AutoSize = True
        Me.NurseBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NurseBtn.Location = New System.Drawing.Point(174, 84)
        Me.NurseBtn.Name = "NurseBtn"
        Me.NurseBtn.Size = New System.Drawing.Size(78, 23)
        Me.NurseBtn.TabIndex = 6
        Me.NurseBtn.TabStop = True
        Me.NurseBtn.Text = "Nurse"
        Me.NurseBtn.UseVisualStyleBackColor = True
        '
        'DoctorBtn
        '
        Me.DoctorBtn.AutoSize = True
        Me.DoctorBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorBtn.Location = New System.Drawing.Point(65, 84)
        Me.DoctorBtn.Name = "DoctorBtn"
        Me.DoctorBtn.Size = New System.Drawing.Size(87, 23)
        Me.DoctorBtn.TabIndex = 5
        Me.DoctorBtn.TabStop = True
        Me.DoctorBtn.Text = "Doctor"
        Me.DoctorBtn.UseVisualStyleBackColor = True
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.SearchBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(467, 73)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(133, 37)
        Me.SearchBtn.TabIndex = 4
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'NameSTxt
        '
        Me.NameSTxt.Location = New System.Drawing.Point(120, 44)
        Me.NameSTxt.Name = "NameSTxt"
        Me.NameSTxt.Size = New System.Drawing.Size(292, 28)
        Me.NameSTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchResultGrid
        '
        Me.SearchResultGrid.BackgroundColor = System.Drawing.Color.White
        Me.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchResultGrid.Location = New System.Drawing.Point(59, 295)
        Me.SearchResultGrid.Name = "SearchResultGrid"
        Me.SearchResultGrid.RowTemplate.Height = 24
        Me.SearchResultGrid.Size = New System.Drawing.Size(853, 169)
        Me.SearchResultGrid.TabIndex = 9
        '
        'DetailsBox
        '
        Me.DetailsBox.Controls.Add(Me.GenderTxt)
        Me.DetailsBox.Controls.Add(Me.DesignationTxt)
        Me.DetailsBox.Controls.Add(Me.DOBTxt)
        Me.DetailsBox.Controls.Add(Me.WorkShiftTxt)
        Me.DetailsBox.Controls.Add(Me.Label12)
        Me.DetailsBox.Controls.Add(Me.SIDTxt)
        Me.DetailsBox.Controls.Add(Me.Label11)
        Me.DetailsBox.Controls.Add(Me.ShowAvailability)
        Me.DetailsBox.Controls.Add(Me.Label3)
        Me.DetailsBox.Controls.Add(Me.MobileTxt)
        Me.DetailsBox.Controls.Add(Me.Label9)
        Me.DetailsBox.Controls.Add(Me.EmailTxt)
        Me.DetailsBox.Controls.Add(Me.Label8)
        Me.DetailsBox.Controls.Add(Me.AddressTxt)
        Me.DetailsBox.Controls.Add(Me.NameTxt)
        Me.DetailsBox.Controls.Add(Me.Label7)
        Me.DetailsBox.Controls.Add(Me.Label6)
        Me.DetailsBox.Controls.Add(Me.Label5)
        Me.DetailsBox.Controls.Add(Me.Label4)
        Me.DetailsBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsBox.Location = New System.Drawing.Point(79, 470)
        Me.DetailsBox.Name = "DetailsBox"
        Me.DetailsBox.Size = New System.Drawing.Size(699, 313)
        Me.DetailsBox.TabIndex = 10
        Me.DetailsBox.TabStop = False
        Me.DetailsBox.Text = "Staff Member Detail"
        '
        'DOBTxt
        '
        Me.DOBTxt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBTxt.Location = New System.Drawing.Point(505, 118)
        Me.DOBTxt.MaxDate = New Date(2019, 2, 12, 0, 0, 0, 0)
        Me.DOBTxt.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.Size = New System.Drawing.Size(171, 28)
        Me.DOBTxt.TabIndex = 18
        Me.DOBTxt.Value = New Date(2019, 2, 12, 0, 0, 0, 0)
        '
        'WorkShiftTxt
        '
        Me.WorkShiftTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WorkShiftTxt.FormattingEnabled = True
        Me.WorkShiftTxt.Items.AddRange(New Object() {"Day", "Night"})
        Me.WorkShiftTxt.Location = New System.Drawing.Point(542, 217)
        Me.WorkShiftTxt.Name = "WorkShiftTxt"
        Me.WorkShiftTxt.Size = New System.Drawing.Size(134, 30)
        Me.WorkShiftTxt.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(417, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 26)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Work Shift : "
        '
        'SIDTxt
        '
        Me.SIDTxt.Location = New System.Drawing.Point(124, 36)
        Me.SIDTxt.Name = "SIDTxt"
        Me.SIDTxt.ReadOnly = True
        Me.SIDTxt.Size = New System.Drawing.Size(204, 28)
        Me.SIDTxt.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 25)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "SID :"
        '
        'ShowAvailability
        '
        Me.ShowAvailability.BackColor = System.Drawing.Color.Red
        Me.ShowAvailability.Location = New System.Drawing.Point(450, 24)
        Me.ShowAvailability.Name = "ShowAvailability"
        Me.ShowAvailability.Size = New System.Drawing.Size(204, 23)
        Me.ShowAvailability.TabIndex = 15
        Me.ShowAvailability.Text = "UnAvailable"
        Me.ShowAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 28)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Designation : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MobileTxt
        '
        Me.MobileTxt.Location = New System.Drawing.Point(124, 169)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(271, 28)
        Me.MobileTxt.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 28)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Phone : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmailTxt
        '
        Me.EmailTxt.Location = New System.Drawing.Point(124, 123)
        Me.EmailTxt.Name = "EmailTxt"
        Me.EmailTxt.Size = New System.Drawing.Size(271, 28)
        Me.EmailTxt.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 28)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Name : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(124, 217)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(271, 90)
        Me.AddressTxt.TabIndex = 7
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(124, 77)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(237, 28)
        Me.NameTxt.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 26)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Address : "
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(417, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gender : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "D.O.B. :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Email :"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.UpdateBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.Location = New System.Drawing.Point(790, 608)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(122, 33)
        Me.UpdateBtn.TabIndex = 16
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.DeleteBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(790, 680)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(122, 33)
        Me.DeleteBtn.TabIndex = 17
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'DesignationTxt
        '
        Me.DesignationTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DesignationTxt.FormattingEnabled = True
        Me.DesignationTxt.Items.AddRange(New Object() {"Doctor", "Nurse", "Receptionist", "Admin"})
        Me.DesignationTxt.Location = New System.Drawing.Point(505, 72)
        Me.DesignationTxt.Name = "DesignationTxt"
        Me.DesignationTxt.Size = New System.Drawing.Size(170, 30)
        Me.DesignationTxt.TabIndex = 20
        '
        'GenderTxt
        '
        Me.GenderTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderTxt.FormattingEnabled = True
        Me.GenderTxt.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.GenderTxt.Location = New System.Drawing.Point(521, 163)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.Size = New System.Drawing.Size(156, 30)
        Me.GenderTxt.TabIndex = 21
        '
        'UpdateStaff_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.DetailsBox)
        Me.Controls.Add(Me.SearchResultGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UpdateStaff_Admin"
        Me.Size = New System.Drawing.Size(977, 804)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsBox.ResumeLayout(False)
        Me.DetailsBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents Receptionistbtn As System.Windows.Forms.RadioButton
    Friend WithEvents NurseBtn As System.Windows.Forms.RadioButton
    Friend WithEvents DoctorBtn As System.Windows.Forms.RadioButton
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents NameSTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SearchResultGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DetailsBox As System.Windows.Forms.GroupBox
    Friend WithEvents ShowAvailability As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EmailTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents WorkShiftTxt As System.Windows.Forms.ComboBox
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents DOBTxt As System.Windows.Forms.DateTimePicker
    Friend WithEvents DesignationTxt As System.Windows.Forms.ComboBox
    Friend WithEvents GenderTxt As System.Windows.Forms.ComboBox

End Class
