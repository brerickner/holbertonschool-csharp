using System;

/// <summary>
/// Class Queue.
/// </summary>
/// <typeparam name="T">Queue type</typeparam>
class Queue<T>
{
    /// <summary>
    /// Check type of queue.
    /// </summary>
    /// <returns>Queue type.</returns>
    public Type CheckType()
    {
        return(typeof(T));
    }
}

