Class OnlineGame

    Public Board(6, 5) As Integer
    Dim MeFirst As Boolean
    Public MyTurn As Boolean
    Public LocalNum As Integer

    Public P1Name As String = "Player 1"
    Public P2Name As String = "Player 2"

    Public P1Colour As Color
    Public P1Brush As Brush
    Public P2Colour As Color
    Public P2Brush As Brush
    Public GridPen As Pen
    Public EllipsePen As Pen

    Public Sub New(ByVal LocalNumber As Integer)
        ReDim Board(6, 5)
        If LocalNumber = 1 Then
            MeFirst = True
            LocalNum = 1
            P1Name = ExternalVars.LocalName
            P2Name = ExternalVars.OpponentName
        Else
            MeFirst = False
            LocalNum = 10
            P1Name = ExternalVars.OpponentName
            P2Name = ExternalVars.LocalName
        End If

        MyTurn = MeFirst



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
#Region "Logic"

    Public Sub PerformGravity()
        Dim ChangeMade As Boolean = True
        While ChangeMade = True
            ChangeMade = False
            For Column = 0 To 6
                For Row = 4 To 0 Step -1
                    If Board(Column, Row) <> 0 And Board(Column, Row + 1) = 0 Then
                        Board(Column, Row + 1) = Board(Column, Row)
                        'DebugState()
                        Board(Column, Row) = 0
                        'DebugState()
                        ChangeMade = True
                    End If
                Next
            Next
        End While
    End Sub

    Public Function CheckTop(ByVal Col As Integer) As Boolean
        If Board(Col, 0) = 0 Then Return False Else MsgBox("This column is obviously full. Please try another one", MsgBoxStyle.OkOnly, "FAILURE") : Return True
    End Function

    Public Sub DoInfinityAndBeyond()
        Dim EmptySpace As Boolean = False
        For Column = 0 To 6
            If Board(Column, 2) = 0 Then EmptySpace = True
        Next
        'Debug.WriteLine(CStr(EmptySpace))
        If EmptySpace = False Then
            ' Shift board by 1
            'MsgBox("INFINITYING")
            For Looper1 = 6 To 0 Step -1
                For Looper2 = 5 To 0 Step -1
                    If Looper2 = 5 Then
                        Board(Looper1, Looper2) = 0
                    Else
                        Board(Looper1, Looper2 + 1) = Board(Looper1, Looper2)
                        Board(Looper1, Looper2) = 0
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub DebugState()
        Debug.Write(" ___________________ " & Environment.NewLine & "| ")
        For Column = 0 To 6
            For Row = 1 To 5
                Debug.Write(Board(Column, Row) & " | ")
            Next
            Debug.Write(Environment.NewLine & "| ")
        Next
        Debug.WriteLine("__________________/" & Environment.NewLine)
    End Sub

    Public Sub MakeMove(Column As Integer)
        If MyTurn = True Then
            MyTurn = False

            Board(Column, 0) = LocalNum
            ExternalVars.Connection.ColumnClick(Column)

        Else
            MsgBox("Not your turn!", MsgBoxStyle.OkOnly, "C-4: Online Play")

        End If
    End Sub

#End Region



End Class
