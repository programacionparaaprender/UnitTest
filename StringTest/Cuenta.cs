using System;


namespace StringTest
{
    public class Cuenta
    {
        private Persona _titular;
        private decimal _saldo;
        private decimal _monto;
        public Cuenta(Persona titular){
            this._titular = titular;
            this._saldo = 0;
        }

        public Cuenta()
        {

        }

        public Persona Titular
        {
            get{
                return this._titular;
            }
            set{
                this._titular = value;
            }
        }

        public decimal Saldo{
            get{
                return this._saldo;
            }
            set{
                this._saldo = value;
            }
        }

        public void Acreditar(decimal monto){
            if(monto < 0){
                throw new Exception();
            }
            this._saldo += monto;

        }
        public void Debitar(decimal monto)
        {
            this._saldo -= monto;
        }

    }
}