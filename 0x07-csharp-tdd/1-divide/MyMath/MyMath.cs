using System;

namespace MyMath
{
    /// <summary>
    /// Matrix class
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides all elements of a matrix
        /// </summary>
        /// <param name="matrix">The matrix of ints</param>
        /// <param name="num">The number to divide by</param>
        /// <returns>New matrix of divided elements</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);
            int[,] newMatrix = new int[rowLength, colLength];

            for (var i = 0; i <rowLength; i++)
            { 
                for (var j = 0; j < colLength; j++)
                {
                    try
                    {
                        newMatrix[i,j] = matrix[i, j]/num;
                    }
                    catch 
                    {
                        return (null);
                    }
                }
            }
            return (newMatrix);
        }
    }
}

