Namespace C4.MSGTypes

#Region "Primary Inheritables"

    MustInherit Class MessageShell
        Public ReadOnly Property type As String
            Get
                Return Me.GetType().Name
            End Get
        End Property

        Public agent As String = "LWM C4"

        Public Structure DataStructure : End Structure
        Public data As DataStructure
    End Class

    MustInherit Class AuthenticatedMessageShell : Inherits MessageShell
        Public jwt As String
        Public Sub New(jwt As String)
            Me.jwt = jwt
        End Sub
    End Class

#End Region

    Class C4Pong : Inherits AuthenticatedMessageShell
        Public Shadows data As DataStructure

        Public Sub New(JWT As String)
            MyBase.New(JWT)
        End Sub

    End Class

    Class Registration : Inherits MessageShell

        Public Shadows Structure DataStructure
            Public username As String
        End Structure
        Public Shadows data As DataStructure

        Public Sub New(Username As String)
            Me.data.username = Username
        End Sub
    End Class

    Class MatchRequest : Inherits AuthenticatedMessageShell
        Public Shadows Structure DataStructure : End Structure
        Public Shadows data As DataStructure

        Public Sub New(jwt As String)
            MyBase.New(jwt)
        End Sub
    End Class

    Class ChatMessage : Inherits AuthenticatedMessageShell
        Public Shadows Structure DataStructure
            Public message As String
        End Structure
        Public Shadows data As DataStructure

        Public Sub New(jwt As String, ChatMSG As String)
            MyBase.New(jwt)
            Me.data.message = ChatMSG
        End Sub
    End Class

    Class PlayPosition : Inherits AuthenticatedMessageShell

        Public Shadows Structure DataStructure
            Public column As Integer
        End Structure
        Public Shadows data As DataStructure

        Public Sub New(jwt As String, column As Integer)
            MyBase.New(jwt)
            Me.data.column = column
        End Sub
    End Class

End Namespace