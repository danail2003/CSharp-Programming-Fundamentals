using System;
using System.Linq;
using System.Collections.Generic;

namespace Nikulden_s_meals
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int count = 0;

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] token = command.Split("-");

                if (token[0] == "Like")
                {
                    if (!guests.ContainsKey(token[1]))
                    {
                        guests[token[1]] = new List<string>();
                    }

                    if (!guests[token[1]].Contains(token[2]))
                    {
                        guests[token[1]].Add(token[2]);
                    }
                }
                else if (token[0] == "Unlike")
                {
                    if (!guests.ContainsKey(token[1]))
                    {
                        Console.WriteLine($"{token[1]} is not at the party.");
                    }
                    else if (!guests[token[1]].Contains(token[2]))
                    {
                        Console.WriteLine($"{token[1]} doesn't have the {token[2]} in his/her collection.");
                    }
                    else
                    {
                        guests[token[1]].Remove(token[2]);
                        count++;

                        Console.WriteLine($"{token[1]} doesn't like the {token[2]}.");
                    } 
                }

                command = Console.ReadLine();
            }

            foreach (var guest in guests.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
            }

            Console.WriteLine($"Unliked meals: {count}");
        }
    }
}
