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

        public bool localTurn;

        public GameForm() {
            InitializeComponent();

            gfx = pnlGraphics.CreateGraphics();
            p = new Pen(Color.Black);

            gameLogic = new GameLogic(new MultiplayerConnection("http://127.0.0.1:80/matchmaking"), 5);

            localTurn = true; // Debug
        }

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
            if (localTurn) {
                int[,] gameBoard = gameLogic.getGameBoard();
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
            int[,] gameBoard = gameLogic.getGameBoard();
        }

        /// <summary>
        /// Calculates game board position of mouse screen position
        /// </summary>
        /// <returns>Position of game position</returns>
        private Point resolveMousePosition() {
            Point gamePosition = new Point();

            gamePosition.X = screenPosition.X / 126;
            gamePosition.Y = screenPosition.Y / 126;

            return gamePosition;
        }

        private void label3_Click(object sender, EventArgs e) {
        }

        private void btnAbandon_Click(object sender, EventArgs e) {
        }

        private void pnlGraphics_MouseDown(object sender, MouseEventArgs e) {
        }

        private void pnlGraphics_MouseMove(object sender, MouseEventArgs e) {
            screenPosition.X = e.X;
            screenPosition.Y = e.Y;

            drawGameState();
        }
    }
}
