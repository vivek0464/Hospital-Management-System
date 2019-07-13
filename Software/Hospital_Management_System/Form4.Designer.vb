<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Amount"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(60, 107)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 28)
        Me.TextBox1.TabIndex = 1
        '
        'OkBtn
        '
        Me.OkBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.OkBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkBtn.ForeColor = System.Drawing.Color.White
        Me.OkBtn.Location = New System.Drawing.Point(77, 157)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(96, 37)
        Me.OkBtn.TabIndex = 2
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OkBtn As System.Windows.Forms.Button
End Class
