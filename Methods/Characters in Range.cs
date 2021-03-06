using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            if (firstSymbol > secondSymbol)
            {
                ReverseMiddleCharacter(firstSymbol, secondSymbol);
            }

            GetMiddleCharacters(firstSymbol, secondSymbol);
        }

        static void GetMiddleCharacters(char firstSymbol, char secondSymbol)
        {
            for (char i = firstSymbol; i < secondSymbol; i++)
            {
                if (i != firstSymbol)
                {
                    Console.Write(i + " ");
                }
            }
        }

        static void ReverseMiddleCharacter(char firstSymbol, char secondSymbol)
        {
            for (char i = secondSymbol; i < firstSymbol; i++)
            {
                if (i != secondSymbol)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
