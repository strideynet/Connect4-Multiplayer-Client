using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    public class GameLogic
    {
        public int[,] gameBoard = new int[7, 6];

        public int localPlayer;

        private bool _localTurn;
        public bool localTurn
        {
            get
            {
                return _localTurn;
            }
            set
            {
                _localTurn = value;
                gameForm.updateLabels();
            }
        }

        public MultiplayerConnection multiplayerConnection;
        public GameForm gameForm;

        public GameLogic(MultiplayerConnection multiplayerConnection, int localPlayer)
        {
            this.multiplayerConnection = multiplayerConnection;
            this.localPlayer = localPlayer;

            gameForm = new GameForm(this);
            gameForm.Show();
        }

        /// <summary>
        /// Attempts to place a piece in a column. Passes onto MultiplayerConnection
        /// </summary>
        /// <param name="column">which X position to place in</param>
        public void columnClick(int column)
        {
            if (this.localTurn)
            {
                int row = getFreeInColumn(column);
                if (row != -1)
                {
                    gameBoard[column, row] = localPlayer; // Predicting success.
                    multiplayerConnection.columnClick(column);
                    gameForm.drawGameState();
                }
            }

        }

        public int getFreeInColumn(int column)
        {
            if (column < 7)
            {
                // Loop through the rows to find the next avail slot
                for (int y = 5; y >= 0; y--)
                {
                    if (gameBoard[column, y] == 0)
                    {
                        return y;
                    }
                }
            }

            return -1;
        }
    }
}
