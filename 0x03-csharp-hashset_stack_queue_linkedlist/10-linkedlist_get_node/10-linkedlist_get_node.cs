using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        var hold = 0;
        foreach(int val in myLList)
        {
            if (hold == n)
                return (val);
            hold++;
        }
        return (0);
    }
}
