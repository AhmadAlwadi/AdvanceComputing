<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionTemplate
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
        Me.questionBox = New System.Windows.Forms.TextBox()
        Me.NextQuestion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.A = New System.Windows.Forms.RadioButton()
        Me.B = New System.Windows.Forms.RadioButton()
        Me.C = New System.Windows.Forms.RadioButton()
        Me.D = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'questionBox
        '
        Me.questionBox.Location = New System.Drawing.Point(238, 78)
        Me.questionBox.Multiline = True
        Me.questionBox.Name = "questionBox"
        Me.questionBox.Size = New System.Drawing.Size(639, 43)
        Me.questionBox.TabIndex = 1
        Me.questionBox.Visible = False
        '
        'NextQuestion
        '
        Me.NextQuestion.Location = New System.Drawing.Point(477, 382)
        Me.NextQuestion.Name = "NextQuestion"
        Me.NextQuestion.Size = New System.Drawing.Size(95, 23)
        Me.NextQuestion.TabIndex = 10
        Me.NextQuestion.Text = "Next Question"
        Me.NextQuestion.UseVisualStyleBackColor = True
        Me.NextQuestion.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(477, 353)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(95, 23)
        Me.Start.TabIndex = 13
        Me.Start.Text = "Start Test"
        Me.Start.UseVisualStyleBackColor = True
        '
        'A
        '
        Me.A.AutoSize = True
        Me.A.Location = New System.Drawing.Point(238, 198)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(90, 17)
        Me.A.TabIndex = 14
        Me.A.TabStop = True
        Me.A.Text = "RadioButton1"
        Me.A.UseVisualStyleBackColor = True
        Me.A.Visible = False
        '
        'B
        '
        Me.B.AutoSize = True
        Me.B.Location = New System.Drawing.Point(787, 198)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(90, 17)
        Me.B.TabIndex = 15
        Me.B.TabStop = True
        Me.B.Text = "RadioButton2"
        Me.B.UseVisualStyleBackColor = True
        Me.B.Visible = False
        '
        'C
        '
        Me.C.AutoSize = True
        Me.C.Location = New System.Drawing.Point(238, 273)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(90, 17)
        Me.C.TabIndex = 16
        Me.C.TabStop = True
        Me.C.Text = "RadioButton3"
        Me.C.UseVisualStyleBackColor = True
        Me.C.Visible = False
        '
        'D
        '
        Me.D.AutoSize = True
        Me.D.Location = New System.Drawing.Point(787, 273)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(90, 17)
        Me.D.TabIndex = 17
        Me.D.TabStop = True
        Me.D.Text = "RadioButton4"
        Me.D.UseVisualStyleBackColor = True
        Me.D.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 411)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1048, 165)
        Me.TextBox1.TabIndex = 18
        '
        'QuestionTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 588)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NextQuestion)
        Me.Controls.Add(Me.questionBox)
        Me.Name = "QuestionTemplate"
        Me.Text = "QuestionTemplate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents questionBox As TextBox
    Friend WithEvents NextQuestion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Start As Button
    Friend WithEvents A As RadioButton
    Friend WithEvents B As RadioButton
    Friend WithEvents C As RadioButton
    Friend WithEvents D As RadioButton
    Friend WithEvents TextBox1 As TextBox
End Class
