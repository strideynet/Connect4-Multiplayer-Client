using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;

namespace Connect4
{
    class MultiplayerConnection
    {
        private ClientWebSocket clientWebSocket;
        const string userAgent = "NStride C4 v1";

        public Uri serverUrl;

        private GameLogic gameLogic;

        public MultiplayerConnection(string url) {
            clientWebSocket = new ClientWebSocket();

            serverUrl = new Uri(url); // Cast the string to the URL datatype

            connect();
        }

        async public Task connect() {
            await clientWebSocket.ConnectAsync(serverUrl, System.Threading.CancellationToken.None); // Initiates connection
            await send("boobies");
        }

        async public Task send(string toSend) {
            byte[] buffer = Encoding.UTF8.GetBytes(toSend);

            await clientWebSocket.SendAsync(new ArraySegment<Byte>(buffer), WebSocketMessageType.Text, false, System.Threading.CancellationToken.None);
        }
    }
}
