Public Class frmGame
    'All variable names: playerName, difficulty
    'https://www.1001fonts.com/crashed-scoreboard-font.html
    Dim playerTimer As Integer
    Dim totalFreeSquares As Integer
    Dim userClickedSquares As Integer
    Dim globalGrid(0, 0) As Button

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim gameGrid(0, 0) As Integer

        Dim totalMines As Integer
        Dim gridYLength As Integer
        Dim gridXLength As Integer

        newHighscore = False
        userClickedSquares = 0
        playerTimer = 0

        timPlayer.Start()

        lblPlayerName.Text = playerName
        lblPlayerName.Left = (pnlGameBar.Width - lblPlayerName.Width) / 2

        totalMines = difficultySetMines(difficulty)
        gridXLength = difficultySelectX(difficulty)
        gridYLength = difficultySelectY(difficulty)

        totalFreeSquares = ((gridXLength + 1) * (gridYLength + 1)) - totalMines

        lblSquaresLeft.Text = totalFreeSquares.ToString().PadLeft(6, "0")

        ReDim gameGrid(gridXLength, gridYLength)
        ReDim globalGrid(gridXLength, gridYLength)

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
        Dim difficultySelect As Integer

        Select Case difficulty
            Case 1 : difficultySelect = 8
            Case 2 : difficultySelect = 15
            Case 3 : difficultySelect = 29
        End Select

        Return difficultySelect
    End Function
    Function difficultySelectY(difficulty As Integer) As Integer
        Dim difficultySelect As Integer

        Select Case difficulty
            Case 1 : difficultySelect = 8
            Case 2, 3 : difficultySelect = 15
        End Select

        Return difficultySelect
    End Function
    Function difficultySetMines(difficulty As Integer) As Integer
        Dim difficultySelect As Integer

        Select Case difficulty
            Case 1 : difficultySelect = 10
            Case 2 : difficultySelect = 40
            Case 3 : difficultySelect = 99
        End Select

        Return difficultySelect
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
        'Randomize()
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
                    yTop = y - 1
                    yBottom = y + 1
                    xLeft = x - 1
                    xRight = x + 1

                    If xLeft <> -1 AndAlso yTop <> -1 AndAlso gameGrid(xLeft, yTop) <> 9 Then
                        gameGrid(xLeft, yTop) = gameGrid(xLeft, yTop) + 1
                    End If

                    If yTop <> -1 AndAlso gameGrid(x, yTop) <> 9 Then
                        gameGrid(x, yTop) = gameGrid(x, yTop) + 1
                    End If

                    If xRight <> xLimit AndAlso yTop <> -1 AndAlso gameGrid(xRight, yTop) <> 9 Then
                        gameGrid(xRight, yTop) = gameGrid(xRight, yTop) + 1
                    End If

                    If xLeft <> -1 AndAlso gameGrid(xLeft, y) <> 9 Then
                        gameGrid(xLeft, y) = gameGrid(xLeft, y) + 1
                    End If

                    If xRight <> xLimit AndAlso gameGrid(xRight, y) <> 9 Then
                        gameGrid(xRight, y) = gameGrid(xRight, y) + 1
                    End If

                    If xLeft <> -1 AndAlso yBottom <> yLimit AndAlso gameGrid(xLeft, yBottom) <> 9 Then
                        gameGrid(xLeft, yBottom) = gameGrid(xLeft, yBottom) + 1
                    End If

                    If yBottom <> yLimit AndAlso gameGrid(x, yBottom) <> 9 Then
                        gameGrid(x, yBottom) = gameGrid(x, yBottom) + 1
                    End If

                    If xRight <> xLimit AndAlso yBottom <> yLimit AndAlso gameGrid(xRight, yBottom) <> 9 Then
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

        Select Case gridXLength
            Case 8
                pnlGame.Width = 219
                pnlGame.Height = 222
                pnlGame.Top = 90
            Case 15
                pnlGame.Width = 387
                pnlGame.Height = 390
                pnlGame.Top = 6
            Case 29
                pnlGame.Width = 723
                pnlGame.Height = 390
                pnlGame.Top = 6
        End Select

        pnlGame.Left = (pnlGameArea.Width - pnlGame.Width) / 2
        pnlGameArea.Controls.Add(pnlGame)
        pnlGame.BringToFront()

        For y = 0 To gridYLength
            For x = 0 To gridXLength
                Dim gridButton As New Button
                gridButton.Name = "btn" & x & " " & y & " " & gamegrid(x, y) & " "

                gridButton.Height = 25
                gridButton.Width = 25

                gridButton.Left = gridButton.Left + (24 * x)
                gridButton.Top = gridButton.Top + (24 * y)

                gridButton.Image = Image.FromFile("square.png")
                'https://stackoverflow.com/a/37803054
                gridButton.TabStop = False
                gridButton.Tag = "0"

                AddHandler gridButton.MouseDown, AddressOf Btn_Click

                pnlGame.Controls.Add(gridButton)

                globalGrid(x, y) = gridButton

                Dim gridLabel As New Label
                gridLabel.Text = gamegrid(x, y)
                gridLabel.Font = New Font(gridLabel.Font, FontStyle.Bold)
                gridLabel.TextAlign = ContentAlignment.MiddleCenter
                gridLabel.BackColor = Color.LightGray

                gridLabel.Height = 25
                gridLabel.Width = 25

                gridLabel.Left = gridLabel.Left + (24 * x)
                gridLabel.Top = gridLabel.Top + (24 * y)

                Select Case gamegrid(x, y)
                    Case 0 : gridLabel.ForeColor = Color.LightGray
                    Case 1 : gridLabel.ForeColor = Color.Blue
                    Case 2 : gridLabel.ForeColor = Color.Green
                    Case 3 : gridLabel.ForeColor = Color.Red
                    Case 4 : gridLabel.ForeColor = Color.BlueViolet
                    Case 5 : gridLabel.ForeColor = Color.Maroon
                    Case 6 : gridLabel.ForeColor = Color.Cyan
                    Case 7 : gridLabel.ForeColor = Color.Black
                    Case 8 : gridLabel.ForeColor = Color.Gray
                    Case Else : gridLabel.Image = Image.FromFile("mine.jpg")
                End Select

                pnlGame.Controls.Add(gridLabel)

            Next x
        Next y
    End Sub

    Private Sub Btn_Click(sender As Object, e As MouseEventArgs)


        Select Case e.Button
            Case MouseButtons.Right
                Select Case sender.tag
                    Case "0"
                        sender.image = Image.FromFile("flag.jpg")
                        sender.tag = "1"
                    Case "1"
                        sender.image = Image.FromFile("square.png")
                        sender.tag = "0"
                End Select
            Case MouseButtons.Left
                If sender.tag <> "1" Then
                    Dim freeSquares As Integer

                    Dim testx As Integer
                    Dim testy As Integer
                    Dim testbutton As Integer


                    Dim i As Integer = 3

                    While sender.name(i) <> " "
                        testx = testx & sender.name(i)
                        i = i + 1
                    End While

                    i = i + 1

                    While sender.name(i) <> " "
                        testy = testy & sender.name(i)
                        i = i + 1
                    End While

                    i = i + 1

                    While sender.name(i) <> " "
                        testbutton = testbutton & sender.name(i)
                        i = i + 1
                    End While

                    If testbutton = 0 Then

                        expandButtons(testx, testy, testbutton)
                    Else
                        userClickedSquares = userClickedSquares + 1

                        globalGrid(testx, testy).Visible = False
                    End If

                    freeSquares = totalFreeSquares - userClickedSquares

                        If userClickedSquares = totalFreeSquares Then
                            timPlayer.Stop()
                            playerScore = playerTimer
                            squaresRemaining = freeSquares
                            frmGameWin.ShowDialog()
                            newHighscore = True
                            writeHighscore()

                        ElseIf testbutton = 9 Then
                            globalGrid(testx, testy).Visible = False
                            timPlayer.Stop()
                            playerScore = playerTimer
                            squaresRemaining = freeSquares
                            frmGameLose.ShowDialog()

                        Else
                            'https://stackoverflow.com/questions/3102808/how-can-i-get-0-in-front-of-any-number
                            lblSquaresLeft.Text = freeSquares.ToString().PadLeft(6, "0")

                        End If
                    End If
        End Select



    End Sub

    Sub expandButtons(testx As Integer, testy As Integer, testbutton As Integer)
        Dim yTop As Integer
        Dim yBottom As Integer
        Dim xLeft As Integer
        Dim xRight As Integer
        Dim xLimit As Integer
        Dim yLimit As Integer
        Dim testbuttonNew As Integer


        If globalGrid(testx, testy).Visible <> False AndAlso Strings.Right(globalGrid(testx, testy).Name, 2) <> 9 Then


            globalGrid(testx, testy).Visible = False


            yTop = testy - 1
            yBottom = testy + 1
            xLeft = testx - 1
            xRight = testx + 1
            xLimit = globalGrid.GetLength(0)
            yLimit = globalGrid.GetLength(1)


            If xLeft <> -1 AndAlso yTop <> -1 Then

                testbuttonNew = Strings.Right(globalGrid(xLeft, yTop).Name, 2)
                If testbuttonNew = 0 Then

                    expandButtons(xLeft, yTop, testbuttonNew)

                ElseIf testbuttonNew <> 9 Then
                    userClickedSquares = userClickedSquares + 1

                    globalGrid(xLeft, yTop).Visible = False

                End If
            End If

            If yTop <> -1 Then

                testbuttonNew = Strings.Right(globalGrid(testx, yTop).Name, 2)
                If testbuttonNew = 0 Then


                    expandButtons(testx, yTop, testbuttonNew)


                ElseIf testbuttonNew <> 9 Then
                    userClickedSquares = userClickedSquares + 1

                    globalGrid(testx, yTop).Visible = False

                End If
            End If

            If xRight <> xLimit AndAlso yTop <> -1 Then

                testbuttonNew = Strings.Right(globalGrid(xRight, yTop).Name, 2)
                If testbuttonNew = 0 Then


                    expandButtons(xRight, yTop, testbuttonNew)


                ElseIf testbuttonNew <> 9 Then
                    userClickedSquares = userClickedSquares + 1

                    globalGrid(xRight, yTop).Visible = False

                End If
            End If

            If xLeft <> -1 Then

                testbuttonNew = Strings.Right(globalGrid(xLeft, testy).Name, 2)
                If testbuttonNew = 0 Then


                    expandButtons(xLeft, testy, testbuttonNew)


                ElseIf testbuttonNew <> 9 Then
                    userClickedSquares = userClickedSquares + 1

                    globalGrid(xLeft, testy).Visible = False

                End If
            End If

            If xRight <> xLimit Then

                testbuttonNew = Strings.Right(globalGrid(xRight, testy).Name, 2)
                If testbuttonNew = 0 Then


                    expandButtons(xRight, testy, testbuttonNew)


                ElseIf testbuttonNew <> 9 Then
                    userClickedSquares = userClickedSquares + 1

                    globalGrid(xRight, testy).Visible = False

                End If
            End If

            If xLeft <> -1 AndAlso yBottom <> yLimit Then

                testbuttonNew = Strings.Right(globalGrid(xLeft, yBottom).Name, 2)
                If testbuttonNew = 0 Then


                    expandButtons(xLeft, yBottom, testbuttonNew)


                ElseIf testbuttonNew <> 9 Then
                    userClickedSquares = userClickedSquares + 1

                    globalGrid(xLeft, yBottom).Visible = False

                End If
            End If

            If yBottom <> yLimit Then

                testbuttonNew = Strings.Right(globalGrid(testx, yBottom).Name, 2)
                If testbuttonNew = 0 Then


                    expandButtons(testx, yBottom, testbuttonNew)


                ElseIf testbuttonNew <> 9 Then
                    userClickedSquares = userClickedSquares + 1

                    globalGrid(testx, yBottom).Visible = False

                End If
            End If

            If xRight <> xLimit AndAlso yBottom <> yLimit Then
                testbuttonNew = Strings.Right(globalGrid(xRight, yBottom).Name, 2)
                If testbuttonNew = 0 Then

                    expandButtons(xRight, yBottom, testbuttonNew)

                ElseIf testbuttonNew <> 9 Then
                    userClickedSquares = userClickedSquares + 1

                    globalGrid(xRight, yBottom).Visible = False

                End If
            End If

        End If
    End Sub


    Sub writeHighscore()
        Dim arrRead(10) As frmHighscores.recHighscore
        Dim temp As frmHighscores.recHighscore

        arrRead(10).name = playerName
        arrRead(10).score = playerScore

        FileSystem.FileOpen(1, Application.StartupPath() & ”\highscores" & difficulty & ".txt”, OpenMode.Input)

        For i = 0 To 9
            FileSystem.Input(1, arrRead(i).name)
            FileSystem.Input(1, arrRead(i).score)
        Next i

        FileSystem.FileClose(1)

        For i = 0 To 9
            If arrRead(i).score <= arrRead(i + 1).score Then
                temp = arrRead(i)
                arrRead(i) = arrRead(i + 1)
                arrRead(i + 1) = temp
            End If
        Next i


        FileSystem.FileOpen(1, Application.StartupPath() & ”\highscores" & difficulty & ".txt”, OpenMode.Output)
        For i = 0 To 9
            FileSystem.WriteLine(1, arrRead(i).name)
            FileSystem.WriteLine(1, arrRead(i).score)
        Next

        FileSystem.FileClose(1)

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
        difficulty = 1
        frmGame_Load(e, e)
    End Sub

    Private Sub IntermediateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntermediateToolStripMenuItem.Click
        difficulty = 2
        frmGame_Load(e, e)
    End Sub

    Private Sub ExpertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpertToolStripMenuItem.Click
        difficulty = 3
        frmGame_Load(e, e)
    End Sub
End Class