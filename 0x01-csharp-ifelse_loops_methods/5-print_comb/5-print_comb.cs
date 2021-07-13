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
                if (i == 99)
                    Console.WriteLine($"{i:D2}");
                else
                    Console.Write($"{i:D2}, ");
            }
        }
    }
}
