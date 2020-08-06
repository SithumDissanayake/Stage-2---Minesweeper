Public Class frmHighscores
    'PLEASE READ THE README.txt FILE BEFORE STARTING

    Private Sub frmHighscores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reads the txt file for every difficulty and displays them in their corsponding listbox
        Dim arrHighScores(9) As recHighscore

        For i = 1 To 3
            FileSystem.FileOpen(1, Application.StartupPath() & ”\highscores\highscores" & i & ".txt”, OpenMode.Input)
            For j = 0 To 9
                FileSystem.Input(1, arrHighScores(j).name)
                FileSystem.Input(1, arrHighScores(j).score)

                'Displays the highscores from the file selected into the appropriate listbox
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
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'When the back button is clicked, this closes this form and displays the main menu
        Me.Close()
        frmMainMenu.Show()
    End Sub
    Private Sub tmiHome_Click(sender As Object, e As EventArgs) Handles tmiHome.Click
        'When the home button is clicked, this closes this form and displays the main menu
        Me.Close()
        frmMainMenu.Show()
    End Sub
End Class