using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IM.BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("göksel")]
        public void TestMethod1()
        {
            
            Assert.AreEqual(7, 7);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        [Owner("göksel")]
        public void TestMethod2()
        {

            Assert.AreEqual(6, 6);
        }
    }
}
