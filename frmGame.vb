Public Class frmGame
    'All variable names: playerName, difficulty
    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim playerName As String = "disum"

        Dim gameGrid(0, 0) As Integer

        Dim difficulty As Integer = 2
        Dim totalMines As Integer
        Dim gridYLength As Integer
        Dim gridXLength As Integer

        'textbox for playername
        totalMines = difficultySetMines(difficulty)
        gridXLength = difficultySelectX(difficulty)
        gridYLength = difficultySelectY(difficulty)
        ReDim gameGrid(gridXLength, gridYLength)

        setGrid(gameGrid, gridXLength, gridYLength)

        generateMines(gameGrid, gridXLength, gridYLength, totalMines)

        populateSquares(gameGrid, gridXLength, gridYLength)

        testButtons(gameGrid)

        Dim x, y As Integer
        Dim temp As String
        For y = 0 To 15
            temp = ""
            For x = 0 To 15
                temp = temp & "     " & gameGrid(x, y)
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
    Function setGrid(gameGrid(,) As Integer, gridXLength As Integer, gridYLength As Integer) As Integer()
        For x = 0 To gridXLength
            For y = 0 To gridYLength
                gameGrid(x, y) = 0
            Next y
        Next x
    End Function
    Function generateMines(gameGrid(,) As Integer, gridXLength As Integer, gridYLength As Integer, totalMines As Integer) As Integer()
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

    End Function
    Public Function RandBetween(Low As Integer, High As Integer) As Integer
        'Randomize()
        RandBetween = Int((High - Low + 1) * Rnd()) + Low
    End Function



    Function populateSquares(gameGrid(,) As Integer, gridXLength As Integer, gridYLength As Integer) As Integer()
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
    End Function

    Sub testbuttons(gamegrid(,) As Integer)
        Dim x, y As Integer

        For y = 0 To 15
            For x = 0 To 15
                Dim test As New Button
                test.Name = gamegrid(x, y)

                test.Height = 50
                test.Width = 50

                test.Left = test.Left + (49 * x)
                test.Top = test.Top + (49 * y)

                pnlGame.Controls.Add(test)
                AddHandler test.Click, AddressOf Btn_Click


                Dim test2 As New Label
                test2.Text = gamegrid(x, y)

                test2.Height = 50
                test2.Width = 50

                test2.Left = test2.Left + (49 * x)
                test2.Top = test2.Top + (49 * y)

                pnlGame.Controls.Add(test2)

            Next x
        Next y
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs)
        Dim buttonValue As Integer

        buttonValue = sender.name

        sender.visible = False

        If buttonValue = 9 Then
            MsgBox("gameover")
        End If

    End Sub
End Class