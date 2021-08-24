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
        double[,] nope = {{ -1 }};
        double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        double hold;

        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            for (int i = 0; i < matrix1.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix2.GetLength(1) - 1; j++)
                {
                    int flag = 0;
                    hold = 0;

                    while (flag < matrix1.GetLength(1) && flag < matrix2.GetLength(0))
                    {
                        hold += (matrix1[i, flag] * matrix2[flag, j]);
                        flag++;
                        
                    }
                    result[i, j] = hold;
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
