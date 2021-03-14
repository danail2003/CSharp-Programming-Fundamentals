using System;
using System.Collections.Generic;
using System.Linq;

namespace Inbox_Manager
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] token = command.Split("->");

                if (token[0] == "Add")
                {
                    if (users.ContainsKey(token[1]))
                    {
                        Console.WriteLine($"{token[1]} is already registered");
                    }
                    else
                    {
                        users[token[1]] = new List<string>();
                    }
                }
                else if (token[0] == "Send")
                {
                    users[token[1]].Add(token[2]);
                }
                else if (token[0] == "Delete")
                {
                    if (users.ContainsKey(token[1]))
                    {
                        users.Remove(token[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{token[1]} not found!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Keys.Count}");

            foreach (var user in users.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{user.Key}");

                foreach (var email in user.Value)
                {
                    Console.WriteLine($"- {email}");
                }
            }
        }
    }
}
