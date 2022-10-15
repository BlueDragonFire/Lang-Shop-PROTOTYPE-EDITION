Public Class Main

    Private Sub btnAfrikaans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAfrikaans.Click
        Dim blah As New GlobalVariables
        blah.InstLang = 0

        Me.Hide()
        Afrikaans.Show()

    End Sub

    Private Sub btnEnglish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnglish.Click
        Dim blah As New GlobalVariables
        blah.InstLang = 1

        Me.Hide()
        English.Show()
    End Sub

    Private Sub btnZulu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZulu.Click
        Dim blah As New GlobalVariables
        blah.InstLang = 2

        Me.Hide()
        Zulu.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
