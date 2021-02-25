using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Arriving_in_Kathmandu
{
    class Program
    {
        static void Main()
        {
            string notes = Console.ReadLine();
            Regex regex = new Regex(@"^(?<name>[A-Za-z0-9!@#$?]+)=(?<length>\d+)<<(?<code>.+)$");

            while(notes != "Last note")
            {
                Match match = regex.Match(notes);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    int length = int.Parse(match.Groups["length"].Value);
                    string code = match.Groups["code"].Value;
                    StringBuilder nameOfPeak = new StringBuilder();

                    if (length == code.Length)
                    {
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (char.IsLetterOrDigit(name[i]))
                            {
                                nameOfPeak.Append(name[i]);
                            }
                        }

                        Console.WriteLine($"Coordinates found! {nameOfPeak} -> {code}");
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
