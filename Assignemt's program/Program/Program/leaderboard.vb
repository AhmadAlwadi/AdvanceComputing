Imports System.Data.OleDb
Public Class leaderboard
    Private Sub go_back_Click(sender As Object, e As EventArgs) Handles go_back.Click
        Me.Hide()
        start_menu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This is creating the connection with the database
        Try
            Dim SQLReader As OleDbDataReader
            Dim connection_type As String = "Provider = Microsoft.JET.OleDB.4.0;"
            Dim file_location As String = "Data Source = E:\ADV computing\Assignment\Database\User database.mdb"
            Dim conn As OleDbConnection
            conn = New OleDbConnection(connection_type & file_location)
            conn.Open()
            'this catches any possible errors
        Catch ex As Exception
            'TextBox2.Text = ex.Message
        End Try
    End Sub

    Private Sub leaderboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class