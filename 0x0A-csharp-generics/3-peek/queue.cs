using System;

/// <summary>
/// Class Queue.
/// </summary>
/// <typeparam name="T">Queue type</typeparam>
class Queue<T>
{
    /// <summary>
    /// Variable tail of Node type set to null
    /// </summary>
    public Node tail = null;
    
    /// <summary>
    /// Head object of type Node
    /// </summary>
    public Node head = null;
    
    /// <summary>
    /// Count type int
    /// </summary>
    public int count = 0;

    /// <summary>
    /// Check type of queue.
    /// </summary>
    /// <returns>Queue type.</returns>
    public Type CheckType()
    {
        return(typeof(T));
    }

    /// <summary>
    /// Class Node.
    /// value: any type, set to null.
    /// next: Node type, set to null.
    /// constructor that takes value for new Node as only parameter.
    /// </summary>
    public class Node {
        /// <summary>
        /// Variable value of any type set to null.
        /// </summary>
        public T value;

        /// <summary>
        /// Variable next of Node type set to null
        /// </summary>
        public Node next = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="value">Node value.</param>
        public Node(T value)
        {
            this.value = value;
        }
    }
        


    /// <summary>
    /// Method Enqueue to create new Node and add to end of queue.
    /// If queue is empty, make new node the head of queue.
    /// Count is incremented each time new Node is added
    /// </summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (this.head == null)
        {
            this.head = newNode;
            this.tail = newNode;
        }
        else
        {
            this.tail.next = newNode;
            this.tail = newNode;
        }
        this.count++;
    }
        
    /// <summary>
    /// Method Count returns number of nodes in the Queue.
    /// </summary>
    /// <returns>Number of nodes in the Queue.</returns>
    public int Count()
    {
        return(this.count);
    }

    /// <summary>
    /// Method Dequeue removes the first Node in queue and returns its value.
    /// If queue is empty, write 'Queue is empty' to console and return default
    /// of parameters type.
    /// </summary> 
    public T Dequeue()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }
        else
        {
            Node temp = this.head;
            this.head = this.head.next;
            this.count--;
            return(temp.value);
        }
    }

    /// <summary>
    /// Method Peek returns the value of the first node of the queue without removing the node.
    /// If queue is empty write 'Queue is empty' to console and return
    /// default value of parameters type.
    /// </summary>
    public T Peek()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }
        else
        {
            return(this.head.value);
        }
    }
}
