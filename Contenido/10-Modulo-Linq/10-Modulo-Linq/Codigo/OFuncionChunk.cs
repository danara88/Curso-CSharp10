namespace _10_Modulo_Linq.Codigo
{
    /**
	 * Podemos dividir una coleccion en distintas partes utilizando Chunk
	 */
    public class OFuncionChunk
	{
        public static void CodigoDelCurso()
        {
			int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var resultado = numeros.Chunk(3);
		}
	}
}

