using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void testMax()
        {
            List<int> myNums = new List<int>{-5, 0, 1, -2};
            // List<int> myNums = new List<int>{-5, 0, 1, -2};
            // List<int> myNums = new List<int>{-5, 0, 1, -2};
            // List<int> myNums = new List<int>{-5, 0, 1, -2};



            Assert.AreEqual(1, MyMath.Operations.Max(myNums));
            // Assert.AreEqual(1, Operations.Max(myNums));
        }
    }
}