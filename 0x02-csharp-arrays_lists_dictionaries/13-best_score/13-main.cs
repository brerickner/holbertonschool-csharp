using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();

        myDict.Add("Alex", 0);

        Console.WriteLine("Best Score: {0}", Dictionary.BestScore(myDict));
    }
}
