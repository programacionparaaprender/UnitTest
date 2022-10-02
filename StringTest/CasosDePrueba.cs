using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace StringTest
{
    [TestFixture]
    public class CasosDePrueba
    {
        [Test]
        [TestCase(new int[] { 3, 7, 1, 4, 5, 6, 2 }, 2)]
        [TestCase(new int[] { 7, 6, 5, 4, 3, 2, 1 }, 1)]
        public void SortOrdenaElementos(int[] elementos, int ultimo)
        {
            //var list = new List<int>(new int[]{3, 7, 1, 4, 5, 6, 2});
            var list = new List<int>(elementos);

            /* for (var i = 0; i < list.Count - 1; i++)
            {
                Assert.LessOrEqual(list[i], list[i + 1]);
            }  */
            list.Sort();
            Assert.AreEqual(ultimo, list[^1]);
        }
        [Test]
        [TestCase(new int[] { 3, 7, 1, 4, 5, 6, 2 })]
        [TestCase(new int[] { 7, 6, 5, 4, 3, 2, 1 })]
        public void SortOrdenaElementos(int[] elementos)
        {
            //var list = new List<int>(new int[]{3, 7, 1, 4, 5, 6, 2});
            var list = new List<int>(elementos);

            for (var i = 0; i < list.Count - 1; i++)
            {
                //valor es menor o igual
                Assert.LessOrEqual(list[i], list[i + 1]);
            } 
        }
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        public void SortOrdenaElementosCuandoYaEstanOrdenados1(int[] elementos)
        {
            var list = new List<int>(elementos);
            for (var i = 0; i < list.Count - 1; i++)
            {
                Assert.LessOrEqual(list[i], list[i + 1]);
            }
        }

        [Test]
        public void SortOrdenaElementosCuandoYaEstanOrdenadosALaInversa()
        {
            var list = new List<int>(new int[] { 7, 6, 5, 4, 3, 2, 1 });
            for (var i = 0; i < list.Count - 1; i++)
            {
                Assert.LessOrEqual(list[i], list[i + 1]);
            }
        }
    }
}