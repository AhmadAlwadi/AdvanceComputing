<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class choose_test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(choose_test))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.start_test = New System.Windows.Forms.Button()
        Me.go_back = New System.Windows.Forms.PictureBox()
        Me.DropDownMenu = New System.Windows.Forms.ComboBox()
        Me.filePath = New System.Windows.Forms.Label()
        CType(Me.go_back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pick A Test!"
        '
        'start_test
        '
        Me.start_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_test.Location = New System.Drawing.Point(700, 410)
        Me.start_test.Name = "start_test"
        Me.start_test.Size = New System.Drawing.Size(88, 28)
        Me.start_test.TabIndex = 1
        Me.start_test.Text = "GO!"
        Me.start_test.UseVisualStyleBackColor = True
        '
        'go_back
        '
        Me.go_back.Image = CType(resources.GetObject("go_back.Image"), System.Drawing.Image)
        Me.go_back.Location = New System.Drawing.Point(12, 12)
        Me.go_back.Name = "go_back"
        Me.go_back.Size = New System.Drawing.Size(53, 27)
        Me.go_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.go_back.TabIndex = 5
        Me.go_back.TabStop = False
        '
        'DropDownMenu
        '
        Me.DropDownMenu.AllowDrop = True
        Me.DropDownMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropDownMenu.FormattingEnabled = True
        Me.DropDownMenu.Items.AddRange(New Object() {"OOP Knowledge ", "SQL Knowledge", "Standard Algorithms"})
        Me.DropDownMenu.Location = New System.Drawing.Point(284, 181)
        Me.DropDownMenu.Name = "DropDownMenu"
        Me.DropDownMenu.Size = New System.Drawing.Size(190, 28)
        Me.DropDownMenu.TabIndex = 6
        Me.DropDownMenu.Text = "Select From...."
        '
        'filePath
        '
        Me.filePath.AutoSize = True
        Me.filePath.Location = New System.Drawing.Point(594, 48)
        Me.filePath.Name = "filePath"
        Me.filePath.Size = New System.Drawing.Size(48, 13)
        Me.filePath.TabIndex = 7
        Me.filePath.Text = "File Path"
        '
        'choose_test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.filePath)
        Me.Controls.Add(Me.DropDownMenu)
        Me.Controls.Add(Me.go_back)
        Me.Controls.Add(Me.start_test)
        Me.Controls.Add(Me.Label1)
        Me.Name = "choose_test"
        Me.Text = "choose_test"
        CType(Me.go_back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents start_test As Button
    Friend WithEvents go_back As PictureBox
    Friend WithEvents DropDownMenu As ComboBox
    Friend WithEvents filePath As Label
End Class
