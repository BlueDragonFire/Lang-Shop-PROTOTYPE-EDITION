<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NL2
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWrong1 = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnWrong2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lang_Shop_PROTOTYPE_EDITION.My.Resources.Resources.Woman
        Me.PictureBox1.Location = New System.Drawing.Point(118, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 183)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'btnWrong1
        '
        Me.btnWrong1.Location = New System.Drawing.Point(224, 225)
        Me.btnWrong1.Name = "btnWrong1"
        Me.btnWrong1.Size = New System.Drawing.Size(100, 44)
        Me.btnWrong1.TabIndex = 8
        Me.btnWrong1.Text = "Button3"
        Me.btnWrong1.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(118, 225)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(100, 44)
        Me.btnRight.TabIndex = 7
        Me.btnRight.Text = "Button2"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnWrong2
        '
        Me.btnWrong2.Location = New System.Drawing.Point(12, 225)
        Me.btnWrong2.Name = "btnWrong2"
        Me.btnWrong2.Size = New System.Drawing.Size(100, 44)
        Me.btnWrong2.TabIndex = 6
        Me.btnWrong2.Text = "Button1"
        Me.btnWrong2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(313, 44)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NL2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 328)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnWrong1)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnWrong2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "NL2"
        Me.Text = "Level 2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnWrong1 As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnWrong2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
