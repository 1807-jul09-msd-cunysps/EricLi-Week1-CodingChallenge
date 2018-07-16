using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromTest;

namespace PalimdromeTest
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void TestMethod0()
        {
            string testObject = "A nut for a jar of tuna.";
            Assert.IsTrue(Palindrom.Test(testObject.Trim().ToLower().Trim()));
        }
        [TestMethod]
        public void TestMethod1()
        {
            string testObject = "Borrow or rob";
            Assert.IsTrue(Palindrom.Test(testObject.ToLower().Trim()));

        }
        [TestMethod]
        public void TestMethod2()
        {
            string testObject = "343";
            Assert.IsTrue(Palindrom.Test(testObject.Trim().ToLower().Trim()));

        }
    }
}
