using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = { -4, 0, 10 };
        double[] vector2 = { 3, 7, -9 };
        double result;

        result = VectorMath.DotProduct(vector1, vector2);

        // Console.WriteLine("(" + result[0] + ", " + result[1] + ")");
        Console.WriteLine("(" + result[0] + ", " + result[1] + ", " + result[2] + ")");
        // Console.WriteLine("(" + result[0] + ")");
    }
}
