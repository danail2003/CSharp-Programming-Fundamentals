using System;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main()
        {
            int guests = int.Parse(Console.ReadLine());
            
            List<string> goingOnParty = new List<string>();

            for (int i = 0; i < guests; i++)
            {
                string command = Console.ReadLine();
                string[] token = command.Split();
                int goingCounter = 0;

                for (int j = 0; j < goingOnParty.Count; j++)
                {
                    if (token[2] == "going!" && token[0] == goingOnParty[j])
                    {
                        Console.WriteLine($"{token[0]} is already in the list!");
                        goingCounter++;
                        break;
                    }
                }

                if (goingCounter == 0 && token[2] == "going!")
                {
                    goingOnParty.Add(token[0]);                                      
                }
                else if (token[2] == "not")
                {
                    int removeCounter = 0;

                    for (int j = 0; j < goingOnParty.Count; j++)
                    {
                        for (int k = 0; k < goingOnParty.Count; k++)
                        {
                            if (token[0] == goingOnParty[k])
                            {
                                goingOnParty.Remove(token[0]);
                                removeCounter++;
                                break;
                            }
                        }

                        if (removeCounter == 1)
                        {
                            break;
                        }

                        if (goingOnParty[j] != token[0])
                        {
                            Console.WriteLine($"{token[0]} is not in the list!");
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < goingOnParty.Count; i++)
            {
                Console.WriteLine(string.Join(" ", goingOnParty[i]));
            }           
        }
    }
}
