﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (myList == null)
            return (null);

        if (index >= myList.Count || index < 0)
        {
            System.Console.WriteLine("Index is out of range");
            return (myList);
        }
        myList.Remove(myList[index]);
        return (myList);
    }
}
