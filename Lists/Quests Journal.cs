using System;
using System.Collections.Generic;
using System.Linq;

namespace Quests_Journal
{
    class Program
    {
        static void Main()
        {
            List<string> quests = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "Retire!")
            {
                string[] token = command.Split(" - ");

                if (token[0] == "Start")
                {
                    if(quests.Contains(token[1]) == false)
                    {
                        quests.Add(token[1]);
                    }
                }
                else if (token[0] == "Complete")
                {
                    if (quests.Contains(token[1]))
                    {
                        quests.Remove(token[1]);
                    }
                }
                else if(token[0] == "Side Quest")
                {
                    string[] sideSplit = token[1].Split(":");

                    if (quests.Contains(sideSplit[0]))
                    {
                        if(quests.Contains(sideSplit[1]) == false)
                        {
                            for (int i = 0; i < quests.Count; i++)
                            {
                                if (quests[i] == sideSplit[0])
                                {
                                    quests.Insert(i + 1, sideSplit[1]);
                                }
                            }
                        }
                    }
                }
                else if (token[0] == "Renew")
                {
                    if (quests.Contains(token[1]))
                    {
                        quests.Remove(token[1]);
                        quests.Add(token[1]);
                    }
                }                

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", quests));
        }
    }
}
