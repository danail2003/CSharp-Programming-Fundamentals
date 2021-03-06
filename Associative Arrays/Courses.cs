using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string command = Console.ReadLine();
        
        Dictionary<string, List<string>> allStudents = new Dictionary<string, List<string>>();

        while (command != "end")
        {
            string[] token = command.Split(" : ");

            if (!allStudents.ContainsKey(token[0]))
            {
                allStudents[token[0]] = new List<string>();
            }

            allStudents[token[0]].Add(token[1]);

            command = Console.ReadLine();
        }

        foreach (var course in allStudents.OrderByDescending(x => x.Value.Count))
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");

            foreach (var student in course.Value.OrderBy(x => x))
            {
                Console.WriteLine($"-- {string.Join(" ", student)}");
            }
        }
    }
}
