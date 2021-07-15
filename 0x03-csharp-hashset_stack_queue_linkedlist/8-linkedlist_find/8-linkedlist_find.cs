using System;
using System.Collections.Generic;
class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int counter = 0;
        for (var node = myLList.First; node != null; node = node.Next, counter++)
        {
            if (value.Equals(node.Value))
                return (counter); 
        }
        return (-1);
    }
}
