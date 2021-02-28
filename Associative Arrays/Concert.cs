using System;
using System.Linq;
using System.Collections.Generic;

namespace Concert
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> bandNames = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTimes = new Dictionary<string, int>();
            
            string command = Console.ReadLine();

            while (command != "start of concert")
            {
                List<string> token = command.Split("; ").ToList();
                string bandName = token[1];

                if (token[0] == "Add")
                {
                    List<string> members = token[2].Split(", ").ToList();

                    if (!bandNames.ContainsKey(bandName))
                    {
                        bandNames[bandName] = new List<string>();

                        for (int i = 0; i < members.Count; i++)
                        {
                            bandNames[bandName].Add(members[i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < members.Count; i++)
                        {
                            if (!bandNames[bandName].Contains(members[i]))
                            {
                                bandNames[bandName].Add(members[i]);
                            }
                        }
                    }
                }
                else if (token[0] == "Play")
                {
                    if (!bandTimes.ContainsKey(bandName))
                    {
                        bandTimes[bandName] = 0;
                    }

                    int times = int.Parse(token[2]);

                    bandTimes[bandName] += times;
                }

                command = Console.ReadLine();
            }

            string group = Console.ReadLine();
            
            var sortedTimes = bandTimes.OrderBy(x => x.Key);
            int sum = 0;

            foreach (var time in bandTimes)
            {
                sum += time.Value;
            }

            Console.WriteLine($"Total time: {sum}");

            foreach (var band in sortedTimes.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            Console.WriteLine(group);

            foreach (var band in bandNames)
            {
                if (band.Key == group)
                {
                    foreach (var members in band.Value)
                    {
                        Console.WriteLine($"=> {members}");
                    }
                }
            }
        }
    }
}
