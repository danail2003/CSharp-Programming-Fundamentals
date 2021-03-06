using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Emoji_Sumator
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
            
            Regex regex = new Regex(@"(?<=[\s])(?<emoji>:[a-z]{4,}:)(?=[\s,.!?])");

            MatchCollection matches = regex.Matches(text);
            string[] elements = new string[matches.Count];
            double sum = 0;

            for (int i = 0; i < matches.Count; i++)
            {
                string word = matches[i].Value;
                string newWord = "";

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] != ':')
                    {
                        sum += word[j];
                        newWord += word[j];
                    }
                }

                elements[i] = newWord;
                newWord = "";
            }

            for (int i = 0; i < elements.Length; i++)
            {
                string element = elements[i];
                bool isEqual = false;

                for (int j = 0; j < element.Length; j++)
                {                    
                    if (element[j] == numbers[j])
                    {
                        isEqual = true;
                    }                   
                    else
                    {
                        isEqual = false;
                        break;
                    }
                }

                if (isEqual)
                {
                    sum *= 2;
                }
            }

            if (matches.Count > 0)
            {
                Console.Write($"Emojis found: {string.Join(", ", matches)}");
                Console.WriteLine();
            }
            
            Console.WriteLine($"Total Emoji Power: {sum}");
        }
    }
}
