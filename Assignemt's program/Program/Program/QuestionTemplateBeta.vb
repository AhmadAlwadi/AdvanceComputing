Public Class QuestionTemplateBeta
    Dim questions(4) As LinkedList
    Dim answers(4) As Integer
    Dim questionCounter As Integer = 0

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main()
    End Sub

    Private Sub main()
        questions = populateData(questions)
        printData(questions)
        displayQuestion(questions(questionCounter))
    End Sub

    'Procedure to make sure that data exists...
    Private Sub printData(questions() As LinkedList)
        For i = 0 To questions.Length - 1
            TextBox2.Text = TextBox2.Text & questions(i).question & vbTab & questions(i).option_A & vbTab & questions(i).option_B & vbTab & questions(i).option_C & vbTab & questions(i).option_D & vbTab & vbNewLine
        Next
    End Sub

    'Display a specific quesiton
    Private Sub displayQuestion(question As LinkedList)
        QuestionBox.Text = question.question
        OptionA.Text = question.option_A
        OptionB.Text = question.option_B
        OptionC.Text = question.option_C
        OptionD.Text = question.option_D
    End Sub

    'Populate the linked list 
    Public Function populateData(questions() As LinkedList)
        Dim FilePath As String
        FilePath = choose_test.filePath.Text
        FileOpen(1, FilePath, OpenMode.Input)
        For i = 0 To questions.Length - 1
            Input(1, questions(i).b_link)
            Input(1, questions(i).f_link)
            Input(1, questions(i).question)
            Input(1, questions(i).option_A)
            Input(1, questions(i).option_B)
            Input(1, questions(i).option_C)
            Input(1, questions(i).option_D)
            Input(1, questions(i).correct_answer_index)
        Next
        Return questions
    End Function

    'Linked list to be used to delete questions from the list
    Public Structure LinkedList
        Dim f_link As Integer
        Dim b_link As Integer
        Dim question As String
        Dim option_A As String
        Dim option_B As String
        Dim option_C As String
        Dim option_D As String
        Dim correct_answer_index As Integer
    End Structure

    'Those procedures are to store the users' answers and display the next question
    Private Sub OptionA_Click(sender As Object, e As EventArgs) Handles OptionA.Click
        If questionCounter < 4 Then
            answers(questionCounter) = 0
            questionCounter += 1
            TextBox1.Text = TextBox1.Text & Str(questionCounter) & vbNewLine
            displayQuestion(questions(questionCounter))
        End If
    End Sub

    Private Sub OptionB_Click(sender As Object, e As EventArgs) Handles OptionB.Click
        If questionCounter < 5 Then
            answers(questionCounter) = 1
            questionCounter += 1
            TextBox1.Text = TextBox1.Text & Str(questionCounter) & vbNewLine
            displayQuestion(questions(questionCounter))
        End If
    End Sub

    Private Sub OptionC_Click(sender As Object, e As EventArgs) Handles OptionC.Click
        If questionCounter < 5 Then
            answers(questionCounter) = 2
            questionCounter += 1
            TextBox1.Text = TextBox1.Text & Str(questionCounter) & vbNewLine
            displayQuestion(questions(questionCounter))
        End If
    End Sub

    Private Sub OptionD_Click(sender As Object, e As EventArgs) Handles OptionD.Click
        If questionCounter < 5 Then
            answers(questionCounter) = 3
            questionCounter += 1
            TextBox1.Text = TextBox1.Text & Str(questionCounter) & vbNewLine
            displayQuestion(questions(questionCounter))
        End If
    End Sub
End Class