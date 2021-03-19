using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));           
            int multiplyNumbers = GetMultipleOfEvenAndOdds(number);
            
            Console.WriteLine(multiplyNumbers);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEven = 0;

            while (number != 0)
            {
                int otherNumber = number % 10;

                if (otherNumber % 2 == 0)
                {
                    sumOfEven += otherNumber;
                }
                number /= 10;
            }

            return sumOfEven;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOfOdd = 0;

            while (number != 0)
            {
                int otherNumber = number % 10;

                if (otherNumber % 2 != 0)
                {
                    sumOfOdd += otherNumber;
                }

                number /= 10;
            }

            return sumOfOdd;
        }
    }
}
