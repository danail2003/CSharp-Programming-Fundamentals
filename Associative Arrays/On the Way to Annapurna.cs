using System;
using System.Linq;
using System.Collections.Generic;

namespace On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> stores = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] token = command.Split("->");

                if (token[0] == "Add")
                {
                    string[] moreItems = token[2].Split(",");

                    if (!stores.ContainsKey(token[1]))
                    {
                        stores[token[1]] = new List<string>();
                    }

                    stores[token[1]].AddRange(moreItems);
                    
                }
                else if (token[0] == "Remove")
                {
                    if (stores.ContainsKey(token[1]))
                    {
                        stores.Remove(token[1]);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Stores list:");

            foreach (var store in stores.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine(store.Key);

                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
