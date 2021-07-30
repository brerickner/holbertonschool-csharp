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
            int num = 0;
            int[,] resultMatrix = Matrix.Divide(testMatrix, num);
    
            Assert.AreEqual(null, resultMatrix);
        }
    }
}
