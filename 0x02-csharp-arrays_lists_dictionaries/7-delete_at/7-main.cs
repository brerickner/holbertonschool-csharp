using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {};

        foreach (int i in myList)
            Console.WriteLine(i);

        Console.WriteLine("----------");

        List.DeleteAt(myList, 0);

        foreach (int i in myList)
            Console.WriteLine(i);
    }
}
