using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int height = 5;

            int [,] arrayz = new int [width,height];
            arrayz[2, 2] = 1;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    System.Console.Write(arrayz[x,y]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
