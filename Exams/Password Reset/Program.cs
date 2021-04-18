using System;

namespace Password_Reset
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] token = command.Split();

                if (token[0] == "TakeOdd")
                {
                    string newPassword = string.Empty;

                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newPassword += password[i];
                        }
                    }

                    password = newPassword;

                    Console.WriteLine(password);
                }
                else if (token[0] == "Cut")
                {
                    int index = int.Parse(token[1]);
                    int length = int.Parse(token[2]);

                    password = password.Remove(index, length);

                    Console.WriteLine(password);
                }
                else if (token[0] == "Substitute")
                {
                    if (password.Contains(token[1]))
                    {
                        password = password.Replace(token[1], token[2]);

                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
