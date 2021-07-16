using System;
class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        
        int row = myMatrix.GetLength(0);
        int column = myMatrix.GetLength(1);
        int[,] newMatrix = new int[row, column];

        for (int x = 0; x < row; x++)
        {
            for (int y = 0; y < column; y++)
            {
                newMatrix[x, y] = myMatrix[x, y] * myMatrix[x, y];
            }
        }
        return (newMatrix);
    }
}
