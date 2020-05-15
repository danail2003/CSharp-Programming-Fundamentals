using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command.Split();

                if (token[0] == "Add")
                {
                    int number = int.Parse(token[1]);
                    numbers.Add(number);
                }
                else if (token[0] == "Remove")
                {
                    int number = int.Parse(token[1]);
                    numbers.Remove(number);
                }
                else if (token[0] == "RemoveAt")
                {
                    int number = int.Parse(token[1]);
                    numbers.RemoveAt(number);
                }
                else if (token[0] == "Insert")
                {
                    int number = int.Parse(token[1]);
                    int index = int.Parse(token[2]);
                    numbers.Insert(index, number);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
