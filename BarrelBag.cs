using System;
using System.Collections.Generic;

namespace LotoGame
{
    public class BarrelBag
    {
        private List<int> numbers;
        private Random rand = new Random();

        public BarrelBag()
        {
            numbers = new List<int>();

            for (int i = 1; i <= 90; i++)
                numbers.Add(i);
        }

        public int GetNext()
        {
            if (numbers.Count == 0)
                throw new Exception("Числа закончились");

            int index = rand.Next(numbers.Count);
            int value = numbers[index];
            numbers.RemoveAt(index);

            return value;
        }

        public int Count()
        {
            return numbers.Count;
        }
    }
}