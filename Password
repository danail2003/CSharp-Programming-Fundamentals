using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"^(\S+)>(?<numbers>\d{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<symbols>[^<^>]{3})<\1$");

            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();
                Match match = regex.Match(text);

                if (match.Success)
                {
                    string numbers = match.Groups["numbers"].Value;
                    string lower = match.Groups["lower"].Value;
                    string upper = match.Groups["upper"].Value;
                    string symbols = match.Groups["symbols"].Value;

                    Console.WriteLine($"Password: {numbers}{lower}{upper}{symbols}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
