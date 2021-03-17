using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int element = arr[i];
                int sum = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum = element + arr[j];

                    if (sum == magicSum)
                    {
                        Console.WriteLine(arr[i] + " " + arr[j]);
                    }
                    else
                    {
                        sum = 0;
                    }
                }
            }
        }
    }
}
