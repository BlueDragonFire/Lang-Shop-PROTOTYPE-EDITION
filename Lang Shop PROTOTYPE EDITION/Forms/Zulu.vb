Public Class Zulu

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub


    Private Sub btnAfrikaans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfrikaans.Click

        GlobalVariables.LearnLang = 0

        Me.Hide()
        Mini_games.Show()

    End Sub

    Private Sub btnEnglish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnglish.Click

        GlobalVariables.LearnLang = 1

        Me.Hide()
        Mini_games.Show()

    End Sub

    Private Sub btnZulu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZulu.Click
        GlobalVariables.LearnLang = 2

        Me.Hide()
        Mini_games.Show()

    End Sub

End Class