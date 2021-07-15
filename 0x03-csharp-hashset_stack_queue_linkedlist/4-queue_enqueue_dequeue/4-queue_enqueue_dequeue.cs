using System;
using System.Collections.Generic;
using System.Linq;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Boolean condition = true;

        if (aQueue == null)
        {
            System.Console.WriteLine("Stack is empty");
            // aQueue = new Stack<string>;
        }
        System.Console.WriteLine($"Number of items: {aQueue.Count}");
        if (aQueue.Count > 0)
            System.Console.WriteLine($"Top item: {aQueue.Peek()}");
        else
            System.Console.WriteLine("Stack is empty");

        if (aQueue.Contains(search) == condition)
        {
            System.Console.WriteLine($"Stack contains \"{search}\": {true}");
            while (aQueue.Contains(search) == condition && aQueue.Count > 0)
            {
                aQueue.Dequeue();
            }
        }
        else
            System.Console.WriteLine($"Stack contains \"{search}\": {false}");

        if(newItem != null)
            aQueue.Enqueue(newItem);
        return (aQueue);
    }
}

