﻿Public Class QuestionTemplateBeta
    Dim questions(9) As QuestionsRecord
    Dim finalQuestions(4) As QuestionsRecord
    Dim answers(4) As Integer
    Dim questionCounter As Integer = 0

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main()
    End Sub

    Private Sub main()
        questions = populateData(questions)
        questions = PickQuestions(questions, finalQuestions)
        printData(finalQuestions)
        displayQuestion(finalQuestions(questionCounter))
    End Sub

    'Procedure to make sure that data exists...
    Private Sub printData(questions() As QuestionsRecord)
        For i = 0 To questions.Length - 1
            TextBox2.Text = TextBox2.Text & questions(i).question & vbNewLine
        Next
    End Sub

    'Display a specific quesiton
    Private Sub displayQuestion(question As QuestionsRecord)
        QuestionBox.Text = question.question
        OptionA.Text = question.option_A
        OptionB.Text = question.option_B
        OptionC.Text = question.option_C
        OptionD.Text = question.option_D
    End Sub

    'Populate the QuestionsRecord 
    Public Function populateData(questions() As QuestionsRecord)
        Dim FilePath As String
        FilePath = choose_test.filePath.Text
        FileOpen(1, FilePath, OpenMode.Input)
        For i = 0 To questions.Length - 1
            Input(1, questions(i).questionID)
            Input(1, questions(i).question)
            Input(1, questions(i).option_A)
            Input(1, questions(i).option_B)
            Input(1, questions(i).option_C)
            Input(1, questions(i).option_D)
            Input(1, questions(i).correct_answer_index)
        Next
        Return questions
    End Function

    'QuestionsRecord to be used to delete questions from the list
    Public Structure QuestionsRecord
        Dim questionID As Integer
        Dim question As String
        Dim option_A As String
        Dim option_B As String
        Dim option_C As String
        Dim option_D As String
        Dim correct_answer_index As Integer
    End Structure

    'This function will pick random questions from the origianl quesitons list for the user
    Private Function PickQuestions(questions() As QuestionsRecord, finalQuestions() As QuestionsRecord)
        Dim RandomIndex As Integer
        Dim isThereDuplicate As Boolean = False
        'This number should be a random number between 0 and the length of the original question list & it will indicate an index
        'Putting in a while loop to only accept non duplicated questions
        Randomize()
        For i = 0 To finalQuestions.Length - 1
            Do
                RandomIndex = Int(9 * Rnd())
                isThereDuplicate = CheckForDupluicates(questions, RandomIndex, finalQuestions)
            Loop Until isThereDuplicate = False
            finalQuestions(i) = questions(RandomIndex)
        Next
        Return finalQuestions
    End Function

    Private Function CheckForDupluicates(ByRef questions() As QuestionsRecord, ByRef index As Integer, ByRef FinalQuestions() As QuestionsRecord)
        Dim IdToCheck As Integer = questions(index).questionID
        Dim isThereDuplicate As Boolean = False
        For i = 0 To FinalQuestions.Length - 1
            If FinalQuestions(i).questionID = IdToCheck Then
                isThereDuplicate = True
            End If
        Next
        Return isThereDuplicate
    End Function

    'Those procedures are to store the users' answers and display the next question
    Private Sub OptionA_Click(sender As Object, e As EventArgs) Handles OptionA.Click
        'This if statement checks if the user hasn't gone over the max number of questions
        If questionCounter < finalQuestions.Length - 1 Then
            answers(questionCounter) = 0
            questionCounter += 1
            TextBox1.Text = TextBox1.Text & Str(questionCounter) & vbNewLine
            displayQuestion(questions(questionCounter))
        End If
    End Sub

    Private Sub OptionB_Click(sender As Object, e As EventArgs) Handles OptionB.Click
        If questionCounter < finalQuestions.Length - 1 Then
            answers(questionCounter) = 1
            questionCounter += 1
            TextBox1.Text = TextBox1.Text & Str(questionCounter) & vbNewLine
            displayQuestion(questions(questionCounter))
        End If
    End Sub

    Private Sub OptionC_Click(sender As Object, e As EventArgs) Handles OptionC.Click
        If questionCounter < finalQuestions.Length - 1 Then
            answers(questionCounter) = 2
            questionCounter += 1
            TextBox1.Text = TextBox1.Text & Str(questionCounter) & vbNewLine
            displayQuestion(questions(questionCounter))
        End If
    End Sub

    Private Sub OptionD_Click(sender As Object, e As EventArgs) Handles OptionD.Click
        If questionCounter < finalQuestions.Length - 1 Then
            answers(questionCounter) = 3
            questionCounter += 1
            TextBox1.Text = TextBox1.Text & Str(questionCounter) & vbNewLine
            displayQuestion(questions(questionCounter))
        End If
    End Sub
End Class