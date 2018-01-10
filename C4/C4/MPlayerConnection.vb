Imports Newtonsoft
Class MPlayerConnection

    Private WithEvents MyClientWebSocket As WebSocketSharp.WebSocket
    Private JWT As String

    Public Sub New(URL As String, Username As String)
        MyClientWebSocket = New WebSocketSharp.WebSocket(URL)
        MyClientWebSocket.Connect()
        If MyClientWebSocket.ReadyState <> WebSocketSharp.WebSocketState.Open Then
            MyClientWebSocket.Close()
            FrmGamePeruser.UpdateStatus("Server is down", True, Color.Firebrick)
            Exit Sub
        End If
        MyClientWebSocket.Send(Json.JsonConvert.SerializeObject(New C4.MSGTypes.Registration(Username)))
    End Sub

    Private Sub MessageHandler(sender As Object, E As WebSocketSharp.MessageEventArgs) Handles MyClientWebSocket.OnMessage

        Dim MSG As Json.Linq.JObject = Json.Linq.JObject.Parse(E.Data)

        If CStr(MSG("type")) = "RegistrationReturn" Then
            Debug.WriteLine("Registration Return Message")
            RegistrationReturnHandler(MSG)
        ElseIf CStr(MSG("type")) = "MatchRequestReturn" Then
            Debug.WriteLine("Match Request Return Return Message")
            MatchRequestReturnHandler(MSG)
        ElseIf CStr(MSG("type")) = "MatchUpdate" Then
            Debug.WriteLine("Match Update Message")
            MatchUpdateHandler(MSG)
        End If

    End Sub

    Public Sub CloseConnection()
        MyClientWebSocket.Close()
        FrmGamePeruser.UpdateStatus("Connection closed", False, Color.FromKnownColor(KnownColor.Control))
    End Sub

#Region "MSG return handlers"

    Private Sub RegistrationReturnHandler(MSG As Object)
        If FrmGamePeruser.InvokeRequired() Then
            FrmGamePeruser.BeginInvoke(New GenericDelegate(AddressOf RegistrationReturnHandler), New Object() {MSG})
        Else
            JWT = MSG("data")("jwt")
            Debug.WriteLine("Registered")
            FrmGamePeruser.UpdateStatus("MatchMaking requested", False, Color.LightBlue)
            Dim Reply = New C4.MSGTypes.MatchRequest(JWT) ' Request matchmaking
            MyClientWebSocket.Send(Json.JsonConvert.SerializeObject(Reply))
        End If
    End Sub

    Private Delegate Sub GenericDelegate(ByVal MSG As Object)

    Private Sub MatchRequestReturnHandler(ByVal MSG As Object)
        If FrmGamePeruser.InvokeRequired() Then
            FrmGamePeruser.BeginInvoke(New GenericDelegate(AddressOf MatchRequestReturnHandler), New Object() {MSG})
        Else
            FrmGamePeruser.StartGame(MSG)
        End If
    End Sub

    Private Sub MatchUpdateHandler(MSG As Object)

        If FrmMPlayerGame.InvokeRequired() Then
            FrmMPlayerGame.BeginInvoke(New GenericDelegate(AddressOf MatchRequestReturnHandler), New Object() {MSG})
        Else
            FrmMPlayerGame.ReceiveTurn(MSG)
        End If

    End Sub

#End Region

#Region "Send Commands To Server"

    Public Sub ColumnClick(Column As Integer)
        Dim MSG As New C4.MSGTypes.PlayPosition(Me.JWT, Column)
        MyClientWebSocket.Send(Json.JsonConvert.SerializeObject(MSG))
    End Sub

    Public Sub InformConnectionEnd(Optional Reason As String = "")
        ' do this
    End Sub

#End Region
End Class
