using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        int[] num_array = new int[size];
        if (size == 0)
        {
            Console.WriteLine();
            return (num_array);
        }
        int i = 0;
        while (i < num_array.Length)
        {
            num_array[i] = i;
            Console.Write(num_array[i]);
            if (i < num_array.Length - 1)
                Console.Write(" ");
            i++;
        }
        Console.WriteLine();
        return (num_array);
    }
}
