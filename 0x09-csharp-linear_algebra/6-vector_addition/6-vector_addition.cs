using System;
/// <summary>
/// class for mathing vectors
/// </summary>
class VectorMath
{
    /// <summary>
    /// Adds two vectors
    /// </summary>
    /// <param name="vector1">first vector</param>
    /// <param name="vector2">second vector</param>
    /// <returns>resulting vector</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] result2 = {0, 0};
        double[] result3 = {0, 0, 0};  
        if (vector1.GetLength(0) == 2 && vector2.GetLength(0) == 2)
        {
            result2[0] = vector1[0] + vector2[0];
            result2[1] = vector1[1] + vector2[1];

            return (result2);
        }
        else if (vector1.GetLength(0) == 2 && vector2.GetLength(0) == 2)
        {
            result3[0] =vector1[0] + vector2[0];
            result3[1] =vector1[1] + vector2[1];
            result3[2] =vector1[2] + vector2[2];

            return (result3);
        }
        else
        {
            return (new double[] {-1});
        }
    }
}
