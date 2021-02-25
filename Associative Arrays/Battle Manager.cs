using System;
using System.Linq;
using System.Collections.Generic;

namespace Battle_Manager
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<int>> users = new Dictionary<string, List<int>>();
            string command = Console.ReadLine();

            while (command != "Results")
            {
                string[] token = command.Split(":");

                if (token[0] == "Add")
                {
                    if (!users.ContainsKey(token[1]))
                    {
                        users[token[1]] = new List<int>();
                        users[token[1]].Add(0);
                        users[token[1]].Add(0);
                        users[token[1]][1] += int.Parse(token[3]);
                    }

                    users[token[1]][0] += int.Parse(token[2]);                    
                }
                else if (token[0] == "Attack")
                {
                    if (users.ContainsKey(token[1]) && users.ContainsKey(token[2]))
                    {
                        users[token[2]][0] -= int.Parse(token[3]);

                        if (users[token[2]][0] <= 0)
                        {
                            Console.WriteLine($"{token[2]} was disqualified!");
                            users.Remove(token[2]);
                        }

                        users[token[1]][1] -= 1;

                        if (users[token[1]][1] == 0)
                        {
                            Console.WriteLine($"{token[1]} was disqualified!");
                            users.Remove(token[1]);
                        }
                    }
                }
                else if (token[0] == "Delete")
                {
                    if (token[1] == "All")
                    {
                        users.Clear();
                    }
                    else if (users.ContainsKey(token[1]))
                    {
                        users.Remove(token[1]);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"People count: {users.Keys.Count}");

            foreach (var user in users.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value[0]} - {user.Value[1]}");
            }
        }
    }
}
