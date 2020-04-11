using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int element = arr[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (element <= arr[j])
                    {
                        isTopInteger = false;
                        break;
                    }                    
                }

                if (isTopInteger)
                {
                    Console.Write(element + " "); 
                }    
            }          
        }
    }
}
