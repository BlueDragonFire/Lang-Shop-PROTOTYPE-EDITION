<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NL4
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
        Me.PictureBox1.Image = Global.Lang_Shop_PROTOTYPE_EDITION.My.Resources.Resources.car
        Me.PictureBox1.Location = New System.Drawing.Point(119, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'btnWrong1
        '
        Me.btnWrong1.Location = New System.Drawing.Point(12, 141)
        Me.btnWrong1.Name = "btnWrong1"
        Me.btnWrong1.Size = New System.Drawing.Size(100, 44)
        Me.btnWrong1.TabIndex = 12
        Me.btnWrong1.Text = "Button3"
        Me.btnWrong1.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(224, 141)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(100, 44)
        Me.btnRight.TabIndex = 11
        Me.btnRight.Text = "Button2"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnWrong2
        '
        Me.btnWrong2.Location = New System.Drawing.Point(119, 141)
        Me.btnWrong2.Name = "btnWrong2"
        Me.btnWrong2.Size = New System.Drawing.Size(100, 44)
        Me.btnWrong2.TabIndex = 10
        Me.btnWrong2.Text = "Button1"
        Me.btnWrong2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(313, 44)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NL4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 245)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnWrong1)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnWrong2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "NL4"
        Me.Text = "Level 4"
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
