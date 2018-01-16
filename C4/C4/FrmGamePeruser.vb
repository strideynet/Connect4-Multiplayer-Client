Public Class FrmGamePeruser
    Dim Searching As Boolean = False

    Dim Tooltips() As String = {"This game is easy", "If you click in the right places at the right times, you might win", "It is a distinct possibility that we've gone too far...", "Maybe one day Half-Life 3 will be released...",
                                "Personally, I believe that ℵ + N both need to get a life", "Not worth the processing power", "Play terraria!", "QWERTY or AZERTY? I vote DVORAK", "NLAS is a viable alternative",
                                "Coming soon to an Alexa near you", "Dim p As New System.Drawing.PhewwwwwwDrawingIsALotOfEffort()", "Perhaps read Tolkein. I'm not sure why.", "Now with AI*    {* Automated Idiocy }",
                                "Decidedly the best way to waste your tem", """HOOOIIIIIIIIIIIIIII"" - Tem that was wasted", "'Undertale is a good game' - Yahtzee", "Everybody do the flop!", "Na Na Na (Na Na Na Na Na Na Na Na Na)",
                                "I would fly you to the moon and back if you'll be, yeah you'll be my JET ENGINES!", "On a scale of one to ten, how much should ℵ actually do some work", "ℵ's writing a book. We think. Well, it's really just a collection of comments but that counts?",
                                "GLUTEN FREE, VEGETARIAN FRIENDLY, PRO-CHOICE, ANTI-FACIST, VEGAN EXCLUDED HAPPINESS", "Cuminati Illuonfirmed", "You would not believe your knees / if ten million bumble bees...", "The bee movie but every time the word bee is said we all play Connect 4",
                                "How much would could a woodchuck chuck if a woodchuck could chuck NORRIS‽", "Windows Vista was the best. Don't believe me? ok.", "Savour this text, there's a lot of it", "C4? That sounds dangerous",
                                "Not all of this was N! ℵ designed and coded this interface. And wrote some mini non-quotes", "Good luck", "ℵ likes doughnuts. Google Home Doughnuts!!!", "I hope you like B♭",
                                "ℵ, translating from VB to JS since 22:47 27/12/17", "Surprisingly entertaining", "We stole a server and ran away. Haven't looked back since.", "Excerpt from 'the thoughts of a boy on the topic of life': ""It couldn't be too bad, could it?""",
                                "KAMEHAMEHAMEHAMEHAMEHAMEHAMEHAMEAAAAAAAAAAAAAA", "reem memes for technologically inclined teens with beans wearing jeans", "ILLUMINATI CONFIRMED"}


    Private Sub GetHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetHelpToolStripMenuItem.Click
        FrmHelp.Show()
    End Sub

    Private Sub DeploySmoothMusicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeploySmoothMusicToolStripMenuItem.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Song, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub BtnSearchQuitSearch_Click(sender As Object, e As EventArgs) Handles BtnSearchQuitSearch.Click
        If Searching = False Then
            BtnSearchQuitSearch.Text = "Exit Search"
            Searching = True
            SpinnerTimer.Start()
            UpdateStatus("Connecting", False, Color.LightGreen)
            NewMplayerConnection()
        Else
            UpdateStatus("Connection interrupted by user", True, Color.Firebrick)
        End If
    End Sub

    Private Sub BtnLeaderboards_Click(sender As Object, e As EventArgs) Handles BtnLeaderboards.Click, LeaderboardsToolStripMenuItem.Click
        MsgBox("Sorry, but this feature is unavailable due to a distinct lack of online play to gather data from", , "LAZINESS.exe has given up")
    End Sub

    Private Sub ExitToMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToMenuToolStripMenuItem.Click
        FrmEntry.Show()
        Me.Close()
    End Sub

    Private Sub FrmGamePeruser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Computer.Audio.Play(My.Resources.Smells_Like_Teen_Spirit_but_every_note_or_chord_is, AudioPlayMode.BackgroundLoop) ' For funsies
        Randomize()
        ChangeToolTip()
        LblSpinnerRight.Visible = False
        LblSpinnerLeft.Visible = False
        SpinnerTimer.Interval = 100
        SpinnerTimer.Start()
        ToolTipTimer.Interval = 5000
        ToolTipTimer.Start()
    End Sub

    Private Sub ChangeToolTip() Handles ToolTipTimer.Tick
        Randomize()
        Dim MaxValue As Integer = Tooltips.Count - 1
        LblMiniTips.Text = Tooltips(CInt(Math.Ceiling(Rnd() * MaxValue)))
    End Sub

    Private Sub OnKeyPressed(sender As Object, E As KeyEventArgs) Handles Me.KeyDown
        If E.KeyCode = Keys.F1 Then
            FrmHelp.Show()
        End If
    End Sub

    Private Sub DoLoadingSpin() Handles SpinnerTimer.Tick
        If Searching = True Then
            LblSpinnerRight.Visible = True
            LblSpinnerLeft.Visible = True
            Select Case LblSpinnerLeft.Text

                Case "-"
                    LblSpinnerLeft.Text = "/"
                    LblSpinnerRight.Text = "\"

                Case "/"
                    LblSpinnerLeft.Text = "|"
                    LblSpinnerRight.Text = "|"

                Case "|"
                    LblSpinnerLeft.Text = "\"
                    LblSpinnerRight.Text = "/"

                Case "\"
                    LblSpinnerLeft.Text = "-"
                    LblSpinnerRight.Text = "-"

            End Select
        Else
            LblSpinnerRight.Visible = False
            LblSpinnerLeft.Visible = False
        End If

    End Sub

    Public Sub ExitMatchmaking(Optional Sender As Object = Nothing, Optional E As FormClosedEventArgs = Nothing) Handles Me.FormClosed
        ' Removes you from the queue when you press "exit search", "leaderboards" or exit the application
        'My.Computer.Audio.Stop()
        If Not Application.OpenForms().OfType(Of FrmMPlayerGame).Any Then
            BtnSearchQuitSearch.Text = "Begin Search"
            LblStatus.BackColor = Color.Firebrick

            If Searching = True Then
                Searching = False
                Connection.CloseConnection()
                MsgBox("Exiting matchmaking!")

            End If
        End If
    End Sub

    Private Sub NewMplayerConnection()
        Try

            Dim UsrName As String = InputBox("What's your username?", "C-4: Online Play", "Anonymous Moose")
            If UsrName = "" Then UsrName = "Anonymous Guadaloupe"
            ExternalVars.LocalName = UsrName
            ExternalVars.Connection = New MPlayerConnection("ws://91.134.107.74:80/", UsrName, Me) ' "ws://91.134.107.74:80/" (srvr), "ws://127.0.0.1:80/" (local)


        Catch ERR As Exception
            'MsgBox(ERR.ToString())
            UpdateStatus("Error: Ded", True, Color.Firebrick)
        End Try
    End Sub

    Public Sub StartGame(MSG As Object)
        'MsgBox(MSG.ToString())
        ExternalVars.LocalNumber = CInt(MSG("data")("localNum"))
        ExternalVars.OpponentName = CStr(MSG("data")("opponent"))
        FrmMPlayerGame.Show()
        Me.Close()
    End Sub

    Public Sub UpdateStatus(ByVal Details As String, ByVal EndConnection As Boolean, ByVal MyColour As Color)
        'MsgBox(MyColour.ToString())
        'MsgBox(Details)
        LblStatus.BackColor = MyColour
        LblSpinnerRight.BackColor = MyColour
        LblSpinnerLeft.BackColor = MyColour
        LblStatus.Text = Details
        LblSpinnerLeft.Refresh()
        LblSpinnerRight.Refresh()
        LblStatus.Refresh()

        If EndConnection = True Then
            ExitMatchmaking()
        End If
    End Sub

    Private Sub LblMiniTips_Click(sender As Object, e As EventArgs) Handles LblMiniTips.Click
        ChangeToolTip()
    End Sub
End Class