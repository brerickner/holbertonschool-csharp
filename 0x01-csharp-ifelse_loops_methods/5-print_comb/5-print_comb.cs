using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 100; i++)
            {
                if (i < 10)
                    Console.Write($"0{i}, ");
                else if (i == 99)
                    Console.Write($"{i}");
                else
                    Console.Write($"{i}, ");
            }
        }
    }
}
