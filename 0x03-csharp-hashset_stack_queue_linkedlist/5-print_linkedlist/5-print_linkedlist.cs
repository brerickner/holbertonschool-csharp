using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linkey = new LinkedList<int>();
        if (size <= 0)
        {
            return(linkey);
        }
        for (int i = 0; i < size; i++)
        {
            System.Console.WriteLine(i);
            linkey.AddLast(i);
        }
        return (linkey);
    }
}
