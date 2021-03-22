using System;

namespace Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] reversedNumbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                reversedNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int j = number - 1; j >= 0; j--)
            {
                Console.Write(reversedNumbers[j] + " ");
            }
        }
    }
}
