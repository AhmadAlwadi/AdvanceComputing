<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class start_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.go_to_leaderboard = New System.Windows.Forms.Button()
        Me.set_test = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Choose An Action:"
        '
        'go_to_leaderboard
        '
        Me.go_to_leaderboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.go_to_leaderboard.Location = New System.Drawing.Point(153, 148)
        Me.go_to_leaderboard.Name = "go_to_leaderboard"
        Me.go_to_leaderboard.Size = New System.Drawing.Size(150, 64)
        Me.go_to_leaderboard.TabIndex = 1
        Me.go_to_leaderboard.Text = "Go To The Leaderboard"
        Me.go_to_leaderboard.UseVisualStyleBackColor = True
        '
        'set_test
        '
        Me.set_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.set_test.Location = New System.Drawing.Point(479, 148)
        Me.set_test.Name = "set_test"
        Me.set_test.Size = New System.Drawing.Size(150, 64)
        Me.set_test.TabIndex = 2
        Me.set_test.Text = "Choose A Test To Set!"
        Me.set_test.UseVisualStyleBackColor = True
        '
        'start_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 405)
        Me.Controls.Add(Me.set_test)
        Me.Controls.Add(Me.go_to_leaderboard)
        Me.Controls.Add(Me.Label1)
        Me.Name = "start_menu"
        Me.Text = "Start Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents go_to_leaderboard As Button
    Friend WithEvents set_test As Button
End Class
