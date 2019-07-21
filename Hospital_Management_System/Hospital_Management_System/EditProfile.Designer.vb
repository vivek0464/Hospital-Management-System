<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProfile
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SIDTxt = New System.Windows.Forms.TextBox()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GenderTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.DOBTxt = New System.Windows.Forms.TextBox()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.OldPasswdTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChangePasswdBtn = New System.Windows.Forms.Button()
        Me.NewPasswdTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 47)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Edit Profile"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SIDTxt)
        Me.GroupBox2.Controls.Add(Me.UpdateBtn)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.GenderTxt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.AddressTxt)
        Me.GroupBox2.Controls.Add(Me.MobileTxt)
        Me.GroupBox2.Controls.Add(Me.DOBTxt)
        Me.GroupBox2.Controls.Add(Me.NameTxt)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(261, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 418)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personal Information"
        '
        'SIDTxt
        '
        Me.SIDTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SIDTxt.Location = New System.Drawing.Point(135, 51)
        Me.SIDTxt.Name = "SIDTxt"
        Me.SIDTxt.ReadOnly = True
        Me.SIDTxt.Size = New System.Drawing.Size(91, 26)
        Me.SIDTxt.TabIndex = 12
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.UpdateBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.Location = New System.Drawing.Point(311, 372)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(133, 37)
        Me.UpdateBtn.TabIndex = 9
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "SID :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GenderTxt
        '
        Me.GenderTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTxt.Location = New System.Drawing.Point(348, 147)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.ReadOnly = True
        Me.GenderTxt.Size = New System.Drawing.Size(96, 26)
        Me.GenderTxt.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mobile :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "D.O.B  :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gender :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddressTxt
        '
        Me.AddressTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTxt.Location = New System.Drawing.Point(135, 269)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(309, 97)
        Me.AddressTxt.TabIndex = 4
        '
        'MobileTxt
        '
        Me.MobileTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileTxt.Location = New System.Drawing.Point(135, 211)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(204, 26)
        Me.MobileTxt.TabIndex = 2
        '
        'DOBTxt
        '
        Me.DOBTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBTxt.Location = New System.Drawing.Point(135, 148)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.ReadOnly = True
        Me.DOBTxt.Size = New System.Drawing.Size(128, 26)
        Me.DOBTxt.TabIndex = 1
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.Location = New System.Drawing.Point(135, 98)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.ReadOnly = True
        Me.NameTxt.Size = New System.Drawing.Size(309, 26)
        Me.NameTxt.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(197, 110)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(163, 23)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'OldPasswdTxt
        '
        Me.OldPasswdTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldPasswdTxt.Location = New System.Drawing.Point(197, 36)
        Me.OldPasswdTxt.Name = "OldPasswdTxt"
        Me.OldPasswdTxt.Size = New System.Drawing.Size(247, 26)
        Me.OldPasswdTxt.TabIndex = 14
        Me.OldPasswdTxt.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 26)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Old Password :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChangePasswdBtn)
        Me.GroupBox1.Controls.Add(Me.NewPasswdTxt)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.OldPasswdTxt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(261, 591)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 178)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Password"
        '
        'ChangePasswdBtn
        '
        Me.ChangePasswdBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ChangePasswdBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePasswdBtn.ForeColor = System.Drawing.Color.White
        Me.ChangePasswdBtn.Location = New System.Drawing.Point(272, 135)
        Me.ChangePasswdBtn.Name = "ChangePasswdBtn"
        Me.ChangePasswdBtn.Size = New System.Drawing.Size(172, 37)
        Me.ChangePasswdBtn.TabIndex = 17
        Me.ChangePasswdBtn.Text = "Change Password"
        Me.ChangePasswdBtn.UseVisualStyleBackColor = False
        '
        'NewPasswdTxt
        '
        Me.NewPasswdTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswdTxt.Location = New System.Drawing.Point(197, 73)
        Me.NewPasswdTxt.Name = "NewPasswdTxt"
        Me.NewPasswdTxt.Size = New System.Drawing.Size(247, 26)
        Me.NewPasswdTxt.TabIndex = 16
        Me.NewPasswdTxt.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 26)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "New Password :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.edit_prof
        Me.PictureBox1.Location = New System.Drawing.Point(281, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'EditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditProfile"
        Me.Size = New System.Drawing.Size(977, 804)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents DOBTxt As System.Windows.Forms.TextBox
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GenderTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents OldPasswdTxt As System.Windows.Forms.TextBox
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents NewPasswdTxt As System.Windows.Forms.TextBox
    Friend WithEvents ChangePasswdBtn As System.Windows.Forms.Button

End Class
