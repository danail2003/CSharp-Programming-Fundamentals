using System;

namespace Math_operations
{
    class Program
    {
        static void Main()
        {
            double firstNumber = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());

            if (operation == '+')
            {
                double print = SumOperation(firstNumber, secondNumber);
                Console.WriteLine(print);
            }
            else if (operation == '-')
            {
                double print = SubtractionOperation(firstNumber, secondNumber);
                Console.WriteLine(print);
            }
            else if (operation == '/')
            {
                double print = DivideOperation(firstNumber, secondNumber);
                Console.WriteLine(print);
            }
            else if (operation == '*')
            {
                double print = MultiplyOperation(firstNumber, secondNumber);
                Console.WriteLine(print);
            }
        } 
        
        static double SumOperation(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }

        static double SubtractionOperation(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }

        static double DivideOperation(double firstNumber, double secondNumber)
        {
            double result = Math.Round(firstNumber / secondNumber);
            return result;
        }

        static double MultiplyOperation(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }
    }
}
