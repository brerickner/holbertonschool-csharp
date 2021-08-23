using System;

namespace _6_vector_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
using System;
/// <summary>
/// class for mathing vectors
/// </summary>
class VectorMath
{
    double[] result;
    /// <summary>
    /// Adds two vectors
    /// </summary>
    /// <param name="vector1">first vector</param>
    /// <param name="vector2">second vector</param>
    /// <returns>resulting vector</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.GetLength(0) != vector2.GetLength(0) || vector1.GetLength(1) != vector2.GetLength(1)
            || vector1.GetLength(0) > 3 || vector2.GetLength(1) > 3)
            return new double[] {-1};
        else if (vector1.GetLength(0) == 2 && vector2.GetLength(0) == 2)
        {
            result = 0;
            result[0] = vector1[0] + vector2[0];
            result[1] = vector1[1] + vector2[1];

            return result;
        }
        else
        {
            result[0] =vector1[0] + vector2[0];
            result[1] =vector1[1] + vector2[1];
            result[2] =vector1[2] + vector2[2];

            return result;
        }
    }
}
