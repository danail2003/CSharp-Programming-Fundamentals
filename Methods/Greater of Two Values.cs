using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            
            if (type == "string")
            {
                string firstText = Console.ReadLine();
                string secondText = Console.ReadLine();
                string result = GetMax(firstText, secondText);
                Console.WriteLine(result);
            }
            else if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int result = GetMax(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstSymbol = char.Parse(Console.ReadLine());
                char secondSymbol = char.Parse(Console.ReadLine());
                char result = GetMax(firstSymbol, secondSymbol);
                Console.WriteLine(result);
            }
        }

        public static string GetMax(string firstText, string secondText)
        {
            int result = firstText.CompareTo(secondText);
            if (result > 0)
            {
                return firstText;
            }
            else
            {
                return secondText;
            }
        }

        public static int GetMax(int firstNumber, int secondNumber)
        {
            int result = Math.Max(firstNumber, secondNumber);
            return result;
        }

        public static char GetMax(char firstSymbol, char secondSymbol)
        {
            char result = (char)Math.Max(firstSymbol, secondSymbol);
            return result;
        }
    }
}
