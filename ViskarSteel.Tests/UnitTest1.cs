using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ViskarSteel.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1()
        {
            int a = 5;
            int b = 5;
            Assert.AreEqual(a, b, "Test Case 1 Passed");
        }

        [TestMethod]
        public void TestCase2()
        {
            string msg = "Hello";
            Assert.IsTrue(msg.Contains("Hell"));
        }
    }
}
