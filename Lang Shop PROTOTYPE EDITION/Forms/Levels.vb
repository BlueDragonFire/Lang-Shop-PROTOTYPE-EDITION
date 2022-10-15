Public Class Levels

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If GlobalVariables.Game = 0 Then

            Me.Hide()
            ML1.Show()

        ElseIf GlobalVariables.Game = 1 Then

            Me.Hide()
            NL1.Show()

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If GlobalVariables.Game = 0 Then

            Me.Hide()
            ML2.Show()

        ElseIf GlobalVariables.Game = 1 Then

            Me.Hide()
            NL2.Show()


        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If GlobalVariables.Game = 0 Then

            Me.Hide()
            ML3.Show()

        ElseIf GlobalVariables.Game = 1 Then

            Me.Hide()
            NL3.Show()

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If GlobalVariables.Game = 0 Then

            Me.Hide()
            ML4.Show()

        ElseIf GlobalVariables.Game = 1 Then

            Me.Hide()
            NL4.Show()

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If GlobalVariables.Game = 0 Then

            Me.Hide()
            ML5.Show()

        ElseIf GlobalVariables.Game = 1 Then

            Me.Hide()
            NL5.Show()

        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Application.Exit()

    End Sub

    Private Sub Levels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.Close()
        Mini_games.Show()

    End Sub
End Class