using System;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            
            Regex regex = new Regex(@"^(\$|%)(?<word>[A-Z][a-z]{3,})\1: \[(?<first>\d*)]\|\[(?<second>\d*)]\|\[(?<third>\d*)]\|$");

            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();
                Match match = regex.Match(text);

                if (match.Success)
                {
                    string word = match.Groups["word"].Value;
                    int firstSymbol = int.Parse(match.Groups["first"].Value);
                    int secondSymbol = int.Parse(match.Groups["second"].Value);
                    int thirdSymbol = int.Parse(match.Groups["third"].Value);
                    
                    char first = (char)firstSymbol;
                    char second = (char)secondSymbol;
                    char third = (char)thirdSymbol;

                    Console.WriteLine($"{word}: {first}{second}{third}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
