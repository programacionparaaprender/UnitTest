using System;
using System.Reflection;


namespace PruebasString
{
    class Program
    {
        static void Main(string[] args)
        {
            var metodos = typeof(Program).GetMethods(BindingFlags.Public | BindingFlags.Static );
            var pruebasExitosas = 0;
            var pruebasFallidas = 0;
            foreach (var metodo  in metodos)
            {
                if (metodo.Name.StartsWith("Prueba"))
                {
                    try
                    {
                        metodo.Invoke(null, null);
                        pruebasExitosas++;
                    }
                    catch
                    {
                        pruebasFallidas++;
                    }

                }
            }
            Console.WriteLine($"Prueba existosas #{pruebasExitosas}");
            Console.WriteLine($"Prueba fallidas #{pruebasFallidas}");
            //PruebaQueStringHolaTieneLongitud4();
            //PruebaQueStringHolaContieneCaracterA();
            Console.WriteLine("Hello World!");
        }
        public static void PruebaQueStringHolaTieneLongitud4(){
            // arrange
            string stringHola = "Hola";
            var longitud = stringHola.Length;
            
            //assert
            Assert.Que(longitud != 4);
            /* if(longitud != 4){
                throw new Exception("Prueba fallida");
            } */
        }

        public static void PruebaQueStringHolaContieneCaracterA(){
            // arrange
            string stringHola = "Hola";
            bool contieneLetraA = stringHola.Contains("a");
            
            //assert
            Assert.Que(!contieneLetraA);
            /* if(!contieneLetraA){
                throw new Exception("Prueba fallida");
            } */
        }

        public static void PruebaXXXXXX()
        {
            
        }

    }
}
