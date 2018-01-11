<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMPlayerGame
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
        Me.PnlBoard = New System.Windows.Forms.Panel()
        Me.TxtChatHistory = New System.Windows.Forms.TextBox()
        Me.TxtChatSender = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Basic = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Blueberry = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Peach = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Stone = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Monochroma = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSendChat = New System.Windows.Forms.Button()
        Me.LblCurrentTurn = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblP1Name = New System.Windows.Forms.Label()
        Me.LblP2Name = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBoard
        '
        Me.PnlBoard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlBoard.Location = New System.Drawing.Point(12, 27)
        Me.PnlBoard.Name = "PnlBoard"
        Me.PnlBoard.Size = New System.Drawing.Size(427, 352)
        Me.PnlBoard.TabIndex = 0
        '
        'TxtChatHistory
        '
        Me.TxtChatHistory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtChatHistory.Location = New System.Drawing.Point(445, 106)
        Me.TxtChatHistory.Multiline = True
        Me.TxtChatHistory.Name = "TxtChatHistory"
        Me.TxtChatHistory.ReadOnly = True
        Me.TxtChatHistory.Size = New System.Drawing.Size(235, 247)
        Me.TxtChatHistory.TabIndex = 1
        '
        'TxtChatSender
        '
        Me.TxtChatSender.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtChatSender.Location = New System.Drawing.Point(445, 359)
        Me.TxtChatSender.Name = "TxtChatSender"
        Me.TxtChatSender.Size = New System.Drawing.Size(174, 20)
        Me.TxtChatSender.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(692, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToMenuToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ExitToMenuToolStripMenuItem
        '
        Me.ExitToMenuToolStripMenuItem.Name = "ExitToMenuToolStripMenuItem"
        Me.ExitToMenuToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ExitToMenuToolStripMenuItem.Text = "Exit Game"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemesToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ThemesToolStripMenuItem
        '
        Me.ThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenu_Settings_Themes_Basic, Me.MainMenu_Settings_Themes_Blueberry, Me.MainMenu_Settings_Themes_Peach, Me.MainMenu_Settings_Themes_Stone, Me.MainMenu_Settings_Themes_Monochroma})
        Me.ThemesToolStripMenuItem.Name = "ThemesToolStripMenuItem"
        Me.ThemesToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
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
        'MainMenu_Settings_Themes_Monochroma
        '
        Me.MainMenu_Settings_Themes_Monochroma.Name = "MainMenu_Settings_Themes_Monochroma"
        Me.MainMenu_Settings_Themes_Monochroma.Size = New System.Drawing.Size(147, 22)
        Me.MainMenu_Settings_Themes_Monochroma.Text = "Monochroma"
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
        'BtnSendChat
        '
        Me.BtnSendChat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSendChat.Location = New System.Drawing.Point(625, 359)
        Me.BtnSendChat.Name = "BtnSendChat"
        Me.BtnSendChat.Size = New System.Drawing.Size(55, 20)
        Me.BtnSendChat.TabIndex = 4
        Me.BtnSendChat.Text = "Send"
        Me.BtnSendChat.UseVisualStyleBackColor = True
        '
        'LblCurrentTurn
        '
        Me.LblCurrentTurn.Location = New System.Drawing.Point(3, 49)
        Me.LblCurrentTurn.Name = "LblCurrentTurn"
        Me.LblCurrentTurn.Size = New System.Drawing.Size(229, 23)
        Me.LblCurrentTurn.TabIndex = 5
        Me.LblCurrentTurn.Text = "It's Xs Turn"
        Me.LblCurrentTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblP2Name)
        Me.Panel1.Controls.Add(Me.LblP1Name)
        Me.Panel1.Controls.Add(Me.LblCurrentTurn)
        Me.Panel1.Location = New System.Drawing.Point(445, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 73)
        Me.Panel1.TabIndex = 6
        '
        'LblP1Name
        '
        Me.LblP1Name.Location = New System.Drawing.Point(3, 1)
        Me.LblP1Name.Name = "LblP1Name"
        Me.LblP1Name.Size = New System.Drawing.Size(229, 13)
        Me.LblP1Name.TabIndex = 6
        Me.LblP1Name.Text = "Player 1: "
        Me.LblP1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblP2Name
        '
        Me.LblP2Name.Location = New System.Drawing.Point(3, 14)
        Me.LblP2Name.Name = "LblP2Name"
        Me.LblP2Name.Size = New System.Drawing.Size(229, 14)
        Me.LblP2Name.TabIndex = 7
        Me.LblP2Name.Text = "Player 2: "
        Me.LblP2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMPlayerGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 391)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSendChat)
        Me.Controls.Add(Me.TxtChatSender)
        Me.Controls.Add(Me.TxtChatHistory)
        Me.Controls.Add(Me.PnlBoard)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMPlayerGame"
        Me.Text = "FrmMPlayerGame"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlBoard As Panel
    Friend WithEvents TxtChatHistory As TextBox
    Friend WithEvents TxtChatSender As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_Themes_Basic As ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_Themes_Blueberry As ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_Themes_Peach As ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_Themes_Stone As ToolStripMenuItem
    Friend WithEvents MainMenu_Settings_Themes_Monochroma As ToolStripMenuItem
    Friend WithEvents BtnSendChat As System.Windows.Forms.Button
    Friend WithEvents GetHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblCurrentTurn As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblP2Name As System.Windows.Forms.Label
    Friend WithEvents LblP1Name As System.Windows.Forms.Label
End Class
