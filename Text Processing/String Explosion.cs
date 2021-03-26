using System;

namespace String_Explosion
{
    class Program
    {
        static void Main()
        {
            string bombs = Console.ReadLine();
            int bomb = 0;

            for (int i = 0; i < bombs.Length; i++)
            {
                if (bombs[i] == '>')
                {
                    bomb += int.Parse(bombs[i + 1].ToString());
                }
                else if(bomb > 0 && bombs[i] != '>')
                {
                    bombs = bombs.Remove(i, 1);
                    bomb--;
                    i--;
                }
            }

            Console.WriteLine(bombs);
        }
    }
}
