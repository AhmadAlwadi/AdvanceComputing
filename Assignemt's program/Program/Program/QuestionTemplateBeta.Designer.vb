<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionTemplateBeta
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.QuestionBox = New System.Windows.Forms.TextBox()
        Me.OptionA = New System.Windows.Forms.Button()
        Me.OptionB = New System.Windows.Forms.Button()
        Me.OptionC = New System.Windows.Forms.Button()
        Me.OptionD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1233, 601)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(397, 265)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 283)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(397, 341)
        Me.TextBox2.TabIndex = 2
        '
        'QuestionBox
        '
        Me.QuestionBox.Location = New System.Drawing.Point(459, 12)
        Me.QuestionBox.Multiline = True
        Me.QuestionBox.Name = "QuestionBox"
        Me.QuestionBox.Size = New System.Drawing.Size(787, 219)
        Me.QuestionBox.TabIndex = 3
        '
        'OptionA
        '
        Me.OptionA.Location = New System.Drawing.Point(470, 254)
        Me.OptionA.Name = "OptionA"
        Me.OptionA.Size = New System.Drawing.Size(304, 122)
        Me.OptionA.TabIndex = 4
        Me.OptionA.Text = "OptionA"
        Me.OptionA.UseVisualStyleBackColor = True
        '
        'OptionB
        '
        Me.OptionB.Location = New System.Drawing.Point(981, 254)
        Me.OptionB.Name = "OptionB"
        Me.OptionB.Size = New System.Drawing.Size(304, 122)
        Me.OptionB.TabIndex = 5
        Me.OptionB.Text = "OptionB"
        Me.OptionB.UseVisualStyleBackColor = True
        '
        'OptionC
        '
        Me.OptionC.Location = New System.Drawing.Point(470, 412)
        Me.OptionC.Name = "OptionC"
        Me.OptionC.Size = New System.Drawing.Size(304, 95)
        Me.OptionC.TabIndex = 6
        Me.OptionC.Text = "OptionC"
        Me.OptionC.UseVisualStyleBackColor = True
        '
        'OptionD
        '
        Me.OptionD.Location = New System.Drawing.Point(981, 412)
        Me.OptionD.Name = "OptionD"
        Me.OptionD.Size = New System.Drawing.Size(304, 95)
        Me.OptionD.TabIndex = 7
        Me.OptionD.Text = "OptionD"
        Me.OptionD.UseVisualStyleBackColor = True
        '
        'QuestionTemplateBeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 636)
        Me.Controls.Add(Me.OptionD)
        Me.Controls.Add(Me.OptionC)
        Me.Controls.Add(Me.OptionB)
        Me.Controls.Add(Me.OptionA)
        Me.Controls.Add(Me.QuestionBox)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "QuestionTemplateBeta"
        Me.Text = "QuestionTemplateBeta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents QuestionBox As TextBox
    Friend WithEvents OptionA As Button
    Friend WithEvents OptionB As Button
    Friend WithEvents OptionC As Button
    Friend WithEvents OptionD As Button
End Class
