using System;
using System.Windows.Forms;

namespace LotoGame
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            PlayersForm f = new PlayersForm();
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

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}