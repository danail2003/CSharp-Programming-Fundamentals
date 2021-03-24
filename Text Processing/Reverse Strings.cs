using System;

namespace Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                string reverse = "";

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reverse += command[i];
                }

                Console.WriteLine($"{command} = {reverse}");

                command = Console.ReadLine();
            }
        }
    }
}
