<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class leaderboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(leaderboard))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.go_back = New System.Windows.Forms.PictureBox()
        CType(Me.go_back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(653, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'go_back
        '
        Me.go_back.Image = CType(resources.GetObject("go_back.Image"), System.Drawing.Image)
        Me.go_back.Location = New System.Drawing.Point(12, 12)
        Me.go_back.Name = "go_back"
        Me.go_back.Size = New System.Drawing.Size(53, 27)
        Me.go_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.go_back.TabIndex = 1
        Me.go_back.TabStop = False
        '
        'leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.go_back)
        Me.Controls.Add(Me.Button1)
        Me.Name = "leaderboard"
        Me.Text = "Leaderboard "
        CType(Me.go_back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents go_back As PictureBox
End Class
