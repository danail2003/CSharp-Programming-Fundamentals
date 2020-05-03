using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int line = 1; line <= number; line++)
            {
                PrintFirsts(1, line);               
            }

            for (int line = number - 1; line >= 1; line--)
            {
                PrintFirsts(1, line);
            }
        }

        static void PrintFirsts(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
