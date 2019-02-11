<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.AdminPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.EditProfileBtn = New System.Windows.Forms.Button()
        Me.PersonalInfoPanel2 = New System.Windows.Forms.Panel()
        Me.PersonalInfoPanel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.UpdateStaffBtn = New System.Windows.Forms.Button()
        Me.AddStaffBtn = New System.Windows.Forms.Button()
        Me.StaffPanel2 = New System.Windows.Forms.Panel()
        Me.StaffPanel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SearchPtntBtn = New System.Windows.Forms.Button()
        Me.PatientPanel2 = New System.Windows.Forms.Panel()
        Me.PatientPanel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BloodAvailabilityBtn = New System.Windows.Forms.Button()
        Me.SearchRecieverBtn = New System.Windows.Forms.Button()
        Me.SearchDonorBtn = New System.Windows.Forms.Button()
        Me.BloodBankPanel2 = New System.Windows.Forms.Panel()
        Me.BloodBankPanel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminPanel
        '
        Me.AdminPanel.BackColor = System.Drawing.Color.White
        Me.AdminPanel.Location = New System.Drawing.Point(537, 115)
        Me.AdminPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AdminPanel.Name = "AdminPanel"
        Me.AdminPanel.Size = New System.Drawing.Size(733, 653)
        Me.AdminPanel.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Location = New System.Drawing.Point(94, 115)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 653)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LogoutBtn)
        Me.GroupBox5.Controls.Add(Me.EditProfileBtn)
        Me.GroupBox5.Controls.Add(Me.PersonalInfoPanel2)
        Me.GroupBox5.Controls.Add(Me.PersonalInfoPanel1)
        Me.GroupBox5.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(10, 470)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(266, 144)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Personal Info"
        '
        'LogoutBtn
        '
        Me.LogoutBtn.FlatAppearance.BorderSize = 0
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.Location = New System.Drawing.Point(15, 83)
        Me.LogoutBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(237, 41)
        Me.LogoutBtn.TabIndex = 6
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'EditProfileBtn
        '
        Me.EditProfileBtn.FlatAppearance.BorderSize = 0
        Me.EditProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditProfileBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditProfileBtn.Location = New System.Drawing.Point(15, 42)
        Me.EditProfileBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.EditProfileBtn.Name = "EditProfileBtn"
        Me.EditProfileBtn.Size = New System.Drawing.Size(237, 41)
        Me.EditProfileBtn.TabIndex = 5
        Me.EditProfileBtn.Text = "Edit Profile"
        Me.EditProfileBtn.UseVisualStyleBackColor = True
        '
        'PersonalInfoPanel2
        '
        Me.PersonalInfoPanel2.BackColor = System.Drawing.Color.Transparent
        Me.PersonalInfoPanel2.Location = New System.Drawing.Point(233, 42)
        Me.PersonalInfoPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PersonalInfoPanel2.Name = "PersonalInfoPanel2"
        Me.PersonalInfoPanel2.Size = New System.Drawing.Size(33, 41)
        Me.PersonalInfoPanel2.TabIndex = 16
        '
        'PersonalInfoPanel1
        '
        Me.PersonalInfoPanel1.BackColor = System.Drawing.Color.Transparent
        Me.PersonalInfoPanel1.Location = New System.Drawing.Point(0, 42)
        Me.PersonalInfoPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PersonalInfoPanel1.Name = "PersonalInfoPanel1"
        Me.PersonalInfoPanel1.Size = New System.Drawing.Size(33, 41)
        Me.PersonalInfoPanel1.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.UpdateStaffBtn)
        Me.GroupBox3.Controls.Add(Me.AddStaffBtn)
        Me.GroupBox3.Controls.Add(Me.StaffPanel2)
        Me.GroupBox3.Controls.Add(Me.StaffPanel1)
        Me.GroupBox3.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 131)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(266, 134)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Staff"
        '
        'UpdateStaffBtn
        '
        Me.UpdateStaffBtn.FlatAppearance.BorderSize = 0
        Me.UpdateStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateStaffBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateStaffBtn.Location = New System.Drawing.Point(15, 73)
        Me.UpdateStaffBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.UpdateStaffBtn.Name = "UpdateStaffBtn"
        Me.UpdateStaffBtn.Size = New System.Drawing.Size(237, 41)
        Me.UpdateStaffBtn.TabIndex = 7
        Me.UpdateStaffBtn.Text = "Update Staff"
        Me.UpdateStaffBtn.UseVisualStyleBackColor = True
        '
        'AddStaffBtn
        '
        Me.AddStaffBtn.FlatAppearance.BorderSize = 0
        Me.AddStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddStaffBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStaffBtn.Location = New System.Drawing.Point(15, 30)
        Me.AddStaffBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.AddStaffBtn.Name = "AddStaffBtn"
        Me.AddStaffBtn.Size = New System.Drawing.Size(237, 41)
        Me.AddStaffBtn.TabIndex = 4
        Me.AddStaffBtn.Text = "Add Staff"
        Me.AddStaffBtn.UseVisualStyleBackColor = True
        '
        'StaffPanel2
        '
        Me.StaffPanel2.BackColor = System.Drawing.Color.Transparent
        Me.StaffPanel2.Location = New System.Drawing.Point(233, 30)
        Me.StaffPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StaffPanel2.Name = "StaffPanel2"
        Me.StaffPanel2.Size = New System.Drawing.Size(33, 41)
        Me.StaffPanel2.TabIndex = 6
        '
        'StaffPanel1
        '
        Me.StaffPanel1.BackColor = System.Drawing.Color.Transparent
        Me.StaffPanel1.Location = New System.Drawing.Point(0, 30)
        Me.StaffPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StaffPanel1.Name = "StaffPanel1"
        Me.StaffPanel1.Size = New System.Drawing.Size(33, 41)
        Me.StaffPanel1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.SearchPtntBtn)
        Me.GroupBox2.Controls.Add(Me.PatientPanel2)
        Me.GroupBox2.Controls.Add(Me.PatientPanel1)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 16)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(266, 93)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient"
        '
        'SearchPtntBtn
        '
        Me.SearchPtntBtn.BackColor = System.Drawing.Color.White
        Me.SearchPtntBtn.FlatAppearance.BorderSize = 0
        Me.SearchPtntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchPtntBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchPtntBtn.Location = New System.Drawing.Point(19, 35)
        Me.SearchPtntBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.SearchPtntBtn.Name = "SearchPtntBtn"
        Me.SearchPtntBtn.Size = New System.Drawing.Size(233, 41)
        Me.SearchPtntBtn.TabIndex = 1
        Me.SearchPtntBtn.Text = "Search Patient"
        Me.SearchPtntBtn.UseVisualStyleBackColor = False
        '
        'PatientPanel2
        '
        Me.PatientPanel2.BackColor = System.Drawing.Color.Transparent
        Me.PatientPanel2.Location = New System.Drawing.Point(233, 35)
        Me.PatientPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PatientPanel2.Name = "PatientPanel2"
        Me.PatientPanel2.Size = New System.Drawing.Size(33, 41)
        Me.PatientPanel2.TabIndex = 6
        '
        'PatientPanel1
        '
        Me.PatientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.PatientPanel1.Location = New System.Drawing.Point(4, 35)
        Me.PatientPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PatientPanel1.Name = "PatientPanel1"
        Me.PatientPanel1.Size = New System.Drawing.Size(33, 41)
        Me.PatientPanel1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BloodAvailabilityBtn)
        Me.GroupBox4.Controls.Add(Me.SearchRecieverBtn)
        Me.GroupBox4.Controls.Add(Me.SearchDonorBtn)
        Me.GroupBox4.Controls.Add(Me.BloodBankPanel2)
        Me.GroupBox4.Controls.Add(Me.BloodBankPanel1)
        Me.GroupBox4.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(10, 280)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(266, 171)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Blood Bank"
        '
        'BloodAvailabilityBtn
        '
        Me.BloodAvailabilityBtn.FlatAppearance.BorderSize = 0
        Me.BloodAvailabilityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BloodAvailabilityBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodAvailabilityBtn.Location = New System.Drawing.Point(15, 112)
        Me.BloodAvailabilityBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.BloodAvailabilityBtn.Name = "BloodAvailabilityBtn"
        Me.BloodAvailabilityBtn.Size = New System.Drawing.Size(237, 41)
        Me.BloodAvailabilityBtn.TabIndex = 7
        Me.BloodAvailabilityBtn.Text = "Blood Availability"
        Me.BloodAvailabilityBtn.UseVisualStyleBackColor = True
        '
        'SearchRecieverBtn
        '
        Me.SearchRecieverBtn.FlatAppearance.BorderSize = 0
        Me.SearchRecieverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchRecieverBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchRecieverBtn.Location = New System.Drawing.Point(15, 72)
        Me.SearchRecieverBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.SearchRecieverBtn.Name = "SearchRecieverBtn"
        Me.SearchRecieverBtn.Size = New System.Drawing.Size(237, 41)
        Me.SearchRecieverBtn.TabIndex = 6
        Me.SearchRecieverBtn.Text = "Search Reciever"
        Me.SearchRecieverBtn.UseVisualStyleBackColor = True
        '
        'SearchDonorBtn
        '
        Me.SearchDonorBtn.FlatAppearance.BorderSize = 0
        Me.SearchDonorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchDonorBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDonorBtn.Location = New System.Drawing.Point(15, 31)
        Me.SearchDonorBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.SearchDonorBtn.Name = "SearchDonorBtn"
        Me.SearchDonorBtn.Size = New System.Drawing.Size(237, 41)
        Me.SearchDonorBtn.TabIndex = 5
        Me.SearchDonorBtn.Text = "Search Donor"
        Me.SearchDonorBtn.UseVisualStyleBackColor = True
        '
        'BloodBankPanel2
        '
        Me.BloodBankPanel2.BackColor = System.Drawing.Color.Transparent
        Me.BloodBankPanel2.Location = New System.Drawing.Point(233, 31)
        Me.BloodBankPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BloodBankPanel2.Name = "BloodBankPanel2"
        Me.BloodBankPanel2.Size = New System.Drawing.Size(33, 41)
        Me.BloodBankPanel2.TabIndex = 15
        '
        'BloodBankPanel1
        '
        Me.BloodBankPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BloodBankPanel1.Location = New System.Drawing.Point(0, 31)
        Me.BloodBankPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BloodBankPanel1.Name = "BloodBankPanel1"
        Me.BloodBankPanel1.Size = New System.Drawing.Size(33, 41)
        Me.BloodBankPanel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.Hospital_blue_icon
        Me.PictureBox1.Location = New System.Drawing.Point(230, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(321, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(684, 55)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Golisano's Hospital Of Florida"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1488, 774)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AdminPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Staff Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdminPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LogoutBtn As System.Windows.Forms.Button
    Friend WithEvents EditProfileBtn As System.Windows.Forms.Button
    Friend WithEvents PersonalInfoPanel2 As System.Windows.Forms.Panel
    Friend WithEvents PersonalInfoPanel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents UpdateStaffBtn As System.Windows.Forms.Button
    Friend WithEvents AddStaffBtn As System.Windows.Forms.Button
    Friend WithEvents StaffPanel2 As System.Windows.Forms.Panel
    Friend WithEvents StaffPanel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchPtntBtn As System.Windows.Forms.Button
    Friend WithEvents PatientPanel2 As System.Windows.Forms.Panel
    Friend WithEvents PatientPanel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BloodAvailabilityBtn As System.Windows.Forms.Button
    Friend WithEvents SearchRecieverBtn As System.Windows.Forms.Button
    Friend WithEvents SearchDonorBtn As System.Windows.Forms.Button
    Friend WithEvents BloodBankPanel2 As System.Windows.Forms.Panel
    Friend WithEvents BloodBankPanel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
