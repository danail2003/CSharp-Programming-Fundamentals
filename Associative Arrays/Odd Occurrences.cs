using System;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> oddWords = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string lowerCase = words[i].ToLower();

                if (oddWords.ContainsKey(lowerCase))
                {
                    oddWords[lowerCase]++;
                }
                else
                {
                    oddWords[lowerCase]=1;
                }
            }

            foreach (var item in oddWords)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
