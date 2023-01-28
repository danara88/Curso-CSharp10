namespace _09_Modulo_Genericos.Codigo
{
    /**
	 * 
	 * ¿Qué son los genéricos?
	 * 
	 * Los genéricos son una manera de cambiar dinamicamente el tipo de dato que recibe una función o método.
	 * 
	 */
    public class AIntroduccionGenericos
	{
		public static void CodigoDelCurso()
		{
			int[] numeros = { 1, 2, 3, 4, 5 };

			string[] nombres = { "Daniel", "Javier", "Alonso" };

			DateTime[] fechas = { DateTime.Now, DateTime.Today };

			Console.WriteLine("Usando genericos: " + CalcularLongitudArreglo<int>(numeros));

            Console.WriteLine("Usando genericos: " + CalcularLongitudArreglo(nombres));

            Console.WriteLine("Usando genericos: " + CalcularLongitudArreglo(fechas));

			Console.WriteLine("Primer elemento del arreglo: " + PrimerElementoArreglo(numeros));

            Console.WriteLine("Primer elemento del arreglo: " + PrimerElementoArreglo(nombres));

            Console.WriteLine("Primer elemento del arreglo: " + PrimerElementoArreglo(fechas));

        }

		/// <summary>
		/// Podemos usar los genericos para los parametros de un método
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="arreglo"></param>
		/// <returns></returns>
        public static int CalcularLongitudArreglo<T>(T[] arreglo)
		{
			return arreglo.Length;
		}

		/// <summary>
		/// Podemos usar los genéricos como retorno de un método
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="arreglo"></param>
		/// <returns></returns>
		public static T? PrimerElementoArreglo<T>(T[] arreglo)
		{
			if(arreglo.Length == 0)
			{
				return default;
			}
			return arreglo[0];
		}
	}

	public interface IUtilidadesArreglos<T>
	{
		int CalcularLongitudArreglo(T[] arreglo);

		T? PrimerElementoArreglo(T[] arreglo);
    }

	/// <summary>
	/// Podemos usar genéricos para clases
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class UtilidadesArreglos<T> : IUtilidadesArreglos<T>
	{
		public int CalcularLongitudArreglo(T[] arreglo)
		{
			return arreglo.Length;
		}

		public T? PrimerElementoArreglo(T[] arreglo)
		{
            if (arreglo.Length == 0)
            {
                return default;
            }

            return arreglo[0];
		}
	}
}

