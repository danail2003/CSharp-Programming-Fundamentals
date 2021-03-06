using System;

namespace Math_Power
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());
            
            double print = MathPower(number, powerNumber);
            
            Console.WriteLine(print);
        }

        static double MathPower(double number, int powerNumber)
        {
            double result = 1;

            for (int i = 0; i < powerNumber ; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
