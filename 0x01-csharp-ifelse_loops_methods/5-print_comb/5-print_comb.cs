using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                if (j == i & j == 9)
                    Console.Write($"{i}{j}");
                else
                    Console.Write($"{i}{j}, ");
            }
        }
    }
}
