Public Class ML5

    Private Sub ML5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim instructions As New LingualPhrases
        Dim ML As New MissingLettersClass
        instructions.blah()
        ML.answers()


        If GlobalVariables.InstLang = 0 Then

            Label1.Text = instructions.ML(0)

        ElseIf GlobalVariables.InstLang = 1 Then

            Label1.Text = instructions.ML(1)

        ElseIf GlobalVariables.InstLang = 2 Then

            Label1.Text = instructions.ML(2)

        End If

        If GlobalVariables.LearnLang = 0 Then

            Label2.Text = "b_ffel" ' Afrikaans

        ElseIf GlobalVariables.LearnLang = 1 Then

            Label2.Text = "d_ck" ' English

        ElseIf GlobalVariables.LearnLang = 2 Then

            Label2.Text = "_s_k_" ' Zulu

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim input As String
        Dim ML As New MissingLettersClass
        ML.answers()

        input = CStr(TextBox1.Text)

        If input = ML.vowels(4) Then

            MessageBox.Show("YOU WON THE LEVEL! This has been the final level for the prototype version of the game. We hope you enjoyed it! :3", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Else

            MessageBox.Show("Sorry, you lost.", "Better luck next time", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Me.Close()
        Levels.Show()

    End Sub
End Class