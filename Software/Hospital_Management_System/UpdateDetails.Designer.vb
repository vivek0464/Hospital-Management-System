<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateDetails
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
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MobileSTxt = New System.Windows.Forms.TextBox()
        Me.NameSTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchResultGrid = New System.Windows.Forms.DataGridView()
        Me.PatientInfoBox = New System.Windows.Forms.GroupBox()
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.GenderTxt = New System.Windows.Forms.TextBox()
        Me.DOBTxt = New System.Windows.Forms.TextBox()
        Me.PIDTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientInfoBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 35)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Update Details "
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
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Patient"
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.SearchBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
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
        Me.Label3.Text = "Phone : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MobileSTxt
        '
        Me.MobileSTxt.Location = New System.Drawing.Point(120, 94)
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
        Me.SearchResultGrid.TabIndex = 7
        '
        'PatientInfoBox
        '
        Me.PatientInfoBox.Controls.Add(Me.MobileTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label9)
        Me.PatientInfoBox.Controls.Add(Me.NameTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label8)
        Me.PatientInfoBox.Controls.Add(Me.AddressTxt)
        Me.PatientInfoBox.Controls.Add(Me.GenderTxt)
        Me.PatientInfoBox.Controls.Add(Me.DOBTxt)
        Me.PatientInfoBox.Controls.Add(Me.PIDTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label7)
        Me.PatientInfoBox.Controls.Add(Me.Label6)
        Me.PatientInfoBox.Controls.Add(Me.Label5)
        Me.PatientInfoBox.Controls.Add(Me.Label4)
        Me.PatientInfoBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientInfoBox.Location = New System.Drawing.Point(108, 480)
        Me.PatientInfoBox.Name = "PatientInfoBox"
        Me.PatientInfoBox.Size = New System.Drawing.Size(623, 292)
        Me.PatientInfoBox.TabIndex = 8
        Me.PatientInfoBox.TabStop = False
        Me.PatientInfoBox.Text = "Patient Information"
        '
        'MobileTxt
        '
        Me.MobileTxt.Location = New System.Drawing.Point(124, 132)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(244, 28)
        Me.MobileTxt.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 28)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Phone : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(124, 92)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.ReadOnly = True
        Me.NameTxt.Size = New System.Drawing.Size(244, 28)
        Me.NameTxt.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 28)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Name : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(124, 182)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(480, 90)
        Me.AddressTxt.TabIndex = 7
        '
        'GenderTxt
        '
        Me.GenderTxt.Location = New System.Drawing.Point(473, 125)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.ReadOnly = True
        Me.GenderTxt.Size = New System.Drawing.Size(131, 28)
        Me.GenderTxt.TabIndex = 6
        '
        'DOBTxt
        '
        Me.DOBTxt.Location = New System.Drawing.Point(457, 88)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.ReadOnly = True
        Me.DOBTxt.Size = New System.Drawing.Size(147, 28)
        Me.DOBTxt.TabIndex = 5
        '
        'PIDTxt
        '
        Me.PIDTxt.Location = New System.Drawing.Point(124, 43)
        Me.PIDTxt.Name = "PIDTxt"
        Me.PIDTxt.ReadOnly = True
        Me.PIDTxt.Size = New System.Drawing.Size(100, 28)
        Me.PIDTxt.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 26)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Address : "
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(383, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gender : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(383, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "DOB :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "PID :"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.UpdateBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UpdateBtn.Location = New System.Drawing.Point(779, 563)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(133, 37)
        Me.UpdateBtn.TabIndex = 9
        Me.UpdateBtn.Text = "Update "
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClearBtn.Location = New System.Drawing.Point(779, 651)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(133, 37)
        Me.ClearBtn.TabIndex = 10
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.useless_pic
        Me.PictureBox1.Location = New System.Drawing.Point(260, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'UpdateDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.PatientInfoBox)
        Me.Controls.Add(Me.SearchResultGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UpdateDetails"
        Me.Size = New System.Drawing.Size(977, 804)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientInfoBox.ResumeLayout(False)
        Me.PatientInfoBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents GenderTxt As System.Windows.Forms.TextBox
    Friend WithEvents DOBTxt As System.Windows.Forms.TextBox
    Friend WithEvents PIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents ClearBtn As System.Windows.Forms.Button

End Class
