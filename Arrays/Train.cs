using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main()
        {
            int countOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[countOfWagons];

            for (int i = 0; i < countOfWagons; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(wagons.Sum());
        }
    }
}
