using System;


namespace StringTest
{
    public class Persona
    {
        public string _nombre;
        
        public Persona(string nombre)
        {
            this._nombre = nombre;
        }
        
        public Persona(){

        }

        public string Nombre{
            get{
                return this._nombre;
            }
            set{
                this._nombre = value;
            }
        }

    }
}