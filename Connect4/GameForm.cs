using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Connect4 {
    public partial class GameForm : Form {
        private Graphics gfx;
        private Pen p;

        private GameLogic gameLogic;

        private Point screenPosition = new Point();
        private Point gamePosition = new Point();

        public GameForm(GameLogic gameLogic) {
            InitializeComponent();

            gfx = pnlGraphics.CreateGraphics();
            p = new Pen(Color.Black);

            this.gameLogic = gameLogic;
        }

        /// <summary>
        /// Draws the game state from the logic to the UI
        /// </summary>
        public void drawGameState() {
            pnlGraphics.Refresh();

            drawBoardOutlines();
            drawProvisionalPlacement();
            drawGamePieces();
        }

        /// <summary>
        /// Draws the black hash tag style background
        /// </summary>
        private void drawBoardOutlines() {
            for (int i = 1; i < 6; i++) {
                gfx.DrawLine(p, new Point(0, i * 125), new Point(881, i * 125)); // Draw 5 horizontals
            }

            for (int i = 1; i < 7; i++) {
                gfx.DrawLine(p, new Point(i * 125, 0), new Point(i * 125, 756)); // Draw 6 verticals
            }
        }

        /// <summary>
        /// Draw provisional placement of the next chip
        /// </summary>
        private void drawProvisionalPlacement() {
            if (gameLogic.localTurn) {
                int gamePositionX = resolveMousePosition().X;

                int yFree = gameLogic.getFreeInColumn(gamePositionX);

                drawCircle(new Rectangle(gamePositionX * 125 + 5, yFree * 125 + 5, 115, 115), Color.Blue, false);
            }
        }

        /// <summary>
        /// Draws a circle
        /// </summary>
        /// <param name="color">Color type</param>
        /// <param name="filled">true for a filled circe</param>
        private void drawCircle(Rectangle position, Color color, bool filled) {
            if (filled){
                SolidBrush brush = new SolidBrush(color);
                gfx.FillEllipse(brush, position);
            } else {
                gfx.DrawEllipse(new Pen(color), position);
            }
        }

        /// <summary>
        /// Draw all the board pieces
        /// </summary>
        private void drawGamePieces() {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (gameLogic.gameBoard[x, y] == gameLogic.localPlayer)
                    {
                        drawCircle(new Rectangle(x * 125 + 5, y * 125 + 5, 115, 115), Color.Blue, true);
                    } else if (gameLogic.gameBoard[x, y] != 0)
                    {
                        drawCircle(new Rectangle(x * 125 + 5, y * 125 + 5, 115, 115), Color.Red, true);
                    }
                }
            }
        }

        /// <summary>
        /// Calculates game board position of mouse screen position
        /// </summary>
        /// <returns>Position of game position</returns>
        private Point resolveMousePosition() {
            gamePosition.X = screenPosition.X / 126;
            gamePosition.Y = screenPosition.Y / 126;

            return gamePosition;
        }

        private void btnAbandon_Click(object sender, EventArgs e) {
            gameLogic.multiplayerConnection.endSession();
        }

        private void pnlGraphics_MouseDown(object sender, MouseEventArgs e) {
            gameLogic.columnClick(resolveMousePosition().X);
        }


        private void pnlGraphics_MouseMove(object sender, MouseEventArgs e) {
            screenPosition.X = e.X;
            screenPosition.Y = e.Y;

            int oldX = gamePosition.X;

            resolveMousePosition();

            if (gamePosition.X != oldX)
            {
                drawGameState();
            }
        }

        public void receiveMessage(string username, string message)
        {
            txtMessageLog.AppendText("\n" + username + ": " + message);
        }

        private void txtPendingMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitChat_Click(object sender, EventArgs e)
        {
            if (txtPendingMessage.Text != "") {
                gameLogic.multiplayerConnection.sendMessage(txtPendingMessage.Text);
                txtPendingMessage.Text = "";
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameLogic.multiplayerConnection.endSession();
        }

        /// <summary>
        /// Updates the labels from data in gameLogic
        /// </summary>
        public void updateLabels()
        {
            lblTurn.Text = gameLogic.localTurn.ToString();
            lblUsername.Text = gameLogic.localPlayer.ToString();
        }
    }
}
