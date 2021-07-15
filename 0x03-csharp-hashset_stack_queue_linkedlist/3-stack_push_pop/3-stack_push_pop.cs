using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Boolean condition = true;

        if (aStack == null)
        {
            System.Console.WriteLine("Stack is empty");
            // aStack = new Stack<string>;
        }
        System.Console.WriteLine($"Number of items: {aStack.Count}");
        if (aStack.Count > 0)
            System.Console.WriteLine($"Top item: {aStack.Peek()}");
        else
            System.Console.WriteLine("Stack is empty");

        if (aStack.Contains(search) == condition)
        {
            System.Console.WriteLine($"Stack contains \"{search}\": {true}");
            while (aStack.Contains(search) == condition && aStack.Count > 0)
            {
                aStack.Pop();
            }
        }
        else
            System.Console.WriteLine($"Stack contains \"{search}\": {false}");

        if(newItem != null)
            aStack.Push(newItem);
        return (aStack);
    }
}
