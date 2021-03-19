using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string end = GetMiddle(text);
            
            Console.WriteLine(end);
        }

        static string GetMiddle(string text)
        {
            int digit = text.Length;
            
            if (digit % 2 != 0)
            {
                return text[digit / 2].ToString();
            }
            else
            {
                return text[digit / 2 - 1].ToString() + text[digit / 2];
            }
        }
    }
}
