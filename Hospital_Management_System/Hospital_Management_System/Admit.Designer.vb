<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admit
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
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.NameSTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchResultGrid = New System.Windows.Forms.DataGridView()
        Me.PatientInfoBox = New System.Windows.Forms.GroupBox()
        Me.MobileSTxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.GenderTxt = New System.Windows.Forms.TextBox()
        Me.AgeTxt = New System.Windows.Forms.TextBox()
        Me.PIDTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AdmitDetailsBox = New System.Windows.Forms.GroupBox()
        Me.RoomNoTxt = New System.Windows.Forms.ComboBox()
        Me.RoomTypeTxt = New System.Windows.Forms.ComboBox()
        Me.DateOutTxt = New System.Windows.Forms.ComboBox()
        Me.DateInTxt = New System.Windows.Forms.ComboBox()
        Me.StatusTxt = New System.Windows.Forms.ComboBox()
        Me.DateOut1Txt = New System.Windows.Forms.TextBox()
        Me.DateIn1Txt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FeesTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HistoryBtn = New System.Windows.Forms.Button()
        Me.AdmitDischargeBtn = New System.Windows.Forms.Button()
        Me.RoomNo1Txt = New System.Windows.Forms.TextBox()
        Me.RoomType1Txt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientInfoBox.SuspendLayout()
        Me.AdmitDetailsBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Admit And Discharge "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchBtn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.MobileTxt)
        Me.GroupBox1.Controls.Add(Me.NameSTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(155, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 128)
        Me.GroupBox1.TabIndex = 5
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
        'MobileTxt
        '
        Me.MobileTxt.Location = New System.Drawing.Point(120, 86)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(237, 28)
        Me.MobileTxt.TabIndex = 2
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
        Me.SearchResultGrid.TabIndex = 6
        Me.SearchResultGrid.Visible = False
        '
        'PatientInfoBox
        '
        Me.PatientInfoBox.Controls.Add(Me.MobileSTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label15)
        Me.PatientInfoBox.Controls.Add(Me.NameTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label14)
        Me.PatientInfoBox.Controls.Add(Me.AddressTxt)
        Me.PatientInfoBox.Controls.Add(Me.GenderTxt)
        Me.PatientInfoBox.Controls.Add(Me.AgeTxt)
        Me.PatientInfoBox.Controls.Add(Me.PIDTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label7)
        Me.PatientInfoBox.Controls.Add(Me.Label6)
        Me.PatientInfoBox.Controls.Add(Me.Label5)
        Me.PatientInfoBox.Controls.Add(Me.Label4)
        Me.PatientInfoBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientInfoBox.Location = New System.Drawing.Point(59, 485)
        Me.PatientInfoBox.Name = "PatientInfoBox"
        Me.PatientInfoBox.Size = New System.Drawing.Size(439, 298)
        Me.PatientInfoBox.TabIndex = 7
        Me.PatientInfoBox.TabStop = False
        Me.PatientInfoBox.Text = "Patient Information"
        Me.PatientInfoBox.Visible = False
        '
        'MobileSTxt
        '
        Me.MobileSTxt.Location = New System.Drawing.Point(96, 116)
        Me.MobileSTxt.Name = "MobileSTxt"
        Me.MobileSTxt.ReadOnly = True
        Me.MobileSTxt.Size = New System.Drawing.Size(253, 28)
        Me.MobileSTxt.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 26)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Mobile :"
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(96, 77)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.ReadOnly = True
        Me.NameTxt.Size = New System.Drawing.Size(326, 28)
        Me.NameTxt.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 25)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Name :"
        '
        'AddressTxt
        '
        Me.AddressTxt.Location = New System.Drawing.Point(124, 198)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.ReadOnly = True
        Me.AddressTxt.Size = New System.Drawing.Size(298, 90)
        Me.AddressTxt.TabIndex = 7
        '
        'GenderTxt
        '
        Me.GenderTxt.Location = New System.Drawing.Point(322, 152)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.ReadOnly = True
        Me.GenderTxt.Size = New System.Drawing.Size(100, 28)
        Me.GenderTxt.TabIndex = 6
        '
        'AgeTxt
        '
        Me.AgeTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTxt.Location = New System.Drawing.Point(96, 154)
        Me.AgeTxt.Name = "AgeTxt"
        Me.AgeTxt.ReadOnly = True
        Me.AgeTxt.Size = New System.Drawing.Size(128, 23)
        Me.AgeTxt.TabIndex = 5
        '
        'PIDTxt
        '
        Me.PIDTxt.Location = New System.Drawing.Point(96, 43)
        Me.PIDTxt.Name = "PIDTxt"
        Me.PIDTxt.ReadOnly = True
        Me.PIDTxt.Size = New System.Drawing.Size(128, 28)
        Me.PIDTxt.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 26)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Address : "
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(232, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gender : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 154)
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
        'AdmitDetailsBox
        '
        Me.AdmitDetailsBox.Controls.Add(Me.RoomNo1Txt)
        Me.AdmitDetailsBox.Controls.Add(Me.RoomType1Txt)
        Me.AdmitDetailsBox.Controls.Add(Me.RoomNoTxt)
        Me.AdmitDetailsBox.Controls.Add(Me.RoomTypeTxt)
        Me.AdmitDetailsBox.Controls.Add(Me.DateOutTxt)
        Me.AdmitDetailsBox.Controls.Add(Me.DateInTxt)
        Me.AdmitDetailsBox.Controls.Add(Me.StatusTxt)
        Me.AdmitDetailsBox.Controls.Add(Me.DateOut1Txt)
        Me.AdmitDetailsBox.Controls.Add(Me.DateIn1Txt)
        Me.AdmitDetailsBox.Controls.Add(Me.Label13)
        Me.AdmitDetailsBox.Controls.Add(Me.Label12)
        Me.AdmitDetailsBox.Controls.Add(Me.Label11)
        Me.AdmitDetailsBox.Controls.Add(Me.FeesTxt)
        Me.AdmitDetailsBox.Controls.Add(Me.Label10)
        Me.AdmitDetailsBox.Controls.Add(Me.Label9)
        Me.AdmitDetailsBox.Controls.Add(Me.Label8)
        Me.AdmitDetailsBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmitDetailsBox.Location = New System.Drawing.Point(504, 485)
        Me.AdmitDetailsBox.Name = "AdmitDetailsBox"
        Me.AdmitDetailsBox.Size = New System.Drawing.Size(408, 255)
        Me.AdmitDetailsBox.TabIndex = 8
        Me.AdmitDetailsBox.TabStop = False
        Me.AdmitDetailsBox.Text = "Admit Details"
        Me.AdmitDetailsBox.Visible = False
        '
        'RoomNoTxt
        '
        Me.RoomNoTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoomNoTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNoTxt.FormattingEnabled = True
        Me.RoomNoTxt.Location = New System.Drawing.Point(161, 32)
        Me.RoomNoTxt.Name = "RoomNoTxt"
        Me.RoomNoTxt.Size = New System.Drawing.Size(141, 27)
        Me.RoomNoTxt.TabIndex = 19
        '
        'RoomTypeTxt
        '
        Me.RoomTypeTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoomTypeTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTypeTxt.FormattingEnabled = True
        Me.RoomTypeTxt.Items.AddRange(New Object() {"General", "V.I.P.", "ICU"})
        Me.RoomTypeTxt.Location = New System.Drawing.Point(161, 71)
        Me.RoomTypeTxt.Name = "RoomTypeTxt"
        Me.RoomTypeTxt.Size = New System.Drawing.Size(181, 27)
        Me.RoomTypeTxt.TabIndex = 18
        '
        'DateOutTxt
        '
        Me.DateOutTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DateOutTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOutTxt.FormattingEnabled = True
        Me.DateOutTxt.Location = New System.Drawing.Point(161, 157)
        Me.DateOutTxt.Name = "DateOutTxt"
        Me.DateOutTxt.Size = New System.Drawing.Size(181, 27)
        Me.DateOutTxt.TabIndex = 17
        '
        'DateInTxt
        '
        Me.DateInTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DateInTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateInTxt.FormattingEnabled = True
        Me.DateInTxt.Location = New System.Drawing.Point(161, 111)
        Me.DateInTxt.Name = "DateInTxt"
        Me.DateInTxt.Size = New System.Drawing.Size(181, 27)
        Me.DateInTxt.TabIndex = 16
        '
        'StatusTxt
        '
        Me.StatusTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusTxt.FormattingEnabled = True
        Me.StatusTxt.Items.AddRange(New Object() {"Paid", "Not Paid"})
        Me.StatusTxt.Location = New System.Drawing.Point(266, 198)
        Me.StatusTxt.Name = "StatusTxt"
        Me.StatusTxt.Size = New System.Drawing.Size(136, 30)
        Me.StatusTxt.TabIndex = 15
        '
        'DateOut1Txt
        '
        Me.DateOut1Txt.Location = New System.Drawing.Point(161, 157)
        Me.DateOut1Txt.Name = "DateOut1Txt"
        Me.DateOut1Txt.ReadOnly = True
        Me.DateOut1Txt.Size = New System.Drawing.Size(181, 28)
        Me.DateOut1Txt.TabIndex = 14
        '
        'DateIn1Txt
        '
        Me.DateIn1Txt.Location = New System.Drawing.Point(161, 110)
        Me.DateIn1Txt.Name = "DateIn1Txt"
        Me.DateIn1Txt.ReadOnly = True
        Me.DateIn1Txt.Size = New System.Drawing.Size(181, 28)
        Me.DateIn1Txt.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 25)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Date Out  :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 28)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Date In  :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(184, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 28)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Status:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FeesTxt
        '
        Me.FeesTxt.Location = New System.Drawing.Point(92, 201)
        Me.FeesTxt.Name = "FeesTxt"
        Me.FeesTxt.Size = New System.Drawing.Size(86, 28)
        Me.FeesTxt.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 25)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Fees  :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 28)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Room Type :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Room No :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(504, 746)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(97, 37)
        Me.ClearBtn.TabIndex = 9
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        Me.ClearBtn.Visible = False
        '
        'PrintBtn
        '
        Me.PrintBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.PrintBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.ForeColor = System.Drawing.Color.White
        Me.PrintBtn.Location = New System.Drawing.Point(655, 746)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(101, 37)
        Me.PrintBtn.TabIndex = 10
        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.UseVisualStyleBackColor = False
        Me.PrintBtn.Visible = False
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.SaveBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(814, 746)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(98, 37)
        Me.SaveBtn.TabIndex = 11
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = False
        Me.SaveBtn.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.medical_bed_icon
        Me.PictureBox1.Location = New System.Drawing.Point(260, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'HistoryBtn
        '
        Me.HistoryBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.HistoryBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryBtn.ForeColor = System.Drawing.Color.White
        Me.HistoryBtn.Location = New System.Drawing.Point(784, 163)
        Me.HistoryBtn.Name = "HistoryBtn"
        Me.HistoryBtn.Size = New System.Drawing.Size(181, 41)
        Me.HistoryBtn.TabIndex = 18
        Me.HistoryBtn.Text = "History"
        Me.HistoryBtn.UseVisualStyleBackColor = False
        Me.HistoryBtn.Visible = False
        '
        'AdmitDischargeBtn
        '
        Me.AdmitDischargeBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.AdmitDischargeBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmitDischargeBtn.ForeColor = System.Drawing.Color.White
        Me.AdmitDischargeBtn.Location = New System.Drawing.Point(784, 220)
        Me.AdmitDischargeBtn.Name = "AdmitDischargeBtn"
        Me.AdmitDischargeBtn.Size = New System.Drawing.Size(181, 45)
        Me.AdmitDischargeBtn.TabIndex = 19
        Me.AdmitDischargeBtn.Text = "Admit/Discharge"
        Me.AdmitDischargeBtn.UseVisualStyleBackColor = False
        Me.AdmitDischargeBtn.Visible = False
        '
        'RoomNo1Txt
        '
        Me.RoomNo1Txt.Location = New System.Drawing.Point(161, 32)
        Me.RoomNo1Txt.Name = "RoomNo1Txt"
        Me.RoomNo1Txt.ReadOnly = True
        Me.RoomNo1Txt.Size = New System.Drawing.Size(141, 28)
        Me.RoomNo1Txt.TabIndex = 20
        Me.RoomNo1Txt.Visible = False
        '
        'RoomType1Txt
        '
        Me.RoomType1Txt.Location = New System.Drawing.Point(161, 73)
        Me.RoomType1Txt.Name = "RoomType1Txt"
        Me.RoomType1Txt.ReadOnly = True
        Me.RoomType1Txt.Size = New System.Drawing.Size(181, 28)
        Me.RoomType1Txt.TabIndex = 21
        Me.RoomType1Txt.Visible = False
        '
        'Admit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.AdmitDischargeBtn)
        Me.Controls.Add(Me.HistoryBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.AdmitDetailsBox)
        Me.Controls.Add(Me.PatientInfoBox)
        Me.Controls.Add(Me.SearchResultGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Admit"
        Me.Size = New System.Drawing.Size(977, 804)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientInfoBox.ResumeLayout(False)
        Me.PatientInfoBox.PerformLayout()
        Me.AdmitDetailsBox.ResumeLayout(False)
        Me.AdmitDetailsBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents NameSTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SearchResultGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PatientInfoBox As System.Windows.Forms.GroupBox
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents GenderTxt As System.Windows.Forms.TextBox
    Friend WithEvents AgeTxt As System.Windows.Forms.TextBox
    Friend WithEvents PIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AdmitDetailsBox As System.Windows.Forms.GroupBox
    Friend WithEvents FeesTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateOut1Txt As System.Windows.Forms.TextBox
    Friend WithEvents DateIn1Txt As System.Windows.Forms.TextBox
    Friend WithEvents StatusTxt As System.Windows.Forms.ComboBox
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents PrintBtn As System.Windows.Forms.Button
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DateOutTxt As System.Windows.Forms.ComboBox
    Friend WithEvents DateInTxt As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MobileSTxt As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents HistoryBtn As System.Windows.Forms.Button
    Friend WithEvents AdmitDischargeBtn As System.Windows.Forms.Button
    Friend WithEvents RoomTypeTxt As System.Windows.Forms.ComboBox
    Friend WithEvents RoomNoTxt As System.Windows.Forms.ComboBox
    Friend WithEvents RoomNo1Txt As System.Windows.Forms.TextBox
    Friend WithEvents RoomType1Txt As System.Windows.Forms.TextBox

End Class
