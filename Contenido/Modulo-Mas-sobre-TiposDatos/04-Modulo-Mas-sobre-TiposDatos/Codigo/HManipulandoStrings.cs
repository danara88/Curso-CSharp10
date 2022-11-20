namespace _04_Modulo_Mas_sobre_TiposDatos.Codigo
{
    public class HManipulandoStrings
    {
        public void CodigoDelCurso()
        {
            // Manipulando strings
            var name = "Daniel";

            var nameMayusuclas = name.ToUpper();

            var nameMinusculas = name.ToLower();

            // Uso de Trim

            var mensaje = "123Hola munda345";

            char[] numeros = new char[] { '0', '1', '2', '3', '4', '5', '6' };

            var mensajeArreglado = mensaje.Trim(numeros);

            Console.WriteLine(mensajeArreglado);

            // Uso de PadLeft (Agregar caracteres a la izquierda o derecha)

            long monto1 = 123;
            long monto2 = 4;

            Console.WriteLine(monto1.ToString().PadLeft(10, '0'));
            Console.WriteLine(monto2.ToString().PadLeft(10, '0'));
        }
    }
}
