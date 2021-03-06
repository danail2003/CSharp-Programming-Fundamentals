using System;
using System.Text.RegularExpressions;

namespace Animal_Sanctuary
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"n:(?<animal>[^;]+);t:(?<kind>[^;]+);c--(?<country>[A-Za-z\s]+)$");
            
            int sum = 0;
            string endName = "";
            string endKind = "";

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["animal"].Value;
                    string kind = match.Groups["kind"].Value;
                    string country = match.Groups["country"].Value;

                    for (int j = 0; j < name.Length; j++)
                    {
                        if (char.IsLetter(name[j]) || name[j] == ' ')
                        {
                            endName += name[j];
                        }
                        else if (char.IsDigit(name[j]))
                        {
                            sum += int.Parse(name[j].ToString());
                        }
                    }

                    for (int j = 0; j < kind.Length; j++)
                    {
                        if (char.IsLetter(kind[j]) || kind[j] == ' ')
                        {
                            endKind += kind[j];
                        }
                        else if (char.IsDigit(kind[j]))
                        {
                            sum += int.Parse(kind[j].ToString());
                        }
                    }

                    Console.WriteLine($"{endName} is a {endKind} from {country}");

                    endName = "";
                    endKind = "";
                }
            }

            Console.WriteLine($"Total weight of animals: {sum}KG");
        }
    }
}
