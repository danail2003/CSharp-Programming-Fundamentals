using System;
using System.Linq;

namespace Number_Array
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] token = command.Split();

                if (token[0] == "Switch")
                {
                    int index = int.Parse(token[1]);

                    if (index >= 0 && index <= numbers.Length)
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (i == index)
                            {
                                numbers[i] *= (-1);
                            }
                        }
                    }
                }
                else if (token[0] == "Change")
                {
                    int index = int.Parse(token[1]);
                    int value = int.Parse(token[2]);

                    if (index >= 0 && index <= 0)
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (i == index)
                            {
                                numbers[i] = value;
                            }
                        }
                    }
                }
                else if (token[0] == "Sum")
                {
                    int sum = 0;

                    if (token[1] == "Negative")
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] < 0)
                            {
                                sum += numbers[i];
                            }
                        }

                        Console.WriteLine(sum);
                        sum = 0;
                    }
                    else if (token[1] == "Positive")
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] >= 0)
                            {
                                sum += numbers[i];
                            }
                        }

                        Console.WriteLine(sum);
                        sum = 0;
                    }
                    else if (token[1] == "All")
                    {
                        Console.WriteLine(numbers.Sum());
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    Console.Write(string.Join(" ", numbers[i] + " "));
                }
            }
        }
    }
}
