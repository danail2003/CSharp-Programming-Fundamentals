using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main()
        {
            PalindromeOrNot();
        }

        static void PalindromeOrNot()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {                
                int firstSymbol = 0;
                int secondSymbol = 0;

                for (int i = 0; i < command.Length; i++)
                {
                    if (i == 0)
                    {
                        firstSymbol = command[i];
                    }
                    else if (i != 0)
                    {
                        secondSymbol = command[i];
                    }
                }

                if (firstSymbol == secondSymbol)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            }
        }
    }
}
