using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNodez = myLList.First;
    
        for (;newNodez != null;newNodez = newNodez.Next)
        {
            if (newNodez.Value > n)
            {
                myLList.AddBefore(newNodez, n);
                return (newNodez);
            }
        }
        myLList.AddLast(n);
        return(newNodez);
    }
}
