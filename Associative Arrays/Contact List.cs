using System;
using System.Collections.Generic;
using System.Linq;

namespace Contact_List
{
    class Program
    {
        static void Main()
        {
            List<string> contacts = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();

            while (true)
            {
                string[] token = command.Split();

                if (token[0] == "Print")
                {
                    break;
                }
                else if (token[0] == "Add")
                {
                    int index = int.Parse(token[2]);

                    if (contacts.Contains(token[1]))
                    {
                        if(index >= 0 && index <= contacts.Count)
                        {
                            contacts.Insert(index, token[1]);
                        }
                    }
                    else
                    {
                        contacts.Add(token[1]);
                    }
                }
                else if (token[0] == "Remove")
                {
                    int index = int.Parse(token[1]);

                    if(index >= 0 && index <= contacts.Count)
                    {
                        for (int i = 0; i < contacts.Count; i++)
                        {
                            if (i == index)
                            {
                                contacts.RemoveAt(index);
                            }
                        }
                    }
                }
                else if (token[0] == "Export")
                {
                    int startIndex = int.Parse(token[1]);
                    int count = int.Parse(token[2]);                    

                    if (count > contacts.Count - 1)
                    {
                        for (int i = startIndex; i < contacts.Count; i++)
                        {
                            Console.Write(contacts[i] + " ");
                        }
                    }
                    else
                    {
                        for (int i = startIndex; i <= count; i++)
                        {
                            Console.Write(contacts[i] + " ");
                        }
                    }

                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }

            string[] element = command.Split();

            if (element[1] == "Normal")
            {
                Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
            }
            else if (element[1] == "Reversed")
            {
                contacts.Reverse();
                Console.WriteLine($"Contacts: {string.Join(" ", contacts)}");
            }
        }
    }
}
