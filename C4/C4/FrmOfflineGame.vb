Public Class FrmOffline

    Dim Game As New OfflineGameDetails(True) ', Color.LightCoral, Color.DarkCyan, Color.DarkSlateGray)
    Dim FirstPlayer As Boolean = True
    Dim DoRedraw As Boolean = True
    Dim Playing As Boolean = False

    Private Sub Main_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Game.Board(1, 1) = 9 ' 9 = P2
        'Game.Board(5, 4) = 1 ' 1 = P1
        MainMenu_Settings_Themes_Peach.Checked = False
        MainMenu_Settings_Themes_Blueberry.Checked = False
        MainMenu_Settings_Themes_Stone.Checked = False
        MainMenu_Settings_Themes_Basic.Checked = False
        MainMenu_Settings_FirstPlayer_P1.Checked = True
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

        UpdateMainGameTheme(My.Settings.CurrentTheme)
        DoRedraw = True
        PnlBoard.Refresh()
    End Sub

    Private Sub Refresher(Sender As Object, ByVal E As EventArgs) Handles PnlBoard.Paint
        PnlBoard.BackColor = My.Settings.BoardColour
        DrawCirclesOnRefresh(Sender, E)
        DoInfinityAndBeyond()
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
            'ByLEwis
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

                    ElseIf Game.Board(Looper1, Looper2) = 9 Then
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

    Private Sub PerformGravity()
        DoRedraw = True
        PnlBoard.Refresh()
        Dim ChangeMade As Boolean = True
        While ChangeMade = True
            ChangeMade = False
            For Column = 0 To 6
                For Row = 4 To 0 Step -1
                    If Game.Board(Column, Row) <> 0 And Game.Board(Column, Row + 1) = 0 Then
                        Game.Board(Column, Row + 1) = Game.Board(Column, Row)
                        'DebugState()
                        Game.Board(Column, Row) = 0
                        ChangeMade = True
                        'DebugState()
                    End If
                Next
            Next

            If ChangeMade = True Then
                System.Threading.Thread.Sleep(50)
                DoRedraw = True
                PnlBoard.Refresh()
            End If
        End While
    End Sub

    Private Sub DoInfinityAndBeyond()
        Dim EmptySpace As Boolean = False
        For Column = 0 To 6
            If Game.Board(Column, 2) = 0 Then EmptySpace = True
        Next
        'Debug.WriteLine(CStr(EmptySpace))
        If EmptySpace = False Then
            ' Shift board by 1
            'MsgBox("INFINITYING")
            For Looper1 = 6 To 0 Step -1
                For Looper2 = 5 To 0 Step -1
                    If Looper2 = 5 Then
                        Game.Board(Looper1, Looper2) = 0
                    Else
                        Game.Board(Looper1, Looper2 + 1) = Game.Board(Looper1, Looper2)
                        Game.Board(Looper1, Looper2) = 0
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub OnClicky(Sender As Object, E As MouseEventArgs) Handles PnlBoard.MouseDown
        If E.Button = Windows.Forms.MouseButtons.Left And Playing = True Then
            Dim Location As Integer = E.Location.X
            Dim Seventh As Double = Sender.Width / 7
            Dim Player As Integer = 0
            Dim ChosenCol As Integer = 0
            If Game.PlayerTurn = True Then Player = 1 Else Player = 9

            If Location >= 0 And Location < Seventh Then
                'MsgBox(0)
                If CheckTop(0) = True Then Exit Sub Else Game.Board(0, 0) = Player : ChosenCol = 1
            ElseIf Location >= Seventh And Location < (Seventh * 2) Then
                'MsgBox(1)
                If CheckTop(1) = True Then Exit Sub Else Game.Board(1, 0) = Player : ChosenCol = 2
            ElseIf Location >= (Seventh * 2) And Location < (Seventh * 3) Then
                'MsgBox(2)
                If CheckTop(2) = True Then Exit Sub Else Game.Board(2, 0) = Player : ChosenCol = 3
            ElseIf Location >= (Seventh * 3) And Location < (Seventh * 4) Then
                'MsgBox(3)
                If CheckTop(3) = True Then Exit Sub Else Game.Board(3, 0) = Player : ChosenCol = 4
            ElseIf Location >= (Seventh * 4) And Location < (Seventh * 5) Then
                'MsgBox(4)
                If CheckTop(4) = True Then Exit Sub Else Game.Board(4, 0) = Player : ChosenCol = 5
            ElseIf Location >= (Seventh * 5) And Location < (Seventh * 6) Then
                'MsgBox(5)
                If CheckTop(5) = True Then Exit Sub Else Game.Board(5, 0) = Player : ChosenCol = 6
            ElseIf Location >= (Seventh * 6) And Location <= Sender.Width Then
                'MsgBox(6)
                If CheckTop(6) = True Then Exit Sub Else Game.Board(6, 0) = Player : ChosenCol = 7
            End If
            If Game.PlayerTurn = True Then Game.PlayerTurn = False Else Game.PlayerTurn = True
            TurnInfoUpdater(ChosenCol)
            PerformGravity()
            Dim VictoryCheck As String = CheckWin()
            If VictoryCheck <> "NONE" Then MsgBox("The winner is: " & VictoryCheck) : MsgBox("Congratulations!") : BtnStartStop_Click(Nothing, Nothing)
        End If
    End Sub
    Private Function CheckTop(ByVal Col As Integer) As Boolean
        If Game.Board(Col, 0) = 0 Then Return False Else MsgBox("This column is obviously full. Please try another one", , "FAILURE") : Return True
    End Function

    Private Function CheckWin() As String
        ' Sum of 4 is a win for P1, sum of 36 is a win for P2

        Dim Victory As String = "NONE"

        For BigXLooper = 0 To 3
            For BigYLooper = 0 To 2
                Dim Total As Integer = 0
                For SmallXLooper = 0 To 3
                    Total = 0
                    For SmallYLooper = 0 To 3 ' Searches verticals
                        Total += Game.Board(SmallXLooper + BigXLooper, SmallYLooper + BigYLooper)
                    Next
                    If Total = 4 Then Victory = Game.P1Name Else If Total = 36 Then Victory = Game.P2Name
                Next
                If Victory <> "NONE" Then Exit For

                Total = 0
                For SmallYLooper = 0 To 3
                    Total = 0
                    For SmallXLooper = 0 To 3 ' Searches Horizontals
                        Total += Game.Board(SmallXLooper + BigXLooper, SmallYLooper + BigYLooper)
                    Next
                    If Total = 36 Then Victory = Game.P2Name Else If Total = 4 Then Victory = Game.P1Name
                Next
                If Victory <> "NONE" Then Exit For

                Dim DiagonalTopLBtmR As Integer = Game.Board(BigXLooper, BigYLooper) + Game.Board(BigXLooper + 1, BigYLooper + 1) +
                    Game.Board(BigXLooper + 2, BigYLooper + 2) + Game.Board(BigXLooper + 3, BigYLooper + 3)
                If DiagonalTopLBtmR = 4 Then
                    Victory = Game.P1Name
                    Exit For
                ElseIf DiagonalTopLBtmR = 36 Then
                    Victory = Game.P2Name
                    Exit For
                End If

                Dim DiagonalBtmLTopR As Integer = Game.Board(BigXLooper + 3, BigYLooper) + Game.Board(BigXLooper + 2, BigYLooper + 1) +
                    Game.Board(BigXLooper + 1, BigYLooper + 2) + Game.Board(BigXLooper, BigYLooper + 3)
                If DiagonalBtmLTopR = 4 Then
                    Victory = Game.P1Name
                    Exit For
                ElseIf DiagonalBtmLTopR = 36 Then
                    Victory = Game.P2Name
                    Exit For
                End If

            Next
            If Victory <> "NONE" Then Exit For
        Next

        Return Victory

    End Function



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

        Themes.ChangeTheme(NewTheme, Game)

        LblP1Name.BackColor = My.Settings.P1Colour
        LblP2Name.BackColor = My.Settings.P2Colour
        Lbl1.BackColor = My.Settings.P1Colour
        Lbl2.BackColor = My.Settings.P2Colour
        PnlBoard.BackColor = My.Settings.BoardColour


        If Game.P2Colour = Color.Black Then LblP2Name.ForeColor = Color.White Else LblP2Name.ForeColor = Color.Black
        If Game.P1Colour = Color.Black Then LblP1Name.ForeColor = Color.White Else LblP1Name.ForeColor = Color.Black
        Lbl1.ForeColor = LblP1Name.ForeColor
        Lbl2.ForeColor = LblP2Name.ForeColor

        DoRedraw = True
        PnlBoard.Refresh()
    End Sub

    Private Sub MainMenu_Main_Exit_Click(sender As Object, e As EventArgs) Handles MainMenu_Main_Exit.Click
        FrmEntry.Show()
        Me.Close()
    End Sub

    Private Sub GetHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetHelpToolStripMenuItem.Click
        FrmHelp.Show()
    End Sub
    Private Sub OnKeyPressed(sender As Object, E As KeyEventArgs) Handles Me.KeyDown
        If E.KeyCode = Keys.F1 Then
            FrmHelp.Show()
        End If
    End Sub

    Private Sub BtnStartStop_Click(sender As Object, e As EventArgs) Handles BtnStartStop.Click
        If Playing = False Then
            CheckFirstPlayer()
            Game = New OfflineGameDetails(FirstPlayer)
            'Game.PlayerTurn = True
            BtnStartStop.Text = "Exit"
            If LblP1Name.Text = "Player 1" Then
                Game.P1Name = InputBox("Player 1's name?", "C-4: Offline Play", "Player 1")
                If Game.P1Name = "" Then Game.P1Name = "Player 1"
            Else
                Game.P1Name = LblP1Name.Text
            End If
            LblP1Name.Text = Game.P1Name
            If LblP2Name.Text = "Player 2" Then
                Game.P2Name = InputBox("Player 2's name?", "C-4: Offline Play", "Player 2")
                If Game.P2Name = "" Then Game.P2Name = "Player 2"
            Else
                Game.P2Name = LblP2Name.Text
            End If
            LblP2Name.Text = Game.P2Name
            Playing = True
            TurnInfoUpdater(-1)
        Else
            BtnStartStop.Text = "Start"
            Playing = False
            TurnInfoUpdater(-2)
            DoRedraw = True
            PnlBoard.Refresh()
        End If
    End Sub

    Private Sub TurnInfoUpdater(Column As Integer)
        If Playing = True Then
            If Game.PlayerTurn = True Then ' 1
                LblCurrentTurn.BackColor = Game.P1Colour
                If Game.P1Colour = Color.Black Then LblCurrentTurn.ForeColor = Color.White Else LblCurrentTurn.ForeColor = Color.Black
                LblCurrentTurn.Text = "It's " & Game.P1Name & "'s turn"

            Else ' 2
                LblCurrentTurn.BackColor = Game.P2Colour
                If Game.P2Colour = Color.Black Then LblCurrentTurn.ForeColor = Color.White Else LblCurrentTurn.ForeColor = Color.Black
                LblCurrentTurn.Text = "It's " & Game.P2Name & "'s turn"

            End If

            If Column = -1 Then
                LblPrevMoveDetails.Text = "No one has moved yet"
            ElseIf Column = -2 Then
                LblPrevMoveDetails.Text = "No game in progress"
            Else
                If Game.PlayerTurn = False Then LblPrevMoveDetails.Text = Game.P1Name Else LblPrevMoveDetails.Text = Game.P2Name
                LblPrevMoveDetails.Text &= " moved in column " & Column
            End If

        Else
            LblCurrentTurn.Text = ""
            LblPrevMoveDetails.Text = ""
            LblCurrentTurn.BackColor = Color.FromKnownColor(KnownColor.Control)
        End If
    End Sub

    Private Sub MainMenu_Settings_FirstPlayer_P1_Click(sender As Object, e As EventArgs) Handles MainMenu_Settings_FirstPlayer_P1.Click
        MainMenu_Settings_FirstPlayer_P1.Checked = True
        MainMenu_Settings_FirstPlayer_P2.Checked = False
        MainMenu_Settings_FirstPlayer_Alternator.Checked = False
        MainMenu_Settings_FirstPlayer_Random.Checked = False
    End Sub

    Private Sub MainMenu_Settings_FirstPlayer_P2_Click(sender As Object, e As EventArgs) Handles MainMenu_Settings_FirstPlayer_P2.Click
        MainMenu_Settings_FirstPlayer_P1.Checked = False
        MainMenu_Settings_FirstPlayer_P2.Checked = True
        MainMenu_Settings_FirstPlayer_Alternator.Checked = False
        MainMenu_Settings_FirstPlayer_Random.Checked = False
    End Sub

    Private Sub MainMenu_Settings_FirstPlayer_Random_Click(sender As Object, e As EventArgs) Handles MainMenu_Settings_FirstPlayer_Random.Click
        MainMenu_Settings_FirstPlayer_P1.Checked = False
        MainMenu_Settings_FirstPlayer_P2.Checked = False
        MainMenu_Settings_FirstPlayer_Alternator.Checked = False
        MainMenu_Settings_FirstPlayer_Random.Checked = True
    End Sub

    Private Sub MainMenu_Settings_FirstPlayer_Alternator_Click(sender As Object, e As EventArgs) Handles MainMenu_Settings_FirstPlayer_Alternator.Click
        MainMenu_Settings_FirstPlayer_P1.Checked = False
        MainMenu_Settings_FirstPlayer_P2.Checked = False
        MainMenu_Settings_FirstPlayer_Alternator.Checked = True
        MainMenu_Settings_FirstPlayer_Random.Checked = False
    End Sub
    Private Sub CheckFirstPlayer()
        If MainMenu_Settings_FirstPlayer_P1.Checked = True Then
            FirstPlayer = True

        ElseIf MainMenu_Settings_FirstPlayer_P2.Checked = True Then
            FirstPlayer = False

        ElseIf MainMenu_Settings_FirstPlayer_Random.Checked = True Then
            Randomize()
            Dim Checker As Integer = CInt(Math.Ceiling(Rnd() * 2)) + 1

            If Checker = 2 Then FirstPlayer = True Else FirstPlayer = False

        Else
            If FirstPlayer = True Then FirstPlayer = False Else FirstPlayer = True
        End If
    End Sub
End Class