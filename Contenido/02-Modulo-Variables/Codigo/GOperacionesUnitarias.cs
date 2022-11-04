using System;
namespace _02_Modulo_Variables.Codigo
{
    public class GOperacionesUnitarias
    {
        public void CodigoDeLaClase()
        {
            var quantity1 = 7;

            var quantity2 = 5;

            // Primero se le suma 1 a quantity1 y despues se evalua la expresion
            var sum1 = ++quantity1 + quantity2;

            Console.WriteLine(sum1);

            // Primero se evalua la expresion, luego se le suma 1 a quantity1
            var sum2 = quantity1++ + quantity2;

            Console.WriteLine(sum2);
        }
    }
}

