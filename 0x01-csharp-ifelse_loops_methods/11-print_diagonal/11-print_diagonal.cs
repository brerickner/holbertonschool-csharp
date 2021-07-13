using System;
class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
            Console.WriteLine("\n");
        int x, y;
        for (x=0;x<length;x++)
        {
            for (y=0;y<x;y++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\"); 
        }
    }
}
