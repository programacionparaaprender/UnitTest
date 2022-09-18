using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace StringTest
{
    [TestFixture]
    public class OrdenTest
    {
        [Test, Order(2)]
        [Category("Ejemplos")]
        public void Test1()
        {
            Console.WriteLine("Test1");
        }

        [Test, Order(1)]
        public void Test2()
        {
            Console.WriteLine("Test2");
        }
    }
}