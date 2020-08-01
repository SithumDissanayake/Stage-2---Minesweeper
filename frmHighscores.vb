Public Class frmHighscores
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        frmMainMenu.Show()
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmMainMenu.Show()
    End Sub


    Public Structure recHighscore
        Public name As String
        Public score As Integer
    End Structure

    Private Sub frmHighscores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrHighScores(9) As recHighscore


        For i = 1 To 3
            FileSystem.FileOpen(1, Application.StartupPath() & ”\highscores" & i & ".txt”, OpenMode.Input)
            For j = 0 To 9
                FileSystem.Input(1, arrHighScores(j).name)
                FileSystem.Input(1, arrHighScores(j).score)

                Select Case i
                    Case 1
                        lstBeginnerHighscores.Items.Add(Space(15) & arrHighScores(j).name & ":    " & arrHighScores(j).score)
                    Case 2
                        lstIntermediateHighscores.Items.Add(Space(15) & arrHighScores(j).name & ":    " & arrHighScores(j).score)
                    Case 3
                        lstExpertHighscores.Items.Add(Space(15) & arrHighScores(j).name & ":    " & arrHighScores(j).score)
                End Select
            Next j

            FileSystem.FileClose(1)

        Next i

    End Sub

End Class