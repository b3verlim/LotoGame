using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoGame
{
    public partial class PlayersForm : Form
    {
        public PlayersForm()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            int count = (int)numPlayers.Value;

            GameForm game = new GameForm(count);
            game.Show();
            this.Hide();
        }
    }
}
