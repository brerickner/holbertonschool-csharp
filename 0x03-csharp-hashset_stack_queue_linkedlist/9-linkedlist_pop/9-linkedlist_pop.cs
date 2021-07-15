using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        var headVal = 0;

        if (myLList.Count < 0)
            return (0);
        headVal = myLList.First.Value;
        myLList.Remove(myLList.First);
        
        return (headVal);
    }
}
