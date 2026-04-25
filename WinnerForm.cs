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
    public partial class WinnerForm : Form
    {
        public WinnerForm(string name)
        {
            InitializeComponent();
            lblWinner.Text = "Победил: " + name;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            MainMenuForm f = new MainMenuForm();
            f.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Вы точно хотите выйти?",
        "Выход",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void WinnerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
