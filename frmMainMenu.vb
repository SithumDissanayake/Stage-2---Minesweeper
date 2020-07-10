Public Class frmMainMenu
    Public playerName As String
    Public difficulty As Integer
    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        playerName = txtName.Text
    End Sub
    Private Sub rdoBeginner_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBeginner.CheckedChanged
        difficulty = 1
    End Sub

    Private Sub rdoIntermediate_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIntermediate.CheckedChanged
        difficulty = 2
    End Sub

    Private Sub rdoExpert_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExpert.CheckedChanged
        difficulty = 3
    End Sub
    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Me.Hide()
        frmInstructions.Show()
    End Sub

    Private Sub btnHighscores_Click(sender As Object, e As EventArgs) Handles btnHighscores.Click
        Me.Hide()
        frmHighscores.Show()
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        frmGame.Show()
    End Sub

End Class
