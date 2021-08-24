using System;

/// <summary>
/// Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices
    /// </summary>
    /// <param name="matrix1">matrix 1</param>
    /// <param name="matrix2">matrix 2</param>
    /// <returns>resulting matrix. Else -1</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        /// The number of columns of the 1st matrix must equal the number of rows of the 2nd matrix.
        /// And the result will have the same number of rows as the 1st matrix,
        /// and the same number of columns as the 2nd matrix.
        
        double[,] nope = {{ -1 }};
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    result[i, j] = ((matrix1[i, j] * matrix2[i, j]) + (matrix1[i + 1, j] * matrix2[i, j + 1]));
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
