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
        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        if ((matrix1.GetLength(0) == 3 && matrix2.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(1) == 3) || 
            (matrix1.GetLength(0) == 2 && matrix2.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(1) == 2))
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
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
