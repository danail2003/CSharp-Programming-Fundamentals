using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Furniture
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            
            string regex = @">>(?<furniture>[A-Z][a-z]+|[A-Z][A-Z])<<(?<price>[\d.]+)!(?<quantity>[\d]+)\b";
            double total = 0;
            List<string> furniture = new List<string>();

            while (command != "Purchase")
            {
                Match match = Regex.Match(command, regex, RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    var name = match.Groups["furniture"].Value;
                    var price = double.Parse(match.Groups["price"].Value);
                    var quantity = double.Parse(match.Groups["quantity"].Value);
                    furniture.Add(name);
                    total += (price * quantity);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            if (furniture.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, furniture)}");
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
