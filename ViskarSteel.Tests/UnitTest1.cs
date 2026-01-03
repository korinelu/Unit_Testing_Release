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

        [TestMethod]
        public void TestCase3()
        {
            var calc = new Calculator();
            int result = calc.Add(5, 5); // This call triggers the coverage!
            Assert.AreEqual(10, result);
        }
    }
}
