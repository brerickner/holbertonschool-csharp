using System;

/// <summary>
/// Math for matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// adds two matrices
    /// </summary>
    /// <param name="matrix1">matrix 1</param>
    /// <param name="matrix2">matrix 2</param>
    /// <returns>resulting matrix</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[] nope = { -1 };
        double[] result;

        if (matrix1.GetLength(0) == matrix2.GetLength(1))
        {
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    result2[i][j] = (matrix1[i][j] + matrix2[i][j]);
                }
            }
            return result2;
        }
        else 
        {
            return nope;
        }
    }
}
