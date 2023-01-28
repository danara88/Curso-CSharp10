using System;
namespace _09_Modulo_Genericos.Codigo
{
	/**
	 * La razón por la cuál podemos iterar un arreglo, un diccionario o una lista es por que estos tipos implementan
	 * una interfaz llamada IEnumerable.
	 * 
	 * Cuando implementan IEnumerable podemos usar el foreach para iterar.
	 * 
	 * OJO: Un IEnumerable solo te permite ITERAR (Enumerar)
	 */
	public class EIEnumerable
	{
		public static void CodigoDelCurso()
		{
			// Podemos iterarlo porque implementa IEnumerbale
			var numbers = new List<int>() { 1, 2, 3 };

            // Podemos iterarlo porque implementa IEnumerbale
            var names = new string[] { "Daniel", "Javier", "Luis" };

			Iterar<int>(numbers);

			Iterar<string>(names);
		}

		public static void Iterar<T>(IEnumerable<T> enumerable) {

			foreach (var item in enumerable)
			{
				Console.WriteLine(item);
			}

		}
	}
}

