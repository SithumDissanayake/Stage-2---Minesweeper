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
        Dim arrBeginnerHighScores(9) As recHighscore
        Dim arrIntermediateHighScores(9) As recHighscore
        Dim arrExpertHighScores(9) As recHighscore

        FileSystem.FileOpen(1, Application.StartupPath() & ”\beginnerHighscores.txt”, OpenMode.Input)
        For i = 0 To 9
            FileSystem.Input(1, arrBeginnerHighScores(i).name)
            FileSystem.Input(1, arrBeginnerHighScores(i).score)

            If arrBeginnerHighScores(i).score <> "" Then
                lstBeginnerHighscores.Items.Add(Space(15) & arrBeginnerHighScores(i).name & ":    " & arrBeginnerHighScores(i).score)
            End If
        Next i
        FileSystem.FileClose(1)


        FileSystem.FileOpen(1, Application.StartupPath() & ”\intermediateHighscores.txt”, OpenMode.Input)
        For i = 0 To 9
            FileSystem.Input(1, arrIntermediateHighScores(i).name)
            FileSystem.Input(1, arrIntermediateHighScores(i).score)

            If arrIntermediateHighScores(i).score <> "" Then
                lstIntermediateHighscores.Items.Add(Space(15) & arrIntermediateHighScores(i).name & ":    " & arrIntermediateHighScores(i).score)
            End If
        Next i
        FileSystem.FileClose(1)


        FileSystem.FileOpen(1, Application.StartupPath() & ”\expertHighscores.txt”, OpenMode.Input)
        For i = 0 To 9
            FileSystem.Input(1, arrExpertHighScores(i).name)
            FileSystem.Input(1, arrExpertHighScores(i).score)

            If arrExpertHighScores(i).score <> "" Then
                lstExpertHighscores.Items.Add(Space(15) & arrExpertHighScores(i).name & ":    " & arrExpertHighScores(i).score)
            End If
        Next i
        FileSystem.FileClose(1)


    End Sub

End Class