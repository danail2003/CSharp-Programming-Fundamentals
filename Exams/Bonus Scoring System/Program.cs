using System;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double maxAttendance = 0;
            double maxStudentAttendance = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double attendances = double.Parse(Console.ReadLine());

                double totalBonus = Math.Ceiling(attendances / lecturesCount * (5 + bonus));

                if (totalBonus > maxAttendance)
                {
                    maxAttendance = totalBonus;
                    maxStudentAttendance = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {maxAttendance}.");
            Console.WriteLine($"The student has attended {maxStudentAttendance} lectures.");
        }
    }
}
