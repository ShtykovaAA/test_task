
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 test = new Class1();
            double ans = test.CircleArea(1);
            Assert.AreEqual(ans, 3.14);
        }
        
    }
}
