using System;

namespace Username
{
    class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Sign up")
            {
                string[] token = command.Split();

                if (token[0] == "Case")
                {
                    if (token[1] == "lower")
                    {
                        username = username.ToLower();
                        Console.WriteLine(username);
                    }
                    else if (token[1] == "upper")
                    {
                        username = username.ToUpper();
                        Console.WriteLine(username);
                    }
                }
                else if (token[0] == "Reverse")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);

                    if (startIndex >= 0 && startIndex < endIndex && endIndex < username.Length)
                    {
                        int diff = endIndex - startIndex + 1;
                        string substring = username.Substring(startIndex, diff);
                        string reverse = "";

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reverse += substring[i];
                        }

                        Console.WriteLine(reverse);
                    }
                }
                else if (token[0] == "Cut")
                {
                    if (username.Contains(token[1]))
                    {
                        username = username.Replace(token[1], "");
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {token[1]}.");
                    }
                }
                else if (token[0] == "Replace")
                {
                    username = username.Replace(char.Parse(token[1]), '*');
                    Console.WriteLine(username);
                }
                else if (token[0] == "Check")
                {
                    if (username.Contains(token[1]))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {token[1]}.");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
