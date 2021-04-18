using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"^![A-Z][a-z]{2,}!:\[[A-Za-z]{8,}]$");
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                string text = Console.ReadLine();

                Match match = regex.Match(text);

                if (match.Success)
                {
                    string[] token = text.Split(new char[] { '!', '[', ']', ':' }).Where(x => x != "").ToArray();

                    stringBuilder.Append(token[0] + ": ");

                    string message = token[1];

                    for (int j = 0; j < message.Length; j++)
                    {
                        int number = message[j];

                        stringBuilder.Append(number + " ");
                    }

                    Console.WriteLine(stringBuilder);

                    stringBuilder.Clear();
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
