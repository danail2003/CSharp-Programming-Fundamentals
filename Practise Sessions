using System;
using System.Linq;
using System.Collections.Generic;

namespace Practise_Sessions
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> roads = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] token = command.Split("->");

                if (token[0] == "Add")
                {
                    if (!roads.ContainsKey(token[1]))
                    {
                        roads[token[1]] = new List<string>();
                    }

                    roads[token[1]].Add(token[2]);
                }
                else if (token[0] == "Move")
                {
                    if (roads[token[1]].Contains(token[2]))
                    {
                        roads[token[3]].Add(token[2]);
                        roads[token[1]].Remove(token[2]);
                    }
                }
                else if (token[0] == "Close")
                {
                    if (roads.ContainsKey(token[1]))
                    {
                        roads.Remove(token[1]);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Practice sessions:");

            foreach (var road in roads.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine(road.Key);

                foreach (var racer in road.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
