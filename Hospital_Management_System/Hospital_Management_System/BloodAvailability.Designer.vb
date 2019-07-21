<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BloodAvailability
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.BloodGrpTxt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AmountLbl = New System.Windows.Forms.Label()
        Me.ValueLbl = New System.Windows.Forms.Label()
        Me.DonorListBtn = New System.Windows.Forms.Button()
        Me.SearchResultGrid = New System.Windows.Forms.DataGridView()
        Me.SuccessMsg = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 47)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Blood Availability"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchBtn)
        Me.GroupBox1.Controls.Add(Me.BloodGrpTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(232, 214)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 137)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.SearchBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(183, 91)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(102, 36)
        Me.SearchBtn.TabIndex = 22
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'BloodGrpTxt
        '
        Me.BloodGrpTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BloodGrpTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodGrpTxt.FormattingEnabled = True
        Me.BloodGrpTxt.Items.AddRange(New Object() {"--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.BloodGrpTxt.Location = New System.Drawing.Point(246, 40)
        Me.BloodGrpTxt.Name = "BloodGrpTxt"
        Me.BloodGrpTxt.Size = New System.Drawing.Size(108, 26)
        Me.BloodGrpTxt.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Blood Group :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AmountLbl
        '
        Me.AmountLbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLbl.Location = New System.Drawing.Point(299, 369)
        Me.AmountLbl.Name = "AmountLbl"
        Me.AmountLbl.Size = New System.Drawing.Size(131, 35)
        Me.AmountLbl.TabIndex = 13
        Me.AmountLbl.Text = "Amount :"
        Me.AmountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ValueLbl
        '
        Me.ValueLbl.AutoSize = True
        Me.ValueLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ValueLbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValueLbl.Location = New System.Drawing.Point(436, 380)
        Me.ValueLbl.Name = "ValueLbl"
        Me.ValueLbl.Size = New System.Drawing.Size(64, 24)
        Me.ValueLbl.TabIndex = 14
        Me.ValueLbl.Text = "litres"
        Me.ValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DonorListBtn
        '
        Me.DonorListBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.DonorListBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonorListBtn.ForeColor = System.Drawing.Color.White
        Me.DonorListBtn.Location = New System.Drawing.Point(323, 434)
        Me.DonorListBtn.Name = "DonorListBtn"
        Me.DonorListBtn.Size = New System.Drawing.Size(221, 36)
        Me.DonorListBtn.TabIndex = 23
        Me.DonorListBtn.Text = "See List of Donors"
        Me.DonorListBtn.UseVisualStyleBackColor = False
        '
        'SearchResultGrid
        '
        Me.SearchResultGrid.BackgroundColor = System.Drawing.Color.White
        Me.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchResultGrid.Location = New System.Drawing.Point(112, 494)
        Me.SearchResultGrid.Name = "SearchResultGrid"
        Me.SearchResultGrid.ReadOnly = True
        Me.SearchResultGrid.RowTemplate.Height = 24
        Me.SearchResultGrid.Size = New System.Drawing.Size(739, 296)
        Me.SearchResultGrid.TabIndex = 24
        Me.SearchResultGrid.Visible = False
        '
        'SuccessMsg
        '
        Me.SuccessMsg.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold)
        Me.SuccessMsg.Location = New System.Drawing.Point(281, 141)
        Me.SuccessMsg.Name = "SuccessMsg"
        Me.SuccessMsg.Size = New System.Drawing.Size(401, 44)
        Me.SuccessMsg.TabIndex = 28
        Me.SuccessMsg.Text = "Label5"
        Me.SuccessMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SuccessMsg.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.UpdateBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.Location = New System.Drawing.Point(735, 362)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(180, 52)
        Me.UpdateBtn.TabIndex = 29
        Me.UpdateBtn.Text = "Update Blood Amount"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        Me.UpdateBtn.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.blood_goodpic
        Me.PictureBox1.Location = New System.Drawing.Point(272, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'BloodAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.SuccessMsg)
        Me.Controls.Add(Me.SearchResultGrid)
        Me.Controls.Add(Me.DonorListBtn)
        Me.Controls.Add(Me.ValueLbl)
        Me.Controls.Add(Me.AmountLbl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BloodAvailability"
        Me.Size = New System.Drawing.Size(977, 804)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BloodGrpTxt As System.Windows.Forms.ComboBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents AmountLbl As System.Windows.Forms.Label
    Friend WithEvents ValueLbl As System.Windows.Forms.Label
    Friend WithEvents DonorListBtn As System.Windows.Forms.Button
    Friend WithEvents SearchResultGrid As System.Windows.Forms.DataGridView
    Friend WithEvents SuccessMsg As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button

End Class
