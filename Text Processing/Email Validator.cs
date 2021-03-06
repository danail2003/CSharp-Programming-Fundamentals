using System;

namespace Email_Validator
{
    class Program
    {
        static void Main()
        {
            string email = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Complete")
            {
                string[] token = command.Split();

                if (token[0] == "Make")
                {
                    if (token[1] == "Upper")
                    {
                        email = email.ToUpper();

                        Console.WriteLine(email);
                    }
                    else if (token[1] == "Lower")
                    {
                        email = email.ToLower();

                        Console.WriteLine(email);
                    }
                }
                else if (token[0] == "GetDomain")
                {
                    int count = int.Parse(token[1]);
                    int index = email.LastIndexOf('.') + 1;
                    string domain = email.Substring(index, count);

                    Console.WriteLine(domain);               
                }
                else if (token[0] == "GetUsername")
                {
                    if (email.Contains('@'))
                    {
                        string username = "";

                        for (int i = 0; i < email.Length; i++)
                        {
                            if (email[i] == '@')
                            {
                                break;
                            }
                            else
                            {
                                username += email[i];
                            }
                        }

                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                }
                else if (token[0] == "Replace")
                {
                    email = email.Replace(char.Parse(token[1]), '-');
                    Console.WriteLine(email);
                }
                else if (token[0] == "Encrypt")
                {                   
                    for (int i = 0; i < email.Length; i++)
                    {
                        char symbol = email[i];
                        int ascii = symbol;
                        Console.Write(ascii + " ");
                    }

                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }
        }
    }
}
