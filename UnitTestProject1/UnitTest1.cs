using Calculator2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;
        [TestInitialize]
        /*
         Test input: 10, 5
        */
        public void Setup() 
        {
            cal = new Calculation(10, 5);
        }

        [TestMethod]
        public void TestAddOperator()
        {
            int expected = 15;
            int actual = cal.Execute("+");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubOperator()
        {
            //Output: 5
            int expected = 5;
            int actual = cal.Execute("-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMulOperator()
        {
            //Output: 50
            int expected = 50;
            int actual = cal.Execute("*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivOperator()
        {
            //Output: 2
            int expected = 2;
            int actual = cal.Execute("/");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivByZero()
        {
            //Output: 2
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
    }
}
