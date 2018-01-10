Module Themes
    Private Class Blueberry
        Public ReadOnly Property BoardColour
            Get
                Return Color.FromArgb(119, 188, 209)
            End Get
        End Property
        Public ReadOnly Property P1Colour
            Get
                Return Color.FromArgb(213, 225, 239)
            End Get
        End Property
        Public ReadOnly Property P2Colour
            Get
                Return Color.FromArgb(34, 42, 63)
            End Get
        End Property
        Public ReadOnly Property GridColour
            Get
                Return Color.FromArgb(87, 124, 135)
            End Get
        End Property
    End Class

    Private Class Peach
        Public ReadOnly Property BoardColour
            Get
                Return Color.FromArgb(226, 231, 211)
            End Get
        End Property
        Public ReadOnly Property P1Colour
            Get
                Return Color.FromArgb(243, 106, 70)
            End Get
        End Property
        Public ReadOnly Property P2Colour
            Get
                Return Color.FromArgb(167, 169, 145)
            End Get
        End Property
        Public ReadOnly Property GridColour
            Get
                Return Color.FromArgb(205, 194, 176)
            End Get
        End Property
    End Class

    Private Class Stone
        Public ReadOnly Property BoardColour
            Get
                Return Color.FromArgb(145, 137, 137)
            End Get
        End Property
        Public ReadOnly Property P1Colour
            Get
                Return Color.FromArgb(84, 51, 26)
            End Get
        End Property
        Public ReadOnly Property P2Colour
            Get
                Return Color.FromArgb(232, 212, 200)
            End Get
        End Property
        Public ReadOnly Property GridColour
            Get
                Return Color.FromArgb(43, 26, 11)
            End Get
        End Property
    End Class

    Private Class Basic
        Public ReadOnly Property BoardColour
            Get
                Return Color.FromKnownColor(KnownColor.InactiveCaption)
            End Get
        End Property
        Public ReadOnly Property P1Colour
            Get
                Return Color.LightCoral
            End Get
        End Property
        Public ReadOnly Property P2Colour
            Get
                Return Color.DarkCyan
            End Get
        End Property
        Public ReadOnly Property GridColour
            Get
                Return Color.DarkSlateGray
            End Get
        End Property
    End Class

    Private Class Monochroma
        Public ReadOnly Property BoardColour
            Get
                Return Color.DarkGray
            End Get
        End Property
        Public ReadOnly Property P1Colour
            Get
                Return Color.White
            End Get
        End Property
        Public ReadOnly Property P2Colour
            Get
                Return Color.Black
            End Get
        End Property
        Public ReadOnly Property GridColour
            Get
                Return Color.Gray
            End Get
        End Property
    End Class


    Public Sub ChangeTheme(NewTheme As String, Optional Game As OfflineGameDetails = Nothing, Optional OnlineGame As OnlineGame = Nothing)
        NewTheme = NewTheme.ToUpper

        Dim Themeset As Object

        Select Case NewTheme

            Case "PEACH"
                Themeset = New Peach

            Case "BLUEBERRY"
                Themeset = New Blueberry

            Case "STONE"
                Themeset = New Stone

            Case "MONOCHROMA"
                Themeset = New Monochroma

            Case Else
                Themeset = New Basic

        End Select

        My.Settings.BoardColour = ThemeSet.BoardColour
        My.Settings.P1Colour = ThemeSet.P1Colour
        My.Settings.P2Colour = ThemeSet.P2Colour
        My.Settings.GridColour = ThemeSet.GridColour

        My.Settings.CurrentTheme = NewTheme
        If Game IsNot Nothing Then Game.UpdateTheme()
        If OnlineGame IsNot Nothing Then OnlineGame.UpdateTheme()

    End Sub

End Module
