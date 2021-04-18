using System;
using System.Linq;
using System.Collections.Generic;

namespace Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main()
        {
            int countOfHeroes = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            for (int i = 0; i < countOfHeroes; i++)
            {
                string[] hero = Console.ReadLine().Split();

                heroes[hero[0]] = new List<int>
                {
                    int.Parse(hero[1]),
                    int.Parse(hero[2])
                };
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] token = command.Split(" - ");

                if (token[0] == "CastSpell")
                {
                    if (heroes[token[1]][1] >= int.Parse(token[2]))
                    {
                        heroes[token[1]][1] -= int.Parse(token[2]);

                        Console.WriteLine($"{token[1]} has successfully cast {token[3]} and now has {heroes[token[1]][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{token[1]} does not have enough MP to cast {token[3]}!");
                    }
                }
                else if (token[0] == "TakeDamage")
                {
                    heroes[token[1]][0] -= int.Parse(token[2]);

                    if (heroes[token[1]][0] > 0)
                    {
                        Console.WriteLine($"{token[1]} was hit for {token[2]} HP by {token[3]} and now has {heroes[token[1]][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{token[1]} has been killed by {token[3]}!");

                        heroes.Remove(token[1]);
                    }
                }
                else if (token[0] == "Recharge")
                {
                    int mana = int.Parse(token[2]);

                    if (heroes[token[1]][1] + mana > 200)
                    {
                        int diff = heroes[token[1]][1] + mana - 200;

                        mana -= diff;

                        heroes[token[1]][1] += mana;
                    }
                    else
                    {
                        heroes[token[1]][1] += mana;
                    }

                    Console.WriteLine($"{token[1]} recharged for {mana} MP!");
                }
                else if (token[0] == "Heal")
                {
                    int heal = int.Parse(token[2]);

                    if (heroes[token[1]][0] + heal > 100)
                    {
                        int diff = heroes[token[1]][0] + heal - 100;

                        heal -= diff;

                        heroes[token[1]][0] += heal;
                    }
                    else
                    {
                        heroes[token[1]][0] += heal;
                    }

                    Console.WriteLine($"{token[1]} healed for {heal} HP!");
                }

                command = Console.ReadLine();
            }

            int counter = 0;

            foreach (var hero in heroes.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                counter = 0;

                Console.WriteLine(hero.Key);

                foreach (var stats in hero.Value)
                {
                    if (counter == 0)
                    {
                        Console.WriteLine($"  HP: {stats}");
                    }
                    else
                    {
                        Console.WriteLine($"  MP: {stats}");
                    }
                        
                    counter++;
                }
            }
        }
    }
}
