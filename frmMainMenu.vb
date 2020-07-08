Public Class frmMainMenu
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        frmGame.Show()
    End Sub
End Class
