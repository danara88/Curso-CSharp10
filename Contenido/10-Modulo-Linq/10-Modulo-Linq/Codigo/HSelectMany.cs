using System;
namespace _10_Modulo_Linq.Codigo
{
	/**
	 * SelectMany: Es una funcion que nos ayuda a aplanar una coleccion para no tener una coleccion
	 * de colecciones.
	 * 
	 */
	public class HSelectMany
	{
		public static void CodigoDelCurso()
		{
            var personas = new List<PersonaV2>()
			{
				new PersonaV2 { Nombre = "Eduardo", Telefonos = { "123-456", "789-852" } },
				new PersonaV2 { Nombre = "Nidia", Telefonos = { "998-478", "568-222" } },
				new PersonaV2 { Nombre = "Alejandro", Telefonos = { "712-132" } },
				new PersonaV2 { Nombre = "Valentina" }
			};

			// Ejemplo 1: Seleccionar telefonos sin personas
			var telefonos = personas.SelectMany(p => p.Telefonos).ToList();

			// Ejemplo 2: Entendiendo SelectMany con dos colecciones diferentes
			int[] numeros = { 1, 2, 3 }; // Cada persona relacionada a cada numero

			var personasYNumeros = personas.SelectMany(p => numeros, (persona, numero) => new
			{
				Persona = persona,
				Numero = numero
			});

			foreach (var item in personasYNumeros)
			{
				Console.WriteLine($"{item.Persona.Nombre} - {item.Numero}");
			}

			// Ejemplo 3: personas y telefonos
			var personasYTelefonos = personas.SelectMany(p => p.Telefonos, (persona, telefono) => new
			{
				Persona = persona,
				Telefono = telefono
			});

            foreach (var item in personasYTelefonos)
            {
                Console.WriteLine($"{item.Persona.Nombre} - {item.Telefono}");
            }

            Console.WriteLine();
        }
	}

	public class PersonaV2
	{
		public string Nombre { get; set; } = null!;

		public List<string> Telefonos = new List<string>();
    }
}

