<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstructions))
        Me.mstInstructions = New System.Windows.Forms.MenuStrip()
        Me.tmiGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmiHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblInstructionsText = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.mstInstructions.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstInstructions
        '
        Me.mstInstructions.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mstInstructions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tmiGame})
        Me.mstInstructions.Location = New System.Drawing.Point(0, 0)
        Me.mstInstructions.Name = "mstInstructions"
        Me.mstInstructions.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.mstInstructions.Size = New System.Drawing.Size(944, 24)
        Me.mstInstructions.TabIndex = 0
        Me.mstInstructions.Text = "cmnuMain"
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
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(372, 29)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(205, 41)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Instructions"
        '
        'lblInstructionsText
        '
        Me.lblInstructionsText.AutoSize = True
        Me.lblInstructionsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInstructionsText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionsText.Location = New System.Drawing.Point(109, 148)
        Me.lblInstructionsText.Name = "lblInstructionsText"
        Me.lblInstructionsText.Size = New System.Drawing.Size(734, 227)
        Me.lblInstructionsText.TabIndex = 2
        Me.lblInstructionsText.Text = resources.GetString("lblInstructionsText.Text")
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(720, 405)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 77)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblInstructionsText)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.mstInstructions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mstInstructions
        Me.Name = "frmInstructions"
        Me.Text = "Minesweeper - Instructions"
        Me.mstInstructions.ResumeLayout(False)
        Me.mstInstructions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mstInstructions As MenuStrip
    Friend WithEvents tmiGame As ToolStripMenuItem
    Friend WithEvents tmiHome As ToolStripMenuItem
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblInstructionsText As Label
    Friend WithEvents btnBack As Button
End Class
