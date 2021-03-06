using System;
using System.Linq;

namespace Tasks_Planner
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int dropped = 0;
            int incomplete = 0;
            int completed = 0;

            while (command != "End")
            {
                string[] token = command.Split();

                if (token[0] == "Complete")
                {
                    int index = int.Parse(token[1]);

                    if (index >= 0 && index <= numbers.Length)
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (i == index)
                            {
                                numbers[i] = 0;
                            }
                        }
                    }
                }
                else if (token[0] == "Change")
                {
                    int index = int.Parse(token[1]);
                    int time = int.Parse(token[2]);

                    if (index >= 0 && index <= numbers.Length)
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (i == index)
                            {
                                numbers[i] = time;
                            }
                        }
                    }
                }
                else if (token[0] == "Drop")
                {
                    int index = int.Parse(token[1]);

                    if (index >= 0 && index <= numbers.Length)
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (i == index)
                            {
                                numbers[i] = -1;
                            }
                        }
                    }
                }
                else if (token[0] == "Count")
                {
                    if (token[1] == "Completed")
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] == 0)
                            {
                                completed++;
                            }
                        }

                        Console.WriteLine(completed);
                    }
                    else if (token[1] == "Incomplete")
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] > 0)
                            {
                                incomplete++;
                            }
                        }

                        Console.WriteLine(incomplete);
                    }
                    else if (token[1] == "Dropped")
                    {
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] < 0)
                            {
                                dropped++;
                            }
                        }

                        Console.WriteLine(dropped);
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    Console.Write(string.Join(" ", numbers[i] + " "));
                }
            }
        }
    }
}
