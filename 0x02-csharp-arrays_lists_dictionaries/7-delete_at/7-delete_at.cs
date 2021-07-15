using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (myList == null || myList.Count == 0)
            return (null);

        if (index < 0 || index > myList.Count - 1)
        {
            System.Console.WriteLine("Index is out of range");
            return (myList);
        }
        myList.Remove(myList[index]);
        return (myList);
    }
}
