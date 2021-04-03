using System;
using System.Linq;
using System.Collections.Generic;

namespace Wizard_Poker
{
    class Program
    {
        static void Main()
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();
            List<string> newCards = new List<string>();
            string command = Console.ReadLine();

            while (command != "Ready")
            {
                string[] token = command.Split();

                if (token[0] == "Add")
                {
                    if (cards.Contains(token[1]))
                    {
                       newCards.Add(token[1]);                      
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (token[0] == "Insert")
                {
                    int index = int.Parse(token[2]);

                    if (cards.Contains(token[1]) && index >= 0 && index < cards.Count - 1)
                    {
                        newCards.Insert(index, token[1]);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (token[0] == "Remove")
                {
                    if (newCards.Contains(token[1]))
                    {
                        newCards.Remove(token[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (token[0] == "Swap")
                {
                    int firstCard = newCards.IndexOf(token[1]);
                    int secondCard = newCards.IndexOf(token[2]);

                    newCards[firstCard] = token[2];
                    newCards[secondCard] = token[1];
                }
                else if (token[0] == "Shuffle")
                {
                    newCards.Reverse();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", newCards));
        }
    }
}
