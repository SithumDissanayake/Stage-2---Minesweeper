Public Class frmMainMenu
    'PLEASE READ THE README.txt FILE BEFORE STARTING
    Private Sub tmiHome_Click(sender As Object, e As EventArgs) Handles tmiHome.Click
        'When the home button is clicked, this closes this form and displays the main menu
        Me.Hide()
        Me.Show()
    End Sub
    Private Sub rdoBeginner_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBeginner.CheckedChanged
        'Changes the difficulty to 1 when this radio button is selected
        playerDifficulty = 1
    End Sub

    Private Sub rdoIntermediate_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIntermediate.CheckedChanged
        'Changes the difficulty to 2 when this radio button is selected
        playerDifficulty = 2
    End Sub

    Private Sub rdoExpert_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExpert.CheckedChanged
        'Changes the difficulty to 3 when this radio button is selected
        playerDifficulty = 3
    End Sub
    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        'Displays the instructions form when clicked
        Me.Hide()
        frmInstructions.Show()
    End Sub

    Private Sub btnHighscores_Click(sender As Object, e As EventArgs) Handles btnHighscores.Click
        'Displays the highscores form when clicked
        Me.Hide()
        frmHighscores.Show()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Checks if there is name inputed into the name field and a difficulty selected - if there is it displays the game form
        If txtName.Text = "" AndAlso playerDifficulty = 0 Then
            MsgBox("Please Enter a Valid Name and Difficulty")
        ElseIf txtName.Text = "" Then
            MsgBox("Please Enter a Valid Name")
        ElseIf playerDifficulty = 0 Then
            MsgBox("Please Select a Difficulty")
        Else
            playerName = txtName.Text

            Me.Hide()
            frmGame.Show()
        End If
    End Sub
End Class
