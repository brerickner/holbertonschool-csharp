using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = { 9, 2, -12 };
        double[] vector2 = { 22, -1, 0 };
        double[] result;

        result = VectorMath.Add(vector1, vector2);

        // Console.WriteLine("(" + result[0] + ", " + result[1] + ")");
        Console.WriteLine("(" + result[0] + ", " + result[1] + ", " + result[2] + ")");
        // Console.WriteLine("(" + result[0] + ")");
    }
}
