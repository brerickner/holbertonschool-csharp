using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {2, 4, 6}
                // {98, 0, -12},
                // {21, 972, 44},
                // {-727, 60, -2}
            };
            int[,] result;
            int i, j;

            result = MyMath.Matrix.Divide(matrix, 2);
            if (result != null)
            {
                for (i = 0; i < result.GetLength(0); i++)
                {
                    for (j = 0; j < result.GetLength(1); j++)
                    {
                        Console.Write(result[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
