Public Class StartMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim questions(4) As data_node
        populate_linked_list(questions)
        print_data(questions)
    End Sub

    Private Sub print_data(questions() As data_node)
        For i = 0 To questions.Length - 1
            TextBox1.Text = TextBox1.Text + Str(questions(i).b_link) + vbTab + questions(i).question + vbTab + questions(i).answer + vbTab + Str(questions(i).f_link) + vbTab + vbNewLine
        Next
    End Sub

    Private Sub populate_linked_list(questions() As data_node)
        Dim file_path As String = "E:\ADV computing\Assignment\Questions\OOP_Questions.csv"
        FileOpen(1, file_path, OpenMode.Input)
        'dummy data will hold data that is useless such as question number if the question was the first or the last as this data should be changed because it will be used as pointers 
        'idk if that makes sense but oh fuck
        Dim dummy_data As String = ""
        For i = 0 To 4
            If i = 0 Or i = 4 Then
                Input(1, dummy_data)
                If i = 0 Then
                    questions(0).f_link = 1
                    questions(0).b_link = 4
                End If
                If i = 4 Then
                    questions(4).f_link = 0
                    questions(4).b_link = 3
                End If
                Input(1, questions(i).question)
                Input(1, questions(i).answer)
            Else
                questions(i).f_link = i + 1
                questions(i).b_link = i - 1
                Input(1, questions(i).question)
                Input(1, questions(i).answer)
            End If
        Next
    End Sub

    Private Structure data_node
        Dim f_link As Integer
        Dim b_link As Integer
        Dim question As String
        Dim answer As String
    End Structure

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
