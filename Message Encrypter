using System;
using System.Text.RegularExpressions;

namespace Message_Encrypter
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"(\*|@)(?<word>[A-Z][a-z]{3,})\1: (\[(?<first>\w)])\|\[(?<second>\w)]\|\[(?<third>\w)]\|$");

            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();

                Match match = regex.Match(text);

                if (match.Success)
                {
                    string word = match.Groups["word"].Value;
                    string first = match.Groups["first"].Value;
                    string second = match.Groups["second"].Value;
                    string third = match.Groups["third"].Value;

                    char firstNum = char.Parse(first);
                    char secondNum = char.Parse(second);
                    char thirdNum = char.Parse(third);
                    int firstSymbol = firstNum;
                    int secondSymbol = secondNum;
                    int thirdSymbol = thirdNum;

                    Console.WriteLine($"{word}: {firstSymbol} {secondSymbol} {thirdSymbol}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
