using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(string.Join(" ", words[i]));
            }
        }
    }
}
