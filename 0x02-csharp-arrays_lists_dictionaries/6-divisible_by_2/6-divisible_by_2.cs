using System;
using System.Collections.Generic;
class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        if (myList == null)
            return (null);
        List<bool> listy = new List<bool>();
        foreach  (int thing in myList)
        {
            if (thing % 2 == 0)
                listy.Add(true);
            else
                listy.Add(false);
        }
        return (listy);
    }
}

