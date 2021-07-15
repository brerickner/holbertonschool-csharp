using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "python");
        myDict.Add("track", "high level");
        myDict.Add("school", "Holberton");
        myDict.Add("address", "98 Battery St.");
        myDict.Add("city", "San Francisco");

        Dictionary.PrintSorted(myDict);
    }
}
