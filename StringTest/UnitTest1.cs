using NUnit.Framework;

namespace StringTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PruebaQueStringHolaTieneLongitud4(){
            // arrange
            string stringHola = "Hola";
            var longitud = stringHola.Length;
            
            //assert
            Assert.AreEqual(longitud, 4);
            /* if(longitud != 4){
                throw new Exception("Prueba fallida");
            } */
        }

        [Test]
        public void PruebaQueStringHolaContieneCaracterA(){
            // arrange
            string stringHola = "Hola";
            bool contieneLetraA = stringHola.Contains("a");
            
            //assert
            Assert.IsTrue(contieneLetraA);
            /* if(!contieneLetraA){
                throw new Exception("Prueba fallida");
            } */
        }
    }
}