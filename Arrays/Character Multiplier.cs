using System;
using System.Linq;

namespace Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            string[] symbols = Console.ReadLine().Split().ToArray();
            
            double sum = 0;
            string firstString = symbols[0];
            string secondString = symbols[1];

            char[] first = firstString.ToCharArray();
            char[] second = secondString.ToCharArray();

            int maxLength = Math.Max(first.Length, second.Length);
            int minLenth = Math.Min(first.Length, second.Length);

            for (int i = 0; i < minLenth; i++)
            {
                sum += first[i] * second[i];
            }

            if (maxLength == first.Length)
            {
                for (int i = minLenth; i < maxLength; i++)
                {
                    sum += first[i];
                }
            }
            else
            {
                for (int i = minLenth; i < maxLength; i++)
                {
                    sum += second[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
