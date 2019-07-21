<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPatient_Admin
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
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MobileSTxt = New System.Windows.Forms.TextBox()
        Me.NameSTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchResultGrid = New System.Windows.Forms.DataGridView()
        Me.PatientInfoBox = New System.Windows.Forms.GroupBox()
        Me.DOBTxt = New System.Windows.Forms.DateTimePicker()
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.GenderTxt = New System.Windows.Forms.TextBox()
        Me.PIDTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientInfoBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.patient_pic
        Me.PictureBox1.Location = New System.Drawing.Point(256, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 47)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Search Patient"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchBtn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MobileSTxt)
        Me.GroupBox1.Controls.Add(Me.NameSTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(155, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 128)
        Me.GroupBox1.TabIndex = 11
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
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mobile : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.SearchResultGrid.ReadOnly = True
        Me.SearchResultGrid.RowTemplate.Height = 24
        Me.SearchResultGrid.Size = New System.Drawing.Size(853, 169)
        Me.SearchResultGrid.TabIndex = 12
        Me.SearchResultGrid.Visible = False
        '
        'PatientInfoBox
        '
        Me.PatientInfoBox.Controls.Add(Me.DOBTxt)
        Me.PatientInfoBox.Controls.Add(Me.MobileTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label10)
        Me.PatientInfoBox.Controls.Add(Me.NameTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label14)
        Me.PatientInfoBox.Controls.Add(Me.AddressTxt)
        Me.PatientInfoBox.Controls.Add(Me.GenderTxt)
        Me.PatientInfoBox.Controls.Add(Me.PIDTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label7)
        Me.PatientInfoBox.Controls.Add(Me.Label6)
        Me.PatientInfoBox.Controls.Add(Me.Label5)
        Me.PatientInfoBox.Controls.Add(Me.Label4)
        Me.PatientInfoBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientInfoBox.Location = New System.Drawing.Point(59, 486)
        Me.PatientInfoBox.Name = "PatientInfoBox"
        Me.PatientInfoBox.Size = New System.Drawing.Size(860, 231)
        Me.PatientInfoBox.TabIndex = 13
        Me.PatientInfoBox.TabStop = False
        Me.PatientInfoBox.Text = "Patient Information"
        Me.PatientInfoBox.Visible = False
        '
        'DOBTxt
        '
        Me.DOBTxt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOBTxt.Location = New System.Drawing.Point(124, 132)
        Me.DOBTxt.MaxDate = New Date(2019, 2, 11, 0, 0, 0, 0)
        Me.DOBTxt.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.Size = New System.Drawing.Size(166, 28)
        Me.DOBTxt.TabIndex = 12
        Me.DOBTxt.Value = New Date(2019, 2, 11, 0, 0, 0, 0)
        '
        'MobileTxt
        '
        Me.MobileTxt.Location = New System.Drawing.Point(554, 83)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(258, 28)
        Me.MobileTxt.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(472, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 28)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Mobile :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(124, 89)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(315, 28)
        Me.NameTxt.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 25)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Name :"
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(554, 128)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(258, 90)
        Me.AddressTxt.TabIndex = 7
        '
        'GenderTxt
        '
        Me.GenderTxt.Location = New System.Drawing.Point(124, 178)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.Size = New System.Drawing.Size(166, 28)
        Me.GenderTxt.TabIndex = 6
        '
        'PIDTxt
        '
        Me.PIDTxt.Location = New System.Drawing.Point(124, 43)
        Me.PIDTxt.Name = "PIDTxt"
        Me.PIDTxt.ReadOnly = True
        Me.PIDTxt.Size = New System.Drawing.Size(116, 28)
        Me.PIDTxt.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(452, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 26)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Address : "
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gender : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "DOB :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "PID :"
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(546, 747)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(97, 37)
        Me.ClearBtn.TabIndex = 15
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        Me.ClearBtn.Visible = False
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.UpdateBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.Location = New System.Drawing.Point(681, 747)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(97, 37)
        Me.UpdateBtn.TabIndex = 16
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        Me.UpdateBtn.Visible = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.DeleteBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(815, 747)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(97, 37)
        Me.DeleteBtn.TabIndex = 17
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        Me.DeleteBtn.Visible = False
        '
        'SearchPatient_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.PatientInfoBox)
        Me.Controls.Add(Me.SearchResultGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SearchPatient_Admin"
        Me.Size = New System.Drawing.Size(977, 804)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientInfoBox.ResumeLayout(False)
        Me.PatientInfoBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MobileSTxt As System.Windows.Forms.TextBox
    Friend WithEvents NameSTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SearchResultGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PatientInfoBox As System.Windows.Forms.GroupBox
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents GenderTxt As System.Windows.Forms.TextBox
    Friend WithEvents PIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents DOBTxt As System.Windows.Forms.DateTimePicker

End Class
