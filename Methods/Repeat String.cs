using System;

namespace Repeat_String
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatText(count, text);
            
            Console.WriteLine(result);
        }

        private static string RepeatText(int count, string text)
        {
            string repeatedText = "";

            for (int i = 0; i < count ; i++)
            {
                repeatedText += text;
            }

            return repeatedText;           
        }
    }
}
