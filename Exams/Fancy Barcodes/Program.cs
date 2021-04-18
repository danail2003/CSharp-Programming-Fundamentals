using System;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main()
        {
            int countOfBarcodes = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"^@#{1,}[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]@#{1,}$");

            for (int i = 0; i < countOfBarcodes; i++)
            {
                string barcode = Console.ReadLine();

                if (regex.IsMatch(barcode))
                {
                    string digits = string.Empty;

                    for (int j = 0; j < barcode.Length; j++)
                    {
                        if (char.IsDigit(barcode[j]))
                        {
                            digits += barcode[j];
                        }
                    }

                    if (digits.Length == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {digits}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
