using System;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                string reversed = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = reversed;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
