﻿using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int index = 0;

        try
        {
            for (;index <= n; index++)
            {
                System.Console.WriteLine(myList[index]);
            }
        }
        catch (Exception)
        {
            return (index);
        }
        return (index);
    }
}
