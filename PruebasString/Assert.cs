using System;

namespace PruebasString
{
    public class Assert
    {
        public static void Que(bool condicion)
        {
            if(!condicion){
                throw new Exception("Assertion error");
            }
        }
    }    
}