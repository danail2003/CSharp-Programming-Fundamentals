using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main()
        {           
            Dictionary<string, int> allItems = new Dictionary<string, int>();
            Dictionary<string, int> junks = new Dictionary<string, int>();
            
            allItems["motes"] = 0;
            allItems["shards"] = 0;
            allItems["fragments"] = 0;
            bool isTrue = false;

            while (true)
            {
                if (isTrue)
                {
                    break;
                }

                List<string> items = Console.ReadLine().Split().ToList();            

                for (int i = 0; i < items.Count; i+=2)
                {
                    int quantity = int.Parse(items[i]);
                    string material = items[i + 1].ToLower();

                    if (allItems.ContainsKey(material))
                    {
                        allItems[material] += quantity;

                        if (allItems["motes"] >= 250 || allItems["shards"] >= 250 || allItems["fragments"] >= 250)
                        {
                            if (allItems["motes"] >= 250)
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if (allItems["shards"] >= 250)
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }

                            allItems[material] -= 250;
                            isTrue = true;
                            break;
                        }
                    }
                    else
                    {
                        junks[material] = 0;
                        junks[material] += quantity;
                    }
                }

            }

            Dictionary<string, int> ordered = allItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var material in ordered)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var junk in junks.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
