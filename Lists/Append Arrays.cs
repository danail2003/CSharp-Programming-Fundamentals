using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main()
        {
            List<string> numbers = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                List<string> spaceNumbers = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < spaceNumbers.Count; j++)
                {
                    Console.Write($"{spaceNumbers[j]} ");
                }
            }
        }
    }
}
