using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> points = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            string command = Console.ReadLine();

            while (command != "exam finished")
            {
                string[] token = command.Split("-");

                if (token[1] == "banned")
                {
                    points.Remove(token[0]);
                }
                else
                {
                    if (!points.ContainsKey(token[0]))
                    {
                        points[token[0]] = 0;
                    }

                    if (int.Parse(token[2]) > points[token[0]])
                    {
                        points[token[0]] = int.Parse(token[2]);
                    }

                    if (!submissions.ContainsKey(token[1]))
                    {
                        submissions[token[1]] = 0;
                    }

                    submissions[token[1]]++;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Results:");

            foreach (var student in points.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var submission in submissions.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
