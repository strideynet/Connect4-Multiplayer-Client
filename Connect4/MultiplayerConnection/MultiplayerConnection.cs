using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using Newtonsoft.Json;

namespace Connect4
{
    class MultiplayerConnection
    {
        private WebSocket clientWebSocket;

        private GameLogic gameLogic;

        public MultiplayerConnection(string url) {
            clientWebSocket = new WebSocket(url);
            clientWebSocket.OnMessage += messageHandler;
            clientWebSocket.Connect();

            clientWebSocket.Send(JsonConvert.SerializeObject(new MessageTypes.Registration("CYKALBK")));
        }

        private void messageHandler(object sender, MessageEventArgs e)
        {
            dynamic message = JsonConvert.DeserializeObject(e.Data);

            Console.WriteLine(e.Data);
            Console.WriteLine(message.info);
        }
    }
}
