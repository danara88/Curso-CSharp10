namespace _05_Modulo_funciones.Codigo
{
    public class DFuncionesParametrosComoReferencia
    {
        public void CodigoDelCurso()
        {
            // Ejemplo 1:
            // Los arreglos son de tipo de REFERENCIA (son mutables).
            // Los strings son de tipo de referencia pero son inmutables.

            var numeros = new int[] { 1, 2, 3, 4, };

            void DuplicarArreglo(int[] arreglo)
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    arreglo[i] *= 2;
                }
            }

            void ImprimirArreglo(int[] arreglo)
            {
                for (int i = 0; i < arreglo.Length; i++)
                {
                    Console.Write(arreglo[i]);
                }
            }

            Console.WriteLine("Valores del arreglo antes de duplicarlo");

            ImprimirArreglo(numeros);

            // Duplicando el arreglo ...
            DuplicarArreglo(numeros);

            Console.WriteLine();

            Console.WriteLine("Valores del arreglo despues de duplicarlo");

            ImprimirArreglo(numeros);

            Console.WriteLine();

            // Ejemplo 2:
            // Usando ref para tipos de valor

            int num = 2;

            void Duplicar(ref int n)
            {
                n *= 2;
                Console.WriteLine($"El valor dentro de la funcion es: {n}");
            }

            Console.WriteLine($"El valor fuera de la funcion es: {num}");

            Duplicar(ref num);

            Console.WriteLine($"El valor fuera de la funcion es: {num}");

        }
    }
}
