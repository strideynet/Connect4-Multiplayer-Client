Public Class FrmMPlayerGame
    Dim Game As New OnlineGame(10)
    Dim DoRedraw As Boolean = True
#Region "Paint Controls"


    Private Sub Refresher(Sender As Object, ByVal E As EventArgs) Handles PnlBoard.Paint
        PnlBoard.BackColor = My.Settings.BoardColour
        DrawCirclesOnRefresh(Sender, E)
        Game.DoInfinityAndBeyond()
    End Sub

    ''' <summary>
    ''' Insert this snippet every time the board is redrawn.
    ''' </summary>
    ''' <param name="Sender">The object that called the subroutine</param>
    ''' <param name="e">The events that called the subroutine</param>
    Public Sub DrawCirclesOnRefresh(Sender As Object, ByVal e As PaintEventArgs)
        If DoRedraw = True Then
            DoRedraw = False
            PnlBoard.Refresh()
            Dim SizeX As Integer = Sender.Width
            Dim SizeY As Integer = Sender.Height
            Dim GP As New Pen(Game.GridPen.Color, Game.GridPen.Width)

            e.Graphics.DrawLine(GP, 0, 0, 0, SizeY) ' Left
            e.Graphics.DrawLine(GP, 0, 0, SizeX, 0) ' Top
            e.Graphics.DrawLine(GP, 0, SizeY - 1, SizeX, SizeY - 1) ' Bottom
            e.Graphics.DrawLine(GP, SizeX - 1, 0, SizeX - 1, SizeY) ' Right

            For Xlooper = 0 To 6
                'Debug.WriteLine(MiniX * Xlooper)
                e.Graphics.DrawLine(GP, CInt(Math.Floor((SizeX / 7) * Xlooper)), 0, CInt(Math.Floor((SizeX / 7) * Xlooper)), SizeY)
            Next

            For Ylooper = 0 To 6
                'Debug.WriteLine(MiniY * Ylooper)
                e.Graphics.DrawLine(GP, 0, CInt(Math.Floor((SizeY / 6) * Ylooper)), SizeX, CInt(Math.Floor((SizeY / 6) * Ylooper)))
            Next

            GP.Dispose()

            Dim EP As New Pen(Game.EllipsePen.Color, Game.EllipsePen.Width)

            Dim MiniX As Integer = CInt(Math.Floor(SizeX / 7))
            Dim MiniY As Integer = CInt(Math.Floor(SizeY / 6))

            For Looper1 = 0 To 6
                For Looper2 = 0 To 5

                    Dim XLocation As Integer = Math.Floor(((SizeX / 7)) * Looper1)
                    Dim YLocation As Integer = Math.Floor(((SizeY / 6)) * Looper2)

                    If Game.Board(Looper1, Looper2) = 1 Then
                        e.Graphics.FillEllipse(Game.P1Brush, XLocation, YLocation, MiniX, MiniY)
                        'e.Graphics.DrawEllipse(EP, XLocation, YLocation, MiniX, MiniY)

                    ElseIf Game.Board(Looper1, Looper2) = 10 Then
                        e.Graphics.FillEllipse(Game.P2Brush, XLocation, YLocation, MiniX, MiniY)
                        'e.Graphics.DrawEllipse(EP, XLocation, YLocation, MiniX, MiniY)

                    Else
                        'e.Graphics.DrawEllipse(EP, XLocation, YLocation, MiniX, MiniY)

                    End If
                    'Debug.WriteLine(CStr(Looper1) & ", " & CStr(Looper2))
                Next
            Next

            EP.Dispose()
        End If
    End Sub

    ''' <summary>
    ''' Redraw the board upon resizing of window
    ''' </summary>
    Private Sub SomeoneResizedMe() Handles PnlBoard.Resize
        DoRedraw = True
        PnlBoard.Refresh()
    End Sub



    Private Sub OnClicky(Sender As Object, E As MouseEventArgs) Handles PnlBoard.MouseDown
        If E.Button = Windows.Forms.MouseButtons.Left Then
            Dim Location As Integer = E.Location.X
            Dim Seventh As Double = Sender.Width / 7
            Dim Player As Integer = 1

            If Location >= 0 And Location < Seventh Then
                'MsgBox(0)
                If Game.CheckTop(0) = True Then Exit Sub Else Game.MakeMove(0)
            ElseIf Location >= Seventh And Location < (Seventh * 2) Then
                'MsgBox(1)
                If Game.CheckTop(1) = True Then Exit Sub Else Game.MakeMove(1)
            ElseIf Location >= (Seventh * 2) And Location < (Seventh * 3) Then
                'MsgBox(2)
                If Game.CheckTop(2) = True Then Exit Sub Else Game.MakeMove(2)
            ElseIf Location >= (Seventh * 3) And Location < (Seventh * 4) Then
                'MsgBox(3)
                If Game.CheckTop(3) = True Then Exit Sub Else Game.MakeMove(3)
            ElseIf Location >= (Seventh * 4) And Location < (Seventh * 5) Then
                'MsgBox(4)
                If Game.CheckTop(4) = True Then Exit Sub Else Game.MakeMove(4)
            ElseIf Location >= (Seventh * 5) And Location < (Seventh * 6) Then
                'MsgBox(5)
                If Game.CheckTop(5) = True Then Exit Sub Else Game.MakeMove(5)
            ElseIf Location >= (Seventh * 6) And Location <= Sender.Width Then
                'MsgBox(6)
                If Game.CheckTop(6) = True Then Exit Sub Else Game.MakeMove(6)
            End If
            Game.PerformGravity()
        End If
    End Sub



    ''' <summary>
    ''' Debugging: writes the contents of the board to the console
    ''' </summary>
    Private Sub DebugState()
        Debug.Write(" ___________________ " & Environment.NewLine & "| ")
        For Column = 0 To 6
            For Row = 1 To 5
                Debug.Write(Game.Board(Column, Row) & " | ")
            Next
            Debug.Write(Environment.NewLine & "| ")
        Next
        Debug.WriteLine("__________________/" & Environment.NewLine)
    End Sub

    ' ___________________
    '| 0 | 0 | 0 | 0 | 0 | 
    '| 0 | 0 | 0 | 0 | 9 | this board is at the wrong angle..... Hmmmmmmmmmmmmmmmm
    '| 0 | 0 | 0 | 0 | 0 | 
    '| 0 | 0 | 0 | 0 | 0 | 
    '| 0 | 0 | 0 | 0 | 0 | 
    '| 0 | 0 | 0 | 0 | 1 | 
    '| 0 | 0 | 0 | 0 | 0 | 
    '| __________________/

    Private Sub GameThemeSettingsBasicClicked() Handles MainMenu_Settings_Themes_Basic.Click
        MainMenu_Settings_Themes_Basic.Checked = True
        MainMenu_Settings_Themes_Blueberry.Checked = False
        MainMenu_Settings_Themes_Peach.Checked = False
        MainMenu_Settings_Themes_Stone.Checked = False
        MainMenu_Settings_Themes_Monochroma.Checked = False
        UpdateMainGameTheme("DEFAULT")
    End Sub
    Private Sub GameThemeSettingsPeachClicked() Handles MainMenu_Settings_Themes_Peach.Click
        MainMenu_Settings_Themes_Basic.Checked = False
        MainMenu_Settings_Themes_Blueberry.Checked = False
        MainMenu_Settings_Themes_Peach.Checked = True
        MainMenu_Settings_Themes_Stone.Checked = False
        MainMenu_Settings_Themes_Monochroma.Checked = False
        UpdateMainGameTheme("PEACH")
    End Sub
    Private Sub GameThemeSettingsStoneClicked() Handles MainMenu_Settings_Themes_Stone.Click
        MainMenu_Settings_Themes_Basic.Checked = False
        MainMenu_Settings_Themes_Blueberry.Checked = False
        MainMenu_Settings_Themes_Peach.Checked = False
        MainMenu_Settings_Themes_Stone.Checked = True
        MainMenu_Settings_Themes_Monochroma.Checked = False
        UpdateMainGameTheme("STONE")
    End Sub
    Private Sub GameThemeSettingsBlueberryClicked() Handles MainMenu_Settings_Themes_Blueberry.Click
        MainMenu_Settings_Themes_Basic.Checked = False
        MainMenu_Settings_Themes_Blueberry.Checked = True
        MainMenu_Settings_Themes_Peach.Checked = False
        MainMenu_Settings_Themes_Stone.Checked = False
        MainMenu_Settings_Themes_Monochroma.Checked = False
        UpdateMainGameTheme("BLUEBERRY")
    End Sub
    Private Sub GameThemeSettingsMonochromaClicked() Handles MainMenu_Settings_Themes_Monochroma.Click
        MainMenu_Settings_Themes_Basic.Checked = False
        MainMenu_Settings_Themes_Blueberry.Checked = False
        MainMenu_Settings_Themes_Peach.Checked = False
        MainMenu_Settings_Themes_Stone.Checked = False
        MainMenu_Settings_Themes_Monochroma.Checked = True
        UpdateMainGameTheme("MONOCHROMA")
    End Sub
    Private Sub UpdateMainGameTheme(ByVal NewTheme As String)

        Themes.ChangeTheme(NewTheme, , Game)

        PnlBoard.BackColor = My.Settings.BoardColour

        DoRedraw = True
        PnlBoard.Refresh()
    End Sub
#End Region

    Private Sub FrmMPlayerGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenu_Settings_Themes_Peach.Checked = False
        MainMenu_Settings_Themes_Blueberry.Checked = False
        MainMenu_Settings_Themes_Stone.Checked = False
        MainMenu_Settings_Themes_Basic.Checked = False
        Select Case My.Settings.CurrentTheme.ToUpper()

            Case "PEACH"
                MainMenu_Settings_Themes_Peach.Checked = True
            Case "BLUEBERRY"
                MainMenu_Settings_Themes_Blueberry.Checked = True
            Case "STONE"
                MainMenu_Settings_Themes_Stone.Checked = True
            Case "MONOCHROMA"
                MainMenu_Settings_Themes_Monochroma.Checked = True
            Case Else
                MainMenu_Settings_Themes_Basic.Checked = True

        End Select

        Debug.WriteLine("LocalNumber: " & CStr(ExternalVars.LocalNumber))
        Game = New OnlineGame(ExternalVars.LocalNumber)

        LblP1Name.Text = "Player 1: " & Game.P1Name
        LblP2Name.Text = "Player 2: " & Game.P2Name

        UpdateMainGameTheme(My.Settings.CurrentTheme)
        DoRedraw = True
        PnlBoard.Refresh()

        ExternalVars.Connection.UpdateReferenceForm(Me)

        If Game.MyTurn = True Then
            LblCurrentTurn.Text = "It's your turn"
        Else
            LblCurrentTurn.Text = "It's " & ExternalVars.OpponentName & "'s turn"
        End If
    End Sub

    Public Sub ReceiveTurn(MSG As Object)
        'Debug.WriteLine(CStr(MSG))
        For X = 0 To 6 Step 1
            For Y = 0 To 5 Step 1
                Game.Board(X, Y) = CInt(MSG("data")("board")(X)(Y))
            Next
        Next
        Game.MyTurn = (Game.LocalNum = CInt(MSG("data")("currentPlayer")))

        If Game.MyTurn = True Then
            LblCurrentTurn.Text = "It's your turn"
        Else
            LblCurrentTurn.Text = "It's " & ExternalVars.OpponentName & "'s turn"
        End If


        DoRedraw = True
        PnlBoard.Refresh()
    End Sub

    Private Sub TxtChatSender_TextChanged(sender As Object, e As EventArgs) Handles TxtChatSender.TextChanged
        BtnSendChat.Enabled = (TxtChatSender.Text = "")

    End Sub

    Private Sub GetHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetHelpToolStripMenuItem.Click
        FrmHelp.Show()
    End Sub

End Class