namespace _04_Modulo_Mas_sobre_TiposDatos.Codigo
{
    public class DCasteos
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1: Casteo explicito

            var number1 = 2;
            var number2 = 45;

            var division = (double)number1 / number2;

            Console.WriteLine($"La division es: {division}");

            // Ejemplo 2: Casteo explicito

            byte byte1; // 0 a 255
            int int1 = 7; // -2 000 000 a 2 mil millones

            checked
            {
                byte1 = (byte)int1;
            }

            // Ejemplo 3: Casteo implicito

            byte byte2 = 11; // El numero 11 cabe perfecto en tipo de dato byte (0 a 255)
            int int2;

            int2 = byte2; // Un tipo de dato "byte" cabe perfectamente en un tipo de dato "int"

            Console.WriteLine(int2);

        }
    }
}
