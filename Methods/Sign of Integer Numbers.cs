using System;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main()
        {
            IsBigger();
        }

        static void IsBigger()
        {
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}
