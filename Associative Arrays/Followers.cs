using System;
using System.Linq;
using System.Collections.Generic;

namespace Followers
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<int>> followers = new Dictionary<string, List<int>>();
            string command = Console.ReadLine();

            while (command != "Log out")
            {
                string[] token = command.Split(": ");

                if (token[0] == "New follower")
                {
                    if (!followers.ContainsKey(token[1]))
                    {
                        followers[token[1]] = new List<int>();
                        followers[token[1]].Add(0);
                        followers[token[1]].Add(0);
                    }
                }
                else if (token[0] == "Like")
                {
                    if (!followers.ContainsKey(token[1]))
                    {
                        followers[token[1]] = new List<int>
                        {
                            0,
                            0
                        };
                    }

                    followers[token[1]][0] += int.Parse(token[2]);
                }
                else if (token[0] == "Comment")
                {
                    if (!followers.ContainsKey(token[1]))
                    {
                        followers[token[1]] = new List<int>();
                        followers[token[1]].Add(0);
                        followers[token[1]].Add(0);
                    }

                    followers[token[1]][1] += 1;
                }
                else if (token[0] == "Blocked")
                {
                    if (followers.ContainsKey(token[1]))
                    {
                        followers.Remove(token[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{token[1]} doesn't exist.");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{followers.Keys.Count} followers");

            foreach (var follower in followers.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{follower.Key}: {string.Join("", follower.Value.Sum())}");
            }
        }
    }
}
