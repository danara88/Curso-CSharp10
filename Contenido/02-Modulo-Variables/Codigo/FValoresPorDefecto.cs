using System;
namespace _02_Modulo_Variables.Codigo
{
    public class FValoresPorDefecto
    {
        public void CodigoDeLaClase()
        {
            int intDefaultValue = default;

            string? stringDefaultValue = default;

            bool boolDefaultValue = default;

            Console.WriteLine(intDefaultValue); // 0

            Console.WriteLine(stringDefaultValue); // " " empty

            Console.WriteLine(boolDefaultValue); // false
        }
    }
}

