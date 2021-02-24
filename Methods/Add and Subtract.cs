using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main()
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            int suming = SumOfTwoInts(firstInt, secondInt);
            int subtract = SubtractThirdDigit(suming, thirdInt);

            Console.WriteLine(subtract);
        }

        static int SumOfTwoInts(int firstInt, int secondInt)
        {
            int sum = firstInt + secondInt;
            return sum;
        }

        static int SubtractThirdDigit(int suming, int thirdInt)
        {
            int diff = suming - thirdInt;
            return diff;
        }
    }
}
