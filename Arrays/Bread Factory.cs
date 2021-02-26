using System;

namespace Bread_Factory
{
    class Program
    {
        static void Main()
        {
            string[] workingDay = Console.ReadLine().Split("|");
            
            int health = 100;
            int coins = 100;

            for (int i = 0; i < workingDay.Length; i++)
            {
                string[] token = workingDay[i].Split("-");

                if (token[0] == "rest")
                {
                    int energy = int.Parse(token[1]);
                    health += energy;

                    if (health > 100)
                    {
                        int diff = health - 100;
                        health -= diff;
                        energy -= diff;
                    }

                    Console.WriteLine($"You gained {energy} energy.");
                    Console.WriteLine($"Current energy: {health}.");
                }
                else if (token[0] == "order")
                {
                    int addCoins = int.Parse(token[1]);                    

                    if (health >= 30)
                    {
                        health -= 30;
                        coins += addCoins;
                        Console.WriteLine($"You earned {addCoins} coins.");
                    }
                    else
                    {
                        health += 50;
                        Console.WriteLine("You had to rest!");
                    }
                }
                else
                {
                    int removeCoins = int.Parse(token[1]);
                    coins -= removeCoins;

                    if (coins > 0)
                    {
                        Console.WriteLine($"You bought {token[0]}.");
                    }
                    else if (coins <= 0)
                    {
                        Console.WriteLine($"Closed! Cannot afford {token[0]}.");
                        return;
                    }
                }
            }

            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {health}");
        }
    }
}
