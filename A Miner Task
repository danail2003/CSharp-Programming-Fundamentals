using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main()
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int number = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += number;
                }

                if(!resources.ContainsKey(resource) && !resources.ContainsValue(number))
                {
                    resources[resource] = 1;
                    resources[resource] = number;
                }              

                resource = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
