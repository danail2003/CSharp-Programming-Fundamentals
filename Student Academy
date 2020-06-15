using System;
using System.Linq;
using System.Collections.Generic;

namespace Student_Academy
{
    class Program
    {
        static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> allStudents = new Dictionary<string, List<double>>();

            for (int i = 0; i < students; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!allStudents.ContainsKey(name))
                {
                    allStudents[name] = new List<double>();
                }

                allStudents[name].Add(grade);
            }

            allStudents = allStudents.Where(x => x.Value.Average() >= 4.50).OrderByDescending(x => x.Value.Average()).ToDictionary(x => x.Key, x => x.Value);

            foreach (var student in allStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
