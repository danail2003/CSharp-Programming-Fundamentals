using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombAndPower[0])
                {
                    int left = Math.Max(i - bombAndPower[1], 0);
                    int right = Math.Min(i + bombAndPower[1], numbers.Count - 1);
                    int length = right - left + 1;
                    numbers.RemoveRange(left, length);
                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
