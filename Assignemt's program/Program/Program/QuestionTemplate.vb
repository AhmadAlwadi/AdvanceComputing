Public Class QuestionTemplate
    Dim questions(4) As data_node
    'This counter has to be used to keep track of what question the user is currently on 
    'It has to be a public(global) variable as I if it was inside a sub, it will always 
    '   be initalised With the value zero And that will ovverride the previous value
    Dim QuestionCounter As Integer = -1

    'This variable will hold the user's answers in an array so they can be checked later and the score calculated 
    'It is an integer value as it will hold the respective index of the radio button selected 
    Dim UsersAnswers(4) As Integer
    Dim NextQuestionClicked As Boolean = False

    'This button starts the test
    Public Sub start_Click(sender As Object, e As EventArgs) Handles Start.Click
        populate_linked_list(questions)
        A.Visible = True
        B.Visible = True
        C.Visible = True
        D.Visible = True
        questionBox.Visible = True
        NextQuestion.Visible = True
        Start.Visible = False
        TextBox1.Text = TextBox1.Text + "Form should be user ready" + vbNewLine
        DisplayQuestions(questions)
    End Sub

    Private Sub NextQuestion_Click(sender As Object, e As EventArgs) Handles NextQuestion.Click
        NextQuestionClicked = True
    End Sub

    'This procedure will display a new question on the form
    Private Sub DisplayQuestions(Questions() As data_node)
        'This is a refactored version of the code below, cuz it has way too many bugs and couldn't be bother debugging it
        Dim i As Integer = 0
        TextBox1.Text = TextBox1.Text + "Now displaying quesitons" + vbNewLine
        Do
            questionBox.Text = Questions(i).question
        Loop Until NextQuestionClicked = True
    End Sub

    Private Sub populate_linked_list(questions() As data_node)
        Dim file_path As String
        file_path = choose_test.filePath.Text
        TextBox1.Text = TextBox1.Text + "Questions imported correctly" & file_path + vbNewLine
        Label1.Text = file_path
        FileOpen(1, file_path, OpenMode.Input)
        For i = 0 To 4
            Input(1, questions(i).b_link)
            Input(1, questions(i).f_link)
            Input(1, questions(i).question)
            Input(1, questions(i).option_A)
            Input(1, questions(i).option_B)
            Input(1, questions(i).option_C)
            Input(1, questions(i).option_D)
            Input(1, questions(i).correct_answer_index)
        Next

    End Sub

    'This sub is for picking the question, every question will be removed from the linked list after it has been picked 
    Private Sub picking_questions(ByRef questions As data_node)

    End Sub

    'This sub will delete elements from the linked list
    Private Sub remove_question(ByRef questions As data_node)

    End Sub

    Private Structure data_node
        Dim f_link As Integer
        Dim b_link As Integer
        Dim question As String
        Dim option_A As String
        Dim option_B As String
        Dim option_C As String
        Dim option_D As String
        Dim correct_answer_index As Integer
    End Structure
End Class