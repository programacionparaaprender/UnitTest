using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace StringTest
{
    public class CuentaTest
    {
        private Cuenta cuenta;

        [SetUp]
        public void SetUp()
        {
            var titular = new Persona("Juan");
            this.cuenta = new Cuenta(titular);
        }

        [Test]
        public void AcreditarUnMontoNegativoNoEsValido()
        {
            var montoNegativo = -10;
            //la excepción esperada para poder pasar el test
            Assert.Throws<Exception>(() => this.cuenta.Acreditar(montoNegativo));
            
        }

        [Test]
        public void SeCreaConSaldoCero()
        {
            Assert.AreEqual(0, cuenta.Saldo);
        }

        [Test]
        public void AcreditarIncrementaElSaldo()
        {
            var saldoInicial = this.cuenta.Saldo;
            var monto = 10;
            
            cuenta.Acreditar(monto);
            Assert.AreEqual(saldoInicial, cuenta.Saldo);
        }
        [Test]
        public void DebitarDecrementaElSaldo()
        {
            var monto = 10;
            var saldoFinalEsperado = this.cuenta.Saldo - monto;
            this.cuenta.Debitar(monto);
            Assert.AreEqual(saldoFinalEsperado, cuenta.Saldo);
        }

    }
}