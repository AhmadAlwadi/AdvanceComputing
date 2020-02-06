Public Class choose_test
    Private Sub start_test_Click(sender As Object, e As EventArgs) Handles start_test.Click
        Dim test_type As String
        test_type = DropDownMenu.SelectedItem.ToString()
        'This if statement is defining the test type so I can use it in the file_path variable 
        Label2.Text = test_type
        If test_type = "OOP Knowledge" Then
            test_type = "OOP_Questions"
        ElseIf test_type = "Standard Algorithms" Then
            test_type = "Standard_Algo_Questions"
        ElseIf test_type = "SQL Knowledge" Then
            test_type = "SQL_Knowledge"
        End If
        'defining the respective file's path
        Dim file_path As String = "D:\Programming\AdvComp\Assignment\Questions\" + test_type + ".csv"
        filePath.Text = file_path
        Me.Hide()
        QuestionTemplateBeta.Show()
    End Sub

    'This sub is for the go_back image 
    Private Sub go_back_click(sender As Object, e As EventArgs) Handles go_back.Click
        Me.Hide()
        start_menu.Show()
    End Sub

    Private Sub filePath_Click(sender As Object, e As EventArgs) Handles filePath.Click

    End Sub
End Class