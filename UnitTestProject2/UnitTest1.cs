using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        SimpleEquation cal;
        [TestMethod]
        public void THVoNghiem()
        {
            /*
             a,b: 0, 1
            VN
            */
            SimpleEquation s = new SimpleEquation(0, 1);
            Assert.AreEqual("VN", s.SingleEquation());
        }

        [TestMethod]
        public void THVoSoNghiem()
        {
            /*
             a,b: 0, 1
            VN
            */
            SimpleEquation s = new SimpleEquation(0, 0);
            Assert.AreEqual("VSN", s.SingleEquation());
        }

        [TestMethod]
        public void THMotNgiem()
        {
            /*
             a,b: 1, 2
            VN
            */
            SimpleEquation s = new SimpleEquation(2, 1);
            Assert.AreEqual("-0.5", s.SingleEquation());
        }
    }
}
