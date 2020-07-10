<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlGameArea = New System.Windows.Forms.Panel()
        Me.pnlGameBar = New System.Windows.Forms.Panel()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.timPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.pnlGameBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.DifficultyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(944, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "cmnuMain"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'DifficultyToolStripMenuItem
        '
        Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
        Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DifficultyToolStripMenuItem.Text = "Difficulty"
        '
        'pnlGameArea
        '
        Me.pnlGameArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGameArea.Location = New System.Drawing.Point(22, 83)
        Me.pnlGameArea.Name = "pnlGameArea"
        Me.pnlGameArea.Size = New System.Drawing.Size(900, 400)
        Me.pnlGameArea.TabIndex = 4
        '
        'pnlGameBar
        '
        Me.pnlGameBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlGameBar.Controls.Add(Me.lblPlayerName)
        Me.pnlGameBar.Controls.Add(Me.lblScore)
        Me.pnlGameBar.Controls.Add(Me.lblTimer)
        Me.pnlGameBar.Location = New System.Drawing.Point(22, 33)
        Me.pnlGameBar.Name = "pnlGameBar"
        Me.pnlGameBar.Size = New System.Drawing.Size(900, 50)
        Me.pnlGameBar.TabIndex = 5
        '
        'lblPlayerName
        '
        Me.lblPlayerName.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(387, 11)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(150, 26)
        Me.lblPlayerName.TabIndex = 6
        Me.lblPlayerName.Text = "Player Name"
        Me.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblScore.Font = New System.Drawing.Font("Perpetua", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblScore.ForeColor = System.Drawing.Color.Red
        Me.lblScore.Location = New System.Drawing.Point(13, 6)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(105, 36)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "000000"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTimer.Font = New System.Drawing.Font("Perpetua", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTimer.ForeColor = System.Drawing.Color.Red
        Me.lblTimer.Location = New System.Drawing.Point(777, 6)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(105, 36)
        Me.lblTimer.TabIndex = 0
        Me.lblTimer.Text = "000000"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(68, 516)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(802, 329)
        Me.ListBox1.TabIndex = 6
        '
        'timPlayer
        '
        Me.timPlayer.Enabled = True
        Me.timPlayer.Interval = 1000
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 867)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.pnlGameBar)
        Me.Controls.Add(Me.pnlGameArea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGame"
        Me.Text = "Minesweeper - Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlGameBar.ResumeLayout(False)
        Me.pnlGameBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DifficultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlGameArea As Panel
    Friend WithEvents pnlGameBar As Panel
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents timPlayer As Timer
End Class
