using System;
using System.Linq;
using System.Collections.Generic;

namespace Froggy_Squad
{
    class Program
    {
        static void Main()
        {
            List<string> namesOfFrogs = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            
            string[] token = command.Split();

            while (true)
            {
                token = command.Split();

                if (token[0] == "Print")
                {
                    break;
                }                

                if (token[0] == "Join")
                {
                    namesOfFrogs.Add(token[1]);
                }
                else if (token[0] == "Jump")
                {
                    int index = int.Parse(token[2]);

                    for (int i = 0; i < namesOfFrogs.Count; i++)
                    {
                        if (index == i)
                        {
                            namesOfFrogs.Insert(index, token[1]);
                        }
                    }
                }
                else if (token[0] == "Dive")
                {
                    int index = int.Parse(token[1]);

                    for (int i = 0; i < namesOfFrogs.Count; i++)
                    {
                        if (index == i)
                        {
                            namesOfFrogs.RemoveAt(i);
                        }
                    }
                }
                else if (token[0] == "First")
                {
                    int count = int.Parse(token[1]);

                    if (count >= namesOfFrogs.Count)
                    {
                        count = namesOfFrogs.Count;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(string.Join(" ", namesOfFrogs[i] + " "));
                    }

                    Console.WriteLine();
                }
                else if (token[0] == "Last")
                {
                    int count = int.Parse(token[1]);

                    if (count >= namesOfFrogs.Count)
                    {
                        count = namesOfFrogs.Count;
                    }

                    List<string> reverse = new List<string>();

                    namesOfFrogs.Reverse();
                    reverse = namesOfFrogs.Take(count).Select(x => x).ToList();
                    reverse.Reverse();
                    namesOfFrogs.Reverse();                   

                    Console.Write(string.Join(" ", reverse) + " ");

                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }

            if (token[1] == "Normal")
            {
                Console.Write("Frogs: ");
                Console.WriteLine(string.Join(" ", namesOfFrogs));
            }
            else if (token[1] == "Reversed")
            {
                Console.Write("Frogs: ");
                namesOfFrogs.Reverse();
                Console.WriteLine(string.Join(" ", namesOfFrogs));
            }
        }
    }
}
