Public Class frmMainMenu
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        Me.Show()
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

        If txtName.Text = "" AndAlso difficulty = 0 Then
            MsgBox("Please Enter a Valid Name and Difficulty")
        ElseIf txtName.Text = "" Then
            MsgBox("Please Enter a Valid Name")

        ElseIf difficulty = 0 Then
            MsgBox("Please Select a Difficulty")

        Else
            playerName = txtName.Text

        Me.Hide()
        frmGame.Show()
        End If
    End Sub
End Class
