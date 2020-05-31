using System;
using System.Collections.Generic;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main()
        {
            string bigNumber = Console.ReadLine();
            bigNumber = bigNumber.TrimStart(new char[] { '0' });
            char[] bigNum = bigNumber.ToCharArray();
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("0");
                return;
            }

            List<string> newNumber = new List<string>();
            int convert = 0;

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                convert += int.Parse(Convert.ToString(bigNum[i])) * number;
                newNumber.Insert(0, (convert % 10).ToString());
                convert /= 10;
            }

            if (convert > 0)
            {
                Console.WriteLine($"{convert}{string.Join("", newNumber)}");
            }
            else
            {
                Console.WriteLine(string.Join("", newNumber));
            }
        }
    }
}
