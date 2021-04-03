using System;
using System.Linq;

namespace Weaponsmith
{
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split("|").ToArray();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] token = command.Split();

                if (token[0] == "Move")
                {
                    if (token[1] == "Left")
                    {
                        int index = int.Parse(token[2]);

                        if (index > 0 && index <= text.Length)
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                if (i == index)
                                {
                                    string firstElement = text[i];
                                    string secondElement = text[i - 1];
                                    text[i] = secondElement;
                                    text[i - 1] = firstElement;
                                }
                            }
                        }
                    }
                    else if (token[1] == "Right")
                    {
                        int index = int.Parse(token[2]);

                        if (index >= 0 && index < text.Length - 1)
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                if (i == index)
                                {
                                    string firstElement = text[i];
                                    string secondElemnet = text[i + 1];
                                    text[i] = secondElemnet;
                                    text[i + 1] = firstElement;
                                }
                            }
                        }
                    }
                    
                }
                else if (token[0] == "Check")
                {
                    if (token[1] == "Odd")
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(text[i] + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (token[1] == "Even")
                    {
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(text[i] + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("", text)}!");
        }
    }
}
