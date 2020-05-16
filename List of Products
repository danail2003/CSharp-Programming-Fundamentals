using System;
using System.Collections.Generic;

namespace List_of_Products
{
    class Program
    {
        static void Main()
        {
            int products = int.Parse(Console.ReadLine());
            List<string> allProducts = new List<string>();

            for (int i = 0; i < products; i++)
            {
                string product = Console.ReadLine();
                allProducts.Add(product);
            }

            allProducts.Sort();

            for (int i = 0; i < allProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{allProducts[i]}");
            }
        }
    }
}
