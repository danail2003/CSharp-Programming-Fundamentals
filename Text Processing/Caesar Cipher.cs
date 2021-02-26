using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string encrypted = "";

            for (int i = 0; i < text.Length; i++)
            {
                int ascii = text[i] + 3;
                char symbol = (char)ascii;
                encrypted += symbol;
            }

            Console.WriteLine(encrypted);
        }
    }
}
