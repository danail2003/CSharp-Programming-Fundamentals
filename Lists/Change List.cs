using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
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

                if (token[0] == "Delete")
                {
                    int number = int.Parse(token[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == number)
                        {
                            numbers.Remove(number);
                            i--;
                        }
                    }
                }
                else if (token[0] == "Insert")
                {
                    int position = int.Parse(token[1]);
                    int number = int.Parse(token[2]);
                    numbers.Insert(number, position);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
