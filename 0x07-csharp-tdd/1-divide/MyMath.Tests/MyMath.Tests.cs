using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void CalculateALotDivisors()
        {
            int[,] testMatrix = new int[,]{{98, 0, -12}, {21, 972, 44}, {-727, 60, -2}};
            int[,] testMatrix1 = new int[,]{{2, 2, 2}, {4, 6, 8}, {10, 12, 10}};

            int num = 0;
            int num1 = 2;
            
            Assert.AreEqual(null, Matrix.Divide(testMatrix, num));
            Assert.AreEqual(new int[,]{{1, 1, 1}, {2, 3, 4}, {5, 6, 5}}, Matrix.Divide(testMatrix1, num1));
            Assert.IsNull(Matrix.Divide(null, num1));
        }
    }
}
