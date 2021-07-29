using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CalculateALotOfSums([Range(-20,100)] int x, [Range(-20,100)] int y)
        {
            int testSum = Operations.Add(x, y);
            int realSum = (x + y);
            Assert.AreEqual(testSum, realSum);
        }
    }
}
