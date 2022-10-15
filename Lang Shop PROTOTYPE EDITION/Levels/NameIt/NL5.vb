Public Class NL5

    Private Sub NL5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim phrase As New LingualPhrases
        Dim name As New NameItClass
        phrase.blah()

        If GlobalVariables.InstLang = 0 Then

            Label1.Text = phrase.NL(0)

        ElseIf GlobalVariables.InstLang = 1 Then

            Label1.Text = phrase.NL(1)

        ElseIf GlobalVariables.InstLang = 2 Then

            Label1.Text = phrase.NL(2)

        End If

        If GlobalVariables.LearnLang = 0 Then 'Afrikaans

            Dim words As New NameItClass
            words.Aanswers()

            btnWrong1.Text = words.Anames(1)
            btnWrong2.Text = words.Anames(2)
            btnRight.Text = words.Anames(4)

        ElseIf GlobalVariables.LearnLang = 1 Then 'English

            Dim words As New NameItClass
            words.Eanswers()

            btnWrong1.Text = words.Enames(1)
            btnWrong2.Text = words.Enames(2)
            btnRight.Text = words.Enames(4)

        ElseIf GlobalVariables.LearnLang = 2 Then 'Zulu

            Dim words As New NameItClass
            words.Zanswers()

            btnWrong1.Text = words.Znames(1)
            btnWrong2.Text = words.Znames(2)
            btnRight.Text = words.Znames(4)

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub


    Private Sub btnWrong1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrong1.Click
        MessageBox.Show("Sorry, you lost.", "Better luck next time", MessageBoxButtons.OK, MessageBoxIcon.Error)
        btnWrong1.BackColor = Color.Red

    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        btnRight.BackColor = Color.Green
        MessageBox.Show("YOU WON THE LEVEL! This has been the final level for the prototype version of the game. We hope you enjoyed it! :3", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Me.Close()
        Levels.Show()

    End Sub

    Private Sub btnWrong2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrong2.Click
        MessageBox.Show("Sorry, you lost.", "Better luck next time", MessageBoxButtons.OK, MessageBoxIcon.Error)
        btnWrong2.BackColor = Color.Red

    End Sub
End Class