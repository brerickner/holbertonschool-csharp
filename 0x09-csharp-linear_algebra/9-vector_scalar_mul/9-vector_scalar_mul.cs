using System;
/// <summary>
/// Solving vector math
/// </summary>
class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] nope = {-1};
        double[] result2 = {0, 0};
        double[] result3 = {0, 0, 0};  
        
        if (vector.GetLength(0) == 2)
        {
            result2[0] = vector[0] * scalar;
            result2[1] = vector[1] * scalar;

            return (result2);
        }
        else if (vector.GetLength(0) == 3)
        {
            result3[0] = vector[0] * scalar;
            result3[1] = vector[1] * scalar;
            result3[2] = vector[2] * scalar;

            return (result3);
        }
        else
        {
            return (nope);
        }
    }
}
