using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSTest;

namespace UnitTestCalculadora
{
    [TestClass]
    public class UnitTestCal
    {
        [TestMethod]
        public void TestMethodSuma()
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Numero1 = 2;
            calculadora.Numero2 = 3;
            Assert.AreEqual(5, calculadora.Suma());
        }
    }
}
