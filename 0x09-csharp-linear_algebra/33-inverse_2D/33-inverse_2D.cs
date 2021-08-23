using System;
/// <summary>
/// Class matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Get's inverse matrix of 2d matrix
    /// </summary>
    /// <param name="matrix">the matrix</param>
    /// <returns>inversed matrix of -1 if not inversible or not 2d</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return(-1);
    }
}
