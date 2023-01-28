namespace _10_Modulo_Linq.Codigo
{
    public class BEjecucionDiferida
	{
		public static void CodigoDelCurso()
		{
			int[] numbers = Enumerable.Range(1, 5).ToArray();

			// Paso 1: Ejecución diferida
			var peerNumbers = numbers.Where(x =>
			{
				// Esto no se va a ejecutar hasta que ejecutemos el foreach
				// Si no haces una consulta sobre el IEnumerable, no se va a ejcutar (Ejecución diferida)
				Console.WriteLine($"Evaluando si {x} es par");
				return x % 2 == 0;

			}).ToList(); // Usando el ToList, no lo ejecutará como ejecución diferida

			Console.WriteLine();

			foreach (var item in peerNumbers)
			{
				Console.WriteLine($"El numero {item} es par");
			}

			Console.WriteLine();
        }
	}
}

