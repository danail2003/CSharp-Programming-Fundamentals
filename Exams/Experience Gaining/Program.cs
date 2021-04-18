using System;

namespace Experience_Gaining
{
    class Program
    {
        static void Main()
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int battleCount = int.Parse(Console.ReadLine());

            double experienceGained = 0;
            int count = 0;

            for (int i = 1; i <= battleCount; i++)
            {
                double experience = double.Parse(Console.ReadLine());
                count++;

                if (i % 3 == 0)
                {
                    experience += experience * 0.15;
                }

                if (i % 5 == 0)
                {
                    experience -= experience * 0.1;
                }

                experienceGained += experience;

                if (experienceGained >= neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
                    return;
                }
            }

            if (experienceGained >= neededExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
            }
            else
            {
                neededExperience -= experienceGained;

                Console.WriteLine($"Player was not able to collect the needed experience, {neededExperience:f2} more needed.");
            }
        }
    }
}
