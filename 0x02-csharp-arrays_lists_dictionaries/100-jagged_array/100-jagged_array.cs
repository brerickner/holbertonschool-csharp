using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int[][] jagged_array = new int[3][];
        jagged_array[0] = new int[]{0, 1, 2, 3};
        jagged_array[1] = new int[]{0, 1, 2, 3, 4, 5, 6};
        jagged_array[2] = new int[]{0, 1};
        for (int b = 0; b < jagged_array.Length; b++)
        {
            for (int a = 0; a < jagged_array[b].Length; a++)
            {
                System.Console.Write("{0}", jagged_array[b][a]);
                if (a < jagged_array[b].Length)
                    System.Console.Write(" ");
            }
            System.Console.WriteLine();
        }
    }
}
