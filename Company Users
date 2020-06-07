using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] token = command.Split(" -> ");

                if (!companies.ContainsKey(token[0]))
                {
                    companies[token[0]] = new List<string>();
                    companies[token[0]].Add(token[1]);
                }

                if (!companies[token[0]].Contains(token[1]))
                {
                    companies[token[0]].Add(token[1]);
                }

                command = Console.ReadLine();
            }

            foreach (var company in companies.OrderBy(x=>x.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {string.Join(" ", employee)}");
                }
            }
        }
    }
}
