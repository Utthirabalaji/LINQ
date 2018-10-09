using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionPractice;

namespace UTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Program", Program.GetHashMap());
        }
    }
}
