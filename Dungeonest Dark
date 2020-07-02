using System;

namespace Dungeonest_Dark
{
    class Program
    {
        static void Main()
        {
            string[] dungeonRooms = Console.ReadLine().Split("|");
            int health = 100;
            int coins = 0;

            for (int i = 0; i < dungeonRooms.Length; i++)
            {
                string[] token = dungeonRooms[i].Split();

                if (token[0] == "potion")
                {
                    int number = int.Parse(token[1]);
                    health += number;

                    if (health > 100)
                    {
                        int diff = health - 100;
                        health -= diff;
                        number -= diff;
                    }

                    Console.WriteLine($"You healed for {number} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (token[0] == "chest")
                {
                    int number = int.Parse(token[1]);
                    coins += number;

                    Console.WriteLine($"You found {number} coins.");
                }
                else
                {
                    int attack = int.Parse(token[1]);
                    health -= attack;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {token[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {token[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
