using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            
            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (counts.ContainsKey(text[i]))
                {
                    counts[text[i]]++;
                }
                else
                {
                    counts[text[i]] = 1;
                }
            }

            foreach (var item in counts)
            {
                if (item.Key != ' ')
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
