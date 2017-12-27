using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Connect4
{
    public partial class GameForm : Form
    {
        private Graphics gfx;
        private Pen p;

        private GameLogic gameLogic;

        private int mouseX, mouseY;

        public bool localTurn;

        public GameForm()
        {
            InitializeComponent();

            gfx = pnlGraphics.CreateGraphics();
            p = new Pen(Color.Black);

            localTurn = true; // Debug
        }

        public void drawGameState()
        {
            drawBoardOutlines();
            drawProvisionalPlacement();
        }

        /// <summary>
        /// Draws the black hash tag style background
        /// </summary>
        private void drawBoardOutlines()
        {
            for (int i = 1; i < 6; i++)
            {
                gfx.DrawLine(p, new Point(0, i * 125), new Point(881, i * 125)); // Draw 5 horizontals
            }

            for (int i = 1; i < 7; i++)
            {
                gfx.DrawLine(p, new Point(i * 125, 0), new Point(i * 125, 756)); // Draw 6 verticals
            }
        }

        /// <summary>
        /// draw provisional placement of the next chip
        /// </summary>
        private void drawProvisionalPlacement()
        {
            if (localTurn)
            {

            }
        }

        /// <summary>
        /// Draw all the board pieces
        /// </summary>
        private void drawGamePieces()
        {
            int[,] gameBoard = gameLogic.getGameBoard();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            drawBoardOutlines();
        }

        private void btnAbandon_Click(object sender, EventArgs e)
        {
            drawBoardOutlines();
        }

        private void pnlGraphics_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
