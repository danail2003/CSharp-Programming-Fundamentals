using System;
using System.Text.RegularExpressions;
using System.Text;

namespace Song_Encryption
{
    class Program
    {
        static void Main()
        {
            string songs = Console.ReadLine();
            Regex regex = new Regex(@"(?<artist>^[A-Z][\s*'a-z]+):[A-Z ]+\b");
            StringBuilder encrypted = new StringBuilder();

            while (songs != "end")
            {
                Match match = regex.Match(songs);

                if (match.Success)
                {
                    int length = match.Groups["artist"].Value.Length;
                    string all = match.Value;

                    for (int i = 0; i < all.Length; i++)
                    {
                        if (all[i] == ':')
                        {
                            encrypted.Append("@");
                        }
                        else if (char.IsLetter(all[i]))
                        {
                            int symbol = all[i] + length;

                            if (symbol > 90 && all[i] <= 90)
                            {
                                int diff = (symbol - 90) + 64;
                                char element = (char)diff;
                                encrypted.Append(element);
                            }
                            else if (symbol > 122)
                            {
                                int diff = (symbol - 122) + 96;
                                char element = (char)diff;
                                encrypted.Append(element);
                            }
                            else
                            {
                                char element = (char)symbol;
                                encrypted.Append(element);
                            }
                        }
                        else
                        {
                            encrypted.Append(all[i]);
                        }
                    }

                    Console.WriteLine($"Successful encryption: {encrypted}");
                    encrypted.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                songs = Console.ReadLine();
            }
        }
    }
}
