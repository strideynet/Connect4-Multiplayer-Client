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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Basic = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Blueberry = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Peach = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Stone = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu_Settings_Themes_Monochroma = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBoard
        '
        Me.PnlBoard.Location = New System.Drawing.Point(12, 27)
        Me.PnlBoard.Name = "PnlBoard"
        Me.PnlBoard.Size = New System.Drawing.Size(451, 335)
        Me.PnlBoard.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(469, 27)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(211, 308)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(470, 341)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(210, 20)
        Me.TextBox2.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(743, 24)
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
        Me.ExitToMenuToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToMenuToolStripMenuItem.Text = "Exit Game"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemesToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ThemesToolStripMenuItem
        '
        Me.ThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenu_Settings_Themes_Basic, Me.MainMenu_Settings_Themes_Blueberry, Me.MainMenu_Settings_Themes_Peach, Me.MainMenu_Settings_Themes_Stone, Me.MainMenu_Settings_Themes_Monochroma})
        Me.ThemesToolStripMenuItem.Name = "ThemesToolStripMenuItem"
        Me.ThemesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ThemesToolStripMenuItem.Text = "Themes"
        '
        'MainMenu_Settings_Themes_Basic
        '
        Me.MainMenu_Settings_Themes_Basic.Name = "MainMenu_Settings_Themes_Basic"
        Me.MainMenu_Settings_Themes_Basic.Size = New System.Drawing.Size(152, 22)
        Me.MainMenu_Settings_Themes_Basic.Text = "Basic"
        '
        'MainMenu_Settings_Themes_Blueberry
        '
        Me.MainMenu_Settings_Themes_Blueberry.Name = "MainMenu_Settings_Themes_Blueberry"
        Me.MainMenu_Settings_Themes_Blueberry.Size = New System.Drawing.Size(152, 22)
        Me.MainMenu_Settings_Themes_Blueberry.Text = "Blueberry"
        '
        'MainMenu_Settings_Themes_Peach
        '
        Me.MainMenu_Settings_Themes_Peach.Name = "MainMenu_Settings_Themes_Peach"
        Me.MainMenu_Settings_Themes_Peach.Size = New System.Drawing.Size(152, 22)
        Me.MainMenu_Settings_Themes_Peach.Text = "Peach"
        '
        'MainMenu_Settings_Themes_Stone
        '
        Me.MainMenu_Settings_Themes_Stone.Name = "MainMenu_Settings_Themes_Stone"
        Me.MainMenu_Settings_Themes_Stone.Size = New System.Drawing.Size(152, 22)
        Me.MainMenu_Settings_Themes_Stone.Text = "Stone"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'MainMenu_Settings_Themes_Monochroma
        '
        Me.MainMenu_Settings_Themes_Monochroma.Name = "MainMenu_Settings_Themes_Monochroma"
        Me.MainMenu_Settings_Themes_Monochroma.Size = New System.Drawing.Size(152, 22)
        Me.MainMenu_Settings_Themes_Monochroma.Text = "Monochroma"
        '
        'FrmMPlayerGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 530)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PnlBoard)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMPlayerGame"
        Me.Text = "FrmMPlayerGame"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlBoard As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
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
End Class
