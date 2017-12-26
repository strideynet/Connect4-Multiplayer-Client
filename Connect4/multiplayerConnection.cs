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
        public Uri serverUrl;

        private GameLogic gameLogic;

        public MultiplayerConnection(string url)
        {
            clientWebSocket = new ClientWebSocket();

            serverUrl = new Uri(url); // Cast the string to the URL datatype
        }

        async public void Connect() => await clientWebSocket.ConnectAsync(serverUrl, System.Threading.CancellationToken.None); // Initiates connection
    }
}
