using System;

namespace String_Manipulator___Group_2
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] token = command.Split();

                if (token[0] == "Change")
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
                else if (token[0] == "End")
                {
                    int endIndex = text.Length - 1;
                    int index = text.LastIndexOf(token[1]) + token[1].Length - 1;

                    if (endIndex == index)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (token[0] == "Uppercase")
                {
                    text = text.ToUpper();

                    Console.WriteLine(text);
                }
                else if (token[0] == "FindIndex")
                {
                    int firstIndex = text.IndexOf(token[1]);

                    Console.WriteLine(firstIndex);
                }
                else if (token[0] == "Cut")
                {
                    int index = int.Parse(token[1]);
                    int length = int.Parse(token[2]);
                    string cut = text.Substring(index, length);

                    Console.WriteLine(cut);
                }

                command = Console.ReadLine();
            }
        }
    }
}
