using System;
/// <summary>
/// Vector math
/// </summary>
class VectorMath
{
    /// <summary>
    /// calculates dot product of either two 2D or two 3D vectors.
    /// </summary>
    /// <param name="vector1">vector 1</param>
    /// <param name="vector2"> vector 2</param>
    /// <returns>dot product</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
        {
            double[] nope = {-1};
            double result2 = {0};
            double result3 = {0}; 

            if (vector1.GetLength(0) == 2 && vector2.GetLength(0) == 2)
            {
                result2 = ((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]));

                return (result2);
            }
            else if (vector1.GetLength(0) == 3 && vector2.GetLength(0) == 3)
            {
                result3 = ((vector1[0] * vector2[0]) + (vector1[1] * vector2[1]) + (vector1[2] * vector2[2]));

                return (result3);
            }
            else
            {
                return (nope);
            }
    }
}
