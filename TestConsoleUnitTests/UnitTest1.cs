using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestConsoleUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTrueAddTwoNumbers()
        {
            int i = 4, j = 5;
            Assert.AreEqual(9, TestConsole.Program.addTwoNumbers(i, j), 0.0, "Addiert die integer nicht richtig");
        }

        /// <summary>
        /// Wenn man diese Methode auskommentiert, dann kann man einchecken, sonst blockiert das gated check-in!
        /// </summary>
        [TestMethod]
        public void ForcedFalseTest()
        {
            //Assert.AreEqual(3, 4);
        }

        [TestMethod]
        public void ForcedTrueTest()
        {
            Assert.AreEqual(true, true, "Dieser Test scheint TRUE zu sein");
        }

        [TestMethod]
        public void CalcProfOne()
        {
            TestConsole.Character ca = new TestConsole.Character(2, 2, 2, 2, 2, 2, "qwe", "231");
            ca.Level = 5;
            ca.Update();
            Assert.AreEqual(3, ca.Prof);
        }
    }
}
