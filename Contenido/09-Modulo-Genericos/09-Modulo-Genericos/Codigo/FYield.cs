using System;
namespace _09_Modulo_Genericos.Codigo
{
	/**
	 * Yield nos permite insertar contenido a un enumerable. (Elemento por elemento)
	 * Esta se ejecuta de manera peresosa (ejecución diferida)
	 * 
	 */
	public class FYield
	{
		public static void CodigoDelCurso()
		{
			var numbers = new List<int>() { 1, 2, 3 };

			// Estos nos permite convertir cualquier colección a enumerable
			var numbersEnumerable = numbers.AsEnumerable();

			// Creando nuestro propio enumerable
			var numbersEnumerable2 = first3umbers();

			// Cuando accedamos a un item dentro del enumerable, el yield se ejecutará
			int firstNumber = numbersEnumerable2.First();

			// Esto va a crear un nuevo enumerable con los primeros 2 valores, por lo que no va a ejecutar los yield
			var first2Numbers = numbersEnumerable2.Take(2);

			// Aquí si se van a ejecutar los yield
			foreach (var item in first2Numbers)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			// Al Hacer el toList, estas forzando la ejecución de los yields
			var allNumbers = first2Numbers.ToList();
		}

		/*
		 * Creando nuestro propio enumerable.
		 * Los yield se ejecutan de forma peresosa, es decir,
		 * solo cuando usemos dicho valor.
		 */
        public static IEnumerable<int> first3umbers()
		{
			yield return 1;

			yield return 2;

			yield return 3;
		}
    }
}

