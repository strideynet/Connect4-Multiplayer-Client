using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class GameLogic
    {
        private int[,] gameBoard = new int[7, 6];

        private int localPlayer;

        private MultiplayerConnection multiplayerConnection;

        public GameLogic(MultiplayerConnection multiplayerConnection, int localPlayer)
        {
            this.multiplayerConnection = multiplayerConnection;
            this.localPlayer = localPlayer;
        }

        /// <summary>
        /// Attempts to place a piece in a column. Passes onto MultiplayerConnection
        /// </summary>
        /// <param name="column">which X position to place in</param>
        public void columnClick(int column)
        {
 
        }

        public int getFreeInColumn(int column)
        {
            // Loop through the rows to find the next avail slot
            for (int y = 5; y >= 0; y--)
            {
                if (gameBoard[column, y] == 0)
                {
                    return y;
                }
            }

            return -1;
        }

        /// <summary>
        /// Applies server state to client state. Executed by MultiplayerConnection
        /// </summary>
        /// <param name="suggestedGameBoard">gameBoard from the server</param>
        public void setGameBoard(int[,] suggestedGameBoard)
        {

        }

        /// <summary>
        /// gets Game State for drawing
        /// </summary>
        /// <returns>game board array</returns>
        public int[,] getGameBoard()
        {
            return gameBoard;
        }

        /// <summary>
        /// gets integer value of local player
        /// </summary>
        /// <returns>integer value of local player</returns>
        public int getLocalPlayer()
        {
            return localPlayer;
        }

    }
}
