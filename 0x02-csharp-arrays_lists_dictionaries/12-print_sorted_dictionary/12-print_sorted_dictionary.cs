using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var myList = myDict.Keys.ToList();
        myList.Sort();
        foreach (string keyz in myList)
        {
            System.Console.WriteLine($"{keyz} : {myDict[keyz]}");
        }
    }
}
