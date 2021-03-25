using System;
using System.Linq;
using System.Collections.Generic;

namespace Santa_s_List
{
    class Program
    {
        static void Main()
        {
            List<string> kids = Console.ReadLine().Split("&").ToList();
            string command = Console.ReadLine();

            while (command != "Finished!")
            {
                string[] token = command.Split();

                if (token[0] == "Bad")
                {
                    for (int i = 0; i < kids.Count; i++)
                    {
                        if (kids.Contains(token[1]) == false)
                        {
                            kids.Insert(0, token[1]);
                        }
                    }
                }
                else if (token[0] == "Good")
                {
                    for (int i = 0; i < kids.Count; i++)
                    {
                        if (kids.Contains(token[1]))
                        {
                            kids.Remove(token[1]);
                        }
                    }
                }
                else if (token[0] == "Rename")
                {
                    if (kids.Contains(token[1]))
                    {
                        for (int i = 0; i < kids.Count; i++)
                        {
                            if (kids[i] == token[1])
                            {
                                kids[i] = token[2];
                            }
                        }
                    }
                }
                else if (token[0] == "Rearrange")
                {
                    if (kids.Contains(token[1]))
                    {
                        for (int i = 0; i < kids.Count; i++)
                        {
                            if (kids[i] == token[1])
                            {
                                kids.RemoveAt(i);
                                kids.Add(token[1]);
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", kids));
        }
    }
}
