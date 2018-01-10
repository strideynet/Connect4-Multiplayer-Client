Class OfflineGameDetails

    Dim FirstPlayer As Boolean ' Red (True) or Blue (False)
    Public PlayerTurn As Boolean
    Public Board(6, 5) As Integer

    Public P1Name As String = "Player 1"
    Public P2Name As String = "Player 2"

    Public P1Colour As Color
    Public P1Brush As Brush
    Public P2Colour As Color
    Public P2Brush As Brush
    Public GridPen As Pen
    Public EllipsePen As Pen

    Dim TurnNumber As Integer = 0

    ''' <summary>
    ''' Provides a constructor for use without colour choices
    ''' </summary>
    ''' <param name="First">The first player (True for P1, False for P2)</param>
    Public Sub New(ByVal First As Boolean)
        ReDim Board(6, 5)
        FirstPlayer = First
        PlayerTurn = First
        P1Colour = My.Settings.P1Colour
        P1Brush = New SolidBrush(P1Colour)
        P2Colour = My.Settings.P2Colour
        P2Brush = New SolidBrush(P2Colour)
        GridPen = New Pen(My.Settings.GridColour, 3)
        EllipsePen = New Pen(My.Settings.GridColour, 1)
    End Sub

    Public Sub UpdateTheme()
        P1Colour = My.Settings.P1Colour
        P1Brush = New SolidBrush(P1Colour)
        P2Colour = My.Settings.P2Colour
        P2Brush = New SolidBrush(P2Colour)
        GridPen = New Pen(My.Settings.GridColour, 3)
        EllipsePen = New Pen(My.Settings.GridColour, 1)
    End Sub

End Class