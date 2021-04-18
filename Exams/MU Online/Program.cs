using System;

namespace MU_Online
{
    class Program
    {
        static void Main()
        {
            string[] rooms = Console.ReadLine().Split("|");

            int health = 100;
            int bitcoins = 0;

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] token = rooms[i].Split();

                if (token[0] == "potion")
                {
                    int healing = int.Parse(token[1]);

                    if (health + healing > 100)
                    {
                        int diff = 100 - health;
                        health += diff;
                        healing = diff;
                    }
                    else
                    {
                        health += healing;
                    }

                    Console.WriteLine($"You healed for {healing} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (token[0] == "chest")
                {
                    bitcoins += int.Parse(token[1]);

                    Console.WriteLine($"You found {token[1]} bitcoins.");
                }
                else
                {
                    int monster = int.Parse(token[1]);

                    health -= monster;

                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {token[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }

                    Console.WriteLine($"You slayed {token[0]}.");
                }
            }

            Console.WriteLine($"You've made it!\nBitcoins: {bitcoins}\nHealth: {health}");
        }
    }
}
