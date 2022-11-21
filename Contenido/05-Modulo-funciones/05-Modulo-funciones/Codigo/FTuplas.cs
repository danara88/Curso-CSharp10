namespace _05_Modulo_funciones.Codigo
{
    public class FTuplas
    {
        public void CodigoDelCurso()
        {
            // Tupla: Conjunto de valores que podemos guardar en una variable

            // Ejemplo 1

            var tupla = (10, 82, "Fluffy"); // Tupla de 3 elementos

            Console.WriteLine(tupla);

            Console.WriteLine(tupla.Item1);
            
            Console.WriteLine(tupla.Item2);

            Console.WriteLine(tupla.Item3);

            // Ejemplo 2

            (int edadDaniel, int edadPedro, string nombrePerro) tuplaV2 = (22, 45, "Fluffy");

            Console.WriteLine(tuplaV2.edadDaniel);

            Console.WriteLine(tuplaV2.edadPedro);

            Console.WriteLine(tuplaV2.nombrePerro);

            // Ejemplo 3

            (int duplo, int triplo) DuplicarYTriplicar(int valor) {

                return (valor * 2, valor * 3);

            }

            var cantidad = 20;
            var resultado = DuplicarYTriplicar(cantidad);

            Console.WriteLine("Duplo: " + resultado.duplo);

            Console.WriteLine("Triplo: " + resultado.triplo);
        }
    }
}
