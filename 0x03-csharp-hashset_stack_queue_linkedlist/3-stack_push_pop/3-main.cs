using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        aStack.Push("Physical");
        aStack.Push("Data Link");
        aStack.Push("Network");
        aStack.Push("Transport");
        aStack.Push("Session");
        aStack.Push("Presentation");

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyStack.Info(aStack, "Application", "Application");

        Console.WriteLine("------");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }
}
