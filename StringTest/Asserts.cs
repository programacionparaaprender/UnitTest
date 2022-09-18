using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace StringTest
{
    [TestFixture]
    public class Asserts
    {

        [Test]
        public void ArrayListSeCreaVacio()
        {
            var array = new ArrayList();
            //Assert.AreEqual(0, array.Count);
            Assert.IsEmpty(array);
        }
        
        [Test]
        public void ArrayListContieneItem()
        {
            var array = new ArrayList(new int[]{1, 2});
            Assert.IsTrue(array.Contains(1));
        }

        [Test]
        public void StringHolaNoEsVacio()
        {
            var hola = "hola";
            //Assert.IsTrue(hola != string.Empty);
            Assert.That(hola, Is.Not.Empty);
        }

        [Test]
        public void StringHolaTieneLongitud4()
        {
            var hola = "hola";
            //Assert.AreEqual(4, hola.Length);
            Assert.That(hola.Length, Is.EqualTo(4));
        }

        [Test]
        public void StringHolaContieneH()
        {
            var hola = "hola";
            //Assert.IsTrue(hola.Contains("h"));
            Assert.That(hola.Contains("h"));
        }

    }
}