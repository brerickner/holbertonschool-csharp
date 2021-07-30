using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void CalculateALotDivisors([Range(-20,100)] int[,] MatriX, [Range(-20,100)] int x)
        {
            int[,] testMatrix = new int[MatriX.GetLength(0), MatriX.GetLength(1)];
            int[,] origMatrix = Matrix.Divide(matrix, x);
            int [,] testMatrix = MatriX[x,y] / x;
            Assert.AreEqual(origMatrix, testMatrix);
        }
    }
}
