using System;
using System.Linq;
using System.Collections.Generic;

namespace Messages_Manager
{
    class Program
    {
        static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> users = new Dictionary<string, List<int>>();
            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] token = command.Split("=");

                if (token[0] == "Add")
                {
                    if (!users.ContainsKey(token[1]))
                    {
                        users[token[1]] = new List<int>();
                        users[token[1]].Add(0);
                        users[token[1]].Add(0);
                        users[token[1]][0] = int.Parse(token[2]);
                        users[token[1]][1] = int.Parse(token[3]);
                    }
                }
                else if (token[0] == "Message")
                {
                    if (users.ContainsKey(token[1]) && users.ContainsKey(token[2]))
                    {
                        users[token[1]][0] += 1;
                        users[token[2]][1] += 1;

                        if (users[token[1]].Sum() == capacity)
                        {
                            users.Remove(token[1]);

                            Console.WriteLine($"{token[1]} reached the capacity!");
                        }

                        if (users[token[2]].Sum() == capacity)
                        {
                            users.Remove(token[2]);

                            Console.WriteLine($"{token[2]} reached the capacity!");
                        }
                    }
                }
                else if (token[0] == "Empty")
                {
                    if (users.ContainsKey(token[1]))
                    {
                        users.Remove(token[1]);
                    }
                    else if (token[1] == "All")
                    {
                        users.Clear();
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Keys.Count}");

            foreach (var user in users.OrderByDescending(x=>x.Value[1]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{user.Key} - {string.Join("", user.Value.Sum())}");
            }
        }
    }
}
