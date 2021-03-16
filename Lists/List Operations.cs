using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] token = command.Split();

                if (token[0] == "Add")
                {
                    int number = int.Parse(token[1]);
                    numbers.Add(number);
                }
                else if (token[0] == "Insert")
                {
                    int number = int.Parse(token[1]);
                    int index = int.Parse(token[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index,number);
                    }
                }
                else if (token[0] == "Remove")
                {
                    int index = int.Parse(token[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");                       
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }  
                }
                else if (token[0] == "Shift")
                {
                    int count = int.Parse(token[2]);

                    if (token[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstNumber = numbers[0];
                            numbers.Add(firstNumber);
                            numbers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];
                            numbers.Insert(0, lastNumber);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
