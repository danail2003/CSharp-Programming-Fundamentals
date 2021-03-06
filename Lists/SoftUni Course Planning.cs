using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main()
        {
            List<string> courses = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] token = command.Split(":");

                if (token[0] == "Add")
                {
                    if (!courses.Contains(token[1]))
                    {
                        courses.Add(token[1]);
                    }
                }
                else if (token[0] == "Insert")
                {
                    int index = int.Parse(token[2]);

                    if (!courses.Contains(token[1]))
                    {
                        courses.Insert(index, token[1]);
                    }
                }
                else if (token[0] == "Remove")
                {
                    if (courses.Contains(token[1]))
                    {
                        courses.Remove(token[1]);
                    }
                }
                else if (token[0] == "Swap")
                {
                    if (courses.Contains(token[1]) && courses.Contains(token[2]))
                    {
                        for (int i = 0; i < courses.Count; i++)
                        {
                            if (courses[i] == token[1])
                            {
                                courses[i] = token[2];         
                            }
                            else if (courses[i] == token[2])
                            {
                                courses[i] = token[1];
                            }
                        }
                    }
                }
                else if (token[0] == "Exercise")
                {
                    if (courses.Contains(token[1]))
                    {
                        for (int i = 0; i < courses.Count; i++)
                        {
                            if (courses[i] == token[1] && courses[i] + "-Exercise" != courses[i + 1])
                            {
                                courses.Insert(i + 1, token[1] + "-Exercise");
                            }
                        }
                    }
                    else
                    {
                        courses.Add(token[1]);
                        courses.Add(token[1] + "-Exercise");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
