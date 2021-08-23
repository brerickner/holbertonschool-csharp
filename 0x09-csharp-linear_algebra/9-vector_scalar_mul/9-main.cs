using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = { 0, -16, 31 };
        double[] scalar = 4;
        double[] result;

        result = VectorMath.Multiply(vector1, scalar);

        // Console.WriteLine("(" + result[0] + ", " + result[1] + ")");
        Console.WriteLine("(" + result[0] + ", " + result[1] + ", " + result[2] + ")");
        // Console.WriteLine("(" + result[0] + ")");
    }
}
