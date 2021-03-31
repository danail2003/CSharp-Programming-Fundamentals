using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command.Split();

                if (token[0] == "Add")
                {
                    int number = int.Parse(token[1]);
                    numbers.Add(number);
                }
                else
                {
                    int number = int.Parse(token[0]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if(numbers[i] + number <= maxCapacity)
                        {
                            numbers[i] += number;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
