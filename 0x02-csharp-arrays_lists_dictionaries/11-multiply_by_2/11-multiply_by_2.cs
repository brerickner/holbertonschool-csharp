using System;
using System.Collections.Generic;
class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> legitDict = new Dictionary<string, int>(myDict);
        foreach (var val in myDict)
        {
            legitDict[val.Key] = val.Value * 2;
        }
        return (legitDict);
    }
}
