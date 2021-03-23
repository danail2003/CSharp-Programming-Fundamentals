using System;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main()
        {
            string symbols = Console.ReadLine();
            string newSymbols = "";
            char lastElement = symbols[symbols.Length - 1];

            for (int i = 0; i < symbols.Length - 1; i++)
            {
                if (symbols[i] != symbols[i + 1])
                {
                    newSymbols += symbols[i];
                }
            }

            newSymbols += lastElement;

            Console.WriteLine(newSymbols);
        }
    }
}
