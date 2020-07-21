Public Class frmGame
    'All variable names: playerName, difficulty
    'https://www.1001fonts.com/crashed-scoreboard-font.html
    Dim playerTimer As Integer
    Dim totalFreeSquares As Integer
    Dim userClickedSquares As Integer

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim gameGrid(0, 0) As Integer

        Dim totalMines As Integer
        Dim gridYLength As Integer
        Dim gridXLength As Integer

        userClickedSquares = 0
        playerTimer = 0

        timPlayer.Start()

        lblPlayerName.Text = frmMainMenu.playerName
        lblPlayerName.Left = (pnlGameBar.Width - lblPlayerName.Width) / 2

        totalMines = difficultySetMines(frmMainMenu.difficulty)
        gridXLength = difficultySelectX(frmMainMenu.difficulty)
        gridYLength = difficultySelectY(frmMainMenu.difficulty)

        totalFreeSquares = ((gridXLength + 1) * (gridYLength + 1)) - totalMines

        lblSquaresLeft.Text = totalFreeSquares.ToString().PadLeft(6, "0")

        ReDim gameGrid(gridXLength, gridYLength)

        setGrid(gameGrid, gridXLength, gridYLength)

        generateMines(gameGrid, gridXLength, gridYLength, totalMines)

        populateSquares(gameGrid, gridXLength, gridYLength)

        testbuttons(gameGrid, gridXLength, gridYLength)


        Dim x, y As Integer
        Dim temp As String
        For y = 0 To gridYLength
            temp = ""
            For x = 0 To gridXLength
                temp = temp & " " & gameGrid(x, y)
            Next x
            ListBox1.Items.Add(temp)
        Next y
    End Sub

    Function difficultySelectX(difficulty As Integer) As Integer
        If difficulty = 1 Then
            Return 8
        ElseIf difficulty = 2 Then
            Return 15
        Else
            Return 29
        End If
    End Function
    Function difficultySelectY(difficulty As Integer) As Integer
        If difficulty = 1 Then
            Return 8
        Else
            Return 15
        End If
    End Function
    Function difficultySetMines(difficulty As Integer) As Integer
        If difficulty = 1 Then
            Return 10
        ElseIf difficulty = 2 Then
            Return 40
        Else
            Return 99
        End If
    End Function
    Function setGrid(gameGrid(,) As Integer, gridXLength As Integer, gridYLength As Integer) As Integer

        For x = 0 To gridXLength
            For y = 0 To gridYLength
                gameGrid(x, y) = 0
            Next y
        Next x

        Return gameGrid(gridXLength, gridYLength)
    End Function
    Function generateMines(gameGrid(,) As Integer, gridXLength As Integer, gridYLength As Integer, totalMines As Integer) As Integer
        Dim checkMines As Integer
        Dim x As Integer
        Dim y As Integer

        checkMines = 0

        While checkMines <> totalMines
            x = RandBetween(0, gridXLength)
            y = RandBetween(0, gridYLength)

            If gameGrid(x, y) <> 9 Then
                gameGrid(x, y) = 9
                checkMines = checkMines + 1
            End If
        End While

        Return gameGrid(gridXLength, gridYLength)
    End Function
    Public Function RandBetween(Low As Integer, High As Integer) As Integer
        Randomize()
        RandBetween = Int((High - Low + 1) * Rnd()) + Low
    End Function



    Function populateSquares(gameGrid(,) As Integer, gridXLength As Integer, gridYLength As Integer) As Integer
        Dim x As Integer
        Dim y As Integer
        Dim yTop As Integer
        Dim yBottom As Integer
        Dim xLeft As Integer
        Dim xRight As Integer

        Dim xLimit As Integer
        Dim yLimit As Integer

        xLimit = gridXLength + 1
        yLimit = gridYLength + 1

        For x = 0 To gridXLength
            For y = 0 To gridYLength
                If gameGrid(x, y) = 9 Then
                    yTop = y + 1
                    yBottom = y - 1
                    xLeft = x - 1
                    xRight = x + 1

                    If xLeft <> -1 AndAlso yTop <> yLimit AndAlso gameGrid(xLeft, yTop) <> 9 Then
                        gameGrid(xLeft, yTop) = gameGrid(xLeft, yTop) + 1
                    End If

                    If yTop <> yLimit AndAlso gameGrid(x, yTop) <> 9 Then
                        gameGrid(x, yTop) = gameGrid(x, yTop) + 1
                    End If

                    If xRight <> xLimit AndAlso yTop <> yLimit AndAlso gameGrid(xRight, yTop) <> 9 Then
                        gameGrid(xRight, yTop) = gameGrid(xRight, yTop) + 1
                    End If

                    If xLeft <> -1 AndAlso gameGrid(xLeft, y) <> 9 Then
                        gameGrid(xLeft, y) = gameGrid(xLeft, y) + 1
                    End If

                    If xRight <> xLimit AndAlso gameGrid(xRight, y) <> 9 Then
                        gameGrid(xRight, y) = gameGrid(xRight, y) + 1
                    End If

                    If xLeft <> -1 AndAlso yBottom <> -1 AndAlso gameGrid(xLeft, yBottom) <> 9 Then
                        gameGrid(xLeft, yBottom) = gameGrid(xLeft, yBottom) + 1
                    End If

                    If yBottom <> -1 AndAlso gameGrid(x, yBottom) <> 9 Then
                        gameGrid(x, yBottom) = gameGrid(x, yBottom) + 1
                    End If

                    If xRight <> xLimit AndAlso yBottom <> -1 AndAlso gameGrid(xRight, yBottom) <> 9 Then
                        gameGrid(xRight, yBottom) = gameGrid(xRight, yBottom) + 1
                    End If

                End If
            Next y
        Next x

        Return gameGrid(gridXLength, gridYLength)
    End Function


    Dim pnlGame As New Panel

    Sub testbuttons(gamegrid(,) As Integer, gridXLength As Integer, gridYLength As Integer)
        Dim x, y As Integer

        pnlGame.Controls.Clear()

        pnlGame.Name = "pnlGame"

        If gridXLength = 8 Then
            pnlGame.Width = 219
            pnlGame.Height = 222
            pnlGame.Top = 90
        ElseIf gridXLength = 15 Then
            pnlGame.Width = 387
            pnlGame.Height = 390
            pnlGame.Top = 6
        ElseIf gridXLength = 29 Then
            pnlGame.Width = 723
            pnlGame.Height = 390
            pnlGame.Top = 6
        End If

        pnlGame.Left = (pnlGameArea.Width - pnlGame.Width) / 2
        pnlGameArea.Controls.Add(pnlGame)
        pnlGame.BringToFront()


        For y = 0 To gridYLength
            For x = 0 To gridXLength
                Dim test As New Button
                test.Name = x & y & gamegrid(x, y)

                test.Height = 25
                test.Width = 25

                test.Left = test.Left + (24 * x)
                test.Top = test.Top + (24 * y)

                'https://stackoverflow.com/a/37803054
                test.TabStop = False

                AddHandler test.Click, AddressOf Btn_Click

                pnlGame.Controls.Add(test)


                Dim test2 As New Label
                test2.Text = gamegrid(x, y)
                test2.Font = New Font(test2.Font, FontStyle.Bold)
                test2.TextAlign = ContentAlignment.MiddleCenter
                test2.BackColor = Color.LightGray

                test2.Height = 25
                test2.Width = 25

                test2.Left = test2.Left + (24 * x)
                test2.Top = test2.Top + (24 * y)

                If gamegrid(x, y) = 0 Then
                    test2.ForeColor = Color.LightGray
                ElseIf gamegrid(x, y) = 1 Then
                    test2.ForeColor = Color.Blue
                ElseIf gamegrid(x, y) = 2 Then
                    test2.ForeColor = Color.Green
                ElseIf gamegrid(x, y) = 3 Then
                    test2.ForeColor = Color.Red
                ElseIf gamegrid(x, y) = 4 Then
                    test2.ForeColor = Color.BlueViolet
                ElseIf gamegrid(x, y) = 5 Then
                    test2.ForeColor = Color.Maroon
                ElseIf gamegrid(x, y) = 6 Then
                    test2.ForeColor = Color.Cyan
                ElseIf gamegrid(x, y) = 7 Then
                    test2.ForeColor = Color.Black
                ElseIf gamegrid(x, y) = 8 Then
                    test2.ForeColor = Color.Gray
                Else
                    test2.Image = Image.FromFile("mine.jpg")
                End If

                pnlGame.Controls.Add(test2)

            Next x
        Next y
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs)
        Dim freeSquares As Integer
        'MsgBox(sender.name)

        sender.visible = False

        'https://social.technet.microsoft.com/wiki/contents/articles/53077.winforms-get-all-controls-of-a-specific-type-vb-net.aspx


        'For Each child As Control In pnlGame.Controls
        '    If Strings.Right(sender.name, 1) = 0 AndAlso Strings.Right(child.Name, 1) = "0" Then

        '        child.Visible = False

        '    End If
        'Next child


        userClickedSquares = userClickedSquares + 1

        freeSquares = totalFreeSquares - userClickedSquares

        If userClickedSquares = totalFreeSquares Then
            timPlayer.Stop()
            frmGameWin.Show()
            writeHighscore()
            MsgBox("gamewin")

        ElseIf strings.right(sender.name, 1) = 9 Then
            MsgBox("gameover")
            frmGameLose.Show()
        Else
            'https://stackoverflow.com/questions/3102808/how-can-i-get-0-in-front-of-any-number
            lblSquaresLeft.Text = freeSquares.ToString().PadLeft(6, "0")
        End If

    End Sub

    Sub writeHighscore()
        Dim arrRead(9) As frmHighscores.recHighscore

        If frmMainMenu.difficulty = 1 Then
            FileSystem.FileOpen(1, Application.StartupPath() & ”\beginnerHighscores.txt”, OpenMode.Input)
            For i = 0 To 9
                FileSystem.Input(1, arrRead(i).name)
                FileSystem.Input(1, arrRead(i).score)

            Next i
            FileSystem.FileClose(1)

            For i = 0 To 9
                If playerTimer < arrRead(i).score Then
                    For j = 9 To i Step -1
                        arrRead(j).name = arrRead(j - 1).name
                        arrRead(j).score = arrRead(j - 1).score
                    Next j
                    arrRead(i).name = frmMainMenu.playerName
                    arrRead(i).score = playerTimer
                End If
            Next i

            FileSystem.FileOpen(1, "\beginnerHighscores.txt", OpenMode.Output) '
            For i = 0 To 9
                FileSystem.WriteLine(1, arrRead(i))
            Next i
            FileSystem.FileClose(1)
        ElseIf frmMainMenu.difficulty = 2 Then
            FileSystem.FileOpen(1, Application.StartupPath() & ”\intermediateHighscores.txt”, OpenMode.Input)


        ElseIf frmMainMenu.difficulty = 3 Then
            FileSystem.FileOpen(1, Application.StartupPath() & ”\expertHighscores.txt”, OpenMode.Input)


        End If
    End Sub

    Private Sub timPlayer_Tick(sender As Object, e As EventArgs) Handles timPlayer.Tick
        playerTimer = playerTimer + 1
        lblTimer.Text = playerTimer.ToString().PadLeft(6, "0")
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    Private Sub BeginnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeginnerToolStripMenuItem.Click
        frmMainMenu.difficulty = 1
        frmGame_Load(e, e)
    End Sub

    Private Sub IntermediateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntermediateToolStripMenuItem.Click
        frmMainMenu.difficulty = 2
        frmGame_Load(e, e)
    End Sub

    Private Sub ExpertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpertToolStripMenuItem.Click
        frmMainMenu.difficulty = 3
        frmGame_Load(e, e)
    End Sub
End Class