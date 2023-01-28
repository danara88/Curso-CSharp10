using System;
namespace _09_Modulo_Genericos.Codigo
{
	/*
	 * Comparaciones personalizadas:
	 * 
	 * IComparable: Se implementa en la clase en donde queremos realizar comparaciones.
	 * 
	 * IComparer: Para crear una clase a parte para hacer las comparaciones.
	 * 
	 * Estos nos son utiles cuando deseamos ordenar un conjunto de elementos.
	 * 
	 */
	public class GComparacionesPersonalizadas
	{
		public static void CodigoDelCurso()
		{
			var claudia = new Person() { Age = 20, Name = "Claudia" };

			var pedro = new Person() { Age = 21, Name = "Pedro" };

			var compare = pedro.CompareTo(claudia); // 1 significa que pedro es mayor a claudia

			Console.WriteLine(compare);

			var persons = new List<Person>()
			{
				new Person(){ Name = "Gilberto", Age = 46 },
                new Person(){ Name = "Agustin", Age = 28 },
                new Person(){ Name = "Javier", Age = 37 }
            };

            // Una vez llame al Sort(), se ejecuta el algoritmo implementado por IComparable
            persons.Sort();

			Console.WriteLine("Ordenado por edad");

			foreach (var person in persons)
			{
				Console.WriteLine($"- {person.Name} Age: {person.Age}");
			}

			// Usando comparador personalizado
			persons.Sort(new ComparadorPersonasPorNombre());

            Console.WriteLine("Ordenado por nombre");

            foreach (var person in persons)
            {
                Console.WriteLine($"- {person.Name} Age: {person.Age}");
            }
        }
	}

	public class Person : IComparable<Person>
	{
		public string? Name { get; set; }

		public int Age { get; set; }

		// Si retorna un valor menor a 0 significa que esta clase Persona es menor que "otro"
		// Si retorna un valor mayor a 0 quiere decir que "otro" es mayor a esta clase "Persona".
        public int CompareTo(Person? other)
        {
			if(other is null)
			{
				throw new ArgumentNullException(nameof(other));
			}

			// Si retornma menor a 0, significa que la persona actual va primero.
			// Si retorna mayor a 0, significa que la persona actual va en segundo.
			// Si retorna igual a 0, significa que ambas tienen el mismo orden
			return Age - other.Age;
        }
    }

    public class ComparadorPersonasPorNombre : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            if(x is null || y is null)
			{
				throw new NullReferenceException();
			}

			return string.Compare(x.Name, y.Name);
        }
    }
}

