using System;
using System.Text;
using System.Text.RegularExpressions;

namespace The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main()
        {
            string notes = Console.ReadLine();
            Regex regex = new Regex(@"(\$|#|&|%|\*)(?<name>[A-Za-z]*)\1=(?<number>\d*)!!(?<code>\S*)");
            StringBuilder coordinate = new StringBuilder();

            while (true)
            {
                Match match = regex.Match(notes);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    int length = int.Parse(match.Groups["number"].Value);
                    string textLength = match.Groups["code"].Value;

                    if (textLength.Length == length)
                    {
                        for (int i = 0; i < textLength.Length; i++)
                        {
                            char modify = textLength[i];
                            modify += (char)length;
                            coordinate.Append(modify);
                        }

                        Console.WriteLine($"Coordinates found! {name} -> {coordinate}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

                notes = Console.ReadLine();
            }
        }
    }
}
