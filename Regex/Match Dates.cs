using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    class Program
    {
        static void Main()
        {
            string dates = Console.ReadLine();
            
            Regex pattern = new Regex(@"\b(?<day>\d{2})([.\/-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");
            MatchCollection matches = pattern.Matches(dates);

            foreach (Match date in matches)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
