﻿using System;
class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }

        int i = array.Length - 1;
        while (i > -1)
        {
            Console.Write(array[i]);
            if (i > 0)
            {
                Console.Write(" ");
            }
            i--;
        }
    }
}
