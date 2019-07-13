<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPatient
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(295, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 82)
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
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(155, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 128)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Patient"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(468, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(120, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(237, 28)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 28)
        Me.TextBox1.TabIndex = 1
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(59, 295)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(853, 169)
        Me.DataGridView1.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(108, 480)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 292)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Patient Information"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(124, 131)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(271, 28)
        Me.TextBox8.TabIndex = 12
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
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(124, 92)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(271, 28)
        Me.TextBox7.TabIndex = 10
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
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(124, 182)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(480, 90)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(504, 125)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 28)
        Me.TextBox5.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(504, 88)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 28)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(124, 43)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 28)
        Me.TextBox3.TabIndex = 4
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
        Me.Label6.Location = New System.Drawing.Point(414, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Gender : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(417, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Age :"
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
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(779, 526)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 37)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Update "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(779, 697)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 37)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(779, 612)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 37)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SearchPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SearchPatient"
        Me.Size = New System.Drawing.Size(977, 804)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
