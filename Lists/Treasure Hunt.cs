using System;
using System.Linq;
using System.Collections.Generic;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main()
        {
            List<string> treasure = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (true)
            {
                string[] token = command.Split();

                if (command == "Yohoho!")
                {
                    break;
                }

                if (token[0] == "Loot")
                {
                    for (int i = 1; i < token.Length; i++)
                    {
                        if (treasure.Contains(token[i]) == false)
                        {
                            treasure.Insert(0, token[i]);
                        }
                    }
                }
                else if (token[0] == "Drop")
                {
                    int index = int.Parse(token[1]);

                    if (index < 0 == false && index > treasure.Count == false)
                    {
                        string element = "";

                        for (int i = 0; i < treasure.Count; i++)
                        {
                            if (i == index)
                            {
                                element = treasure[i];
                            }
                        }

                        treasure.RemoveAt(index);
                        treasure.Add(element);
                    }           
                }
                else if (token[0] == "Steal")
                {
                    int count = int.Parse(token[1]);

                    List<string> stollenItems = new List<string>();

                    treasure.Reverse();
                    stollenItems = treasure.Take(count).Select(x => x).ToList();
                    stollenItems.Reverse();
                    treasure.Reverse();

                    Console.WriteLine(string.Join(", ", stollenItems));

                    for (int i = 0; i < stollenItems.Count; i++)
                    {
                        if (treasure.Contains(stollenItems[i]))
                        {
                            treasure.Remove(stollenItems[i]);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            double allElements = 0;           

            for (int i = 0; i < treasure.Count; i++)
            {
                string symbol = treasure[i];
                allElements += symbol.Length;
            }

            double diff = allElements / treasure.Count;

            if (treasure.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {diff:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
