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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblHighscores = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstBeginnerHighscores = New System.Windows.Forms.ListBox()
        Me.lblBeginner = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lstIntermediateHighscores = New System.Windows.Forms.ListBox()
        Me.lblIntermediate = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lstExpertHighscores = New System.Windows.Forms.ListBox()
        Me.lblExpert = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(126, 779)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(350, 148)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblHighscores
        '
        Me.lblHighscores.AutoSize = True
        Me.lblHighscores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighscores.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighscores.Location = New System.Drawing.Point(744, 56)
        Me.lblHighscores.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHighscores.Name = "lblHighscores"
        Me.lblHighscores.Size = New System.Drawing.Size(379, 78)
        Me.lblHighscores.TabIndex = 4
        Me.lblHighscores.Text = "Highscores"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1888, 44)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "cmnuMain"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(97, 36)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(214, 44)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lstBeginnerHighscores)
        Me.Panel1.Controls.Add(Me.lblBeginner)
        Me.Panel1.Location = New System.Drawing.Point(94, 183)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 548)
        Me.Panel1.TabIndex = 8
        '
        'lstBeginnerHighscores
        '
        Me.lstBeginnerHighscores.BackColor = System.Drawing.SystemColors.Menu
        Me.lstBeginnerHighscores.FormattingEnabled = True
        Me.lstBeginnerHighscores.ItemHeight = 25
        Me.lstBeginnerHighscores.Location = New System.Drawing.Point(72, 92)
        Me.lstBeginnerHighscores.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstBeginnerHighscores.Name = "lstBeginnerHighscores"
        Me.lstBeginnerHighscores.Size = New System.Drawing.Size(346, 429)
        Me.lstBeginnerHighscores.TabIndex = 1
        '
        'lblBeginner
        '
        Me.lblBeginner.AutoSize = True
        Me.lblBeginner.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeginner.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblBeginner.Location = New System.Drawing.Point(154, 19)
        Me.lblBeginner.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBeginner.Name = "lblBeginner"
        Me.lblBeginner.Size = New System.Drawing.Size(187, 46)
        Me.lblBeginner.TabIndex = 0
        Me.lblBeginner.Text = "Beginner"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lstIntermediateHighscores)
        Me.Panel2.Controls.Add(Me.lblIntermediate)
        Me.Panel2.Location = New System.Drawing.Point(694, 183)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(498, 548)
        Me.Panel2.TabIndex = 9
        '
        'lstIntermediateHighscores
        '
        Me.lstIntermediateHighscores.BackColor = System.Drawing.SystemColors.Menu
        Me.lstIntermediateHighscores.FormattingEnabled = True
        Me.lstIntermediateHighscores.ItemHeight = 25
        Me.lstIntermediateHighscores.Location = New System.Drawing.Point(78, 92)
        Me.lstIntermediateHighscores.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstIntermediateHighscores.Name = "lstIntermediateHighscores"
        Me.lstIntermediateHighscores.Size = New System.Drawing.Size(346, 429)
        Me.lstIntermediateHighscores.TabIndex = 2
        '
        'lblIntermediate
        '
        Me.lblIntermediate.AutoSize = True
        Me.lblIntermediate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntermediate.ForeColor = System.Drawing.Color.Gold
        Me.lblIntermediate.Location = New System.Drawing.Point(118, 19)
        Me.lblIntermediate.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblIntermediate.Name = "lblIntermediate"
        Me.lblIntermediate.Size = New System.Drawing.Size(251, 46)
        Me.lblIntermediate.TabIndex = 1
        Me.lblIntermediate.Text = "Intermediate"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lstExpertHighscores)
        Me.Panel3.Controls.Add(Me.lblExpert)
        Me.Panel3.Location = New System.Drawing.Point(1294, 183)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(498, 548)
        Me.Panel3.TabIndex = 10
        '
        'lstExpertHighscores
        '
        Me.lstExpertHighscores.BackColor = System.Drawing.SystemColors.Menu
        Me.lstExpertHighscores.FormattingEnabled = True
        Me.lstExpertHighscores.ItemHeight = 25
        Me.lstExpertHighscores.Location = New System.Drawing.Point(72, 92)
        Me.lstExpertHighscores.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstExpertHighscores.Name = "lstExpertHighscores"
        Me.lstExpertHighscores.Size = New System.Drawing.Size(346, 429)
        Me.lstExpertHighscores.TabIndex = 3
        '
        'lblExpert
        '
        Me.lblExpert.AutoSize = True
        Me.lblExpert.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpert.ForeColor = System.Drawing.Color.Red
        Me.lblExpert.Location = New System.Drawing.Point(176, 19)
        Me.lblExpert.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblExpert.Name = "lblExpert"
        Me.lblExpert.Size = New System.Drawing.Size(142, 46)
        Me.lblExpert.TabIndex = 2
        Me.lblExpert.Text = "Expert"
        '
        'frmHighscores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1888, 963)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblHighscores)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmHighscores"
        Me.Text = "Minesweeper - Highscores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblHighscores As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblBeginner As Label
    Friend WithEvents lblIntermediate As Label
    Friend WithEvents lblExpert As Label
    Friend WithEvents lstIntermediateHighscores As ListBox
    Friend WithEvents lstExpertHighscores As ListBox
    Friend WithEvents lstBeginnerHighscores As ListBox
End Class
