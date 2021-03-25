using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            
            GetSmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        static void GetSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber <= firstNumber && secondNumber <= thirdNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (thirdNumber <= firstNumber && thirdNumber <= secondNumber)
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
