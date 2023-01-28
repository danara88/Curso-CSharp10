namespace _09_Modulo_Genericos.Codigo
{
	public class BRestriccionesGenericos
	{
		public static void CodigoDelCurso()
		{
			// int is a struct
			int[] years = { 2018, 2019, 2020, 2021 };

			// string is a class
			string[] countries = { "EUA", "Mexico", "Colombia", "Canada" };

			// DateTime is a struct
			DateTime[] dates = { DateTime.Now, DateTime.Today };

			// Will accept dates because it is a struct
			GetLengthOnlyStructs(dates);

			// This array accepts string items and null items
			string?[] nullableStrings = { "Barcelona", "Mexico City", "LA", null };

			// Will accept countries because these are strings so theese are classes
			GetLengthOnlyClasses(countries);
			GetLengthOnlyClasses(nullableStrings);

            int numbers = new int(); // constructor vacio

        }

        /*
		 * This method only accepts T where T has to be a struct
		 * Data type T has to be a struct
		 */
        public static int GetLengthOnlyStructs<T>(T[] input) where T : struct
		{
			return input.Length;
		}

		/**
		 * Data type T has to be a class
		 */
		public static int GetLengthOnlyClasses<T>(T[] input) where T : class?
		{
			return input.Length;
		}

		/**
		 * Data type T has to be a class and with constructor with not parameters
		 */
        public static int GetLengthOnlyClassesWith2Conditions<T>(T[] input) where T : class, new()
        {
            return input.Length;
        }

        /**
		 * Data type T has to be a constructor with not parameters
		 */
        public int GetLengthUsingTWithConstructor<T>(T[] input) where T : new()
		{
			return input.Length;
		}
	}

}

