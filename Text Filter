using System;
using System.Linq;

namespace Text_Filter
{
    class Program
    {
        static void Main()
        {
            string[] banned = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();

            foreach (var ban in banned)
            {
                if (text.Contains(ban))
                {
                    text = text.Replace(ban, new string('*', ban.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
