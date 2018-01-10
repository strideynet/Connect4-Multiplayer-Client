Public Class FrmHelp

    Private Sub FrmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbbxSelector.SelectedIndex = 0
    End Sub


    Dim SinglePlayerHelpText As String = "SINGLE PLAYER MODE" & Environment.NewLine &
        "When you click ""Go it offline"" in the main menu, you will be taken to the offline play screen." & Environment.NewLine &
        "How To Play" & Environment.NewLine &
        "- The aim of the game is to get four of your counters in a line horizontally, vertically or diagonally, while preventing your opponent from doing the same" & Environment.NewLine &
        "- To do this, simply click within the column of your chosen space. This will place a counter at the top, which will then fall to your space" & Environment.NewLine &
        "- You cannot place a counter in a full column" & Environment.NewLine & Environment.NewLine &
        "The Display" & Environment.NewLine &
        "- The 'Start' / 'End' button - Clicking this will prompt you to enter a name for each player. The game begins with the first player." & Environment.NewLine &
        "- The player names - Your names are displayed here, and the colour box around them informs you what colour you are" & Environment.NewLine &
        "- Turn information - The name of the player who is to move" & Environment.NewLine &
        "- Last turn information - Tells you which column was played last (In case of really slow games)" & Environment.NewLine

    Dim MultiplayerHelpText As String = "ONLINE PLAY" & Environment.NewLine &
        "Clicking 'Play vs. Strangers' will allow you to connect to the internet to play against other people." & Environment.NewLine &
        "Anyone running this C4 client or Strideynet's Connect4 will be able to play online, as long as the server is online" & Environment.NewLine &
        "To begin the search, click 'Begin Search'. At any point while searching you can click it again to exit matchmaking" & Environment.NewLine &
        "The game plays the same as normal Connect 4, so it is recommended you play this to familiarise yourself with the game before attempting online play. We have found that this C4 client offers the best overall offline user experience. Mostly because it actually has one" & Environment.NewLine &
        "While playing online, you can send text messages to the other player. This will allow you to communicate your obvious superiority in the form of the text ""GGEZ"" or similar contractions to demonstrate just how awesome you are at this game" & Environment.NewLine &
        "It is strongly recommended you do not exit the application forcefully (via TaskManager or otherwise) as this can result in a bad experience for other players. Exiting the application normally, however, is fine." & Environment.NewLine &
        "On a scale of 1 to 10, 99.6% of people agree that positive concentration gradients are positive."

    Dim OtherHelpText As String = "OTHER STUFF" & Environment.NewLine &
        "THEMES!" & Environment.NewLine &
        "-> Unlike T3, this game actually implements themes in a pretty manner. Use the main menu to change them" & Environment.NewLine &
        "--> Available themes include:" & Environment.NewLine &
        "--- Basic, Blueberry, Monochroma, Peach and Stone" & Environment.NewLine &
        "Player Selection" & Environment.NewLine &
        "Use the main menu in offline mode to select who goes first. It's not as hard as you may think" & Environment.NewLine &
        "In online play, the first player is selected randomly"

    Private Sub UpdateHelpText() Handles CbbxSelector.SelectedIndexChanged
        If CbbxSelector.SelectedIndex = 0 Then
            TxtHelp.Text = SinglePlayerHelpText
        ElseIf CbbxSelector.SelectedIndex = 1 Then
            TxtHelp.Text = MultiplayerHelpText
        Else
            TxtHelp.Text = OtherHelpText
        End If
    End Sub

End Class