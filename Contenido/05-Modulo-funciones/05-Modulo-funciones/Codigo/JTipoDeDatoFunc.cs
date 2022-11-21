namespace _05_Modulo_funciones.Codigo
{
    public class JTipoDeDatoFunc
    {
        public void CodigoDelCurso()
        {
            // Func: Es un tipo de dato donde podemos guardar en una variables funciones que retornan un valor

            // Ejemplo 1:

            Func<string> retornarString;

            string ObtenerFechaYHora()
            {
                return DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }

            retornarString = ObtenerFechaYHora;

            Console.WriteLine(retornarString());

            // Ejemplo 2:

            void Procesar(Func<string> productorDeValor)
            {
                Console.WriteLine("Linea anterior");

                var valor = productorDeValor();

                Console.WriteLine("El valor es " + valor);

                Console.WriteLine("Linea posterior");
            }

            Procesar(retornarString);

            Console.WriteLine();

            // Ejemplo 3:
            // Func que reciben parametros

            // Los primeros tipo de datos son los parametros.
            // El ultimo es el tipo de dato de salida
            Func<int, string> recibeIntRetornaString;

            string ObtenerNombreDelMes(int mes)
            {
                var fecha = new DateTime(2022, mes, 1);

                return fecha.ToString("MMM");
            }

            recibeIntRetornaString = ObtenerNombreDelMes;

            var mayo = recibeIntRetornaString(5);

            Console.WriteLine(mayo);
        }
    }
}
