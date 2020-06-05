using System;

namespace Substring
{
    class Program
    {
        static void Main()
        {
            string firstString = Console.ReadLine().ToLower();
            string secondString = Console.ReadLine();

            int index = secondString.IndexOf(firstString);

            while (index != -1)
            {
                secondString = secondString.Remove(index, firstString.Length);
                index = secondString.IndexOf(firstString);
            }

            Console.WriteLine(secondString);
        }
    }
}
