using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int right = arr.Sum();
            int left = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                right -= arr[i];

                if (right == left)
                {
                    Console.WriteLine(i);
                    return;
                }

                left += arr[i];
            }

            Console.WriteLine("no");
        }
    }
}
