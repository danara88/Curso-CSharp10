using System;
namespace _10_Modulo_Linq.Codigo
{
	public class AQueEsLinq
	{
		public static void CodigoDelCurso()
		{
			int[] numbers = Enumerable.Range(1, 5).ToArray();

			// Sacando numeros pares LINQ (Sintaxis de métodos)
			var peerNumbers = numbers.Where(x => x % 2 == 0).ToList();

			// Sacando numeros pares LINQ (Sintaxis de queries)
			var peerNumbersQuerie = (from n in numbers
									 where n % 2 == 0
									 select n).ToList();
		}
	}
}

