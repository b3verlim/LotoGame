using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LotoGame
{
    public partial class GameForm : Form
    {
        private GameManager game;
        private Dictionary<Player, DataGridView> playerCards;

        public GameForm(int count)
        {
            InitializeComponent();

            game = new GameManager(count);
            playerCards = new Dictionary<Player, DataGridView>();

            CreateCards();
            DrawCards();
        }
        private void lblInfo_Click(object sender, EventArgs e)
        {
        }

        private void CreateCards()
        {
            flowCards.Controls.Clear();
            playerCards.Clear();

            foreach (Player player in game.Players)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Text = player.Name;
                groupBox.Width = 520;
                groupBox.Height = 180;

                DataGridView grid = new DataGridView();
                grid.Width = 470;
                grid.Height = 100;
                grid.Left = 15;
                grid.Top = 30;

                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.AllowUserToResizeColumns = false;
                grid.AllowUserToResizeRows = false;
                grid.ReadOnly = true;
                grid.RowHeadersVisible = false;
                grid.ColumnHeadersVisible = false;
                grid.ScrollBars = ScrollBars.None;
                grid.MultiSelect = false;

                grid.Columns.Clear();

                for (int i = 0; i < 9; i++)
                {
                    grid.Columns.Add("col" + i, "");
                    grid.Columns[i].Width = 48;
                }

                grid.Rows.Add(3);

                for (int i = 0; i < 3; i++)
                {
                    grid.Rows[i].Height = 28;
                }

                groupBox.Controls.Add(grid);
                flowCards.Controls.Add(groupBox);

                playerCards[player] = grid;
            }
        }

        private void DrawCards()
        {
            foreach (Player player in game.Players)
            {
                DataGridView grid = playerCards[player];

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 9; col++)
                    {
                        DataGridViewCell cell = grid.Rows[row].Cells[col];

                        if (player.Card[row, col].HasValue)
                        {
                            int number = player.Card[row, col].Value;
                            cell.Value = number.ToString();

                            if (player.Marked[row, col])
                            {
                                cell.Style.BackColor = Color.LightGreen;
                            }
                            else
                            {
                                cell.Style.BackColor = Color.White;
                            }
                        }
                        else
                        {
                            cell.Value = "";
                            cell.Style.BackColor = Color.LightGray;
                        }
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int currentNumber;

            try
            {
                currentNumber = game.NextNumber();
            }
            catch
            {
                MessageBox.Show("Числа закончились");
                return;
            }

            lblInfo.Text = "Выпало число: " + currentNumber;
            txtStatus.Clear();
            txtStatus.AppendText("Выпало число: " + currentNumber + Environment.NewLine + Environment.NewLine);

            foreach (Player player in game.Players)
            {
                if (player.HasNumber(currentNumber))
                {
                    player.MarkNumber(currentNumber);
                    txtStatus.AppendText(player.Name + " — ЕСТЬ" + Environment.NewLine);
                }
                else
                {
                    txtStatus.AppendText(player.Name + " — НЕТ" + Environment.NewLine);
                }
            }

            DrawCards();

            foreach (Player player in game.Players)
            {
                if (player.IsWinner())
                {
                    WinnerForm win = new WinnerForm(player.Name);
                    win.Show();
                    this.Hide();
                    return;
                }
            }
        }
    }
}