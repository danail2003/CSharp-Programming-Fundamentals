using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            Regex regex = new Regex(@"%(?<customer>[A-Z][a-z]+)%[^|\$%\.]*<(?<product>\w+)>[^|\$%\.]*\|(?<count>\d+)\|[^|\$%\.0-9]*(?<price>\d+\.?\d+)\$");
            double totalIncome = 0;

            while (command != "end of shift")
            {
                var matches = regex.Match(command);

                if (matches.Success)
                {
                    string customer = matches.Groups["customer"].Value;
                    string product = matches.Groups["product"].Value;
                    int count = int.Parse(matches.Groups["count"].Value);
                    double price = double.Parse(matches.Groups["price"].Value);

                    double totalPrice = count * price;
                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
