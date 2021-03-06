using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main()
        {
            long factorialNumber = long.Parse(Console.ReadLine());
            long divider = long.Parse(Console.ReadLine());
            
            double result = (double)DiviseNumbers(factorialNumber) / DiviseNumbers(divider);
            
            Console.WriteLine($"{result:f2}");
        }

        static long DiviseNumbers(long factorialNumber)
        {
            long multiply = 1;           

            for (int i = 2; i <= factorialNumber; i++)
            {
                multiply *= i;
            }

            return multiply;
        }
    }
}
