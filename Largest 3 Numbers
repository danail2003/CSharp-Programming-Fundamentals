using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < 3)
                {
                    Console.Write(string.Join(" ", numbers[i] + " "));
                }
            }
        }
    }
}
