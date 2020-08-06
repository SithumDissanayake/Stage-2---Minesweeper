Public Class frmGame
    'PLEASE READ THE README.txt FILE BEFORE STARTING

    'Declaration  of a Record that will contain the x, y and the squares value of how many mines are around it
    Private Structure recGlobalGrid
        Dim xCoordinate As Integer
        Dim yCoordinate As Integer
        Dim squareValue As Integer
    End Structure

    'Declaration of the playerTime - tracks how long the player has been playing for - totalFreeSquares - amount of squares that are not mines in the grid
    Dim playerTimer As Integer
    Dim totalFreeSquares As Integer

    'Declaration of globalGridArray - will contain a 2d array of buttons that make up the playable grid - globalGrid - will contains every squares x, y And mines around value - arrRead - will contain all of the previous highscores as well as the current players score if they win
    Dim globalGridArray(0, 0) As Button
    Dim globalGrid(0) As recGlobalGrid
    Dim arrRead(10) As recHighscore

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initial setup For the game including: setting all the mines; setting square values around the mines; starting the player timer; generating the total grid and displaying it

        'Declaration of all varaibles used in this sub
        Dim gameGrid(0, 0) As Integer

        Dim totalMines As Integer
        Dim totalSquares As Integer
        Dim gridYLength As Integer
        Dim gridXLength As Integer

        'Resetting all values
        newHighscore = False
        playerTimer = 0

        'Starting timer
        timPlayer.Start()

        'Setting labels text and its position in the middle of the panel that holds all player info
        lblPlayerName.Text = playerName
        lblPlayerName.Left = (pnlGameBar.Width - lblPlayerName.Width) / 2

        'Sets the amount of mines and size of the grid based on the player difficulty
        totalMines = difficultySetMines(playerDifficulty)
        gridXLength = difficultySelectX(playerDifficulty)
        gridYLength = difficultySelectY(playerDifficulty)

        'Sets the total amount of squares in the grid and using that and the total amount of mines to set the total amount of free squares
        totalSquares = (gridXLength + 1) * (gridYLength + 1)
        totalFreeSquares = totalSquares - totalMines

        'Displays the initial amount of squares left and adds extra 0's infront of score.
        lblSquaresLeft.Text = totalFreeSquares.ToString().PadLeft(6, "0")

        'ReDim's all of the global arrays based on the difficulty selected
        ReDim gameGrid(gridXLength, gridYLength)
        ReDim globalGridArray(gridXLength, gridYLength)
        ReDim globalGrid(totalSquares)

        'Sets all the values in the grid to equal 0
        setGrid(gameGrid, gridXLength, gridYLength)

        'Randomly generates mines on the grid based on difficulty
        generateMines(gameGrid, gridXLength, gridYLength, totalMines)

        'Populates all the squares around the mines with values based on how many there are
        populateSquares(gameGrid, gridXLength, gridYLength)

        'Populates all of the visible labels and buttons
        populateVisibleGrid(gameGrid, gridXLength, gridYLength)

    End Sub

    Function difficultySetMines(difficulty As Integer) As Integer
        'Selects the amount of mines in this particular grid based off its difficulty - returns the amount of mines as an integer

        Dim totalMines As Integer

        Select Case difficulty
            Case 1 : totalMines = 10
            Case 2 : totalMines = 40
            Case 3 : totalMines = 99
        End Select

        Return totalMines
    End Function

    Function difficultySelectX(difficulty As Integer) As Integer
        'Selects the length of x axis in this particular grid based off its difficulty - returns the x length of the grid as an integer

        Dim gridXLength As Integer

        Select Case difficulty
            Case 1 : gridXLength = 8
            Case 2 : gridXLength = 15
            Case 3 : gridXLength = 29
        End Select

        Return gridXLength
    End Function

    Function difficultySelectY(difficulty As Integer) As Integer
        'Selects the length of y axis in this particular grid based off its difficulty - returns the y length of the grid as an integer

        Dim gridYLength As Integer

        Select Case difficulty
            Case 1 : gridYLength = 8
            Case 2, 3 : gridYLength = 15
        End Select

        Return gridYLength
    End Function

    Function setGrid(gameGrid(,) As Integer, gridXLength As Integer, gridYLength As Integer) As Integer
        'Sets all the values in the grid to 0 by looping through the entire 2d array - returns the gamegrid as an array of integers

        Dim x As Integer
        Dim y As Integer

        For x = 0 To gridXLength
            For y = 0 To gridYLength
                gameGrid(x, y) = 0
            Next y
        Next x

        Return gameGrid(gridXLength, gridYLength)
    End Function

    Function generateMines(gameGrid(,) As Integer, gridXLength As Integer, gridYLength As Integer, totalMines As Integer) As Integer
        'Randomly generates mines in the grid up to the amount allowed by the difficulty - returns the gamegrid as an array of integers

        Dim checkMines As Integer
        Dim x As Integer
        Dim y As Integer

        checkMines = 0

        'Will continue to loop until the required amount of mines are generated
        While checkMines <> totalMines
            'Generates Random x And y coordinates for the mines
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
        'Randomly generates a number between the highest and lowest integer passed into it - returns an integer
        Randomize()
        RandBetween = Int((High - Low + 1) * Rnd()) + Low
    End Function

    Function populateSquares(gameGrid(,) As Integer, gridXLength As Integer, gridYLength As Integer) As Integer
        'Populates all the squares around the mines with values to indicate how many mines are around them - returns an array of integers

        'Declares all the x, y values of the current squares and the ones around the current square
        Dim x As Integer
        Dim y As Integer
        Dim yTop As Integer
        Dim yBottom As Integer
        Dim xLeft As Integer
        Dim xRight As Integer

        'Declares the x and y limits of the grid
        Dim xLimit As Integer
        Dim yLimit As Integer

        'Assigns the x and y limits of the grid
        xLimit = gridXLength + 1
        yLimit = gridYLength + 1

        'Loops through the entire grid
        For x = 0 To gridXLength
            For y = 0 To gridYLength
                'Checks whether the current square equals a mine (9) and if it does it adds a 1 to the surrounding squares
                If gameGrid(x, y) = 9 Then
                    'Assigns coordinates of mines around the selected square
                    yTop = y - 1
                    yBottom = y + 1
                    xLeft = x - 1
                    xRight = x + 1

                    'Checks if the square to the top left of the current square is with in the boundaries and is not a mine, if it fits these conditions it adds a 1 to that square
                    If xLeft <> -1 AndAlso yTop <> -1 AndAlso gameGrid(xLeft, yTop) <> 9 Then
                        gameGrid(xLeft, yTop) = gameGrid(xLeft, yTop) + 1
                    End If

                    'Checks if the square to the top of the current square is with in the boundaries and is not a mine, if it fits these conditions it adds a 1 to that square
                    If yTop <> -1 AndAlso gameGrid(x, yTop) <> 9 Then
                        gameGrid(x, yTop) = gameGrid(x, yTop) + 1
                    End If

                    'Checks if the square to the top right of the current square is with in the boundaries and is not a mine, if it fits these conditions it adds a 1 to that square
                    If xRight <> xLimit AndAlso yTop <> -1 AndAlso gameGrid(xRight, yTop) <> 9 Then
                        gameGrid(xRight, yTop) = gameGrid(xRight, yTop) + 1
                    End If

                    'Checks if the square to the left of the current square is with in the boundaries and is not a mine, if it fits these conditions it adds a 1 to that square
                    If xLeft <> -1 AndAlso gameGrid(xLeft, y) <> 9 Then
                        gameGrid(xLeft, y) = gameGrid(xLeft, y) + 1
                    End If

                    'Checks if the square to the right of the current square is with in the boundaries and is not a mine, if it fits these conditions it adds a 1 to that square
                    If xRight <> xLimit AndAlso gameGrid(xRight, y) <> 9 Then
                        gameGrid(xRight, y) = gameGrid(xRight, y) + 1
                    End If

                    'Checks if the square to the bottom left of the current square is with in the boundaries and is not a mine, if it fits these conditions it adds a 1 to that square
                    If xLeft <> -1 AndAlso yBottom <> yLimit AndAlso gameGrid(xLeft, yBottom) <> 9 Then
                        gameGrid(xLeft, yBottom) = gameGrid(xLeft, yBottom) + 1
                    End If

                    'Checks if the square to the bottom of the current square is with in the boundaries and is not a mine, if it fits these conditions it adds a 1 to that square
                    If yBottom <> yLimit AndAlso gameGrid(x, yBottom) <> 9 Then
                        gameGrid(x, yBottom) = gameGrid(x, yBottom) + 1
                    End If

                    'Checks if the square to the bottom right of the current square is with in the boundaries and is not a mine, if it fits these conditions it adds a 1 to that square
                    If xRight <> xLimit AndAlso yBottom <> yLimit AndAlso gameGrid(xRight, yBottom) <> 9 Then
                        gameGrid(xRight, yBottom) = gameGrid(xRight, yBottom) + 1
                    End If

                End If
            Next y
        Next x

        Return gameGrid(gridXLength, gridYLength)
    End Function

    Sub populateVisibleGrid(gamegrid(,) As Integer, gridXLength As Integer, gridYLength As Integer)
        'Populates the visible grid with buttons and labels based on their values

        'Generates a panel where all the labels and buttons will go
        Dim pnlGame As New Panel
        'Contains the name value that will be used to identify the coordinates and square values of a square from its the array of recrods
        Dim arrVal As Integer
        Dim x, y As Integer

        arrVal = 0

        'Clears the panel and sets it to the right size and position
        panelSetup(pnlGame)

        'Loops through the 2d array
        For y = 0 To gridYLength
            For x = 0 To gridXLength
                'Sets the x, y and square value of the game to the record that holds them
                globalGrid(arrVal).xCoordinate = x
                globalGrid(arrVal).yCoordinate = y
                globalGrid(arrVal).squareValue = gamegrid(x, y)

                'Generates a new button, sets its image And uses its providied coordinates to assign it its name and adds it to the panel and array of buttons
                Dim gridButton As New Button

                gridButton = generateButton(gridButton, arrVal, x, y)

                pnlGame.Controls.Add(gridButton)
                globalGridArray(x, y) = gridButton

                'Generates a new label settings its size and number using info from gamegrid and adds it to the panel
                Dim gridLabel As New Label

                gridLabel = generateLabel(gridLabel, gamegrid, x, y)

                pnlGame.Controls.Add(gridLabel)

                arrVal = arrVal + 1
            Next x
        Next y
    End Sub

    Sub panelSetup(pnlGame As Panel)
        'Clears all the controls (buttons and labels) in the panel and sets the new dimentions and location of the panel

        pnlGame.Controls.Clear()

        pnlGame.Name = "pnlGame"

        'Based on difficulty it changes the size of the panel
        Select Case playerDifficulty
            Case 1
                pnlGame.Width = 219
                pnlGame.Height = 222
                pnlGame.Top = 90
            Case 2
                pnlGame.Width = 387
                pnlGame.Height = 390
                pnlGame.Top = 6
            Case 3
                pnlGame.Width = 723
                pnlGame.Height = 390
                pnlGame.Top = 6
        End Select

        'Sets the location of the panel and brings it to the front of the screen
        pnlGame.Left = (pnlGameArea.Width - pnlGame.Width) / 2
        pnlGameArea.Controls.Add(pnlGame)
        pnlGame.BringToFront()
    End Sub

    Function generateButton(gridButton As Button, arrVal As Integer, x As Integer, y As Integer) As Button
        'Sets the new buttons size, position image and tag as well as its handler and address when clicked

        gridButton.Name = arrVal

        gridButton.Height = 25
        gridButton.Width = 25

        gridButton.Left = gridButton.Left + (24 * x)
        gridButton.Top = gridButton.Top + (24 * y)

        gridButton.Image = Image.FromFile("images\square.png")
        gridButton.TabStop = False
        gridButton.Tag = "0"

        AddHandler gridButton.MouseDown, AddressOf Btn_Click

        Return gridButton
    End Function

    Function generateLabel(gridLabel As Label, gamegrid(,) As Integer, x As Integer, y As Integer) As Label
        'Sets the font, background color, dimensions and color of the new label
        gridLabel.Text = gamegrid(x, y)
        gridLabel.Font = New Font(gridLabel.Font, FontStyle.Bold)
        gridLabel.TextAlign = ContentAlignment.MiddleCenter
        gridLabel.BackColor = Color.LightGray

        gridLabel.Height = 25
        gridLabel.Width = 25

        gridLabel.Left = gridLabel.Left + (24 * x)
        gridLabel.Top = gridLabel.Top + (24 * y)

        'Depending on the square value sets the text color or mine image
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
            Case 9 : gridLabel.Image = Image.FromFile("images\mine.jpg")
        End Select

        Return gridLabel
    End Function

    Private Sub Btn_Click(sender As Object, e As MouseEventArgs)
        'Runs when one of the square values are clicked

        'Checks if the mouse click was a left of right click
        Select Case e.Button
            Case MouseButtons.Right
                'Based on the buttons tag it either sets the button as a flag or square
                Select Case sender.tag
                    Case "0"
                        sender.image = Image.FromFile("images\flag.jpg")
                        sender.tag = "1"
                    Case "1"
                        sender.image = Image.FromFile("images\square.png")
                        sender.tag = "0"
                End Select
            Case MouseButtons.Left
                'Using the buttons name, this obtains its x, y and square values from the array of records holding it
                If sender.tag <> "1" Then
                    Dim freeSquares As Integer
                    Dim userClickedSquares As Integer

                    Dim buttonX As Integer
                    Dim buttonY As Integer
                    Dim buttonValue As Integer
                    Dim arrVal As Integer

                    arrVal = sender.name

                    buttonX = globalGrid(arrVal).xCoordinate

                    buttonY = globalGrid(arrVal).yCoordinate

                    buttonValue = globalGrid(arrVal).squareValue

                    'When a button that is 0 is clicked, it recursively expands the surrounding squares
                    If buttonValue = 0 Then
                        expandButtons(buttonX, buttonY, buttonValue)
                    Else
                        globalGridArray(buttonX, buttonY).Visible = False
                    End If

                    'Checks how many squares have been clicked
                    userClickedSquares = checkUserClickedSquares()

                    'Determines how many free squares are left
                    freeSquares = totalFreeSquares - userClickedSquares

                    If userClickedSquares = totalFreeSquares Then
                        'When a user has won, it displays a win form
                        userWin()
                    ElseIf buttonValue = 9 Then
                        'When a user has lost, it displays a lose form with the amount of freesquares left and displays all the remaining squares
                        userLose(freeSquares)
                    Else
                        'Displays the squares left for the palyer to click on
                        lblSquaresLeft.Text = freeSquares.ToString().PadLeft(6, "0")
                    End If
                End If
        End Select

    End Sub

    Sub expandButtons(buttonX As Integer, buttonY As Integer, buttonValue As Integer)
        'Recursively checks all squares around the selected squares to expand all the 0's

        Dim yTop As Integer
        Dim yBottom As Integer
        Dim xLeft As Integer
        Dim xRight As Integer

        Dim xLimit As Integer
        Dim yLimit As Integer

        'Checks If the button Is visible And if its a mine
        If globalGridArray(buttonX, buttonY).Visible <> False AndAlso globalGrid(globalGridArray(buttonX, buttonY).Name).squareValue <> 9 Then
            'Sets the buttons to invisible
            globalGridArray(buttonX, buttonY).Visible = False

            'Sets all the values of the surrounding squares
            yTop = buttonY - 1
            yBottom = buttonY + 1
            xLeft = buttonX - 1
            xRight = buttonX + 1
            xLimit = globalGridArray.GetLength(0)
            yLimit = globalGridArray.GetLength(1)

            'Checks if the square is within the limits
            If xLeft <> -1 AndAlso yTop <> -1 Then
                'Checks if the top left square is 0 or not and expands based one that
                expandButtonCheck(xLeft, yTop)
            End If

            'Checks if the square is within the limits
            If yTop <> -1 Then
                'Checks if the top square is 0 or not and expands based one that
                expandButtonCheck(buttonX, yTop)
            End If

            'Checks if the square is within the limits
            If xRight <> xLimit AndAlso yTop <> -1 Then
                'Checks if the top right square is 0 or not and expands based one that
                expandButtonCheck(xRight, yTop)
            End If

            'Checks if the square is within the limits
            If xLeft <> -1 Then
                'Checks if the left square is 0 or not and expands based one that
                expandButtonCheck(xLeft, buttonY)
            End If

            'Checks if the square is within the limits
            If xRight <> xLimit Then
                'Checks if the right square is 0 or not and expands based one that
                expandButtonCheck(xRight, buttonY)
            End If

            'Checks if the square is within the limits
            If xLeft <> -1 AndAlso yBottom <> yLimit Then
                'Checks if the bottom left square is 0 or not and expands based one that
                expandButtonCheck(xLeft, yBottom)
            End If

            'Checks if the square is within the limits
            If yBottom <> yLimit Then
                'Checks if the bottom square is 0 or not and expands based one that
                expandButtonCheck(buttonX, yBottom)
            End If

            'Checks if the square is within the limits
            If xRight <> xLimit AndAlso yBottom <> yLimit Then
                'Checks if the bottom right square is 0 or not and expands based one that
                expandButtonCheck(xRight, yBottom)
            End If

        End If
    End Sub
    Sub expandButtonCheck(x As Integer, y As Integer)
        Dim buttonNameNew As Integer
        Dim buttonValueNew As Integer
        'Sets the name and value of the button
        buttonNameNew = globalGridArray(x, y).Name
        buttonValueNew = globalGrid(buttonNameNew).squareValue

        'If the new value equals 0 it runs this subroutine again with the new coordinates
        If buttonValueNew = 0 Then
            expandButtons(x, y, buttonValueNew)
        ElseIf buttonValueNew <> 9 Then
            'Checks if the new square value is a mine, if its not it changes that value to false
            globalGridArray(x, y).Visible = False
        End If
    End Sub
    Function checkUserClickedSquares() As Integer
        'Checks all clicked squares on the screen

        Dim userClickedSquares As Integer

        'Loops through the 2d array
        For x = 0 To globalGridArray.GetLength(0) - 1
            For y = 0 To globalGridArray.GetLength(1) - 1
                If globalGridArray(x, y).Visible = False Then
                    'If the button is not displayed, it adds 1 to the clicked squares
                    userClickedSquares = userClickedSquares + 1
                End If
            Next y
        Next x

        Return userClickedSquares
    End Function

    Sub userWin()
        'When the user has won this, stops the timer, lets the score to the timer value, checks the highscores and displays the win form
        timPlayer.Stop()

        playerScore = playerTimer

        scoreChecking()

        frmGameWin.ShowDialog()
    End Sub

    Sub userLose(freeSquares As Integer)
        'When the user has won this, stops the timer, reveals all the squares, sets the player's time as their score, sets the amount of squares remaining and displays the lose form

        timPlayer.Stop()

        'Loops through all controls to find mines at which point it will reveal them
        revealMines()

        playerScore = playerTimer

        squaresRemaining = freeSquares

        frmGameLose.ShowDialog()
    End Sub

    Sub scoreChecking()
        'Checks whether a players score is a new highscore by reading all the current highscores, adding the players highscore and then sorting it with a bubble sort and writing it back to the text file
        arrRead(10).name = playerName
        arrRead(10).score = playerScore

        readHighscores()

        bubbleSort()

        writeHighscores()
    End Sub

    Sub readHighscores()
        'Reads a file and puts the first two lines into a record of names and scores
        FileSystem.FileOpen(1, Application.StartupPath() & ”\highscores\highscores" & playerDifficulty & ".txt”, OpenMode.Input)

        For i = 0 To 9
            FileSystem.Input(1, arrRead(i).name)
            FileSystem.Input(1, arrRead(i).score)
        Next i

        FileSystem.FileClose(1)
    End Sub

    Sub bubbleSort()
        'Bubble sort from the NESA specs https://educationstandards.nsw.edu.au/wps/wcm/connect/44325629-51c6-4330-8bf8-662d5cfbe5fb/software-design-development-course-specs.pdf?MOD=AJPERES&CVID=
        Dim arrReadLength As Integer
        Dim swapped As Boolean

        Dim i As Integer
        Dim temp As recHighscore

        arrReadLength = arrRead.Length - 2

        swapped = True

        newHighscore = False

        'Loops until nothing is swapped at which point it will everything should be sorted from smallest to largest
        While swapped = True
            swapped = False
            For i = 0 To arrReadLength
                If arrRead(i).score > arrRead(i + 1).score Then
                    'Temp is used to store the original variable so nothing is lost when it is swapped
                    temp = arrRead(i)
                    arrRead(i) = arrRead(i + 1)
                    arrRead(i + 1) = temp

                    swapped = True
                    newHighscore = True
                End If
            Next i
            arrReadLength = arrReadLength - 1
        End While

    End Sub

    Sub writeHighscores()
        'Writes new highscores list to file
        FileSystem.FileOpen(1, Application.StartupPath() & ”\highscores\highscores" & playerDifficulty & ".txt”, OpenMode.Output)

        For i = 0 To 9
            FileSystem.WriteLine(1, arrRead(i).name)
            FileSystem.WriteLine(1, arrRead(i).score)
        Next

        FileSystem.FileClose(1)
    End Sub

    Sub revealMines()
        'Loops through all controls to find mines by using the control name to find the control's value at which point it will make the mine visible
        Dim buttonName As String
        Dim buttonValue As Integer

        Dim x As Integer
        Dim y As Integer

        For x = 0 To globalGridArray.GetLength(0) - 1
            For y = 0 To globalGridArray.GetLength(1) - 1
                buttonName = globalGridArray(x, y).Name
                buttonValue = globalGrid(buttonName).squareValue
                If buttonValue = 9 Then
                    globalGridArray(x, y).Visible = False
                End If
            Next y
        Next x
    End Sub

    Private Sub timPlayer_Tick(sender As Object, e As EventArgs) Handles timPlayer.Tick
        'Every second it increments the players time and displays it
        playerTimer = playerTimer + 1

        lblTimer.Text = playerTimer.ToString().PadLeft(6, "0")
    End Sub

    Private Sub tmiHome_Click(sender As Object, e As EventArgs) Handles tmiHome.Click
        'When the home button is clicked, this closes this form and displays the main menu
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub tmiBeginner_Click(sender As Object, e As EventArgs) Handles tmiBeginner.Click
        'When the player selects a new difficulty, this sets the difficulty to that difficulty and reloads the form
        playerDifficulty = 1
        frmGame_Load(e, e)
    End Sub

    Private Sub tmiIntermediate_Click(sender As Object, e As EventArgs) Handles tmiIntermediate.Click
        'When the player selects a new difficulty, this sets the difficulty to that difficulty and reloads the form
        playerDifficulty = 2
        frmGame_Load(e, e)
    End Sub

    Private Sub tmiExpert_Click(sender As Object, e As EventArgs) Handles tmiExpert.Click
        'When the player selects a new difficulty, this sets the difficulty to that difficulty and reloads the form
        playerDifficulty = 3
        frmGame_Load(e, e)
    End Sub

End Class