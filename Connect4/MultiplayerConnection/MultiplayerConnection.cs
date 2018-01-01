using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using Newtonsoft.Json;

namespace Connect4
{
    public class MultiplayerConnection
    {
        private WebSocket clientWebSocket;

        private GameLogic gameLogic;
        private MenuScreen menuScreen;

        private string jwt;

        public MultiplayerConnection(string url, string username, MenuScreen menuScreen) {
            clientWebSocket = new WebSocket(url);
            clientWebSocket.OnMessage += messageHandler; //Add event handler for incoming WS messages
            clientWebSocket.Connect();

            this.menuScreen = menuScreen;

            clientWebSocket.Send(JsonConvert.SerializeObject(new MessageTypes.Registration(username)));
        }

        /// <summary>
        /// Handles all messages coming in and directs to message type handlers
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">MessageEventArgs</param>
        private void messageHandler(object sender, MessageEventArgs e) {
            dynamic message = JsonConvert.DeserializeObject(e.Data); // Dynamic as format is unknown.

            Console.WriteLine(e.Data);
            
            if (message.type == "RegistrationReturn") {
                RegistrationReturnHandler(message);
            } else if (message.type == "MatchRequestReturn") {
                MatchRequestReturnHandler(message);
            } else if (message.type == "MatchUpdate") {
                MatchUpdateHandler(message);
            }
        }

        #region Message Handlers

        private void RegistrationReturnHandler(dynamic message)
        {
            jwt = message.data.jwt;

            var reply = new MessageTypes.MatchRequest(jwt); //Now we are registered, apply for match
            clientWebSocket.Send(JsonConvert.SerializeObject(reply));
        }

        /* 
         * The following is an example of thread traversal. The networking is occuring in a side thread and thus the MatchRequestHandler is in that thread to start with
         * This will cause all sorts of trouble if you try to create a new form. So instead we ask the menuScreen to nicely run the function again in its thread
         * The MatchRequestReturnDelegate sets out the format of the parameters, so that it can be invoked in a statically typed system.
         *  Finally once the function is ran again on the main UI thread, the else statement will be selected.
         */
        private delegate void MatchRequestReturnDelegate(dynamic message); //Delegate for cross thread work

        private void MatchRequestReturnHandler(dynamic message)
        {
            if (menuScreen.InvokeRequired) //Checks if we are on different thread from the menuScreen UI:
            {
                menuScreen.BeginInvoke(new MatchRequestReturnDelegate(MatchRequestReturnHandler), new object[] { message }); //Force the control to invoke this function on its thread
            } else { //Once we are in the UI thread do the following:
                gameLogic = new GameLogic(this, (int)message.data.localNum);
            }
        }

        private void MatchUpdateHandler(dynamic message) {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    gameLogic.gameBoard[x, y] = message.data.board[x][y];
                }
            }
        }

        #endregion

        #region Remote Commands

        public void columnClick(int column )
        {
            var message = new MessageTypes.PlayPosition(this.jwt, column);
            clientWebSocket.Send(JsonConvert.SerializeObject(message));
        }

        #endregion
    }
}
