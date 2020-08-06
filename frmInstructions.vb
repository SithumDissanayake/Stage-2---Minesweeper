Public Class frmInstructions
    'PLEASE READ THE README.txt FILE BEFORE STARTING

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