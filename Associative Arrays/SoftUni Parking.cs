using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> registeredStudents = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "register")
                {
                    if (registeredStudents.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {command[2]}");
                    }
                    else
                    {
                        registeredStudents[command[1]] = command[2];
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (!registeredStudents.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                    else
                    {
                        registeredStudents.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                }
            }

            foreach (var student in registeredStudents)
            {
                Console.WriteLine($"{student.Key} => {student.Value}");
            }
        }
    }
}
