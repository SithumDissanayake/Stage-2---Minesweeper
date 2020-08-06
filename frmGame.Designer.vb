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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.mstGame = New System.Windows.Forms.MenuStrip()
        Me.tmiGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiDifficulty = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiBeginner = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiIntermediate = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiExpert = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlGameArea = New System.Windows.Forms.Panel()
        Me.pnlGameBar = New System.Windows.Forms.Panel()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblSquaresLeft = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.timPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.mstGame.SuspendLayout()
        Me.pnlGameBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstGame
        '
        Me.mstGame.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mstGame.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiGame, Me.tmiDifficulty})
        Me.mstGame.Location = New System.Drawing.Point(0, 0)
        Me.mstGame.Name = "mstGame"
        Me.mstGame.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.mstGame.Size = New System.Drawing.Size(944, 24)
        Me.mstGame.TabIndex = 3
        Me.mstGame.Text = "cmnuMain"
        '
        'tmiGame
        '
        Me.tmiGame.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiHome})
        Me.tmiGame.Name = "tmiGame"
        Me.tmiGame.Size = New System.Drawing.Size(50, 22)
        Me.tmiGame.Text = "Game"
        '
        'tmiHome
        '
        Me.tmiHome.Name = "tmiHome"
        Me.tmiHome.Size = New System.Drawing.Size(107, 22)
        Me.tmiHome.Text = "Home"
        '
        'tmiDifficulty
        '
        Me.tmiDifficulty.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiBeginner, Me.tmiIntermediate, Me.tmiExpert})
        Me.tmiDifficulty.Name = "tmiDifficulty"
        Me.tmiDifficulty.Size = New System.Drawing.Size(67, 22)
        Me.tmiDifficulty.Text = "Difficulty"
        '
        'tmiBeginner
        '
        Me.tmiBeginner.Name = "tmiBeginner"
        Me.tmiBeginner.Size = New System.Drawing.Size(141, 22)
        Me.tmiBeginner.Text = "Beginner"
        '
        'tmiIntermediate
        '
        Me.tmiIntermediate.Name = "tmiIntermediate"
        Me.tmiIntermediate.Size = New System.Drawing.Size(141, 22)
        Me.tmiIntermediate.Text = "Intermediate"
        '
        'tmiExpert
        '
        Me.tmiExpert.Name = "tmiExpert"
        Me.tmiExpert.Size = New System.Drawing.Size(141, 22)
        Me.tmiExpert.Text = "Expert"
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
        Me.pnlGameBar.Controls.Add(Me.lblSquaresLeft)
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
        'lblSquaresLeft
        '
        Me.lblSquaresLeft.AutoSize = True
        Me.lblSquaresLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSquaresLeft.Font = New System.Drawing.Font("Perpetua", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblSquaresLeft.ForeColor = System.Drawing.Color.Red
        Me.lblSquaresLeft.Location = New System.Drawing.Point(13, 6)
        Me.lblSquaresLeft.Name = "lblSquaresLeft"
        Me.lblSquaresLeft.Size = New System.Drawing.Size(105, 36)
        Me.lblSquaresLeft.TabIndex = 1
        Me.lblSquaresLeft.Text = "000000"
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
        'timPlayer
        '
        Me.timPlayer.Enabled = True
        Me.timPlayer.Interval = 1000
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.pnlGameBar)
        Me.Controls.Add(Me.pnlGameArea)
        Me.Controls.Add(Me.mstGame)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstGame
        Me.Name = "frmGame"
        Me.Text = "Minesweeper - Game"
        Me.mstGame.ResumeLayout(False)
        Me.mstGame.PerformLayout()
        Me.pnlGameBar.ResumeLayout(False)
        Me.pnlGameBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mstGame As MenuStrip
    Friend WithEvents tmiGame As ToolStripMenuItem
    Friend WithEvents tmiHome As ToolStripMenuItem
    Friend WithEvents tmiDifficulty As ToolStripMenuItem
    Friend WithEvents pnlGameArea As Panel
    Friend WithEvents pnlGameBar As Panel
    Friend WithEvents lblSquaresLeft As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblPlayerName As Label
    Friend WithEvents timPlayer As Timer
    Friend WithEvents tmiBeginner As ToolStripMenuItem
    Friend WithEvents tmiIntermediate As ToolStripMenuItem
    Friend WithEvents tmiExpert As ToolStripMenuItem
End Class
