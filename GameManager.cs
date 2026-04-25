using System.Collections.Generic;

namespace LotoGame
{
    public class GameManager
    {
        public List<Player> Players { get; set; }
        public List<int> DrawnNumbers { get; set; }

        private BarrelBag bag;

        public GameManager(int playerCount)
        {
            Players = new List<Player>();
            DrawnNumbers = new List<int>();
            bag = new BarrelBag();

            for (int i = 1; i <= playerCount; i++)
            {
                Players.Add(new Player("Игрок " + i));
            }
        }

        public int NextNumber()
        {
            int number = bag.GetNext();
            DrawnNumbers.Add(number);
            return number;
        }

        public List<Player> CheckWinners()
        {
            List<Player> winners = new List<Player>();

            foreach (Player player in Players)
            {
                if (player.IsWinner())
                    winners.Add(player);
            }

            return winners;
        }
    }
}