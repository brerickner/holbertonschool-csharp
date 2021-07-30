using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void testPals()
        {
            string stringy = "helloworld";
            string stringy2 = "";
            string stringy3 = "meow";
            string stringy4 = "kayak";
            string stringy5 = "noon";
            string stringy6 = "bob";


            Assert.AreEqual(false, Str.IsPalindrome(stringy));
            Assert.AreEqual(true, Str.IsPalindrome(stringy2));
            Assert.AreEqual(false, Str.IsPalindrome(stringy3));
            Assert.AreEqual(true, Str.IsPalindrome(stringy4));
            Assert.AreEqual(true, Str.IsPalindrome(stringy5));
            Assert.AreEqual(true, Str.IsPalindrome(stringy6));
        }
    }
}