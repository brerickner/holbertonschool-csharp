using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void testUniqs()
        {
            string stringy = "helloworld";
            string stringy2 = "";
            string stringy3 = "meow";
            string stringy4 = "hheey";
            string stringy5 = "noon";
            string stringy6 = "bob";


            Assert.AreEqual(0, Str.UniqueChar(stringy));
            Assert.AreEqual(-1, Str.UniqueChar(stringy2));
            Assert.AreEqual(0, Str.UniqueChar(stringy3));
            Assert.AreEqual(4, Str.UniqueChar(stringy4));
            Assert.AreEqual(-1, Str.UniqueChar(stringy5));
            Assert.AreEqual(1, Str.UniqueChar(stringy6));
        }
    }
}