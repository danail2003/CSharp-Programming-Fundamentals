using System;
using System.Linq;
using System.Collections.Generic;

namespace The_Final_Quest
{
    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] token = command.Split();

                if (token[0] == "Delete")
                {
                    int index = int.Parse(token[1]);

                    if (index >= -1 && index < words.Count - 1)
                    {
                        words.RemoveAt(index + 1);
                    }
                }
                else if (token[0] == "Swap")
                {
                    if (words.Contains(token[1]) && words.Contains(token[2]))
                    {
                        for (int i = 0; i < words.Count; i++)
                        {
                            if (words[i] == token[1])
                            {
                                words[i] = token[2];
                            }
                            else if (words[i] == token[2])
                            {
                                words[i] = token[1];
                            }
                        }
                    }
                }
                else if (token[0] == "Put")
                {
                    int index = int.Parse(token[2]);

                    if (index > 0 && index <= words.Count)
                    {
                        for (int i = 0; i < words.Count; i++)
                        {
                            if (index == i)
                            {
                                words.Insert(i - 1, token[1]);
                            }

                            if (index >= words.Count)
                            {
                                words.Add(token[1]);
                            }
                        }
                    }
                }
                else if (token[0] == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }
                else if (token[0] == "Replace")
                {
                    if (words.Contains(token[2]))
                    {
                        for (int i = 0; i < words.Count; i++)
                        {
                            if (words[i] == token[2])
                            {
                                words[i] = token[1];
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
