using System;
using System.Linq;
using System.Collections.Generic;

namespace Man_O_War
{
    class Program
    {
        static void Main()
        {
            List<int> statusOfPirates = Console.ReadLine().Split('>', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> statusOfWarship = Console.ReadLine().Split('>', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (true)
            {
                string[] token = command.Split();

                if (token[0] == "Retire")
                {
                    break;
                }

                if (token[0] == "Fire")
                {
                    int index = int.Parse(token[1]);
                    int damage = int.Parse(token[2]);

                    if(index < 0 == false && index > statusOfWarship.Count == false)
                    {
                        for (int i = 0; i < statusOfWarship.Count; i++)
                        {
                            if (i == index)
                            {
                                statusOfWarship[i] -= damage;

                                if (statusOfWarship[i] <= 0)
                                {
                                    Console.WriteLine("You won! The enemy ship has sunken.");
                                    return;
                                }
                            }
                        }
                    }
                }
                else if (token[0] == "Defend")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);
                    int damage = int.Parse(token[3]);

                    if (startIndex < 0 == false && startIndex > statusOfPirates.Count == false && endIndex < 0 == false && endIndex > statusOfPirates.Count == false)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            if (i <= endIndex)
                            {
                                statusOfPirates[i] -= damage;

                                if (statusOfPirates[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    return;
                                }
                            }
                        }
                    }
                }
                else if (token[0] == "Repair")
                {
                    int index = int.Parse(token[1]);
                    int health = int.Parse(token[2]);

                    if (index < 0 == false && index > statusOfPirates.Count == false)
                    {
                        for (int i = 0; i < statusOfPirates.Count; i++)
                        {
                            if (i == index)
                            {                               
                                statusOfPirates[i] += health;

                                if (statusOfPirates[i] > maxHealth)
                                {
                                    int diff = statusOfPirates[i] - maxHealth;
                                    statusOfPirates[i] -= diff;
                                }
                            }
                        }
                    }
                }
                else if (token[0] == "Status")
                {
                    int counter = 0;
              
                    for (int i = 0; i < statusOfPirates.Count; i++)
                    {
                        double percent = statusOfPirates[i] / (double)maxHealth;

                        if (percent < 0.2)
                        {
                            counter++;
                        }
                    }

                    Console.WriteLine($"{counter} sections need repair.");
                    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Pirate ship status: {statusOfPirates.Sum()}");
            Console.WriteLine($"Warship status: {statusOfWarship.Sum()}");
        }
    }
}
