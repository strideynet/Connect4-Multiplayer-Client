Imports Newtonsoft
Class MPlayerConnection

    Private WithEvents MyClientWebSocket As WebSocketSharp.WebSocket
    Private JWT As String
    Public ControlForm As Object

    Public Sub New(URL As String, Username As String, Optional ByVal ReferenceForm As FrmGamePeruser = Nothing)
        AddHandler Application.ApplicationExit, AddressOf OnApplicationExit

        ControlForm = ReferenceForm

        MyClientWebSocket = New WebSocketSharp.WebSocket(URL)
        MyClientWebSocket.Connect()
        If MyClientWebSocket.ReadyState <> WebSocketSharp.WebSocketState.Open Then
            MyClientWebSocket.Close()
            FrmGamePeruser.UpdateStatus("Server is down", True, Color.Firebrick)
            Exit Sub
        End If
        MyClientWebSocket.Send(Json.JsonConvert.SerializeObject(New C4.MSGTypes.Registration(Username)))
    End Sub

    Private Delegate Sub MessageHandlerDelegate(sender As Object, E As WebSocketSharp.MessageEventArgs)
    Private Sub MessageHandler(sender As Object, E As WebSocketSharp.MessageEventArgs) Handles MyClientWebSocket.OnMessage
        If ControlForm.InvokeRequired = True Then
            Debug.WriteLine("MessageHandler got invoked!")
            ControlForm.BeginInvoke(New MessageHandlerDelegate(AddressOf MessageHandler), New Object() {sender, E})
        Else
            Dim MSG As Json.Linq.JObject = Json.Linq.JObject.Parse(E.Data)
            Debug.WriteLine(MSG.ToString())
            If CStr(MSG("type")) = "RegistrationReturn" Then
                Debug.WriteLine("RegistrationReturn Message!")
                RegistrationReturnHandler(MSG)
            ElseIf CStr(MSG("type")) = "MatchRequestReturn" Then
                Debug.WriteLine("MatchRequestReturn Message!")
                MatchRequestReturnHandler(MSG)
            ElseIf CStr(MSG("type")) = "MatchUpdate" Then
                Debug.WriteLine("MatchUpdate Message!")
                MatchUpdateHandler(MSG)
            ElseIf CStr(MSG("type")) = "ChatMessageReturn" Then
                Debug.WriteLine("ChatReceived Message!")
                ChatReceivedHandler(MSG)
            ElseIf CStr(MSG("type")) = "MatchEnd" Then
                Debug.WriteLine("MatchEnd Message!")
                EndMatchHandler(MSG)
            End If

        End If

    End Sub

    Public Sub CloseConnection()
        MyClientWebSocket.Close()
        FrmGamePeruser.UpdateStatus("Connection closed", False, Color.FromKnownColor(KnownColor.Control))
    End Sub

#Region "MSG return handlers"

    Private Sub RegistrationReturnHandler(MSG As Object)
        'If ControlForm.InvokeRequired = True Then
        '    Debug.WriteLine("Registration return handler got invoked!")
        '    ControlForm.BeginInvoke(New GenericDelegate(AddressOf RegistrationReturnHandler), New Object() {MSG})
        'Else
        JWT = MSG("data")("jwt")
            Debug.WriteLine("Registered!")
            FrmGamePeruser.UpdateStatus("MatchMaking requested", False, Color.LightBlue)
            Dim Reply = New C4.MSGTypes.MatchRequest(JWT) ' Request matchmaking
            MyClientWebSocket.Send(Json.JsonConvert.SerializeObject(Reply))
        'End If
    End Sub

    Private Delegate Sub GenericDelegate(ByVal MSG As Object)

    Private Sub MatchRequestReturnHandler(ByVal MSG As Object)
        'If ControlForm.InvokeRequired = True Then
        'Debug.WriteLine("Match request return handler got invoked!")
        'FrmGamePeruser.BeginInvoke(New GenericDelegate(AddressOf MatchRequestReturnHandler), New Object() {MSG})
        'Else
        FrmGamePeruser.StartGame(MSG)
        'End If
    End Sub

    Private Sub MatchUpdateHandler(MSG As Object)

        If ControlForm.InvokeRequired = True Then
            Debug.WriteLine("Match update handler got invoked!")
            ControlForm.BeginInvoke(New GenericDelegate(AddressOf MatchUpdateHandler), New Object() {MSG})
        Else
            Debug.WriteLine("Invoke complete")
            FrmMPlayerGame.ReceiveTurn(MSG)
        End If

    End Sub

    Private Sub ChatReceivedHandler(MSG As Object)
        If ControlForm.InvokeRequired = True Then
            Debug.WriteLine("Chat receiver handler got invoked!")
            ControlForm.BeginInvoke(New GenericDelegate(AddressOf ChatReceivedHandler), New Object() {MSG})
        Else
            Debug.WriteLine("Chat received")
            FrmMPlayerGame.ReceiveChat(MSG)
        End If
    End Sub

    Private Sub EndMatchHandler(MSG As Object)
        If ControlForm.InvokeRequired = True Then
            Debug.WriteLine("Match end handler got invoked")
            ControlForm.BeginInvoke(New GenericDelegate(AddressOf EndMatchHandler), New Object() {MSG})
        Else
            If CStr(MSG("data")("type")) = "1" Then
                FrmMPlayerGame.EndGameByWin(MSG)
            Else
                FrmMPlayerGame.EndGameBySubmit(MSG)
            End If
        End If
    End Sub

#End Region

#Region "Send Commands To Server"

    Public Sub ColumnClick(Column As Integer)
        Dim MSG As New C4.MSGTypes.PlayPosition(Me.JWT, Column)
        MyClientWebSocket.Send(Json.JsonConvert.SerializeObject(MSG))
    End Sub

    Public Sub InformConnectionEnd()
        ' do this
    End Sub

    Public Sub SendChat(ByVal ChatMSG As String)

        Dim MSGToSend As New C4.MSGTypes.ChatMessage(Me.JWT, ChatMSG)
        MyClientWebSocket.Send(Json.JsonConvert.SerializeObject(MSGToSend))

    End Sub

#End Region

    Private Sub OnApplicationExit()

        ' inform the server about stuff then exit
        If MyClientWebSocket.ReadyState <> WebSocketSharp.WebSocketState.Closed Then
            InformConnectionEnd()

            ExternalVars.Connection.CloseConnection()
        End If



    End Sub

    Private Sub OnConnectionClose() Handles MyClientWebSocket.OnClose
        Debug.WriteLine("Connection Closed")
    End Sub

    Public Sub UpdateReferenceForm(NewForm As Object)
        ControlForm = NewForm
    End Sub

End Class
