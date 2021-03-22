using System;

namespace Password_Validator
{
    class Program
    {
        static void Main()
        {
            string pass = Console.ReadLine();
            
            bool result1 = HasGotCharacters(pass);
            bool result2 = HasGotAllComponents(pass);
            bool result3 = HasTwoDigits(pass);

            if (result1 && result2 && result3 == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool HasGotCharacters(string pass)
        {
            int digits = pass.Length;
            bool isEnough = false;

            if (digits >= 6 && digits <= 10)
            {
                isEnough = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            return isEnough;
        }

        static bool HasGotAllComponents(string pass)
        {
            bool hasAllComponents = false;
            int ifCounter = 0;

            for (int i = 0; i < pass.Length; i++)
            {
                char digit = pass[i];
                
                if(digit >= 48 && digit <= 57 || digit >= 65 && digit <= 90 || digit >= 97 && digit <= 122)
                {
                    hasAllComponents = true;
                }
                else
                {
                    if (ifCounter == 0)
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        ifCounter++;
                        hasAllComponents = false;
                    }                     
                }
            }

            return hasAllComponents;
        }

        static bool HasTwoDigits(string pass)
        {
            bool hasDigits = false;
            int counter = 0;
            int ifCounter = 0;

            for (int i = 0; i < pass.Length; i++)
            {
                char digits = pass[i];               

                if(digits >= 48 && digits <= 57)
                {
                    counter++;
                }              
            }

            if (counter >= 2)
            {
                hasDigits = true;
            }
            else
            {
                if (ifCounter == 0)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    ifCounter++;
                }
            }

            return hasDigits;
        }
    }
}
