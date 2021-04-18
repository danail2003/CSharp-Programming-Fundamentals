using System;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main()
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] token = command.Split(" - ");

                if (token[0] == "Collect")
                {
                    if (!items.Contains(token[1]))
                    {
                        items.Add(token[1]);
                    }
                }
                else if (token[0] == "Drop")
                {
                    if (items.Contains(token[1]))
                    {
                        items.Remove(token[1]);
                    }
                }
                else if(token[0] == "Combine Items")
                {
                    string[] combinedItems = token[1].Split(":");

                    if (items.Contains(combinedItems[0]))
                    {
                        int index = items.IndexOf(combinedItems[0]);

                        items.Insert(index + 1, combinedItems[1]);
                    }
                }
                else if (token[0] == "Renew")
                {
                    if (items.Contains(token[1]))
                    {
                        items.Remove(token[1]);
                        items.Add(token[1]);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
