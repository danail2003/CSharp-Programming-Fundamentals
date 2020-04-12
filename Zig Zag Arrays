using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main()
        {
            int countOfArr = int.Parse(Console.ReadLine());
            int[] firstArr = new int[countOfArr];
            int[] secondArr = new int[countOfArr];

            for (int i = 0; i < countOfArr; i++)
            {
               int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = arr[0];
                    secondArr[i] = arr[1];
                }
                else
                {
                    firstArr[i] = arr[1];
                    secondArr[i] = arr[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
