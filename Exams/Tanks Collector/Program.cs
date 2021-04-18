using System;
using System.Linq;
using System.Collections.Generic;

namespace Tanks_Collector
{
    class Program
    {
        static void Main()
        {
            List<string> ownedTanks = Console.ReadLine().Split(", ").ToList();
            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] command = Console.ReadLine().Split(", ");

                if (command[0] == "Add")
                {
                    string tank = ownedTanks.FirstOrDefault(x => x.Contains(command[1]));

                    if (tank == null)
                    {
                        ownedTanks.Add(command[1]);

                        Console.WriteLine("Tank successfully bought");
                    }
                    else
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                }
                else if (command[0] == "Remove")
                {
                    string tank = ownedTanks.FirstOrDefault(x => x.Contains(command[1]));

                    if (tank == null)
                    {
                        Console.WriteLine("Tank not found");
                    }
                    else
                    {
                        ownedTanks.Remove(tank);

                        Console.WriteLine("Tank successfully sold");
                    }
                }
                else if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < ownedTanks.Count)
                    {
                        ownedTanks.RemoveAt(index);

                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < ownedTanks.Count)
                    {
                        string tank = ownedTanks.FirstOrDefault(x => x.Contains(command[2]));

                        if (tank == null)
                        {
                            ownedTanks.Insert(index, command[2]);

                            Console.WriteLine("Tank successfully bought");
                        }
                        else
                        {
                            Console.WriteLine("Tank is already bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }

            Console.WriteLine(string.Join(", ", ownedTanks));
        }
    }
}
