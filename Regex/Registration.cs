using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"U\$(?<name>[A-Z][a-z]{2,})U\$P@\$(?<pass>[A-Za-z]{5,}\d+)P@\$");
            
            int counter = 0;

            for (int i = 0; i < lines; i++)
            {
                string password = Console.ReadLine();
                Match match = regex.Match(password);

                if (match.Success)
                {
                    counter++;
                    Console.WriteLine("Registration was successful");
                    string pass = match.Groups["pass"].Value;
                    string user = match.Groups["name"].Value;                  

                    Console.WriteLine($"Username: {user}, Password: {pass}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {counter}");
        }
    }
}
