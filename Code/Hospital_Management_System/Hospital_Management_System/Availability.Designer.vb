<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Availability
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.ReceptionistBtn = New System.Windows.Forms.RadioButton()
        Me.NurseBtn = New System.Windows.Forms.RadioButton()
        Me.DoctorBtn = New System.Windows.Forms.RadioButton()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.NameSTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchResultGrid = New System.Windows.Forms.DataGridView()
        Me.DetailsBox = New System.Windows.Forms.GroupBox()
        Me.ShowAvailability = New System.Windows.Forms.Label()
        Me.DesignationTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.GenderTxt = New System.Windows.Forms.TextBox()
        Me.DOBTxt = New System.Windows.Forms.TextBox()
        Me.SIDTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetailsBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Staff Availability"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ClearBtn)
        Me.GroupBox1.Controls.Add(Me.ReceptionistBtn)
        Me.GroupBox1.Controls.Add(Me.NurseBtn)
        Me.GroupBox1.Controls.Add(Me.DoctorBtn)
        Me.GroupBox1.Controls.Add(Me.SearchBtn)
        Me.GroupBox1.Controls.Add(Me.NameSTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(116, 122)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(467, 103)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Staff Member"
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(350, 24)
        Me.ClearBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(100, 30)
        Me.ClearBtn.TabIndex = 8
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'ReceptionistBtn
        '
        Me.ReceptionistBtn.AutoSize = True
        Me.ReceptionistBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceptionistBtn.Location = New System.Drawing.Point(210, 68)
        Me.ReceptionistBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReceptionistBtn.Name = "ReceptionistBtn"
        Me.ReceptionistBtn.Size = New System.Drawing.Size(115, 20)
        Me.ReceptionistBtn.TabIndex = 7
        Me.ReceptionistBtn.TabStop = True
        Me.ReceptionistBtn.Text = "Receptionist"
        Me.ReceptionistBtn.UseVisualStyleBackColor = True
        '
        'NurseBtn
        '
        Me.NurseBtn.AutoSize = True
        Me.NurseBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NurseBtn.Location = New System.Drawing.Point(130, 68)
        Me.NurseBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NurseBtn.Name = "NurseBtn"
        Me.NurseBtn.Size = New System.Drawing.Size(68, 20)
        Me.NurseBtn.TabIndex = 6
        Me.NurseBtn.TabStop = True
        Me.NurseBtn.Text = "Nurse"
        Me.NurseBtn.UseVisualStyleBackColor = True
        '
        'DoctorBtn
        '
        Me.DoctorBtn.AutoSize = True
        Me.DoctorBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorBtn.Location = New System.Drawing.Point(49, 68)
        Me.DoctorBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DoctorBtn.Name = "DoctorBtn"
        Me.DoctorBtn.Size = New System.Drawing.Size(73, 20)
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
        Me.SearchBtn.Location = New System.Drawing.Point(350, 59)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(100, 30)
        Me.SearchBtn.TabIndex = 4
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'NameSTxt
        '
        Me.NameSTxt.Location = New System.Drawing.Point(90, 36)
        Me.NameSTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NameSTxt.Name = "NameSTxt"
        Me.NameSTxt.Size = New System.Drawing.Size(220, 24)
        Me.NameSTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchResultGrid
        '
        Me.SearchResultGrid.BackgroundColor = System.Drawing.Color.White
        Me.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchResultGrid.Location = New System.Drawing.Point(44, 240)
        Me.SearchResultGrid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchResultGrid.Name = "SearchResultGrid"
        Me.SearchResultGrid.RowTemplate.Height = 24
        Me.SearchResultGrid.Size = New System.Drawing.Size(640, 137)
        Me.SearchResultGrid.TabIndex = 8
        '
        'DetailsBox
        '
        Me.DetailsBox.Controls.Add(Me.ShowAvailability)
        Me.DetailsBox.Controls.Add(Me.DesignationTxt)
        Me.DetailsBox.Controls.Add(Me.Label3)
        Me.DetailsBox.Controls.Add(Me.MobileTxt)
        Me.DetailsBox.Controls.Add(Me.Label9)
        Me.DetailsBox.Controls.Add(Me.NameTxt)
        Me.DetailsBox.Controls.Add(Me.Label8)
        Me.DetailsBox.Controls.Add(Me.AddressTxt)
        Me.DetailsBox.Controls.Add(Me.GenderTxt)
        Me.DetailsBox.Controls.Add(Me.DOBTxt)
        Me.DetailsBox.Controls.Add(Me.SIDTxt)
        Me.DetailsBox.Controls.Add(Me.Label7)
        Me.DetailsBox.Controls.Add(Me.Label6)
        Me.DetailsBox.Controls.Add(Me.Label5)
        Me.DetailsBox.Controls.Add(Me.Label4)
        Me.DetailsBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsBox.Location = New System.Drawing.Point(116, 382)
        Me.DetailsBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DetailsBox.Name = "DetailsBox"
        Me.DetailsBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DetailsBox.Size = New System.Drawing.Size(467, 254)
        Me.DetailsBox.TabIndex = 9
        Me.DetailsBox.TabStop = False
        Me.DetailsBox.Text = "Staff Member Detail"
        '
        'ShowAvailability
        '
        Me.ShowAvailability.BackColor = System.Drawing.Color.Red
        Me.ShowAvailability.Location = New System.Drawing.Point(292, 20)
        Me.ShowAvailability.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ShowAvailability.Name = "ShowAvailability"
        Me.ShowAvailability.Size = New System.Drawing.Size(164, 19)
        Me.ShowAvailability.TabIndex = 15
        Me.ShowAvailability.Text = "UnAvailable"
        Me.ShowAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesignationTxt
        '
        Me.DesignationTxt.Location = New System.Drawing.Point(321, 58)
        Me.DesignationTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DesignationTxt.Name = "DesignationTxt"
        Me.DesignationTxt.ReadOnly = True
        Me.DesignationTxt.Size = New System.Drawing.Size(135, 24)
        Me.DesignationTxt.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Designation : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MobileTxt
        '
        Me.MobileTxt.Location = New System.Drawing.Point(93, 137)
        Me.MobileTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.ReadOnly = True
        Me.MobileTxt.Size = New System.Drawing.Size(204, 24)
        Me.MobileTxt.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 137)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 23)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Phone : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(93, 100)
        Me.NameTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.ReadOnly = True
        Me.NameTxt.Size = New System.Drawing.Size(204, 24)
        Me.NameTxt.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 101)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 23)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Name : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(93, 176)
        Me.AddressTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.ReadOnly = True
        Me.AddressTxt.Size = New System.Drawing.Size(363, 74)
        Me.AddressTxt.TabIndex = 7
        '
        'GenderTxt
        '
        Me.GenderTxt.Location = New System.Drawing.Point(380, 132)
        Me.GenderTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.ReadOnly = True
        Me.GenderTxt.Size = New System.Drawing.Size(76, 24)
        Me.GenderTxt.TabIndex = 6
        '
        'DOBTxt
        '
        Me.DOBTxt.Location = New System.Drawing.Point(380, 95)
        Me.DOBTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.ReadOnly = True
        Me.DOBTxt.Size = New System.Drawing.Size(76, 24)
        Me.DOBTxt.TabIndex = 5
        '
        'SIDTxt
        '
        Me.SIDTxt.Location = New System.Drawing.Point(93, 63)
        Me.SIDTxt.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SIDTxt.Name = "SIDTxt"
        Me.SIDTxt.ReadOnly = True
        Me.SIDTxt.Size = New System.Drawing.Size(76, 24)
        Me.SIDTxt.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 21)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Address : "
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(313, 137)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 21)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gender : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 100)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "D.O.B. :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SID :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.useful_pic
        Me.PictureBox1.Location = New System.Drawing.Point(195, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Availability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.DetailsBox)
        Me.Controls.Add(Me.SearchResultGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Availability"
        Me.Size = New System.Drawing.Size(733, 653)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetailsBox.ResumeLayout(False)
        Me.DetailsBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents NameSTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NurseBtn As System.Windows.Forms.RadioButton
    Friend WithEvents DoctorBtn As System.Windows.Forms.RadioButton
    Friend WithEvents ReceptionistBtn As System.Windows.Forms.RadioButton
    Friend WithEvents SearchResultGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DetailsBox As System.Windows.Forms.GroupBox
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents GenderTxt As System.Windows.Forms.TextBox
    Friend WithEvents DOBTxt As System.Windows.Forms.TextBox
    Friend WithEvents SIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DesignationTxt As System.Windows.Forms.TextBox
    Friend WithEvents ShowAvailability As System.Windows.Forms.Label
    Friend WithEvents ClearBtn As System.Windows.Forms.Button

End Class
