using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keys_plz = 0;
        foreach (var keys in myDict)
        {
            keys_plz++;
        }
        return(keys_plz);
    }
}
