using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace StringTest
{
    [TestFixture]
    public class ResultadoTest
    {

        [Test]
        public void TestQuePasa()
        {
            Assert.Pass();
        }

        [Test]
        public void TestQueFalla()
        {
            var valor = 5;
            Assert.AreEqual(4, valor);
        }

        [Test]
        public void TestInconcluso()
        {
            Assert.Inconclusive();
        }

        [Test, Ignore("Desactivado temporalmente por ....")]
        public void TestIgnorado()
        {
            Assert.Ignore();
        }

    }
}
