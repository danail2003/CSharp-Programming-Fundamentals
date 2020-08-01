using System;

namespace String_Manipulator
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            string text = "";

            while (command != "End")
            {
                string[] token = command.Split();

                if (token[0] == "Add")
                {
                    text += token[1];
                }
                else if (token[0] == "Upgrade")
                {
                    char symbol = char.Parse(token[1]);
                    int lastSymbol = symbol + 1;
                    char element = (char)lastSymbol;
                    text = text.Replace(char.Parse(token[1]), element);
                }
                else if (token[0] == "Print")
                {
                    Console.WriteLine(text);
                }
                else if (token[0] == "Index")
                {
                    if (text.Contains(token[1]))
                    {
                        char symbol = char.Parse(token[1]);
                        string indexes = "";

                        for (int i = 0; i < text.Length; i++)
                        {
                            if (text[i] == symbol)
                            {
                                indexes += i + " ";
                            }
                        }

                        Console.Write(indexes);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("None");
                    }
                }
                else if (token[0] == "Remove")
                {
                    text = text.Replace(token[1], "");
                }

                command = Console.ReadLine();
            }
        }
    }
}
