﻿using Newtonsoft.Json;
using System;
using WebSocketSharp;

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
            } else if (message.type == "ChatMessageReturn") {
                ChatMessageHandler(message);
            } else if (message.type == "MatchEnd") {
                MatchEndHandler(message);
            } else if (message.type == "C4Ping")
            {
                C4PingHandler(message);
            }
        }

        #region Message Handlers

        private void RegistrationReturnHandler(dynamic message)
        {
            jwt = message.data.jwt;

            var reply = new MessageTypes.MatchRequest(jwt); //Now we are registered, apply for match
            clientWebSocket.Send(JsonConvert.SerializeObject(reply));
        }

        private void C4PingHandler(dynamic message)
        {
            var reply = new MessageTypes.C4Pong(this.jwt);
            clientWebSocket.Send(JsonConvert.SerializeObject(reply));
        }

        /* 
         * The following is an example of thread traversal. The networking is occuring in a side thread and thus the MatchRequestHandler is in that thread to start with
         * This will cause all sorts of trouble if you try to create a new form. So instead we ask the menuScreen to nicely run the function again in its thread
         * The MatchRequestReturnDelegate sets out the format of the parameters, so that it can be invoked in a statically typed system.
         *  Finally once the function is ran again on the main UI thread, the else statement will be selected.
         */
        private delegate void GenericDelegate(dynamic message); //Delegate for cross thread work

        private void MatchRequestReturnHandler(dynamic message)
        {
            if (menuScreen.InvokeRequired) //Checks if we are on different thread from the menuScreen UI:
            {
                menuScreen.BeginInvoke(new GenericDelegate(MatchRequestReturnHandler), new object[] { message }); //Force the control to invoke this function on its thread
            } else { //Once we are in the UI thread do the following:
                gameLogic = new GameLogic(this, (int)message.data.localNum);
                gameLogic.localTurn = (gameLogic.localPlayer == (int)message.data.currentPlayer);
            }
        }

        private void MatchUpdateHandler(dynamic message) {
            if (menuScreen.InvokeRequired) //Checks if we are on different thread from the menuScreen UI:
            {
                menuScreen.BeginInvoke(new GenericDelegate(MatchUpdateHandler), new object[] { message }); //Force the control to invoke this function on its thread
            } else
            {
                for (int x = 0; x < 7; x++)
                {
                    for (int y = 0; y < 6; y++)
                    {
                        gameLogic.gameBoard[x, y] = message.data.board[x][y];
                    }
                }
                gameLogic.localTurn = (gameLogic.localPlayer == (int)message.data.currentPlayer);
                gameLogic.gameForm.drawGameState();
            }
        }

        private void ChatMessageHandler(dynamic message)
        {
            if (menuScreen.InvokeRequired) //Checks if we are on different thread from the menuScreen UI:
            {
                menuScreen.BeginInvoke(new GenericDelegate(ChatMessageHandler), new object[] { message }); //Force the control to invoke this function on its thread
            }
            else
            {
                gameLogic.gameForm.receiveMessage((string)message.data.sender, (string)message.data.message);
            }
        }

        private void MatchEndHandler(dynamic message)
        {
            if (menuScreen.InvokeRequired) //Checks if we are on different thread from the menuScreen UI:
            {
                menuScreen.BeginInvoke(new GenericDelegate(MatchEndHandler), new object[] { message }); //Force the control to invoke this function on its thread
            }
            else
            {
                gameLogic.localTurn = false; // Prevents further plays

                System.Windows.Forms.MessageBox.Show("Game Ends...");

                string winner = ((int)message.data.winner == gameLogic.localPlayer ? "You" : "They");
                System.Windows.Forms.MessageBox.Show(winner + " win the game!");

                gameLogic.gameForm.Close();
            }
        }

        #endregion

        #region Remote Commands

        public void columnClick(int column )
        {
            var message = new MessageTypes.PlayPosition(this.jwt, column);
            clientWebSocket.Send(JsonConvert.SerializeObject(message));
        }

        public void sendMessage(string messageContent)
        {
            var message = new MessageTypes.ChatMessage(this.jwt, messageContent);
            clientWebSocket.Send(JsonConvert.SerializeObject(message));
        }

        public void endSession() // Shuts down session at end of match
        {
            clientWebSocket.Close();
            gameLogic = null;
        }

        #endregion
    }
}
