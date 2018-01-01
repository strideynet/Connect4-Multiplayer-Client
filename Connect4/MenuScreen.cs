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
    public partial class MenuScreen : Form {
        public MenuScreen() {
            InitializeComponent();
        }

        private void btnMatchmake_Click(object sender, EventArgs e) {
            MultiplayerConnection multiplayerConnection = new MultiplayerConnection("ws://86.138.91.20:80", txtUsername.Text, this);
        }
    }
}
