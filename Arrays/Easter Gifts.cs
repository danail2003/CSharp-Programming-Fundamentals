using System;

namespace Easter_Gifts
{
    class Program
    {
        static void Main()
        {
            string[] gifts = Console.ReadLine().Split();
            string command = Console.ReadLine();

            while (command != "No Money")
            {
                string[] token = command.Split();

                if (token[0] == "OutOfStock")
                {
                    for (int i = 0; i < gifts.Length; i++)
                    {
                        if (token[1] == gifts[i])
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (token[0] == "Required")
                {
                    int index = int.Parse(token[2]);

                    if (index >= 0 && index <= gifts.Length)
                    {
                        for (int i = 0; i < gifts.Length; i++)
                        {
                            if (index == i)
                            {
                                gifts[i] = token[1];
                            }
                        }
                    }                    
                }
                else if (token[0] == "JustInCase")
                {
                    gifts[gifts.Length - 1] = token[1];
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < gifts.Length; i++)
            {
                if (gifts[i] != "None")
                {
                    Console.Write(string.Join(" ", gifts[i] + " "));
                }
            }
        }
    }
}
