using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircle1()
        {
            Class1 test = new Class1();
            double ans = test.CircleArea(1);
            Assert.AreEqual(ans, 3.14);
        }
        [TestMethod]
        public void TestCircle2() //radius is 0
        {
            Class1 test = new Class1();
            double ans = test.CircleArea(0);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void TestCircle3() //negative radius
        {
            Class1 test = new Class1();
            double ans = test.CircleArea(-12);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void TestCircle4() 
        {
            Class1 test = new Class1();
            double ans = test.CircleArea(2.5);
            Assert.AreEqual(ans, 19.625);
        }
        [TestMethod]
        public void TestCircle5()
        {
            Class1 test = new Class1();
            double ans = test.CircleArea(4);
            Assert.AreEqual(ans, 50.24);
        }
        [TestMethod]
        public void TestTriangle1()
        {
            Class1 test = new Class1();
            double ans = test.TriangleArea(-1, 1, 1);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void TestTriangle2()
        {
            Class1 test = new Class1();
            double ans = test.TriangleArea(1, -12, -1);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void TestTriangle3()
        {
            Class1 test = new Class1();
            double ans = test.TriangleArea(0, 2, 1);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void TestTriangle4()
        {
            Class1 test = new Class1();
            double ans = test.TriangleArea(10, 10, 30);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void TestTriangle5()
        {
            Class1 test = new Class1();
            double ans = test.TriangleArea(30, 10, 10);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void TestTriangle6()
        {
            Class1 test = new Class1();
            double ans = test.TriangleArea(10, 20, 10);
            Assert.AreEqual(ans, -1);
        }
        [TestMethod]
        public void TestTriangle7()
        {
            Class1 test = new Class1();
            double ans = test.TriangleArea(1, 1, 1);
            Assert.AreEqual(ans, 0.4330127018922193);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestClass1()
        {
            Class2 test = new Class2();
            bool ans = test.IsPositive(2);
            Assert.AreEqual(ans, true);
        }
        /*
        [TestMethod]
        public void TestCLass2()
        {
            Class2 test = new Class2();
            bool ans = test.IsEqual(-2);
            Assert.AreEqual(ans, true);
        }
        */
    }
}
