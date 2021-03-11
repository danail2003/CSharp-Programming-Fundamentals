using System;
using System.Linq;
using System.Collections.Generic;

namespace ForceBook
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> teams = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "Lumpawaroo")
            {
                if (command.Contains('|'))
                {
                    string[] token = command.Split(" | ");

                    if (!teams.ContainsKey(token[0]))
                    {
                        teams[token[0]] = new List<string>();                        
                    }

                    bool isMember = false;

                    foreach (var member in teams)
                    {
                        if (member.Value.Contains(token[1]))
                        {
                            isMember = true;
                        }
                    }

                    if (!teams[token[0]].Contains(token[1]) && !isMember)
                    {
                        teams[token[0]].Add(token[1]);
                    }
                }
                else if (command.Contains(" -> "))
                {
                    string[] token = command.Split(" -> ");
                    bool isMember = false;
                    string side = "";

                    foreach (var member in teams)
                    {
                        if (member.Value.Contains(token[0]))
                        {
                            side = member.Key;
                            isMember = true;
                        }
                    }

                    if (!teams.ContainsKey(token[1]))
                    {
                        teams[token[1]] = new List<string>();
                    }

                    if (isMember)
                    {
                        teams[side].Remove(token[0]);
                    }

                    teams[token[1]].Add(token[0]);

                    Console.WriteLine($"{token[0]} joins the {token[1]} side!");
                }

                command = Console.ReadLine();
            }

            teams = teams.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var team in teams)
            {
                Console.WriteLine($"Side: {team.Key}, Members: {team.Value.Count}");
                List<string> crew = team.Value;
                crew.Sort();

                foreach (var member in crew)
                {
                    Console.WriteLine($"! {member}");
                }
            }
        }
    }
}
