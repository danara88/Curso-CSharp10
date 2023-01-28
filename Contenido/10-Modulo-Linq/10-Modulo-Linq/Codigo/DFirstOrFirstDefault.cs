using System;
namespace _10_Modulo_Linq.Codigo
{
	public class DFirstOrFirstDefault
	{
		public static void CodigoDelCurso()
		{
            // Colección de personas
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
                new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
            };

            var primeraPersona = personas.First();

            var primeraPersona_2 = personas.FirstOrDefault();

            Console.WriteLine();

            // Colección vacía

            var paises = new List<string>();

            //var pais = paises.First();

            var pais_2 = paises.FirstOrDefault();

            Console.WriteLine();

            // Agregando filtros

            var primeraPersonaMenorA25 = personas.First(p => p.Edad <= 25); // El primer registro que cumpla la condición

            var primeraPersonaMayorA100 = personas.FirstOrDefault(p => p.Edad >= 100);

            if(primeraPersonaMayorA100 is null)
            {
                Console.WriteLine("No hay una persona mayor a 100");
            }

            // Combinar metodos de LINQ
            // Aqui se está usando la ejecución diferida, por que primero puedo aplicar el Where y después el FirstOrDefault
            var primeraPersonaMayorA60 = personas.Where(p => p.Edad >= 25).FirstOrDefault();

        }
    }
}

