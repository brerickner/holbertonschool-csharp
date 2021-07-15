using System;
using System.Collections.Generic;
class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        if (myDict == null)
            return (null);
        if (myDict.ContainsKey(key))
            myDict.Add(key, myDict[key]);
        else
            myDict.Add(key, value);

        return(myDict);
    }
}
