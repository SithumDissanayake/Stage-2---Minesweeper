<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.mstMainMenu = New System.Windows.Forms.MenuStrip()
        Me.tmiGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHighscores = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.rdoBeginner = New System.Windows.Forms.RadioButton()
        Me.pnlDifficulty = New System.Windows.Forms.Panel()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.rdoExpert = New System.Windows.Forms.RadioButton()
        Me.rdoIntermediate = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.mstMainMenu.SuspendLayout()
        Me.pnlDifficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(409, 426)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(138, 53)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'mstMainMenu
        '
        Me.mstMainMenu.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.mstMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiGame})
        Me.mstMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mstMainMenu.Name = "mstMainMenu"
        Me.mstMainMenu.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.mstMainMenu.Size = New System.Drawing.Size(944, 24)
        Me.mstMainMenu.TabIndex = 1
        Me.mstMainMenu.Text = "cmnuMain"
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
        'btnHighscores
        '
        Me.btnHighscores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighscores.Location = New System.Drawing.Point(595, 416)
        Me.btnHighscores.Name = "btnHighscores"
        Me.btnHighscores.Size = New System.Drawing.Size(175, 77)
        Me.btnHighscores.TabIndex = 2
        Me.btnHighscores.Text = "Highscores"
        Me.btnHighscores.UseVisualStyleBackColor = True
        '
        'btnInstructions
        '
        Me.btnInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.Location = New System.Drawing.Point(183, 416)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(175, 77)
        Me.btnInstructions.TabIndex = 3
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'rdoBeginner
        '
        Me.rdoBeginner.AutoSize = True
        Me.rdoBeginner.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBeginner.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.rdoBeginner.Location = New System.Drawing.Point(93, 96)
        Me.rdoBeginner.Name = "rdoBeginner"
        Me.rdoBeginner.Size = New System.Drawing.Size(108, 29)
        Me.rdoBeginner.TabIndex = 4
        Me.rdoBeginner.TabStop = True
        Me.rdoBeginner.Text = "Beginner"
        Me.rdoBeginner.UseVisualStyleBackColor = True
        '
        'pnlDifficulty
        '
        Me.pnlDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDifficulty.Controls.Add(Me.lblDifficulty)
        Me.pnlDifficulty.Controls.Add(Me.rdoExpert)
        Me.pnlDifficulty.Controls.Add(Me.rdoIntermediate)
        Me.pnlDifficulty.Controls.Add(Me.rdoBeginner)
        Me.pnlDifficulty.Location = New System.Drawing.Point(327, 163)
        Me.pnlDifficulty.Name = "pnlDifficulty"
        Me.pnlDifficulty.Size = New System.Drawing.Size(300, 235)
        Me.pnlDifficulty.TabIndex = 6
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficulty.Location = New System.Drawing.Point(74, 29)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(156, 39)
        Me.lblDifficulty.TabIndex = 7
        Me.lblDifficulty.Text = "Difficulty"
        '
        'rdoExpert
        '
        Me.rdoExpert.AutoSize = True
        Me.rdoExpert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoExpert.ForeColor = System.Drawing.Color.Red
        Me.rdoExpert.Location = New System.Drawing.Point(93, 166)
        Me.rdoExpert.Name = "rdoExpert"
        Me.rdoExpert.Size = New System.Drawing.Size(86, 29)
        Me.rdoExpert.TabIndex = 6
        Me.rdoExpert.TabStop = True
        Me.rdoExpert.Text = "Expert"
        Me.rdoExpert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoExpert.UseVisualStyleBackColor = True
        '
        'rdoIntermediate
        '
        Me.rdoIntermediate.AutoSize = True
        Me.rdoIntermediate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIntermediate.ForeColor = System.Drawing.Color.Gold
        Me.rdoIntermediate.Location = New System.Drawing.Point(93, 131)
        Me.rdoIntermediate.Name = "rdoIntermediate"
        Me.rdoIntermediate.Size = New System.Drawing.Size(137, 29)
        Me.rdoIntermediate.TabIndex = 5
        Me.rdoIntermediate.TabStop = True
        Me.rdoIntermediate.Text = "Intermediate"
        Me.rdoIntermediate.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(258, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(440, 76)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Minesweeper"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(316, 109)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(189, 25)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Enter Your Name: "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(495, 113)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(132, 20)
        Me.txtName.TabIndex = 0
        '
        'frmMainMenu
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlDifficulty)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnHighscores)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.mstMainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstMainMenu
        Me.Name = "frmMainMenu"
        Me.Text = "Minesweeper - Main Menu"
        Me.mstMainMenu.ResumeLayout(False)
        Me.mstMainMenu.PerformLayout()
        Me.pnlDifficulty.ResumeLayout(False)
        Me.pnlDifficulty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents mstMainMenu As MenuStrip
    Friend WithEvents tmiGame As ToolStripMenuItem
    Friend WithEvents btnHighscores As Button
    Friend WithEvents btnInstructions As Button
    Friend WithEvents rdoBeginner As RadioButton
    Friend WithEvents pnlDifficulty As Panel
    Friend WithEvents rdoExpert As RadioButton
    Friend WithEvents rdoIntermediate As RadioButton
    Friend WithEvents lblDifficulty As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents tmiHome As ToolStripMenuItem
End Class
