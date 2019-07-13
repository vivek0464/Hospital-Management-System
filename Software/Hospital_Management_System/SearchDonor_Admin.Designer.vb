<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchDonor_Admin
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
        Me.SearchResultGrid = New System.Windows.Forms.DataGridView()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MobileSTxt = New System.Windows.Forms.TextBox()
        Me.NameSTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.DonorInfoBox = New System.Windows.Forms.GroupBox()
        Me.BloodGroupTxt = New System.Windows.Forms.ComboBox()
        Me.GenderTxt = New System.Windows.Forms.ComboBox()
        Me.QuantityTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.IDTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateOfDonationTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DOBTxt = New System.Windows.Forms.TextBox()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.DonorInfoBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.images1232
        Me.PictureBox1.Location = New System.Drawing.Point(165, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 47)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search Donor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchResultGrid
        '
        Me.SearchResultGrid.BackgroundColor = System.Drawing.Color.White
        Me.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchResultGrid.Location = New System.Drawing.Point(59, 295)
        Me.SearchResultGrid.Name = "SearchResultGrid"
        Me.SearchResultGrid.ReadOnly = True
        Me.SearchResultGrid.RowTemplate.Height = 24
        Me.SearchResultGrid.Size = New System.Drawing.Size(853, 169)
        Me.SearchResultGrid.TabIndex = 10
        Me.SearchResultGrid.Visible = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.DeleteBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(808, 588)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(104, 37)
        Me.DeleteBtn.TabIndex = 13
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        Me.DeleteBtn.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MobileSTxt)
        Me.GroupBox1.Controls.Add(Me.NameSTxt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(155, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 128)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Patient"
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.SearchBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(468, 82)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(133, 37)
        Me.SearchBtn.TabIndex = 4
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mobile : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MobileSTxt
        '
        Me.MobileSTxt.Location = New System.Drawing.Point(120, 86)
        Me.MobileSTxt.Name = "MobileSTxt"
        Me.MobileSTxt.Size = New System.Drawing.Size(237, 28)
        Me.MobileSTxt.TabIndex = 2
        '
        'NameSTxt
        '
        Me.NameSTxt.Location = New System.Drawing.Point(120, 44)
        Me.NameSTxt.Name = "NameSTxt"
        Me.NameSTxt.Size = New System.Drawing.Size(237, 28)
        Me.NameSTxt.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 28)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Name : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(808, 667)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(104, 37)
        Me.ClearBtn.TabIndex = 12
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'DonorInfoBox
        '
        Me.DonorInfoBox.Controls.Add(Me.BloodGroupTxt)
        Me.DonorInfoBox.Controls.Add(Me.GenderTxt)
        Me.DonorInfoBox.Controls.Add(Me.QuantityTxt)
        Me.DonorInfoBox.Controls.Add(Me.Label12)
        Me.DonorInfoBox.Controls.Add(Me.IDTxt)
        Me.DonorInfoBox.Controls.Add(Me.Label11)
        Me.DonorInfoBox.Controls.Add(Me.Label4)
        Me.DonorInfoBox.Controls.Add(Me.MobileTxt)
        Me.DonorInfoBox.Controls.Add(Me.Label9)
        Me.DonorInfoBox.Controls.Add(Me.DateOfDonationTxt)
        Me.DonorInfoBox.Controls.Add(Me.Label8)
        Me.DonorInfoBox.Controls.Add(Me.DOBTxt)
        Me.DonorInfoBox.Controls.Add(Me.NameTxt)
        Me.DonorInfoBox.Controls.Add(Me.Label6)
        Me.DonorInfoBox.Controls.Add(Me.Label5)
        Me.DonorInfoBox.Controls.Add(Me.Label3)
        Me.DonorInfoBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonorInfoBox.Location = New System.Drawing.Point(79, 470)
        Me.DonorInfoBox.Name = "DonorInfoBox"
        Me.DonorInfoBox.Size = New System.Drawing.Size(699, 259)
        Me.DonorInfoBox.TabIndex = 15
        Me.DonorInfoBox.TabStop = False
        Me.DonorInfoBox.Text = "Donor Information"
        Me.DonorInfoBox.Visible = False
        '
        'BloodGroupTxt
        '
        Me.BloodGroupTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BloodGroupTxt.FormattingEnabled = True
        Me.BloodGroupTxt.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.BloodGroupTxt.Location = New System.Drawing.Point(531, 164)
        Me.BloodGroupTxt.Name = "BloodGroupTxt"
        Me.BloodGroupTxt.Size = New System.Drawing.Size(146, 30)
        Me.BloodGroupTxt.TabIndex = 21
        '
        'GenderTxt
        '
        Me.GenderTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderTxt.FormattingEnabled = True
        Me.GenderTxt.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.GenderTxt.Location = New System.Drawing.Point(530, 118)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.Size = New System.Drawing.Size(146, 30)
        Me.GenderTxt.TabIndex = 20
        '
        'QuantityTxt
        '
        Me.QuantityTxt.Location = New System.Drawing.Point(507, 215)
        Me.QuantityTxt.Name = "QuantityTxt"
        Me.QuantityTxt.ReadOnly = True
        Me.QuantityTxt.Size = New System.Drawing.Size(169, 28)
        Me.QuantityTxt.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(401, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 26)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Quantity : "
        '
        'IDTxt
        '
        Me.IDTxt.Location = New System.Drawing.Point(117, 36)
        Me.IDTxt.Name = "IDTxt"
        Me.IDTxt.ReadOnly = True
        Me.IDTxt.Size = New System.Drawing.Size(204, 28)
        Me.IDTxt.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 25)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "ID :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(388, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 28)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Blood Group : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MobileTxt
        '
        Me.MobileTxt.Location = New System.Drawing.Point(117, 124)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(271, 28)
        Me.MobileTxt.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 28)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Phone : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateOfDonationTxt
        '
        Me.DateOfDonationTxt.Location = New System.Drawing.Point(196, 215)
        Me.DateOfDonationTxt.Name = "DateOfDonationTxt"
        Me.DateOfDonationTxt.ReadOnly = True
        Me.DateOfDonationTxt.Size = New System.Drawing.Size(192, 28)
        Me.DateOfDonationTxt.TabIndex = 10
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
        'DOBTxt
        '
        Me.DOBTxt.Location = New System.Drawing.Point(117, 167)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.Size = New System.Drawing.Size(169, 28)
        Me.DOBTxt.TabIndex = 5
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(117, 77)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(271, 28)
        Me.NameTxt.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(401, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gender : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Age :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Date Of Donation :"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.UpdateBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.Location = New System.Drawing.Point(808, 517)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(104, 37)
        Me.UpdateBtn.TabIndex = 16
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        Me.UpdateBtn.Visible = False
        '
        'SearchDonor_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.DonorInfoBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.SearchResultGrid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SearchDonor_Admin"
        Me.Size = New System.Drawing.Size(977, 804)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.DonorInfoBox.ResumeLayout(False)
        Me.DonorInfoBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchResultGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MobileSTxt As System.Windows.Forms.TextBox
    Friend WithEvents NameSTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DonorInfoBox As System.Windows.Forms.GroupBox
    Friend WithEvents QuantityTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents IDTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateOfDonationTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DOBTxt As System.Windows.Forms.TextBox
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents GenderTxt As System.Windows.Forms.ComboBox
    Friend WithEvents BloodGroupTxt As System.Windows.Forms.ComboBox

End Class
