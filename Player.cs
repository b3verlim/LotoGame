using System;
using System.Collections.Generic;
using System.Linq;

namespace LotoGame
{
    public class Player
    {
        public string Name { get; set; }

        // Карточка 3x9. null = пустая клетка
        public int?[,] Card { get; set; }

        // Отмеченные числа
        public bool[,] Marked { get; set; }

        private static Random rand = new Random();

        public Player(string name)
        {
            Name = name;
            Card = new int?[3, 9];
            Marked = new bool[3, 9];

            GenerateCard();
        }

        private void GenerateCard()
        {
            // Сначала очищаем карточку
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    Card[row, col] = null;
                    Marked[row, col] = false;
                }
            }

            // Для каждой строки выбираем 5 позиций из 9
            for (int row = 0; row < 3; row++)
            {
                List<int> positions = Enumerable.Range(0, 9)
                                                .OrderBy(x => rand.Next())
                                                .Take(5)
                                                .OrderBy(x => x)
                                                .ToList();

                // Берём 5 уникальных чисел
                List<int> numbers = Enumerable.Range(1, 90)
                                              .OrderBy(x => rand.Next())
                                              .Take(5)
                                              .OrderBy(x => x)
                                              .ToList();

                for (int i = 0; i < 5; i++)
                {
                    Card[row, positions[i]] = numbers[i];
                }
            }
        }

        public bool HasNumber(int number)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (Card[row, col] == number)
                        return true;
                }
            }

            return false;
        }

        public void MarkNumber(int number)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (Card[row, col] == number)
                        Marked[row, col] = true;
                }
            }
        }

        public bool IsWinner()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (Card[row, col].HasValue && !Marked[row, col])
                        return false;
                }
            }

            return true;
        }
    }
}