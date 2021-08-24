using System;

/// <summary>
/// Math for matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies matrix by scalar
    /// </summary>
    /// <param name="matrix">matrix</param>
    /// <param name="scalar">scalar</param>
    /// <returns>resulting matrix</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] nope = {{ -1 }};
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3 || matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i, j] = (matrix[i, j] * scalar);
                }
            }
            return result;
        }
        else 
        {
            return nope;
        }
    }
}
