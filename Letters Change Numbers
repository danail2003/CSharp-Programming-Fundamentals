using System;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main()
        {
            string[] characters = Console.ReadLine().Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;

            for (int i = 0; i < characters.Length; i++)
            {
                string element = characters[i];
                decimal number = decimal.Parse(element.Substring(1, element.Length - 2));
                char firstLetter = element[0];
                char lastLetter = element[element.Length - 1];

                if (char.IsUpper(firstLetter))
                {
                    number /= (firstLetter - 64);
                }
                else if (char.IsLower(firstLetter))
                {
                    number *= (firstLetter - 96);
                }

                if (char.IsUpper(lastLetter))
                {
                    number -= (lastLetter - 64);
                }
                else
                {
                    number += (lastLetter - 96);
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
