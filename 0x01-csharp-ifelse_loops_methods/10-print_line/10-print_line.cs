using System;
class Line
{
    public static void PrintLine(int length)
    {
        int i;
        if (length <= 0)
            Console.WriteLine("\n");
        for (i=0; i<length; i++)
        {
            if (i == length)
                Console.WriteLine("\n");
            else
                Console.Write("_");
        }
    }
}

