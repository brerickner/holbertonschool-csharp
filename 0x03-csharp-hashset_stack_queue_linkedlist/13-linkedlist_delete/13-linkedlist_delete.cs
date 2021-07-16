using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> nodez = myLList.First;
        int i = 0;
        for (; i <= index && nodez != null;i++, nodez=nodez.Next)
        {
            if (index == i)
            {
                myLList.Remove(nodez);
            }
        }
    }
}

