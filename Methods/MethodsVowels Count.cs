using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            int[] counter = new int[10];
            int result = CountingOfVowels(text, counter[0]);
            
            Console.WriteLine(result);
        }

        static int CountingOfVowels(string text, int counter)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char digit = text[i];

                if (digit == 'o' || digit == 'a' || digit == 'e' || digit == 'i' || digit == 'u')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
