using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main()
        {
            int counts = int.Parse(Console.ReadLine());
            var synonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < counts; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    synonyms[word] = new List<string>();
                }

                synonyms[word].Add(synonym);
            }

            foreach (var item in synonyms)
            {
                var key = item.Key;
                var value = item.Value;

                Console.WriteLine($"{key} - {string.Join(", ", value)}");
            }
        }
    }
}
