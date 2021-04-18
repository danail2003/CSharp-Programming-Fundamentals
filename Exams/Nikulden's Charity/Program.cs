using System;

namespace Nikulden_s_Charity
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] token = command.Split();

                if (token[0] == "Replace")
                {
                    text = text.Replace(token[1], token[2]);

                    Console.WriteLine(text);
                }
                else if (token[0] == "Cut")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);

                    if (startIndex >= 0 && startIndex < text.Length && endIndex >= 0 && endIndex < text.Length)
                    {
                        int count = 0;

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            count++;
                        }

                        text = text.Remove(startIndex, count);

                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (token[0] == "Make")
                {
                    if (token[1] == "Upper")
                    {
                        text = text.ToUpper();

                        Console.WriteLine(text);
                    }
                    else if (token[1] == "Lower")
                    {
                        text = text.ToLower();

                        Console.WriteLine(text);
                    }
                }
                else if (token[0] == "Check")
                {
                    string message = token[1];

                    if (text.Contains(message))
                    {
                        Console.WriteLine($"Message contains {message}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {message}");
                    }
                }
                else if (token[0] == "Sum")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);

                    if (startIndex >= 0 && startIndex < text.Length && endIndex >= 0 && endIndex < text.Length)
                    {
                        int count = 0;

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            count++;
                        }

                        string substring = text.Substring(startIndex, count);
                        int sum = 0;

                        for (int i = 0; i < substring.Length; i++)
                        {
                            sum += substring[i];
                        }

                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
