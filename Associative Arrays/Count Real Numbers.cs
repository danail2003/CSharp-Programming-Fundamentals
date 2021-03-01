using System;
using System.Linq;
using System.Collections.Generic;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> realNumbers = new SortedDictionary<double, int>();

            foreach (var count in numbers)
            {
                if (realNumbers.ContainsKey(count))
                {
                    realNumbers[count]++;
                }
                else
                {
                    realNumbers[count] = 1;
                }
            }

            foreach (var number in realNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
