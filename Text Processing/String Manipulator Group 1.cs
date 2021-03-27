using System;

namespace String_Manipulator___Group_1
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] token = command.Split();

                if (token[0] == "Translate")
                {
                    text = text.Replace(token[1], token[2]);
                    Console.WriteLine(text);
                }
                else if (token[0] == "Includes")
                {
                    if (text.Contains(token[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (token[0] == "Start")
                {
                    int index = text.IndexOf(token[1]);

                    if (index == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (token[0] == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (token[0] == "FindIndex")
                {
                    int lastIndex = text.LastIndexOf(token[1]);
                    Console.WriteLine(lastIndex);
                }
                else if (token[0] == "Remove")
                {
                    int startIndex = int.Parse(token[1]);
                    int count = int.Parse(token[2]);
                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }

                command = Console.ReadLine();
            }
        }
    }
}
