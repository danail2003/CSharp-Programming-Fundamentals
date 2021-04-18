using System;
using System.Linq;

namespace Friendlist_Maintenance
{
    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(", ");

            int countOfBlacklist = 0;
            int countOfLosts = 0;

            string command = Console.ReadLine();

            while (command != "Report")
            {
                string[] token = command.Split();

                if (token[0] == "Blacklist")
                {
                    string name = names.FirstOrDefault(x => x.Contains(token[1]));

                    if (name == null)
                    {
                        Console.WriteLine($"{token[1]} was not found.");
                    }
                    else
                    {
                        countOfBlacklist++;
                        int index = 0;

                        for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i] == name)
                            {
                                index = i;
                                break;
                            }
                        }

                        names[index] = "Blacklisted";

                        Console.WriteLine($"{token[1]} was blacklisted.");
                    }
                }
                else if (token[0] == "Error")
                {
                    int index = int.Parse(token[1]);
                    string name = names[index];

                    if (name != "Blacklisted" && name != "Lost")
                    {
                        countOfLosts++;

                        names[index] = "Lost";

                        Console.WriteLine($"{name} was lost due to an error.");
                    }
                }
                else if (token[0] == "Change")
                {
                    int index = int.Parse(token[1]);

                    if (index >= 0 && index < names.Length)
                    {
                        string currentName = names[index];
                        names[index] = token[2];

                        Console.WriteLine($"{currentName} changed his username to {token[2]}.");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {countOfBlacklist} ");
            Console.WriteLine($"Lost names: {countOfLosts} ");
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
