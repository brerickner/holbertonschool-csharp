using System;
using System.Collections.Generic;
class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        List<int> listy = new List<int>();
        for (int i = 0; i < size; i++)
        {
            listy.Add(i);
            Console.Write(listy[i]);

            if (i < size - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
        return (listy);
    }
}
