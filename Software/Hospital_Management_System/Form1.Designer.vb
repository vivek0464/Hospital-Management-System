<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShowPasswd = New System.Windows.Forms.CheckBox()
        Me.AdminRadioBtn = New System.Windows.Forms.RadioButton()
        Me.StaffRadioBtn = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.ShowPasswd)
        Me.GroupBox1.Controls.Add(Me.AdminRadioBtn)
        Me.GroupBox1.Controls.Add(Me.StaffRadioBtn)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ExitBtn)
        Me.GroupBox1.Controls.Add(Me.loginBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PasswordTxt)
        Me.GroupBox1.Controls.Add(Me.UsernameTxt)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(793, 102)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(604, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'ShowPasswd
        '
        Me.ShowPasswd.AutoSize = True
        Me.ShowPasswd.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPasswd.Location = New System.Drawing.Point(431, 192)
        Me.ShowPasswd.Name = "ShowPasswd"
        Me.ShowPasswd.Size = New System.Drawing.Size(150, 23)
        Me.ShowPasswd.TabIndex = 16
        Me.ShowPasswd.Text = "Show Password"
        Me.ShowPasswd.UseVisualStyleBackColor = True
        '
        'AdminRadioBtn
        '
        Me.AdminRadioBtn.AutoSize = True
        Me.AdminRadioBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminRadioBtn.Location = New System.Drawing.Point(119, 258)
        Me.AdminRadioBtn.Name = "AdminRadioBtn"
        Me.AdminRadioBtn.Size = New System.Drawing.Size(78, 22)
        Me.AdminRadioBtn.TabIndex = 8
        Me.AdminRadioBtn.TabStop = True
        Me.AdminRadioBtn.Text = "Admin"
        Me.AdminRadioBtn.UseVisualStyleBackColor = True
        '
        'StaffRadioBtn
        '
        Me.StaffRadioBtn.AutoSize = True
        Me.StaffRadioBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffRadioBtn.Location = New System.Drawing.Point(29, 260)
        Me.StaffRadioBtn.Name = "StaffRadioBtn"
        Me.StaffRadioBtn.Size = New System.Drawing.Size(68, 22)
        Me.StaffRadioBtn.TabIndex = 7
        Me.StaffRadioBtn.TabStop = True
        Me.StaffRadioBtn.Text = "Staff"
        Me.StaffRadioBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.imageedit_1_6564123496
        Me.PictureBox1.Location = New System.Drawing.Point(0, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExitBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(461, 248)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(75, 32)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.loginBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.loginBtn.Location = New System.Drawing.Point(353, 248)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 32)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(234, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.Location = New System.Drawing.Point(376, 133)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(216, 28)
        Me.PasswordTxt.TabIndex = 1
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxt.Location = New System.Drawing.Point(376, 77)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(216, 28)
        Me.UsernameTxt.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hospital_Management_System.My.Resources.Resources.golisano_childrens_hospital_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1262, 721)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StaffRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents AdminRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents ShowPasswd As System.Windows.Forms.CheckBox

End Class
