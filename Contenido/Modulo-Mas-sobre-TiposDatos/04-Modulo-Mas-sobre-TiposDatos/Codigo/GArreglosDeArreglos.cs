using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Modulo_Mas_sobre_TiposDatos.Codigo
{
    public class GArreglosDeArreglos
    {
        public void CodigoDelCurso()
        {
            int[][] arreglosDeArreglo =
            {
                new int[] {1,2,3,4},
                new int[] {5,6,7,8}
            };

            for(int fila = 0; fila < arreglosDeArreglo.Length; fila++)
            {
                var arreglo = arreglosDeArreglo[fila];
                for(int columna = 0; columna < arreglo.Length; columna++)
                {
                    Console.Write(arreglo[columna]);
                }
                Console.WriteLine();
            }
        }
    }
}
