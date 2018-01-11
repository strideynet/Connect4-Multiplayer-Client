<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGamePeruser
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
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblMiniTips = New System.Windows.Forms.Label()
        Me.BtnSearchQuitSearch = New System.Windows.Forms.Button()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaderboardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeploySmoothMusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnLeaderboards = New System.Windows.Forms.Button()
        Me.ToolTipTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LblSpinnerLeft = New System.Windows.Forms.Label()
        Me.LblSpinnerRight = New System.Windows.Forms.Label()
        Me.SpinnerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblStatus
        '
        Me.LblStatus.BackColor = System.Drawing.SystemColors.Control
        Me.LblStatus.Location = New System.Drawing.Point(12, 53)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(360, 39)
        Me.LblStatus.TabIndex = 0
        Me.LblStatus.Text = "Waiting to connect..."
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMiniTips
        '
        Me.LblMiniTips.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblMiniTips.Location = New System.Drawing.Point(12, 121)
        Me.LblMiniTips.Name = "LblMiniTips"
        Me.LblMiniTips.Size = New System.Drawing.Size(360, 62)
        Me.LblMiniTips.TabIndex = 1
        Me.LblMiniTips.Text = "If you click correctly, you might win..."
        Me.LblMiniTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSearchQuitSearch
        '
        Me.BtnSearchQuitSearch.Location = New System.Drawing.Point(12, 27)
        Me.BtnSearchQuitSearch.Name = "BtnSearchQuitSearch"
        Me.BtnSearchQuitSearch.Size = New System.Drawing.Size(360, 23)
        Me.BtnSearchQuitSearch.TabIndex = 2
        Me.BtnSearchQuitSearch.Text = "Begin Search"
        Me.BtnSearchQuitSearch.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(384, 24)
        Me.Menu.TabIndex = 3
        Me.Menu.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToMenuToolStripMenuItem, Me.LeaderboardsToolStripMenuItem, Me.DeploySmoothMusicToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ExitToMenuToolStripMenuItem
        '
        Me.ExitToMenuToolStripMenuItem.Name = "ExitToMenuToolStripMenuItem"
        Me.ExitToMenuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.ExitToMenuToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ExitToMenuToolStripMenuItem.Text = "Exit to menu"
        '
        'LeaderboardsToolStripMenuItem
        '
        Me.LeaderboardsToolStripMenuItem.Name = "LeaderboardsToolStripMenuItem"
        Me.LeaderboardsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LeaderboardsToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.LeaderboardsToolStripMenuItem.Text = "Leaderboards"
        '
        'DeploySmoothMusicToolStripMenuItem
        '
        Me.DeploySmoothMusicToolStripMenuItem.Name = "DeploySmoothMusicToolStripMenuItem"
        Me.DeploySmoothMusicToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DeploySmoothMusicToolStripMenuItem.Text = "Deploy smooth music"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetHelpToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GetHelpToolStripMenuItem
        '
        Me.GetHelpToolStripMenuItem.Name = "GetHelpToolStripMenuItem"
        Me.GetHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.GetHelpToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.GetHelpToolStripMenuItem.Text = "Get Help"
        '
        'BtnLeaderboards
        '
        Me.BtnLeaderboards.Location = New System.Drawing.Point(12, 95)
        Me.BtnLeaderboards.Name = "BtnLeaderboards"
        Me.BtnLeaderboards.Size = New System.Drawing.Size(360, 23)
        Me.BtnLeaderboards.TabIndex = 4
        Me.BtnLeaderboards.Text = "View Leaderboards"
        Me.BtnLeaderboards.UseVisualStyleBackColor = True
        '
        'ToolTipTimer
        '
        Me.ToolTipTimer.Enabled = True
        '
        'LblSpinnerLeft
        '
        Me.LblSpinnerLeft.BackColor = System.Drawing.Color.PaleGreen
        Me.LblSpinnerLeft.Location = New System.Drawing.Point(12, 53)
        Me.LblSpinnerLeft.Name = "LblSpinnerLeft"
        Me.LblSpinnerLeft.Size = New System.Drawing.Size(53, 39)
        Me.LblSpinnerLeft.TabIndex = 5
        Me.LblSpinnerLeft.Text = "-"
        Me.LblSpinnerLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSpinnerRight
        '
        Me.LblSpinnerRight.BackColor = System.Drawing.Color.PaleGreen
        Me.LblSpinnerRight.Location = New System.Drawing.Point(319, 53)
        Me.LblSpinnerRight.Name = "LblSpinnerRight"
        Me.LblSpinnerRight.Size = New System.Drawing.Size(53, 39)
        Me.LblSpinnerRight.TabIndex = 6
        Me.LblSpinnerRight.Text = "-"
        Me.LblSpinnerRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpinnerTimer
        '
        Me.SpinnerTimer.Enabled = True
        '
        'FrmGamePeruser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 192)
        Me.Controls.Add(Me.LblSpinnerRight)
        Me.Controls.Add(Me.LblSpinnerLeft)
        Me.Controls.Add(Me.BtnLeaderboards)
        Me.Controls.Add(Me.BtnSearchQuitSearch)
        Me.Controls.Add(Me.LblMiniTips)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.Menu)
        Me.MainMenuStrip = Me.Menu
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 230)
        Me.MinimumSize = New System.Drawing.Size(400, 230)
        Me.Name = "FrmGamePeruser"
        Me.Text = "GamePeruser"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents LblMiniTips As System.Windows.Forms.Label
    Friend WithEvents BtnSearchQuitSearch As System.Windows.Forms.Button
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaderboardsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnLeaderboards As System.Windows.Forms.Button
    Friend WithEvents ToolTipTimer As System.Windows.Forms.Timer
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblSpinnerLeft As System.Windows.Forms.Label
    Friend WithEvents LblSpinnerRight As System.Windows.Forms.Label
    Friend WithEvents SpinnerTimer As System.Windows.Forms.Timer
    Friend WithEvents DeploySmoothMusicToolStripMenuItem As ToolStripMenuItem
End Class
