namespace _04_Modulo_Mas_sobre_TiposDatos.Codigo
{
    public class FArreglosMultidimensionales
    {

        public void CodigoDelCurso()
        {
            // Matriz de 2 filas y 2 columnas
            int[,] matriz = new int[2, 2];
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[1, 0] = 3;
            matriz[1, 1] = 4;
            
            // Matriz de 4 fila con 2 columnas
            int[,] matrizV2 = new int[,]
            {
                {5, 6},   // Primera fila
                {7, 8},   // Segunda fila
                {9, 10},  // Tercera fila
                {10, 11}, // Cuarta fila
            };

            // Recorrer una matriz
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for(int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna]);
                }
                Console.WriteLine();
            }
        }
    }
}
