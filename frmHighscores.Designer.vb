<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighscores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHighscores))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblHighscores = New System.Windows.Forms.Label()
        Me.mstHighscores = New System.Windows.Forms.MenuStrip()
        Me.tmiGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBeginner = New System.Windows.Forms.Panel()
        Me.lstBeginnerHighscores = New System.Windows.Forms.ListBox()
        Me.lblBeginner = New System.Windows.Forms.Label()
        Me.pnlIntermediate = New System.Windows.Forms.Panel()
        Me.lstIntermediateHighscores = New System.Windows.Forms.ListBox()
        Me.lblIntermediate = New System.Windows.Forms.Label()
        Me.pnlExpert = New System.Windows.Forms.Panel()
        Me.lstExpertHighscores = New System.Windows.Forms.ListBox()
        Me.lblExpert = New System.Windows.Forms.Label()
        Me.mstHighscores.SuspendLayout()
        Me.pnlBeginner.SuspendLayout()
        Me.pnlIntermediate.SuspendLayout()
        Me.pnlExpert.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(63, 405)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 77)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblHighscores
        '
        Me.lblHighscores.AutoSize = True
        Me.lblHighscores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighscores.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighscores.Location = New System.Drawing.Point(372, 29)
        Me.lblHighscores.Name = "lblHighscores"
        Me.lblHighscores.Size = New System.Drawing.Size(200, 41)
        Me.lblHighscores.TabIndex = 4
        Me.lblHighscores.Text = "Highscores"
        '
        'mstHighscores
        '
        Me.mstHighscores.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mstHighscores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiGame})
        Me.mstHighscores.Location = New System.Drawing.Point(0, 0)
        Me.mstHighscores.Name = "mstHighscores"
        Me.mstHighscores.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.mstHighscores.Size = New System.Drawing.Size(944, 24)
        Me.mstHighscores.TabIndex = 7
        Me.mstHighscores.Text = "cmnuMain"
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
        'pnlBeginner
        '
        Me.pnlBeginner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBeginner.Controls.Add(Me.lstBeginnerHighscores)
        Me.pnlBeginner.Controls.Add(Me.lblBeginner)
        Me.pnlBeginner.Location = New System.Drawing.Point(47, 95)
        Me.pnlBeginner.Name = "pnlBeginner"
        Me.pnlBeginner.Size = New System.Drawing.Size(250, 286)
        Me.pnlBeginner.TabIndex = 8
        '
        'lstBeginnerHighscores
        '
        Me.lstBeginnerHighscores.BackColor = System.Drawing.SystemColors.Menu
        Me.lstBeginnerHighscores.FormattingEnabled = True
        Me.lstBeginnerHighscores.Location = New System.Drawing.Point(36, 48)
        Me.lstBeginnerHighscores.Name = "lstBeginnerHighscores"
        Me.lstBeginnerHighscores.Size = New System.Drawing.Size(175, 225)
        Me.lstBeginnerHighscores.TabIndex = 1
        '
        'lblBeginner
        '
        Me.lblBeginner.AutoSize = True
        Me.lblBeginner.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeginner.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblBeginner.Location = New System.Drawing.Point(77, 10)
        Me.lblBeginner.Name = "lblBeginner"
        Me.lblBeginner.Size = New System.Drawing.Size(98, 25)
        Me.lblBeginner.TabIndex = 0
        Me.lblBeginner.Text = "Beginner"
        '
        'pnlIntermediate
        '
        Me.pnlIntermediate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlIntermediate.Controls.Add(Me.lstIntermediateHighscores)
        Me.pnlIntermediate.Controls.Add(Me.lblIntermediate)
        Me.pnlIntermediate.Location = New System.Drawing.Point(347, 95)
        Me.pnlIntermediate.Name = "pnlIntermediate"
        Me.pnlIntermediate.Size = New System.Drawing.Size(250, 286)
        Me.pnlIntermediate.TabIndex = 9
        '
        'lstIntermediateHighscores
        '
        Me.lstIntermediateHighscores.BackColor = System.Drawing.SystemColors.Menu
        Me.lstIntermediateHighscores.FormattingEnabled = True
        Me.lstIntermediateHighscores.Location = New System.Drawing.Point(39, 48)
        Me.lstIntermediateHighscores.Name = "lstIntermediateHighscores"
        Me.lstIntermediateHighscores.Size = New System.Drawing.Size(175, 225)
        Me.lstIntermediateHighscores.TabIndex = 2
        '
        'lblIntermediate
        '
        Me.lblIntermediate.AutoSize = True
        Me.lblIntermediate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntermediate.ForeColor = System.Drawing.Color.Gold
        Me.lblIntermediate.Location = New System.Drawing.Point(59, 10)
        Me.lblIntermediate.Name = "lblIntermediate"
        Me.lblIntermediate.Size = New System.Drawing.Size(131, 25)
        Me.lblIntermediate.TabIndex = 1
        Me.lblIntermediate.Text = "Intermediate"
        '
        'pnlExpert
        '
        Me.pnlExpert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlExpert.Controls.Add(Me.lstExpertHighscores)
        Me.pnlExpert.Controls.Add(Me.lblExpert)
        Me.pnlExpert.Location = New System.Drawing.Point(647, 95)
        Me.pnlExpert.Name = "pnlExpert"
        Me.pnlExpert.Size = New System.Drawing.Size(250, 286)
        Me.pnlExpert.TabIndex = 10
        '
        'lstExpertHighscores
        '
        Me.lstExpertHighscores.BackColor = System.Drawing.SystemColors.Menu
        Me.lstExpertHighscores.FormattingEnabled = True
        Me.lstExpertHighscores.Location = New System.Drawing.Point(36, 48)
        Me.lstExpertHighscores.Name = "lstExpertHighscores"
        Me.lstExpertHighscores.Size = New System.Drawing.Size(175, 225)
        Me.lstExpertHighscores.TabIndex = 3
        '
        'lblExpert
        '
        Me.lblExpert.AutoSize = True
        Me.lblExpert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpert.ForeColor = System.Drawing.Color.Red
        Me.lblExpert.Location = New System.Drawing.Point(88, 10)
        Me.lblExpert.Name = "lblExpert"
        Me.lblExpert.Size = New System.Drawing.Size(74, 25)
        Me.lblExpert.TabIndex = 2
        Me.lblExpert.Text = "Expert"
        '
        'frmHighscores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.pnlExpert)
        Me.Controls.Add(Me.pnlIntermediate)
        Me.Controls.Add(Me.pnlBeginner)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblHighscores)
        Me.Controls.Add(Me.mstHighscores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstHighscores
        Me.Name = "frmHighscores"
        Me.Text = "Minesweeper - Highscores"
        Me.mstHighscores.ResumeLayout(False)
        Me.mstHighscores.PerformLayout()
        Me.pnlBeginner.ResumeLayout(False)
        Me.pnlBeginner.PerformLayout()
        Me.pnlIntermediate.ResumeLayout(False)
        Me.pnlIntermediate.PerformLayout()
        Me.pnlExpert.ResumeLayout(False)
        Me.pnlExpert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblHighscores As Label
    Friend WithEvents mstHighscores As MenuStrip
    Friend WithEvents tmiGame As ToolStripMenuItem
    Friend WithEvents tmiHome As ToolStripMenuItem
    Friend WithEvents pnlBeginner As Panel
    Friend WithEvents pnlIntermediate As Panel
    Friend WithEvents pnlExpert As Panel
    Friend WithEvents lblBeginner As Label
    Friend WithEvents lblIntermediate As Label
    Friend WithEvents lblExpert As Label
    Friend WithEvents lstIntermediateHighscores As ListBox
    Friend WithEvents lstExpertHighscores As ListBox
    Friend WithEvents lstBeginnerHighscores As ListBox
End Class
