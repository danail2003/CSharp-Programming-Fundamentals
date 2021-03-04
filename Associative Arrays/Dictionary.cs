using System;
using System.Linq;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            List<string> wordsAndDefs = Console.ReadLine().Split(" | ").ToList();
            Dictionary<string, List<string>> definitions = new Dictionary<string, List<string>>();
            string[] words = Console.ReadLine().Split(" | ");
            string command = Console.ReadLine();

            for (int i = 0; i < wordsAndDefs.Count; i++)
            {
                string[] word = wordsAndDefs[i].Split(": ");

                if (!definitions.ContainsKey(word[0]))
                {
                    definitions[word[0]] = new List<string>();
                }
                
                definitions[word[0]].Add(word[1]);
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (definitions.ContainsKey(words[i]))
                {
                    Console.WriteLine($"{words[i]}");

                    var allDefs = definitions[words[i]];
                    allDefs = allDefs.OrderByDescending(x => x.Length).ToList();

                    foreach (var word in allDefs)
                    {
                        Console.WriteLine($" -{word}");
                    }
                }
            }

            if (command == "End")
            {
                return;
            }
            else if (command == "List")
            {
                foreach (var word in definitions.OrderBy(x=>x.Key))
                {
                    Console.Write($"{string.Join(" ", word.Key) + " "}");
                }
            }
        }
    }
}
