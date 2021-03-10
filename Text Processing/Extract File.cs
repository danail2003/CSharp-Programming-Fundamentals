using System;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main()
        {
            string[] directory = Console.ReadLine().Split("\\").ToArray();
            
            string file = directory[directory.Length - 1];
            string[] split = file.Split(".");
            string fileName = split[0];
            string extension = split[1];

            Console.WriteLine($"File name: {fileName}\nFile extension: {extension}");
        }
    }
}
