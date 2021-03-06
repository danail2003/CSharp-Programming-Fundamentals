using System;
using System.Collections.Generic;
using System.Linq;

namespace Easter_Shopping
{
    class Program
    {
        static void Main()
        {
            List<string> shops = Console.ReadLine().Split().ToList();
            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Include")
                {
                    shops.Add(command[1]);
                }
                else if (command[0] == "Visit")
                {
                    if (command[1] == "first")
                    {
                        int number = int.Parse(command[2]);

                        if (number <= shops.Count)
                        {
                            for (int j = 0; j < number; j++)
                            {
                                shops.RemoveAt(0);
                            }
                        }
                    }
                    else if (command[1] == "last")
                    {
                        int number = int.Parse(command[2]);

                        if (number <= shops.Count)
                        {
                            shops.Reverse();

                            for (int j = 0; j < number; j++)
                            {
                                shops.RemoveAt(0);
                            }

                            shops.Reverse();
                        }
                    }
                }
                else if (command[0] == "Prefer")
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);
                    string firstShop = "";
                    string secondShop = "";

                    if(firstIndex >= 0 && firstIndex < shops.Count && secondIndex >= 0 && secondIndex < shops.Count)
                    {
                        for (int j = 0; j < shops.Count; j++)
                        {
                            if (j == firstIndex)
                            {
                                firstShop = shops[j];
                            }
                            else if (j == secondIndex)
                            {
                                secondShop = shops[j];
                            }
                        }

                        for (int j = 0; j < shops.Count; j++)
                        {
                            if (j == firstIndex)
                            {
                                shops[j] = secondShop;
                            }
                            else if (j == secondIndex)
                            {
                                shops[j] = firstShop;
                            }
                        }
                    }
                }
                else if (command[0] == "Place")
                {
                    int index = int.Parse(command[2]);

                    if (index >= 0 && index < shops.Count)
                    {
                        for (int j = 0; j < shops.Count; j++)
                        {
                            if (j == index)
                            {
                                shops.Insert(j + 1, command[1]);
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
