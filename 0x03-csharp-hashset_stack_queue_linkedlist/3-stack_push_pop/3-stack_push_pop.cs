using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Boolean condition = true;

        if (aStack == null || aStack.Count <= 0)
            System.Console.WriteLine("Stack is empty");
    
        System.Console.WriteLine($"Number of items: {aStack.Count}");
        System.Console.WriteLine($"Top item: {aStack.Peek()}");

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
        aStack.Push(newItem);
        return (aStack);
    }
}
