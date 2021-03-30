using System;

namespace Top_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            IsTopNumber(number);            
        }

        static void IsTopNumber(int number)
        {          
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int element = i;
                bool oddDigit = false;

                while (true)
                {
                    if (element == 0)
                    {
                        break;
                    }

                    int right = element % 10;
                    sum += right;

                    if (right % 2 != 0)
                    {
                        oddDigit = true;
                    }

                    element /= 10;
                }

                if (sum % 8 == 0 && oddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
