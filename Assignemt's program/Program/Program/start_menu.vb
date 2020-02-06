Public Class start_menu
    Private Sub set_test_Click(sender As Object, e As EventArgs) Handles set_test.Click
        Me.Hide()
        choose_test.Show()
    End Sub
    Private Sub go_to_leaderboard_click(sender As Object, e As EventArgs) Handles go_to_leaderboard.Click
        leaderboard.Show()
        Me.Hide()
    End Sub
End Class