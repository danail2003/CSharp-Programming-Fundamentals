using System;
using System.Linq;

namespace Seize_the_Fire
{
    class Program
    {
        static void Main()
        {
            string[] fireCells = Console.ReadLine().Split('#', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int water = int.Parse(Console.ReadLine());
            
            int[] fireOut = new int[fireCells.Length];

            for (int i = 0; i < fireCells.Length; i++)
            {
                string[] token = fireCells[i].Split();

                if (token[0] == "High")
                {
                    int level = int.Parse(token[2]);

                    if (level < 81 == false && level > 125 == false)
                    {
                        if (water >= level)
                        {
                            water -= level;
                            fireOut[i] += level;
                        }
                    }
                }
                else if (token[0] == "Medium")
                {
                    int level = int.Parse(token[2]);

                    if(level < 51 == false && level > 80 == false)
                    {
                        if (water >= level)
                        {
                            water -= level;
                            fireOut[i] += level;
                        }
                    }
                }
                else if (token[0] == "Low")
                {
                    int level = int.Parse(token[2]);

                    if (level < 1 == false && level > 50 == false)
                    {
                        if (water >= level)
                        {
                            water -= level;
                            fireOut[i] += level;
                        }
                    }
                }
            }

            Console.WriteLine($"Cells:");

            for (int i = 0; i < fireOut.Length; i++)
            {
                if (fireOut[i] == 0 == false)
                {
                    Console.WriteLine($" - {fireOut[i]}");
                }
            }

            double effort = 0;

            for (int i = 0; i < fireOut.Length; i++)
            {
                effort += fireOut[i] * 0.25;
            }

            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {fireOut.Sum()}");
        }
    }
}
