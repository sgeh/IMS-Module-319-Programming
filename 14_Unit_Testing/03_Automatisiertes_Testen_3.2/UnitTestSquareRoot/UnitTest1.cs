using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestSquareRoot
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double input = 25;
            double result = Bwz.Rappi.Program.CalculateSqrt(input);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestPythagorasSolution()
        {
            double a = 56;
            double b = 90;
            double c = Bwz.Rappi.Program.CalculatePythagorasC(a, b);
            Assert.AreEqual(106, c);
        }

        [TestMethod]
        public void TestPythagoras()
        {
            // TODO: Hier Test implementieren:
            //       Zugriff auf Bwz.Rappi.Program.CalculatePythagorasC(input);
            // Assert.AreEqual(106, c);
        }
    }
}
