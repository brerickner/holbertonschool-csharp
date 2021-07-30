using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void testUniqs()
        {
            string stringy = "helloworld";
            Assert.AreEqual(0, Str.UniqueChar(stringy));
        }
    }
}