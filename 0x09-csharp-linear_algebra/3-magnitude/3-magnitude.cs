using System;

/// <summary>
/// Vector math
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates length of a vector
    /// </summary>
    /// <param name="vector">Vector</param>
    /// <returns>Length of vector</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            double result2D = 0;
            result2D = vector[0] * vector[0];
            result2D += (vector[1] * vector[1]);
            return (Math.Round(Math.Sqrt(result2D), 2));

        }
        if (vector.Length == 3)
        {
            double[] result3D = 0;
            result3D = vector[0] * vector[0];
            result3D += (vector[1] * vector[1]);
            result3D += (vector[2] * vector[2]);
            return (Math.Round(Math.Sqrt(result3D), 3));
        }
        else
        {
            return (-1);
        }
    }
}
