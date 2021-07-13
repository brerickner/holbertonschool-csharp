using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            int toBase = 16;
            for (value=0; value < 99; value++)
            {
                string hex = Convert.ToString(value, toBase);
                Console.WriteLine($"{value} = 0x{hex}");
            };
        }
    }
}
