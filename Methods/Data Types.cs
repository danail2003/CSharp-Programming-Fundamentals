using System;

namespace Data_Types
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int fullNumber = int.Parse(Console.ReadLine());
                ReadingIntType(fullNumber);
            }
            else if (input == "real")
            {
                double realNumber = double.Parse(Console.ReadLine());
                ReadingDoubleType(realNumber);
            }
            else if (input == "string")
            {
                string text = Console.ReadLine();
                ReadingStringType(text);
            }
        }

        static void ReadingIntType(int fullNumber)
        {
            fullNumber *= 2;
            Console.WriteLine(fullNumber);
        }

        static void ReadingDoubleType(double realNumber)
        {
            realNumber *= 1.5;
            Console.WriteLine($"{realNumber:f2}");
        }

        static void ReadingStringType(string text)
        {
            Console.WriteLine($"${text}$");
        }
    }
}
