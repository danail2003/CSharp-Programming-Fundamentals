using System;
using System.Linq;

namespace Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            string[] usernames = Console.ReadLine().Split(", ").ToArray();

            for (int i = 0; i < usernames.Length; i++)
            {
                string username = usernames[i];
                bool isValid = false;

                if (username.Length >= 3 && username.Length <= 16)
                {
                    foreach (var symbol in username)
                    {
                        if (char.IsLetterOrDigit(symbol) || symbol == 45 || symbol == 95)
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
