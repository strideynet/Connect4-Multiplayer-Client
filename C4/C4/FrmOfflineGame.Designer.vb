<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOffline
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOffline))
        Me.PnlBoard = New System.Windows.Forms.Panel()
        Me.TblPnlMain = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnStartStop = New System.Windows.Forms.Button()
        Me.TblPnlInfo = New System.Windows.Forms.TableLayoutPanel()
        Me.LblP2Name = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.LblP1Name = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.LblCurrentTurn = New System.Windows.Forms.Label()
        Me.LblPrevMoveDetails = New System.Windows.Forms.Label()
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MainMenu_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Main_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Basic = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Blueberry = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Monochroma = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Peach = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Stone = New System.Windows.Forms.ToolStripMenuItem()
        Me.StPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_FirstPlayer_P1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_FirstPlayer_P2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_FirstPlayer_Random = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_FirstPlayer_Alternator = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntxtMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Cntxt_StartStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cntxt_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cntxt_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cntxt_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblPnlMain.SuspendLayout()
        Me.TblPnlInfo.SuspendLayout()
        Me.MainMenuStrip.SuspendLayout()
        Me.CntxtMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBoard
        '
        Me.PnlBoard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBoard.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.PnlBoard.Location = New System.Drawing.Point(12, 27)
        Me.PnlBoard.Name = "PnlBoard"
        Me.PnlBoard.Size = New System.Drawing.Size(395, 296)
        Me.PnlBoard.TabIndex = 0
        '
        'TblPnlMain
        '
        Me.TblPnlMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblPnlMain.ColumnCount = 1
        Me.TblPnlMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblPnlMain.Controls.Add(Me.BtnStartStop, 0, 0)
        Me.TblPnlMain.Controls.Add(Me.TblPnlInfo, 0, 1)
        Me.TblPnlMain.Controls.Add(Me.LblCurrentTurn, 0, 2)
        Me.TblPnlMain.Controls.Add(Me.LblPrevMoveDetails, 0, 3)
        Me.TblPnlMain.Location = New System.Drawing.Point(413, 27)
        Me.TblPnlMain.Name = "TblPnlMain"
        Me.TblPnlMain.RowCount = 4
        Me.TblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TblPnlMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TblPnlMain.Size = New System.Drawing.Size(156, 296)
        Me.TblPnlMain.TabIndex = 1
        '
        'BtnStartStop
        '
        Me.BtnStartStop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnStartStop.Location = New System.Drawing.Point(3, 3)
        Me.BtnStartStop.Name = "BtnStartStop"
        Me.BtnStartStop.Size = New System.Drawing.Size(150, 68)
        Me.BtnStartStop.TabIndex = 0
        Me.BtnStartStop.Text = "Start"
        Me.BtnStartStop.UseVisualStyleBackColor = True
        '
        'TblPnlInfo
        '
        Me.TblPnlInfo.ColumnCount = 2
        Me.TblPnlInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblPnlInfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblPnlInfo.Controls.Add(Me.LblP2Name, 1, 1)
        Me.TblPnlInfo.Controls.Add(Me.Lbl2, 0, 1)
        Me.TblPnlInfo.Controls.Add(Me.LblP1Name, 1, 0)
        Me.TblPnlInfo.Controls.Add(Me.Lbl1, 0, 0)
        Me.TblPnlInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblPnlInfo.Location = New System.Drawing.Point(3, 77)
        Me.TblPnlInfo.Name = "TblPnlInfo"
        Me.TblPnlInfo.RowCount = 2
        Me.TblPnlInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblPnlInfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblPnlInfo.Size = New System.Drawing.Size(150, 68)
        Me.TblPnlInfo.TabIndex = 1
        '
        'LblP2Name
        '
        Me.LblP2Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblP2Name.Location = New System.Drawing.Point(78, 34)
        Me.LblP2Name.Name = "LblP2Name"
        Me.LblP2Name.Size = New System.Drawing.Size(69, 34)
        Me.LblP2Name.TabIndex = 3
        Me.LblP2Name.Text = "Player 2"
        Me.LblP2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl2
        '
        Me.Lbl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl2.Location = New System.Drawing.Point(3, 34)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(69, 34)
        Me.Lbl2.TabIndex = 2
        Me.Lbl2.Text = "Player 2:"
        Me.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblP1Name
        '
        Me.LblP1Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblP1Name.Location = New System.Drawing.Point(78, 0)
        Me.LblP1Name.Name = "LblP1Name"
        Me.LblP1Name.Size = New System.Drawing.Size(69, 34)
        Me.LblP1Name.TabIndex = 1
        Me.LblP1Name.Text = "Player 1"
        Me.LblP1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl1
        '
        Me.Lbl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lbl1.Location = New System.Drawing.Point(3, 0)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(69, 34)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "Player 1:"
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCurrentTurn
        '
        Me.LblCurrentTurn.AutoSize = True
        Me.LblCurrentTurn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCurrentTurn.Location = New System.Drawing.Point(3, 148)
        Me.LblCurrentTurn.Name = "LblCurrentTurn"
        Me.LblCurrentTurn.Size = New System.Drawing.Size(150, 74)
        Me.LblCurrentTurn.TabIndex = 2
        Me.LblCurrentTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPrevMoveDetails
        '
        Me.LblPrevMoveDetails.AutoSize = True
        Me.LblPrevMoveDetails.BackColor = System.Drawing.SystemColors.Control
        Me.LblPrevMoveDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPrevMoveDetails.Location = New System.Drawing.Point(3, 222)
        Me.LblPrevMoveDetails.Name = "LblPrevMoveDetails"
        Me.LblPrevMoveDetails.Size = New System.Drawing.Size(150, 74)
        Me.LblPrevMoveDetails.TabIndex = 3
        Me.LblPrevMoveDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenu_Menu, Me.MainMenu_Help})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(581, 24)
        Me.MainMenuStrip.TabIndex = 2
        Me.MainMenuStrip.Text = "Main Menu"
        '
        'MainMenu_Menu
        '
        Me.MainMenu_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenu_Main_Exit, Me.SettingsToolStripMenuItem})
        Me.MainMenu_Menu.Name = "MainMenu_Menu"
        Me.MainMenu_Menu.Size = New System.Drawing.Size(50, 20)
        Me.MainMenu_Menu.Text = "Menu"
        '
        'MainMenu_Main_Exit
        '
        Me.MainMenu_Main_Exit.Name = "MainMenu_Main_Exit"
        Me.MainMenu_Main_Exit.Size = New System.Drawing.Size(140, 22)
        Me.MainMenu_Main_Exit.Text = "Exit to Menu"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemesToolStripMenuItem, Me.StPlayerToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ThemesToolStripMenuItem
        '
        Me.ThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenu_Settings_Themes_Basic, Me.MainMenu_Settings_Themes_Blueberry, Me.MainMenu_Settings_Themes_Monochroma, Me.MainMenu_Settings_Themes_Peach, Me.MainMenu_Settings_Themes_Stone})
        Me.ThemesToolStripMenuItem.Name = "ThemesToolStripMenuItem"
        Me.ThemesToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ThemesToolStripMenuItem.Text = "Themes"
        '
        'MainMenu_Settings_Themes_Basic
        '
        Me.MainMenu_Settings_Themes_Basic.Name = "MainMenu_Settings_Themes_Basic"
        Me.MainMenu_Settings_Themes_Basic.Size = New System.Drawing.Size(147, 22)
        Me.MainMenu_Settings_Themes_Basic.Text = "Basic"
        '
        'MainMenu_Settings_Themes_Blueberry
        '
        Me.MainMenu_Settings_Themes_Blueberry.Name = "MainMenu_Settings_Themes_Blueberry"
        Me.MainMenu_Settings_Themes_Blueberry.Size = New System.Drawing.Size(147, 22)
        Me.MainMenu_Settings_Themes_Blueberry.Text = "Blueberry"
        '
        'MainMenu_Settings_Themes_Monochroma
        '
        Me.MainMenu_Settings_Themes_Monochroma.Name = "MainMenu_Settings_Themes_Monochroma"
        Me.MainMenu_Settings_Themes_Monochroma.Size = New System.Drawing.Size(147, 22)
        Me.MainMenu_Settings_Themes_Monochroma.Text = "Monochroma"
        '
        'MainMenu_Settings_Themes_Peach
        '
        Me.MainMenu_Settings_Themes_Peach.Name = "MainMenu_Settings_Themes_Peach"
        Me.MainMenu_Settings_Themes_Peach.Size = New System.Drawing.Size(147, 22)
        Me.MainMenu_Settings_Themes_Peach.Text = "Peach"
        '
        'MainMenu_Settings_Themes_Stone
        '
        Me.MainMenu_Settings_Themes_Stone.Name = "MainMenu_Settings_Themes_Stone"
        Me.MainMenu_Settings_Themes_Stone.Size = New System.Drawing.Size(147, 22)
        Me.MainMenu_Settings_Themes_Stone.Text = "Stone"
        '
        'StPlayerToolStripMenuItem
        '
        Me.StPlayerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenu_Settings_FirstPlayer_P1, Me.MainMenu_Settings_FirstPlayer_P2, Me.MainMenu_Settings_FirstPlayer_Random, Me.MainMenu_Settings_FirstPlayer_Alternator})
        Me.StPlayerToolStripMenuItem.Name = "StPlayerToolStripMenuItem"
        Me.StPlayerToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.StPlayerToolStripMenuItem.Text = "1st Player"
        '
        'MainMenu_Settings_FirstPlayer_P1
        '
        Me.MainMenu_Settings_FirstPlayer_P1.Name = "MainMenu_Settings_FirstPlayer_P1"
        Me.MainMenu_Settings_FirstPlayer_P1.Size = New System.Drawing.Size(133, 22)
        Me.MainMenu_Settings_FirstPlayer_P1.Text = "Player 1"
        '
        'MainMenu_Settings_FirstPlayer_P2
        '
        Me.MainMenu_Settings_FirstPlayer_P2.Name = "MainMenu_Settings_FirstPlayer_P2"
        Me.MainMenu_Settings_FirstPlayer_P2.Size = New System.Drawing.Size(133, 22)
        Me.MainMenu_Settings_FirstPlayer_P2.Text = "Player 2"
        '
        'MainMenu_Settings_FirstPlayer_Random
        '
        Me.MainMenu_Settings_FirstPlayer_Random.Name = "MainMenu_Settings_FirstPlayer_Random"
        Me.MainMenu_Settings_FirstPlayer_Random.Size = New System.Drawing.Size(133, 22)
        Me.MainMenu_Settings_FirstPlayer_Random.Text = "Random"
        '
        'MainMenu_Settings_FirstPlayer_Alternator
        '
        Me.MainMenu_Settings_FirstPlayer_Alternator.Name = "MainMenu_Settings_FirstPlayer_Alternator"
        Me.MainMenu_Settings_FirstPlayer_Alternator.Size = New System.Drawing.Size(133, 22)
        Me.MainMenu_Settings_FirstPlayer_Alternator.Text = "Alternating"
        '
        'MainMenu_Help
        '
        Me.MainMenu_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetHelpToolStripMenuItem})
        Me.MainMenu_Help.Name = "MainMenu_Help"
        Me.MainMenu_Help.Size = New System.Drawing.Size(44, 20)
        Me.MainMenu_Help.Text = "Help"
        '
        'GetHelpToolStripMenuItem
        '
        Me.GetHelpToolStripMenuItem.Name = "GetHelpToolStripMenuItem"
        Me.GetHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.GetHelpToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.GetHelpToolStripMenuItem.Text = "Get Help"
        '
        'CntxtMenu
        '
        Me.CntxtMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cntxt_StartStop, Me.Cntxt_Settings, Me.Cntxt_Exit, Me.Cntxt_Help})
        Me.CntxtMenu.Name = "CntxtMenu"
        Me.CntxtMenu.Size = New System.Drawing.Size(155, 92)
        '
        'Cntxt_StartStop
        '
        Me.Cntxt_StartStop.Name = "Cntxt_StartStop"
        Me.Cntxt_StartStop.Size = New System.Drawing.Size(154, 22)
        Me.Cntxt_StartStop.Text = "Start / Stop"
        '
        'Cntxt_Settings
        '
        Me.Cntxt_Settings.Name = "Cntxt_Settings"
        Me.Cntxt_Settings.Size = New System.Drawing.Size(154, 22)
        Me.Cntxt_Settings.Text = "Settings"
        '
        'Cntxt_Exit
        '
        Me.Cntxt_Exit.Name = "Cntxt_Exit"
        Me.Cntxt_Exit.Size = New System.Drawing.Size(154, 22)
        Me.Cntxt_Exit.Text = "Exit to previous"
        '
        'Cntxt_Help
        '
        Me.Cntxt_Help.Name = "Cntxt_Help"
        Me.Cntxt_Help.Size = New System.Drawing.Size(154, 22)
        Me.Cntxt_Help.Text = "Help"
        '
        'FrmOffline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 335)
        Me.Controls.Add(Me.TblPnlMain)
        Me.Controls.Add(Me.PnlBoard)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 650)
        Me.MinimumSize = New System.Drawing.Size(520, 320)
        Me.Name = "FrmOffline"
        Me.Text = "Play"
        Me.TblPnlMain.ResumeLayout(False)
        Me.TblPnlMain.PerformLayout()
        Me.TblPnlInfo.ResumeLayout(False)
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.CntxtMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PnlBoard As System.Windows.Forms.Panel
    Friend WithEvents TblPnlMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MainMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MainMenu_Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnStartStop As System.Windows.Forms.Button
    Friend WithEvents TblPnlInfo As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MainMenu_Main_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CntxtMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Cntxt_StartStop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cntxt_Settings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cntxt_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cntxt_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThemesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_Themes_Peach As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_Themes_Blueberry As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_Themes_Stone As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_Themes_Basic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblP2Name As Label
    Friend WithEvents Lbl2 As Label
    Friend WithEvents LblP1Name As Label
    Friend WithEvents Lbl1 As Label
    Friend WithEvents LblCurrentTurn As Label
    Friend WithEvents LblPrevMoveDetails As Label
    Friend WithEvents MainMenu_Settings_Themes_Monochroma As ToolStripMenuItem
    Friend WithEvents StPlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_FirstPlayer_P1 As ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_FirstPlayer_P2 As ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_FirstPlayer_Random As ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_FirstPlayer_Alternator As ToolStripMenuItem
End Class
