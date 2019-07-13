<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterDonor
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuccessMsg = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QuantityTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WarningLbl = New System.Windows.Forms.Label()
        Me.BloodGrpTxt = New System.Windows.Forms.ComboBox()
        Me.BloodGrpLbl = New System.Windows.Forms.Label()
        Me.GenderTxt = New System.Windows.Forms.ComboBox()
        Me.AgeLbl = New System.Windows.Forms.Label()
        Me.AgeTxt = New System.Windows.Forms.TextBox()
        Me.MobileLbl = New System.Windows.Forms.Label()
        Me.GenderLbl = New System.Windows.Forms.Label()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'SuccessMsg
        '
        Me.SuccessMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.SuccessMsg.Location = New System.Drawing.Point(117, 174)
        Me.SuccessMsg.Name = "SuccessMsg"
        Me.SuccessMsg.Size = New System.Drawing.Size(401, 44)
        Me.SuccessMsg.TabIndex = 21
        Me.SuccessMsg.Text = "Name :"
        Me.SuccessMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SuccessMsg.Visible = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(547, 704)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(148, 51)
        Me.ClearBtn.TabIndex = 20
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.AddBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(760, 704)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(148, 51)
        Me.AddBtn.TabIndex = 19
        Me.AddBtn.Text = "Add Donor"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(614, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 480)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parameter Check"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(31, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 36)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Diseases Not Present"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox8.Location = New System.Drawing.Point(34, 434)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(96, 23)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "Typhoid"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.Location = New System.Drawing.Point(34, 387)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(116, 23)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "Cholestrol"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.Location = New System.Drawing.Point(34, 333)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(93, 23)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "Syphilis"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(34, 284)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(91, 23)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "HTLV II"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(34, 237)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(85, 23)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "HTLV I"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(34, 187)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(60, 23)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "HIV"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(34, 137)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(128, 23)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Hepatitus C"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(34, 86)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(127, 23)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Hepatitus B"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DateTxt)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.QuantityTxt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.WarningLbl)
        Me.GroupBox2.Controls.Add(Me.BloodGrpTxt)
        Me.GroupBox2.Controls.Add(Me.BloodGrpLbl)
        Me.GroupBox2.Controls.Add(Me.GenderTxt)
        Me.GroupBox2.Controls.Add(Me.AgeLbl)
        Me.GroupBox2.Controls.Add(Me.AgeTxt)
        Me.GroupBox2.Controls.Add(Me.MobileLbl)
        Me.GroupBox2.Controls.Add(Me.GenderLbl)
        Me.GroupBox2.Controls.Add(Me.NameLbl)
        Me.GroupBox2.Controls.Add(Me.MobileTxt)
        Me.GroupBox2.Controls.Add(Me.NameTxt)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(68, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 444)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Donor Information"
        '
        'DateTxt
        '
        Me.DateTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTxt.Location = New System.Drawing.Point(121, 374)
        Me.DateTxt.Name = "DateTxt"
        Me.DateTxt.ReadOnly = True
        Me.DateTxt.Size = New System.Drawing.Size(167, 26)
        Me.DateTxt.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Date :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuantityTxt
        '
        Me.QuantityTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTxt.Location = New System.Drawing.Point(250, 324)
        Me.QuantityTxt.Name = "QuantityTxt"
        Me.QuantityTxt.Size = New System.Drawing.Size(87, 26)
        Me.QuantityTxt.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Amount Donated: "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WarningLbl
        '
        Me.WarningLbl.AutoSize = True
        Me.WarningLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLbl.ForeColor = System.Drawing.Color.Red
        Me.WarningLbl.Location = New System.Drawing.Point(272, 133)
        Me.WarningLbl.Name = "WarningLbl"
        Me.WarningLbl.Size = New System.Drawing.Size(107, 17)
        Me.WarningLbl.TabIndex = 21
        Me.WarningLbl.Text = "(18-55 years)"
        Me.WarningLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BloodGrpTxt
        '
        Me.BloodGrpTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BloodGrpTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodGrpTxt.FormattingEnabled = True
        Me.BloodGrpTxt.Items.AddRange(New Object() {"--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.BloodGrpTxt.Location = New System.Drawing.Point(163, 277)
        Me.BloodGrpTxt.Name = "BloodGrpTxt"
        Me.BloodGrpTxt.Size = New System.Drawing.Size(113, 27)
        Me.BloodGrpTxt.TabIndex = 20
        '
        'BloodGrpLbl
        '
        Me.BloodGrpLbl.AutoSize = True
        Me.BloodGrpLbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodGrpLbl.Location = New System.Drawing.Point(25, 280)
        Me.BloodGrpLbl.Name = "BloodGrpLbl"
        Me.BloodGrpLbl.Size = New System.Drawing.Size(127, 19)
        Me.BloodGrpLbl.TabIndex = 19
        Me.BloodGrpLbl.Text = "Blood Group :"
        Me.BloodGrpLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GenderTxt
        '
        Me.GenderTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTxt.FormattingEnabled = True
        Me.GenderTxt.Items.AddRange(New Object() {"MALE", "FEMALE", "OTHERS"})
        Me.GenderTxt.Location = New System.Drawing.Point(127, 226)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.Size = New System.Drawing.Size(124, 27)
        Me.GenderTxt.TabIndex = 14
        '
        'AgeLbl
        '
        Me.AgeLbl.AutoSize = True
        Me.AgeLbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeLbl.Location = New System.Drawing.Point(25, 131)
        Me.AgeLbl.Name = "AgeLbl"
        Me.AgeLbl.Size = New System.Drawing.Size(54, 19)
        Me.AgeLbl.TabIndex = 13
        Me.AgeLbl.Text = "Age :"
        Me.AgeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgeTxt
        '
        Me.AgeTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTxt.Location = New System.Drawing.Point(127, 128)
        Me.AgeTxt.Name = "AgeTxt"
        Me.AgeTxt.Size = New System.Drawing.Size(124, 26)
        Me.AgeTxt.TabIndex = 10
        '
        'MobileLbl
        '
        Me.MobileLbl.AutoSize = True
        Me.MobileLbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileLbl.Location = New System.Drawing.Point(25, 181)
        Me.MobileLbl.Name = "MobileLbl"
        Me.MobileLbl.Size = New System.Drawing.Size(76, 19)
        Me.MobileLbl.TabIndex = 8
        Me.MobileLbl.Text = "Mobile :"
        Me.MobileLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GenderLbl
        '
        Me.GenderLbl.AutoSize = True
        Me.GenderLbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderLbl.Location = New System.Drawing.Point(25, 229)
        Me.GenderLbl.Name = "GenderLbl"
        Me.GenderLbl.Size = New System.Drawing.Size(83, 19)
        Me.GenderLbl.TabIndex = 6
        Me.GenderLbl.Text = "Gender :"
        Me.GenderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.NameLbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLbl.Location = New System.Drawing.Point(25, 76)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(71, 19)
        Me.NameLbl.TabIndex = 5
        Me.NameLbl.Text = "Name :"
        Me.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MobileTxt
        '
        Me.MobileTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileTxt.Location = New System.Drawing.Point(147, 178)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(232, 26)
        Me.MobileTxt.TabIndex = 2
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.Location = New System.Drawing.Point(127, 73)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(355, 26)
        Me.NameTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 35)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Register Donor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.images1232
        Me.PictureBox1.Location = New System.Drawing.Point(156, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(357, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "(In litres)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'RegisterDonor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.SuccessMsg)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RegisterDonor"
        Me.Size = New System.Drawing.Size(977, 804)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SuccessMsg As System.Windows.Forms.Label
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents QuantityTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents WarningLbl As System.Windows.Forms.Label
    Friend WithEvents BloodGrpTxt As System.Windows.Forms.ComboBox
    Friend WithEvents BloodGrpLbl As System.Windows.Forms.Label
    Friend WithEvents GenderTxt As System.Windows.Forms.ComboBox
    Friend WithEvents AgeLbl As System.Windows.Forms.Label
    Friend WithEvents AgeTxt As System.Windows.Forms.TextBox
    Friend WithEvents MobileLbl As System.Windows.Forms.Label
    Friend WithEvents GenderLbl As System.Windows.Forms.Label
    Friend WithEvents NameLbl As System.Windows.Forms.Label
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
